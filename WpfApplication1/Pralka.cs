﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class Pralka : Agd
    {
        public Pralka (Marka marka, int numerSeryjny, string usterka)
        {
            UstawMarke(marka);
            UstawNumer(numerSeryjny);
            UstawUsterke(usterka);
        }
        public override string ToString()
        {
            return ("Marka: " + ZwrocMarke().ToString() + ", numer seryjny: " + ZwrocNumer() + ", usterka: " + ZwrocUsterke() + " PRALKA");
        }
    }
}
