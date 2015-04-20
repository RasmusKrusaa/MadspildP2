using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Madspildprojekt
{
    public class Husholdning : Beholdning
    {
        public List<Vare> HusBeholdning = new List<Vare>();
        DateTime d = new DateTime();
        
        public void indlæs(List<Vare> husholdning)
        {
            Producent p = new Producent();
            p.Varedannelse("C:\\Users\\Bilgram\\Desktop\\Program\\MadspildP2\\Husholdning.txt", husholdning);
            d.AddDays(5.0);
        }

        public void DatoAdvarsel()
        {
            throw new System.NotImplementedException();
        }
        
    
        
    }
}
