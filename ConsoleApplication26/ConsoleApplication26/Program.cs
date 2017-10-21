using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.marka = "Skoda";
            car1.UstawRokProdukcji(2016);
            Console.WriteLine(car1.Info());
            car1.srednieSpalanie = 5.6;
            Console.WriteLine(car1.ObliczKosztPrzejazdu(34.2, 34.2));
            //Car car2 = new Car();
            //car2.marka = "Fiat";
            //car2.UstawRokProdukcji(2015);
            //Console.WriteLine(car2.Info());
            //car1 = car2;
            //Console.WriteLine("po przypisaniu");
            //Console.WriteLine(car1.Info());
            //Console.WriteLine(car2.Info());
            Console.ReadKey();
        }


    }

    
}
