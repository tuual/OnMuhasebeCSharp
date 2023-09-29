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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaEkran));
            ımageList1 = new ImageList(components);
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            btnStokKart = new MaterialSkin.Controls.MaterialButton();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "buy-svgrepo-com.png");
            ımageList1.Images.SetKeyName(1, "square-kanban-svgrepo-com.png");
            ımageList1.Images.SetKeyName(2, "person-team-svgrepo-com.png");
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Controls.Add(tabPage3);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = ımageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1313, 635);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(materialCard1);
            tabPage1.ImageKey = "square-kanban-svgrepo-com.png";
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1305, 592);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Stok Takip";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialButton2);
            materialCard1.Controls.Add(btnStokKart);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Top;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(3, 3);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1299, 57);
            materialCard1.TabIndex = 0;
            // 
            // materialButton2
            // 
            materialButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(148, 10);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(130, 36);
            materialButton2.TabIndex = 1;
            materialButton2.Text = "Stok Listeleri";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // btnStokKart
            // 
            btnStokKart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnStokKart.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStokKart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnStokKart.Depth = 0;
            btnStokKart.HighEmphasis = true;
            btnStokKart.Icon = null;
            btnStokKart.Location = new Point(18, 10);
            btnStokKart.Margin = new Padding(4, 6, 4, 6);
            btnStokKart.MouseState = MaterialSkin.MouseState.HOVER;
            btnStokKart.Name = "btnStokKart";
            btnStokKart.NoAccentTextColor = Color.Empty;
            btnStokKart.Size = new Size(99, 36);
            btnStokKart.TabIndex = 0;
            btnStokKart.Text = "Stok Kart";
            btnStokKart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnStokKart.UseAccentColor = false;
            btnStokKart.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.ImageKey = "buy-svgrepo-com.png";
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1305, 592);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Alış Satış";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.ImageKey = "person-team-svgrepo-com.png";
            tabPage3.Location = new Point(4, 39);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1305, 592);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Personeller";
            // 
            // frmAnaEkran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 702);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "frmAnaEkran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ön Muhasebe";
            Load += frmAnaEkran_Load;
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ImageList ımageList1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnStokKart;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}