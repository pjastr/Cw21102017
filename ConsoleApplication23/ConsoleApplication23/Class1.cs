using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
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
            return 2017 - rokUrodzenia;
        }

        public void UstawImie(string imie)
        {
            this.imie = imie;
        }

        public string PobierzImie()
        {
            return imie;
        }
    }
}
