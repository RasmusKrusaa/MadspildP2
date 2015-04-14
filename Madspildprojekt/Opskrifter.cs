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
        
        /// <summary>
        /// BrugerValg. Med husholdning eller efter valgte varer
        /// </summary>
        /// 

        public void IndlaesOpskrifter()
        {
            
            foreach (string line in File.ReadAllLines(@"C:\\Users\\Bilgram\\Desktop\\Program\\MadspildP2\\Opskrifter.txt"))
            {
                VareStkMH v = new VareStkMH("Kød", 123m);
                string[] str = line.Split('_', '$', '@');
                v.Stk = 10;
            }  
        }



        private void ForeslåOpskrift()
        {
            
        }

        private void TilføjOpskrift()
        {
            throw new System.NotImplementedException();
        }
    }
}
