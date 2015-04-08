using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madspildprojekt
{
    public class Vare
    {
        string _Navn;
        decimal _Pris;

        public Vare(string Navn, decimal Pris)
        {
            _Navn = Navn;
            _Pris = Pris;
        }
    }
}
