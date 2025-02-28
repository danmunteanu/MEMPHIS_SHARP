using Memphis;

namespace MEMPHIS_SHARP
{
    public partial class SelectionPage : CommonForms.ApplicationPageBase
    {
        private Engine? mEngine = null;

        public Engine? TokenEngine {
            get => mEngine;
            set
            {
                mEngine = value;
                OnEngineSet();
            }
        }

        public SelectionPage()
        {
            InitializeComponent();
        }

        private void OnEngineSet()
        {
            if (mEngine == null)
                return;

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

        private void btnRename_Click(object sender, EventArgs e)
        {

        }
    }
}
