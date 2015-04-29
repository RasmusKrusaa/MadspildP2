using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadspildGUI
{
    class VareTypeNotFoundException : Exception
    {
        public VareTypeNotFoundException() : base() {}
        public VareTypeNotFoundException(string s) : base(s) {}
        public VareTypeNotFoundException(string s, Exception ex) : base(s, ex) {}
    }
}
