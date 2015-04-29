using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Madspildprojekt
{
    /*
     * Klassen Opskrift er en underklasse af beholdning.
     * Opskrift har ansvar for at indlæse opskrifter, Foreslå opskrifter ud fra en liste af varer eller ud fra en bestemt vare.
     * Derudover giver den også mulighed for at manuelt at tilføje en opskrift.
     */
    public class Opskrift : Beholdning
    {

        public string retNavn;
        public List<Vare> Ingredienser = new List<Vare>();
        private List<string> Instruktioner = new List<string>();
        public List<Opskrift> Opskrifter = new List<Opskrift>();
        
        /*
         * Metoden "indlæs" bliver brugt til at indlæse opskrifter fra fil, som tilføjes til specifikke lister.
         */
        public void Indlæs(string filnavn) //Filnavn som parameter
        {
            Opskrift o = new Opskrift();
            string filsti = Directory.GetParent(Directory.GetParent(Directory.GetParent(
                Directory.GetCurrentDirectory()).ToString()).ToString()).ToString() + @"\" + filnavn;
            foreach (string line in File.ReadAllLines(filsti))
            {
                string[] str = line.Split('_');
                if (str[0] == "$")
                {
                    o.retNavn = str[1];
                }
                else if (str[0] == "@")
                {
                    if (str[2] == "g" || str[2] == "kg")
                    {
                        VareVægtMH v = new VareVægtMH(str[3]);
                        v.Vægt = decimal.Parse(str[1]);
                        o.Ingredienser.Add(v);
                    }
                    else
                    {
                        VareStkMH v = new VareStkMH(str[2]);
                        v.Stk = decimal.Parse(str[1]);
                        o.Ingredienser.Add(v);
                    }
                }
                else if (str[0] == "#")
                {
                    o.Instruktioner.Add(str[1]);
                }
                else if (str[0] == "---")
                {
                    Opskrifter.Add(o);
                    o = new Opskrift();
                }
                else 
                {
                    throw new VareTypeNotFoundException(); 
                }
            }
        }
        /*
         * Metoden "ForeslåEfterVarer" foreslårer en opskrift ud fra udvalgte varer 
         */
        public List<Opskrift> ForeslåEfterVarer(string[] vareNavn)
        {
            List<Opskrift> forslag = new List<Opskrift>();
            foreach (string str in vareNavn)
            {
                foreach (Opskrift o in Opskrifter)
                {
                    foreach (Vare v in o.Ingredienser)
	                {
		                if (v._Navn == str && !forslag.Contains(o))
	                    {
                            forslag.Add(o);
    	                }
                    }   
                }
            }
            return forslag;
        }
        /*
         * Metoden "ForeslåEfterListe" foreslårer en opskrift ud fra en udvalgt liste, f.eks. husbeholdning.
         */
        public List<Opskrift> ForeslåEfterListe(List<Vare> liste) 
        {
            List<Opskrift> forslag = new List<Opskrift>();
            
            for (int forslagCount = 0; forslagCount < 5; forslagCount++)
            {
                int topMatch = 0;
                foreach (Opskrift o in Opskrifter)
                {
                    int ingrediensMatch = 0;
                    if (!forslag.Contains(o))
                    {
                        foreach (Vare opskriftVare in o.Ingredienser)
                        {
                            foreach (Vare listeVare in liste)
                            {
                                if (opskriftVare._Navn == listeVare._Navn)
                                {
                                    ingrediensMatch++;
                                }
                            }
                            if (topMatch < ingrediensMatch)
                            {
                                topMatch = ingrediensMatch;
                                if (forslag.Count > forslagCount)
                                {
                                    forslag.RemoveAt(forslagCount);
                                    forslag.Add(o);
                                }
                                else
                                {
                                    forslag.Add(o);
                                }
                            }
                        }
                    }
                }
            }
            return forslag;
        }
        /*
         * Metoden "TilføjOpskriftTilFil" tilføjer en opskrift til fil, ud fra parameterne retnavn, ingrediencer og instruktioner.
         */
        public void TilføjOpskriftTilFil(string retNavn, string[] Ingredienser, string[] Instruktioner)
        {
            string opskriftfilSti = Directory.GetParent(Directory.GetParent(Directory.GetParent(
                Directory.GetCurrentDirectory()).ToString()).ToString()).ToString() + @"\Opskrifter.txt";
            var fil = new List<string>(File.ReadAllLines(opskriftfilSti));
            if (fil.ElementAt(fil.Count - 1) == "---")
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(opskriftfilSti, true))
                {
                    file.WriteLine();
                }
            }
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(opskriftfilSti, true))
            {
                file.WriteLine("$_" + retNavn);
                foreach (string str in Ingredienser)
                {
                    file.WriteLine("@_" + str);
                }
                foreach (string str in Instruktioner)
                {
                    file.WriteLine("#_" + str);
                }
                file.Write("---");                
            }
        }
    }
}
