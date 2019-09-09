using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod_Form2
{
    public class Kisi
    {
        public Kisi(string a, string b)
        {
            Ad = a;
            Soyad = b;
        }


        public string Ad { get; set; }
        public string Soyad { get; set; }


        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }
    }
}
