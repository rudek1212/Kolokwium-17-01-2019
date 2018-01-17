using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WpfApplication1
{
    class Serwis : ISerwis
    {
        private LinkedList<Agd> doNaprawy = new LinkedList<Agd>();
        private int zysk;
        public Serwis()
        {
            this.zysk= (-15);
        }
        public void DodajPralke(Agd.Marka marka, int numer, string usterka)
        {
            doNaprawy.AddFirst(new Pralka(marka, numer, usterka));
            this.zysk = zysk + 50;
        }
        public void DodajLodowke(Agd.Marka marka, int numer, string usterka)
        {
            doNaprawy.AddFirst(new Lodowka(marka, numer, usterka));
            this.zysk = zysk + 70;
        }
        public override string ToString()
        {
            StringBuilder wynik = new StringBuilder();
            wynik.Append("Lista:");
            wynik.AppendLine();
            foreach (var element in doNaprawy)
            {
                wynik.Append(element.ToString());
                wynik.AppendLine();
            }
            wynik.AppendFormat("Zysk: {0}", zysk);
            return wynik.ToString();
        }
        public void GenerujRaport()
        {
            File.WriteAllText(Directory.GetCurrentDirectory() + @"\usterki.txt", this.ToString());
        }
        public void Napraw() 
        {
            doNaprawy.RemoveFirst();    
        }

        //to nie ma prawa działac bo kolekcja jest modyfikowana podczas pętli
        //nie mam pojęcia jak to zrobić 
        public void Napraw(int numer)
        {
            int tmp;
            foreach (var element in doNaprawy)
            {
                if (element.ZwrocNumer() == numer)
                {
                    doNaprawy.Remove(element);
                }
            }
        }
    }
}
