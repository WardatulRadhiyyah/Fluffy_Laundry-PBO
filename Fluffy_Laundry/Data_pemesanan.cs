using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluffy_Laundry
{
    class Data_pemesanan
    {
        private string _NamaPemesan;
        private string _NomorHP;
        private int _Beratkain;
        private DateTime _Tanggalpemesanan;
        private DateTime _Tanggalpengambilan;
        private string _Jenispaket;
        private double _Totalbiaya;

        public string Namapemesan
        {
            get { return _NamaPemesan; }
            set { _NamaPemesan = value; }
        }

        public string NomorHP
        {
            get { return _NomorHP; }
            set { _NomorHP = value; }
        }
        public int Berat
        {
            get { return _Beratkain; }
            set { _Beratkain = value; }
        }
        public DateTime Tanggalpemesanan
        {
            get { return _Tanggalpemesanan; }
            set { _Tanggalpemesanan = value; }
        }

        public DateTime Tanggalpengambilan
        {
            get { return _Tanggalpengambilan; }
            set { _Tanggalpengambilan = value; }
        }
        public string Jenispaket
        {
            get { return _Jenispaket; }
            set { _Jenispaket = value; }
        }
        public double Totalbiaya
        {
            get { return _Totalbiaya; }
            set { _Totalbiaya = value; }
        }
        public Data_pemesanan() { }
        public Data_pemesanan(string namapemesan, string nomorhp, int berat, DateTime tglPesan, string jenis)
        {
            Namapemesan = namapemesan;
            NomorHP = nomorhp;
            Berat = berat;
            Jenispaket = jenis;
            Tanggalpemesanan = tglPesan;
        }
    }
}
