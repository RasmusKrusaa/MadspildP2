using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Madspildprojekt
{
    public class VareStkSA : Vare
    {
        private decimal _Stk;
        private DateTime _SidsteAnvendelse;

        public VareStkSA(string navn)
        {
            _Navn = navn;
        }
        public DateTime SidsteAnvendelse
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
