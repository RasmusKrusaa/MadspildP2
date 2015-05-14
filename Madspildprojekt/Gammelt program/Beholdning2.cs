using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Madspildprojekt
{
    /*
     * Beholdning indeholder metoder som kan arbejde med kollektionsklassen List<>.
     */
    public class Beholdning2
    {
        /*
        * Metoden "TilføjVare" tilføjer en specifik vare til en liste.
        */
        public void TilføjVare(Vare2 v, List<Vare2> liste) 
        {
            liste.Add(v);
        }
        /*
         * Metoden "SletVare" Sletter en specifik vare fra en liste.
         */
        public void SletVare(Vare2 v, List<Vare2> liste)
        {
            if (liste.Contains(v))
            {
                liste.Remove(v);
            }
        }
        /*
         * Metoden "SkrifListeAfVarerTilFil" Skriver en liste af Varer til en fil.
         */
        public void SkrivListeAfVarerTilFil(string filnavn, List<Vare2> liste)
        {
            string filsti = Directory.GetParent(Directory.GetParent(Directory.GetParent(
                Directory.GetCurrentDirectory()).ToString()).ToString()).ToString() + @"\" + filnavn;
            using(System.IO.StreamWriter file = new System.IO.StreamWriter(filsti, true))
            {
                foreach (Vare2 v in liste)
                {
                    file.WriteLine(v.skrivInfoTilFil());
                }
            }
        }

        /*
         * Metoden "IndlæsVarer" kalder på metoden IndlæsProdukter fra 
         * producentklassen, som instantierer varer fra en fil.
        */
        public List<Vare2> IndlæsVarer(string filnavn)
        {
            Producent2 p = new Producent2();
            List<Vare2> husholdning = new List<Vare2>();
            husholdning = p.indlaesProdukter(filnavn);
            return husholdning;
        }

        public void SletVareFraFil(string filnavn, List<Vare2> Husbeholdning)
        {
            string filsti = Directory.GetParent(Directory.GetParent(Directory.GetParent(
                Directory.GetCurrentDirectory()).ToString()).ToString()).ToString() + @"\" + filnavn;

            File.WriteAllText(filsti, String.Empty);
            SkrivListeAfVarerTilFil(filnavn, Husbeholdning);
        }
    }
}
