using CommonForms;

namespace MEMPHIS_SHARP.ConditionEditors
{
    public partial class EditorAlways: EditorBase
    {
        public EditorAlways()
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
