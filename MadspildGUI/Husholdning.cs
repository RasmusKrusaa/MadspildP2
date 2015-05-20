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
        public List<Vare> HusBeholdning = new List<Vare>();

        /*
         *Metoden "DatoAdvarsel" informerer brugeren om udløbelende varer, baseret -
         * på sidsteanvendelses- eller mindstholdbarhedsdato.
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
         * Metoden "SletGammelVare" Tjekker og sletter alle de varer i husholdningslisten, 
         * som har overskrevet deres holdbarhed med 30 dage.
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
        /*
         * Metoden "SletVareUdFraOpskrift" tager en specifik vare ind  og tjekker 
         * hvorvidt alle varene befinder sig i beholdningen. Findes alle varene i beholdningen -
         * vil metoden returnere true og fjerne den mængde vare opskriften kræver. 
         * Findes varene ikke i beholdningen eller er volumen ikke tilstrækkelig returnere metoden false -
         * og varene vil ikke blive slettet.
         */

        public bool SletVarerUdFraOpskrift(Opskrift o, string filnavn)
        {
            List<Vare> Templiste = new List<Vare>();
            List<string> VarerSlettetFraOpskrift = new List<string>();
            decimal OpskriftVolumen = 0, HusbeholdningVolumen = 0, FlerevareVolumen = 0; // erklærer viabler.
            int Varematch = 0;
            foreach (Vare v in o.Ingredienser)
            {
                Templiste.Clear();
                for (int i = 0; i < HusBeholdning.Count; i++)
                {
                    
                    if (v._Navn == HusBeholdning[i]._Navn)
                    {
                        Varematch++;
                        OpskriftVolumen = v.VolumenTjek();
                        HusbeholdningVolumen = HusBeholdning[i].VolumenTjek();
                        HusbeholdningVolumen = HusbeholdningVolumen - OpskriftVolumen;
                        if (HusbeholdningVolumen == 0 && !VarerSlettetFraOpskrift.Contains(v._Navn))
                        {
                            SletVare(HusBeholdning[i], HusBeholdning);
                            i--;
                            VarerSlettetFraOpskrift.Add(HusBeholdning[i]._Navn);
                        }
                        else if (HusbeholdningVolumen > 0 && !VarerSlettetFraOpskrift.Contains(v._Navn))
                        {
                            HusBeholdning[i].setVolumen(HusbeholdningVolumen);
                            VarerSlettetFraOpskrift.Add(HusBeholdning[i]._Navn);
                        }
                        else if (HusbeholdningVolumen < 0)
                        {
                            if (HusBeholdning.FindAll(x => x._Navn == v._Navn).Count() == 1)
                            {
                              return false;  
                            }
                            else if (HusBeholdning.FindAll(x => x._Navn == v._Navn).Count() > 1)
                            {
                                Templiste = HusBeholdning.FindAll(x => x._Navn == v._Navn);
                                foreach (Vare tempvare in Templiste)
                                {
                                    FlerevareVolumen += tempvare.VolumenTjek();
                                }    
                                if (OpskriftVolumen > FlerevareVolumen)
                                    {
                                        return false;
                                    }
                                    else if (OpskriftVolumen <= FlerevareVolumen)
                                    {
                                        Templiste.Sort((a, b) => a.GetDate().CompareTo(b.GetDate()));
                                        OpskriftVolumen -= Templiste[0].VolumenTjek();
                                        v.setVolumen(OpskriftVolumen);
                                        SletVare(HusBeholdning[i], HusBeholdning);
                                        i--;
                                    }
                               
                            }

                        } 
                    }
                }              
            }
            if (Varematch < o.Ingredienser.Count())
            {
                return false;
            }
            else
            {
                SletVareFraFil(filnavn, HusBeholdning);
                return true;
            }
        }
    }
}
