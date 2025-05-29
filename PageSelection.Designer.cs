namespace MEMPHIS_SHARP
{
    partial class PageSelection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            selectionDetails = new TokenSelectionEditor();
            tableLayoutAll = new TableLayoutPanel();
            tableLayoutMain = new TableLayoutPanel();
            lblOriginalName = new Label();
            txtRenameTo = new TextBox();
            lblRenameTo = new Label();
            txtOriginalName = new TextBox();
            btnRename = new Button();
            txtSeparators = new TextBox();
            lblDefaultSepar = new Label();
            scenePainter = new ScenePainter();
            tableLayoutAll.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            SuspendLayout();
            // 
            // selectionDetails
            // 
            selectionDetails.Location = new Point(2, 574);
            selectionDetails.Margin = new Padding(2, 3, 2, 3);
            selectionDetails.Name = "selectionDetails";
            selectionDetails.Size = new Size(553, 150);
            selectionDetails.TabIndex = 0;
            selectionDetails.Token = null;
            selectionDetails.TokenChanged = null;
            // 
            // tableLayoutAll
            // 
            tableLayoutAll.ColumnCount = 1;
            tableLayoutAll.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutAll.Controls.Add(selectionDetails, 0, 4);
            tableLayoutAll.Controls.Add(tableLayoutMain, 0, 1);
            tableLayoutAll.Controls.Add(scenePainter, 0, 3);
            tableLayoutAll.Dock = DockStyle.Fill;
            tableLayoutAll.Location = new Point(0, 0);
            tableLayoutAll.Margin = new Padding(2, 3, 2, 3);
            tableLayoutAll.Name = "tableLayoutAll";
            tableLayoutAll.RowCount = 5;
            tableLayoutAll.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutAll.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutAll.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutAll.RowStyles.Add(new RowStyle(SizeType.Absolute, 350F));
            tableLayoutAll.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
            tableLayoutAll.Size = new Size(1302, 731);
            tableLayoutAll.TabIndex = 9;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 4;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 139F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 38F));
            tableLayoutMain.Controls.Add(lblOriginalName, 0, 1);
            tableLayoutMain.Controls.Add(txtRenameTo, 1, 2);
            tableLayoutMain.Controls.Add(lblRenameTo, 0, 2);
            tableLayoutMain.Controls.Add(txtOriginalName, 1, 1);
            tableLayoutMain.Controls.Add(btnRename, 2, 2);
            tableLayoutMain.Controls.Add(txtSeparators, 2, 1);
            tableLayoutMain.Controls.Add(lblDefaultSepar, 2, 0);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(2, 33);
            tableLayoutMain.Margin = new Padding(2, 3, 2, 3);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 4;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutMain.Size = new Size(1298, 114);
            tableLayoutMain.TabIndex = 4;
            // 
            // lblOriginalName
            // 
            lblOriginalName.Anchor = AnchorStyles.Right;
            lblOriginalName.AutoSize = true;
            lblOriginalName.Location = new Point(9, 26);
            lblOriginalName.Margin = new Padding(2, 0, 2, 0);
            lblOriginalName.Name = "lblOriginalName";
            lblOriginalName.Size = new Size(109, 20);
            lblOriginalName.TabIndex = 0;
            lblOriginalName.Text = "Original Name:";
            // 
            // txtRenameTo
            // 
            txtRenameTo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRenameTo.Location = new Point(122, 62);
            txtRenameTo.Margin = new Padding(2, 3, 2, 3);
            txtRenameTo.Name = "txtRenameTo";
            txtRenameTo.ReadOnly = true;
            txtRenameTo.Size = new Size(997, 27);
            txtRenameTo.TabIndex = 3;
            // 
            // lblRenameTo
            // 
            lblRenameTo.Anchor = AnchorStyles.Right;
            lblRenameTo.AutoSize = true;
            lblRenameTo.Location = new Point(32, 66);
            lblRenameTo.Margin = new Padding(2, 0, 2, 0);
            lblRenameTo.Name = "lblRenameTo";
            lblRenameTo.Size = new Size(86, 20);
            lblRenameTo.TabIndex = 1;
            lblRenameTo.Text = "Rename To:";
            // 
            // txtOriginalName
            // 
            txtOriginalName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtOriginalName.Location = new Point(122, 22);
            txtOriginalName.Margin = new Padding(2, 3, 2, 3);
            txtOriginalName.Name = "txtOriginalName";
            txtOriginalName.ReadOnly = true;
            txtOriginalName.Size = new Size(997, 27);
            txtOriginalName.TabIndex = 2;
            // 
            // btnRename
            // 
            btnRename.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnRename.Location = new Point(1123, 61);
            btnRename.Margin = new Padding(2, 3, 2, 3);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(135, 29);
            btnRename.TabIndex = 6;
            btnRename.Text = "RENAME";
            btnRename.UseVisualStyleBackColor = true;
            // 
            // txtSeparators
            // 
            txtSeparators.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSeparators.Location = new Point(1123, 22);
            txtSeparators.Margin = new Padding(2, 3, 2, 3);
            txtSeparators.Name = "txtSeparators";
            txtSeparators.Size = new Size(135, 27);
            txtSeparators.TabIndex = 7;
            // 
            // lblDefaultSepar
            // 
            lblDefaultSepar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDefaultSepar.AutoSize = true;
            lblDefaultSepar.Location = new Point(1123, 0);
            lblDefaultSepar.Margin = new Padding(2, 0, 2, 0);
            lblDefaultSepar.Name = "lblDefaultSepar";
            lblDefaultSepar.Size = new Size(133, 16);
            lblDefaultSepar.TabIndex = 8;
            lblDefaultSepar.Text = "Default Separators";
            // 
            // scenePainter
            // 
            scenePainter.Dock = DockStyle.Fill;
            scenePainter.Engine = null;
            scenePainter.Location = new Point(3, 226);
            scenePainter.Margin = new Padding(3, 5, 3, 5);
            scenePainter.Name = "scenePainter";
            scenePainter.SelectionChanged = null;
            scenePainter.Size = new Size(1296, 340);
            scenePainter.TabIndex = 8;
            // 
            // PageSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutAll);
            Margin = new Padding(2, 3, 2, 3);
            Name = "PageSelection";
            Size = new Size(1302, 731);
            tableLayoutAll.ResumeLayout(false);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TokenSelectionEditor selectionDetails;
        private TableLayoutPanel tableLayoutAll;
        private ScenePainter scenePainter;
        private TableLayoutPanel tableLayoutMain;
        private Label lblOriginalName;
        private TextBox txtRenameTo;
        private Label lblRenameTo;
        private TextBox txtOriginalName;
        private Button btnRename;
        private TextBox txtSeparators;
        private Label lblDefaultSepar;
    }
}
