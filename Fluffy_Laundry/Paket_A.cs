using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluffy_Laundry
{
    class Paket_A : Paket_cucian
    {
        private const double _Hargapaket = 10000;
        private const string _Jenispaket = "Paket A";
        private const int _Durasi = 3;

        public new double Hargapaket
        {
            get { return _Hargapaket; }

        }
        public new string jenispaket
        {
            get { return _Jenispaket; }

        }
        public new int Durasi
        {
            get { return _Durasi; }

        }
    }
}
