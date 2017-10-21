using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Car
    {
        private double pojemnoscSilnika;
        private string marka;

        public Car()
        {
            this.pojemnoscSilnika = 45.2;
            this.marka = "Fiat";

        }

        public Car(string markaSamochodu, double poj)
        {
            this.pojemnoscSilnika = poj;
            this.marka = markaSamochodu;
        }
    }
}
