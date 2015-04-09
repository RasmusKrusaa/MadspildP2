using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Madspildprojekt
{
    public class Opskrift : Beholdning1
    {
        public List<Vare1> Varer = new List<Vare1>();
        public List<string> Trin = new List<string>();

        /// <summary>
        /// BrugerValg. Med husholdning eller efter valgte varer
        /// </summary>
        private void ForeslåOpskrift()
        {
            throw new System.NotImplementedException();
        }

        private void TilføjOpskrift()
        {
            throw new System.NotImplementedException();
        }
    }
}
