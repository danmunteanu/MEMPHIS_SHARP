﻿namespace MEMPHIS_SHARP
{
    partial class SelectionDetails
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
            txtSelection = new TextBox();
            chkEnabled = new CheckBox();
            txtSeparators = new TextBox();
            btnClearSep = new Button();
            btnDefaultSeparators = new Button();
            btnMoveLeft = new Button();
            btnMoveRight = new Button();
            lblSepar = new Label();
            lblText = new Label();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutMain.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtSelection
            // 
            txtSelection.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSelection.Location = new Point(62, 8);
            txtSelection.Margin = new Padding(2);
            txtSelection.Name = "txtSelection";
            txtSelection.Size = new Size(921, 31);
            txtSelection.TabIndex = 0;
            txtSelection.KeyDown += txtSelection_KeyDown;
            // 
            // chkEnabled
            // 
            chkEnabled.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chkEnabled.AutoSize = true;
            chkEnabled.Location = new Point(1010, 9);
            chkEnabled.Margin = new Padding(2);
            chkEnabled.Name = "chkEnabled";
            chkEnabled.Size = new Size(111, 29);
            chkEnabled.TabIndex = 1;
            chkEnabled.Text = "Enabled";
            chkEnabled.UseVisualStyleBackColor = true;
            chkEnabled.CheckedChanged += chkEnabled_CheckedChanged;
            // 
            // txtSeparators
            // 
            txtSeparators.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSeparators.Location = new Point(172, 8);
            txtSeparators.Margin = new Padding(2);
            txtSeparators.Name = "txtSeparators";
            txtSeparators.Size = new Size(126, 31);
            txtSeparators.TabIndex = 2;
            // 
            // btnClearSep
            // 
            btnClearSep.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnClearSep.Font = new Font("Segoe UI", 8F);
            btnClearSep.Location = new Point(342, 8);
            btnClearSep.Margin = new Padding(2);
            btnClearSep.Name = "btnClearSep";
            btnClearSep.Size = new Size(36, 32);
            btnClearSep.TabIndex = 3;
            btnClearSep.Text = "X";
            btnClearSep.UseVisualStyleBackColor = true;
            // 
            // btnDefaultSeparators
            // 
            btnDefaultSeparators.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnDefaultSeparators.Font = new Font("Segoe UI", 8F);
            btnDefaultSeparators.Location = new Point(382, 8);
            btnDefaultSeparators.Margin = new Padding(2);
            btnDefaultSeparators.Name = "btnDefaultSeparators";
            btnDefaultSeparators.Size = new Size(86, 32);
            btnDefaultSeparators.TabIndex = 4;
            btnDefaultSeparators.Text = "DEFAULT";
            btnDefaultSeparators.UseVisualStyleBackColor = true;
            // 
            // btnMoveLeft
            // 
            btnMoveLeft.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnMoveLeft.Location = new Point(985, 8);
            btnMoveLeft.Margin = new Padding(2);
            btnMoveLeft.Name = "btnMoveLeft";
            btnMoveLeft.Size = new Size(61, 32);
            btnMoveLeft.TabIndex = 5;
            btnMoveLeft.Text = "<<";
            btnMoveLeft.UseVisualStyleBackColor = true;
            // 
            // btnMoveRight
            // 
            btnMoveRight.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnMoveRight.Location = new Point(1050, 8);
            btnMoveRight.Margin = new Padding(2);
            btnMoveRight.Name = "btnMoveRight";
            btnMoveRight.Size = new Size(71, 32);
            btnMoveRight.TabIndex = 6;
            btnMoveRight.Text = ">>";
            btnMoveRight.UseVisualStyleBackColor = true;
            // 
            // lblSepar
            // 
            lblSepar.Anchor = AnchorStyles.Right;
            lblSepar.AutoSize = true;
            lblSepar.Location = new Point(67, 11);
            lblSepar.Margin = new Padding(2, 0, 2, 0);
            lblSepar.Name = "lblSepar";
            lblSepar.Size = new Size(101, 25);
            lblSepar.TabIndex = 7;
            lblSepar.Text = "Separators:";
            // 
            // lblText
            // 
            lblText.Anchor = AnchorStyles.Right;
            lblText.AutoSize = true;
            lblText.Location = new Point(10, 11);
            lblText.Margin = new Padding(4, 0, 4, 0);
            lblText.Name = "lblText";
            lblText.Size = new Size(46, 25);
            lblText.TabIndex = 10;
            lblText.Text = "Text:";
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 3;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutMain.Controls.Add(tableLayoutPanel1, 1, 1);
            tableLayoutMain.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Margin = new Padding(4);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 4;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutMain.Size = new Size(1171, 194);
            tableLayoutMain.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
            tableLayoutPanel1.Controls.Add(lblText, 0, 0);
            tableLayoutPanel1.Controls.Add(chkEnabled, 3, 0);
            tableLayoutPanel1.Controls.Add(txtSelection, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(24, 45);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1123, 48);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 9;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanel2.Controls.Add(txtSeparators, 2, 0);
            tableLayoutPanel2.Controls.Add(btnDefaultSeparators, 5, 0);
            tableLayoutPanel2.Controls.Add(btnMoveRight, 8, 0);
            tableLayoutPanel2.Controls.Add(btnMoveLeft, 7, 0);
            tableLayoutPanel2.Controls.Add(btnClearSep, 4, 0);
            tableLayoutPanel2.Controls.Add(lblSepar, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(24, 101);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1123, 48);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // SelectionDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutMain);
            Margin = new Padding(2);
            Name = "SelectionDetails";
            Size = new Size(1171, 194);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtSelection;
        private CheckBox chkEnabled;
        private TextBox txtSeparators;
        private Button btnClearSep;
        private Button btnDefaultSeparators;
        private Button btnMoveLeft;
        private Button btnMoveRight;
        private Label lblSepar;
        private Label lblText;
        private TableLayoutPanel tableLayoutMain;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
