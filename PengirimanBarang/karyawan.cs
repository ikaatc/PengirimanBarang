using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PengirimanBarang
{
    public partial class karyawan : Form
    {
        public karyawan()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtkaryawan.Enabled = true;
            txtnmkaryawan.Enabled = true;
            txtnokaryawan.Enabled = true;
            btnsave.Enabled = true;
            btnclear.Enabled = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string idkaryawan = txtkaryawan.Text;
            string nmkaryawan = txtnmkaryawan.Text;
            string nokaryawan = txtnokaryawan.Text;

            if (idkaryawan == "")
            {
                MessageBox.Show("Masukkan ID Karyawan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (nmkaryawan == "")
            {
                MessageBox.Show("Masukkan Nama Karyawan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (nokaryawan == "")
            {
                MessageBox.Show("Masukkan No Telpon Karyawan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
