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
            dataGridView1 = new DataGridView();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            btnStokKart = new MaterialSkin.Controls.MaterialButton();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            dataGridView2 = new DataGridView();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            materialButton4 = new MaterialSkin.Controls.MaterialButton();
            materialButton5 = new MaterialSkin.Controls.MaterialButton();
            materialButton6 = new MaterialSkin.Controls.MaterialButton();
            materialButton7 = new MaterialSkin.Controls.MaterialButton();
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            materialCard1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            materialCard2.SuspendLayout();
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
            materialTabControl1.Size = new Size(1313, 634);
            materialTabControl1.TabIndex = 0;
            materialTabControl1.SelectedIndexChanged += materialTabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(materialCard1);
            tabPage1.ImageKey = "square-kanban-svgrepo-com.png";
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1305, 591);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Stok Takip";
            tabPage1.Click += tabPage1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1299, 528);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialButton3);
            materialCard1.Controls.Add(materialButton1);
            materialCard1.Controls.Add(materialButton2);
            materialCard1.Controls.Add(btnStokKart);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Top;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(3, 3);
            materialCard1.Margin = new Padding(14, 13, 14, 13);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14, 13, 14, 13);
            materialCard1.Size = new Size(1299, 57);
            materialCard1.TabIndex = 0;
            // 
            // materialButton3
            // 
            materialButton3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(338, 10);
            materialButton3.Margin = new Padding(5);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(104, 36);
            materialButton3.TabIndex = 3;
            materialButton3.Text = "Stok Silme";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            materialButton3.Click += materialButton3_Click;
            // 
            // materialButton1
            // 
            materialButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(155, 10);
            materialButton1.Margin = new Padding(5);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(164, 36);
            materialButton1.TabIndex = 2;
            materialButton1.Text = "  Stok Güncelleme   ";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // materialButton2
            // 
            materialButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(470, 10);
            materialButton2.Margin = new Padding(5);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(135, 36);
            materialButton2.TabIndex = 1;
            materialButton2.Text = "Verileri Yenile";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // btnStokKart
            // 
            btnStokKart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnStokKart.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStokKart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnStokKart.Depth = 0;
            btnStokKart.HighEmphasis = true;
            btnStokKart.Icon = null;
            btnStokKart.Location = new Point(27, 10);
            btnStokKart.Margin = new Padding(5);
            btnStokKart.MouseState = MaterialSkin.MouseState.HOVER;
            btnStokKart.Name = "btnStokKart";
            btnStokKart.NoAccentTextColor = Color.Empty;
            btnStokKart.Size = new Size(99, 36);
            btnStokKart.TabIndex = 0;
            btnStokKart.Text = "Stok Kart";
            btnStokKart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnStokKart.UseAccentColor = false;
            btnStokKart.UseVisualStyleBackColor = true;
            btnStokKart.Click += btnStokKart_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.ImageKey = "buy-svgrepo-com.png";
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1305, 591);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Alış Satış";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Controls.Add(materialCard2);
            tabPage3.ImageKey = "person-team-svgrepo-com.png";
            tabPage3.Location = new Point(4, 39);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1305, 591);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Personeller";
            tabPage3.Click += tabPage3_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeight = 29;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 57);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(1305, 534);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(materialButton4);
            materialCard2.Controls.Add(materialButton5);
            materialCard2.Controls.Add(materialButton6);
            materialCard2.Controls.Add(materialButton7);
            materialCard2.Depth = 0;
            materialCard2.Dock = DockStyle.Top;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(0, 0);
            materialCard2.Margin = new Padding(14, 13, 14, 13);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14, 13, 14, 13);
            materialCard2.Size = new Size(1305, 57);
            materialCard2.TabIndex = 1;
            // 
            // materialButton4
            // 
            materialButton4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = null;
            materialButton4.Location = new Point(424, 12);
            materialButton4.Margin = new Padding(5);
            materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(151, 36);
            materialButton4.TabIndex = 3;
            materialButton4.Text = "   Personel Silme   ";
            materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = true;
            materialButton4.Click += materialButton4_Click;
            // 
            // materialButton5
            // 
            materialButton5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            materialButton5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton5.Depth = 0;
            materialButton5.HighEmphasis = true;
            materialButton5.Icon = null;
            materialButton5.Location = new Point(202, 12);
            materialButton5.Margin = new Padding(5);
            materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton5.Name = "materialButton5";
            materialButton5.NoAccentTextColor = Color.Empty;
            materialButton5.Size = new Size(203, 36);
            materialButton5.TabIndex = 2;
            materialButton5.Text = "   Personel Güncelleme   ";
            materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton5.UseAccentColor = false;
            materialButton5.UseVisualStyleBackColor = true;
            materialButton5.Click += materialButton5_Click;
            // 
            // materialButton6
            // 
            materialButton6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            materialButton6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton6.Depth = 0;
            materialButton6.HighEmphasis = true;
            materialButton6.Icon = null;
            materialButton6.Location = new Point(605, 12);
            materialButton6.Margin = new Padding(5);
            materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton6.Name = "materialButton6";
            materialButton6.NoAccentTextColor = Color.Empty;
            materialButton6.Size = new Size(135, 36);
            materialButton6.TabIndex = 1;
            materialButton6.Text = "Verileri Yenile";
            materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton6.UseAccentColor = false;
            materialButton6.UseVisualStyleBackColor = true;
            materialButton6.Click += materialButton6_Click;
            // 
            // materialButton7
            // 
            materialButton7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            materialButton7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton7.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton7.Depth = 0;
            materialButton7.HighEmphasis = true;
            materialButton7.Icon = null;
            materialButton7.Location = new Point(31, 12);
            materialButton7.Margin = new Padding(5);
            materialButton7.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton7.Name = "materialButton7";
            materialButton7.NoAccentTextColor = Color.Empty;
            materialButton7.Size = new Size(147, 36);
            materialButton7.TabIndex = 0;
            materialButton7.Text = "    Personel Ekle    ";
            materialButton7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton7.UseAccentColor = false;
            materialButton7.UseVisualStyleBackColor = true;
            materialButton7.Click += materialButton7_Click;
            // 
            // frmAnaEkran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 701);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "frmAnaEkran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ön Muhasebe";
            Load += frmAnaEkran_Load;
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
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
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialButton materialButton6;
        private MaterialSkin.Controls.MaterialButton materialButton7;
        private DataGridView dataGridView2;
    }
}