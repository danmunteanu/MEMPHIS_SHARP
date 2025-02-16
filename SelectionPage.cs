using Memphis;

namespace MEMPHIS_SHARP
{
    public partial class SelectionPage: CommonForms.ApplicationPageBase
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

            TokenEngine.SetMasterToken(fileName);

            txtRenameTo.Text = TokenEngine.RenameTo;
        }
    }
}
