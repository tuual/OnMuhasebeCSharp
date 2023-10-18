﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace OnMuhasebe
{
    public partial class frmStokKartEkle : MaterialForm

    {
        private readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private SqlCommand cmd;
        private SqlConnection sqlConnection;
        private SqlConn sqlConn;

        public frmStokKartEkle()
        {
            InitializeComponent();
            sqlConn = new SqlConn();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700
                , MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            insertData();

        }
        private void insertData()
        {
            String query = "INSERT INTO tblStokEkle (stokKodu,stokIsim,stokMiktar,stokAciklama,stokDeposu,stokKdvOrani,stokBarkod) VALUES (@stokkodu,@stokisim,@stokmiktar,@stokaciklama,@stokdeposu,@stokkdvorani,@stokbarkodno)";
            try
            {
                cmd.Parameters.AddWithValue("@stokkodu", txtStokKodu.Text);
                cmd.Parameters.AddWithValue("@stokisim", txtStokisim.Text);
                cmd.Parameters.AddWithValue("@stokmiktar", txtStokMiktar.Text);
                cmd.Parameters.AddWithValue("@stokaciklama", txtStokAciklama.Text);
                cmd.Parameters.AddWithValue("@stokdeposu", cbStokDeposu.Text.ToString());
                cmd.Parameters.AddWithValue("@stokkdvorani", txtStokKdv.Text);
                cmd.Parameters.AddWithValue("@stokbarkodno", txtBarkodNo.Text);
                sqlConn.sqlConnection.Open();
                int result = cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          

        }
    }
}

