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
            tableLayoutRename = new TableLayoutPanel();
            lblOriginalName = new Label();
            txtRenameTo = new TextBox();
            lblRenameTo = new Label();
            txtOriginalName = new TextBox();
            btnRename = new Button();
            txtSeparators = new TextBox();
            tableLayoutPanelLeft = new TableLayoutPanel();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelRight.SuspendLayout();
            tableLayoutRename.SuspendLayout();
            tableLayoutPanelLeft.SuspendLayout();
            SuspendLayout();
            // 
            // panelList
            // 
            panelList.Dock = DockStyle.Fill;
            panelList.Location = new Point(3, 3);
            panelList.Name = "panelList";
            panelList.Size = new Size(488, 551);
            panelList.TabIndex = 0;
            // 
            // panelTransforms
            // 
            panelTransforms.Dock = DockStyle.Fill;
            panelTransforms.Location = new Point(3, 560);
            panelTransforms.Name = "panelTransforms";
            panelTransforms.Size = new Size(488, 294);
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
            scenePainter.Size = new Size(681, 252);
            scenePainter.TabIndex = 2;
            // 
            // selectionDetails
            // 
            selectionDetails.BorderStyle = BorderStyle.FixedSingle;
            selectionDetails.Dock = DockStyle.Fill;
            selectionDetails.Location = new Point(2, 307);
            selectionDetails.Margin = new Padding(2);
            selectionDetails.Name = "selectionDetails";
            selectionDetails.Size = new Size(683, 132);
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
            tableLayoutPanelMain.Size = new Size(1193, 863);
            tableLayoutPanelMain.TabIndex = 7;
            // 
            // tableLayoutPanelRight
            // 
            tableLayoutPanelRight.ColumnCount = 1;
            tableLayoutPanelRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelRight.Controls.Add(scenePainter, 0, 1);
            tableLayoutPanelRight.Controls.Add(selectionDetails, 0, 2);
            tableLayoutPanelRight.Controls.Add(tableLayoutRename, 0, 4);
            tableLayoutPanelRight.Dock = DockStyle.Fill;
            tableLayoutPanelRight.Location = new Point(503, 3);
            tableLayoutPanelRight.Name = "tableLayoutPanelRight";
            tableLayoutPanelRight.RowCount = 5;
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 260F));
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 136F));
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 169F));
            tableLayoutPanelRight.Size = new Size(687, 857);
            tableLayoutPanelRight.TabIndex = 8;
            // 
            // tableLayoutRename
            // 
            tableLayoutRename.ColumnCount = 4;
            tableLayoutRename.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutRename.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutRename.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutRename.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutRename.Controls.Add(lblOriginalName, 0, 0);
            tableLayoutRename.Controls.Add(txtRenameTo, 1, 1);
            tableLayoutRename.Controls.Add(lblRenameTo, 0, 1);
            tableLayoutRename.Controls.Add(txtOriginalName, 1, 0);
            tableLayoutRename.Controls.Add(btnRename, 2, 1);
            tableLayoutRename.Controls.Add(txtSeparators, 2, 0);
            tableLayoutRename.Dock = DockStyle.Fill;
            tableLayoutRename.Location = new Point(2, 691);
            tableLayoutRename.Margin = new Padding(2, 3, 2, 3);
            tableLayoutRename.Name = "tableLayoutRename";
            tableLayoutRename.RowCount = 2;
            tableLayoutRename.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutRename.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutRename.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutRename.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutRename.Size = new Size(683, 163);
            tableLayoutRename.TabIndex = 5;
            // 
            // lblOriginalName
            // 
            lblOriginalName.Anchor = AnchorStyles.Right;
            lblOriginalName.AutoSize = true;
            lblOriginalName.Location = new Point(9, 10);
            lblOriginalName.Margin = new Padding(2, 0, 2, 0);
            lblOriginalName.Name = "lblOriginalName";
            lblOriginalName.Size = new Size(109, 20);
            lblOriginalName.TabIndex = 0;
            lblOriginalName.Text = "Original Name:";
            // 
            // txtRenameTo
            // 
            txtRenameTo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRenameTo.Location = new Point(122, 88);
            txtRenameTo.Margin = new Padding(2, 3, 2, 3);
            txtRenameTo.Name = "txtRenameTo";
            txtRenameTo.ReadOnly = true;
            txtRenameTo.Size = new Size(399, 27);
            txtRenameTo.TabIndex = 3;
            // 
            // lblRenameTo
            // 
            lblRenameTo.Anchor = AnchorStyles.Right;
            lblRenameTo.AutoSize = true;
            lblRenameTo.Location = new Point(32, 91);
            lblRenameTo.Margin = new Padding(2, 0, 2, 0);
            lblRenameTo.Name = "lblRenameTo";
            lblRenameTo.Size = new Size(86, 20);
            lblRenameTo.TabIndex = 1;
            lblRenameTo.Text = "Rename To:";
            // 
            // txtOriginalName
            // 
            txtOriginalName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtOriginalName.Location = new Point(122, 6);
            txtOriginalName.Margin = new Padding(2, 3, 2, 3);
            txtOriginalName.Name = "txtOriginalName";
            txtOriginalName.ReadOnly = true;
            txtOriginalName.Size = new Size(399, 27);
            txtOriginalName.TabIndex = 2;
            // 
            // btnRename
            // 
            btnRename.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnRename.Location = new Point(525, 87);
            btnRename.Margin = new Padding(2, 3, 2, 3);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(136, 29);
            btnRename.TabIndex = 6;
            btnRename.Text = "RENAME";
            btnRename.UseVisualStyleBackColor = true;
            // 
            // txtSeparators
            // 
            txtSeparators.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSeparators.Location = new Point(525, 6);
            txtSeparators.Margin = new Padding(2, 3, 2, 3);
            txtSeparators.Name = "txtSeparators";
            txtSeparators.Size = new Size(136, 27);
            txtSeparators.TabIndex = 7;
            // 
            // tableLayoutPanelLeft
            // 
            tableLayoutPanelLeft.ColumnCount = 1;
            tableLayoutPanelLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelLeft.Controls.Add(panelList, 0, 0);
            tableLayoutPanelLeft.Controls.Add(panelTransforms, 0, 1);
            tableLayoutPanelLeft.Dock = DockStyle.Fill;
            tableLayoutPanelLeft.Location = new Point(3, 3);
            tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            tableLayoutPanelLeft.RowCount = 2;
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelLeft.Size = new Size(494, 857);
            tableLayoutPanelLeft.TabIndex = 8;
            // 
            // FormNew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 863);
            Controls.Add(tableLayoutPanelMain);
            Name = "FormNew";
            Text = "FormNew";
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelRight.ResumeLayout(false);
            tableLayoutRename.ResumeLayout(false);
            tableLayoutRename.PerformLayout();
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
        private TableLayoutPanel tableLayoutRename;
        private Label lblOriginalName;
        private TextBox txtRenameTo;
        private Label lblRenameTo;
        private TextBox txtOriginalName;
        private Button btnRename;
        private TextBox txtSeparators;
    }
}