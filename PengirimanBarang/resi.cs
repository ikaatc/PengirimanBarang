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

        BindingSource customersBindingSource = new BindingSource();
        public resi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select no_resi, id_pengirim, nm_barang, tgl_pengiriman, berat_brg, harga_pengiriman from dbo.resi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            koneksi.Close();
        }

        private void refreshform()
        {
            
        }

        private void idpengirimtxt()
        {
            koneksi.Open();
            string str = "SELECT id_pengirim FROM dbo.pengirim";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();

            cbxidpengirim.DisplayMember = "id_pengirim";
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
            txtnoresi.Enabled = true;
            cbxidpengirim.Enabled = true;
            txtbrg.Enabled = true;
            txtharga.Enabled = true;
            datetime.Enabled = true;
            idpengirimtxt();
            btnclear.Enabled = true;
            btnsave.Enabled = true;

        }

        private void cbxidpengirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            koneksi.Open();
            string nm = "";
            string strs = "select nm_barang from dbo.barang where id_pengirim = @idp";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@idp", cbxidpengirim.Text));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                nm = dr["nm_barang"].ToString();
            }
            dr.Close();
            koneksi.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            refreshform();
        }
    }
}
