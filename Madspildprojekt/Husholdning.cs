using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;

namespace Madspildprojekt
{
    /*
     * Klassen husholdning indeholder en liste af forbrugerens varer.
     * Klassen har også ansvaret for at informere om varens holdbarhedsdato og slette hvis det er nødvendigt.
     * Derudover er det en underklasse af beholdning så den får funktionaliterne af metoderne fra beholdningsklassen.
    */
    public class Husholdning : Beholdning
    {
        public List<Vare> HusBeholdning = new List<Vare>(); // skal være private ?

        /*
         *Metoden "DatoAdvarsel" informerer brugeren om udløbelende varer, baseret på sidsteanvendelses- eller mindstholdbarhedsdato.
        */
        public void DatoAdvarsel(DateTime dato)
        {
            foreach (Vare v in HusBeholdning)
            {
                v.ForGammelDatoTjek(dato);
            }
        }
        /*
         * Metoden "SletGammelVare" Tjekker og sletter alle de varer i husholdningslisten, som har overskrevet deres holdbarhed.
        */
        public void SletGammelVare(DateTime dato)
        {
            for (int i = 0; i < HusBeholdning.Count; i++)
            {
                bool succes = HusBeholdning[i].SletVareFraListeHvisGammel(dato, HusBeholdning);
                if (succes == true)
                {
                    i--;
                }
            }
        }

        // Metode der skal kunne slette varer fra husholdningen baseret på en opskrift.
        public void SletVareUdFraOpskrift(Opskrift o)
        {
            decimal OpskriftVolumen = 0, HusbeholdningVolumen = 0; // erklærer viabler.

            foreach (Vare v in o.Ingredienser)
            {
                for (int i = 0; i < HusBeholdning.Count; i++)
                {
                    if (v._Navn == HusBeholdning[i]._Navn) 
                    {
                        OpskriftVolumen = v.VolumenTjek();
                        HusbeholdningVolumen = HusBeholdning[i].VolumenTjek();
                        HusbeholdningVolumen = HusbeholdningVolumen - OpskriftVolumen;
                        if (HusbeholdningVolumen != 0)
                        {
                            HusBeholdning[i].setVolumen(HusbeholdningVolumen);
                        }
                        else
                        {
                            SletVare(HusBeholdning[i], HusBeholdning);
                            i--;
                        }
                    }
                }
            }
            SletVareFraFil("Husholdning.txt", HusBeholdning); 
        }
    }
}
