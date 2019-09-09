using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class_Ornek1
{
    class GenericClass<T>
    {


        public int MyProperty1 { get; set; }
        public string MyProperty2 { get; set; }
        public T MyProperty3 { get; set; }
        public T[] MyProperty4 { get; set; }


        public void Ekle(T eleman)
        {
            Console.WriteLine("Ekleme işlemi yapıldı!");
        }

        public T Test(int id)
        {

            return default(T);

        }



        public void Ara(string item)
        {
            Console.WriteLine("Arama işlemi yapıldı!");

        }







    }
}
