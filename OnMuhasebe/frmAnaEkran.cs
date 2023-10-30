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
        private SqlCommand cmd;
        private SqlConnection sqlCon;

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

        private void materialButton2_Click(object sender, EventArgs e)
        {
            tableUpdate();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    int id = Convert.ToInt32(selectedRow.Cells["stokID"].Value);
                    DialogResult dr = MessageBox.Show("Seçilen Stoğu Silmek İstiyor musunuz ? ", "Stok Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    switch (dr)
                    {

                        case DialogResult.Yes:
                            String query = "DELETE FROM tblStokEkle WHERE stokID=" + id;
                            String connect = "Server=213.254.137.231;Database=OnMuhasebe;User Id=biltekbilisim;Password=Bilisim20037816";
                            sqlCon = new SqlConnection(connect);
                            cmd = new SqlCommand();
                            cmd.Connection = sqlCon;
                            sqlCon.Open();
                            cmd.CommandText = query;
                            cmd.ExecuteNonQuery();
                            sqlCon.Close();
                            dataGridView1.Refresh();
                            break;
                        case DialogResult.No:

                            break;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }
    }
}
