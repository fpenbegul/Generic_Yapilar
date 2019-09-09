using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Interface_Form3
{
    public class AddString : IAdd<string>
    {
        public string Add(string item1, string item2)
        {
            return item1 +" "+ item2 + "->string Yapı<-";
        }
    }
}
