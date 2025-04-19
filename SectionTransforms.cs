using CommonForms.Components;
using Memphis;
using RealityFrameworks;

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
                
                OnTransformsContainerSet();
            }
        }

        public TransformsList()
        {
            //  Add click handlers
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnRem.Click += btnRem_Click;
            btnToggle.Click += btnToggle_Click;
            btnUp.Click += btnUp_Click;
            btnDown.Click += btnDown_Click;
            btnTemplate.Click += btnTemplate_Click;
            btnClear.Click += btnClear_Click;

            //  List setup
            lstTransforms.HorizontalScrollbar = true;
            lstTransforms.DrawItem += lstTransforms_DrawItem;
            lstTransforms.DrawMode = DrawMode.OwnerDrawFixed;
            lstTransforms.DoubleClick += lstTransforms_DoubleClick;
            lstTransforms.SelectedIndexChanged += lstTransforms_SelectedIndexChanged;

            UpdateUI();
        }

        public void Reload()
        {
            OnTransformsContainerSet();
        }

        public void UpdateUI()
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

        private void OnTransformsContainerSet()
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

        private void lstTransforms_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return; // Avoid errors for empty list
            if (TransformsContainer == null) return;

            e.DrawBackground();
            e.DrawFocusRectangle();

            string? text = lstTransforms.Items[e.Index].ToString();
            Font font = lstTransforms.Font;

            //  make sure index is valid in Processor
            if (e.Index >= 0 && e.Index < TransformsContainer.CountTransforms())
            {
                if (!TransformsContainer.GetTransformAt(e.Index).Enabled)
                    font = new Font(font, FontStyle.Strikeout);
            }

            using (Brush textBrush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(text, font, textBrush, e.Bounds);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //  Display add transform dialog
            mDlgTrans.LoadState(DialogSelectTransform<Token>.EditorState.Add);
            mDlgTrans.ShowDialog(this);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OnEdit();
        }

        private void OnEdit()
        {
            int idx = lstTransforms.SelectedIndex;

            if (idx == -1)
                return;

            if (mTransformsContainer == null)
                return;

            mDlgTrans.LoadState(DialogSelectTransform<T>.EditorState.Edit, mTransformsContainer.GetTransformAt(idx));
            mDlgTrans.ShowDialog(this);

        }

        private void btnRem_Click(object sender, EventArgs e)
        {
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mTransformsContainer?.ClearTransforms();
            Reload();
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
            Transform<T>? tr = null;
            if (lstTransforms.SelectedIndex != -1)
                tr = mTransformsContainer?.GetTransformAt(lstTransforms.SelectedIndex);

            if (tr != null)
            {
                tr.Enabled = !tr.Enabled;
                btnToggle.Text = tr.Enabled ? "■" : "●";
                lstTransforms.Invalidate();
            }
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            Transform<T>? tr = null;
            if (lstTransforms.SelectedIndex != -1)
                tr = mTransformsContainer?.GetTransformAt(lstTransforms.SelectedIndex);

            if (tr != null)
            {
                tr.UseLastOutput = !tr.UseLastOutput;
                btnLink.Text = tr.UseLastOutput ? "🧷" : "🔗";
                lstTransforms.Invalidate();
            }
        }

        private void btnTemplate_Click(object sender, EventArgs e)
        {
         
        }
    }

    public abstract partial class TransformsListUI : UserControl
    {
        public TransformsListUI()
        {
            InitializeComponent();
        }

        //  Abstract event handlers
        //public abstract void OnAdd();
        //public abstract void OnEdit();
        //public abstract void OnToggle();
        //public abstract void OnLink();
        //public abstract void OnRemove();
        //public abstract void OnUp();
        //public abstract void OnDown();
        //public abstract void OnTemplate();
        //public abstract void OnClear();

        //  Update UI, reloads the state
        //public abstract void UpdateUI();
    }
}
