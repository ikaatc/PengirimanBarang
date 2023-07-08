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
    public partial class karyawan : Form
    {
        private string stringConnection = "data source=DESKTOP-9NQGA7N\\IKATC;" + "database=PengirimanBarang; User ID = sa; Password = 1234";
        private SqlConnection koneksi;
        public karyawan()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_karyawan, nm_karyawan, notlp_karyawan from dbo.Karyawan";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void refreshform()
        {
            txtkaryawan.Text = "";
            txtkaryawan.Enabled = false;
            txtnmkaryawan.Text = "";
            txtnmkaryawan.Enabled = false;
            txtnokaryawan.Text = "";
            txtnokaryawan.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtkaryawan.Enabled = true;
            txtnmkaryawan.Enabled = true;
            txtnokaryawan.Enabled = true;
            btnsave.Enabled = true;
            btnclear.Enabled = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string idkaryawan = txtkaryawan.Text;
            string nmkaryawan = txtnmkaryawan.Text;
            string nokaryawan = txtnokaryawan.Text;

            if (idkaryawan == "")
            {
                MessageBox.Show("Masukkan ID Karyawan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (nmkaryawan == "")
            {
                MessageBox.Show("Masukkan Nama Karyawan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (nokaryawan == "")
            {
                MessageBox.Show("Masukkan No Telpon Karyawan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void karyawan_Load(object sender, EventArgs e)
        {
            refreshform();
        }
    }
}
