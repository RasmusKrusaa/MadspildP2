using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Madspildprojekt
{
    public class Opskrift : Beholdning
    {

        protected string retNavn;
        public List<Vare> Ingredienser = new List<Vare>();
        private List<string> Instruktioner = new List<string>();
        public List<Opskrift> Opskrifter = new List<Opskrift>();
        

        public void Indlæs() //Filnavn som parameter
        {
            Opskrift o = new Opskrift();
            foreach (string line in File.ReadAllLines(@"C:\\Users\\Bilgram\\Desktop\\Program\\MadspildP2\\Opskrifter.txt"))
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

        public void TilføjOpskriftTilFil(string retNavn, string[] Ingredienser, string[] Instruktioner)
        {
            var fil = new List<string>(File.ReadAllLines(@"C:\Users\Bilgram\Desktop\Program\MadspildP2\Opskrifter.txt"));
            if (fil.ElementAt(fil.Count - 1) == "---")
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Bilgram\Desktop\Program\MadspildP2\Opskrifter.txt", true))
                {
                    file.WriteLine();
                }
            }
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Bilgram\Desktop\Program\MadspildP2\Opskrifter.txt", true))
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
