using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    /*interface birbirinin alternatifi olan ancak
    kod içeriği farklı olan durumlar için kullanırız.*/
    //soyut sınıfları new leyemeyiz.interface-abstract class
    interface IKrediManager
    {
        //bankadaki her kredide olması gereken metotlar
        void Hesapla();
        void BiseyYap();
        
    }
}

