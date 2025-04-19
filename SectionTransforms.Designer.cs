﻿namespace MEMPHIS_SHARP
{
    partial class TransformsListUI
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
            components = new System.ComponentModel.Container();
            tableLayoutTransforms = new TableLayoutPanel();
            lblTrans = new Label();
            lstTransforms = new ListBox();
            tableLayoutPanelButtons = new TableLayoutPanel();
            btnLink = new Button();
            btnToggle = new Button();
            btnDown = new Button();
            btnAdd = new Button();
            btnUp = new Button();
            btnClear = new Button();
            btnRem = new Button();
            btnEdit = new Button();
            btnTemplates = new Button();
            btnReload = new Button();
            toolTip = new ToolTip(components);
            tableLayoutTransforms.SuspendLayout();
            tableLayoutPanelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutTransforms
            // 
            tableLayoutTransforms.ColumnCount = 1;
            tableLayoutTransforms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutTransforms.Controls.Add(lblTrans, 0, 0);
            tableLayoutTransforms.Controls.Add(lstTransforms, 0, 1);
            tableLayoutTransforms.Controls.Add(tableLayoutPanelButtons, 0, 2);
            tableLayoutTransforms.Dock = DockStyle.Fill;
            tableLayoutTransforms.Location = new Point(0, 0);
            tableLayoutTransforms.Margin = new Padding(2);
            tableLayoutTransforms.Name = "tableLayoutTransforms";
            tableLayoutTransforms.RowCount = 3;
            tableLayoutTransforms.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutTransforms.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutTransforms.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutTransforms.Size = new Size(414, 452);
            tableLayoutTransforms.TabIndex = 0;
            // 
            // lblTrans
            // 
            lblTrans.Anchor = AnchorStyles.Left;
            lblTrans.AutoSize = true;
            lblTrans.Location = new Point(2, 8);
            lblTrans.Margin = new Padding(2, 0, 2, 0);
            lblTrans.Name = "lblTrans";
            lblTrans.Size = new Size(128, 20);
            lblTrans.TabIndex = 0;
            lblTrans.Text = "List of Transforms:";
            // 
            // lstTransforms
            // 
            lstTransforms.Dock = DockStyle.Fill;
            lstTransforms.FormattingEnabled = true;
            lstTransforms.Location = new Point(2, 38);
            lstTransforms.Margin = new Padding(2);
            lstTransforms.Name = "lstTransforms";
            lstTransforms.Size = new Size(410, 368);
            lstTransforms.TabIndex = 1;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.ColumnCount = 13;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanelButtons.Controls.Add(btnLink, 3, 0);
            tableLayoutPanelButtons.Controls.Add(btnToggle, 2, 0);
            tableLayoutPanelButtons.Controls.Add(btnDown, 7, 0);
            tableLayoutPanelButtons.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanelButtons.Controls.Add(btnUp, 6, 0);
            tableLayoutPanelButtons.Controls.Add(btnClear, 12, 0);
            tableLayoutPanelButtons.Controls.Add(btnRem, 4, 0);
            tableLayoutPanelButtons.Controls.Add(btnEdit, 1, 0);
            tableLayoutPanelButtons.Controls.Add(btnTemplates, 10, 0);
            tableLayoutPanelButtons.Controls.Add(btnReload, 9, 0);
            tableLayoutPanelButtons.Dock = DockStyle.Fill;
            tableLayoutPanelButtons.Location = new Point(2, 410);
            tableLayoutPanelButtons.Margin = new Padding(2);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.Size = new Size(410, 40);
            tableLayoutPanelButtons.TabIndex = 2;
            // 
            // btnLink
            // 
            btnLink.Dock = DockStyle.Fill;
            btnLink.Location = new Point(110, 2);
            btnLink.Margin = new Padding(2);
            btnLink.Name = "btnLink";
            btnLink.Size = new Size(32, 36);
            btnLink.TabIndex = 7;
            btnLink.Text = "🔗";
            btnLink.UseVisualStyleBackColor = true;
            // 
            // btnToggle
            // 
            btnToggle.Dock = DockStyle.Fill;
            btnToggle.Location = new Point(74, 2);
            btnToggle.Margin = new Padding(2);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(32, 36);
            btnToggle.TabIndex = 6;
            btnToggle.Text = "■";
            btnToggle.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            btnDown.Dock = DockStyle.Fill;
            btnDown.Location = new Point(228, 2);
            btnDown.Margin = new Padding(2);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(32, 36);
            btnDown.TabIndex = 4;
            btnDown.Text = "▼";
            btnDown.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Location = new Point(2, 2);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(32, 36);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "✚";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            btnUp.Dock = DockStyle.Fill;
            btnUp.Location = new Point(192, 2);
            btnUp.Margin = new Padding(2);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(32, 36);
            btnUp.TabIndex = 2;
            btnUp.Text = "▲";
            btnUp.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Location = new Point(376, 2);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(32, 36);
            btnClear.TabIndex = 3;
            btnClear.Text = "✖";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnRem
            // 
            btnRem.Dock = DockStyle.Fill;
            btnRem.Location = new Point(146, 2);
            btnRem.Margin = new Padding(2);
            btnRem.Name = "btnRem";
            btnRem.Size = new Size(32, 36);
            btnRem.TabIndex = 1;
            btnRem.Text = "━";
            btnRem.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Location = new Point(38, 2);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(32, 36);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "✎";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnTemplates
            // 
            btnTemplates.Dock = DockStyle.Fill;
            btnTemplates.Location = new Point(320, 2);
            btnTemplates.Margin = new Padding(2);
            btnTemplates.Name = "btnTemplates";
            btnTemplates.Size = new Size(32, 36);
            btnTemplates.TabIndex = 9;
            btnTemplates.Text = "📂";
            btnTemplates.UseVisualStyleBackColor = true;
            // 
            // btnReload
            // 
            btnReload.Dock = DockStyle.Fill;
            btnReload.Location = new Point(285, 3);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(30, 34);
            btnReload.TabIndex = 10;
            btnReload.Text = "⭮";
            btnReload.UseVisualStyleBackColor = true;
            // 
            // TransformsListUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutTransforms);
            Margin = new Padding(2);
            Name = "TransformsListUI";
            Size = new Size(414, 452);
            tableLayoutTransforms.ResumeLayout(false);
            tableLayoutTransforms.PerformLayout();
            tableLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        protected TableLayoutPanel tableLayoutTransforms;
        protected Label lblTrans;
        protected ListBox lstTransforms;
        protected TableLayoutPanel tableLayoutPanelButtons;
        protected Button btnAdd;
        protected Button btnRem;
        protected Button btnUp;
        protected Button btnClear;
        protected Button btnDown;
        protected Button btnEdit;
        protected Button btnToggle;
        protected Button btnLink;
        protected Button btnTemplates;
        protected ToolTip toolTip;
        protected Button btnReload;
    }
}
