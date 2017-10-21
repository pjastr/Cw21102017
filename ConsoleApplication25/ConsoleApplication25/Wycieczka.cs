using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Wycieczka
    {
        private int cena;
        public string kraj;
        private bool allInclusive;
        public int holetGwiazdki;

        public void ObliczCene()
        {
            this.cena = 3000;
            
        }

        protected void WyswietlCene()
        {
            Console.WriteLine(cena);
        }
    }
}
