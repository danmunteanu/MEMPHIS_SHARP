using Memphis;

namespace MEMPHIS_SHARP
{
    public partial class SelectionDetails : UserControl
    {
        //  remember the token for fast update
        private Token? mToken = null;

        public delegate void TokenTextChanged_Callback(Token token);
        public TokenTextChanged_Callback? TokenChanged { get; set; }

        public Token? Token
        {
            get
            {
                return mToken;
            }
            set
            {
                mToken = value;
                LoadToken(mToken);
            }
        }

        public void LoadToken(Token? token)
        {
            if (token == null)
            {
                //grpSelection.Enabled = false;
                txtSelection.Clear();
                chkEnabled.Checked = false;
                txtSeparators.Clear();
                return;
            }

            //grpSelection.Enabled = true;
            txtSelection.Text = token.Text;
            chkEnabled.Checked = token.Enabled;
            txtSeparators.Text = token.Separators;

            this.Enabled = token != null;
        }

        public SelectionDetails()
        {
            InitializeComponent();
        }

        private void chkEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (mToken != null)
            {
                mToken.Enabled = chkEnabled.Checked;
                TokenChanged?.Invoke(mToken);
            }
        }

        private void txtSelection_KeyDown(object sender, KeyEventArgs e)
        {
            if (mToken == null)
                return;

            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtSelection.Text))
                {
                    // TODO: Show error message or handle empty text case
                    return;
                }

                mToken.Text = txtSelection.Text;
                TokenChanged?.Invoke(mToken);
            }
        }
    }
}
