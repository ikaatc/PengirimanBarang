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
    public partial class pengirim : Form
    {
        private string stringConnection = "data source=DESKTOP-9NQGA7N\\IKATC;" + "database=PengirimanBarang; User ID = sa; Password = 1234";
        private SqlConnection koneksi;
        public pengirim()
        {
            InitializeComponent();
        }

        private void refreshform()
        {
            txtpengirim.Text = "";
            txtpengirim.Enabled = false;
            txtnmpengirim.Text = "";
            txtnmpengirim.Enabled = false;
            txtnopengirim.Text = "";
            txtnopengirim.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_pengirim, nm_pengirim, notlp_pengirim from dbo.Pengirim";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void notelppengirim_Click(object sender, EventArgs e)
        {

        }

        private void pengirim_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnopen_Click(object sender, EventArgs e)
        {
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
        }

        private void btnback_Click(object sender, EventArgs e)
        {
        }
    }
}
