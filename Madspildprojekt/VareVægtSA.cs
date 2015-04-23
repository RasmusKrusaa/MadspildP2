using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Madspildprojekt
    /* 
     * Denne klasse er en underklasse af vare, som har ansvaret for at tilskrive
     * vægt og sidsteanvendelsesdato på vare som skal have disse specifikationer.
    */
{
    public class VareVægtSA : Vare
    {
        private decimal _Vægt;
        private DateTime _SidsteAnvendelse;

        public VareVægtSA(string navn)
        {
            _Navn = navn;
        }
        public decimal Vægt
        {
            get { return _Vægt; }
            set { _Vægt = value; }
        }

        public DateTime SidsteAnvendelse
        {
            get { return _SidsteAnvendelse; }
            set { _SidsteAnvendelse = value; }
        }
    }
}
