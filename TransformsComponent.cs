using CommonForms.Components;
using Memphis;
using RealityFrameworks;

namespace MEMPHIS_SHARP
{
    public class TransformsComponent<T> : TransformsListUI
    {
        private const string K_ENABLE_TRANSFORM = "●";
        private const string K_DISABLE_TRANSFORM = "■";
        private const string K_LINK_TRANSFORM = "🔗";
        private const string K_UNLINK_TRANSFORM = "🧷";

        private TransformsContainer<T>? mTransformsContainer = null;

        private DialogSelectTransform<T> mDlgTransform = new();

        List<Func<Transform<T>>> mTemplates = new();

        public TransformsContainer<T>? TransformsContainer
        {
            get { return mTransformsContainer; }
            set
            {
                mTransformsContainer = value;
                
                ReloadTransforms();

                mDlgTransform.Processor = mTransformsContainer;
                LoadConditionAndActionNames();

                UpdateUI();
            }
        }

        public TransformsComponent()
        {
            //  Add click handlers
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnRem.Click += btnRem_Click;
            btnToggle.Click += btnToggle_Click;
            btnUp.Click += btnUp_Click;
            btnDown.Click += btnDown_Click;
            btnTemplates.Click += btnTemplate_Click;
            btnClear.Click += btnClear_Click;

            //  List setup
            lstTransforms.HorizontalScrollbar = true;
            lstTransforms.DrawItem += lstTransforms_DrawItem;
            lstTransforms.DrawMode = DrawMode.OwnerDrawFixed;
            lstTransforms.DoubleClick += lstTransforms_DoubleClick;
            lstTransforms.SelectedIndexChanged += lstTransforms_SelectedIndexChanged;

            //  TODO: OnContainerSet reloads the names everytime it's called!

            mDlgTransform.OnModified = () =>
            {
                ReloadTransforms();
                UpdateUI();
            };

            LoadTooltips();
            LoadTemplates();
            UpdateUI();
        }

        public void Reload()
        {
            ReloadTransforms();
            UpdateUI();
        }

        public void UpdateUI()
        {
            bool haveTransforms = TransformsContainer?.CountTransforms() > 0;
            bool haveSelection = lstTransforms.SelectedIndex != -1;
            Transform<T>? tr = null;
            if (haveSelection)
                tr = mTransformsContainer?.GetTransformAt(lstTransforms.SelectedIndex);

            btnAdd.Enabled = true;

            btnEdit.Enabled = haveSelection;
            
            btnToggle.Enabled = haveSelection;
            if (tr != null)
                btnToggle.Text = tr.Enabled ? K_DISABLE_TRANSFORM : K_ENABLE_TRANSFORM;

            btnLink.Enabled = haveSelection;
            if (tr != null)
                btnLink.Text = tr.UseLastOutput ? K_UNLINK_TRANSFORM : K_LINK_TRANSFORM;

            btnRem.Enabled = haveSelection;

            btnUp.Enabled = haveSelection && lstTransforms.SelectedIndex > 0;
            btnDown.Enabled = haveSelection && lstTransforms.SelectedIndex < lstTransforms.Items.Count - 1;
            
            btnTemplates.Enabled = true;
            btnReload.Enabled = haveTransforms;

            btnClear.Enabled = haveTransforms;
        }

        private void LoadTooltips()
        {
            toolTip.SetToolTip(btnAdd, "Add a new Transform");
            toolTip.SetToolTip(btnEdit, "Edit Transform");
            toolTip.SetToolTip(btnToggle, "Disable Transform");
            toolTip.SetToolTip(btnRem, "Remove transform");
            toolTip.SetToolTip(btnReload, "Reloads list of transforms");
            toolTip.SetToolTip(btnTemplates, "Transform templates");
            toolTip.SetToolTip(btnClear, "Clear transforms list");
        }

        private void LoadTemplates()
        {
            menuStripTemplates.Items.Clear();
            menuStripTemplates.Items.Add("YAML/PREFIX: ADD", null, TemplateMenuItem_Click);
            menuStripTemplates.Items.Add("YAML/PREFIX: REMOVE", null, TemplateMenuItem_Click);
        }

