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

namespace PengirimanBarang
{
    public partial class detail_penerima : Form
    {
        private string stringConnection = "data source=DESKTOP-9NQGA7N\\IKATC;" + "database=PengirimanBarang; User ID = sa; Password = 1234";
        private SqlConnection koneksi;
        public detail_penerima()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void idkurirtxt()
        {
            koneksi.Open();
            string str = "select id_kurir from dbo.kurir";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            koneksi.Close();
            cbxidkurir.ValueMember = "id_kurir";
            cbxidkurir.DataSource = ds.Tables[0];
        }

        private void idpenerimatxt()
        {
            koneksi.Open();
            string str = "select id_penerima from dbo.penerima";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            koneksi.Close();
            cbxidpenerima.ValueMember = "id_penerima";
            cbxidpenerima.DataSource = ds.Tables[0];
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 hu = new Form1();
            hu.Show();
            this.Hide();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtbuktipenerima.Enabled = true;
            cbxiddetail.Enabled = true;
            cbxidkurir.Enabled = true;
            cbxidpenerima.Enabled = true;
            dtditerima.Enabled = true;
            btnsave.Enabled = true;
            btnclear.Enabled = true;
            idkurirtxt();
            idpenerimatxt();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_detail_penerima, id_kurir, id_penerima, bukti_penerima, tgl_penerima from dbo.detail_penerima";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnopen.Enabled = false;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

        }

        private void refreshform()
        {
            txtbuktipenerima.Enabled = false;
            cbxiddetail.Enabled = false;
            cbxidkurir.Enabled = false;
            cbxidpenerima.Enabled = false;
            dtditerima.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
        }
    }
}
