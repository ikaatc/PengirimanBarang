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
    public partial class barang : Form
    {
        private string stringConnection = "data source=DESKTOP-9NQGA7N\\IKATC;" + "database=PengirimanBarang; User ID = sa; Password = 1234";
        private SqlConnection koneksi;

        private string nama, jenis, kategori, idpeng, idkar;
        BindingSource customersBindingSource = new BindingSource();
        public barang()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 hu = new Form1();
            hu.Show();
            this.Hide();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnopen.Enabled = false;
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
            txtidpengirim.ValueMember = "id_pengirim";
            txtidpengirim.DataSource = ds.Tables[0];
        }

        private void idkaryawantxt()
        {
            koneksi.Open();
            string str = "select id_karyawan from dbo.karyawan";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            txtidkaryawan.ValueMember = "id_karyawan";
            txtidkaryawan.DataSource = ds.Tables[0];
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtidpengirim.Text = "";
            txtnmbarang.Text = "";
            txtjnsbarang.Text = "";
            txtktgrbarang.Text = "";
            txtidkaryawan.Text = "";
            txtidpengirim.Enabled = true;
            txtnmbarang.Enabled = true;
            txtjnsbarang.Enabled = true;
            txtktgrbarang.Enabled = true;
            txtidkaryawan.Enabled = true;
            idpengirimtxt();
            idkaryawantxt();
            btnsave.Enabled = true;
            btnclear.Enabled = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            nama = txtnmbarang.Text;
            jenis = txtjnsbarang.Text;
            kategori = txtktgrbarang.Text;
            idpeng = txtidpengirim.SelectedValue.ToString();
            idkar = txtidkaryawan.SelectedValue.ToString();

            koneksi.Open();
            string strs = "select id_pengirim from dbo.pengirim where id_pengirim = @idp, select id_karyawan from dbo.karyawan where id_karyawan = @idk";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@idp", idpeng));
            cm.Parameters.Add(new SqlParameter("@idk", idkar));

            string str = "insert into dbo.barang(id_pengirim, id_karyawan, nm_barang, jns_barang, kategori_barang)" +
                    "values (@idp, @idk, @nama, @jenis, @kategori)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@jenis", jenis);
            cmd.Parameters.AddWithValue("@kategori", kategori);
            cmd.Parameters.AddWithValue("@idp", idpeng);
            cmd.Parameters.AddWithValue("@idk", idkar);
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

        private void txtidpengirim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_pengirim, id_karyawan, nm_barang, jns_barang, kategori_barang from dbo.barang";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void refreshform()
        {
            txtidpengirim.Text = "";
            txtidpengirim.Enabled = false;
            txtidkaryawan.Text = "";
            txtidkaryawan.Enabled = false;
            txtnmbarang.Text = "";
            txtnmbarang.Enabled = false;
            txtjnsbarang.Text = "";
            txtjnsbarang.Enabled = false;
            txtktgrbarang.Text = "";
            txtktgrbarang.Enabled = false;
            btnsave.Enabled = false;
            btnclear.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void barang_Load(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("SELECT m.nm_barang, m.jns_barang, " +
                "m.kategori_barang, p.id_pengirim, k.id_karyawan FROM dbo.barang m " +
                "JOIN dbo.pengirim p ON m.id_pengirim = p.id_pengirim " +
                "JOIN dbo.karyawan k ON m.id_karyawan = k.id_karyawan", koneksi));

            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customersBindingSource.DataSource = ds.Tables[0];
            this.txtidpengirim.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "id_pengirim", true));
            this.txtidkaryawan.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "id_karyawan", true));
            this.txtnmbarang.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "nm_barang", true));
            this.txtjnsbarang.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "jns_barang", true));
            this.txtktgrbarang.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "kategori_barang", true));
            koneksi.Close();
            refreshform();
        }
    }
}
