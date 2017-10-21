using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Car
    {
        public string marka;
        private int rokProdukcji;
        private string model;
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        public int srednieSpalanie;


        public void UstawRokProdukcji(int rok)
        {
            this.rokProdukcji = rok;
        }

        public string Info()
        {
            return marka + " " + rokProdukcji;
        }
        private double ObliczSpalanie(double dlugoscTrasy)
        {
            double spalanie;
            spalanie = (srednieSpalanie * dlugoscTrasy);
            return spalanie;
        }
        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
           return ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;

        }
    
    
    
    
    }
}
