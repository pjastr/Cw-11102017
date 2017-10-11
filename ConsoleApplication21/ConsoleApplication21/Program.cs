using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {

            //string carName = "Moj samochod";
            Car car1 = new Car();
            car1.marka = "Ford";
            car1.rokProdukcji = 2000;
            car1.sredniaSpalanie = 5;

            Console.WriteLine(car1.ObliczKosztPrzejazdu(100, 5));
            Console.ReadKey();
            //Car car2 = new Car();
            //car2.marka = "Skoda";
            //car2.rokProdukcji = 2015;

            //car2 = car1;
        }

        
    }

    
}
