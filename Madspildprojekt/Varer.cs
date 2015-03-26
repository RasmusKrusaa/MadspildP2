using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madspildprojekt
{
    public class Varer
    {
        string _navn;
        int _stk;
        double _vaegt;

        public Varer(string navn, int stk, double vaegt)
        {
            _navn = navn;
            _stk = stk;
            _vaegt = vaegt;
        }
    }
}
