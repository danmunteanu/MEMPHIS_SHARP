namespace MEMPHIS_SHARP
{
    public partial class PanelRename: UserControl
    {
        public PanelRename()
        {
            InitializeComponent();
        }

        public string OriginalName
        {
            get
            {
                return txtOriginalName.Text;
            }
            set
            {
                txtOriginalName.Text = value;
            }
        }

        public string RenameTo { 
            get
            {
                return txtRenameTo.Text;
            }
            set
            {
                txtRenameTo.Text = value;
            }
        }
    }
}
