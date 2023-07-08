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
    public partial class penerima : Form
    {
        private string stringConnection = "data source=DESKTOP-9NQGA7N\\IKATC;" + "database=PengirimanBarang; User ID = sa; Password = 1234";
        private SqlConnection koneksi;
        public penerima()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            txtpenerima.Text = "";
            txtpenerima.Enabled = false;
            txtnmpenerima.Text = "";
            txtnmpenerima.Enabled = false;
            txtalmtpenerima.Text = "";
            txtalmtpenerima.Enabled = false;
            txtnopenerima.Text = "";
            txtnopenerima.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
        }

        private void penerima_Load(object sender, EventArgs e)
        {
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_penerima, nm_penerima, alamat_penerima, notlp_penerima from dbo.Penerima";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
