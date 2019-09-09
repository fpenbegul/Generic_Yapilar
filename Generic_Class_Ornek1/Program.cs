using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class_Ornek1
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<int> nesne1 = new GenericClass<int>();
            nesne1.MyProperty1 = 1;
            nesne1.MyProperty2 = "2";
            nesne1.MyProperty3 = 3;
            nesne1.MyProperty4 = new int[] { 1, 2, 3, 4 };


            nesne1.Ekle(1);
            nesne1.Ara("2");
            Console.WriteLine(nesne1.Test(3));
            Console.WriteLine("------------------");

            GenericClass<string> nesne2 = new GenericClass<string>();
            nesne2.MyProperty1 = 1;
            nesne2.MyProperty2 = "2";
            nesne2.MyProperty3 = "3";
            nesne2.MyProperty4 = new string[] { "a", "b", "c" };


            nesne2.Ekle("Merhaba!");
            nesne2.Ara("2");
            Console.WriteLine((nesne2.Test(1)));
            Console.WriteLine("------------------");

            GenericClass<Kahve> nesne3 = new GenericClass<Kahve>();
            nesne3.MyProperty1 = 1;
            nesne3.MyProperty2 = "2";
            nesne3.MyProperty3 = new Kahve(2, "C");
            nesne3.MyProperty4 = new Kahve[] { new Kahve(1, "A"), new Kahve(2, "B"), new Kahve(3, "C"), new Kahve(4, "D"), };

            nesne3.Ekle(new Kahve(1, "E"));
            nesne3.Ara("2");
            Console.WriteLine(nesne3.Test(1));

            Console.ReadLine();






        }
    }
}
