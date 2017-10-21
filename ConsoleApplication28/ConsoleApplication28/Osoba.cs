using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class Osoba
    {
        private string imie;
        public string nazwisko;
        public int rokUrodzenia;
        public int waga;
        public int wzrost;
        public bool okulary;
        public string plec;

        public int ObliczWiek()
        {
            return DateTime.Now.Year - rokUrodzenia;
        }

        public void SetImie(string imie)
        {
            this.imie = imie;
        }

        public string GetImie()
        {
            return imie;
        }

    }
}
