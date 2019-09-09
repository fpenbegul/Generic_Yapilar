using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Interface_Form3
{
    public class AddInteger : IAdd<int>
    {
        public int Add(int item1, int item2)
        {
            return item1 + item2;
        }
    }
}
