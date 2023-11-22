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
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace OnMuhasebe
{
    public partial class frmPersonelGuncelleme : MaterialForm
    {
        private readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private SqlConnection sqlConnection;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private String updateQuery;
        int personelId;
        private frmAnaEkran anaEkranReferansi;
        public frmPersonelGuncelleme(frmAnaEkran anaEkran, int id2)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700
                , MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
            anaEkranReferansi = anaEkran;
            personelId = id2;

            sqlConnection = new SqlConnection("Server=213.254.137.231;Database=OnMuhasebe;User Id=biltekbilisim;Password=Bilisim20037816");

        }

        private void frmPersonelGuncelleme_Load(object sender, EventArgs e)
        {
            MessageBox.Show(personelId.ToString());
            veriGetir();
            label1.Visible = false;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text != "" || txtPersonelAd.Text != "" || txtSifre.Text != "")
                {
                    string emailRegex = @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$";
                    string emailInput = txtEmail.Text.Trim();
                    if (Regex.Match(emailInput, emailRegex).Success)
                    {
                        updateQuery = "UPDATE tblUser set sirketAdi=@sirketadi,sifre=@sifre,email=@email WHERE ID=" + personelId;
                        sqlConnection.Open();
                        cmd = new SqlCommand(updateQuery, sqlConnection);
                        cmd.Parameters.AddWithValue("@sirketadi", txtPersonelAd.Text);
                        cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);


                        cmd.ExecuteNonQuery();
                        sqlConnection.Close();

                        MessageBox.Show("Güncelleme Başarılı");
                        this.Close();
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void veriGetir()
        {
            String query = "SELECT * FROM tblUser WHERE ID=" + personelId;


            cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtPersonelAd.Text = reader["sirketAdi"].ToString().Trim();
                txtSifre.Text = reader["sifre"].ToString().Trim();
                txtEmail.Text = reader["email"].ToString().Trim();
               
            }
            else
            {
                MessageBox.Show("Eşleşen Bir Veri Bulunamadı.");
            }
            reader.Close();
            sqlConnection.Close();

        }
    }
}
