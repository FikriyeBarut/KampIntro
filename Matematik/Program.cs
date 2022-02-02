using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(6, 3);
            dortIslem.Cikar(5, 2);
            dortIslem.Carp(6, 1);
            dortIslem.Bol(4, 2);
        }
    }
}
