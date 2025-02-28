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
            textBox1 = new TextBox();
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
            txtSelection.Location = new Point(3, 4);
            txtSelection.Name = "txtSelection";
            txtSelection.Size = new Size(257, 31);
            txtSelection.TabIndex = 0;
            // 
            // chkEnabled
            // 
            chkEnabled.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chkEnabled.AutoSize = true;
            chkEnabled.Location = new Point(266, 9);
            chkEnabled.Name = "chkEnabled";
            chkEnabled.Size = new Size(29, 21);
            chkEnabled.TabIndex = 1;
            chkEnabled.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 31);
            textBox1.TabIndex = 2;
            // 
            // btnClearSep
            // 
            btnClearSep.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnClearSep.Location = new Point(201, 3);
            btnClearSep.Name = "btnClearSep";
            btnClearSep.Size = new Size(39, 33);
            btnClearSep.TabIndex = 3;
            btnClearSep.Text = "X";
            btnClearSep.UseVisualStyleBackColor = true;
            // 
            // btnDefaultSeparators
            // 
            btnDefaultSeparators.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnDefaultSeparators.Location = new Point(246, 3);
            btnDefaultSeparators.Name = "btnDefaultSeparators";
            btnDefaultSeparators.Size = new Size(49, 33);
            btnDefaultSeparators.TabIndex = 4;
            btnDefaultSeparators.Text = "Def.";
            btnDefaultSeparators.UseVisualStyleBackColor = true;
            // 
            // btnMoveLeft
            // 
            btnMoveLeft.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnMoveLeft.Location = new Point(3, 3);
            btnMoveLeft.Name = "btnMoveLeft";
            btnMoveLeft.Size = new Size(44, 33);
            btnMoveLeft.TabIndex = 5;
            btnMoveLeft.Text = "<<";
            btnMoveLeft.UseVisualStyleBackColor = true;
            // 
            // btnMoveRight
            // 
            btnMoveRight.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnMoveRight.Location = new Point(53, 3);
            btnMoveRight.Name = "btnMoveRight";
            btnMoveRight.Size = new Size(44, 33);
            btnMoveRight.TabIndex = 6;
            btnMoveRight.Text = ">>";
            btnMoveRight.UseVisualStyleBackColor = true;
            // 
            // lblSepar
            // 
            lblSepar.Anchor = AnchorStyles.Right;
            lblSepar.AutoSize = true;
            lblSepar.Location = new Point(4, 77);
            lblSepar.Name = "lblSepar";
            lblSepar.Size = new Size(101, 25);
            lblSepar.TabIndex = 7;
            lblSepar.Text = "Separators:";
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 3;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutMain.Controls.Add(tableLayoutSeparator, 1, 2);
            tableLayoutMain.Controls.Add(tableLayoutText, 1, 1);
            tableLayoutMain.Controls.Add(lblSepar, 0, 2);
            tableLayoutMain.Controls.Add(tableLayoutMove, 1, 3);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(3, 27);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 5;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutMain.Size = new Size(422, 179);
            tableLayoutMain.TabIndex = 8;
            // 
            // tableLayoutSeparator
            // 
            tableLayoutSeparator.ColumnCount = 3;
            tableLayoutSeparator.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutSeparator.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutSeparator.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableLayoutSeparator.Controls.Add(btnClearSep, 1, 0);
            tableLayoutSeparator.Controls.Add(btnDefaultSeparators, 2, 0);
            tableLayoutSeparator.Controls.Add(textBox1, 0, 0);
            tableLayoutSeparator.Dock = DockStyle.Fill;
            tableLayoutSeparator.Location = new Point(111, 70);
            tableLayoutSeparator.Name = "tableLayoutSeparator";
            tableLayoutSeparator.RowCount = 1;
            tableLayoutSeparator.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutSeparator.Size = new Size(298, 39);
            tableLayoutSeparator.TabIndex = 9;
            // 
            // tableLayoutText
            // 
            tableLayoutText.ColumnCount = 2;
            tableLayoutText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutText.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutText.Controls.Add(chkEnabled, 1, 0);
            tableLayoutText.Controls.Add(txtSelection, 0, 0);
            tableLayoutText.Dock = DockStyle.Fill;
            tableLayoutText.Location = new Point(111, 25);
            tableLayoutText.Name = "tableLayoutText";
            tableLayoutText.RowCount = 1;
            tableLayoutText.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutText.Size = new Size(298, 39);
            tableLayoutText.TabIndex = 9;
            // 
            // tableLayoutMove
            // 
            tableLayoutMove.ColumnCount = 3;
            tableLayoutMove.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutMove.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutMove.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMove.Controls.Add(btnMoveLeft, 0, 0);
            tableLayoutMove.Controls.Add(btnMoveRight, 1, 0);
            tableLayoutMove.Dock = DockStyle.Fill;
            tableLayoutMove.Location = new Point(111, 115);
            tableLayoutMove.Name = "tableLayoutMove";
            tableLayoutMove.RowCount = 1;
            tableLayoutMove.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMove.Size = new Size(298, 39);
            tableLayoutMove.TabIndex = 9;
            // 
            // grpSelection
            // 
            grpSelection.Controls.Add(tableLayoutMain);
            grpSelection.Dock = DockStyle.Fill;
            grpSelection.Location = new Point(0, 0);
            grpSelection.Name = "grpSelection";
            grpSelection.Size = new Size(428, 209);
            grpSelection.TabIndex = 9;
            grpSelection.TabStop = false;
            grpSelection.Text = "Selection Details";
            // 
            // SelectionDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpSelection);
            Name = "SelectionDetails";
            Size = new Size(428, 209);
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
        private TextBox textBox1;
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
