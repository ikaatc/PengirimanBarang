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
            this.bindingNavigator1.BindingSource = this.customersBindingSource;
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
            formresi_load();
            clearBinding();
        }

        private void formresi_load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("select m.no_resi, p.id_pengirim, k.nm_barang, m.berat_brg, " +
                "m.harga_pengiriman, m.tgl_pengiriman from dbo.resi m " +
                "join dbo.pengirim p on m.id_pengirim = p.id_pengirim " +
                "join dbo.barang k on m.id_barang = k.id_barang", koneksi));

            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customersBindingSource.DataSource = ds.Tables[0];
            this.txtnoresi.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "no_resi", true));
            this.cbxidpengirim.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "id_pengirim", true));
            this.cbxnama.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "nm_barang", true));
            this.txtbrg.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "berat_brg", true));
            this.txtharga.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "harga_pengiriman", true));
            this.datetime.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "tgl_pengiriman", true));
            koneksi.Close();

            this.bindingNavigator1.BindingSource = this.customersBindingSource;
        }

        private void clearBinding()
        {
            this.txtnoresi.DataBindings.Clear();
            this.cbxidpengirim.DataBindings.Clear();
            this.cbxnama.DataBindings.Clear();
            this.txtbrg.DataBindings.Clear();
            this.txtharga.DataBindings.Clear();
            this.datetime.DataBindings.Clear();
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
            nm = cbxnama.SelectedValue.ToString();
            berat = txtbrg.Text;
            harga = txtharga.Text;
            tgl = datetime.Value;

            koneksi.Open();
            string strs = "select id_pengirim, id_barang from dbo.pengirim, dbo.barang " +
              "where id_pengirim = @idp and nm_barang = @nmb";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@idp", id));
            cm.Parameters.Add(new SqlParameter("@nmb", nm));
            SqlDataReader dr = cm.ExecuteReader();
            dr.Close();
            string str = "insert into dbo.resi (no_resi, id_pengirim, id_barang, tgl_pengiriman, berat_brg, harga_pengiriman) " +
             "values (@no, @id, @nm, @tgl, @berat, @harga)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@no", no));
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.Parameters.Add(new SqlParameter("@nm", nm));
            cmd.Parameters.Add(new SqlParameter("@berat", berat));
            cmd.Parameters.Add(new SqlParameter("@harga", harga));
            cmd.Parameters.Add(new SqlParameter("@tgl", tgl));
            cmd.ExecuteNonQuery();
            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            refreshform();
        }
    }
}
