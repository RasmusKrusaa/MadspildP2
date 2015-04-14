using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Madspildprojekt
{
    public class Opskrift : Beholdning
    {
        protected string[] ingredienser, instruktioner; 
        protected string retNavn;
        public List<Opskrift> Opskrifter = new List<Opskrift>();
 
        /// <summary>
        /// BrugerValg. Med husholdning eller efter valgte varer
        /// </summary>
        /// 

        public void IndlaesOpskrifter()
        {
            
            foreach (string line in File.ReadAllLines(@"C:\\Users\\Bilgram\\Desktop\\Program\\MadspildP2\\Opskrifter.txt"))
            {

                string[] str = line.Split('_', '$', '@');
               
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
