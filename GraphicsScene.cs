namespace Memphis
{
    using TokenRectangleTuple = (Rectangle rect, Token token, Color color);

    //  SCENE
    public class GraphicsScene : UserControl
    {
        public Engine? Engine { get; set; } = null;

        public delegate void Callback_SelectionChanged();
        public Callback_SelectionChanged? SelectionChanged { get; set; } = null;

        private Panel mDrawingPanel;

        private List<TokenRectangleTuple> mRectangles = new();
        private int mSelectedIndex = -1;

        private Token? mRootToken = null;

        private Font mFont = new Font("Arial", 12);

        private Color BorderColor { get; set; } = Color.White;

        private Color NormalColor { get; set; } = Color.DarkGray;
        
        private Color SelectionColor { get; set; } = Color.GreenYellow;

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
            // Setup Panel
            mDrawingPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            this.Controls.Add(mDrawingPanel);

            // Event Handlers
            mDrawingPanel.Paint += DrawingPanel_Paint;
            mDrawingPanel.MouseClick += DrawingPanel_MouseClick;

            UpdateScene();
        }

        private void UpdateScene()
        {
            //  rebuild the scene using current root token
            if (mRootToken == null)
                return;
            
            mRectangles.Clear();
            int x = 25;
            int y = 50;
            for (int idx = 0; idx < mRootToken.Subtokens.Count; idx++) 
            {
                Token token = mRootToken.Subtokens.ElementAt(idx);
                mRectangles.Add(
                    new TokenRectangleTuple(new Rectangle(x, y, 120, 50),
                    token,
                    NormalColor)
                );
                x += 100;
            }

            mDrawingPanel.Invalidate();

            CallUpdateSelection();
        }

        private void DrawingPanel_Paint(object? sender, PaintEventArgs e)
        {
            if (mRectangles == null)
                return;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Draw connections (lines between rectangles)
            //using (Pen linePen = new Pen(Color.Black, 2))
            //{
            //    g.DrawLine(linePen, GetCenter(mRectangles[0].rect), GetCenter(mRectangles[1].rect));
            //    g.DrawLine(linePen, GetCenter(mRectangles[1].rect), GetCenter(mRectangles[2].rect));
            //}

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