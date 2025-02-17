namespace Memphis
{
    using RTuple = (Rectangle, string, Color);

    //  SCENE
    public class GraphicsPanel : UserControl
    {
        private Panel drawingPanel;
        private List<(Rectangle rect, string text, Color color)> mRectangles = new();
        private Font font = new Font("Arial", 12);

        private Token? mRootToken = null;

        public Token? RootToken
        {
            get { return mRootToken; }
            set
            {
                mRootToken = value;
                UpdateScene();
            }
        }

        public GraphicsPanel()
        {
            // Setup Form
            this.Text = "Graphics in Panel with Click Handling";
            this.Size = new Size(600, 700);

            // Setup Panel
            drawingPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                BackColor = Color.White
            };
            this.Controls.Add(drawingPanel);

            // Event Handlers
            drawingPanel.Paint += DrawingPanel_Paint;
            drawingPanel.MouseClick += DrawingPanel_MouseClick;

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
                    new RTuple( new Rectangle(x, y, 120, 50),
                    token.Text,
                    Color.YellowGreen )
                );
                x += 100;
            }
            Invalidate();
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
                g.DrawRectangle(Pens.Black, item.rect);
                g.DrawString(item.text, font, Brushes.Black, item.rect.Location);
            }
        }

        private void DrawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < mRectangles.Count; i++)
            {
                if (mRectangles[i].rect.Contains(e.Location))
                {
                    // Change the color of the clicked rectangle
                    mRectangles[i] = (mRectangles[i].rect, mRectangles[i].text, Color.Yellow);
                    drawingPanel.Invalidate(); // Redraw the panel
                    MessageBox.Show($"You clicked {mRectangles[i].text}");
                    break;
                }
            }
        }

    }
}