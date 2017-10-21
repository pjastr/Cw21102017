using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Car
    {
        public string marka;
        private int rokProdukcji;
        private string model;
        private int iloscDrzwi;
        private double pojemnoscSilnika;
        public double srednieSpalanie;

        public void UstawRokProdukcji(int rok)
        {
            this.rokProdukcji = rok;
        }

        public string Info()
        {
            return marka + " " + rokProdukcji;
        }

        public string GetMarke()
        {
            return this.marka;
        }

        public void SetMarke(string marka)
        {
            this.marka = marka;
        }

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return srednieSpalanie * dlugoscTrasy;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            return ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
        }
    }
}
