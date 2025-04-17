using CommonForms;

namespace MEMPHIS_SHARP.ActionEditors
{
    public partial class EditorSetSeparators: EditorBase2
    {
        public EditorSetSeparators()
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
