using Memphis;
using CommonForms;
using CommonForms.Components;
using RealityFrameworks;
using Memphis.Actions;
using Memphis.Conditions;
using MEMPHIS_SHARP.ConditionEditors;
using MEMPHIS_SHARP.ActionEditors;

namespace MEMPHIS_SHARP
{
    public partial class FormNew: Form
    {
        private Engine mEngine = new();
        private FilesProcessor? mProcessor = new();
        private FilesList? mFilesList = null;
        private TransformsList<Token>? mTransformsComponent = null;

        public FormNew()
        {
            InitializeComponent();

            SetupEngine();
            RegisterCreators();
            SetupComponents();

            scenePainter.Engine = mEngine;
            scenePainter.SelectionChanged = this.OnTokenSelectionChanged;

            selectionDetails.TokenChanged = OnTokenChanged;

            this.Text = Locale.APPLICATION_NAME;
            this.CenterToParent();
        }

        private void RegisterCreators()
        {
            //  Register Condition Creators
            TokenConditionFactory.Register(typeof(ConditionAlways).Name, () => new ConditionAlways());
            TokenConditionFactory.Register(typeof(ConditionEquals).Name, () => new ConditionEquals());
            TokenConditionFactory.Register(typeof(ConditionIsNumeric).Name, () => new ConditionIsNumeric());
            TokenConditionFactory.Register(typeof(ConditionIsRoot).Name, () => new ConditionIsRoot(mEngine));

            //  Register Action Creators
            TokenActionFactory.Register(typeof(ActionChangeCase).Name, () => new ActionChangeCase(mEngine));
            TokenActionFactory.Register(typeof(ActionEnableDisable).Name, () => new ActionEnableDisable(mEngine));
            TokenActionFactory.Register(typeof(ActionInsertText).Name, () => new ActionInsertText());
            TokenActionFactory.Register(typeof(ActionReplaceText).Name, () => new ActionReplaceText(mEngine));
            TokenActionFactory.Register(typeof(ActionSetSeparators).Name, () => new ActionSetSeparators(mEngine));

            //  Register Condition Editor Creators
            TokenEditorFactory.Register(typeof(ConditionAlways).Name, () => new EditorAlways());
            TokenEditorFactory.Register(typeof(ConditionEquals).Name, () => new EditorEquals());
            TokenEditorFactory.Register(typeof(ConditionIsNumeric).Name, () => new EditorIsNumeric());
            TokenEditorFactory.Register(typeof(ConditionIsRoot).Name, () => new EditorIsRoot());

            //  Register Action Editor Creators
            TokenEditorFactory.Register(typeof(ActionChangeCase).Name, () => new EditorChangeCase());
            TokenEditorFactory.Register(typeof(ActionEnableDisable).Name, () => new EditorEnableDisable());
            TokenEditorFactory.Register(typeof(ActionReplaceText).Name, () => new EditorReplaceText());
            TokenEditorFactory.Register(typeof(ActionInsertText).Name, () => new EditorInsertText());
            TokenEditorFactory.Register(typeof(ActionSetSeparators).Name, () => new EditorSetSeparators());
        }

        private void SetupComponents()
        {
            //  Create Files List
            mFilesList = new()
            {
                //  Adding processor just bc list won't add files without an instance of it
                //  unused, for now
                Processor = mProcessor,

                Settings = new FilesList.FilesListSettings()
                {
                    UseProgressBar = false,
                    TopLabel = Locale.LIST_TOP_LABEL,
                    LabelLineHeight = 45,
                    ButtonLineHeight = 50,
                    ParseSubfolders = true,
                    ButtonRowTop = false,   //  move buttons to top?
                },
                FileFilters = Utils.AudioFileExtensions.ToList()
            };
            mFilesList.UpdateList(SelectionMode.One, true);
            mFilesList.SelectionChanged_Callback = OnFileSelected;
            Utils.AddUserControlToPanel(panelList, mFilesList);
            panelList.Padding = new Padding(10, 0, 10, 10);


            //  Connect pageSelection to mEngine and mFilesList
            //pageSelection.Engine = mEngine;
            //pageSelection.FilesList = mFilesList;


            //  Transforms Component
            mTransformsComponent = new()
            {
                TransformsContainer = mEngine
            };
            mTransformsComponent.LoadConditionNames(TokenConditionFactory.CreatorKeys);
            mTransformsComponent.LoadActionNames(TokenActionFactory.CreatorKeys);
            Utils.AddUserControlToPanel(panelTransforms, mTransformsComponent);
        }

        private void UpdateUI()
        {

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
            if (mEngine != null)
            {
                string renameTo = mEngine.ReconstructOutput(mEngine.RootToken);
                txtRenameTo.Text = renameTo;
            }
        }

        public void SetupEngine()
        {
            //  Strings to remove - Add these to Settings
            mEngine.AddStringToRemove("(Hydr0.org)");
            mEngine.AddStringToRemove("(by.NecKerM4nn)");

            Transform<Token> tr = new(
                new ConditionAlways(),
                new ActionInsertText()
            );
            mEngine.AddTransform(tr);

            tr = new(
                new ConditionAlways(),
                new ActionChangeCase(mEngine, true, false, true)
            );
            mEngine.AddTransform(tr);
        }

    }
}
