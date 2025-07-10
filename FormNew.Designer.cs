namespace MEMPHIS_SHARP
{
    partial class FormNew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelList = new Panel();
            panelTransforms = new Panel();
            scenePainter = new ScenePainter();
            selectionDetails = new SelectionDetails();
            tableLayoutPanelMain = new TableLayoutPanel();
            tableLayoutPanelRight = new TableLayoutPanel();
            tableLayoutPanelSelectionTransforms = new TableLayoutPanel();
            panelRename = new PanelRename();
            tableLayoutPanelLeft = new TableLayoutPanel();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelRight.SuspendLayout();
            tableLayoutPanelSelectionTransforms.SuspendLayout();
            tableLayoutPanelLeft.SuspendLayout();
            SuspendLayout();
            // 
            // panelList
            // 
            panelList.Dock = DockStyle.Fill;
            panelList.Location = new Point(3, 3);
            panelList.Name = "panelList";
            panelList.Size = new Size(488, 851);
            panelList.TabIndex = 0;
            // 
            // panelTransforms
            // 
            panelTransforms.Dock = DockStyle.Fill;
            panelTransforms.Location = new Point(487, 3);
            panelTransforms.Name = "panelTransforms";
            panelTransforms.Size = new Size(244, 188);
            panelTransforms.TabIndex = 1;
            // 
            // scenePainter
            // 
            scenePainter.BorderStyle = BorderStyle.FixedSingle;
            scenePainter.Dock = DockStyle.Fill;
            scenePainter.Engine = null;
            scenePainter.Location = new Point(3, 49);
            scenePainter.Margin = new Padding(3, 4, 3, 4);
            scenePainter.Name = "scenePainter";
            scenePainter.SelectionChanged = null;
            scenePainter.Size = new Size(734, 252);
            scenePainter.TabIndex = 2;
            // 
            // selectionDetails
            // 
            selectionDetails.BorderStyle = BorderStyle.FixedSingle;
            selectionDetails.Dock = DockStyle.Fill;
            selectionDetails.Location = new Point(2, 2);
            selectionDetails.Margin = new Padding(2);
            selectionDetails.Name = "selectionDetails";
            selectionDetails.Size = new Size(460, 190);
            selectionDetails.TabIndex = 3;
            selectionDetails.Token = null;
            selectionDetails.TokenChanged = null;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelRight, 1, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelLeft, 0, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 1;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(1246, 863);
            tableLayoutPanelMain.TabIndex = 7;
            // 
            // tableLayoutPanelRight
            // 
            tableLayoutPanelRight.ColumnCount = 1;
            tableLayoutPanelRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelRight.Controls.Add(tableLayoutPanelSelectionTransforms, 0, 2);
            tableLayoutPanelRight.Controls.Add(scenePainter, 0, 1);
            tableLayoutPanelRight.Controls.Add(panelRename, 0, 4);
            tableLayoutPanelRight.Dock = DockStyle.Fill;
            tableLayoutPanelRight.Location = new Point(503, 3);
            tableLayoutPanelRight.Name = "tableLayoutPanelRight";
            tableLayoutPanelRight.RowCount = 5;
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 260F));
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
            tableLayoutPanelRight.Size = new Size(740, 857);
            tableLayoutPanelRight.TabIndex = 8;
            // 
            // tableLayoutPanelSelectionTransforms
            // 
            tableLayoutPanelSelectionTransforms.ColumnCount = 3;
            tableLayoutPanelSelectionTransforms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanelSelectionTransforms.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelSelectionTransforms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanelSelectionTransforms.Controls.Add(panelTransforms, 2, 0);
            tableLayoutPanelSelectionTransforms.Controls.Add(selectionDetails, 0, 0);
            tableLayoutPanelSelectionTransforms.Dock = DockStyle.Fill;
            tableLayoutPanelSelectionTransforms.Location = new Point(3, 308);
            tableLayoutPanelSelectionTransforms.Name = "tableLayoutPanelSelectionTransforms";
            tableLayoutPanelSelectionTransforms.RowCount = 1;
            tableLayoutPanelSelectionTransforms.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelSelectionTransforms.Size = new Size(734, 194);
            tableLayoutPanelSelectionTransforms.TabIndex = 8;
            // 
            // panelRename
            // 
            panelRename.Dock = DockStyle.Fill;
            panelRename.Location = new Point(3, 730);
            panelRename.Name = "panelRename";
            panelRename.Size = new Size(734, 124);
            panelRename.TabIndex = 9;
            // 
            // tableLayoutPanelLeft
            // 
            tableLayoutPanelLeft.ColumnCount = 1;
            tableLayoutPanelLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelLeft.Controls.Add(panelList, 0, 0);
            tableLayoutPanelLeft.Dock = DockStyle.Fill;
            tableLayoutPanelLeft.Location = new Point(3, 3);
            tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            tableLayoutPanelLeft.RowCount = 1;
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelLeft.Size = new Size(494, 857);
            tableLayoutPanelLeft.TabIndex = 8;
            // 
            // FormNew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 863);
            Controls.Add(tableLayoutPanelMain);
            Name = "FormNew";
            Text = "FormNew";
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelRight.ResumeLayout(false);
            tableLayoutPanelSelectionTransforms.ResumeLayout(false);
            tableLayoutPanelLeft.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelList;
        private Panel panelTransforms;
        private ScenePainter scenePainter;
        private SelectionDetails selectionDetails;
        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanelLeft;
        private TableLayoutPanel tableLayoutPanelRight;
        private TableLayoutPanel tableLayoutPanelSelectionTransforms;
        private PanelRename panelRename;
    }
}