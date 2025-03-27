using Memphis;
using CommonForms;
using CommonForms.Components;
using RealityFrameworks;
using Memphis.Actions;
using Memphis.Conditions;
using RealityFrameworks.Conditions;

namespace MEMPHIS_SHARP
{
    public partial class MainForm : Form, IEngineObserver
    {
        private MemphisEngine mEngine = new();

        private FilesProcessor? mProcessor = new();

        private FilesListComponent? mFilesList = null;

        public MainForm()
        {
            InitializeComponent();

            this.Text = Locale.APPLICATION_NAME;

            RegisterCreators();
            SetupEngine();

            SetupComponents();

            mEngine.AddStringToRemove("(Hydr0.org)");
            mEngine.AddStringToRemove("(by.NecKerM4nn)");

            SetupEngine();

            this.CenterToParent();
        }

        private void RegisterCreators()
        {
            //  REGISTER CONDITION Creators
            TokenConditionFactory.Register(typeof(ConditionAlways).Name, () => new ConditionAlways());
            TokenConditionFactory.Register(typeof(ConditionEquals).Name, () => new ConditionEquals());
            TokenConditionFactory.Register(typeof(ConditionIsFolder).Name, () => new ConditionIsNumeric());
            TokenConditionFactory.Register(typeof(ConditionIsRoot).Name, () => new ConditionIsRoot(mEngine));

            TokenActionFactory.Register(typeof(ActionChangeCase).Name, () => new ActionChangeCase(mEngine));
            TokenActionFactory.Register(typeof(ActionEnableDisable).Name, () => new ActionEnableDisable(mEngine));
            TokenActionFactory.Register(typeof(ActionInsertText).Name, () => new ActionInsertText());
            TokenActionFactory.Register(typeof(ActionReplaceText).Name, () => new ActionReplaceText(mEngine));
            TokenActionFactory.Register(typeof(ActionSetSeparators).Name, () => new ActionSetSeparators(mEngine));
        }

        private void SetupComponents()
        {
            //  Create the FilesList
            mFilesList = new()
            {
                //  Adding processor just bc list won't add files without an instance of it
                //  unused, for now
                Processor = mProcessor,

                Settings = new FilesListComponent.ListSettings()
                {
                    UseProgressBar = false,
                    TopLabel = Locale.LIST_TOP_LABEL,
                    TopLineHeight = 60,
                    BottomLineHeight = 60,
                    ParseSubfolders = true,
                },
                FileFilters = Utils.AudioFileExtensions.ToList()
            };
            mFilesList.UpdateList(SelectionMode.One, true);
            Utils.AddUserControlToPanel(panelList, mFilesList);
            panelList.Padding = new Padding(10, 0, 10, 10);

            //  Connect pageSelection to mFilesList and mEngine
            pageSelection.Engine = mEngine;
            pageSelection.FilesList = mFilesList;
        }

        public void Notify()
        {
            //  engine has changed - reload
        }

        public void SetupEngine()
        {
            Transform<Token> t = new (new ConditionAlways(), new ActionInsertText());
            mEngine.AddTransform(t);

            t = new(new ConditionAlways(), new ActionChangeCase(mEngine, true, false, true));
            mEngine.AddTransform(t);

            t = new(new ConditionAlways(), new ActionEnableDisable(mEngine, true));
            mEngine.AddTransform(t);

            //mEngine.ApplyTransformsToToken(null);



            //  Upcase all words
            //mEngine.AddTransform(
            //new ConditionAlways(),
            //new ActionChangeCase(mEngine, true, false, true)
            //);

            //  Discard numeric tokens

            //  lowcase extensions

            //  upcase several strings

            //  add dot after various tokens
        }

    }
}
