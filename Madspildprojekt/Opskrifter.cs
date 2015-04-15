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
        

        public void IndlæsOpskrifter()
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
                    throw new Exception(); 
                }
            }
        }

        //private void ForeslåOpskrift()
        //{

        //}

        //private void TilføjOpskrift()
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
