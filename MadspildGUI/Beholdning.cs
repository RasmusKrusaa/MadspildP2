using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MadspildGUI
{
    /*
     * Beholdning indeholder metoder som kan arbejde med kollektionsklassen List<>.
     */
    public class Beholdning
    {
        /*
        * Metoden "TilføjVare" tilføjer en specifik vare til en liste.
        */
        public void TilføjVare(Vare v, List<Vare> liste) 
        {
            liste.Add(v);
        }
        /*
         * Metoden "SletVare" Sletter en specifik vare fra en liste.
         */
        public void SletVare(Vare v, List<Vare> liste)
        {
            if (liste.Contains(v))
            {
                liste.Remove(v);
            }
        }
        /*
         * 
         */
        public void SkrivListeAfVarerTilFil(string filnavn, List<Vare> liste)
        {
            string filsti = Directory.GetParent(Directory.GetParent(Directory.GetParent(
                Directory.GetCurrentDirectory()).ToString()).ToString()).ToString() + @"\" + filnavn;
            using(System.IO.StreamWriter file = new System.IO.StreamWriter(filsti))
            {
                foreach (Vare v in liste)
                {
                    file.WriteLine(v.skrivInfoTilFil());
                }
            }
        }

        /*
         * Metoden "IndlæsVarer" kalder på metoden IndlæsProdukter fra 
         * producentklassen, som instantierer varer fra en fil.
        */
        public List<Vare> IndlæsVarer(string filnavn)
        {
            Producent p = new Producent();
            List<Vare> husholdning = new List<Vare>();
            husholdning = p.indlaesProdukter(filnavn);
            return husholdning;
        }

        public void SletVareFraFil(string filnavn, List<Vare> Husbeholdning)
        {
            string filsti = Directory.GetParent(Directory.GetParent(Directory.GetParent(
                Directory.GetCurrentDirectory()).ToString()).ToString()).ToString() + @"\" + filnavn;

            File.WriteAllText(filsti, String.Empty);
            SkrivListeAfVarerTilFil(filnavn, Husbeholdning);
        }
    }
}
