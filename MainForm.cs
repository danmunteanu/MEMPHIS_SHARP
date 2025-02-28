using Memphis;
using CommonForms;
using CommonForms.Components;
using RealityFrameworks;

namespace MEMPHIS_SHARP
{
    public partial class MainForm : Form, IEngineObserver
    {
        private Engine mEngine = new();

        private FilesProcessor? mProcessor = new();

        private FilesListComponent? mFilesList = null;

        public MainForm()
        {
            InitializeComponent();

            this.Text = Locale.APPLICATION_NAME;

            SetupComponents();

            mEngine.AddStringToRemove("(Hydr0.org)");
            mEngine.AddStringToRemove("(by.NecKerM4nn)");

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
                    TopLineHeight = 55, //does not work
                    BottomLineHeight = 75
                },
                FileFilters = Utils.AudioFileExtensions.ToList()
            };
            mFilesList.UpdateList(SelectionMode.One, true);
            Utils.AddUserControlToPanel(panelList, mFilesList);

            //  Connect pageSelection to mFilesList and mEngine
            pageSelection.TokenEngine = mEngine;
            pageSelection.FilesList = mFilesList;
        }

        public void Notify()
        {
            //  engine has changed - reload
        }

    }
}
