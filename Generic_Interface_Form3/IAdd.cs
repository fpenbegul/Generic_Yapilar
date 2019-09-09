using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Interface_Form3
{
    public interface IAdd<T>
    {
        T Add(T item1, T item2);

    }
}
