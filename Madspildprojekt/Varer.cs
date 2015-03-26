using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madspildprojekt
{
    public class Varer
    {
        public string _Navn;
        public int _Stk;
        public double _Vaegt;

        public Varer(string navn, int stk, double vaegt)
        {
            _Navn = navn;
            _Stk = stk;
            _Vaegt = vaegt;
        }

    }
}
