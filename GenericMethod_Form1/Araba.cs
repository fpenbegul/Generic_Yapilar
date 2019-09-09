using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod_Form1
{
    public class Araba
    {
        public string Marka { get; set; }

        public int Model { get; set; }

        public Araba(string mrk, int mdl)
        {
            Marka = mrk;
            Model = mdl;

        }
    }
}
