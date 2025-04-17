using CommonForms;

namespace MEMPHIS_SHARP.ConditionEditors
{
    public partial class EditorIsNumeric: EditorBase2
    {
        public EditorIsNumeric()
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
