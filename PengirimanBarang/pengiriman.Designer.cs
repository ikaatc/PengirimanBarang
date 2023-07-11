namespace PengirimanBarang
{
    partial class pengiriman
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
            this.btndelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpengantaran = new System.Windows.Forms.DateTimePicker();
            this.cbxidpengirim = new System.Windows.Forms.ComboBox();
            this.cbxidpenerima = new System.Windows.Forms.ComboBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.datapengirim = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnopen = new System.Windows.Forms.Button();
            this.txtidpengiriman = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(1008, 166);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(126, 51);
            this.btndelete.TabIndex = 54;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpengantaran, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxidpengirim, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxidpenerima, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtidpengiriman, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(181, 300);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 259);
            this.tableLayoutPanel1.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID Pengiriman";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "ID Pengirim";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(392, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tanggal Pengantaran";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "ID Penerima";
            // 
            // dtpengantaran
            // 
            this.dtpengantaran.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpengantaran.Location = new System.Drawing.Point(401, 214);
            this.dtpengantaran.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpengantaran.Name = "dtpengantaran";
            this.dtpengantaran.Size = new System.Drawing.Size(392, 26);
            this.dtpengantaran.TabIndex = 39;
            // 
            // cbxidpengirim
            // 
            this.cbxidpengirim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxidpengirim.FormattingEnabled = true;
            this.cbxidpengirim.Location = new System.Drawing.Point(401, 88);
            this.cbxidpengirim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxidpengirim.Name = "cbxidpengirim";
            this.cbxidpengirim.Size = new System.Drawing.Size(392, 28);
            this.cbxidpengirim.TabIndex = 31;
            // 
            // cbxidpenerima
            // 
            this.cbxidpenerima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxidpenerima.FormattingEnabled = true;
            this.cbxidpenerima.Location = new System.Drawing.Point(401, 152);
            this.cbxidpenerima.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxidpenerima.Name = "cbxidpenerima";
            this.cbxidpenerima.Size = new System.Drawing.Size(392, 28);
            this.cbxidpenerima.TabIndex = 40;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(852, 625);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(126, 51);
            this.btnclear.TabIndex = 52;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(526, 625);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(126, 51);
            this.btnsave.TabIndex = 51;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(181, 625);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(126, 51);
            this.btnadd.TabIndex = 50;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // datapengirim
            // 
            this.datapengirim.AutoSize = true;
            this.datapengirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datapengirim.Location = new System.Drawing.Point(503, 51);
            this.datapengirim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datapengirim.Name = "datapengirim";
            this.datapengirim.Size = new System.Drawing.Size(153, 30);
            this.datapengirim.TabIndex = 48;
            this.datapengirim.Text = "Pengiriman";
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(25, 105);
            this.btnback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(126, 51);
            this.btnback.TabIndex = 47;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(181, 105);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(796, 188);
            this.dataGridView1.TabIndex = 55;
            // 
            // btnopen
            // 
            this.btnopen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnopen.Location = new System.Drawing.Point(1008, 92);
            this.btnopen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(112, 41);
            this.btnopen.TabIndex = 56;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            // 
            // txtidpengiriman
            // 
            this.txtidpengiriman.Location = new System.Drawing.Point(401, 3);
            this.txtidpengiriman.Name = "txtidpengiriman";
            this.txtidpengiriman.Size = new System.Drawing.Size(392, 26);
            this.txtidpengiriman.TabIndex = 41;
            // 
            // pengiriman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 702);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.datapengirim);
            this.Controls.Add(this.btnback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "pengiriman";
            this.Text = "pengiriman";
            this.Load += new System.EventHandler(this.pengiriman_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpengantaran;
        private System.Windows.Forms.ComboBox cbxidpengirim;
        private System.Windows.Forms.ComboBox cbxidpenerima;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label datapengirim;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.TextBox txtidpengiriman;
    }
}