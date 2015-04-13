using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Madspildprojekt
{
    public class VareStkSA : Vare
    {
        private decimal _Stk;
        private int _SidsteAnvendelse;

        public VareStkSA(string navn, decimal pris)
        {
            _Navn = navn;
            _Pris = pris;
        }
        public int SidsteAnvendelse
        {
            get { return _SidsteAnvendelse; }
            set { _SidsteAnvendelse = value; }

        }

        public decimal Stk
        {
            get { return _Stk; }
            set { _Stk = value; }
        }
    }
}
