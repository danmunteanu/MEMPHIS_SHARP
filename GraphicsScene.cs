using Memphis;

namespace Memphis
{
    using TokenRectangleTuple = (Rectangle rect, Token token, Color color);

    //  SCENE
    public class GraphicsScene : UserControl
    {
        const int KInterTokenHorizontalSpace = 20;
        const int KInterTokenVerticalSpace = 35;

        public MemphisEngine? Engine { get; set; } = null;

        public delegate void Callback_SelectionChanged();
        public Callback_SelectionChanged? SelectionChanged { get; set; } = null;

        private Panel mDrawingPanel;
        private Panel mScrollContainer;

        private List<TokenRectangleTuple> mRectangles = new();
        private int mSelectedIndex = -1;

        private Token? mRootToken = null;

        private Font mFont = new Font("Arial", 12);

        private Color BorderColor { get; set; } = Color.White;

        private Color NormalColor { get; set; } = Color.DarkGray;
        
        private Color SelectionColor { get; set; } = Color.GreenYellow;

        private int mTotalWidth = 0;
        private int mTotalHeight = 0;

        public Token? RootToken
        {
            get { return mRootToken; }
            set
            {
                mRootToken = value;
                UpdateScene();
            }
        }

        public GraphicsScene()
        {
            // Setup Scroll Container
            mScrollContainer = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };
            this.Controls.Add(mScrollContainer);

            // Setup Drawing Panel
            mDrawingPanel = new Panel
            {
                BackColor = Color.White,
                AutoSize = true
            };
            mScrollContainer.Controls.Add(mDrawingPanel);

            // Event Handlers
            mDrawingPanel.Paint += DrawingPanel_Paint;
            mDrawingPanel.MouseClick += DrawingPanel_MouseClick;

            UpdateScene();
        }

        private void ScrollBar_Scroll(object? sender, ScrollEventArgs e)
        {
            mDrawingPanel.Invalidate();
        }

        private void UpdateScene()
        {
            //  rebuild the scene using current root token
            if (mRootToken == null)
                return;
            
            mRectangles.Clear();
            int x = 25;
            int y = 50;
            int w = 0;
            int h = 0;

            ConstructScene(mRootToken, ref x, ref y, ref w, ref h);

            // Update total dimensions
            mTotalWidth = w + 50; // Add padding
            mTotalHeight = h + 50; // Add padding

            // Update drawing panel size
            mDrawingPanel.Size = new Size(mTotalWidth, mTotalHeight);

            mDrawingPanel.Invalidate();
            CallUpdateSelection();
        }

        private void ConstructScene(Token token, 
            ref int orig_x_offset, ref int orig_y_offset, ref int width, ref int height)
        {
            if (Engine == null)
                return;

            bool select = (Engine.SelectedSubtoken == token);
            Color tokenColor = select ? SelectionColor : NormalColor;

            if (token.Subtokens.Count == 0)
            {
                //  construct the rectangle for the subtoken
                Rectangle rect = new Rectangle(orig_x_offset, orig_y_offset, 120, 50);
                mRectangles.Add(new TokenRectangleTuple(rect, token, tokenColor));

                width = rect.Width;
                height = rect.Height;
            }
            else
            {
                //  construct group widget
                Rectangle groupRect = new Rectangle(orig_x_offset, orig_y_offset, 120, 50);
                mRectangles.Add(new TokenRectangleTuple(groupRect, token, tokenColor));

                //  local version
                int x_offset = orig_x_offset;
                int y_offset = orig_y_offset + groupRect.Height + KInterTokenVerticalSpace;
                int subtoken_width = 0;
                int subtoken_height = 0;

                int group_width = 0;
                int max_height = 0;

                //  store positions for connector lines
                Point first_subtoken_pos = new Point();
                Point last_subtoken_pos = new Point();

                //  iterate subtokens
                for (int i = 0; i < token.Subtokens.Count; i++)
                {
                    Token subtoken = token.Subtokens.ElementAt(i);
                    ConstructScene(subtoken, ref x_offset, ref y_offset, ref subtoken_width, ref subtoken_height);

                    //  store first subtoken's pos for connector line
                    if (i == 0)
                    {
                        first_subtoken_pos.X = x_offset + subtoken_width / 2;
                        first_subtoken_pos.Y = y_offset - KInterTokenVerticalSpace / 2;
                    }

                    //  store last subtoken's pos for connector line
                    if (i == token.Subtokens.Count - 1)
                    {
                        last_subtoken_pos.X = x_offset + subtoken_width / 2;
                        last_subtoken_pos.Y = y_offset - KInterTokenVerticalSpace / 2;
                    }

                    //  prepare X for next subtoken
                    x_offset += subtoken_width + KInterTokenHorizontalSpace;

                    group_width += subtoken_width + KInterTokenHorizontalSpace;
                    if (max_height < subtoken_height)
                        max_height = subtoken_height;
                }

                //  added 1 extra inter token space, subtract it if group width is positive
                if (group_width != 0)
                    group_width -= KInterTokenHorizontalSpace;

                //  feedback group dimensions
                width = Math.Max(group_width, groupRect.Width);    //  pick the largest width
                height = groupRect.Height + KInterTokenVerticalSpace + max_height;

                //  center the group
                groupRect.X = orig_x_offset + width / 2 - groupRect.Width / 2;
                mRectangles[mRectangles.Count - 1] = new TokenRectangleTuple(groupRect, token, tokenColor);
            }
        }

