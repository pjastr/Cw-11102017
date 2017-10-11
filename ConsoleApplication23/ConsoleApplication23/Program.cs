using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            Koszyk koszyk1 = new Koszyk();
            koszyk1.DodajProdukt("Jabłko", 3);
            koszyk1.DodajProdukt("Mleko", 2);
            koszyk1.CoMamWKoszyku();

            Console.ReadKey();
        }
    }
}
