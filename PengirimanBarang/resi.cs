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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PengirimanBarang
{
    public partial class resi : Form
    {
        private string stringConnection = "data source=DESKTOP-9NQGA7N\\IKATC;" + "database=PengirimanBarang; User ID = sa; Password = 1234";
        private SqlConnection koneksi;
        public resi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void resi_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select no_resi, id_pengirim, nm_barang, berat_brg, harga_pengiriman, tgl_pengiriman from dbo.resi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 hu = new Form1();
            hu.Show();
            this.Hide();
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
            cbxid.ValueMember = "id_pengirim";
            cbxid.DataSource = ds.Tables[0];
        }

        private void nmbarangtxt()
        {
            koneksi.Open();
            string str = "select id_barang, nm_barang from dbo.barang";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxnama.DisplayMember = "nm_barang";
            cbxnama.ValueMember = "id_barang";
            cbxnama.DataSource = ds.Tables[0];
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtno.Enabled = true;
            cbxid.Enabled = true;
            cbxnama.Enabled = true;
            txtberat.Enabled = true;
            txtharga.Enabled = true;
            datetime.Enabled = true;
            idpengirimtxt();
            nmbarangtxt();
            btnsave.Enabled = true;
            btnclear.Enabled = true;
        }

        private void refreshform()
        {
            txtno.Enabled = false;
            cbxid.Enabled = false;
            cbxnama.Enabled = false;
            txtberat.Enabled = false;
            txtharga.Enabled = false;
            datetime.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            refreshform();
        }
    }
}
