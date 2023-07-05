
namespace PengirimanBarang
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.datapengirim = new System.Windows.Forms.ToolStripMenuItem();
            this.datakaryawan = new System.Windows.Forms.ToolStripMenuItem();
            this.databarang = new System.Windows.Forms.ToolStripMenuItem();
            this.datapenerima = new System.Windows.Forms.ToolStripMenuItem();
            this.datakurir = new System.Windows.Forms.ToolStripMenuItem();
            this.dataresi = new System.Windows.Forms.ToolStripMenuItem();
            this.datapengiriman = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.datapengantaran = new System.Windows.Forms.ToolStripMenuItem();
            this.datadetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 50);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datapengirim,
            this.databarang,
            this.datakaryawan,
            this.datakurir,
            this.datapenerima});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(192, 45);
            this.toolStripDropDownButton1.Text = "Data Utama";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // datapengirim
            // 
            this.datapengirim.Name = "datapengirim";
            this.datapengirim.Size = new System.Drawing.Size(321, 50);
            this.datapengirim.Text = "Data Pengirim";
            // 
            // datakaryawan
            // 
            this.datakaryawan.Name = "datakaryawan";
            this.datakaryawan.Size = new System.Drawing.Size(321, 50);
            this.datakaryawan.Text = "Data Karyawan";
            // 
            // databarang
            // 
            this.databarang.Name = "databarang";
            this.databarang.Size = new System.Drawing.Size(321, 50);
            this.databarang.Text = "Data Barang";
            // 
            // datapenerima
            // 
            this.datapenerima.Name = "datapenerima";
            this.datapenerima.Size = new System.Drawing.Size(321, 50);
            this.datapenerima.Text = "Data Penerima";
            // 
            // datakurir
            // 
            this.datakurir.Name = "datakurir";
            this.datakurir.Size = new System.Drawing.Size(321, 50);
            this.datakurir.Text = "Data Kurir";
            // 
            // dataresi
            // 
            this.dataresi.Name = "dataresi";
            this.dataresi.Size = new System.Drawing.Size(402, 50);
            this.dataresi.Text = "Data Resi";
            // 
            // datapengiriman
            // 
            this.datapengiriman.Name = "datapengiriman";
            this.datapengiriman.Size = new System.Drawing.Size(402, 50);
            this.datapengiriman.Text = "Data Pengiriman";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataresi,
            this.datapengiriman,
            this.datapengantaran,
            this.datadetail});
            this.toolStripDropDownButton2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(254, 45);
            this.toolStripDropDownButton2.Text = "Data Pengiriman";
            // 
            // datapengantaran
            // 
            this.datapengantaran.Name = "datapengantaran";
            this.datapengantaran.Size = new System.Drawing.Size(402, 50);
            this.datapengantaran.Text = "Data Pengantaran";
            // 
            // datadetail
            // 
            this.datadetail.Name = "datadetail";
            this.datadetail.Size = new System.Drawing.Size(402, 50);
            this.datadetail.Text = "Data Detail Penerima";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem datapengirim;
        private System.Windows.Forms.ToolStripMenuItem databarang;
        private System.Windows.Forms.ToolStripMenuItem datakaryawan;
        private System.Windows.Forms.ToolStripMenuItem datakurir;
        private System.Windows.Forms.ToolStripMenuItem datapenerima;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem dataresi;
        private System.Windows.Forms.ToolStripMenuItem datapengiriman;
        private System.Windows.Forms.ToolStripMenuItem datapengantaran;
        private System.Windows.Forms.ToolStripMenuItem datadetail;
    }
}

