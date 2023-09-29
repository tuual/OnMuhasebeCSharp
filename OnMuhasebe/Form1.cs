using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Drawing;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace OnMuhasebe
{
    public partial class Form1 : Form

    {
        private string sirketAdi, sifre;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private string queryLogin;
        private SqlConn sqlConn;
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public Form1()
        {
            sqlConn = new SqlConn();
            sqlConn.sqlConnection.Open();
            InitializeComponent();

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            sirketAdi = txtSirketAdi.Text;
            sifre = txtSifre.Text;
            loginCheck(sirketAdi, sifre);

        }



        private void loginCheck(string sirketAdi, string sifre)
        {
            queryLogin = "SELECT * FROM tblUser where sirketAdi=@sirketadi AND sifre=@sifre";

            SqlConnection sqlConnection = new SqlConnection("Server=213.254.137.231;Database=OnMuhasebe;User Id=biltekbilisim;Password=Bilisim20037816");
            cmd = new SqlCommand(queryLogin, sqlConnection);
            cmd.Parameters.AddWithValue("@sirketAdi", sirketAdi);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            sqlConnection.Open();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Giriþ Baþarýlý");
                frmAnaEkran frmAnaEkran = new frmAnaEkran();
                frmAnaEkran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalý Oturum");
            }
        }

    }

}