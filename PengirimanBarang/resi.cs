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
    public partial class resi : Form
    {
        private string stringConnection = "data source=DESKTOP-9NQGA7N\\IKATC;" + "database=PengirimanBarang; User ID = sa; Password = 1234";
        private SqlConnection koneksi;
        public resi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select no_resi, id_pengirim, nm_barang, jns_barang, kategori_barang, tgl_pengiriman, berat_brg, harga_pengiriman from dbo.resi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            koneksi.Close();
        }

        private void refreshform()
        {
            txtnoresi.Text = "";
            txtnoresi.Enabled = false;
            txtbrg.Text = "";
            txtbrg.Enabled = false;
            txtharga.Text = "";
            txtharga.Enabled = false;
            datetime.Enabled = false;
            cbxidpengirim.Text = "";
            cbxidpengirim.Enabled = false;
            cbxidpengirim.SelectedIndex = -1;
            txtnama.Visible = false;
            txtjns.Visible = false;
            txtktgr.Visible = false;
            btnsave.Enabled = false;
            btnclear.Visible = false;
        }

        private void resi_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 hu = new Form1();
            hu.Show();
            this.Hide();
        }
    }
}
