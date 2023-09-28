namespace OnMuhasebe
{
    partial class frmAnaEkran
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
            menuStrip1 = new MenuStrip();
            sTOKTAKİPToolStripMenuItem = new ToolStripMenuItem();
            aLIŞSATIŞToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sTOKTAKİPToolStripMenuItem, aLIŞSATIŞToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1319, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sTOKTAKİPToolStripMenuItem
            // 
            sTOKTAKİPToolStripMenuItem.Name = "sTOKTAKİPToolStripMenuItem";
            sTOKTAKİPToolStripMenuItem.Size = new Size(100, 24);
            sTOKTAKİPToolStripMenuItem.Text = "STOK TAKİP";
            // 
            // aLIŞSATIŞToolStripMenuItem
            // 
            aLIŞSATIŞToolStripMenuItem.Name = "aLIŞSATIŞToolStripMenuItem";
            aLIŞSATIŞToolStripMenuItem.Size = new Size(93, 24);
            aLIŞSATIŞToolStripMenuItem.Text = "ALIŞ SATIŞ";
            // 
            // frmAnaEkran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 702);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "frmAnaEkran";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sTOKTAKİPToolStripMenuItem;
        private ToolStripMenuItem aLIŞSATIŞToolStripMenuItem;
    }
}