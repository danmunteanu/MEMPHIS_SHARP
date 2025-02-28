namespace MEMPHIS_SHARP
{
    partial class SelectionPage
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
            lblOriginal.Location = new Point(17, 52);
            lblOriginal.Name = "lblOriginal";
            lblOriginal.Size = new Size(130, 25);
            lblOriginal.TabIndex = 0;
            lblOriginal.Text = "Original Name:";
            // 
            // lblRenameTo
            // 
            lblRenameTo.Anchor = AnchorStyles.Right;
            lblRenameTo.AutoSize = true;
            lblRenameTo.Location = new Point(45, 102);
            lblRenameTo.Name = "lblRenameTo";
            lblRenameTo.Size = new Size(102, 25);
            lblRenameTo.TabIndex = 1;
            lblRenameTo.Text = "Rename To:";
            // 
            // txtOriginalName
            // 
            txtOriginalName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtOriginalName.Location = new Point(153, 49);
            txtOriginalName.Name = "txtOriginalName";
            txtOriginalName.ReadOnly = true;
            txtOriginalName.Size = new Size(906, 31);
            txtOriginalName.TabIndex = 2;
            // 
            // txtRenameTo
            // 
            txtRenameTo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRenameTo.Location = new Point(153, 99);
            txtRenameTo.Name = "txtRenameTo";
            txtRenameTo.ReadOnly = true;
            txtRenameTo.Size = new Size(906, 31);
            txtRenameTo.TabIndex = 3;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 4;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
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
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 5;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
            tableLayoutMain.Size = new Size(1330, 768);
            tableLayoutMain.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 360F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(selectionDetails1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(153, 591);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(906, 174);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // selectionDetails1
            // 
            selectionDetails1.Dock = DockStyle.Fill;
            selectionDetails1.Location = new Point(3, 3);
            selectionDetails1.Name = "selectionDetails1";
            selectionDetails1.Size = new Size(354, 168);
            selectionDetails1.TabIndex = 0;
            // 
            // graphicsPanel
            // 
            graphicsPanel.Dock = DockStyle.Fill;
            graphicsPanel.Location = new Point(153, 143);
            graphicsPanel.Name = "graphicsPanel";
            graphicsPanel.RootToken = null;
            graphicsPanel.Size = new Size(906, 442);
            graphicsPanel.TabIndex = 5;
            // 
            // btnRename
            // 
            btnRename.Dock = DockStyle.Fill;
            btnRename.Location = new Point(1065, 93);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(214, 44);
            btnRename.TabIndex = 6;
            btnRename.Text = "RENAME";
            btnRename.UseVisualStyleBackColor = true;
            // 
            // txtSeparators
            // 
            txtSeparators.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSeparators.Location = new Point(1065, 49);
            txtSeparators.Name = "txtSeparators";
            txtSeparators.Size = new Size(214, 31);
            txtSeparators.TabIndex = 7;
            // 
            // lblDefaultSepar
            // 
            lblDefaultSepar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDefaultSepar.AutoSize = true;
            lblDefaultSepar.Location = new Point(1065, 15);
            lblDefaultSepar.Name = "lblDefaultSepar";
            lblDefaultSepar.Size = new Size(159, 25);
            lblDefaultSepar.TabIndex = 8;
            lblDefaultSepar.Text = "Default Separators";
            // 
            // SelectionPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutMain);
            Name = "SelectionPage";
            Size = new Size(1330, 768);
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
