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
    public partial class pengiriman : Form
    {
        private string stringConnection = "data source=DESKTOP-9NQGA7N\\IKATC;" + "database=PengirimanBarang; User ID = sa; Password = 1234";
        private SqlConnection koneksi;

        private string idpengiriman, idpengirim, idpenerima;
        private DateTime tgl;
        public pengiriman()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void pengiriman_Load(object sender, EventArgs e)
        {

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
            cbxidpengirim.ValueMember = "id_pengirim";
            cbxidpengirim.DataSource = ds.Tables[0];
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
    }
}
