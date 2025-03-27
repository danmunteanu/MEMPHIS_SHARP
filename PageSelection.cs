using Memphis;
using CommonForms;
using Memphis.Actions;
using RealityFrameworks;
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

            UpdateUI();

            graphicsPanel.SelectionChanged = this.OnSelectionChanged;
        }

        public override void UpdateUI()
        {
            bool haveSelection = mEngine?.MasterToken != null;
            
            btnRename.Enabled = haveSelection;
            selectionDetails.Enabled = haveSelection;
            txtSeparators.Enabled = haveSelection;
        }

        private void OnEngineSet()
        {
            if (mEngine == null)
                return;

            //  pass the engine reference to all components
            compTransforms.TransformsContainer = mEngine;
            graphicsPanel.Engine = mEngine;

            //  load settings from Engine
            txtSeparators.Text = mEngine.DefaultSeparators;

            var t = new Transform<Token>(null, new ActionInsertText());
            mEngine.AddTransform(t);

            compTransforms.Reload();
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
                return;

            string fileName = Path.GetFileName(fullFilePath);
            txtOriginalName.Text = fileName;

            if (mEngine == null)
                return;

            //  create & split master token
            mEngine.SelectMasterToken(fileName);

            graphicsPanel.RootToken = mEngine.MasterToken;

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

        private void btnRename_Click(object sender, EventArgs e)
        {
            
        }
    }
}
