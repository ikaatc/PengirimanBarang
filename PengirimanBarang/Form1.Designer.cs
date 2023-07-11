
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
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dataresi = new System.Windows.Forms.ToolStripMenuItem();
            this.datapengiriman = new System.Windows.Forms.ToolStripMenuItem();
            this.datapengantaran = new System.Windows.Forms.ToolStripMenuItem();
            this.datadetail = new System.Windows.Forms.ToolStripMenuItem();
            this.btnpeng = new System.Windows.Forms.Button();
            this.btnb = new System.Windows.Forms.Button();
            this.btnka = new System.Windows.Forms.Button();
            this.btnku = new System.Windows.Forms.Button();
            this.btnpen = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.PeachPuff;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1067, 50);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            this.toolStripDropDownButton2.Click += new System.EventHandler(this.toolStripDropDownButton2_Click);
            // 
            // dataresi
            // 
            this.dataresi.BackColor = System.Drawing.Color.MistyRose;
            this.dataresi.Name = "dataresi";
            this.dataresi.Size = new System.Drawing.Size(402, 50);
            this.dataresi.Text = "Data Resi";
            this.dataresi.Click += new System.EventHandler(this.dataresi_Click);
            // 
            // datapengiriman
            // 
            this.datapengiriman.BackColor = System.Drawing.Color.MistyRose;
            this.datapengiriman.Name = "datapengiriman";
            this.datapengiriman.Size = new System.Drawing.Size(402, 50);
            this.datapengiriman.Text = "Data Pengiriman";
            this.datapengiriman.Click += new System.EventHandler(this.datapengiriman_Click);
            // 
            // datapengantaran
            // 
            this.datapengantaran.BackColor = System.Drawing.Color.MistyRose;
            this.datapengantaran.Name = "datapengantaran";
            this.datapengantaran.Size = new System.Drawing.Size(402, 50);
            this.datapengantaran.Text = "Data Pengantaran";
            this.datapengantaran.Click += new System.EventHandler(this.datapengantaran_Click);
            // 
            // datadetail
            // 
            this.datadetail.BackColor = System.Drawing.Color.MistyRose;
            this.datadetail.Name = "datadetail";
            this.datadetail.Size = new System.Drawing.Size(402, 50);
            this.datadetail.Text = "Data Detail Penerima";
            this.datadetail.Click += new System.EventHandler(this.datadetail_Click);
            // 
            // btnpeng
            // 
            this.btnpeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpeng.Location = new System.Drawing.Point(160, 228);
            this.btnpeng.Name = "btnpeng";
            this.btnpeng.Size = new System.Drawing.Size(172, 78);
            this.btnpeng.TabIndex = 1;
            this.btnpeng.Text = "Pengirim";
            this.btnpeng.UseVisualStyleBackColor = true;
            this.btnpeng.Click += new System.EventHandler(this.btnpeng_Click);
            // 
            // btnb
            // 
            this.btnb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnb.Location = new System.Drawing.Point(452, 228);
            this.btnb.Name = "btnb";
            this.btnb.Size = new System.Drawing.Size(172, 78);
            this.btnb.TabIndex = 2;
            this.btnb.Text = "Barang";
            this.btnb.UseVisualStyleBackColor = true;
            this.btnb.Click += new System.EventHandler(this.btnb_Click);
            // 
            // btnka
            // 
            this.btnka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnka.Location = new System.Drawing.Point(298, 384);
            this.btnka.Name = "btnka";
            this.btnka.Size = new System.Drawing.Size(172, 78);
            this.btnka.TabIndex = 3;
            this.btnka.Text = "Karyawan";
            this.btnka.UseVisualStyleBackColor = true;
            this.btnka.Click += new System.EventHandler(this.btnka_Click);
            // 
            // btnku
            // 
            this.btnku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnku.Location = new System.Drawing.Point(586, 384);
            this.btnku.Name = "btnku";
            this.btnku.Size = new System.Drawing.Size(172, 78);
            this.btnku.TabIndex = 4;
            this.btnku.Text = "Kurir";
            this.btnku.UseVisualStyleBackColor = true;
            this.btnku.Click += new System.EventHandler(this.btnku_Click);
            // 
            // btnpen
            // 
            this.btnpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpen.Location = new System.Drawing.Point(715, 228);
            this.btnpen.Name = "btnpen";
            this.btnpen.Size = new System.Drawing.Size(172, 78);
            this.btnpen.TabIndex = 5;
            this.btnpen.Text = "Penerima";
            this.btnpen.UseVisualStyleBackColor = true;
            this.btnpen.Click += new System.EventHandler(this.btnpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PengirimanBarang.Properties.Resources.Infamuse__1_;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btnpen);
            this.Controls.Add(this.btnku);
            this.Controls.Add(this.btnka);
            this.Controls.Add(this.btnb);
            this.Controls.Add(this.btnpeng);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem dataresi;
        private System.Windows.Forms.ToolStripMenuItem datapengiriman;
        private System.Windows.Forms.ToolStripMenuItem datapengantaran;
        private System.Windows.Forms.ToolStripMenuItem datadetail;
        private System.Windows.Forms.Button btnpeng;
        private System.Windows.Forms.Button btnb;
        private System.Windows.Forms.Button btnka;
        private System.Windows.Forms.Button btnku;
        private System.Windows.Forms.Button btnpen;
    }
}

