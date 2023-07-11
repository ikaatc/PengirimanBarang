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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void dataPengirimToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void datapengirim_Click(object sender, EventArgs e)
        {
            pengirim peng = new pengirim();
            peng.Show();
            this.Hide();
        }

        private void dataresi_Click(object sender, EventArgs e)
        {
            resi re = new resi();
            re.Show();
            this.Hide();
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void datapengiriman_Click(object sender, EventArgs e)
        {
            pengiriman pe = new pengiriman();
            pe.Show();
            this.Hide();
        }

        private void datapengantaran_Click(object sender, EventArgs e)
        {
            Pengantaran penga = new Pengantaran();
            penga.Show();
            this.Hide();
        }

        private void datadetail_Click(object sender, EventArgs e)
        {
            detail_penerima det = new detail_penerima();
            det.Show();
            this.Hide();
        }

        private void btnpeng_Click(object sender, EventArgs e)
        {
            pengirim peng = new pengirim();
            peng.Show();
            this.Hide();
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            barang bar = new barang();
            bar.Show();
            this.Hide();
        }

        private void btnpen_Click(object sender, EventArgs e)
        {
            penerima pen = new penerima();
            pen.Show();
            this.Hide();
        }

        private void btnka_Click(object sender, EventArgs e)
        {
            karyawan kar = new karyawan();
            kar.Show();
            this.Hide();
        }

        private void btnku_Click(object sender, EventArgs e)
        {
            kurir kur = new kurir();
            kur.Show();
            this.Hide();
        }
    }
}
