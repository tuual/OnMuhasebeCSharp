using System;
using System.Collections;
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

namespace OnMuhasebe
{
    public partial class frmAnaEkran : MaterialForm

    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmAnaEkran()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700
                , MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void frmAnaEkran_Load(object sender, EventArgs e)
        {
            tableUpdate();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnStokKart_Click(object sender, EventArgs e)
        {
            frmStokKartEkle stokKartEkle = new frmStokKartEkle();
            stokKartEkle.Show();

        }
        private void tableUpdate()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false;




            string readQuery = "SELECT * FROM tblStokEkle";
            String connect = "Server=213.254.137.231;Database=OnMuhasebe;User Id=biltekbilisim;Password=Bilisim20037816";
            using (SqlConnection connection = new SqlConnection(connect))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(readQuery, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // DataGridView kontrolüne verileri yükle
                    dataGridView1.DataSource = dataTable;
                }
            }
        }
    }

}
