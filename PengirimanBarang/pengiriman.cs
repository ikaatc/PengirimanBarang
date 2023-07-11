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
            refreshform();
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

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 hu = new Form1();
            hu.Show();
            this.Hide();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtidpengiriman.Text = "";
            txtidpengiriman.Enabled = true;
            cbxidpengirim.Text = "";
            cbxidpengirim.Enabled = true;
            cbxidpenerima.Text = "";
            cbxidpenerima.Enabled = true;
            dtpengantaran.Enabled = true;
            btnsave.Enabled = true;
            btnclear.Enabled = true;
            idpengirimtxt();
            idpenerimatxt();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnopen.Enabled = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            idpengiriman = txtidpengiriman.Text;
            idpengirim = cbxidpengirim.Text;
            idpenerima = cbxidpenerima.Text;
            tgl = dtpengantaran.Value;

            koneksi.Open();
            string strs = "select id_pengirim from dbo.pengirim where id_pengirim = @idp, select id_penerima from dbo.penerima where id_penerima = @idpn";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@idp", idpengirim));
            cm.Parameters.Add(new SqlParameter("@idpn", idpenerima));

            string str = "insert into dbo.pengiriman(id_pengiriman, id_pengirim, id_penerima, tgl_pengantaran)" +
                "values (@idpeng, @idp, @idpn, @tgl)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idpeng", idpengiriman);
            cmd.Parameters.AddWithValue("@idp", idpengirim);
            cmd.Parameters.AddWithValue("@idpn", idpenerima);
            cmd.Parameters.AddWithValue("@tgl", tgl);
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView();
            refreshform();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Ambil ID pengiriman dari baris yang dipilih
                string idPengiriman = dataGridView1.SelectedRows[0].Cells["id_pengiriman"].Value.ToString();

                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data pengiriman dengan ID " + idPengiriman + "?",
                    "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    
                        koneksi.Open();

                        // Hapus data pengiriman berdasarkan ID pengiriman
                        string str = "DELETE FROM dbo.pengiriman WHERE id_pengiriman = @idpengiriman";
                        SqlCommand cmd = new SqlCommand(str, koneksi);
                        cmd.Parameters.AddWithValue("@idpengiriman", idPengiriman);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        koneksi.Close();
                        // Refresh tampilan DataGridView
                        dataGridView();

                        
                    
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih baris data yang ingin dihapus.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_pengiriman, id_pengirim, id_penerima, tgl_pengantaran from dbo.pengiriman";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void refreshform()
        {
            txtidpengiriman.Text = "";
            txtidpengiriman.Enabled = false;
            cbxidpengirim.Text = "";
            cbxidpengirim.Enabled = false;
            cbxidpenerima.Text = "";
            cbxidpenerima.Enabled = false;
            dtpengantaran.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
        }
    }
}
