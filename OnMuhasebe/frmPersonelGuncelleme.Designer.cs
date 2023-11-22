namespace OnMuhasebe
{
    partial class frmPersonelGuncelleme
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
            txtPersonelAd = new MaterialSkin.Controls.MaterialTextBox2();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            label1 = new Label();
            panel3 = new Panel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            txtSifre = new MaterialSkin.Controls.MaterialTextBox2();
            panel1 = new Panel();
            materialCard1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPersonelAd
            // 
            txtPersonelAd.AnimateReadOnly = false;
            txtPersonelAd.BackgroundImageLayout = ImageLayout.None;
            txtPersonelAd.CharacterCasing = CharacterCasing.Normal;
            txtPersonelAd.Depth = 0;
            txtPersonelAd.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPersonelAd.HideSelection = true;
            txtPersonelAd.Hint = "Personel Adı";
            txtPersonelAd.LeadingIcon = null;
            txtPersonelAd.Location = new Point(312, 150);
            txtPersonelAd.Margin = new Padding(3, 4, 3, 4);
            txtPersonelAd.MaxLength = 32767;
            txtPersonelAd.MouseState = MaterialSkin.MouseState.OUT;
            txtPersonelAd.Name = "txtPersonelAd";
            txtPersonelAd.PasswordChar = '\0';
            txtPersonelAd.PrefixSuffixText = null;
            txtPersonelAd.ReadOnly = false;
            txtPersonelAd.RightToLeft = RightToLeft.No;
            txtPersonelAd.SelectedText = "";
            txtPersonelAd.SelectionLength = 0;
            txtPersonelAd.SelectionStart = 0;
            txtPersonelAd.ShortcutsEnabled = true;
            txtPersonelAd.Size = new Size(341, 48);
            txtPersonelAd.TabIndex = 14;
            txtPersonelAd.TabStop = false;
            txtPersonelAd.TextAlign = HorizontalAlignment.Left;
            txtPersonelAd.TrailingIcon = null;
            txtPersonelAd.UseSystemPasswordChar = false;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(panel3);
            materialCard1.Controls.Add(txtPersonelAd);
            materialCard1.Controls.Add(txtEmail);
            materialCard1.Controls.Add(txtSifre);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 0);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(968, 588);
            materialCard1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(400, 374);
            label1.Name = "label1";
            label1.Size = new Size(185, 23);
            label1.TabIndex = 21;
            label1.Text = "Geçerli bir mail giriniz !";
            // 
            // panel3
            // 
            panel3.Controls.Add(materialButton1);
            panel3.Location = new Point(379, 416);
            panel3.Name = "panel3";
            panel3.Size = new Size(222, 49);
            panel3.TabIndex = 20;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Dock = DockStyle.Fill;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(0, 0);
            materialButton1.Margin = new Padding(5, 8, 5, 8);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(222, 49);
            materialButton1.TabIndex = 6;
            materialButton1.Text = "Personel Güncelle";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "E-Posta Adresi";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(312, 307);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(341, 48);
            txtEmail.TabIndex = 16;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
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
            txtSifre.Location = new Point(312, 223);
            txtSifre.Margin = new Padding(3, 4, 3, 4);
            txtSifre.MaxLength = 32767;
            txtSifre.MouseState = MaterialSkin.MouseState.OUT;
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '\0';
            txtSifre.PrefixSuffixText = null;
            txtSifre.ReadOnly = false;
            txtSifre.RightToLeft = RightToLeft.No;
            txtSifre.SelectedText = "";
            txtSifre.SelectionLength = 0;
            txtSifre.SelectionStart = 0;
            txtSifre.ShortcutsEnabled = true;
            txtSifre.Size = new Size(341, 48);
            txtSifre.TabIndex = 15;
            txtSifre.TabStop = false;
            txtSifre.TextAlign = HorizontalAlignment.Left;
            txtSifre.TrailingIcon = null;
            txtSifre.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(materialCard1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 24);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 588);
            panel1.TabIndex = 2;
            // 
            // frmPersonelGuncelleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 615);
            Controls.Add(panel1);
            FormStyle = FormStyles.ActionBar_None;
            Name = "frmPersonelGuncelleme";
            Padding = new Padding(3, 24, 3, 3);
            Text = "Personel Güncelleme";
            Load += frmPersonelGuncelleme_Load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtPersonelAd;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label label1;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private MaterialSkin.Controls.MaterialTextBox2 txtSifre;
        private Panel panel1;
    }
}