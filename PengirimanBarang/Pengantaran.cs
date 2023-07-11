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
    public partial class Pengantaran : Form
    {
        private string stringConnection = "data source=DESKTOP-9NQGA7N\\IKATC;" + "database=PengirimanBarang; User ID = sa; Password = 1234";
        private SqlConnection koneksi;
        public Pengantaran()
        {
            InitializeComponent();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_pengantaran, id_karyawan, id_kurir, estimasi_penerimaan from dbo.pengantaran";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void refreshform()
        {
            cbxidpengantaran.Text = "";
            cbxidpengantaran.Enabled = false;
            cbxidkaryawan.Text = "";
            cbxidkaryawan.Enabled = false;
            cbxidkurir.Text = "";
            cbxidkurir.Enabled = false;
            dtpenerimaan.Text = "";
            dtpenerimaan.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            cbxidpengantaran.Enabled = true;
            cbxidkaryawan.Enabled = true;
            cbxidkurir.Enabled = true;
            dtpenerimaan.Enabled = true;
            btnsave.Enabled = true;
            btnclear.Enabled = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string idpengantaran = cbxidpengantaran.Text;
            string idkaryawan = cbxidkaryawan.Text;
            string idkurir = cbxidkurir.Text;
            string estimasipenerimaan = dtpenerimaan.Text;

            if (idpengantaran == "")
            {
                MessageBox.Show("Masukkan ID Pengantaran", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (idkaryawan == "")
            {
                MessageBox.Show("Masukkan ID Karyawan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (idkurir == "")
            {
                MessageBox.Show("Masukkan ID Kurir", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (estimasipenerimaan == "")
            {
                MessageBox.Show("Masukkan Estimasi Penerimaan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                koneksi.Open();
                string str = "INSERT INTO pengantaran (id_pengantaran, id_karyawan, id_kurir, estimasi_penerimaan) " +
                    "VALUES (@id_pengantaran, @id_karyawan, @id_kurir, @estimasi_penerimaan)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_pengantaran", idpengantaran));
                cmd.Parameters.Add(new SqlParameter("@id_karyawan", idkaryawan));
                cmd.Parameters.Add(new SqlParameter("@id_kurir", idkurir));
                cmd.Parameters.Add(new SqlParameter("@estimasi_penerimaan", estimasipenerimaan));
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
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
