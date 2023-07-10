
namespace PengirimanBarang
{
    partial class barang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnback = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidpengirim = new System.Windows.Forms.ComboBox();
            this.jnsbarang = new System.Windows.Forms.Label();
            this.idpengirim = new System.Windows.Forms.Label();
            this.nmbarang = new System.Windows.Forms.Label();
            this.txtnmbarang = new System.Windows.Forms.TextBox();
            this.ktgrbarang = new System.Windows.Forms.Label();
            this.txtjnsbarang = new System.Windows.Forms.TextBox();
            this.txtktgrbarang = new System.Windows.Forms.ComboBox();
            this.txtidkaryawan = new System.Windows.Forms.ComboBox();
            this.databarang = new System.Windows.Forms.Label();
            this.btnopen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(135, 79);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(743, 174);
            this.dataGridView1.TabIndex = 37;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(16, 15);
            this.btnback.Margin = new System.Windows.Forms.Padding(4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(112, 41);
            this.btnback.TabIndex = 36;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(736, 506);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(112, 41);
            this.btnclear.TabIndex = 35;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(468, 506);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(112, 41);
            this.btnsave.TabIndex = 34;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(183, 506);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(112, 41);
            this.btnadd.TabIndex = 33;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtidpengirim, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.jnsbarang, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.idpengirim, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nmbarang, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtnmbarang, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ktgrbarang, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtjnsbarang, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtktgrbarang, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtidkaryawan, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(135, 273);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.68539F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.31461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(747, 226);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "ID Karyawan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtidpengirim
            // 
            this.txtidpengirim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtidpengirim.FormattingEnabled = true;
            this.txtidpengirim.Location = new System.Drawing.Point(376, 6);
            this.txtidpengirim.Name = "txtidpengirim";
            this.txtidpengirim.Size = new System.Drawing.Size(368, 33);
            this.txtidpengirim.TabIndex = 39;
            // 
            // jnsbarang
            // 
            this.jnsbarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.jnsbarang.AutoSize = true;
            this.jnsbarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jnsbarang.Location = new System.Drawing.Point(4, 98);
            this.jnsbarang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jnsbarang.Name = "jnsbarang";
            this.jnsbarang.Size = new System.Drawing.Size(365, 25);
            this.jnsbarang.TabIndex = 7;
            this.jnsbarang.Text = "Jenis Barang";
            this.jnsbarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idpengirim
            // 
            this.idpengirim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.idpengirim.AutoSize = true;
            this.idpengirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idpengirim.Location = new System.Drawing.Point(4, 10);
            this.idpengirim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idpengirim.Name = "idpengirim";
            this.idpengirim.Size = new System.Drawing.Size(365, 25);
            this.idpengirim.TabIndex = 0;
            this.idpengirim.Text = "ID Pengirim";
            this.idpengirim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nmbarang
            // 
            this.nmbarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nmbarang.AutoSize = true;
            this.nmbarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbarang.Location = new System.Drawing.Point(4, 55);
            this.nmbarang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nmbarang.Name = "nmbarang";
            this.nmbarang.Size = new System.Drawing.Size(365, 25);
            this.nmbarang.TabIndex = 1;
            this.nmbarang.Text = "Nama Barang";
            this.nmbarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtnmbarang
            // 
            this.txtnmbarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnmbarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnmbarang.Location = new System.Drawing.Point(377, 52);
            this.txtnmbarang.Margin = new System.Windows.Forms.Padding(4);
            this.txtnmbarang.Name = "txtnmbarang";
            this.txtnmbarang.Size = new System.Drawing.Size(366, 30);
            this.txtnmbarang.TabIndex = 4;
            // 
            // ktgrbarang
            // 
            this.ktgrbarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ktgrbarang.AutoSize = true;
            this.ktgrbarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktgrbarang.Location = new System.Drawing.Point(4, 144);
            this.ktgrbarang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ktgrbarang.Name = "ktgrbarang";
            this.ktgrbarang.Size = new System.Drawing.Size(365, 25);
            this.ktgrbarang.TabIndex = 2;
            this.ktgrbarang.Text = "Kategori Barang";
            this.ktgrbarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtjnsbarang
            // 
            this.txtjnsbarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtjnsbarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjnsbarang.Location = new System.Drawing.Point(377, 96);
            this.txtjnsbarang.Margin = new System.Windows.Forms.Padding(4);
            this.txtjnsbarang.Name = "txtjnsbarang";
            this.txtjnsbarang.Size = new System.Drawing.Size(366, 30);
            this.txtjnsbarang.TabIndex = 6;
            // 
            // txtktgrbarang
            // 
            this.txtktgrbarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtktgrbarang.FormattingEnabled = true;
            this.txtktgrbarang.Items.AddRange(new object[] {
            "Elektronik",
            "Pakaian dan Aksesoris",
            "Makanan dan Minuman",
            "Perlengkapan Rumah Tangga",
            "Kesehatan dan Kecantikan",
            "Olahraga dan Rekreasi",
            "Perawatan Hewan"});
            this.txtktgrbarang.Location = new System.Drawing.Point(376, 140);
            this.txtktgrbarang.Name = "txtktgrbarang";
            this.txtktgrbarang.Size = new System.Drawing.Size(368, 33);
            this.txtktgrbarang.TabIndex = 38;
            // 
            // txtidkaryawan
            // 
            this.txtidkaryawan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtidkaryawan.FormattingEnabled = true;
            this.txtidkaryawan.Items.AddRange(new object[] {
            "Elektronik",
            "Pakaian dan Aksesoris",
            "Makanan dan Minuman",
            "Perlengkapan Rumah Tangga",
            "Kesehatan dan Kecantikan",
            "Olahraga dan Rekreasi",
            "Perawatan Hewan"});
            this.txtidkaryawan.Location = new System.Drawing.Point(376, 187);
            this.txtidkaryawan.Name = "txtidkaryawan";
            this.txtidkaryawan.Size = new System.Drawing.Size(368, 33);
            this.txtidkaryawan.TabIndex = 41;
            // 
            // databarang
            // 
            this.databarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.databarang.AutoSize = true;
            this.databarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databarang.Location = new System.Drawing.Point(405, 28);
            this.databarang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.databarang.Name = "databarang";
            this.databarang.Size = new System.Drawing.Size(167, 30);
            this.databarang.TabIndex = 31;
            this.databarang.Text = "Data Barang";
            this.databarang.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnopen
            // 
            this.btnopen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnopen.Location = new System.Drawing.Point(919, 102);
            this.btnopen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(112, 41);
            this.btnopen.TabIndex = 38;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            // 
            // barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.databarang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "barang";
            this.Text = "barang";
            this.Load += new System.EventHandler(this.barang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label jnsbarang;
        private System.Windows.Forms.Label idpengirim;
        private System.Windows.Forms.Label nmbarang;
        private System.Windows.Forms.TextBox txtnmbarang;
        private System.Windows.Forms.TextBox txtjnsbarang;
        private System.Windows.Forms.Label ktgrbarang;
        private System.Windows.Forms.Label databarang;
        private System.Windows.Forms.ComboBox txtidpengirim;
        private System.Windows.Forms.ComboBox txtktgrbarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtidkaryawan;
        private System.Windows.Forms.Button btnopen;
    }
}