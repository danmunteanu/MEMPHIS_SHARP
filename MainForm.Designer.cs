namespace MEMPHIS_SHARP
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            CommonForms.Components.FilesListComponent.ListSettings listSettings1 = new CommonForms.Components.FilesListComponent.ListSettings();
            panelList = new Panel();
            pageSelection = new PageSelection();
            filesListComponent1 = new CommonForms.Components.FilesListComponent();
            SuspendLayout();
            // 
            // panelList
            // 
            panelList.Dock = DockStyle.Left;
            panelList.Location = new Point(0, 0);
            panelList.Margin = new Padding(2, 2, 2, 2);
            panelList.Name = "panelList";
            panelList.Size = new Size(478, 599);
            panelList.TabIndex = 0;
            // 
            // pageSelection
            // 
            pageSelection.Dock = DockStyle.Fill;
            pageSelection.Engine = null;
            pageSelection.FilesList = null;
            pageSelection.Location = new Point(478, 0);
            pageSelection.Margin = new Padding(2);
            pageSelection.Name = "pageSelection";
            pageSelection.Processor = null;
            pageSelection.Size = new Size(759, 599);
            pageSelection.TabIndex = 1;
            pageSelection.UpdateStatusCallback = null;
            // 
            // filesListComponent1
            // 
            filesListComponent1.SelectionChanged_Callback = null;
            filesListComponent1.UpdateProgress_Callback = null;
            filesListComponent1.UpdateUI_Callback = null;
            filesListComponent1.FileFilters = (List<string>)resources.GetObject("filesListComponent1.FileFilters");
            filesListComponent1.FilesList = null;
            filesListComponent1.Location = new Point(0, 0);
            filesListComponent1.Margin = new Padding(4, 5, 4, 5);
            filesListComponent1.Name = "filesListComponent1";
            filesListComponent1.Processor = null;
            filesListComponent1.Progress = 0;
            listSettings1.AllowAddFolders = true;
            listSettings1.BottomLineHeight = 55;
            listSettings1.ButtonAddLabel = "ADD FILES";
            listSettings1.FontFamily = "Segoe UI";
            listSettings1.FontSize = 8;
            listSettings1.ParseSubfolders = false;
            listSettings1.ProgressBarLineHeight = 45;
            listSettings1.SearchBarHeight = 55;
            listSettings1.SettingsButtonVisible = true;
            listSettings1.StatusBarLineHeight = 33;
            listSettings1.TopLabel = "↓↓ Add Files To Merge ↓↓";
            listSettings1.TopLineHeight = 45;
            listSettings1.UseProgressBar = true;
            listSettings1.UseSearchBar = false;
            listSettings1.UseStatus = true;
            filesListComponent1.Settings = listSettings1;
            filesListComponent1.Size = new Size(214, 250);
            filesListComponent1.Status = "List ready.";
            filesListComponent1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 599);
            Controls.Add(pageSelection);
            Controls.Add(panelList);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MainForm";
            Text = "MEMPHIS (Sharp)";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelList;
        private PageSelection pageSelection;
        private CommonForms.Components.FilesListComponent filesListComponent1;
    }
}
