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
            lblOriginalName = new Label();
            txtRenameTo = new TextBox();
            lblRenameTo = new Label();
            txtOriginalName = new TextBox();
            btnRename = new Button();
            txtSeparators = new TextBox();
            tableLayoutRename.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutRename
            // 
            tableLayoutRename.ColumnCount = 4;
            tableLayoutRename.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutRename.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutRename.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutRename.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutRename.Controls.Add(lblOriginalName, 0, 1);
            tableLayoutRename.Controls.Add(txtRenameTo, 1, 2);
            tableLayoutRename.Controls.Add(lblRenameTo, 0, 2);
            tableLayoutRename.Controls.Add(txtOriginalName, 1, 1);
            tableLayoutRename.Controls.Add(btnRename, 2, 2);
            tableLayoutRename.Controls.Add(txtSeparators, 2, 1);
            tableLayoutRename.Dock = DockStyle.Fill;
            tableLayoutRename.Location = new Point(0, 0);
            tableLayoutRename.Margin = new Padding(2, 3, 2, 3);
            tableLayoutRename.Name = "tableLayoutRename";
            tableLayoutRename.RowCount = 4;
            tableLayoutRename.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutRename.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutRename.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutRename.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutRename.Size = new Size(714, 146);
            tableLayoutRename.TabIndex = 6;
            // 
            // lblOriginalName
            // 
            lblOriginalName.Anchor = AnchorStyles.Right;
            lblOriginalName.AutoSize = true;
            lblOriginalName.Location = new Point(9, 43);
            lblOriginalName.Margin = new Padding(2, 0, 2, 0);
            lblOriginalName.Name = "lblOriginalName";
            lblOriginalName.Size = new Size(109, 20);
            lblOriginalName.TabIndex = 0;
            lblOriginalName.Text = "Original Name:";
            // 
            // txtRenameTo
            // 
            txtRenameTo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRenameTo.Location = new Point(122, 79);
            txtRenameTo.Margin = new Padding(2, 3, 2, 3);
            txtRenameTo.Name = "txtRenameTo";
            txtRenameTo.ReadOnly = true;
            txtRenameTo.Size = new Size(430, 27);
            txtRenameTo.TabIndex = 3;
            // 
            // lblRenameTo
            // 
            lblRenameTo.Anchor = AnchorStyles.Right;
            lblRenameTo.AutoSize = true;
            lblRenameTo.Location = new Point(32, 83);
            lblRenameTo.Margin = new Padding(2, 0, 2, 0);
            lblRenameTo.Name = "lblRenameTo";
            lblRenameTo.Size = new Size(86, 20);
            lblRenameTo.TabIndex = 1;
            lblRenameTo.Text = "Rename To:";
            // 
            // txtOriginalName
            // 
            txtOriginalName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtOriginalName.Location = new Point(122, 39);
            txtOriginalName.Margin = new Padding(2, 3, 2, 3);
            txtOriginalName.Name = "txtOriginalName";
            txtOriginalName.ReadOnly = true;
            txtOriginalName.Size = new Size(430, 27);
            txtOriginalName.TabIndex = 2;
            // 
            // btnRename
            // 
            btnRename.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnRename.Location = new Point(556, 78);
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
            txtSeparators.Location = new Point(556, 39);
            txtSeparators.Margin = new Padding(2, 3, 2, 3);
            txtSeparators.Name = "txtSeparators";
            txtSeparators.Size = new Size(136, 27);
            txtSeparators.TabIndex = 7;
            // 
            // PanelRename
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutRename);
            Name = "PanelRename";
            Size = new Size(714, 146);
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
    }
}
