using CommonForms.Components;
using Memphis;
using RealityFrameworks;
using SharpCompress;

namespace MEMPHIS_SHARP
{
    public class TransformsList<T> : TransformsListUI
    {
        private TransformsContainer<T>? mTransformsContainer = null;

        private DialogSelectTransform<T> mDlgTrans = new();

        public TransformsContainer<T>? TransformsContainer
        {
            get { return mTransformsContainer; }
            set
            {
                mTransformsContainer = value;
                
                OnContainerSet();
            }
        }

        public void Reload()
        {
            OnContainerSet();
        }

        public override void UpdateUI()
        {
            bool haveTransforms = mTransformsContainer?.Transforms.Count >= 0;
            bool haveSelection = lstTransforms.SelectedIndex != -1;
            Transform<T>? tr = null;
            if (haveSelection)
                tr = mTransformsContainer?.GetTransformAt(lstTransforms.SelectedIndex);

            btnAdd.Enabled = true;

            btnEdit.Enabled = haveSelection;
            
            btnToggle.Enabled = haveSelection;
            if (tr != null)
                btnToggle.Text = tr.Enabled ? "■" : "●";

            btnLink.Enabled = haveSelection;
            if (tr != null)
                btnLink.Text = tr.UseLastOutput ? "🧷" : "🔗";

            btnRem.Enabled = haveSelection;
            btnUp.Enabled = haveSelection;
            btnDown.Enabled = haveSelection;
            
            btnTemplate.Enabled = true;

            btnClear.Enabled = haveTransforms;

        }

        public void UpdateLocale()
        {

        }

        private void OnContainerSet()
        {
            lstTransforms.Items.Clear();

            if (mTransformsContainer == null)
                return;

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

        public override void OnAdd()
        {
            //  Display add transform dialog
            mDlgTrans.LoadState(DialogSelectTransform<Token>.EditorState.Add);
            mDlgTrans.ShowDialog(this);
        }

        public override void OnEdit()
        {
            int idx = lstTransforms.SelectedIndex;

            if (idx == -1)
                return;

            if (mTransformsContainer == null)
                return;

            mDlgTrans.LoadState(DialogSelectTransform<T>.EditorState.Edit, mTransformsContainer.GetTransformAt(idx));
            mDlgTrans.ShowDialog(this);

        }

        public override void OnToggle()
        {
            Transform<T>? tr = null;
            if (lstTransforms.SelectedIndex != -1)
                tr = mTransformsContainer?.GetTransformAt(lstTransforms.SelectedIndex);

            if (tr != null)
            {
                tr.Enabled = !tr.Enabled;
                btnToggle.Text = tr.Enabled ? "■" : "●";
            }
        }

        public override void OnLink()
        {
            Transform<T>? tr = null;
            if (lstTransforms.SelectedIndex != -1)
                tr = mTransformsContainer?.GetTransformAt(lstTransforms.SelectedIndex);

            if (tr != null)
            {
                tr.UseLastOutput = !tr.UseLastOutput;
                btnLink.Text = tr.UseLastOutput ? "🧷" : "🔗";
            }
        }

        public override void OnRemove()
        {

        }

        public override void OnUp()
        {

        }

        public override void OnDown()
        {

        }

        public override void OnTemplate()
        {

        }

        public override void OnClear()
        {
            mTransformsContainer?.ClearTransforms();
            Reload();
        }

    }

    public abstract partial class TransformsListUI : UserControl
    {
        public TransformsListUI()
        {
            InitializeComponent();

            lstTransforms.HorizontalScrollbar = true;

            UpdateUI();
        }

        //  Event handlers, implemented in generic class wrapper
        public abstract void OnAdd();
        public abstract void OnEdit();
        public abstract void OnToggle();
        public abstract void OnLink();
        public abstract void OnRemove();
        public abstract void OnUp();
        public abstract void OnDown();
        public abstract void OnTemplate();
        public abstract void OnClear();

        //  Update UI, reloads the state
        public abstract void UpdateUI();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OnAdd();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OnEdit();
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            OnRemove();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            OnUp();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            OnDown();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            OnClear();
        }

        private void lstTransforms_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void lstTransforms_DoubleClick(object sender, EventArgs e)
        {
            OnEdit();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            OnToggle();
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            OnLink();
        }

        private void btnTemplate_Click(object sender, EventArgs e)
        {
            OnTemplate();
        }
    }
}
