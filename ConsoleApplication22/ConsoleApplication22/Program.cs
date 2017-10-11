using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba ludzik1 = new Osoba();
            ludzik1.imie = "Anna";
            ludzik1.nazwisko = "Nowak";
            ludzik1.plec = "K";
            ludzik1.Info();

            Console.ReadKey();
        }
    }
}
