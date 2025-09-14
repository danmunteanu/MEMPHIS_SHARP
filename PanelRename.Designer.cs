namespace MEMPHIS_SHARP
{
    partial class PanelRename
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
            tableLayoutRename = new TableLayoutPanel();
            txtRenameTo = new TextBox();
            txtOriginalName = new TextBox();
            btnRename = new Button();
            txtSeparators = new TextBox();
            lblOriginalName = new Label();
            lblSepar = new Label();
            lblRenameTo = new Label();
            tableLayoutRename.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutRename
            // 
            tableLayoutRename.ColumnCount = 3;
            tableLayoutRename.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutRename.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            tableLayoutRename.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutRename.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutRename.Controls.Add(txtRenameTo, 0, 3);
            tableLayoutRename.Controls.Add(txtOriginalName, 0, 1);
            tableLayoutRename.Controls.Add(btnRename, 1, 3);
            tableLayoutRename.Controls.Add(txtSeparators, 1, 1);
            tableLayoutRename.Controls.Add(lblOriginalName, 0, 0);
            tableLayoutRename.Controls.Add(lblSepar, 1, 0);
            tableLayoutRename.Controls.Add(lblRenameTo, 0, 2);
            tableLayoutRename.Dock = DockStyle.Fill;
            tableLayoutRename.Location = new Point(0, 0);
            tableLayoutRename.Margin = new Padding(2, 4, 2, 4);
            tableLayoutRename.Name = "tableLayoutRename";
            tableLayoutRename.RowCount = 5;
            tableLayoutRename.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutRename.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutRename.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutRename.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutRename.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutRename.Size = new Size(892, 182);
            tableLayoutRename.TabIndex = 6;
            // 
            // txtRenameTo
            // 
            txtRenameTo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRenameTo.Location = new Point(2, 117);
            txtRenameTo.Margin = new Padding(2, 4, 2, 4);
            txtRenameTo.Name = "txtRenameTo";
            txtRenameTo.ReadOnly = true;
            txtRenameTo.Size = new Size(688, 31);
            txtRenameTo.TabIndex = 3;
            // 
            // txtOriginalName
            // 
            txtOriginalName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtOriginalName.Location = new Point(2, 32);
            txtOriginalName.Margin = new Padding(2, 4, 2, 4);
            txtOriginalName.Name = "txtOriginalName";
            txtOriginalName.ReadOnly = true;
            txtOriginalName.Size = new Size(688, 31);
            txtOriginalName.TabIndex = 2;
            // 
            // btnRename
            // 
            btnRename.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnRename.Location = new Point(694, 115);
            btnRename.Margin = new Padding(2, 4, 2, 4);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(171, 36);
            btnRename.TabIndex = 6;
            btnRename.Text = "RENAME";
            btnRename.UseVisualStyleBackColor = true;
            btnRename.Click += btnRename_Click;
            // 
            // txtSeparators
            // 
            txtSeparators.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSeparators.Location = new Point(694, 32);
            txtSeparators.Margin = new Padding(2, 4, 2, 4);
            txtSeparators.Name = "txtSeparators";
            txtSeparators.Size = new Size(171, 31);
            txtSeparators.TabIndex = 7;
            // 
            // lblOriginalName
            // 
            lblOriginalName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblOriginalName.AutoSize = true;
            lblOriginalName.Location = new Point(2, 0);
            lblOriginalName.Margin = new Padding(2, 0, 2, 0);
            lblOriginalName.Name = "lblOriginalName";
            lblOriginalName.Size = new Size(126, 23);
            lblOriginalName.TabIndex = 0;
            lblOriginalName.Text = "Original Name";
            // 
            // lblSepar
            // 
            lblSepar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSepar.AutoSize = true;
            lblSepar.Location = new Point(694, 0);
            lblSepar.Margin = new Padding(2, 0, 2, 0);
            lblSepar.Name = "lblSepar";
            lblSepar.Size = new Size(159, 23);
            lblSepar.TabIndex = 8;
            lblSepar.Text = "Default Separators";
            // 
            // lblRenameTo
            // 
            lblRenameTo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRenameTo.AutoSize = true;
            lblRenameTo.Location = new Point(2, 83);
            lblRenameTo.Margin = new Padding(2, 0, 2, 0);
            lblRenameTo.Name = "lblRenameTo";
            lblRenameTo.Size = new Size(98, 25);
            lblRenameTo.TabIndex = 1;
            lblRenameTo.Text = "Rename To";
            // 
            // PanelRename
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutRename);
            Margin = new Padding(4);
            Name = "PanelRename";
            Size = new Size(892, 182);
            tableLayoutRename.ResumeLayout(false);
            tableLayoutRename.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutRename;
        private Label lblOriginalName;
        private TextBox txtRenameTo;
        private Label lblRenameTo;
        private TextBox txtOriginalName;
        private Button btnRename;
        private TextBox txtSeparators;
        private Label lblSepar;
    }
}
