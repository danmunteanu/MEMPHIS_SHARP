﻿using CommonForms;

namespace MEMPHIS_SHARP.ConditionEditors
{
    public partial class EditorEquals: EditorBase2
    {
        public EditorEquals()
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
