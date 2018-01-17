using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public abstract class Agd
    {
        public enum Marka
        {
            Amica,
            Beko,
            Samsung
        }
        private Marka marka;
        private int numerSeryjny;
        private string usterka;

        public Agd(Marka marka, int numerSeryjny, string usterka)
        {
            this.marka = marka;
            this.numerSeryjny = numerSeryjny;
            this.usterka = usterka;
        }
        public Agd()
        {
        }
        //blok funkcji ustawiajacych parametry
        public void UstawMarke(Marka marka)
        {
            this.marka = marka;
        }
        public void UstawNumer(int numer)
        {
            this.numerSeryjny = numer;
        }
        public void UstawUsterke(string usterka)
        {
            this.usterka = usterka;
        }
        //koniec bloku

        public Marka ZwrocMarke()
        {
            return this.marka;
        }

        public int ZwrocNumer()
        {
            return this.numerSeryjny;
        }

        public string ZwrocUsterke()
        {
            return this.usterka;
        }

        public override string ToString()
        {
            return ("Marka: " + marka + ", numer seryjny: " + numerSeryjny + ", usterka: " + usterka);
        }
    }
}
