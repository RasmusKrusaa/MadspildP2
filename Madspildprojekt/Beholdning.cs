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
        public void SkrivListeAfVarerTilFil(string filsti, List<Vare> liste)
        {
            using(System.IO.StreamWriter file = new System.IO.StreamWriter(filsti, true))
            {
                foreach (Vare v in liste)
                {
                    file.WriteLine(v._Navn);
                }
                //skriver objekter til fil, vi vil skrive elementerne fra objektet.
            }
        }
        //protected void SorterBeholdning()
        //{
            
        //}
    }
}
