﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Produkt
    {
        public string nazwa;
        public int cena;

        public string OpisProduktu()
        {
            return nazwa + " " + cena;
        }
    }
}
