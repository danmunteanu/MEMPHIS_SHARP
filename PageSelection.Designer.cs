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
            tableLayoutRename = new TableLayoutPanel();
            lblOriginalName = new Label();
            txtRenameTo = new TextBox();
            lblRenameTo = new Label();
            txtOriginalName = new TextBox();
            btnRename = new Button();
            txtSeparators = new TextBox();
            scenePainter = new ScenePainter();
            tableLayoutPanelMain = new TableLayoutPanel();
            tableLayoutPanelBottom = new TableLayoutPanel();
            tableLayoutRename.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // selectionDetails
            // 
            selectionDetails.BorderStyle = BorderStyle.FixedSingle;
            selectionDetails.Dock = DockStyle.Fill;
            selectionDetails.Location = new Point(819, 3);
            selectionDetails.Margin = new Padding(2, 3, 2, 3);
            selectionDetails.Name = "selectionDetails";
            selectionDetails.Size = new Size(436, 382);
            selectionDetails.TabIndex = 0;
            selectionDetails.Token = null;
            selectionDetails.TokenChanged = null;
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
            tableLayoutRename.Location = new Point(2, 3);
            tableLayoutRename.Margin = new Padding(2, 3, 2, 3);
            tableLayoutRename.Name = "tableLayoutRename";
            tableLayoutRename.RowCount = 2;
            tableLayoutRename.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutRename.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutRename.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutRename.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutRename.Size = new Size(1259, 105);
            tableLayoutRename.TabIndex = 4;
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
            txtRenameTo.Location = new Point(122, 59);
            txtRenameTo.Margin = new Padding(2, 3, 2, 3);
            txtRenameTo.Name = "txtRenameTo";
            txtRenameTo.ReadOnly = true;
            txtRenameTo.Size = new Size(975, 27);
            txtRenameTo.TabIndex = 3;
            // 
            // lblRenameTo
            // 
            lblRenameTo.Anchor = AnchorStyles.Right;
            lblRenameTo.AutoSize = true;
            lblRenameTo.Location = new Point(32, 62);
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
            txtOriginalName.Size = new Size(975, 27);
            txtOriginalName.TabIndex = 2;
            // 
            // btnRename
            // 
            btnRename.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnRename.Location = new Point(1101, 58);
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
            txtSeparators.Location = new Point(1101, 6);
            txtSeparators.Margin = new Padding(2, 3, 2, 3);
            txtSeparators.Name = "txtSeparators";
            txtSeparators.Size = new Size(136, 27);
            txtSeparators.TabIndex = 7;
            // 
            // scenePainter
            // 
            scenePainter.BorderStyle = BorderStyle.FixedSingle;
            scenePainter.Dock = DockStyle.Fill;
            scenePainter.Engine = null;
            scenePainter.Location = new Point(3, 5);
            scenePainter.Margin = new Padding(3, 5, 3, 5);
            scenePainter.Name = "scenePainter";
            scenePainter.SelectionChanged = null;
            scenePainter.Size = new Size(811, 378);
            scenePainter.TabIndex = 8;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelBottom, 0, 1);
            tableLayoutPanelMain.Controls.Add(tableLayoutRename, 0, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 21.9801979F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 78.0198F));
            tableLayoutPanelMain.Size = new Size(1263, 505);
            tableLayoutPanelMain.TabIndex = 9;
            // 
            // tableLayoutPanelBottom
            // 
            tableLayoutPanelBottom.ColumnCount = 2;
            tableLayoutPanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanelBottom.Controls.Add(scenePainter, 0, 0);
            tableLayoutPanelBottom.Controls.Add(selectionDetails, 1, 0);
            tableLayoutPanelBottom.Dock = DockStyle.Fill;
            tableLayoutPanelBottom.Location = new Point(3, 114);
            tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            tableLayoutPanelBottom.RowCount = 1;
            tableLayoutPanelBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelBottom.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelBottom.Size = new Size(1257, 388);
            tableLayoutPanelBottom.TabIndex = 10;
            // 
            // PageSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanelMain);
            Margin = new Padding(2, 3, 2, 3);
            Name = "PageSelection";
            Size = new Size(1263, 505);
            tableLayoutRename.ResumeLayout(false);
            tableLayoutRename.PerformLayout();
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TokenSelectionEditor selectionDetails;
        private TableLayoutPanel tableLayoutAll;
        private ScenePainter scenePainter;
        private TableLayoutPanel tableLayoutRename;
        private Label lblOriginalName;
        private TextBox txtRenameTo;
        private Label lblRenameTo;
        private TextBox txtOriginalName;
        private Button btnRename;
        private TextBox txtSeparators;
        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanelBottom;
    }
}
