using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class_Ornek1
{
    public class Kahve
    {
        public int Adet { get; set; }
        public string Adi { get; set; }

        public Kahve(int adt, string ad)
        {
            Adet = adt;
            Adi = ad;
        }


    }
}
