using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Madspildprojekt
{
    public class Indkøb : Beholdning
    {
        public List<Vare> Indkøbskurv = new List<Vare>();

        private List<Vare> IndkøbskurvUdfraOpskrift(Opskrift opskrift, Husholdning hjemmeBeholdning)
        {
            foreach (Vare opskriftVare in opskrift.Ingredienser)
            {
                Indkøbskurv.Add(opskriftVare);
                foreach (Vare husholdningVare in hjemmeBeholdning.HusBeholdning)
                {
                    if (opskriftVare._Navn == husholdningVare._Navn)
                    {
                        Indkøbskurv.Remove(opskriftVare);
                    }
                }
            }
            return Indkøbskurv;
        }
    }
}
// skal kunne lave en indkøbskurv udfra en opskrift, som indeholder hvad man mangler til denne.