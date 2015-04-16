using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Madspildprojekt
{
    public class Beholdning
    {
        public void TilføjVare(Vare v, List<Vare> liste) 
        {
            liste.Add(v);
        }

        public void SletVare(Vare v, List<Vare> liste)
        {
            if (liste.Contains(v))
            {
                liste.Remove(v);
            }
        }

        //protected void SorterBeholdning()
        //{
            
        //}
    }
}
