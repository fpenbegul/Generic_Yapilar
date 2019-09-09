using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class_Ornek2
{
    public class GenericColleciton<T> where T : class
    {
        T[] dizi;


        public GenericColleciton()
        {
            dizi = new T[4];
        }

        public void ElemanEkle(T eleman)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                //if (dizi[i] == default(T))
                if (dizi[i] == null) // double value type ve asla null olmaz bu yüzen bu kod bloğuna hiç girmedi/girmez.
                {
                    dizi[i] = eleman;
                    break;
                }
            }
        }

        public void ElemanlariYaz()
        {
            foreach (T item in dizi)
            {
                Console.WriteLine(item);
            }
        }

    }
}
