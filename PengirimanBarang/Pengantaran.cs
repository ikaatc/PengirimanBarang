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
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void idkaryawantxt()
        {
            koneksi.Open();
            string str = "select id_karyawan from dbo.karyawan";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            koneksi.Close();
            cbxidkaryawan.ValueMember = "id_karyawan";
            cbxidkaryawan.DataSource = ds.Tables[0];
        }

        private void idkurirtxt()
        {
            koneksi.Open();
            string str = "select id_kurir from dbo.kurir";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            koneksi.Close();
            cbxidkurir.ValueMember = "id_kurir";
            cbxidkurir.DataSource = ds.Tables[0];
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
            txtidpengantaran.Text = "";
            txtidpengantaran.Enabled = false;
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
            txtidpengantaran.Enabled = true;
            cbxidkaryawan.Enabled = true;
            cbxidkurir.Enabled = true;
            dtpenerimaan.Enabled = true;
            btnsave.Enabled = true;
            btnclear.Enabled = true;
            idkaryawantxt();
            idkurirtxt();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string idpengantaran = txtidpengantaran.Text;
            string idkaryawan = cbxidkaryawan.Text;
            string idkurir = cbxidkurir.Text;
            DateTime estimasipenerimaan = dtpenerimaan.Value;
            
            koneksi.Open();
            string strs = "select id_karyawan from dbo.karyawan where id_karyawan = @idk, select id_kurir from dbo.kurir where id_kurir = @idku";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@idk", idkaryawan));
            cm.Parameters.Add(new SqlParameter("@idku", idkurir));

            string str = "INSERT INTO dbo.pengantaran (id_pengantaran, id_karyawan, id_kurir, estimasi_penerimaan) " +
                    "VALUES (@idpengantaran, @idk, @idku, @estimasi)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@idpengantaran", idpengantaran));
            cmd.Parameters.Add(new SqlParameter("@idk", idkaryawan));
            cmd.Parameters.Add(new SqlParameter("@idku", idkurir));
            cmd.Parameters.Add(new SqlParameter("@estimasi", estimasipenerimaan));
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

        private void Pengantaran_Load(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idPengiriman = dataGridView1.SelectedRows[0].Cells["id_pengantaran"].Value.ToString();

                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data pengantaran dengan ID " + idPengiriman + "?",
                    "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    koneksi.Open();
                    string str = "DELETE FROM dbo.pengantaran WHERE id_pengantaran = @idpengantaran";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.Parameters.AddWithValue("@idpengantaran", idPengiriman);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    koneksi.Close();
                    dataGridView();
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih baris data yang ingin dihapus.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
