namespace MEMPHIS_SHARP
{
    partial class ListTransforms
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
            tableLayoutTransforms = new TableLayoutPanel();
            lblTrans = new Label();
            lstTransforms = new ListBox();
            tableLayoutPanelButtons = new TableLayoutPanel();
            btnDown = new Button();
            btnAdd = new Button();
            btnUp = new Button();
            btnClear = new Button();
            btnRem = new Button();
            btnEdit = new Button();
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
            tableLayoutTransforms.Name = "tableLayoutTransforms";
            tableLayoutTransforms.RowCount = 3;
            tableLayoutTransforms.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutTransforms.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutTransforms.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutTransforms.Size = new Size(518, 565);
            tableLayoutTransforms.TabIndex = 0;
            // 
            // lblTrans
            // 
            lblTrans.Anchor = AnchorStyles.Left;
            lblTrans.AutoSize = true;
            lblTrans.Location = new Point(3, 10);
            lblTrans.Name = "lblTrans";
            lblTrans.Size = new Size(99, 25);
            lblTrans.TabIndex = 0;
            lblTrans.Text = "Transforms";
            // 
            // lstTransforms
            // 
            lstTransforms.Dock = DockStyle.Fill;
            lstTransforms.FormattingEnabled = true;
            lstTransforms.ItemHeight = 25;
            lstTransforms.Location = new Point(3, 48);
            lstTransforms.Name = "lstTransforms";
            lstTransforms.Size = new Size(512, 459);
            lstTransforms.TabIndex = 1;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.ColumnCount = 7;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanelButtons.Controls.Add(btnDown, 4, 0);
            tableLayoutPanelButtons.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanelButtons.Controls.Add(btnUp, 3, 0);
            tableLayoutPanelButtons.Controls.Add(btnClear, 6, 0);
            tableLayoutPanelButtons.Controls.Add(btnEdit, 2, 0);
            tableLayoutPanelButtons.Controls.Add(btnRem, 1, 0);
            tableLayoutPanelButtons.Dock = DockStyle.Fill;
            tableLayoutPanelButtons.Location = new Point(3, 513);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.Size = new Size(512, 49);
            tableLayoutPanelButtons.TabIndex = 2;
            // 
            // btnDown
            // 
            btnDown.Dock = DockStyle.Fill;
            btnDown.Location = new Point(183, 3);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(39, 43);
            btnDown.TabIndex = 4;
            btnDown.Text = "▼";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDown_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(39, 43);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "✚";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUp
            // 
            btnUp.Dock = DockStyle.Fill;
            btnUp.Location = new Point(138, 3);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(39, 43);
            btnUp.TabIndex = 2;
            btnUp.Text = "▲";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Location = new Point(470, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(39, 43);
            btnClear.TabIndex = 3;
            btnClear.Text = "✖";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnRem
            // 
            btnRem.Dock = DockStyle.Fill;
            btnRem.Location = new Point(48, 3);
            btnRem.Name = "btnRem";
            btnRem.Size = new Size(39, 43);
            btnRem.TabIndex = 1;
            btnRem.Text = "━";
            btnRem.UseVisualStyleBackColor = true;
            btnRem.Click += btnRem_Click;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Location = new Point(93, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(39, 43);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "✎";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // ListTransforms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutTransforms);
            Name = "ListTransforms";
            Size = new Size(518, 565);
            tableLayoutTransforms.ResumeLayout(false);
            tableLayoutTransforms.PerformLayout();
            tableLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutTransforms;
        private Label lblTrans;
        private ListBox lstTransforms;
        private TableLayoutPanel tableLayoutPanelButtons;
        private Button btnAdd;
        private Button btnRem;
        private Button btnUp;
        private Button btnClear;
        private Button btnDown;
        private Button btnEdit;
    }
}
