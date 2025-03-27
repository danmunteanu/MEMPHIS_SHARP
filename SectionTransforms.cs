using CommonForms.Components;
using Memphis;
using RealityFrameworks;

namespace MEMPHIS_SHARP
{
    public partial class SectionTransforms : UserControl
    {
        private TransformsContainer<Token>? mTransformsContainer = null;

        private DialogSelectTransform<Token> mDlgTrans = new();

        public TransformsContainer<Token>? TransformsContainer
        {
            get { return mTransformsContainer; }
            set
            {
                mTransformsContainer = value;
                
                OnContainerSet();
            }
        }

        public SectionTransforms()
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
            bool haveTransforms = mTransformsContainer?.Transforms.Count >= 0;
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
            if (mTransformsContainer == null)
                return;

            lstTransforms.Items.Clear();

            //  load the transforms from the container
            foreach (var tr in mTransformsContainer.Transforms)
            {
                lstTransforms.Items.Add(tr.Description);
            }

            LoadNames();

            UpdateUI();
        }

        public void LoadNames()
        {
            //  LOAD NAMES
            List<string> mConditionNames = new();
            List<string> mActionNames = new();

            // Load Condition names
            for (int idx = 0; idx < TokenConditionFactory.Count; ++idx)
                mConditionNames.Add(TokenConditionFactory.GetNameAt(idx));

            // Load Action names
            for (int idx = 0; idx < TokenActionFactory.Count; ++idx)
                mActionNames.Add(TokenActionFactory.GetNameAt(idx));

            mDlgTrans.LoadConditionNames(mConditionNames);
            mDlgTrans.LoadActionNames(mActionNames);
        }

        private void OnEditClick()
        {
            int idx = lstTransforms.SelectedIndex;

            if (idx == -1)
                return;

            if (mTransformsContainer == null)
                return;

            mDlgTrans.LoadState(DialogSelectTransform<Token>.EditorState.Edit, mTransformsContainer.GetTransformAt(idx));
            mDlgTrans.ShowDialog(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //  Display add transform dialog
            mDlgTrans.LoadState(DialogSelectTransform<Token>.EditorState.Add);
            mDlgTrans.ShowDialog(this);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OnEditClick();
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

            OnEditClick();
        }
    }
}