        private void TemplateMenuItem_Click(object? sender, EventArgs e)
        {
            ToolStripMenuItem? menuItem = sender as ToolStripMenuItem;
            if (menuItem == null || string.IsNullOrEmpty(menuItem.Text))
                return;

            //  get the index for the item
            int idx = menuStripTemplates.Items.IndexOf(menuItem);

            //  valid index?
            if (idx == -1)
            {
                string title = "Template Error";
                string message = string.Format("Menu item \"{0}\" has returned and invalid index: {1}", menuItem.Text, idx);
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  within bounds
            if (!(idx >= 0 && idx < mTemplates.Count()))
            {
                string title = "Template Error";
                string message = string.Format("There is no template registered for \"{0}\" at position {1}", menuItem.Text, idx);
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  create the FileTransform
            Transform<T> tr = mTemplates.ElementAt(idx)();
            if (tr != null)
            {
                Reload();
                TransformsContainer?.AddTransform(tr);
            }
        }

        public void UpdateLocale()
        {
            //  Update localization strings here
        }

        private void ReloadTransforms()
        {
            lstTransforms.Items.Clear();

            if (TransformsContainer == null)
                return;

            //  load the transforms from the container
            foreach (var tr in TransformsContainer.Transforms)
                lstTransforms.Items.Add(tr.Description);                       
        }

        /// <summary>
        /// Loads condition and action names into the transforms dialog
        /// </summary>
        public void LoadConditionAndActionNames()
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

            mDlgTransform.LoadConditionNames(mConditionNames);
            mDlgTransform.LoadActionNames(mActionNames);
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

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            //  Display add transform dialog
            mDlgTransform.LoadState(DialogSelectTransform<Token>.EditorState.Add);
            mDlgTransform.ShowDialog(this);
        }

        private void btnEdit_Click(object? sender, EventArgs e)
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

            mDlgTransform.LoadState(DialogSelectTransform<T>.EditorState.Edit, mTransformsContainer.GetTransformAt(idx));
            mDlgTransform.ShowDialog(this);

        }

        private void btnRem_Click(object? sender, EventArgs e)
        {
            //  remove selected transform
        }

        private void btnUp_Click(object? sender, EventArgs e)
        {
            int idxList = lstTransforms.SelectedIndex;
            TransformsContainer?.MoveUp(idxList);
            
            Reload();

            idxList--;
            if (idxList >= 0 && idxList < lstTransforms.Items.Count)
                lstTransforms.SelectedIndex = idxList;
            else
                lstTransforms.SelectedIndex = 0;

            UpdateUI();
        }

        private void btnDown_Click(object? sender, EventArgs e)
        {
            int idxList = lstTransforms.SelectedIndex;
            TransformsContainer?.MoveDown(lstTransforms.SelectedIndex);

            Reload();

            idxList++;
            if (idxList >= 0 && idxList < lstTransforms.Items.Count)
                lstTransforms.SelectedIndex = idxList;
            else
                lstTransforms.SelectedIndex = lstTransforms.Items.Count - 1;

            UpdateUI();
        }

        private void lstTransforms_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateUI();
        }

        private void lstTransforms_DoubleClick(object? sender, EventArgs e)
        {
            OnEdit();
        }

        private void btnToggle_Click(object? sender, EventArgs e)
        {
            Transform<T>? tr = null;
            if (lstTransforms.SelectedIndex != -1)
                tr = mTransformsContainer?.GetTransformAt(lstTransforms.SelectedIndex);

            if (tr != null)
            {
                tr.Enabled = !tr.Enabled;
                btnToggle.Text = tr.Enabled ? K_DISABLE_TRANSFORM : K_ENABLE_TRANSFORM;
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
                btnLink.Text = tr.UseLastOutput ? K_UNLINK_TRANSFORM : K_LINK_TRANSFORM;
                lstTransforms.Invalidate();
            }
        }

        private void btnTemplate_Click(object? sender, EventArgs e)
        {
            //  show a menu
            menuStripTemplates.Show(btnTemplates, new Point(0, btnAdd.Height));
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            mTransformsContainer?.ClearTransforms();
            lstTransforms.Items.Clear();
            UpdateUI();
        }
        
    }

    /*
     * TransformsListUI keeps only the desginer part of the TransformsList
     * in order to avoid the generic class designer problem     * 
     */
    public partial class TransformsListUI : UserControl
    {
        public TransformsListUI()
        {
            InitializeComponent();
        }

        //  Do NOT add any kind of event handlers in this class!
        //  They're all defined in the generic wrapper class

        //  Update UI, reloads the state
        //public abstract void UpdateUI();
    }
}
