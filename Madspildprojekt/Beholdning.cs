using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Madspildprojekt
{
    public class Beholdning
    {
        public void TilføjVare(Vare v, List<Vare> liste) 
        {
            liste.Add(v);
        }

        public void SletVare(Vare v, List<Vare> liste)
        {
            if (liste.Contains(v))
            {
                liste.Remove(v);
            }
        }

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
