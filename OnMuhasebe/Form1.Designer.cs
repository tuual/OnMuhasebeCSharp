namespace OnMuhasebe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtSifre = new TextBox();
            txtSirketAdi = new TextBox();
            btnGiris = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Image = Properties.Resources.on_muhasebe_1;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // txtSifre
            // 
            resources.ApplyResources(txtSifre, "txtSifre");
            txtSifre.BackColor = Color.White;
            txtSifre.Name = "txtSifre";
            // 
            // txtSirketAdi
            // 
            resources.ApplyResources(txtSirketAdi, "txtSirketAdi");
            txtSirketAdi.BackColor = Color.White;
            txtSirketAdi.Name = "txtSirketAdi";
            // 
            // btnGiris
            // 
            resources.ApplyResources(btnGiris, "btnGiris");
            btnGiris.Name = "btnGiris";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnGiris);
            Controls.Add(txtSirketAdi);
            Controls.Add(txtSifre);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtSifre;
        private MaterialSkin.Controls.MaterialTextBox txtKadi;
        private TextBox txtSirketAdi;
        private Button btnGiris;
    }
}