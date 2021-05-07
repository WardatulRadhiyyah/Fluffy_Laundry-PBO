using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fluffy_Laundry { 
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
                Close();
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
    }

    public Data_Pemesanan(string nama, string alamat, string nomor, string email)
    {
        InitializeComponent();
        mode = Mode.Edit;
        pelanggan = new Pelanggan
        {
            Nama = nama,
            No_Hp = nomor,
            Berat_Cucian = Convert.ToInt32(tbberat.Text),
            Jenis_Paket = tbjenispaket.Text,
            Harga_Paket = Convert.ToDouble(tbharga.Text),
            Harga_Total = Convert.ToDouble(tbhargatotal.Text),
            Tanggal_Pemsanan = Convert.ToDateTime(dateTimePicker2.Text),
            Tanggal_Pengambilan = Convert.ToDateTime(dateTimePicker1.Text),
        };
        tbnama.Text = nama;
        tbnohp.Text = nomor;
        tbberat.Text = tbberat.Text;
        tbjenispaket.Text = tbjenispaket.Text;
        tbharga.Text = tbharga.Text;
        tbhargatotal.Text = tbhargatotal.Text;
        dateTimePicker2.Text = dateTimePicker2.Text;
        dateTimePicker1.Text = dateTimePicker1.Text;
        btnsimpan.Text = "Simpan";
    }

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
}
}

