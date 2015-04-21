using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Madspildprojekt
{
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
