using MaterialSkin.Controls;
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

namespace OnMuhasebe
{
    public partial class frmGuncelleme : MaterialForm
    {
        private readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private SqlConnection sqlConnection;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private String updateQuery;
        int stokId;
        private frmAnaEkran anaEkranReferansi;

        public frmGuncelleme(frmAnaEkran anaEkran, int id)
        {
            sqlConnection = new SqlConnection("Server=213.254.137.231;Database=OnMuhasebe;User Id=biltekbilisim;Password=Bilisim20037816");

            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700
                , MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
            anaEkranReferansi = anaEkran;
            stokId = id;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                updateQuery = "UPDATE tblStokEkle set stokKodu=@stokkodu,stokIsim=@stokisim,stokMiktar=@stokmiktar,stokAciklama=@stokaciklama,stokKdvOrani=@stokkdv,stokBarkod=@stokbarkod WHERE stokID=" + stokId;
                sqlConnection.Open();
                cmd = new SqlCommand(updateQuery, sqlConnection);
                cmd.Parameters.AddWithValue("@stokkodu", txtStokKodu.Text);
                cmd.Parameters.AddWithValue("@stokisim", txtStokisim.Text);
                cmd.Parameters.AddWithValue("@stokmiktar", txtStokMiktar.Text);
                cmd.Parameters.AddWithValue("@stokAciklama", txtStokAciklama.Text);
                cmd.Parameters.AddWithValue("@stokkdv", txtStokKdv.Text);
                cmd.Parameters.AddWithValue("@stokbarkod", txtBarkodNo.Text);

                cmd.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Güncelleme Başarılı");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           



        }

        private void frmGuncelleme_Load(object sender, EventArgs e)
        {
            SetID();
            veriGetir();
        }

        public void SetID()
        {
            anaEkranReferansi.id = stokId;
            MessageBox.Show(stokId.ToString());
        }


        private void veriGetir()
        {
            String query = "SELECT * FROM tblStokEkle WHERE stokID=" + stokId;


            cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtStokKodu.Text = reader["stokKodu"].ToString().Trim();
                txtStokisim.Text = reader["stokIsim"].ToString().Trim();
                txtStokMiktar.Text = reader["stokMiktar"].ToString().Trim();
                txtStokAciklama.Text = reader["stokAciklama"].ToString().Trim();
                txtStokKdv.Text = reader["stokKdvOrani"].ToString().Trim();
                txtBarkodNo.Text = reader["stokBarkod"].ToString().Trim();
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
