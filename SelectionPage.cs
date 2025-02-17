using Memphis;

namespace MEMPHIS_SHARP
{
    public partial class SelectionPage : CommonForms.ApplicationPageBase
    {
        TokenEngine? mTokenEngine = null;

        public TokenEngine? TokenEngine {
            get => mTokenEngine;
            set
            {
                mTokenEngine = value;
                OnEngineSet();
            }
        }

        public SelectionPage()
        {
            InitializeComponent();
        }

        private void OnEngineSet()
        {
            if (mTokenEngine == null)
                return;

            txtSeparators.Text = mTokenEngine.DefaultSeparators;
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

            if (mTokenEngine == null)
                return;

            //  create & split master token
            mTokenEngine.SelectMasterToken(fileName);

            graphicsPanel.RootToken = mTokenEngine.MasterToken;

            txtRenameTo.Text = mTokenEngine.RenameTo;
        }

        private void btnRename_Click(object sender, EventArgs e)
        {

        }
    }
}
