using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluffy_Laundry
{
    class Paket_cucian
    {
      
            private double _Hargapaket;
            private string _Jenispaket;
            private int _Durasi;

            public double Hargapaket
            {
                get { return _Hargapaket; }
                set { _Hargapaket = value; }
            }

            public string jenispaket
            {
                get { return _Jenispaket; }
                set { _Jenispaket = value; }
            }
            public int Durasi
            {
                get { return _Durasi; }
                set { _Durasi = value; }
            }
       
    }
}
