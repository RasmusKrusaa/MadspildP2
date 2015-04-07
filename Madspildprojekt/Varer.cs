using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Madspildprojekt
{
    public class Varer
    {
        public string _Navn;
        public decimal _Pris;

        public Varer(string navn, decimal pris)
        {
            _Navn = navn;
            _Pris = pris;
        }

        protected List<Varer> madliste = new List<Varer>();

        public void Read_file_varer()
        {
            foreach (string line in File.ReadAllLines(@"C:\\Users\\Mark\\Documents\\GitHub\\MadspildP2\\Varer.txt"))
            {
                int i = 0;
                int j = 1;

                string[] benny = line.Split(' ');
                madliste.Add(new Varer(benny[i], decimal.Parse(benny[j])));
                i += 2;
                j += 2;
            }
        }
        public void Print_varer_list()
        {
            foreach (Varer v in madliste)
            {
                
                Console.WriteLine("{0} {1}", v._Navn, v._Pris);
            }
        }
    }
}