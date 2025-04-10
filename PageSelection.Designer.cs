﻿namespace MEMPHIS_SHARP
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
            btnRename = new Button();
            txtSeparators = new TextBox();
            lblDefaultSepar = new Label();
            selectionDetails = new SelectionDetails();
            compTransforms = new SectionTransforms();
            tableLayoutBottom = new TableLayoutPanel();
            tableLayoutRight = new TableLayoutPanel();
            tableLayoutLeft = new TableLayoutPanel();
            tableLayoutAll = new TableLayoutPanel();
            scenePainter = new ScenePainter();
            tableLayoutMain.SuspendLayout();
            tableLayoutBottom.SuspendLayout();
            tableLayoutRight.SuspendLayout();
            tableLayoutLeft.SuspendLayout();
            tableLayoutAll.SuspendLayout();
            SuspendLayout();
            // 
            // lblOriginal
            // 
            lblOriginal.Anchor = AnchorStyles.Right;
            lblOriginal.AutoSize = true;
            lblOriginal.Location = new Point(16, 19);
            lblOriginal.Margin = new Padding(2, 0, 2, 0);
            lblOriginal.Name = "lblOriginal";
            lblOriginal.Size = new Size(87, 15);
            lblOriginal.TabIndex = 0;
            lblOriginal.Text = "Original Name:";
            // 
            // lblRenameTo
            // 
            lblRenameTo.Anchor = AnchorStyles.Right;
            lblRenameTo.AutoSize = true;
            lblRenameTo.Location = new Point(35, 49);
            lblRenameTo.Margin = new Padding(2, 0, 2, 0);
            lblRenameTo.Name = "lblRenameTo";
            lblRenameTo.Size = new Size(68, 15);
            lblRenameTo.TabIndex = 1;
            lblRenameTo.Text = "Rename To:";
            // 
            // txtOriginalName
            // 
            txtOriginalName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtOriginalName.Location = new Point(107, 15);
            txtOriginalName.Margin = new Padding(2);
            txtOriginalName.Name = "txtOriginalName";
            txtOriginalName.ReadOnly = true;
            txtOriginalName.Size = new Size(605, 23);
            txtOriginalName.TabIndex = 2;
            // 
            // txtRenameTo
            // 
            txtRenameTo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRenameTo.Location = new Point(107, 45);
            txtRenameTo.Margin = new Padding(2);
            txtRenameTo.Name = "txtRenameTo";
            txtRenameTo.ReadOnly = true;
            txtRenameTo.Size = new Size(605, 23);
            txtRenameTo.TabIndex = 3;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 4;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33F));
            tableLayoutMain.Controls.Add(lblOriginal, 0, 1);
            tableLayoutMain.Controls.Add(txtRenameTo, 1, 2);
            tableLayoutMain.Controls.Add(lblRenameTo, 0, 2);
            tableLayoutMain.Controls.Add(txtOriginalName, 1, 1);
            tableLayoutMain.Controls.Add(btnRename, 2, 2);
            tableLayoutMain.Controls.Add(txtSeparators, 2, 1);
            tableLayoutMain.Controls.Add(lblDefaultSepar, 2, 0);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(2, 2);
            tableLayoutMain.Margin = new Padding(2);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 4;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutMain.Size = new Size(869, 87);
            tableLayoutMain.TabIndex = 4;
            // 
            // btnRename
            // 
            btnRename.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnRename.Location = new Point(716, 46);
            btnRename.Margin = new Padding(2);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(118, 22);
            btnRename.TabIndex = 6;
            btnRename.Text = "RENAME";
            btnRename.UseVisualStyleBackColor = true;
            // 
            // txtSeparators
            // 
            txtSeparators.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSeparators.Location = new Point(716, 15);
            txtSeparators.Margin = new Padding(2);
            txtSeparators.Name = "txtSeparators";
            txtSeparators.Size = new Size(118, 23);
            txtSeparators.TabIndex = 7;
            // 
            // lblDefaultSepar
            // 
            lblDefaultSepar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDefaultSepar.AutoSize = true;
            lblDefaultSepar.Location = new Point(716, 0);
            lblDefaultSepar.Margin = new Padding(2, 0, 2, 0);
            lblDefaultSepar.Name = "lblDefaultSepar";
            lblDefaultSepar.Size = new Size(103, 12);
            lblDefaultSepar.TabIndex = 8;
            lblDefaultSepar.Text = "Default Separators";
            // 
            // selectionDetails
            // 
            selectionDetails.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            selectionDetails.Location = new Point(2, 7);
            selectionDetails.Margin = new Padding(2);
            selectionDetails.Name = "selectionDetails";
            selectionDetails.Size = new Size(206, 102);
            selectionDetails.TabIndex = 0;
            selectionDetails.Token = null;
            // 
            // compTransforms
            // 
            compTransforms.Dock = DockStyle.Fill;
            compTransforms.Location = new Point(2, 2);
            compTransforms.Margin = new Padding(2, 2, 2, 2);
            compTransforms.Name = "compTransforms";
            compTransforms.Size = new Size(254, 540);
            compTransforms.TabIndex = 6;
            compTransforms.TransformsContainer = null;
            // 
            // tableLayoutBottom
            // 
            tableLayoutBottom.ColumnCount = 2;
            tableLayoutBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 210F));
            tableLayoutBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutBottom.Controls.Add(selectionDetails, 0, 0);
            tableLayoutBottom.Dock = DockStyle.Fill;
            tableLayoutBottom.Location = new Point(2, 277);
            tableLayoutBottom.Margin = new Padding(2);
            tableLayoutBottom.Name = "tableLayoutBottom";
            tableLayoutBottom.RowCount = 1;
            tableLayoutBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutBottom.Size = new Size(869, 116);
            tableLayoutBottom.TabIndex = 7;
            // 
            // tableLayoutRight
            // 
            tableLayoutRight.ColumnCount = 1;
            tableLayoutRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutRight.Controls.Add(compTransforms, 0, 0);
            tableLayoutRight.Dock = DockStyle.Fill;
            tableLayoutRight.Location = new Point(879, 2);
            tableLayoutRight.Margin = new Padding(2);
            tableLayoutRight.Name = "tableLayoutRight";
            tableLayoutRight.RowCount = 1;
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 545F));
            tableLayoutRight.Size = new Size(258, 544);
            tableLayoutRight.TabIndex = 8;
            // 
            // tableLayoutLeft
            // 
            tableLayoutLeft.ColumnCount = 1;
            tableLayoutLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutLeft.Controls.Add(tableLayoutMain, 0, 0);
            tableLayoutLeft.Controls.Add(tableLayoutBottom, 0, 2);
            tableLayoutLeft.Controls.Add(scenePainter, 0, 1);
            tableLayoutLeft.Dock = DockStyle.Fill;
            tableLayoutLeft.Location = new Point(2, 2);
            tableLayoutLeft.Margin = new Padding(2);
            tableLayoutLeft.Name = "tableLayoutLeft";
            tableLayoutLeft.RowCount = 4;
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 184F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutLeft.Size = new Size(873, 544);
            tableLayoutLeft.TabIndex = 9;
            // 
            // tableLayoutAll
            // 
            tableLayoutAll.ColumnCount = 2;
            tableLayoutAll.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutAll.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 262F));
            tableLayoutAll.Controls.Add(tableLayoutRight, 1, 0);
            tableLayoutAll.Controls.Add(tableLayoutLeft, 0, 0);
            tableLayoutAll.Dock = DockStyle.Fill;
            tableLayoutAll.Location = new Point(0, 0);
            tableLayoutAll.Margin = new Padding(2);
            tableLayoutAll.Name = "tableLayoutAll";
            tableLayoutAll.RowCount = 1;
            tableLayoutAll.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutAll.Size = new Size(1139, 548);
            tableLayoutAll.TabIndex = 10;
            // 
            // scenePainter
            // 
            scenePainter.Dock = DockStyle.Fill;
            scenePainter.Location = new Point(3, 94);
            scenePainter.Name = "scenePainter";
            scenePainter.Size = new Size(867, 178);
            scenePainter.TabIndex = 8;
            // 
            // PageSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutAll);
            Margin = new Padding(2);
            Name = "PageSelection";
            Size = new Size(1139, 548);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutMain.PerformLayout();
            tableLayoutBottom.ResumeLayout(false);
            tableLayoutRight.ResumeLayout(false);
            tableLayoutLeft.ResumeLayout(false);
            tableLayoutAll.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblOriginal;
        private Label lblRenameTo;
        private TextBox txtOriginalName;
        private TextBox txtRenameTo;
        private TableLayoutPanel tableLayoutMain;
        private Button btnRename;
        private TextBox txtSeparators;
        private Label lblDefaultSepar;
        private SelectionDetails selectionDetails;
        private SectionTransforms compTransforms;
        private TableLayoutPanel tableLayoutBottom;
        private TableLayoutPanel tableLayoutRight;
        private TableLayoutPanel tableLayoutLeft;
        private TableLayoutPanel tableLayoutAll;
        private ScenePainter scenePainter;
    }
}
