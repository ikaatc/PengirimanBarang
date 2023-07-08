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

            else
            {
                koneksi.Open();
                string str = "INSERT INTO karyawan (id_karyawan, nm_karyawan, notlp_karyawan) VALUES (@id_karyawan, @nm_karyawan, @notlp_karyawan)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_karyawan", idkaryawan));
                cmd.Parameters.Add(new SqlParameter("@nm_karyawan", nmkaryawan));
                cmd.Parameters.Add(new SqlParameter("@notlp_karyawan", nokaryawan));
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnopen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnopen.Enabled = false;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 hu = new Form1();
            hu.Show();
            this.Hide();
        }
    }
}
