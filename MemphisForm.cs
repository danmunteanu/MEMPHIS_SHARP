using Memphis;
using CommonForms;
using CommonForms.Components;
using RealityFrameworks;

namespace MEMPHIS_SHARP
{
    public partial class MemphisForm : Form, IEngineObserver
    {
        private TokenEngine mTokenEngine = new();

        private FilesProcessor? mProcessor = new();

        private FilesListComponent? mFilesList = null;

        public MemphisForm()
        {
            InitializeComponent();

            SetupComponents();

            //mTokenEngine.AddStringToRemove("(Hydr0.org)");

            this.CenterToParent();
        }

        private void SetupComponents()
        {
            //  Create the FilesList
            mFilesList = new()
            {
                //  Adding processor just bc list won't add files without an instance
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

            //  Connect pageSelection to mFilesList
            pageSelection.TokenEngine = mTokenEngine;
            pageSelection.FilesList = mFilesList;
        }

        public void Notify()
        {
            //  engine has changed - reload
        }

    }
}
