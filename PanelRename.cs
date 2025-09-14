using Memphis;

namespace MEMPHIS_SHARP
{
    public partial class PanelRename : UserControl
    {
        //  reference to engine
        Engine? mEngine;

        public Engine? Engine {
            get { return mEngine; } 
            set { 
                mEngine = value;
                UpdateUI();
            }
        }

        public PanelRename()
        {
            InitializeComponent();
        }

        public void UpdateUI()
        {
            if (mEngine == null)
                return;

            txtSeparators.Text = mEngine.DefaultSeparators;
            txtOriginalName.Text = mEngine.RootToken?.Text;
            txtRenameTo.Text = mEngine.RenameTo;
            btnRename.Enabled = mEngine.RenameTo != null;
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (mEngine == null)
                return;

            MessageBox.Show("Rename not implemented");
        }
    }
}
