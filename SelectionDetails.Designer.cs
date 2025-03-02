namespace MEMPHIS_SHARP
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
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutSeparator = new TableLayoutPanel();
            tableLayoutText = new TableLayoutPanel();
            tableLayoutMove = new TableLayoutPanel();
            grpSelection = new GroupBox();
            tableLayoutMain.SuspendLayout();
            tableLayoutSeparator.SuspendLayout();
            tableLayoutText.SuspendLayout();
            tableLayoutMove.SuspendLayout();
            grpSelection.SuspendLayout();
            SuspendLayout();
            // 
            // txtSelection
            // 
            txtSelection.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSelection.Location = new Point(2, 2);
            txtSelection.Margin = new Padding(2);
            txtSelection.Name = "txtSelection";
            txtSelection.Size = new Size(223, 27);
            txtSelection.TabIndex = 0;
            txtSelection.KeyDown += txtSelection_KeyDown;
            // 
            // chkEnabled
            // 
            chkEnabled.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chkEnabled.AutoSize = true;
            chkEnabled.Location = new Point(229, 7);
            chkEnabled.Margin = new Padding(2);
            chkEnabled.Name = "chkEnabled";
            chkEnabled.Size = new Size(24, 17);
            chkEnabled.TabIndex = 1;
            chkEnabled.UseVisualStyleBackColor = true;
            chkEnabled.CheckedChanged += chkEnabled_CheckedChanged;
            // 
            // txtSeparators
            // 
            txtSeparators.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSeparators.Location = new Point(2, 2);
            txtSeparators.Margin = new Padding(2);
            txtSeparators.Name = "txtSeparators";
            txtSeparators.Size = new Size(166, 27);
            txtSeparators.TabIndex = 2;
            // 
            // btnClearSep
            // 
            btnClearSep.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnClearSep.Location = new Point(172, 3);
            btnClearSep.Margin = new Padding(2);
            btnClearSep.Name = "btnClearSep";
            btnClearSep.Size = new Size(31, 26);
            btnClearSep.TabIndex = 3;
            btnClearSep.Text = "X";
            btnClearSep.UseVisualStyleBackColor = true;
            // 
            // btnDefaultSeparators
            // 
            btnDefaultSeparators.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnDefaultSeparators.Location = new Point(207, 3);
            btnDefaultSeparators.Margin = new Padding(2);
            btnDefaultSeparators.Name = "btnDefaultSeparators";
            btnDefaultSeparators.Size = new Size(46, 26);
            btnDefaultSeparators.TabIndex = 4;
            btnDefaultSeparators.Text = "Def.";
            btnDefaultSeparators.UseVisualStyleBackColor = true;
            // 
            // btnMoveLeft
            // 
            btnMoveLeft.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnMoveLeft.Location = new Point(2, 3);
            btnMoveLeft.Margin = new Padding(2);
            btnMoveLeft.Name = "btnMoveLeft";
            btnMoveLeft.Size = new Size(41, 26);
            btnMoveLeft.TabIndex = 5;
            btnMoveLeft.Text = "<<";
            btnMoveLeft.UseVisualStyleBackColor = true;
            // 
            // btnMoveRight
            // 
            btnMoveRight.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnMoveRight.Location = new Point(47, 3);
            btnMoveRight.Margin = new Padding(2);
            btnMoveRight.Name = "btnMoveRight";
            btnMoveRight.Size = new Size(41, 26);
            btnMoveRight.TabIndex = 6;
            btnMoveRight.Text = ">>";
            btnMoveRight.UseVisualStyleBackColor = true;
            // 
            // lblSepar
            // 
            lblSepar.Anchor = AnchorStyles.Right;
            lblSepar.AutoSize = true;
            lblSepar.Location = new Point(4, 53);
            lblSepar.Margin = new Padding(2, 0, 2, 0);
            lblSepar.Name = "lblSepar";
            lblSepar.Size = new Size(80, 36);
            lblSepar.TabIndex = 7;
            lblSepar.Text = "Separators:";
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 3;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutMain.Controls.Add(tableLayoutSeparator, 1, 2);
            tableLayoutMain.Controls.Add(tableLayoutText, 1, 1);
            tableLayoutMain.Controls.Add(lblSepar, 0, 2);
            tableLayoutMain.Controls.Add(tableLayoutMove, 1, 3);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(2, 22);
            tableLayoutMain.Margin = new Padding(2);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 5;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutMain.Size = new Size(353, 143);
            tableLayoutMain.TabIndex = 8;
            // 
            // tableLayoutSeparator
            // 
            tableLayoutSeparator.ColumnCount = 3;
            tableLayoutSeparator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutSeparator.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutSeparator.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutSeparator.Controls.Add(btnClearSep, 1, 0);
            tableLayoutSeparator.Controls.Add(btnDefaultSeparators, 2, 0);
            tableLayoutSeparator.Controls.Add(txtSeparators, 0, 0);
            tableLayoutSeparator.Dock = DockStyle.Fill;
            tableLayoutSeparator.Location = new Point(88, 55);
            tableLayoutSeparator.Margin = new Padding(2);
            tableLayoutSeparator.Name = "tableLayoutSeparator";
            tableLayoutSeparator.RowCount = 1;
            tableLayoutSeparator.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutSeparator.Size = new Size(255, 32);
            tableLayoutSeparator.TabIndex = 9;
            // 
            // tableLayoutText
            // 
            tableLayoutText.ColumnCount = 2;
            tableLayoutText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
            tableLayoutText.Controls.Add(chkEnabled, 1, 0);
            tableLayoutText.Controls.Add(txtSelection, 0, 0);
            tableLayoutText.Dock = DockStyle.Fill;
            tableLayoutText.Location = new Point(88, 19);
            tableLayoutText.Margin = new Padding(2);
            tableLayoutText.Name = "tableLayoutText";
            tableLayoutText.RowCount = 1;
            tableLayoutText.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutText.Size = new Size(255, 32);
            tableLayoutText.TabIndex = 9;
            // 
            // tableLayoutMove
            // 
            tableLayoutMove.ColumnCount = 3;
            tableLayoutMove.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutMove.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutMove.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMove.Controls.Add(btnMoveLeft, 0, 0);
            tableLayoutMove.Controls.Add(btnMoveRight, 1, 0);
            tableLayoutMove.Dock = DockStyle.Fill;
            tableLayoutMove.Location = new Point(88, 91);
            tableLayoutMove.Margin = new Padding(2);
            tableLayoutMove.Name = "tableLayoutMove";
            tableLayoutMove.RowCount = 1;
            tableLayoutMove.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMove.Size = new Size(255, 32);
            tableLayoutMove.TabIndex = 9;
            // 
            // grpSelection
            // 
            grpSelection.Controls.Add(tableLayoutMain);
            grpSelection.Dock = DockStyle.Fill;
            grpSelection.Location = new Point(0, 0);
            grpSelection.Margin = new Padding(2);
            grpSelection.Name = "grpSelection";
            grpSelection.Padding = new Padding(2);
            grpSelection.Size = new Size(357, 167);
            grpSelection.TabIndex = 9;
            grpSelection.TabStop = false;
            grpSelection.Text = "Selection Details";
            // 
            // SelectionDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpSelection);
            Margin = new Padding(2);
            Name = "SelectionDetails";
            Size = new Size(357, 167);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutMain.PerformLayout();
            tableLayoutSeparator.ResumeLayout(false);
            tableLayoutSeparator.PerformLayout();
            tableLayoutText.ResumeLayout(false);
            tableLayoutText.PerformLayout();
            tableLayoutMove.ResumeLayout(false);
            grpSelection.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutMain;
        private TableLayoutPanel tableLayoutMove;
        private TableLayoutPanel tableLayoutText;
        private TableLayoutPanel tableLayoutSeparator;
        private GroupBox grpSelection;
    }
}
