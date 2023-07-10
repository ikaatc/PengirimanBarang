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

        private void idpengirimtxt()
        {
            koneksi.Open();
            string str = "SELECT id_pengirim FROM dbo.pengirim WHERE " +
             "NOT EXISTS (SELECT id_barang FROM dbo.barang WHERE " +
             "barang.nm_barang = pengirim.nm AND barang.jns_barang = pengirim.jns AND barang.kategori_barang = pengirim.kategori)";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            koneksi.Close();

            cbxidpengirim.DisplayMember = "id_pengirim";
            cbxidpengirim.ValueMember = "id_pengirim";
            cbxidpengirim.DataSource = ds.Tables[0];
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

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void cbxidpengirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            koneksi.Open();
            string nm = "";
            string jns = "";
            string ktgr = "";
            string strs = "select nm, jns, ktgr from dbo.barang where id_pengirim = @idp";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@idp", cbxidpengirim.SelectedValue)); // Mengambil nilai terpilih dari ComboBox
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            koneksi.Close();

            if (dt.Rows.Count > 0)
            {
                nm = dt.Rows[0]["nm"].ToString();
                jns = dt.Rows[0]["jns"].ToString();
                ktgr = dt.Rows[0]["ktgr"].ToString();
            }

            txtnama.Text = nm;
            txtjns.Text = jns;
            txtktgr.Text = ktgr;
        }
    }
}
