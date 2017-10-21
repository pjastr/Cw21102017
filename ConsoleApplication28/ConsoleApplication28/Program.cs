using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba dyrektor = new Osoba();
            dyrektor.SetImie( "Adam");
            dyrektor.nazwisko = "Nowak";
            dyrektor.rokUrodzenia = 1988;
            Console.WriteLine(dyrektor.GetImie() + " " + dyrektor.nazwisko + " " + dyrektor.ObliczWiek());
            Console.ReadKey();
        }
    }
}
