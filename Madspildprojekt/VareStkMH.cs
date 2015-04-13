using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Madspildprojekt
{
    public class VareStkMH : Vare
    {
        private decimal _Stk;
        private int _MindstHoldbar;
        
        public VareStkMH(string navn, decimal pris)
        {
            _Navn = navn;
            _Pris = pris;
        }
        public int MindstHoldbar
        {
            get { return _MindstHoldbar; }
            set { _MindstHoldbar = value; }
        }

        public decimal Stk
        {
            get { return _Stk; }
            set { _Stk = value; }
        }
    }
}
