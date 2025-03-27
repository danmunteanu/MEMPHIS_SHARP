using Memphis;
using CommonForms;
using CommonForms.Components;
using RealityFrameworks;
using Memphis.Actions;

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

            SetupComponents();

            mEngine.AddStringToRemove("(Hydr0.org)");
            mEngine.AddStringToRemove("(by.NecKerM4nn)");

            CreateDefaultTransforms();

            this.CenterToParent();
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

        public void CreateDefaultTransforms()
        {
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
