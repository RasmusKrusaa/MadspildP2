﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Madspildprojekt
{
    public class VareVægtSA : Vare
    {
        private decimal _Vægt;
        private double _SidsteAnvendelse;

        public VareVægtSA(string navn)
        {
            _Navn = navn;
          //  _Pris = pris;
        }
        public decimal Vægt
        {
            get { return _Vægt; }
            set { _Vægt = value; }
        }

        public double SidsteAnvendelse
        {
            get { return _SidsteAnvendelse; }
            set { _SidsteAnvendelse = value; }
        }
    }
}
