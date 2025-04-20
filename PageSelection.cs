using Memphis;
using CommonForms;
using CommonForms.Components;

namespace MEMPHIS_SHARP
{
    public partial class PageSelection : ApplicationPageBase
    {
        private MemphisEngine? mEngine = null;

        private TransformsComponent<Token> mTransformsComp;
                
        public MemphisEngine? Engine {
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

            mTransformsComp = new() 
            {
            };
            Utils.AddUserControlToPanel(panelTransforms, mTransformsComp);

            scenePainter.SelectionChanged = this.OnSelectionChanged;
            selectionDetails.TokenChanged = OnTokenTextChanged;

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

            //  pass the engine reference to all components
            mTransformsComp.TransformsContainer = mEngine;
            
            //  load the names
            mTransformsComp.LoadConditionNames(TokenConditionFactory.CreatorKeys);
            mTransformsComp.LoadActionNames(TokenActionFactory.CreatorKeys);

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

        private void OnSelectionChanged()
        {
            if (mEngine == null || mEngine.SelectedSubtoken == null)
                return;

            //  setting the token loads selection details
            selectionDetails.Token = mEngine.SelectedSubtoken;

            UpdateUI();
        }

        private void OnTokenTextChanged(Token token)
        {
            scenePainter.UpdateNode(token);
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            
        }
    }
}
