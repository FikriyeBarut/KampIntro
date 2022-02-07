using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //inheritance(miras alma)
    internal class GercekMusteri:Musteri //musteri icindeki tüm özellikler Gercek musteride de vardır.
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }

    }
}
