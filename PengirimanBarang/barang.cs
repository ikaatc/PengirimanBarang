using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;

namespace PengirimanBarang
{
    public partial class barang : Form
    {
        private string stringConnection = "data source=DESKTOP-9NQGA7N\\IKATC;" + "database=PengirimanBarang; User ID = sa; Password = 1234";
        private SqlConnection koneksi;

        private string nama, jenis, kategori, idpeng, idkar;
        BindingSource customersBindingSource = new BindingSource();
        public barang()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 hu = new Form1();
            hu.Show();
            this.Hide();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnopen.Enabled = false;
        }

        private void idpengirimtxt()
        {
            koneksi.Open();
            string str = "select id_pengirim from dbo.pengirim";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            koneksi.Close();
            txtidpengirim.ValueMember = "id_pengirim";
            txtidpengirim.DataSource = ds.Tables[0];
        }

        private void idkaryawantxt()
        {
            koneksi.Open();
            string str = "select id_karyawan from dbo.karyawan";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            txtidkaryawan.ValueMember = "id_karyawan";
            txtidkaryawan.DataSource = ds.Tables[0];
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtidpengirim.Text = "";
            txtnmbarang.Text = "";
            txtjnsbarang.Text = "";
            txtktgrbarang.Text = "";
            txtidkaryawan.Text = "";
            txtidpengirim.Enabled = true;
            txtnmbarang.Enabled = true;
            txtjnsbarang.Enabled = true;
            txtktgrbarang.Enabled = true;
            txtidkaryawan.Enabled = true;
            idpengirimtxt();
            idkaryawantxt();
            btnsave.Enabled = true;
            btnclear.Enabled = true;
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_pengirim, id_karyawan, nm_barang, jns_barang, kategori_barang from dbo.barang";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void refreshform()
        {
            txtidpengirim.Text = "";
            txtidpengirim.Enabled = false;
            txtidkaryawan.Text = "";
            txtidkaryawan.Enabled = false;
            txtnmbarang.Text = "";
            txtnmbarang.Enabled = false;
            txtjnsbarang.Text = "";
            txtjnsbarang.Enabled = false;
            txtktgrbarang.Text = "";
            txtktgrbarang.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void barang_Load(object sender, EventArgs e)
        {

        }
    }
}
