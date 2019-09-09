using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Interface_Form3
{
    public class AddDouble : IAdd<double>
    {
        public double Add(double item1, double item2)
        {
            return item1 + item2;
        }
    }
}
