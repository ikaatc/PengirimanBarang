
namespace PengirimanBarang
{
    partial class pengirim
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
            this.datapengirim = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.idpengirim = new System.Windows.Forms.Label();
            this.nmpengirim = new System.Windows.Forms.Label();
            this.nopengirim = new System.Windows.Forms.Label();
            this.txtpengirim = new System.Windows.Forms.TextBox();
            this.txtnmpengirim = new System.Windows.Forms.TextBox();
            this.txtnopengirim = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datapengirim
            // 
            this.datapengirim.AutoSize = true;
            this.datapengirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datapengirim.Location = new System.Drawing.Point(285, 52);
            this.datapengirim.Name = "datapengirim";
            this.datapengirim.Size = new System.Drawing.Size(201, 36);
            this.datapengirim.TabIndex = 0;
            this.datapengirim.Text = "Data Pengirim";
            this.datapengirim.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.idpengirim, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nopengirim, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.nmpengirim, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtpengirim, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtnmpengirim, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtnopengirim, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(103, 108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 222);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // idpengirim
            // 
            this.idpengirim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.idpengirim.AutoSize = true;
            this.idpengirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idpengirim.Location = new System.Drawing.Point(3, 24);
            this.idpengirim.Name = "idpengirim";
            this.idpengirim.Size = new System.Drawing.Size(274, 26);
            this.idpengirim.TabIndex = 0;
            this.idpengirim.Text = "ID Pengirim";
            this.idpengirim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nmpengirim
            // 
            this.nmpengirim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nmpengirim.AutoSize = true;
            this.nmpengirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmpengirim.Location = new System.Drawing.Point(3, 98);
            this.nmpengirim.Name = "nmpengirim";
            this.nmpengirim.Size = new System.Drawing.Size(274, 26);
            this.nmpengirim.TabIndex = 1;
            this.nmpengirim.Text = "Nama Pengirim";
            this.nmpengirim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nopengirim
            // 
            this.nopengirim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nopengirim.AutoSize = true;
            this.nopengirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nopengirim.Location = new System.Drawing.Point(3, 172);
            this.nopengirim.Name = "nopengirim";
            this.nopengirim.Size = new System.Drawing.Size(274, 26);
            this.nopengirim.TabIndex = 2;
            this.nopengirim.Text = "No Telepon Pengirim";
            this.nopengirim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nopengirim.Click += new System.EventHandler(this.notelppengirim_Click);
            // 
            // txtpengirim
            // 
            this.txtpengirim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpengirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpengirim.Location = new System.Drawing.Point(283, 19);
            this.txtpengirim.Name = "txtpengirim";
            this.txtpengirim.Size = new System.Drawing.Size(274, 35);
            this.txtpengirim.TabIndex = 3;
            // 
            // txtnmpengirim
            // 
            this.txtnmpengirim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnmpengirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnmpengirim.Location = new System.Drawing.Point(283, 93);
            this.txtnmpengirim.Name = "txtnmpengirim";
            this.txtnmpengirim.Size = new System.Drawing.Size(274, 35);
            this.txtnmpengirim.TabIndex = 4;
            // 
            // txtnopengirim
            // 
            this.txtnopengirim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnopengirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnopengirim.Location = new System.Drawing.Point(283, 167);
            this.txtnopengirim.Name = "txtnopengirim";
            this.txtnopengirim.Size = new System.Drawing.Size(274, 35);
            this.txtnopengirim.TabIndex = 5;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(116, 364);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(118, 43);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(330, 364);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(118, 43);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(531, 364);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(118, 43);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(12, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(118, 43);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            // 
            // pengirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.datapengirim);
            this.Name = "pengirim";
            this.Text = "pengirim";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label datapengirim;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label idpengirim;
        private System.Windows.Forms.Label nopengirim;
        private System.Windows.Forms.Label nmpengirim;
        private System.Windows.Forms.TextBox txtpengirim;
        private System.Windows.Forms.TextBox txtnmpengirim;
        private System.Windows.Forms.TextBox txtnopengirim;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnback;
    }
}