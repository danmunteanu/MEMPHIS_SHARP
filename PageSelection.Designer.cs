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
            selectionDetails = new SelectionDetails();
            tableLayoutLeft = new TableLayoutPanel();
            scenePainter = new ScenePainter();
            tableLayoutAll = new TableLayoutPanel();
            lblDefaultSepar = new Label();
            txtSeparators = new TextBox();
            btnRename = new Button();
            txtOriginalName = new TextBox();
            lblRenameTo = new Label();
            txtRenameTo = new TextBox();
            lblOriginal = new Label();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutLeft.SuspendLayout();
            tableLayoutAll.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            SuspendLayout();
            // 
            // selectionDetails
            // 
            selectionDetails.Location = new Point(2, 710);
            selectionDetails.Margin = new Padding(2, 4, 2, 4);
            selectionDetails.Name = "selectionDetails";
            selectionDetails.Size = new Size(691, 188);
            selectionDetails.TabIndex = 0;
            selectionDetails.Token = null;
            selectionDetails.TokenChanged = null;
            // 
            // tableLayoutLeft
            // 
            tableLayoutLeft.ColumnCount = 1;
            tableLayoutLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutLeft.Controls.Add(selectionDetails, 0, 4);
            tableLayoutLeft.Controls.Add(tableLayoutMain, 0, 1);
            tableLayoutLeft.Controls.Add(scenePainter, 0, 3);
            tableLayoutLeft.Dock = DockStyle.Fill;
            tableLayoutLeft.Location = new Point(2, 4);
            tableLayoutLeft.Margin = new Padding(2, 4, 2, 4);
            tableLayoutLeft.Name = "tableLayoutLeft";
            tableLayoutLeft.RowCount = 5;
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 438F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tableLayoutLeft.Size = new Size(1624, 906);
            tableLayoutLeft.TabIndex = 9;
            // 
            // scenePainter
            // 
            scenePainter.Dock = DockStyle.Fill;
            scenePainter.Engine = null;
            scenePainter.Location = new Point(4, 274);
            scenePainter.Margin = new Padding(4, 6, 4, 6);
            scenePainter.Name = "scenePainter";
            scenePainter.SelectionChanged = null;
            scenePainter.Size = new Size(1616, 426);
            scenePainter.TabIndex = 8;
            // 
            // tableLayoutAll
            // 
            tableLayoutAll.ColumnCount = 1;
            tableLayoutAll.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutAll.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutAll.Controls.Add(tableLayoutLeft, 0, 0);
            tableLayoutAll.Dock = DockStyle.Fill;
            tableLayoutAll.Location = new Point(0, 0);
            tableLayoutAll.Margin = new Padding(2, 4, 2, 4);
            tableLayoutAll.Name = "tableLayoutAll";
            tableLayoutAll.RowCount = 1;
            tableLayoutAll.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutAll.Size = new Size(1628, 914);
            tableLayoutAll.TabIndex = 10;
            // 
            // lblDefaultSepar
            // 
            lblDefaultSepar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDefaultSepar.AutoSize = true;
            lblDefaultSepar.Location = new Point(1400, 0);
            lblDefaultSepar.Margin = new Padding(2, 0, 2, 0);
            lblDefaultSepar.Name = "lblDefaultSepar";
            lblDefaultSepar.Size = new Size(159, 20);
            lblDefaultSepar.TabIndex = 8;
            lblDefaultSepar.Text = "Default Separators";
            // 
            // txtSeparators
            // 
            txtSeparators.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSeparators.Location = new Point(1400, 29);
            txtSeparators.Margin = new Padding(2, 4, 2, 4);
            txtSeparators.Name = "txtSeparators";
            txtSeparators.Size = new Size(170, 31);
            txtSeparators.TabIndex = 7;
            // 
            // btnRename
            // 
            btnRename.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnRename.Location = new Point(1400, 77);
            btnRename.Margin = new Padding(2, 4, 2, 4);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(170, 36);
            btnRename.TabIndex = 6;
            btnRename.Text = "RENAME";
            btnRename.UseVisualStyleBackColor = true;
            // 
            // txtOriginalName
            // 
            txtOriginalName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtOriginalName.Location = new Point(152, 29);
            txtOriginalName.Margin = new Padding(2, 4, 2, 4);
            txtOriginalName.Name = "txtOriginalName";
            txtOriginalName.ReadOnly = true;
            txtOriginalName.Size = new Size(1244, 31);
            txtOriginalName.TabIndex = 2;
            // 
            // lblRenameTo
            // 
            lblRenameTo.Anchor = AnchorStyles.Right;
            lblRenameTo.AutoSize = true;
            lblRenameTo.Location = new Point(46, 82);
            lblRenameTo.Margin = new Padding(2, 0, 2, 0);
            lblRenameTo.Name = "lblRenameTo";
            lblRenameTo.Size = new Size(102, 25);
            lblRenameTo.TabIndex = 1;
            lblRenameTo.Text = "Rename To:";
            // 
            // txtRenameTo
            // 
            txtRenameTo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRenameTo.Location = new Point(152, 79);
            txtRenameTo.Margin = new Padding(2, 4, 2, 4);
            txtRenameTo.Name = "txtRenameTo";
            txtRenameTo.ReadOnly = true;
            txtRenameTo.Size = new Size(1244, 31);
            txtRenameTo.TabIndex = 3;
            // 
            // lblOriginal
            // 
            lblOriginal.Anchor = AnchorStyles.Right;
            lblOriginal.AutoSize = true;
            lblOriginal.Location = new Point(18, 32);
            lblOriginal.Margin = new Padding(2, 0, 2, 0);
            lblOriginal.Name = "lblOriginal";
            lblOriginal.Size = new Size(130, 25);
            lblOriginal.TabIndex = 0;
            lblOriginal.Text = "Original Name:";
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 4;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 174F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            tableLayoutMain.Controls.Add(lblOriginal, 0, 1);
            tableLayoutMain.Controls.Add(txtRenameTo, 1, 2);
            tableLayoutMain.Controls.Add(lblRenameTo, 0, 2);
            tableLayoutMain.Controls.Add(txtOriginalName, 1, 1);
            tableLayoutMain.Controls.Add(btnRename, 2, 2);
            tableLayoutMain.Controls.Add(txtSeparators, 2, 1);
            tableLayoutMain.Controls.Add(lblDefaultSepar, 2, 0);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(2, 42);
            tableLayoutMain.Margin = new Padding(2, 4, 2, 4);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 4;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutMain.Size = new Size(1620, 142);
            tableLayoutMain.TabIndex = 4;
            // 
            // PageSelection
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutAll);
            Margin = new Padding(2, 4, 2, 4);
            Name = "PageSelection";
            Size = new Size(1628, 914);
            tableLayoutLeft.ResumeLayout(false);
            tableLayoutAll.ResumeLayout(false);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private SelectionDetails selectionDetails;
        private TableLayoutPanel tableLayoutLeft;
        private TableLayoutPanel tableLayoutAll;
        private ScenePainter scenePainter;
        private TableLayoutPanel tableLayoutMain;
        private Label lblOriginal;
        private TextBox txtRenameTo;
        private Label lblRenameTo;
        private TextBox txtOriginalName;
        private Button btnRename;
        private TextBox txtSeparators;
        private Label lblDefaultSepar;
    }
}
