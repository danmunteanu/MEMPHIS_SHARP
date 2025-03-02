using Memphis;

namespace MEMPHIS_SHARP
{
    public partial class PageSelection : CommonForms.ApplicationPageBase
    {
        private Engine? mEngine = null;

        public Engine? Engine {
            get => mEngine;
            set
            {
                mEngine = value;
                OnEngineSet();
            }
        }

        public PageSelection()
        {
            InitializeComponent();

            graphicsPanel.SelectionChanged = this.OnSelectionChanged;
        }

        private void OnEngineSet()
        {
            if (mEngine == null)
                return;

            graphicsPanel.Engine = mEngine;

            //  load settings from Engine
            txtSeparators.Text = mEngine.DefaultSeparators;
        }

        protected override void OnFilesListSet()
        {
            if (FilesList != null)
            {
                FilesList.Callback_SelectionChanged = OnFileSelected;
            }
        }

        private void OnFileSelected(string fullFilePath)
        {
            string fileName = Path.GetFileName(fullFilePath);
            txtOriginalName.Text = fileName;

            if (mEngine == null)
                return;

            //  create & split master token
            mEngine.SelectMasterToken(fileName);

            graphicsPanel.RootToken = mEngine.MasterToken;

            txtRenameTo.Text = mEngine.RenameTo;
        }

        private void OnSelectionChanged()
        {
            if (mEngine == null || mEngine.SelectedSubtoken == null)
                return;

            //  load selection details
            selectionDetails.LoadFromToken(mEngine.SelectedSubtoken);
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            
        }
    }
}
