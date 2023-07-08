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
            koneksi = new SqlConnection(stringConnection);
            refreshform();
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
            refreshform();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            string idpengirim = txtpengirim.Text;
            string nmpengirim = txtnmpengirim.Text;
            string nopengirim = txtnopengirim.Text;

            if (idpengirim == "")
            {
                MessageBox.Show("Masukkan ID Pengirim", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (nmpengirim == "")
            {
                MessageBox.Show("Masukka Nama Pengirim", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (nopengirim == "")
            {
                MessageBox.Show("Masukkan No Telepon Pengirim", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "INSERT INTO pengirim (id_pengirim, nm_pengirim, notlp_pengirim) VALUES (@id_pengirim, @nm_pengirim, @notlp_pengirim)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_pengirim", idpengirim));
                cmd.Parameters.Add(new SqlParameter("@nm_pengirim", nmpengirim));
                cmd.Parameters.Add(new SqlParameter("@notlp_pengirim", nopengirim));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtpengirim.Enabled = true;
            txtnmpengirim.Enabled = true;
            txtnopengirim.Enabled = true;
            btnsave.Enabled = true;
            btnclear.Enabled = true;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 hu = new Form1();
            hu.Show();
            this.Hide();
        }
    }
}
