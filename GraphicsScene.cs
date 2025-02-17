namespace Memphis
{
    using TokenRectangleTuple = (Rectangle rect, Token token, Color color);

    //  SCENE
    public class GraphicsScene : UserControl
    {
        private Panel mDrawingPanel;
        private List<TokenRectangleTuple> mRectangles = new();
        private Font font = new Font("Arial", 12);

        private Token? mRootToken = null;

        private Color TokenBorderColor { get; set; } = Color.White;
        private Color TokenColor { get; set; } = Color.DarkGray;
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
            // Setup Form

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
            var subtoken = mRootToken.Subtokens.ElementAt(0);
            foreach (var token in subtoken.Subtokens)
            {
                mRectangles.Add(
                    new TokenRectangleTuple( new Rectangle(x, y, 120, 50),
                    token,
                    TokenColor )
                );
                x += 100;
            }
            mDrawingPanel.Invalidate();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
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
                
                g.DrawRectangle(new Pen(TokenBorderColor), item.rect);
                g.DrawString(item.token.Text, font, Brushes.Black, item.rect.Location);
            }
        }

        private void DrawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < mRectangles.Count; i++)
            {
                if (mRectangles[i].rect.Contains(e.Location))
                {
                    // Change the color of the clicked rectangle
                    mRectangles[i] = (
                        mRectangles[i].rect, 
                        mRectangles[i].token, 
                        Color.Yellow
                    );
                    mDrawingPanel.Invalidate(); // Redraw the panel
                    //MessageBox.Show($"You clicked {mRectangles[i].text}");
                    break;
                }
            }
        }

    }
}