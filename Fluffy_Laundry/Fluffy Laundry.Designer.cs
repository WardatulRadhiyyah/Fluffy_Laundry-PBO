
namespace Fluffy_Laundry
{
    partial class Data_Pemesanan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbhargatotal = new System.Windows.Forms.TextBox();
            this.tbharga = new System.Windows.Forms.TextBox();
            this.tbjenispaket = new System.Windows.Forms.ComboBox();
            this.tbberat = new System.Windows.Forms.TextBox();
            this.tbnohp = new System.Windows.Forms.TextBox();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.Judul = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nomor Hp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.tbhargatotal);
            this.groupBox1.Controls.Add(this.tbharga);
            this.groupBox1.Controls.Add(this.tbjenispaket);
            this.groupBox1.Controls.Add(this.tbberat);
            this.groupBox1.Controls.Add(this.tbnohp);
            this.groupBox1.Controls.Add(this.tbnama);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 466);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Pemesanan";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(236, 372);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tanggal Pengambilan";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(236, 418);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // tbhargatotal
            // 
            this.tbhargatotal.Location = new System.Drawing.Point(236, 321);
            this.tbhargatotal.Name = "tbhargatotal";
            this.tbhargatotal.Size = new System.Drawing.Size(206, 26);
            this.tbhargatotal.TabIndex = 12;
            // 
            // tbharga
            // 
            this.tbharga.Location = new System.Drawing.Point(236, 263);
            this.tbharga.Name = "tbharga";
            this.tbharga.Size = new System.Drawing.Size(206, 26);
            this.tbharga.TabIndex = 11;
            // 
            // tbjenispaket
            // 
            this.tbjenispaket.FormattingEnabled = true;
            this.tbjenispaket.Items.AddRange(new object[] {
            "Paket A",
            "Paket B",
            "Paket C"});
            this.tbjenispaket.Location = new System.Drawing.Point(236, 211);
            this.tbjenispaket.Name = "tbjenispaket";
            this.tbjenispaket.Size = new System.Drawing.Size(206, 28);
            this.tbjenispaket.TabIndex = 10;
            this.tbjenispaket.SelectedIndexChanged += new System.EventHandler(this.tbjenispaket_SelectedIndexChanged);
            // 
            // tbberat
            // 
            this.tbberat.Location = new System.Drawing.Point(236, 152);
            this.tbberat.Name = "tbberat";
            this.tbberat.Size = new System.Drawing.Size(142, 26);
            this.tbberat.TabIndex = 9;
            // 
            // tbnohp
            // 
            this.tbnohp.Location = new System.Drawing.Point(236, 101);
            this.tbnohp.Name = "tbnohp";
            this.tbnohp.Size = new System.Drawing.Size(236, 26);
            this.tbnohp.TabIndex = 8;
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(236, 39);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(426, 26);
            this.tbnama.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tanggal Pemesanan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Harga Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harga Paket";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jenis Paket Cucian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Berat Cucian";
            // 
            // btnsimpan
            // 
            this.btnsimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsimpan.Location = new System.Drawing.Point(689, 565);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(116, 39);
            this.btnsimpan.TabIndex = 3;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // Judul
            // 
            this.Judul.BackColor = System.Drawing.Color.Plum;
            this.Judul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Judul.Location = new System.Drawing.Point(211, 21);
            this.Judul.Name = "Judul";
            this.Judul.Size = new System.Drawing.Size(402, 34);
            this.Judul.TabIndex = 5;
            this.Judul.Text = "Fluffy Laundry";
            this.Judul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Data_Pemesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(833, 624);
            this.Controls.Add(this.Judul);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.groupBox1);
            this.Name = "Data_Pemesanan";
            this.Text = "Data Pemesanan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbhargatotal;
        private System.Windows.Forms.TextBox tbharga;
        private System.Windows.Forms.ComboBox tbjenispaket;
        private System.Windows.Forms.TextBox tbberat;
        private System.Windows.Forms.TextBox tbnohp;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Label Judul;
    }
}

