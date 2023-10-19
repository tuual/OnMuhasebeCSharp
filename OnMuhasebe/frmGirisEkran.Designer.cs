namespace OnMuhasebe
{
    partial class frmGirisEkran
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
            txtSirketAdi = new MaterialSkin.Controls.MaterialTextBox2();
            txtSifre = new MaterialSkin.Controls.MaterialTextBox2();
            panel1 = new Panel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            label1 = new Label();
            panel3 = new Panel();
            btnGiris = new MaterialSkin.Controls.MaterialButton();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            materialCard1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtSirketAdi
            // 
            txtSirketAdi.AnimateReadOnly = false;
            txtSirketAdi.BackgroundImageLayout = ImageLayout.None;
            txtSirketAdi.CharacterCasing = CharacterCasing.Normal;
            txtSirketAdi.Depth = 0;
            txtSirketAdi.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSirketAdi.HideSelection = true;
            txtSirketAdi.Hint = "Şirket Adı";
            txtSirketAdi.LeadingIcon = null;
            txtSirketAdi.Location = new Point(27, 136);
            txtSirketAdi.Margin = new Padding(3, 4, 3, 4);
            txtSirketAdi.MaxLength = 32767;
            txtSirketAdi.MouseState = MaterialSkin.MouseState.OUT;
            txtSirketAdi.Name = "txtSirketAdi";
            txtSirketAdi.PasswordChar = '\0';
            txtSirketAdi.PrefixSuffixText = null;
            txtSirketAdi.ReadOnly = false;
            txtSirketAdi.RightToLeft = RightToLeft.No;
            txtSirketAdi.SelectedText = "";
            txtSirketAdi.SelectionLength = 0;
            txtSirketAdi.SelectionStart = 0;
            txtSirketAdi.ShortcutsEnabled = true;
            txtSirketAdi.Size = new Size(360, 48);
            txtSirketAdi.TabIndex = 1;
            txtSirketAdi.TabStop = false;
            txtSirketAdi.TextAlign = HorizontalAlignment.Center;
            txtSirketAdi.TrailingIcon = null;
            txtSirketAdi.UseSystemPasswordChar = false;
            // 
            // txtSifre
            // 
            txtSifre.AnimateReadOnly = false;
            txtSifre.BackgroundImageLayout = ImageLayout.None;
            txtSifre.CharacterCasing = CharacterCasing.Normal;
            txtSifre.Depth = 0;
            txtSifre.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSifre.HideSelection = true;
            txtSifre.Hint = "Şifre";
            txtSifre.LeadingIcon = null;
            txtSifre.Location = new Point(27, 212);
            txtSifre.Margin = new Padding(3, 4, 3, 4);
            txtSifre.MaxLength = 32767;
            txtSifre.MouseState = MaterialSkin.MouseState.OUT;
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.PrefixSuffixText = null;
            txtSifre.ReadOnly = false;
            txtSifre.RightToLeft = RightToLeft.No;
            txtSifre.SelectedText = "";
            txtSifre.SelectionLength = 0;
            txtSifre.SelectionStart = 0;
            txtSifre.ShortcutsEnabled = true;
            txtSifre.Size = new Size(360, 48);
            txtSifre.TabIndex = 2;
            txtSifre.TabStop = false;
            txtSifre.TextAlign = HorizontalAlignment.Center;
            txtSifre.TrailingIcon = null;
            txtSifre.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(materialCard1);
            panel1.Dock = DockStyle.Right;
            panel1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(673, 85);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(11, 0, 11, 0);
            panel1.Size = new Size(426, 654);
            panel1.TabIndex = 4;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(panel3);
            materialCard1.Controls.Add(txtSirketAdi);
            materialCard1.Controls.Add(txtSifre);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(11, 0);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(404, 654);
            materialCard1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 14);
            label1.Name = "label1";
            label1.Size = new Size(207, 41);
            label1.TabIndex = 5;
            label1.Text = "Oturum Açınız";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnGiris);
            panel3.Location = new Point(55, 283);
            panel3.Name = "panel3";
            panel3.Size = new Size(303, 46);
            panel3.TabIndex = 4;
            // 
            // btnGiris
            // 
            btnGiris.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGiris.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGiris.Depth = 0;
            btnGiris.Dock = DockStyle.Fill;
            btnGiris.HighEmphasis = true;
            btnGiris.Icon = null;
            btnGiris.Location = new Point(0, 0);
            btnGiris.Margin = new Padding(5, 8, 5, 8);
            btnGiris.MouseState = MaterialSkin.MouseState.HOVER;
            btnGiris.Name = "btnGiris";
            btnGiris.NoAccentTextColor = Color.Empty;
            btnGiris.Padding = new Padding(6, 7, 6, 7);
            btnGiris.Size = new Size(303, 46);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "Giriş Yap";
            btnGiris.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGiris.UseAccentColor = false;
            btnGiris.UseCompatibleTextRendering = true;
            btnGiris.UseMnemonic = false;
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 85);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(670, 654);
            panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.on_muhasebe_1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(670, 654);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // frmGirisEkran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1102, 743);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmGirisEkran";
            Padding = new Padding(3, 85, 3, 4);
            Text = "Giriş Ekranı";
            panel1.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 txtSirketAdi;
        private MaterialSkin.Controls.MaterialTextBox2 txtSifre;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnGiris;
        private Panel panel3;
        private Label label1;
    }
}