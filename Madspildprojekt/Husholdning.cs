using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Madspildprojekt
{
    public class Husholdning : Beholdning
    {
        public List<Vare> HusBeholdning = new List<Vare>();

        public void DatoAdvarsel()
        {
            throw new System.NotImplementedException();
        }
    }
}
