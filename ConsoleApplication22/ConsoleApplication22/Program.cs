using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.marka = "Skoda";
            car1.UstawRokProdukcji(2014);

            car1.srednieSpalanie = 6;
            Console.WriteLine(car1.ObliczKosztPrzejazdu(555.5, 999.8));
            Console.WriteLine(car1.Info());

            //Car car2 = new Car();
            //car2.marka = "Honda";
            //car2.UstawRokProdukcji(2016);
            //Console.WriteLine(car2.Info());
            //car1 = car2;
            //Console.WriteLine("po przypisaniu:");
            //Console.WriteLine(car1.Info());
            //Console.WriteLine(car2.Info());
            Console.ReadKey();
        }


    }

    
}
