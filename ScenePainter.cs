﻿using Memphis;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;

namespace MEMPHIS_SHARP
{
    public partial class ScenePainter : UserControl
    {
        //  A callback for selection changed
        public delegate void SelectionChanged_Callback();
        public SelectionChanged_Callback? SelectionChanged { get; set; } = null;

        //  Fill Colors
        Microsoft.Msagl.Drawing.Color mSelectedFillColor = Microsoft.Msagl.Drawing.Color.LightGoldenrodYellow;
        Microsoft.Msagl.Drawing.Color mFillColor = Microsoft.Msagl.Drawing.Color.LightBlue;
        
        //  Simple colors
        Microsoft.Msagl.Drawing.Color mSelectedColor = Microsoft.Msagl.Drawing.Color.Gold;
        Microsoft.Msagl.Drawing.Color mColor = Microsoft.Msagl.Drawing.Color.Black;

        //  Engine reference
        private Engine? mEngine = null;
        public Engine? Engine 
        {
            get { return mEngine; }
            set { 
                mEngine = value;
                SetupScene();
            }
        }
        
        //  Graph viewer and actual graph
        private GViewer mViewer = new();
        private Graph mGraph = new();

        //  various
        private bool isDragging = false;
        private Point lastMousePosition;

        public ScenePainter()
        {
            InitializeComponent();

            // Create the viewer control
            mViewer.Dock = DockStyle.Fill;
            mViewer.ToolBarIsVisible = false;
            mViewer.AutoScroll = true;
            this.Controls.Add(mViewer);

            // Subscribe to mouse events
            mViewer.MouseDown += OnMouseDown;
            mViewer.MouseMove += OnMouseMove;
            mViewer.MouseUp += OnMouseUp;
            mViewer.Click += OnGraphClick;

            // Set up the graph
            mGraph.Attr.LayerDirection = LayerDirection.TB; // Top to Bottom layout
            mGraph.Attr.OptimizeLabelPositions = true;
            mViewer.Graph = mGraph;

            SetupScene();
        }

        private void OnGraphClick(object? sender, EventArgs e)
        {
            //  We need an Engine
            if (Engine == null) return;

            //  Have selection?
            var clickedObject = mViewer.SelectedObject;
            if (clickedObject == null) return;

            //  Selection is Node?
            var clickedNode = clickedObject as Node;
            if (clickedNode == null) return;

            // Get the token reference from the node's UserData
            var token = clickedNode.UserData as Token;
            if (token == null) return;

            //  Select token
            Engine.SelectSubtoken(token);

            //  Notify of selection changed
            SelectionChanged?.Invoke();
        }

        private void SetupScene()
        {
            if (mGraph == null)
            {
                System.Diagnostics.Debug.WriteLine("Graph is null!");
                return;
            }

            // Clear the existing graph
            foreach (var node in mGraph.Nodes.ToList())
                mGraph.RemoveNode(node);

            if (Engine?.RootToken == null)
            {
                // Make the graph viewer transparent when no file is selected
                mViewer.BackColor = System.Drawing.Color.Transparent;
                mViewer.Graph = null;
                return;
            }

            // Reset background color when showing graph
            mViewer.BackColor = System.Drawing.SystemColors.Window;
            
            var parent = mGraph.AddNode(Engine.RootToken.Text);
            parent.LabelText = Engine.RootToken.Text;
            parent.UserData = Engine.RootToken;  // Store the root token reference
              SetNodeStyle(parent);

            AddSubtokens(Engine.RootToken, mGraph);

            // Force graph update
            mViewer.Graph = mGraph;
        }

        private void AddSubtokens(Token parent, Graph graph)
        {
            foreach (var token in parent.Subtokens.Reverse())
            {
                //  Add the child node
                var childNode = graph.AddNode(token.Text);
                childNode.LabelText = token.Text;
                childNode.UserData = token;  // Store the token reference
                SetNodeStyle(childNode);

                //  connect child to parent
                graph.AddEdge(parent.Text, token.Text);

                //  add subtokens, if any
                if (token.Subtokens.Count > 0)
                    AddSubtokens(token, graph);
            }
        }

        private void SetNodeStyle(Node node, bool isSelected = false)
        {
            node.Attr.Shape = Shape.Box;

            node.Attr.FillColor = isSelected ? mSelectedFillColor : mFillColor;
            node.Attr.LabelMargin = 5;
            node.Attr.XRadius = 3;
            node.Attr.YRadius = 3;
            node.Label.FontSize = 12;

            // Optional: Change border color for selected nodes
            node.Attr.Color = isSelected ? mSelectedColor : mColor;
            node.Attr.LineWidth = isSelected ? 2 : 1;

            // Add strikethrough for disabled tokens
            if (node.UserData is Token token && token.Discard)
                node.Label.FontStyle = Microsoft.Msagl.Drawing.FontStyle.Strikeout;
            else
                node.Label.FontStyle = Microsoft.Msagl.Drawing.FontStyle.Regular;
        }

        public void UpdateNode(Token token)
        {
            if (mGraph == null || token == null)
                return;
            
            // Find the node with this token
            var node = mGraph.Nodes.FirstOrDefault(n => (n.UserData == token));
            if (node == null) return;

            //  Find the previously selected node and fill it with regular color
            var selectedNode = mGraph.Nodes.FirstOrDefault(n => (n.Attr.FillColor == mSelectedFillColor));
            if (selectedNode != null)
                SetNodeStyle(selectedNode, false);

            // Update the node's text
            node.LabelText = token.Text;

            // Update the node's style based on selection and enabled state
            SetNodeStyle(node, Engine?.SelectedSubtoken == token);

            // Force graph update
            mViewer.Graph = mGraph;
        }

        private void OnMouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                // Check if click is on a node
                var hitObject = mViewer.GetObjectAt(e.X, e.Y);
                if (hitObject is Node)
                {
                    isDragging = false;  // Prevent dragging for nodes
                }
                else
                {
                    isDragging = true;   // Allow dragging for background
                    lastMousePosition = e.Location;
                }
            }
        }

        private void OnMouseMove(object? sender, MouseEventArgs e)
        {
            if (isDragging && e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                // Only handle background dragging
                int deltaX = e.X - lastMousePosition.X;
                int deltaY = e.Y - lastMousePosition.Y;
                mViewer.Pan(deltaX, deltaY);
                lastMousePosition = e.Location;
            }
        }

        private void OnMouseUp(object? sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}
