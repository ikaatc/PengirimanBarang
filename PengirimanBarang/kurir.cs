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
    public partial class kurir : Form
    {
        private string stringConnection = "data source=DESKTOP-9NQGA7N\\IKATC;" + "database=PengirimanBarang; User ID = sa; Password = 1234";
        private SqlConnection koneksi;
        public kurir()
        {
            InitializeComponent();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_kurir, nm_kurir, alamat_kurir, notlp_kurir from dbo.Kurir";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void refreshform()
        {
            txtkurir.Text = "";
            txtkurir.Enabled = false;
            txtnmkurir.Text = "";
            txtnmkurir.Enabled = false;
            txtalmtkurir.Text = "";
            txtalmtkurir.Enabled = false;
            txtnokurir.Text = "";
            txtnokurir.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
        }


        private void btnadd_Click(object sender, EventArgs e)
        {
            txtkurir.Enabled = true;
            txtnmkurir.Enabled = true;
            txtalmtkurir.Enabled = true;
            txtnokurir.Enabled = true;
            btnsave.Enabled = true;
            btnclear.Enabled = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string idkurir = txtkurir.Text;
            string nmkurir = txtnmkurir.Text;
            string almtkurir = txtalmtkurir.Text;
            string nokurir = txtnokurir.Text;

            if (idkurir == "")
            {
                MessageBox.Show("Masukkan ID Kurir", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (nmkurir == "")
            {
                MessageBox.Show("Masukkan Nama Kurir", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (almtkurir == "")
            {
                MessageBox.Show("Masukkan Alamat Kurir", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
            }

            if (nokurir == "")
            {
                MessageBox.Show("Masukkan No Telpon Kurir", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                koneksi.Open();
                string str = "INSERT INTO kurir (id_kurir, nm_kurir, alamat_kurir, notlp_kurir) VALUES (@id_kurir, @nm_kurir, @alamat_kurir, @notlp_kurir)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_kurir", idkurir));
                cmd.Parameters.Add(new SqlParameter("@nm_kurir", nmkurir));
                cmd.Parameters.Add(new SqlParameter("@alamat_kurir", almtkurir));
                cmd.Parameters.Add(new SqlParameter("@notlp_kurir", nokurir));
                cmd.ExecuteNonQuery();
            }
        }
    }
}
