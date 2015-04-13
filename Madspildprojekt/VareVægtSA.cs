using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Madspildprojekt
{
    public class VareVægtSA : Vare
    {
        private decimal _Vægt;
        private int _SidsteAnvendelse;

        public VareVægtSA(string navn, decimal pris)
        {
            _Navn = navn;
            _Pris = pris;
        }
        public decimal Vægt
        {
            get { return _Vægt; }
            set { _Vægt = value; }
        }

        public int SidsteAnvendelse
        {
            get { return _SidsteAnvendelse; }
            set { _SidsteAnvendelse = value; }
        }
    }
}
