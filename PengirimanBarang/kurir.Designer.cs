namespace PengirimanBarang
{
    partial class kurir
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
            this.almtkurir = new System.Windows.Forms.Label();
            this.idkurir = new System.Windows.Forms.Label();
            this.nmkurir = new System.Windows.Forms.Label();
            this.txtkurir = new System.Windows.Forms.TextBox();
            this.txtnmkurir = new System.Windows.Forms.TextBox();
            this.txtalmtkurir = new System.Windows.Forms.TextBox();
            this.txtnokurir = new System.Windows.Forms.TextBox();
            this.nokurir = new System.Windows.Forms.Label();
            this.datakurir = new System.Windows.Forms.Label();
            this.btnopen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(135, 80);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(743, 219);
            this.dataGridView1.TabIndex = 30;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(16, 15);
            this.btnback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(112, 41);
            this.btnback.TabIndex = 29;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(736, 506);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(112, 41);
            this.btnclear.TabIndex = 28;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(468, 506);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(112, 41);
            this.btnsave.TabIndex = 27;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(183, 506);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(112, 41);
            this.btnadd.TabIndex = 26;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.almtkurir, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.idkurir, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nmkurir, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtkurir, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtnmkurir, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtalmtkurir, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtnokurir, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.nokurir, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(135, 320);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.53764F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.46236F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(747, 179);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // almtkurir
            // 
            this.almtkurir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.almtkurir.AutoSize = true;
            this.almtkurir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.almtkurir.Location = new System.Drawing.Point(4, 99);
            this.almtkurir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.almtkurir.Name = "almtkurir";
            this.almtkurir.Size = new System.Drawing.Size(365, 25);
            this.almtkurir.TabIndex = 7;
            this.almtkurir.Text = "Alamat";
            this.almtkurir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idkurir
            // 
            this.idkurir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.idkurir.AutoSize = true;
            this.idkurir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idkurir.Location = new System.Drawing.Point(4, 9);
            this.idkurir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idkurir.Name = "idkurir";
            this.idkurir.Size = new System.Drawing.Size(365, 25);
            this.idkurir.TabIndex = 0;
            this.idkurir.Text = "ID Kurir";
            this.idkurir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nmkurir
            // 
            this.nmkurir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nmkurir.AutoSize = true;
            this.nmkurir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmkurir.Location = new System.Drawing.Point(4, 53);
            this.nmkurir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nmkurir.Name = "nmkurir";
            this.nmkurir.Size = new System.Drawing.Size(365, 25);
            this.nmkurir.TabIndex = 1;
            this.nmkurir.Text = "Nama";
            this.nmkurir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtkurir
            // 
            this.txtkurir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtkurir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkurir.Location = new System.Drawing.Point(377, 7);
            this.txtkurir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtkurir.Name = "txtkurir";
            this.txtkurir.Size = new System.Drawing.Size(366, 30);
            this.txtkurir.TabIndex = 3;
            // 
            // txtnmkurir
            // 
            this.txtnmkurir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnmkurir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnmkurir.Location = new System.Drawing.Point(377, 50);
            this.txtnmkurir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnmkurir.Name = "txtnmkurir";
            this.txtnmkurir.Size = new System.Drawing.Size(366, 30);
            this.txtnmkurir.TabIndex = 4;
            // 
            // txtalmtkurir
            // 
            this.txtalmtkurir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtalmtkurir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtalmtkurir.Location = new System.Drawing.Point(377, 96);
            this.txtalmtkurir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtalmtkurir.Name = "txtalmtkurir";
            this.txtalmtkurir.Size = new System.Drawing.Size(366, 30);
            this.txtalmtkurir.TabIndex = 5;
            // 
            // txtnokurir
            // 
            this.txtnokurir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnokurir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnokurir.Location = new System.Drawing.Point(377, 142);
            this.txtnokurir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnokurir.Name = "txtnokurir";
            this.txtnokurir.Size = new System.Drawing.Size(366, 30);
            this.txtnokurir.TabIndex = 6;
            // 
            // nokurir
            // 
            this.nokurir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nokurir.AutoSize = true;
            this.nokurir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nokurir.Location = new System.Drawing.Point(4, 145);
            this.nokurir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nokurir.Name = "nokurir";
            this.nokurir.Size = new System.Drawing.Size(365, 25);
            this.nokurir.TabIndex = 2;
            this.nokurir.Text = "No Telepon";
            this.nokurir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datakurir
            // 
            this.datakurir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.datakurir.AutoSize = true;
            this.datakurir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datakurir.Location = new System.Drawing.Point(404, 29);
            this.datakurir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datakurir.Name = "datakurir";
            this.datakurir.Size = new System.Drawing.Size(139, 30);
            this.datakurir.TabIndex = 24;
            this.datakurir.Text = "Data Kurir";
            this.datakurir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnopen
            // 
            this.btnopen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnopen.Location = new System.Drawing.Point(919, 102);
            this.btnopen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(112, 41);
            this.btnopen.TabIndex = 31;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // kurir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.datakurir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "kurir";
            this.Text = "kurir";
            this.Load += new System.EventHandler(this.kurir_Load);
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
        private System.Windows.Forms.Label almtkurir;
        private System.Windows.Forms.Label idkurir;
        private System.Windows.Forms.Label nmkurir;
        private System.Windows.Forms.TextBox txtkurir;
        private System.Windows.Forms.TextBox txtnmkurir;
        private System.Windows.Forms.TextBox txtalmtkurir;
        private System.Windows.Forms.TextBox txtnokurir;
        private System.Windows.Forms.Label nokurir;
        private System.Windows.Forms.Label datakurir;
        private System.Windows.Forms.Button btnopen;
    }
}