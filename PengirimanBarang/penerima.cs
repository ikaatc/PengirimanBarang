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

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 hu = new Form1();
            hu.Show();
            this.Hide();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtpenerima.Enabled = true;
            txtnmpenerima.Enabled = true;
            txtalmtpenerima.Enabled = true;
            txtnopenerima.Enabled = true;
            btnsave.Enabled = true;
            btnclear.Enabled = true;
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnopen.Enabled = false;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string idpenerima = txtpenerima.Text;
            string nmpenerima = txtnmpenerima.Text;
            string almtpenerima = txtalmtpenerima.Text;
            string nopenerima = txtnopenerima.Text;

            if (idpenerima == "")
            {
                MessageBox.Show("Masukkan ID Penerima", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (nmpenerima == "")
            {
                MessageBox.Show("Masukka Nama Penerima", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (almtpenerima == "")
            {
                MessageBox.Show("Masukka Alamat Penerima", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (nopenerima == "")
            {
                MessageBox.Show("Masukkan No Telepon Penerima", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "INSERT INTO penerima(id_penerima, nm_penerima, alamat_penerima, notlp_penerima) VALUES (@id_penerima, @nm_penerima, @alamat_penerima, @notlp_penerima)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_penerima", idpenerima));
                cmd.Parameters.Add(new SqlParameter("@nm_penerima", nmpenerima));
                cmd.Parameters.Add(new SqlParameter("@alamat_penerima", almtpenerima));
                cmd.Parameters.Add(new SqlParameter("@notlp_penerima", nopenerima));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }
    }
}
