using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
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

        public void DatoAdvarsel(DateTime dato)
        {
            foreach (Vare v in HusBeholdning)
            {
                if (true) //Problem med at tilgå dato
                {
                    MessageBox.Show(v._Navn + " er ved at blive for gammel. Tjek dato.");
                }
            }
        }        
        public void SletGammelVare(DateTime dato)
        {
            foreach (Vare v in HusBeholdning)
            {
                if (true) //Problem med at tilgå dato
                {
                    SletVare(v, HusBeholdning);
                }
            }
        }
    }
}
