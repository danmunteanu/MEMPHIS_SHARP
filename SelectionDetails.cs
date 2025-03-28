﻿using Memphis;

namespace MEMPHIS_SHARP
{
    public partial class SelectionDetails : UserControl
    {
        //  remember the token for fast update
        private Token? mToken = null;

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
                grpSelection.Enabled = false;
                txtSelection.Clear();
                chkEnabled.Checked = false;
                txtSeparators.Clear();
                return;
            }

            grpSelection.Enabled = true;
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
            }
        }

        private void txtSelection_KeyDown(object sender, KeyEventArgs e)
        {
            if (mToken == null) 
                return;

            if (e.KeyCode == Keys.Enter)
            {
                mToken.Text = txtSelection.Text;
            }
        }
    }
}
