namespace OnMuhasebe
{
    partial class frmStokKartEkle
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
            panel1 = new Panel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            panel2 = new Panel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            txtStokMiktar = new MaterialSkin.Controls.MaterialTextBox2();
            txtStokKodu = new MaterialSkin.Controls.MaterialTextBox2();
            txtStokAciklama = new MaterialSkin.Controls.MaterialTextBox2();
            txtBarkodNo = new MaterialSkin.Controls.MaterialTextBox2();
            txtStokisim = new MaterialSkin.Controls.MaterialTextBox2();
            txtStokKdv = new MaterialSkin.Controls.MaterialTextBox2();
            panel1.SuspendLayout();
            materialCard1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(materialCard1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 85);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 618);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(panel2);
            materialCard1.Controls.Add(txtStokMiktar);
            materialCard1.Controls.Add(txtStokKodu);
            materialCard1.Controls.Add(txtStokAciklama);
            materialCard1.Controls.Add(txtBarkodNo);
            materialCard1.Controls.Add(txtStokisim);
            materialCard1.Controls.Add(txtStokKdv);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 0);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1048, 618);
            materialCard1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(materialButton1);
            panel2.Location = new Point(384, 385);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 49);
            panel2.TabIndex = 6;
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
            materialButton1.Text = "Kart Oluştur";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // txtStokMiktar
            // 
            txtStokMiktar.AnimateReadOnly = false;
            txtStokMiktar.BackgroundImageLayout = ImageLayout.None;
            txtStokMiktar.CharacterCasing = CharacterCasing.Normal;
            txtStokMiktar.Depth = 0;
            txtStokMiktar.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtStokMiktar.HideSelection = true;
            txtStokMiktar.Hint = " Miktar";
            txtStokMiktar.LeadingIcon = null;
            txtStokMiktar.Location = new Point(568, 114);
            txtStokMiktar.Margin = new Padding(3, 4, 3, 4);
            txtStokMiktar.MaxLength = 32767;
            txtStokMiktar.MouseState = MaterialSkin.MouseState.OUT;
            txtStokMiktar.Name = "txtStokMiktar";
            txtStokMiktar.PasswordChar = '\0';
            txtStokMiktar.PrefixSuffixText = null;
            txtStokMiktar.ReadOnly = false;
            txtStokMiktar.RightToLeft = RightToLeft.No;
            txtStokMiktar.SelectedText = "";
            txtStokMiktar.SelectionLength = 0;
            txtStokMiktar.SelectionStart = 0;
            txtStokMiktar.ShortcutsEnabled = true;
            txtStokMiktar.Size = new Size(268, 48);
            txtStokMiktar.TabIndex = 3;
            txtStokMiktar.TabStop = false;
            txtStokMiktar.TextAlign = HorizontalAlignment.Left;
            txtStokMiktar.TrailingIcon = null;
            txtStokMiktar.UseSystemPasswordChar = false;
            // 
            // txtStokKodu
            // 
            txtStokKodu.AnimateReadOnly = false;
            txtStokKodu.BackgroundImageLayout = ImageLayout.None;
            txtStokKodu.CharacterCasing = CharacterCasing.Normal;
            txtStokKodu.Depth = 0;
            txtStokKodu.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtStokKodu.HideSelection = true;
            txtStokKodu.Hint = "Stok Kodu";
            txtStokKodu.LeadingIcon = null;
            txtStokKodu.Location = new Point(64, 114);
            txtStokKodu.Margin = new Padding(3, 4, 3, 4);
            txtStokKodu.MaxLength = 32767;
            txtStokKodu.MouseState = MaterialSkin.MouseState.OUT;
            txtStokKodu.Name = "txtStokKodu";
            txtStokKodu.PasswordChar = '\0';
            txtStokKodu.PrefixSuffixText = null;
            txtStokKodu.ReadOnly = false;
            txtStokKodu.RightToLeft = RightToLeft.No;
            txtStokKodu.SelectedText = "";
            txtStokKodu.SelectionLength = 0;
            txtStokKodu.SelectionStart = 0;
            txtStokKodu.ShortcutsEnabled = true;
            txtStokKodu.Size = new Size(341, 48);
            txtStokKodu.TabIndex = 0;
            txtStokKodu.TabStop = false;
            txtStokKodu.TextAlign = HorizontalAlignment.Left;
            txtStokKodu.TrailingIcon = null;
            txtStokKodu.UseSystemPasswordChar = false;
            // 
            // txtStokAciklama
            // 
            txtStokAciklama.AnimateReadOnly = false;
            txtStokAciklama.BackgroundImageLayout = ImageLayout.None;
            txtStokAciklama.CharacterCasing = CharacterCasing.Normal;
            txtStokAciklama.Depth = 0;
            txtStokAciklama.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtStokAciklama.HideSelection = true;
            txtStokAciklama.Hint = "Açıklama";
            txtStokAciklama.LeadingIcon = null;
            txtStokAciklama.Location = new Point(64, 271);
            txtStokAciklama.Margin = new Padding(3, 4, 3, 4);
            txtStokAciklama.MaxLength = 32767;
            txtStokAciklama.MouseState = MaterialSkin.MouseState.OUT;
            txtStokAciklama.Name = "txtStokAciklama";
            txtStokAciklama.PasswordChar = '\0';
            txtStokAciklama.PrefixSuffixText = null;
            txtStokAciklama.ReadOnly = false;
            txtStokAciklama.RightToLeft = RightToLeft.No;
            txtStokAciklama.SelectedText = "";
            txtStokAciklama.SelectionLength = 0;
            txtStokAciklama.SelectionStart = 0;
            txtStokAciklama.ShortcutsEnabled = true;
            txtStokAciklama.Size = new Size(462, 48);
            txtStokAciklama.TabIndex = 2;
            txtStokAciklama.TabStop = false;
            txtStokAciklama.TextAlign = HorizontalAlignment.Left;
            txtStokAciklama.TrailingIcon = null;
            txtStokAciklama.UseSystemPasswordChar = false;
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.AnimateReadOnly = false;
            txtBarkodNo.BackgroundImageLayout = ImageLayout.None;
            txtBarkodNo.CharacterCasing = CharacterCasing.Normal;
            txtBarkodNo.Depth = 0;
            txtBarkodNo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBarkodNo.HideSelection = true;
            txtBarkodNo.Hint = "Barkod Kodu";
            txtBarkodNo.LeadingIcon = null;
            txtBarkodNo.Location = new Point(568, 187);
            txtBarkodNo.Margin = new Padding(3, 4, 3, 4);
            txtBarkodNo.MaxLength = 32767;
            txtBarkodNo.MouseState = MaterialSkin.MouseState.OUT;
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.PasswordChar = '\0';
            txtBarkodNo.PrefixSuffixText = null;
            txtBarkodNo.ReadOnly = false;
            txtBarkodNo.RightToLeft = RightToLeft.No;
            txtBarkodNo.SelectedText = "";
            txtBarkodNo.SelectionLength = 0;
            txtBarkodNo.SelectionStart = 0;
            txtBarkodNo.ShortcutsEnabled = true;
            txtBarkodNo.Size = new Size(268, 48);
            txtBarkodNo.TabIndex = 4;
            txtBarkodNo.TabStop = false;
            txtBarkodNo.TextAlign = HorizontalAlignment.Left;
            txtBarkodNo.TrailingIcon = null;
            txtBarkodNo.UseSystemPasswordChar = false;
            // 
            // txtStokisim
            // 
            txtStokisim.AnimateReadOnly = false;
            txtStokisim.BackgroundImageLayout = ImageLayout.None;
            txtStokisim.CharacterCasing = CharacterCasing.Normal;
            txtStokisim.Depth = 0;
            txtStokisim.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtStokisim.HideSelection = true;
            txtStokisim.Hint = "Stok İsim";
            txtStokisim.LeadingIcon = null;
            txtStokisim.Location = new Point(64, 187);
            txtStokisim.Margin = new Padding(3, 4, 3, 4);
            txtStokisim.MaxLength = 32767;
            txtStokisim.MouseState = MaterialSkin.MouseState.OUT;
            txtStokisim.Name = "txtStokisim";
            txtStokisim.PasswordChar = '\0';
            txtStokisim.PrefixSuffixText = null;
            txtStokisim.ReadOnly = false;
            txtStokisim.RightToLeft = RightToLeft.No;
            txtStokisim.SelectedText = "";
            txtStokisim.SelectionLength = 0;
            txtStokisim.SelectionStart = 0;
            txtStokisim.ShortcutsEnabled = true;
            txtStokisim.Size = new Size(341, 48);
            txtStokisim.TabIndex = 1;
            txtStokisim.TabStop = false;
            txtStokisim.TextAlign = HorizontalAlignment.Left;
            txtStokisim.TrailingIcon = null;
            txtStokisim.UseSystemPasswordChar = false;
            // 
            // txtStokKdv
            // 
            txtStokKdv.AnimateReadOnly = false;
            txtStokKdv.BackgroundImageLayout = ImageLayout.None;
            txtStokKdv.CharacterCasing = CharacterCasing.Normal;
            txtStokKdv.Depth = 0;
            txtStokKdv.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtStokKdv.HideSelection = true;
            txtStokKdv.Hint = "Kdv Oranı";
            txtStokKdv.LeadingIcon = null;
            txtStokKdv.Location = new Point(568, 271);
            txtStokKdv.Margin = new Padding(3, 4, 3, 4);
            txtStokKdv.MaxLength = 32767;
            txtStokKdv.MouseState = MaterialSkin.MouseState.OUT;
            txtStokKdv.Name = "txtStokKdv";
            txtStokKdv.PasswordChar = '\0';
            txtStokKdv.PrefixSuffixText = null;
            txtStokKdv.ReadOnly = false;
            txtStokKdv.RightToLeft = RightToLeft.No;
            txtStokKdv.SelectedText = "";
            txtStokKdv.SelectionLength = 0;
            txtStokKdv.SelectionStart = 0;
            txtStokKdv.ShortcutsEnabled = true;
            txtStokKdv.Size = new Size(268, 48);
            txtStokKdv.TabIndex = 5;
            txtStokKdv.TabStop = false;
            txtStokKdv.TextAlign = HorizontalAlignment.Left;
            txtStokKdv.TrailingIcon = null;
            txtStokKdv.UseSystemPasswordChar = false;
            // 
            // frmStokKartEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 707);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmStokKartEkle";
            Padding = new Padding(3, 85, 3, 4);
            Text = "Stok Kart Oluşturma";
            panel1.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtStokKodu;
        private MaterialSkin.Controls.MaterialTextBox2 txtStokMiktar;
        private MaterialSkin.Controls.MaterialTextBox2 txtStokisim;
        private MaterialSkin.Controls.MaterialTextBox2 txtStokAciklama;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox2 txtBarkodNo;
        private MaterialSkin.Controls.MaterialTextBox2 txtStokKdv;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Panel panel2;
    }
}