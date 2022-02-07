using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //inheritance(miras alma)
    /*Bir classın birden fazla kalıtımı olmaz(ebeveyn)
     * ancak bir classın birden fazla intercafe olabilir.
     */
    internal class TuzelMusteri:Musteri //musteri ebeveyn
    {
       
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
