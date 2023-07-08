
namespace PengirimanBarang
{
    partial class karyawan
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
            this.idkaryawan = new System.Windows.Forms.Label();
            this.nokaryawan = new System.Windows.Forms.Label();
            this.nmkaryawan = new System.Windows.Forms.Label();
            this.txtkaryawan = new System.Windows.Forms.TextBox();
            this.txtnmkaryawan = new System.Windows.Forms.TextBox();
            this.txtnokaryawan = new System.Windows.Forms.TextBox();
            this.datakaryawan = new System.Windows.Forms.Label();
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
            this.dataGridView1.Size = new System.Drawing.Size(743, 219);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(16, 15);
            this.btnback.Margin = new System.Windows.Forms.Padding(4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(112, 41);
            this.btnback.TabIndex = 15;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(736, 506);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(112, 41);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(468, 506);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(112, 41);
            this.btnsave.TabIndex = 13;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(183, 506);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(112, 41);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.idkaryawan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nokaryawan, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.nmkaryawan, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtkaryawan, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtnmkaryawan, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtnokaryawan, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(135, 321);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.53764F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.46236F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(747, 178);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // idkaryawan
            // 
            this.idkaryawan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.idkaryawan.AutoSize = true;
            this.idkaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idkaryawan.Location = new System.Drawing.Point(4, 19);
            this.idkaryawan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idkaryawan.Name = "idkaryawan";
            this.idkaryawan.Size = new System.Drawing.Size(365, 20);
            this.idkaryawan.TabIndex = 0;
            this.idkaryawan.Text = "ID Karyawan";
            this.idkaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nokaryawan
            // 
            this.nokaryawan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nokaryawan.AutoSize = true;
            this.nokaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nokaryawan.Location = new System.Drawing.Point(4, 137);
            this.nokaryawan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nokaryawan.Name = "nokaryawan";
            this.nokaryawan.Size = new System.Drawing.Size(365, 20);
            this.nokaryawan.TabIndex = 2;
            this.nokaryawan.Text = "No Telepon";
            this.nokaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nmkaryawan
            // 
            this.nmkaryawan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nmkaryawan.AutoSize = true;
            this.nmkaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmkaryawan.Location = new System.Drawing.Point(4, 78);
            this.nmkaryawan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nmkaryawan.Name = "nmkaryawan";
            this.nmkaryawan.Size = new System.Drawing.Size(365, 20);
            this.nmkaryawan.TabIndex = 1;
            this.nmkaryawan.Text = "Nama";
            this.nmkaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtkaryawan
            // 
            this.txtkaryawan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtkaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkaryawan.Location = new System.Drawing.Point(377, 16);
            this.txtkaryawan.Margin = new System.Windows.Forms.Padding(4);
            this.txtkaryawan.Name = "txtkaryawan";
            this.txtkaryawan.Size = new System.Drawing.Size(366, 26);
            this.txtkaryawan.TabIndex = 3;
            // 
            // txtnmkaryawan
            // 
            this.txtnmkaryawan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnmkaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnmkaryawan.Location = new System.Drawing.Point(377, 75);
            this.txtnmkaryawan.Margin = new System.Windows.Forms.Padding(4);
            this.txtnmkaryawan.Name = "txtnmkaryawan";
            this.txtnmkaryawan.Size = new System.Drawing.Size(366, 26);
            this.txtnmkaryawan.TabIndex = 4;
            // 
            // txtnokaryawan
            // 
            this.txtnokaryawan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnokaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnokaryawan.Location = new System.Drawing.Point(377, 134);
            this.txtnokaryawan.Margin = new System.Windows.Forms.Padding(4);
            this.txtnokaryawan.Name = "txtnokaryawan";
            this.txtnokaryawan.Size = new System.Drawing.Size(366, 26);
            this.txtnokaryawan.TabIndex = 5;
            // 
            // datakaryawan
            // 
            this.datakaryawan.AutoSize = true;
            this.datakaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datakaryawan.Location = new System.Drawing.Point(405, 28);
            this.datakaryawan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datakaryawan.Name = "datakaryawan";
            this.datakaryawan.Size = new System.Drawing.Size(174, 26);
            this.datakaryawan.TabIndex = 10;
            this.datakaryawan.Text = "Data Karyawan";
            // 
            // btnopen
            // 
            this.btnopen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnopen.Location = new System.Drawing.Point(906, 100);
            this.btnopen.Margin = new System.Windows.Forms.Padding(4);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(112, 41);
            this.btnopen.TabIndex = 17;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            // 
            // karyawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.datakaryawan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "karyawan";
            this.Text = "karyawan";
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
        private System.Windows.Forms.Label idkaryawan;
        private System.Windows.Forms.Label nokaryawan;
        private System.Windows.Forms.Label nmkaryawan;
        private System.Windows.Forms.TextBox txtkaryawan;
        private System.Windows.Forms.TextBox txtnmkaryawan;
        private System.Windows.Forms.TextBox txtnokaryawan;
        private System.Windows.Forms.Label datakaryawan;
        private System.Windows.Forms.Button btnopen;
    }
}