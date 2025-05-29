using Memphis;
using CommonForms;
using CommonForms.Components;

namespace MEMPHIS_SHARP
{
    public partial class PageSelection : ApplicationPageBase
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

            scenePainter.SelectionChanged = this.OnTokenSelectionChanged;
            selectionDetails.TokenChanged = OnTokenChanged;

            UpdateUI();
        }

        public override void UpdateUI()
        {
            bool haveSelection = mEngine?.RootToken != null;
            
            btnRename.Enabled = haveSelection;
            selectionDetails.Enabled = haveSelection;
            txtSeparators.Enabled = haveSelection;
        }

        private void OnEngineSet()
        {
            if (mEngine == null)
                return;

            scenePainter.Engine = mEngine;

            //  load settings from Engine
            txtSeparators.Text = mEngine.DefaultSeparators;
        }

        protected override void OnFilesListSet()
        {
            if (FilesList != null)
            {
                FilesList.SelectionChanged_Callback = OnFileSelected;
            }
        }

        private void OnFileSelected(string fullFilePath)
        {
            if (string.IsNullOrEmpty(fullFilePath))
            {
                return;
            }

            string fileName = Path.GetFileName(fullFilePath);
            txtOriginalName.Text = fileName;

            if (mEngine == null)
                return;

            //  create & split master token
            mEngine.SelectMasterToken(fileName);

            scenePainter.Engine = mEngine;

            txtRenameTo.Text = mEngine.RenameTo;

            UpdateUI();
        }

        private void OnTokenSelectionChanged()
        {
            if (mEngine == null || mEngine.SelectedSubtoken == null)
                return;

            

            //  Set the token and force reload of selection details
            selectionDetails.Token = mEngine.SelectedSubtoken;

            //  Repaint token
            scenePainter.UpdateNode(mEngine.SelectedSubtoken);

            UpdateUI();
        }

        private void OnTokenChanged(Token token)
        {
            scenePainter.UpdateNode(token);
            
            //  Reconstruct output
            if (Engine != null)
            {
                string renameTo = Engine.ReconstructOutput(Engine.RootToken);
                txtRenameTo.Text = renameTo;
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            
        }
    }
}
