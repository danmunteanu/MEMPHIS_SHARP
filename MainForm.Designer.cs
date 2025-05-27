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
            CommonForms.Components.FilesList.FilesListSettings listSettings1 = new CommonForms.Components.FilesList.FilesListSettings();
            filesListComponent1 = new CommonForms.Components.FilesList();
            pageSelection = new PageSelection();
            panelList = new Panel();
            tableLayoutMain = new TableLayoutPanel();
            panelTransforms = new Panel();
            tableLayoutMain.SuspendLayout();
            SuspendLayout();
            // 
            // filesListComponent1
            // 
            filesListComponent1.FileFilters = (List<string>)resources.GetObject("filesListComponent1.FileFilters");
            filesListComponent1.FilesList = null;
            filesListComponent1.Location = new Point(0, 0);
            filesListComponent1.Margin = new Padding(4, 5, 4, 5);
            filesListComponent1.Name = "filesListComponent1";
            filesListComponent1.Processor = null;
            filesListComponent1.Progress = 0;
            filesListComponent1.SelectionChanged_Callback = null;
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
            filesListComponent1.UpdateProgress_Callback = null;
            filesListComponent1.UpdateUI_Callback = null;
            // 
            // pageSelection
            // 
            pageSelection.Dock = DockStyle.Fill;
            pageSelection.Engine = null;
            pageSelection.FilesList = null;
            pageSelection.Location = new Point(309, 1);
            pageSelection.Margin = new Padding(1, 1, 1, 1);
            pageSelection.Name = "pageSelection";
            pageSelection.Processor = null;
            pageSelection.Size = new Size(614, 635);
            pageSelection.TabIndex = 1;
            pageSelection.UpdateStatusCallback = null;
            // 
            // panelList
            // 
            panelList.Dock = DockStyle.Fill;
            panelList.Location = new Point(1, 1);
            panelList.Margin = new Padding(1, 1, 1, 1);
            panelList.Name = "panelList";
            panelList.Size = new Size(306, 635);
            panelList.TabIndex = 0;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 3;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutMain.Controls.Add(panelList, 0, 0);
            tableLayoutMain.Controls.Add(pageSelection, 1, 0);
            tableLayoutMain.Controls.Add(panelTransforms, 2, 0);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Margin = new Padding(1, 1, 1, 1);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 1;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.Size = new Size(1233, 637);
            tableLayoutMain.TabIndex = 2;
            // 
            // panelTransforms
            // 
            panelTransforms.Dock = DockStyle.Fill;
            panelTransforms.Location = new Point(926, 2);
            panelTransforms.Margin = new Padding(2, 2, 2, 2);
            panelTransforms.Name = "panelTransforms";
            panelTransforms.Size = new Size(305, 633);
            panelTransforms.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 637);
            Controls.Add(tableLayoutMain);
            Margin = new Padding(1, 1, 1, 1);
            Name = "MainForm";
            Text = "MEMPHIS (Sharp)";
            tableLayoutMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private CommonForms.Components.FilesList filesListComponent1;
        private PageSelection pageSelection;
        private Panel panelList;
        private TableLayoutPanel tableLayoutMain;
        private Panel panelTransforms;
    }
}
