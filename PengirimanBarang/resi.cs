﻿using System;
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

        BindingSource customersBindingSource = new BindingSource();
        public resi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            this.bindingNavigator1.BindingSource = this.customersBindingSource;
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select no_resi, id_pengirim, nm_barang, tgl_pengiriman, berat_brg, harga_pengiriman from dbo.resi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            koneksi.Close();
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
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("select m.no_resi, p.id_pengirim, k.nm_barang, m.berat_brg," +
                "m.harga_pengiriman, m.tgl_pengiriman from dbo.resi m" +
                "join dbo.pengirim p on m.id_pengirim = p.id_pengirim" +
                "join dbo.barang k on m.nm_barang = k.nm_barang", koneksi));
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

        private void resi_Load(object sender, EventArgs e)
        {

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

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 hu = new Form1();
            hu.Show();
            this.Hide();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtnoresi.Enabled = true;
            cbxidpengirim.Enabled = true;
            txtbrg.Enabled = true;
            txtharga.Enabled = true;
            datetime.Enabled = true;
            idpengirimtxt();
            btnclear.Enabled = true;
            btnsave.Enabled = true;

        }

        private void cbxidpengirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            koneksi.Open();
            string nm = "";
            string strs = "select nm_barang from dbo.barang where id_pengirim = @idp";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@idp", cbxidpengirim.Text));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                nm = dr["nm_barang"].ToString();
            }
            dr.Close();
            koneksi.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            refreshform();
        }
    }
}
