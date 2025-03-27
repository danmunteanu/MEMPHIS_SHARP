using CommonForms.Components;
using Memphis;

namespace MEMPHIS_SHARP
{
    public partial class ComponentListTransforms : UserControl
    {
        private TransformsContainer? mContainer = null;
        private DialogSelectTransform mDlgTrans = new();

        public TransformsContainer? TransformsContainer
        {
            get { return mContainer; }
            set
            {
                mContainer = value;
                OnContainerSet();
            }
        }

        public ComponentListTransforms()
        {
            InitializeComponent();

            lstTransforms.HorizontalScrollbar = true;

            UpdateUI();
        }

        public void Reload()
        {
            OnContainerSet();
        }

        public void UpdateUI()
        {
            bool haveTransforms = mContainer?.Transforms.Count >= 0;
            bool haveSelection = lstTransforms.SelectedIndex != -1;

            btnAdd.Enabled = true;

            btnEdit.Enabled = haveSelection;
            btnRem.Enabled = haveSelection;
            btnUp.Enabled = haveSelection;
            btnDown.Enabled = haveSelection;

            btnClear.Enabled = haveTransforms;

        }

        public void UpdateLocale()
        {

        }

        private void OnContainerSet()
        {
            if (mContainer == null)
                return;

            lstTransforms.Items.Clear();

            foreach (var tr in mContainer.Transforms)
            {
                lstTransforms.Items.Add(tr.Description);
            }

            UpdateUI();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //  Display add transform dialog
            mDlgTrans.LoadState(DialogSelectTransform.EditorState.Add);
            mDlgTrans.ShowDialog(this);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //  Display edit transform dialog
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            //  Remove transform
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            //  Move up
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            //  Move down
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //  Clear all
        }

        private void lstTransforms_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void lstTransforms_DoubleClick(object sender, EventArgs e)
        {
            //  Display add transform dialog
            
            mDlgTrans.LoadState(DialogSelectTransform.EditorState.Edit);
            mDlgTrans.ShowDialog(this);
        }
    }
}
