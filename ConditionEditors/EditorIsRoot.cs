using CommonForms;

namespace MEMPHIS_SHARP.ConditionEditors
{
    public partial class EditorIsRoot: EditorBase2
    {
        public EditorIsRoot()
        {
            InitializeComponent();
        }

        public override void LoadState(object item)
        {
            //  nothing, just to avoid exception
        }

        public override void SaveState(object item)
        {
            //  silence exception
        }
    }
}
