using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Car
    {
        public string marka;
        public int rokProdukcji;
        private string model;
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        public double sredniaSpalanie;

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return sredniaSpalanie * dlugoscTrasy;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            return ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
        }
    }
}
