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

        }
    }
}
