using Memphis;
using CommonForms;
using Memphis.Actions;
using RealityFrameworks;
using Memphis.Conditions;

namespace MEMPHIS_SHARP
{
    public partial class PageSelection : ApplicationPageBase
    {
        private MemphisEngine? mEngine = null;
                
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

            scenePainter.SelectionChanged = this.OnSelectionChanged;

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
            compTransforms.TransformsContainer = mEngine;
            //graphicsPanel.Engine = mEngine;

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

        private void btnRename_Click(object sender, EventArgs e)
        {
            
        }
    }
}
