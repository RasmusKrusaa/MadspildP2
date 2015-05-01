using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;

namespace MadspildGUI
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
            for (int i = 0; i < HusBeholdning.Count; i++)
            {
                if (HusBeholdning[i].ForGammelDatoTjek(DateTime.Today.Date) == true)
                {
                    if (MessageBox.Show("Ønsker du at slette " + HusBeholdning[i]._Navn +
                        " fra din husholdning?", "Slet vare?", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        SletVare(HusBeholdning[i], HusBeholdning);
                        i--;
                    }
                }
            }
        }
        /*
         * Metoden "SletGammelVare" Tjekker og sletter alle de varer i husholdningslisten, som har overskrevet deres holdbarhed med 30 dage.
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
    }
}
