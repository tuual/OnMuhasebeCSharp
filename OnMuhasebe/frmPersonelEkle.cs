using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace OnMuhasebe
{
    public partial class frmPersonelEkle : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private SqlCommand cmd;
        private SqlConnection sqlCon;
        public frmPersonelEkle()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700
                , MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

            String connect = "Server=213.254.137.231;Database=OnMuhasebe;User Id=biltekbilisim;Password=Bilisim20037816";
            sqlCon = new SqlConnection(connect);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string emailRegex = @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$";
            string emailInput = txtEmail.Text.Trim();
            if (txtEmail.Text != "" || txtPersonelAd.Text != "" || txtSifre.Text != "")
            {
                if (Regex.Match(emailInput, emailRegex).Success)
                {
                    try
                    {
                        // Ekleme Kodları
                        String query = "INSERT INTO tblUser(sirketAdi,sifre,email) VALUES(@sirketadi,@sifre,@email)";
                        cmd = new SqlCommand(query, sqlCon);
                        sqlCon.Open();
                        cmd.Parameters.AddWithValue("@sirketadi", txtPersonelAd.Text.Trim());
                        cmd.Parameters.AddWithValue("@sifre", txtSifre.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.ExecuteNonQuery();
                        sqlCon.Close();

                        //Textbox reset
                        txtEmail.Text = "";
                        txtPersonelAd.Text = "";
                        txtSifre.Text = "";
                        MessageBox.Show("Personel Eklendi", "Sistem", MessageBoxButtons.OK, MessageBoxIcon.Question);

                        // Label
                        label1.Visible = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }


                }
                else
                {
                    label1.Visible = true;
                    label1.Text = "Geçerli bir mail adresi giriniz !";
                    label1.ForeColor = Color.Red;

                }
            }
            else
            {
                label1.Visible = true;
                label1.Text = "Metin Kutuları Boş Bırakılamaz !";
                label1.ForeColor = Color.Red;

            }


        }

        private void frmPersonelEkle_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
