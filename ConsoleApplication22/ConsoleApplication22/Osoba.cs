using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Osoba
    {
        public string imie;
        public string nazwisko;
        public string plec;

        public void Info()
        {
            if (plec == "K")
            {
                Console.WriteLine("{0} {1} jest kobietą", imie, nazwisko);
            }
            else if (plec == "M")
            {
                Console.WriteLine("{0} {1} jest mężczyzną", imie, nazwisko);
                
            }
        }
    }
}
