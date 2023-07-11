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
    public partial class resi : Form
    {
        private string stringConnection = "data source=DESKTOP-9NQGA7N\\IKATC;" + "database=PengirimanBarang; User ID = sa; Password = 1234";
        private SqlConnection koneksi;

        private string no, id, nm, berat, harga;
        private DateTime tgl;
        BindingSource customersBindingSource = new BindingSource();
        public resi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            txtnoresi.Enabled = false;
            cbxidpengirim.Enabled = false;
            cbxnama.Enabled = false;
            txtbrg.Enabled = false;
            txtharga.Enabled = false;
            datetime.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
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

            cbxidpengirim.DisplayMember = "id_pengirim";
            cbxidpengirim.DataSource = ds.Tables[0];
        }

        private void nmbarangtxt()
        {
            koneksi.Open();
            string str = "SELECT id_barang, nm_barang FROM dbo.barang";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();

            cbxnama.DisplayMember = "nm_barang";
            cbxnama.ValueMember = "id_barang";
            cbxnama.DataSource = ds.Tables[0];
        }

        private void resi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pengirimanBarangDataSet.resi' table. You can move, or remove it, as needed.
            this.resiTableAdapter.Fill(this.pengirimanBarangDataSet.resi);
            // TODO: This line of code loads data into the 'pengirimanBarangDataSet.pengirim' table. You can move, or remove it, as needed.
            this.pengirimTableAdapter.Fill(this.pengirimanBarangDataSet.pengirim);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 hu = new Form1();
            hu.Show();
            this.Hide();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            
        }

        private void btnopen_Click_1(object sender, EventArgs e)
        {
            dataGridView();
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtnoresi.Text = "";
            txtbrg.Text = "";
            txtharga.Text = "";
            datetime.Value = DateTime.Now;
            txtnoresi.Enabled = true;
            cbxidpengirim.Enabled = true;
            cbxnama.Enabled = true;
            txtbrg.Enabled = true;
            txtharga.Enabled = true;
            datetime.Enabled = true;
            idpengirimtxt();
            nmbarangtxt();
            btnclear.Enabled = true;
            btnsave.Enabled = true;
        }

        private void cbxidpengirim_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            no = txtnoresi.Text;
            id = cbxidpengirim.Text;
            nm = cbxnama.Text;
            berat = txtbrg.Text;
            harga = txtharga.Text;
            tgl = datetime.Value;

            koneksi.Open();
            string strs = "select id_pengirim from dbo.pengirim where id_pengirim = @idp";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@idp", id));

            string str = "insert into dbo.resi(no_resi, id_pengirim, nm_barang, berat_brg, harga_pengiriman, tgl_pengiriman)" +
                "values (@no, @idp, @nm, @berat, @harga, @tgl)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@no", no);
            cmd.Parameters.AddWithValue("@idp", id);
            cmd.Parameters.AddWithValue("@nm", nm);
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