        private void DrawingPanel_Paint(object? sender, PaintEventArgs e)
        {
            if (mRectangles == null)
                return;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Draw rectangles with text
            foreach (var item in mRectangles)
            {
                using (Brush brush = new SolidBrush(item.color))
                {
                    g.FillRectangle(brush, item.rect);
                }
                
                g.DrawRectangle(new Pen(BorderColor), item.rect);
                g.DrawString(item.token.Text, mFont, Brushes.Black, item.rect.Location);
            }

            // Draw connecting lines between tokens
            using (Pen linePen = new Pen(Color.Black, 2))
            {
                for (int i = 0; i < mRectangles.Count; i++)
                {
                    var current = mRectangles[i];
                    if (current.token.Subtokens.Count > 0)
                    {
                        // Draw vertical line down from parent
                        Point parentBottom = new Point(
                            current.rect.X + current.rect.Width / 2,
                            current.rect.Y + current.rect.Height
                        );
                        Point parentBottomEnd = new Point(
                            parentBottom.X,
                            parentBottom.Y + KInterTokenVerticalSpace / 2
                        );
                        g.DrawLine(linePen, parentBottom, parentBottomEnd);

                        // Draw horizontal line connecting children
                        if (current.token.Subtokens.Count > 1)
                        {
                            var firstChild = mRectangles.FirstOrDefault(r => r.token == current.token.Subtokens.First());
                            var lastChild = mRectangles.FirstOrDefault(r => r.token == current.token.Subtokens.Last());
                            
                            if (firstChild != default && lastChild != default)
                            {
                                Point lineStart = new Point(
                                    firstChild.rect.X + firstChild.rect.Width / 2,
                                    firstChild.rect.Y - KInterTokenVerticalSpace / 2
                                );
                                Point lineEnd = new Point(
                                    lastChild.rect.X + lastChild.rect.Width / 2,
                                    lastChild.rect.Y - KInterTokenVerticalSpace / 2
                                );
                                g.DrawLine(linePen, lineStart, lineEnd);
                            }
                        }
                    }
                }
            }
        }

        private void DrawingPanel_MouseClick(object? sender, MouseEventArgs e)
        {
            if (Engine == null || mRootToken == null) 
                return;

            for (int i = 0; i < mRectangles.Count; i++)
            {
                if (mRectangles[i].rect.Contains(e.Location))
                {
                    Engine.SelectSubtoken(mRootToken.Subtokens.ElementAt(i));

                    // Change the color of the clicked rectangle
                    mRectangles[i] = (
                        mRectangles[i].rect, 
                        mRectangles[i].token, 
                        SelectionColor
                    );

                    //  deselect previous
                    if (mSelectedIndex != -1 && mSelectedIndex != i)
                    {
                        mRectangles[mSelectedIndex] = (
                            mRectangles[mSelectedIndex].rect,
                            mRectangles[mSelectedIndex].token,
                            NormalColor
                        );
                    }
                    //  update selected index
                    mSelectedIndex = i;

                    CallUpdateSelection();

                    mDrawingPanel.Invalidate(); // Redraw the panel
                    break;
                }
            }
        }

        private void CallUpdateSelection()
        {
            if (SelectionChanged != null)
                SelectionChanged();
        }

    }
}