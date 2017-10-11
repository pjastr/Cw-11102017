using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Koszyk
    {
        List<Produkt> lista = new List<Produkt>();

        public void DodajProdukt(string nazwaProduktu, int cenaProduktu)
        {
            Produkt produktDodawany = new Produkt();
            produktDodawany.nazwa = nazwaProduktu;
            produktDodawany.cena = cenaProduktu;
            lista.Add(produktDodawany);
            Console.WriteLine("dodaję na listę");

        }

        public void CoMamWKoszyku()
        {
            foreach(var element in lista)
            {
                Console.WriteLine(element.OpisProduktu());
            }
        }
    }
}
