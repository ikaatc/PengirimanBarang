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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void barang_Load(object sender, EventArgs e)
        {

        }
    }
}
