namespace MEMPHIS_SHARP
{
    partial class FormNew
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelList = new Panel();
            panelTransforms = new Panel();
            scenePainter = new ScenePainter();
            selectionDetails = new SelectionDetails();
            panelRename = new PanelRename();
            tableLayoutLeft = new TableLayoutPanel();
            tableLayoutPanelTop = new TableLayoutPanel();
            lblScene = new Label();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutLeft.SuspendLayout();
            tableLayoutPanelTop.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelList
            // 
            panelList.Dock = DockStyle.Fill;
            panelList.Location = new Point(4, 4);
            panelList.Margin = new Padding(4);
            panelList.Name = "panelList";
            panelList.Size = new Size(546, 457);
            panelList.TabIndex = 0;
            // 
            // panelTransforms
            // 
            panelTransforms.Dock = DockStyle.Fill;
            panelTransforms.Location = new Point(4, 469);
            panelTransforms.Margin = new Padding(4);
            panelTransforms.Name = "panelTransforms";
            panelTransforms.Size = new Size(546, 302);
            panelTransforms.TabIndex = 1;
            // 
            // scenePainter
            // 
            scenePainter.BorderStyle = BorderStyle.FixedSingle;
            scenePainter.Dock = DockStyle.Fill;
            scenePainter.Engine = null;
            scenePainter.Location = new Point(4, 50);
            scenePainter.Margin = new Padding(4, 5, 4, 5);
            scenePainter.Name = "scenePainter";
            scenePainter.SelectionChanged = null;
            scenePainter.Size = new Size(642, 327);
            scenePainter.TabIndex = 2;
            scenePainter.Load += scenePainter_Load;
            // 
            // selectionDetails
            // 
            selectionDetails.BorderStyle = BorderStyle.FixedSingle;
            selectionDetails.Dock = DockStyle.Fill;
            selectionDetails.Enabled = false;
            selectionDetails.Location = new Point(2, 384);
            selectionDetails.Margin = new Padding(2);
            selectionDetails.Name = "selectionDetails";
            selectionDetails.Size = new Size(646, 147);
            selectionDetails.TabIndex = 3;
            selectionDetails.Token = null;
            selectionDetails.TokenChanged = null;
            // 
            // panelRename
            // 
            panelRename.Dock = DockStyle.Fill;
            panelRename.Location = new Point(5, 580);
            panelRename.Margin = new Padding(5);
            panelRename.Name = "panelRename";
            panelRename.Size = new Size(640, 190);
            panelRename.TabIndex = 9;
            // 
            // tableLayoutLeft
            // 
            tableLayoutLeft.ColumnCount = 1;
            tableLayoutLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutLeft.Controls.Add(panelList, 0, 0);
            tableLayoutLeft.Controls.Add(panelTransforms, 0, 1);
            tableLayoutLeft.Dock = DockStyle.Fill;
            tableLayoutLeft.Location = new Point(3, 3);
            tableLayoutLeft.Name = "tableLayoutLeft";
            tableLayoutLeft.RowCount = 2;
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutLeft.Size = new Size(554, 775);
            tableLayoutLeft.TabIndex = 10;
            // 
            // tableLayoutPanelTop
            // 
            tableLayoutPanelTop.ColumnCount = 1;
            tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelTop.Controls.Add(scenePainter, 0, 1);
            tableLayoutPanelTop.Controls.Add(lblScene, 0, 0);
            tableLayoutPanelTop.Controls.Add(panelRename, 0, 5);
            tableLayoutPanelTop.Controls.Add(selectionDetails, 0, 2);
            tableLayoutPanelTop.Dock = DockStyle.Fill;
            tableLayoutPanelTop.Location = new Point(563, 3);
            tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            tableLayoutPanelTop.RowCount = 6;
            tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 337F));
            tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 151F));
            tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 210F));
            tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tableLayoutPanelTop.Size = new Size(650, 775);
            tableLayoutPanelTop.TabIndex = 11;
            // 
            // lblScene
            // 
            lblScene.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblScene.AutoSize = true;
            lblScene.Location = new Point(3, 20);
            lblScene.Name = "lblScene";
            lblScene.Size = new Size(116, 25);
            lblScene.TabIndex = 3;
            lblScene.Text = "Scene Painter";
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 2;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 560F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(tableLayoutPanelTop, 1, 0);
            tableLayoutMain.Controls.Add(tableLayoutLeft, 0, 0);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 1;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.Size = new Size(1216, 781);
            tableLayoutMain.TabIndex = 12;
            // 
            // FormNew
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 781);
            Controls.Add(tableLayoutMain);
            Margin = new Padding(4);
            Name = "FormNew";
            Text = "FormNew";
            tableLayoutLeft.ResumeLayout(false);
            tableLayoutPanelTop.ResumeLayout(false);
            tableLayoutPanelTop.PerformLayout();
            tableLayoutMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelList;
        private Panel panelTransforms;
        private ScenePainter scenePainter;
        private SelectionDetails selectionDetails;
        private PanelRename panelRename;
        private TableLayoutPanel tableLayoutLeft;
        private TableLayoutPanel tableLayoutPanelTop;
        private Label lblScene;
        private TableLayoutPanel tableLayoutMain;
    }
}