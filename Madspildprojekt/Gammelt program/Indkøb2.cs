using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Madspildprojekt
{
    /*
     * Klassen indkøb er en underklasse af beholdning.
     * indkøb har ansvar for at administrere en indkøbskurv, som kan tilføjes til husbeholdning.
     * administration af indkøbskurv dækker over at lave listen baseret på en opskrift.
     */
    public class Indkøb2 : Beholdning2
    {
        public List<Vare2> Indkøbskurv = new List<Vare2>();

        /*
         * Metoden "UdfraOpskrift" returnere en indkøbskurv baseret på en opskrift, hvor der er 
         * blevet taget forbehold for de varer der er i beholdning.
         */
        public List<Vare2> UdfraOpskrift(Opskrift2 opskrift, Husholdning2 hjemmeBeholdning)
        {
            decimal volumenHusVare, volumenOpskriftVare, manglendeVolumen;
            foreach (Vare2 opskriftVare in opskrift.Ingredienser)
            {
                Indkøbskurv.Add(opskriftVare);
                foreach (Vare2 husholdningVare in hjemmeBeholdning.HusBeholdning)
                {
                    if (opskriftVare._Navn == husholdningVare._Navn)
                    {
                        volumenHusVare = husholdningVare.VolumenTjek();
                        volumenOpskriftVare = opskriftVare.VolumenTjek();
                        if (volumenHusVare >= volumenOpskriftVare)
                        {
                            Indkøbskurv.Remove(opskriftVare);
                        }
                        else
                        {
                            manglendeVolumen = volumenOpskriftVare - volumenHusVare;
                            opskriftVare.setVolumen(manglendeVolumen);
                        }
                    }
                }
            }
            return Indkøbskurv;
        }
        /*
         * Metoden "ManuelTilføjning" giver brugeren mulighed for at tilføje til indkøbskurv, manuelt.
         */
        public List<Vare2> ManuelTilføjning (Vare2 v)
        {
            TilføjVare(v, Indkøbskurv);
            return Indkøbskurv;
        }
        /*
         *  Metoden "MauelSlet" giver brugeren mulighed for at slette elementer fra indkøbskurv, manuelt.
         * 
         */
        public List<Vare2> ManuelSlet(Vare2 v)
        {
            if (Indkøbskurv.Contains(v))
            {
                SletVare(v, Indkøbskurv);
            }
            else
            {
                throw new VareTypeNotFoundException(); //Indeholder ikke vare exception
            }
            return Indkøbskurv;
        }
        /*
         *  Metoden "TilføjTilHjemmeBeholdning" tilføjer indkøbskurven til husbeholdningen.
         */
        public void TilføjTilHjemmeBeholdning(List<Vare2> liste, List<Vare2> Produktkatalog)
        {
            foreach (Vare2 v in Indkøbskurv)
            {
                foreach (Vare2 Produkt in Produktkatalog)
                {
                    if (v._Navn == Produkt._Navn)
                    {
                        decimal Antal = Math.Ceiling(v.VolumenTjek() / Produkt.VolumenTjek());
                        Indkøbskurv.Remove(v);
                        for (int i = 0; i < Antal; i++)
                        {
                            Indkøbskurv.Add(Produkt);
                        }
                    }
                }
                TilføjVare(v, liste);
            }
            Indkøbskurv = new List<Vare2>();
        }
    }
}
