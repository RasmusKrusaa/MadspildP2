using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Madspildprojekt
{
    /* 
     * Denne klasse er en underklasse af vare, som har ansvaret for at tilskrive
     * stk og mindstholbarhedsdato på vare som skal have disse specifikationer.
    */
    public class VareStkMH : Vare
    {
        private decimal _Stk;
        private DateTime _MindstHoldbar;
        
        public VareStkMH(string navn)
        {
            _Navn = navn;
        }
        public DateTime MindstHoldbar
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
