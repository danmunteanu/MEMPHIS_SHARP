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
            lblOriginal = new Label();
            lblRenameTo = new Label();
            txtOriginalName = new TextBox();
            txtRenameTo = new TextBox();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            selectionDetails1 = new SelectionDetails();
            graphicsPanel = new Memphis.GraphicsScene();
            btnRename = new Button();
            txtSeparators = new TextBox();
            lblDefaultSepar = new Label();
            tableLayoutMain.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblOriginal
            // 
            lblOriginal.Anchor = AnchorStyles.Right;
            lblOriginal.AutoSize = true;
            lblOriginal.Location = new Point(9, 42);
            lblOriginal.Margin = new Padding(2, 0, 2, 0);
            lblOriginal.Name = "lblOriginal";
            lblOriginal.Size = new Size(109, 20);
            lblOriginal.TabIndex = 0;
            lblOriginal.Text = "Original Name:";
            // 
            // lblRenameTo
            // 
            lblRenameTo.Anchor = AnchorStyles.Right;
            lblRenameTo.AutoSize = true;
            lblRenameTo.Location = new Point(32, 82);
            lblRenameTo.Margin = new Padding(2, 0, 2, 0);
            lblRenameTo.Name = "lblRenameTo";
            lblRenameTo.Size = new Size(86, 20);
            lblRenameTo.TabIndex = 1;
            lblRenameTo.Text = "Rename To:";
            // 
            // txtOriginalName
            // 
            txtOriginalName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtOriginalName.Location = new Point(122, 38);
            txtOriginalName.Margin = new Padding(2, 2, 2, 2);
            txtOriginalName.Name = "txtOriginalName";
            txtOriginalName.ReadOnly = true;
            txtOriginalName.Size = new Size(762, 27);
            txtOriginalName.TabIndex = 2;
            // 
            // txtRenameTo
            // 
            txtRenameTo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRenameTo.Location = new Point(122, 78);
            txtRenameTo.Margin = new Padding(2, 2, 2, 2);
            txtRenameTo.Name = "txtRenameTo";
            txtRenameTo.ReadOnly = true;
            txtRenameTo.Size = new Size(762, 27);
            txtRenameTo.TabIndex = 3;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 4;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 38F));
            tableLayoutMain.Controls.Add(tableLayoutPanel1, 1, 4);
            tableLayoutMain.Controls.Add(lblOriginal, 0, 1);
            tableLayoutMain.Controls.Add(txtRenameTo, 1, 2);
            tableLayoutMain.Controls.Add(lblRenameTo, 0, 2);
            tableLayoutMain.Controls.Add(txtOriginalName, 1, 1);
            tableLayoutMain.Controls.Add(graphicsPanel, 1, 3);
            tableLayoutMain.Controls.Add(btnRename, 2, 2);
            tableLayoutMain.Controls.Add(txtSeparators, 2, 1);
            tableLayoutMain.Controls.Add(lblDefaultSepar, 2, 0);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Margin = new Padding(2, 2, 2, 2);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 5;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 144F));
            tableLayoutMain.Size = new Size(1064, 614);
            tableLayoutMain.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 288F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(selectionDetails1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(122, 472);
            tableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 139F));
            tableLayoutPanel1.Size = new Size(762, 140);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // selectionDetails1
            // 
            selectionDetails1.Dock = DockStyle.Fill;
            selectionDetails1.Location = new Point(2, 2);
            selectionDetails1.Margin = new Padding(2, 2, 2, 2);
            selectionDetails1.Name = "selectionDetails1";
            selectionDetails1.Size = new Size(284, 136);
            selectionDetails1.TabIndex = 0;
            // 
            // graphicsPanel
            // 
            graphicsPanel.Dock = DockStyle.Fill;
            graphicsPanel.Location = new Point(122, 114);
            graphicsPanel.Margin = new Padding(2, 2, 2, 2);
            graphicsPanel.Name = "graphicsPanel";
            graphicsPanel.RootToken = null;
            graphicsPanel.Size = new Size(762, 354);
            graphicsPanel.TabIndex = 5;
            // 
            // btnRename
            // 
            btnRename.Dock = DockStyle.Fill;
            btnRename.Location = new Point(888, 74);
            btnRename.Margin = new Padding(2, 2, 2, 2);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(136, 36);
            btnRename.TabIndex = 6;
            btnRename.Text = "RENAME";
            btnRename.UseVisualStyleBackColor = true;
            // 
            // txtSeparators
            // 
            txtSeparators.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSeparators.Location = new Point(888, 38);
            txtSeparators.Margin = new Padding(2, 2, 2, 2);
            txtSeparators.Name = "txtSeparators";
            txtSeparators.Size = new Size(136, 27);
            txtSeparators.TabIndex = 7;
            // 
            // lblDefaultSepar
            // 
            lblDefaultSepar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDefaultSepar.AutoSize = true;
            lblDefaultSepar.Location = new Point(888, 12);
            lblDefaultSepar.Margin = new Padding(2, 0, 2, 0);
            lblDefaultSepar.Name = "lblDefaultSepar";
            lblDefaultSepar.Size = new Size(133, 20);
            lblDefaultSepar.TabIndex = 8;
            lblDefaultSepar.Text = "Default Separators";
            // 
            // PageSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutMain);
            Margin = new Padding(2, 2, 2, 2);
            Name = "PageSelection";
            Size = new Size(1064, 614);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutMain.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblOriginal;
        private Label lblRenameTo;
        private TextBox txtOriginalName;
        private TextBox txtRenameTo;
        private TableLayoutPanel tableLayoutMain;
        private Memphis.GraphicsScene graphicsPanel;
        private Button btnRename;
        private TextBox txtSeparators;
        private Label lblDefaultSepar;
        private TableLayoutPanel tableLayoutPanel1;
        private SelectionDetails selectionDetails1;
    }
}
