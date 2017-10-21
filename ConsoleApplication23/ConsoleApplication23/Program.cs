using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba dyrektor = new Osoba();
            dyrektor.UstawImie("Janusz");
            dyrektor.nazwisko = "Kowalski";
            dyrektor.rokUrodzenia = 1970;
            dyrektor.okulary = true;

            Console.WriteLine(dyrektor.PobierzImie());
            Console.WriteLine(dyrektor.nazwisko);
            Console.WriteLine(dyrektor.ObliczWiek());
            Console.WriteLine(dyrektor.okulary);
            Console.ReadKey();
        }
    }
}
