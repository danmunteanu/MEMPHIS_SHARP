using Memphis;

namespace MEMPHIS_SHARP
{
    public partial class SelectionDetails: UserControl
    {
        public void LoadFromToken (Token token)
        {
            if (token == null)
                return;

            txtSelection.Text = token.Text;
            chkEnabled.Checked = token.Enabled;
            txtSeparators.Text = token.Separators;
        }

        public SelectionDetails()
        {
            InitializeComponent();
        }
    }
}
