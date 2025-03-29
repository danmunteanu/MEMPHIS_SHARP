using Memphis;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using System.Linq;

namespace MEMPHIS_SHARP
{
    public partial class ScenePainter : UserControl
    {
        private MemphisEngine? mEngine = null;
        public MemphisEngine? Engine 
        {
            get { return mEngine; }
            set { 
                mEngine = value;
                SetupScene();
            }
        }

        public delegate void SelectionChanged_Callback();

        public SelectionChanged_Callback? SelectionChanged { get; set; } = null;

        private GViewer mViewer = new();
        private Graph mGraph = new();

        public ScenePainter()
        {
            InitializeComponent();

            // Create the viewer control
            mViewer.Dock = DockStyle.Fill;
            mViewer.ToolBarIsVisible = false;
            this.Controls.Add(mViewer);

            // Subscribe to click events
            mViewer.Click += OnGraphClick;

            // Set up the graph
            mGraph.Attr.LayerDirection = LayerDirection.TB; // Top to Bottom layout
            mGraph.Attr.OptimizeLabelPositions = true;
            mViewer.Graph = mGraph;

            SetupScene();
        }

        private void OnGraphClick(object? sender, EventArgs e)
        {
            var clickedObject = mViewer.SelectedObject;
            if (clickedObject == null)
                return;

            var clickedNode = clickedObject as Node;
            if (clickedNode == null)
                return;

            if (Engine == null)
                return;

            // Get the token reference from the node's UserData
            var token = clickedNode.UserData as Token;
            if (token == null)  // If no token in UserData, it's our message node
                return;

            Engine.SelectSubtoken(token);

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
            {
                mGraph.RemoveNode(node);
            }

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
            node.Attr.FillColor = isSelected ? Microsoft.Msagl.Drawing.Color.LightGoldenrodYellow : Microsoft.Msagl.Drawing.Color.LightBlue;
            node.Attr.LabelMargin = 5;
            node.Attr.XRadius = 3;
            node.Attr.YRadius = 3;
            node.Label.FontSize = 12;

            // Optional: Change border color for selected nodes
            node.Attr.Color = isSelected ? Microsoft.Msagl.Drawing.Color.Gold : Microsoft.Msagl.Drawing.Color.Black;
            node.Attr.LineWidth = isSelected ? 2 : 1;
        }
    }
}
