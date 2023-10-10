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
            pictureBox1 = new PictureBox();
            txtSirketAdi = new MaterialSkin.Controls.MaterialTextBox2();
            txtSifre = new MaterialSkin.Controls.MaterialTextBox2();
            btnGiris = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.on_muhasebe_1;
            pictureBox1.Location = new Point(6, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(573, 484);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            txtSirketAdi.Location = new Point(649, 143);
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
            txtSirketAdi.Size = new Size(250, 48);
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
            txtSifre.Location = new Point(649, 247);
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
            txtSifre.Size = new Size(250, 48);
            txtSifre.TabIndex = 2;
            txtSifre.TabStop = false;
            txtSifre.TextAlign = HorizontalAlignment.Center;
            txtSifre.TrailingIcon = null;
            txtSifre.UseSystemPasswordChar = false;
            // 
            // btnGiris
            // 
            btnGiris.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGiris.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGiris.Depth = 0;
            btnGiris.HighEmphasis = true;
            btnGiris.Icon = null;
            btnGiris.Location = new Point(737, 343);
            btnGiris.Margin = new Padding(4, 6, 4, 6);
            btnGiris.MouseState = MaterialSkin.MouseState.HOVER;
            btnGiris.Name = "btnGiris";
            btnGiris.NoAccentTextColor = Color.Empty;
            btnGiris.Padding = new Padding(5);
            btnGiris.Size = new Size(89, 36);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "Giriş Yap";
            btnGiris.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGiris.UseAccentColor = false;
            btnGiris.UseCompatibleTextRendering = true;
            btnGiris.UseMnemonic = false;
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // frmGirisEkran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(964, 557);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtSirketAdi);
            Controls.Add(pictureBox1);
            Name = "frmGirisEkran";
            Text = "Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox2 txtSirketAdi;
        private MaterialSkin.Controls.MaterialTextBox2 txtSifre;
        private MaterialSkin.Controls.MaterialButton btnGiris;
    }
}