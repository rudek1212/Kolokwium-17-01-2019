using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    interface ISerwis
    {
        void DodajPralke(Agd.Marka marka, int numer, string usterka);
        void DodajLodowke(Agd.Marka marka, int numer, string usterka);
        void GenerujRaport();
        void Napraw();
        void Napraw(int numer);
    }
}
