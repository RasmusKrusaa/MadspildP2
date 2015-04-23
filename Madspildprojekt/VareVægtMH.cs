using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Madspildprojekt
{
    /* 
    * Denne klasse er en underklasse af vare, som har ansvaret for at tilskrive
    * vægt og mindstholdbarhedsdato på vare som skal have disse specifikationer.
    */
    public class VareVægtMH : Vare
    {
        private decimal _Vægt;
        private DateTime _MindstHoldbar;

        public VareVægtMH(string navn)
        {
            _Navn = navn;
        }

        public DateTime MindstHoldbar
        {
            get { return _MindstHoldbar; }
            set { _MindstHoldbar = value; }
        }

        public decimal Vægt
        {
            get { return _Vægt; }
            set { _Vægt = value; }
        }
    }
}
