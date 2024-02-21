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
        public int id, id2;

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


            tableUpdate("tblStokEkle", dataGridView1);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnStokKart_Click(object sender, EventArgs e)
        {
            frmStokKartEkle stokKartEkle = new frmStokKartEkle();
            stokKartEkle.Show();

        }
        private void tableUpdate(String tabloadi, DataGridView dt)
        {
            dt.ReadOnly = true;
            dt.AllowUserToDeleteRows = false;




            string readQuery = "SELECT * FROM " + tabloadi;
            String connect = "Server=;Database=OnMuhasebe;User Id=;Password=";
            using (SqlConnection connection = new SqlConnection(connect))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(readQuery, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dt.DataSource = dataTable;
                }
            }


        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            tableUpdate("tblStokEkle", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    id = Convert.ToInt32(selectedRow.Cells["stokID"].Value);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            frmGuncelleme frmguncelleme = new frmGuncelleme(this, id);

            if (id == null || id == 0)
            {
                MessageBox.Show("Bir Satır Seçiniz.");

            }
            else
            {
                frmguncelleme.ShowDialog();
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            deleteData("tblStokEkle", "stokID", id.ToString());
            tableUpdate("tblStokEkle", dataGridView1);

        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
            frmPersonelEkle frmprsnlekle = new frmPersonelEkle();
            frmprsnlekle.Show();

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (materialTabControl1.SelectedTab == tabPage1)
            {
                tableUpdate("tblStokEkle", dataGridView1);
            }
            else if (materialTabControl1.SelectedTab == tabPage2)
            {

            }
            else if (materialTabControl1.SelectedTab == tabPage3)
            {
                tableUpdate("tblUser", dataGridView2);

            }
        }
        private void deleteData(String tabloadi, String idadi, String seciliId)
        {
            DialogResult dr = MessageBox.Show("Seçilen Satırı Silmek İstiyor musunuz ? ", "Veri Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            switch (dr)
            {

                case DialogResult.Yes:
                    String query = "DELETE FROM " + tabloadi + " WHERE " + idadi + "=" + seciliId;
                    String connect = "Server=213.254.137.231;Database=OnMuhasebe;User Id=biltekbilisim;Password=Bilisim20037816";
                    sqlCon = new SqlConnection(connect);
                    cmd = new SqlCommand();
                    cmd.Connection = sqlCon;
                    sqlCon.Open();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();
                    break;
                case DialogResult.No:

                    break;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                    id2 = Convert.ToInt32(selectedRow.Cells["ID"].Value);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            deleteData("tblUser", "ID", id2.ToString());

            tableUpdate("tblUser", dataGridView2);

        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            tableUpdate("tblUser", dataGridView2);
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {

            frmPersonelGuncelleme frmpersonelguncelleme = new frmPersonelGuncelleme(this,id2);

            if (id2 == null || id2 == 0)
            {
                MessageBox.Show("Bir Satır Seçiniz.");

            }
            else
            {
                frmpersonelguncelleme.ShowDialog();
                
            }
        }
    }
}
