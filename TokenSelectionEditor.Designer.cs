namespace MEMPHIS_SHARP
{
    partial class TokenSelectionEditor
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
            lblText = new Label();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutPanelSeparators = new TableLayoutPanel();
            txtSeparators = new TextBox();
            btnDefaultSeparators = new Button();
            btnMoveRight = new Button();
            btnMoveLeft = new Button();
            btnClearSep = new Button();
            lblSepar = new Label();
            tableLayoutPanelText = new TableLayoutPanel();
            tableLayoutMain.SuspendLayout();
            tableLayoutPanelSeparators.SuspendLayout();
            tableLayoutPanelText.SuspendLayout();
            SuspendLayout();
            // 
            // txtSelection
            // 
            txtSelection.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSelection.Location = new Point(52, 6);
            txtSelection.Margin = new Padding(2);
            txtSelection.Name = "txtSelection";
            txtSelection.Size = new Size(253, 27);
            txtSelection.TabIndex = 0;
            txtSelection.KeyDown += txtSelection_KeyDown;
            // 
            // chkEnabled
            // 
            chkEnabled.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chkEnabled.AutoSize = true;
            chkEnabled.Location = new Point(456, 7);
            chkEnabled.Margin = new Padding(2);
            chkEnabled.Name = "chkEnabled";
            chkEnabled.Size = new Size(97, 24);
            chkEnabled.TabIndex = 1;
            chkEnabled.Text = "Enabled";
            chkEnabled.UseVisualStyleBackColor = true;
            chkEnabled.CheckedChanged += chkEnabled_CheckedChanged;
            // 
            // lblText
            // 
            lblText.Anchor = AnchorStyles.Right;
            lblText.AutoSize = true;
            lblText.Location = new Point(8, 9);
            lblText.Name = "lblText";
            lblText.Size = new Size(39, 20);
            lblText.TabIndex = 10;
            lblText.Text = "Text:";
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 3;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 16F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 16F));
            tableLayoutMain.Controls.Add(tableLayoutPanelSeparators, 1, 2);
            tableLayoutMain.Controls.Add(tableLayoutPanelText, 1, 1);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 4;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.Size = new Size(593, 140);
            tableLayoutMain.TabIndex = 11;
            // 
            // tableLayoutPanelSeparators
            // 
            tableLayoutPanelSeparators.ColumnCount = 9;
            tableLayoutPanelSeparators.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            tableLayoutPanelSeparators.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanelSeparators.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 98F));
            tableLayoutPanelSeparators.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tableLayoutPanelSeparators.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tableLayoutPanelSeparators.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanelSeparators.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelSeparators.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanelSeparators.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tableLayoutPanelSeparators.Controls.Add(txtSeparators, 2, 0);
            tableLayoutPanelSeparators.Controls.Add(btnDefaultSeparators, 5, 0);
            tableLayoutPanelSeparators.Controls.Add(btnMoveRight, 8, 0);
            tableLayoutPanelSeparators.Controls.Add(btnMoveLeft, 7, 0);
            tableLayoutPanelSeparators.Controls.Add(btnClearSep, 4, 0);
            tableLayoutPanelSeparators.Controls.Add(lblSepar, 1, 0);
            tableLayoutPanelSeparators.Dock = DockStyle.Fill;
            tableLayoutPanelSeparators.Location = new Point(19, 58);
            tableLayoutPanelSeparators.Name = "tableLayoutPanelSeparators";
            tableLayoutPanelSeparators.RowCount = 1;
            tableLayoutPanelSeparators.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelSeparators.Size = new Size(555, 39);
            tableLayoutPanelSeparators.TabIndex = 12;
            // 
            // txtSeparators
            // 
            txtSeparators.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSeparators.Location = new Point(144, 6);
            txtSeparators.Margin = new Padding(2);
            txtSeparators.Name = "txtSeparators";
            txtSeparators.Size = new Size(94, 27);
            txtSeparators.TabIndex = 2;
            // 
            // btnDefaultSeparators
            // 
            btnDefaultSeparators.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnDefaultSeparators.Font = new Font("Segoe UI", 7F);
            btnDefaultSeparators.Location = new Point(306, 6);
            btnDefaultSeparators.Margin = new Padding(2);
            btnDefaultSeparators.Name = "btnDefaultSeparators";
            btnDefaultSeparators.Size = new Size(32, 26);
            btnDefaultSeparators.TabIndex = 4;
            btnDefaultSeparators.Text = "\U0001f9f9";
            btnDefaultSeparators.UseVisualStyleBackColor = true;
            btnDefaultSeparators.Click += btnDefaultSeparators_Click;
            // 
            // btnMoveRight
            // 
            btnMoveRight.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnMoveRight.Location = new Point(511, 6);
            btnMoveRight.Margin = new Padding(2);
            btnMoveRight.Name = "btnMoveRight";
            btnMoveRight.Size = new Size(42, 26);
            btnMoveRight.TabIndex = 6;
            btnMoveRight.Text = "❯❯ ";
            btnMoveRight.UseVisualStyleBackColor = true;
            btnMoveRight.Click += btnMoveRight_Click;
            // 
            // btnMoveLeft
            // 
            btnMoveLeft.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnMoveLeft.Font = new Font("Segoe UI", 8F);
            btnMoveLeft.Location = new Point(471, 6);
            btnMoveLeft.Margin = new Padding(2);
            btnMoveLeft.Name = "btnMoveLeft";
            btnMoveLeft.Size = new Size(36, 26);
            btnMoveLeft.TabIndex = 5;
            btnMoveLeft.Text = "❮❮";
            btnMoveLeft.UseVisualStyleBackColor = true;
            btnMoveLeft.Click += btnMoveLeft_Click;
            // 
            // btnClearSep
            // 
            btnClearSep.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnClearSep.Font = new Font("Segoe UI", 8F);
            btnClearSep.Location = new Point(274, 6);
            btnClearSep.Margin = new Padding(2);
            btnClearSep.Name = "btnClearSep";
            btnClearSep.Size = new Size(28, 26);
            btnClearSep.TabIndex = 3;
            btnClearSep.Text = "✖";
            btnClearSep.UseVisualStyleBackColor = true;
            btnClearSep.Click += btnClearSep_Click;
            // 
            // lblSepar
            // 
            lblSepar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblSepar.AutoSize = true;
            lblSepar.Location = new Point(54, 9);
            lblSepar.Margin = new Padding(2, 0, 2, 0);
            lblSepar.Name = "lblSepar";
            lblSepar.Size = new Size(86, 20);
            lblSepar.TabIndex = 7;
            lblSepar.Text = "Separators:";
            // 
            // tableLayoutPanelText
            // 
            tableLayoutPanelText.ColumnCount = 4;
            tableLayoutPanelText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanelText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 257F));
            tableLayoutPanelText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 101F));
            tableLayoutPanelText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelText.Controls.Add(lblText, 0, 0);
            tableLayoutPanelText.Controls.Add(chkEnabled, 3, 0);
            tableLayoutPanelText.Controls.Add(txtSelection, 1, 0);
            tableLayoutPanelText.Dock = DockStyle.Fill;
            tableLayoutPanelText.Location = new Point(19, 13);
            tableLayoutPanelText.Name = "tableLayoutPanelText";
            tableLayoutPanelText.RowCount = 1;
            tableLayoutPanelText.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelText.Size = new Size(555, 39);
            tableLayoutPanelText.TabIndex = 12;
            // 
            // TokenSelectionEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutMain);
            Margin = new Padding(2);
            Name = "TokenSelectionEditor";
            Size = new Size(593, 140);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutPanelSeparators.ResumeLayout(false);
            tableLayoutPanelSeparators.PerformLayout();
            tableLayoutPanelText.ResumeLayout(false);
            tableLayoutPanelText.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtSelection;
        private CheckBox chkEnabled;
        private Label lblText;
        private TableLayoutPanel tableLayoutMain;
        private TableLayoutPanel tableLayoutPanelText;
        private TableLayoutPanel tableLayoutPanelSeparators;
        private TextBox txtSeparators;
        private Button btnDefaultSeparators;
        private Button btnMoveRight;
        private Button btnMoveLeft;
        private Button btnClearSep;
        private Label lblSepar;
    }
}
