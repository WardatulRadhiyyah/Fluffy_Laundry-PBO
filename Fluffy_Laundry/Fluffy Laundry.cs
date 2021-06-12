using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fluffy_Laundry
{
    public partial class Data_Pemesanan : Form
    {
        Pelanggan pelanggan;
        public enum Mode { Insert, Edit }
        Mode mode;
        public Data_Pemesanan()
        {
            InitializeComponent();
            mode = Mode.Insert;
            btnsimpan.Text = "Simpan";
        }
        private void SimpanData()
        {
            if (tbnama.Text != "" && tbnohp.Text != "" && tbberat.Text != "" && tbjenispaket.Text != "" && tbharga.Text != "" && tbhargatotal.Text != "" && dateTimePicker2.Text != ""
                && dateTimePicker1.Text != "")
            {
                using (var db = new PelangganModel())
                {
                    pelanggan = new Pelanggan
                    {
                        Nama = tbnama.Text,
                        No_Hp = tbnohp.Text,
                        Berat_Cucian = Convert.ToInt32(tbberat.Text),
                        Jenis_Paket = tbjenispaket.Text,
                        Harga_Paket = Convert.ToDouble(tbharga.Text),
                        Harga_Total = Convert.ToDouble(tbhargatotal.Text),
                        Tanggal_Pemsanan = Convert.ToDateTime(dateTimePicker2.Text),
                        Tanggal_Pengambilan = Convert.ToDateTime(dateTimePicker1.Text),
                    };
                    db.Pelanggans.Add(pelanggan);
                    db.SaveChanges();
                    MessageBox.Show("Pesanan Disimpan");

                }
            }
            else
            {
                MessageBox.Show("Nama, Nomor Hp, Berat Cucian, Jenis Paket, Tanggal Pemesanan harus diisi");
            }
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Insert)
                SimpanData();
           // if (mode == Mode.Edit)
                //EditData();
        }

        public Data_Pemesanan(string namapemesan, string nomorhp, int berat, DateTime tglPesan, string jenis)
        {
            InitializeComponent();
            mode = Mode.Edit;
            pelanggan = new Pelanggan
            {
                Nama = namapemesan,
                No_Hp = nomorhp,
                Berat_Cucian = Convert.ToInt32(tbberat.Text),
                Jenis_Paket = tbjenispaket.Text,
                Harga_Paket = Convert.ToDouble(tbharga.Text),
                Harga_Total = Convert.ToDouble(tbhargatotal.Text),
                Tanggal_Pemsanan = Convert.ToDateTime(dateTimePicker2.Text),
                Tanggal_Pengambilan = Convert.ToDateTime(dateTimePicker1.Text),
            };
            tbnama.Text = namapemesan;
            tbnohp.Text = nomorhp;
            tbberat.Text = tbberat.Text;
            tbjenispaket.Text = tbjenispaket.Text;
            tbharga.Text = tbharga.Text;
            tbhargatotal.Text = tbhargatotal.Text;
            dateTimePicker2.Text = dateTimePicker2.Text;
            dateTimePicker1.Text = dateTimePicker1.Text;
            btnsimpan.Text = "Simpan";
        }
       // private void EditData()
        //{
           // using (var db = new PelangganModel())
           // {
               // var result = db.Pelanggans.SingleOrDefault(k => k.Nama == pelanggan.Nama);
               // if (result != null)
               // {
                   // if (tbnama.Text != ""  && tbnohp.Text != "" && tbberat.Text != "" && tbjenispaket.Text != ""&& tbharga.Text !="" && tbhargatotal.Text  !="" && dateTimePicker2.Text != "" && dateTimePicker1.Text != "")
                    //{
                       // result.Nama = tbnama.Text;
                       // result.Berat_Cucian = Convert.ToInt32(tbberat.Text);
                       // result.Jenis_Paket = tbjenispaket.Text;
                       // result.Harga_Paket = Convert.ToDouble(tbharga.Text);
                       // result.Harga_Total = Convert.ToDouble(tbhargatotal.Text);
                        //result.Tanggal_Pemsanan = Convert.ToDateTime(dateTimePicker2.Text);
                       // result.Tanggal_Pengambilan = Convert.ToDateTime(dateTimePicker1.Text);
                       // result.No_Hp = tbnohp.Text;
                        
                       // db.SaveChanges();
                       // MessageBox.Show("Kontak berhasil diperbaharui");
                       // Close();
                    //}
                   // else
                   // {
                        //MessageBox.Show("Nama, Alamat, dan Nomor HP harus diisi");
                   // }
               // }
           // }
        //}
        
      //  private void button4_Click(object sender, EventArgs e)
       // {

           // Data_Pemesanan data_Pemesanan = new Data_Pemesanan(tbnama.Text, tbnohp.Text, tbjenispaket.Text, tbharga.Text,tbhargatotal.Text,tbberat.Text, dateTimePicker2.Text, dateTimePicker1.Text) ;
          //  Data_Pemesanan.ShowDialog();
        //}




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbjenispaket_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data_pemesanan data = new Data_pemesanan();
            hitungTotal();
            hitungTanggal();
        }
        public void hitungTotal()
        {
            Data_pemesanan data = new Data_pemesanan(tbnama.Text, tbnohp.Text, Convert.ToInt32(tbberat.Text), Convert.ToDateTime(dateTimePicker2.Text), tbjenispaket.Text);
            switch (tbjenispaket.Text)
            {
                case "Paket A":

                    Paket_A paketA = new Paket_A();
                    data.Totalbiaya = data.Berat * paketA.Hargapaket;
                    tbharga.Text = Convert.ToString(paketA.Hargapaket);
                    break;


                case "Paket B":
                    Paket_B paketB = new Paket_B();
                    data.Totalbiaya = data.Berat * paketB.Hargapaket;
                    tbharga.Text = Convert.ToString(paketB.Hargapaket);
                    break;

                case "Paket C":
                    Paket_C paketC = new Paket_C();
                    data.Totalbiaya = data.Berat * paketC.Hargapaket;
                    tbharga.Text = Convert.ToString(paketC.Hargapaket);
                    break;
            }
            tbhargatotal.Text = Convert.ToString(data.Totalbiaya);
        }
        public void hitungTanggal()
        {
            Data_pemesanan data = new Data_pemesanan(tbnama.Text, tbnohp.Text, Convert.ToInt32(tbberat.Text), Convert.ToDateTime(dateTimePicker2.Text), tbjenispaket.Text);
            switch (tbjenispaket.Text)
            {
                case "Paket A":
                    Paket_A paketA = new Paket_A();
                    data.Tanggalpengambilan = data.Tanggalpemesanan.AddDays(paketA.Durasi);
                    break;

                case "Paket B":
                    Paket_B paketB = new Paket_B();
                    data.Tanggalpengambilan = data.Tanggalpemesanan.AddDays(paketB.Durasi);
                    break;

                case "Paket C":
                    Paket_C paketC = new Paket_C();
                    data.Tanggalpengambilan = data.Tanggalpemesanan.AddDays(paketC.Durasi);
                    break;
            }
            dateTimePicker1.Text = Convert.ToString(data.Tanggalpengambilan);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login keluar = new Login();
            keluar.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu back = new Menu();
            back.Show();
            this.Hide();
        }

        private void tbnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Input_Click(object sender, EventArgs e)
        {
            tbnama.Text = "";
            tbnohp.Text = "";
            tbjenispaket.Text = "";
            tbhargatotal.Text = "";
            tbharga.Text = "";
            tbberat.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";


            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lbpesanan.Items.Clear();
            groupBox1.Visible = false;
            groupBox2.Visible = true;

            using (var db = new PelangganModel())
            {
                var query = from pelanggan in db.Pelanggans
                            where pelanggan.Nama != ""
                            select pelanggan;
                foreach (var item in query)
                {
                    lbpesanan.Items.Add(item.Nama + "\t" + item.Jenis_Paket + "\t" + item.Berat_Cucian + "\t" + item.Tanggal_Pemsanan + "\t" + item.Tanggal_Pengambilan + "\t" + item.Harga_Total);

                }
            }
        }
        

        
    }
}



