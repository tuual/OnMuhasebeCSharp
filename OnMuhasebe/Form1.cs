using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Drawing;

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
        public Form1()
        {
            InitializeComponent();
        }

        public object ToastNotificationManager { get; private set; }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            sirketAdi = txtKadi.Text;
            sifre = txtSifre.Text;
            loginCheck(sirketAdi, sifre);
            dbConnection(1);



        }
        private void dbConnection(int isOpen)
        {
            sqlConn = new SqlConn();
            try
            {
                if (isOpen == 1)
                {
                    sqlConn.sqlConnection.Open();


                }
                else
                {
                    sqlConn.sqlConnection.Close();
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                sqlConn.sqlConnection.Close();

            }
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
            }
            else
            {
                MessageBox.Show("Hatalý Oturum");
            }
        }

    }

}