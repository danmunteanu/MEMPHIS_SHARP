using Memphis;

namespace MEMPHIS_SHARP
{
    public partial class SelectionPage : CommonForms.ApplicationPageBase
    {
        public TokenEngine? TokenEngine { get; set; } = null;

        public SelectionPage()
        {
            InitializeComponent();
        }

        protected override void OnFilesListSet()
        {
            if (FilesList != null)
            {
                FilesList.SelectionChangedCallback = OnFileSelected;
            }
        }

        private void OnFileSelected(string fullFilePath)
        {
            string fileName = Path.GetFileName(fullFilePath);
            txtOriginalName.Text = fileName;

            if (TokenEngine == null)
                return;

            //  create & split master token
            TokenEngine.SelectMasterToken(fileName);

            graphicsPanel.RootToken = TokenEngine.MasterToken;

            txtRenameTo.Text = TokenEngine.RenameTo;
        }

        private void btnRename_Click(object sender, EventArgs e)
        {

        }
    }
}
