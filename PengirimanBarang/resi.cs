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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PengirimanBarang
{
    public partial class resi : Form
    {
        private string stringConnection = "data source=DESKTOP-9NQGA7N\\IKATC;" + "database=PengirimanBarang; User ID = sa; Password = 1234";
        private SqlConnection koneksi;

        private string no, id, berat, harga;
        private DateTime tgl;
        public resi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void resi_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select no_resi, id_pengirim, nm_barang, berat_brg, harga_pengiriman, tgl_pengiriman from dbo.resi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void idpengirimtxt()
        {
            koneksi.Open();
            string str = "SELECT id_pengirim FROM dbo.pengirim";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();

            cbxid.DisplayMember = "id_pengirim";
            cbxid.DataSource = ds.Tables[0];
        }

        private void nmbarangtxt()
        {
            koneksi.Open();
            string str = "SELECT nm_barang FROM dbo.barang";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();

            cbxnm.DisplayMember = "nm_barang";
            cbxnm.DataSource = ds.Tables[0];
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 hu = new Form1();
            hu.Show();
            this.Hide();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtno.Enabled = true;
            cbxid.Enabled = true;
            cbxnm.Enabled = true;
            txtberat.Enabled = true;
            txtharga.Enabled = true;
            datetime.Enabled = true;
            btnsave.Enabled = true;
            btnclear.Enabled = true;
            idpengirimtxt();
            nmbarangtxt();
        }

        private void refreshform()
        {
            txtno.Enabled = false;
            cbxid.Enabled = false;
            cbxnm.Enabled = false;
            txtberat.Enabled = false;
            txtharga.Enabled = false;
            datetime.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
        }

        private void cbxid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string noResi = dataGridView1.SelectedRows[0].Cells["no_resi"].Value.ToString();

                    koneksi.Open();
                    string str = "DELETE FROM dbo.resi WHERE no_resi = @noResi";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.Parameters.AddWithValue("@noResi", noResi);
                    cmd.ExecuteNonQuery();
                    koneksi.Close();

                    MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView();
                }
            }
            else
            {
                MessageBox.Show("Pilih baris data yang ingin dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            no = txtno.Text;
            berat = txtberat.Text;
            harga = txtharga.Text;
            tgl = datetime.Value;
            id = cbxid.Text;
            string nm = cbxnm.Text;

            koneksi.Open();
            string strs = "select id_pengirim from dbo.pengirim where id_pengirim = @idp";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@idp", id));

            string str = "insert into dbo.resi(no_resi, id_pengirim, nm_barang, berat_brg, harga_pengiriman, tgl_pengiriman)" +
                "values (@no, @idp, @nmb, @berat, @harga, @tgl)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@no", no);
            cmd.Parameters.AddWithValue("@idp", id);
            cmd.Parameters.AddWithValue("@nmb", nm);
            cmd.Parameters.AddWithValue("@berat", berat);
            cmd.Parameters.AddWithValue("@harga", harga);
            cmd.Parameters.AddWithValue("@tgl", tgl);
            cmd.ExecuteNonQuery();

            koneksi.Close();
            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView();
            refreshform();
        }
    }
}
