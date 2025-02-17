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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblOriginal = new Label();
            lblRenameTo = new Label();
            txtOriginalName = new TextBox();
            txtRenameTo = new TextBox();
            tableLayoutMain = new TableLayoutPanel();
            btnRename = new Guna.UI2.WinForms.Guna2Button();
            graphicsPanel = new Memphis.GraphicsPanel();
            tableLayoutMain.SuspendLayout();
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
            txtOriginalName.Size = new Size(808, 31);
            txtOriginalName.TabIndex = 2;
            // 
            // txtRenameTo
            // 
            txtRenameTo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRenameTo.Location = new Point(153, 99);
            txtRenameTo.Name = "txtRenameTo";
            txtRenameTo.Size = new Size(808, 31);
            txtRenameTo.TabIndex = 3;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 4;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            tableLayoutMain.Controls.Add(lblOriginal, 0, 1);
            tableLayoutMain.Controls.Add(txtRenameTo, 1, 2);
            tableLayoutMain.Controls.Add(lblRenameTo, 0, 2);
            tableLayoutMain.Controls.Add(txtOriginalName, 1, 1);
            tableLayoutMain.Controls.Add(btnRename, 2, 4);
            tableLayoutMain.Controls.Add(graphicsPanel, 1, 3);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 5;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutMain.Size = new Size(1232, 670);
            tableLayoutMain.TabIndex = 4;
            // 
            // btnRename
            // 
            btnRename.CustomizableEdges = customizableEdges3;
            btnRename.DisabledState.BorderColor = Color.DarkGray;
            btnRename.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRename.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRename.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRename.Dock = DockStyle.Fill;
            btnRename.Font = new Font("Segoe UI", 9F);
            btnRename.ForeColor = Color.White;
            btnRename.Location = new Point(967, 598);
            btnRename.Name = "btnRename";
            btnRename.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnRename.Size = new Size(214, 69);
            btnRename.TabIndex = 4;
            btnRename.Text = "RENAME";
            btnRename.Click += btnRename_Click;
            // 
            // graphicsPanel
            // 
            graphicsPanel.Location = new Point(153, 143);
            graphicsPanel.Name = "graphicsPanel";
            graphicsPanel.Size = new Size(808, 449);
            graphicsPanel.TabIndex = 5;
            // 
            // SelectionPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutMain);
            Name = "SelectionPage";
            Size = new Size(1232, 670);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblOriginal;
        private Label lblRenameTo;
        private TextBox txtOriginalName;
        private TextBox txtRenameTo;
        private TableLayoutPanel tableLayoutMain;
        private Guna.UI2.WinForms.Guna2Button btnRename;
        private Memphis.GraphicsPanel graphicsPanel;
    }
}
