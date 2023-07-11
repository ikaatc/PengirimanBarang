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
    public partial class detail_penerima : Form
    {
        private string stringConnection = "data source=DESKTOP-9NQGA7N\\IKATC;" + "database=PengirimanBarang; User ID = sa; Password = 1234";
        private SqlConnection koneksi;

        private string iddetail, idk, idp, bukti;
        private DateTime tgl;
        public detail_penerima()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
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
            txtbuktipenerima.Enabled = true;
            txtidedetail.Enabled = true;
            cbxidkurir.Enabled = true;
            cbxidpenerima.Enabled = true;
            dtditerima.Enabled = true;
            btnsave.Enabled = true;
            btnclear.Enabled = true;
            idkurirtxt();
            idpenerimatxt();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_detail_penerima, id_kurir, id_penerima, bukti_penerima, tgl_penerima from dbo.detail_penerima";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string iddetail = dataGridView1.SelectedRows[0].Cells["id_detail_penerima"].Value.ToString();

                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data detail penerima dengan ID " + iddetail + "?",
                    "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    koneksi.Open();
                    string str = "DELETE FROM dbo.detail_penerima WHERE id_detail_penerima = @iddetail";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.Parameters.AddWithValue("@iddetail", iddetail);
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

        private void refreshform()
        {
            txtbuktipenerima.Enabled = false;
            txtidedetail.Enabled = false;
            cbxidkurir.Enabled = false;
            cbxidpenerima.Enabled = false;
            dtditerima.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
        }

        private void detail_penerima_Load(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            iddetail = txtidedetail.Text;
            idk = cbxidkurir.Text;
            idp = cbxidpenerima.Text;
            bukti = txtbuktipenerima.Text;
            tgl = dtditerima.Value;

            koneksi.Open();
            string strs = "select id_kurir from dbo.kurir where id_kurir = @idk, select id_penerima from dbo.penerima where id_penerima = @idp";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@idk", idk));
            cm.Parameters.Add(new SqlParameter("@idp", idp));

            string str = "insert into dbo.detail_penerima (id_detail_penerima, id_kurir, id_penerima, bukti_penerima, tgl_penerima)" +
                "values (@iddetail, @idk, @idp, @bukti, @tgl)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@iddetail", iddetail);
            cmd.Parameters.AddWithValue("@idk", idk);
            cmd.Parameters.AddWithValue("@idp", idp);
            cmd.Parameters.AddWithValue("@bukti", bukti);
            cmd.Parameters.AddWithValue("@tgl", tgl);
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView();
            refreshform();
        }
    }
}
