using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class_Ornek2
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Generic Collection Örnek
            /// 

            GenericColleciton<string> nesne1 = new GenericColleciton<string>();
            nesne1.ElemanEkle("Ankara");
            nesne1.ElemanEkle("İstanbul");
            nesne1.ElemanEkle("İzmir");
            nesne1.ElemanEkle("Eskişehir");
            nesne1.ElemanEkle("Malatya");

            nesne1.ElemanlariYaz();

            Console.WriteLine("---------------");

            //GenericColleciton<double> nesne2 = new GenericColleciton<double>();
            //nesne2.ElemanEkle(12);
            //nesne2.ElemanEkle(22);
            //nesne2.ElemanEkle(32);
            //nesne2.ElemanEkle(42);

            //nesne2.ElemanlariYaz();


            Console.ReadLine();
        }
    }
}
