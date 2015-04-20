using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Madspildprojekt
{
    public class Husholdning : Beholdning
    {
        public List<Vare> HusBeholdning = new List<Vare>();
        
        public void indlæs(List<Vare> husholdning)
        {
            Producent p = new Producent();
            p.Varedannelse("C:\\Users\\Bilgram\\Desktop\\Program\\MadspildP2\\Husholdning.txt", husholdning);          
        }

        public void DatoAdvarsel()
        {
            throw new System.NotImplementedException();
        }        
    }
}
