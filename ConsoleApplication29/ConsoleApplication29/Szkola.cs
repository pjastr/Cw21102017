using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication29
{
    class Szkola
    {
        internal int iloscUczniow;
        private int iloscKlas;
        public string adres;

        public int sredniaUczniowWKlasie() {
            return iloscUczniow / iloscKlas;
        }

        public void zmienAdres(string adres)
        {
            this.adres = adres;
        }
    }
}
