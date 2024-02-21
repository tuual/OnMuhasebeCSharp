using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Windows;
using Microsoft.Toolkit.Uwp.Notifications;
using System.IO;
using System.Security.Policy;

namespace OnMuhasebe
{
    public partial class frmGirisEkran : MaterialForm
    {
        private string sirketAdi, sifre;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private string queryLogin;
        private SqlConn sqlConn;
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public frmGirisEkran()
        {

            sqlConn = new SqlConn();
            sqlConn.sqlConnection.Open();
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700
                , MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);


        }


        private void btnGiris_Click(object sender, EventArgs e)
        {
            sirketAdi = txtSirketAdi.Text;
            sifre = txtSifre.Text;
            loginCheck(sirketAdi, sifre);


        }
        private void loginCheck(string sirketAdi, string sifre)
        {
            if (txtSifre.TextLength <= 0 && txtSirketAdi.TextLength <= 0)
            {
                ErrorProvider ep = new ErrorProvider();
                ep.SetError(txtSirketAdi, "Boş Geçilemez");
                ep.SetError(txtSifre, "Boş Geçilemez");
            }
            else
            {
                queryLogin = "SELECT * FROM tblUser where sirketAdi=@sirketadi AND sifre=@sifre";

                SqlConnection sqlConnection = new SqlConnection("Server=;Database=OnMuhasebe;User Id=;Password=");
                cmd = new SqlCommand(queryLogin, sqlConnection);
                cmd.Parameters.AddWithValue("@sirketAdi", sirketAdi);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                sqlConnection.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //MessageBox.Show("Giriş Başarılı");
                    frmAnaEkran frmAnaEkran = new frmAnaEkran();
                    frmAnaEkran.Show();
                    this.Hide();
                    showNotification();
                }
                else
                {
                    MessageBox.Show("Hatalı Oturum");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void showNotification()
        {



        }
    }


}

