using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
/*
namespace Madspildprojekt
{
    public class Vare
    {
        public string _Navn;
        public decimal _Pris;

        public Vare(string navn, decimal pris)
        {
            _Navn = navn;
            _Pris = pris;
        }

        protected List<Vare> madliste = new List<Vare>();

        public void Read_file_varer()
        {
            foreach (string line in File.ReadAllLines(@"C:\\Users\\Bilgram\\Desktop\\Program\\MadspildP2\\Varer.txt"))
            {
                int i = 0;
                int j = 1;

                string[] benny = line.Split(' ');
                madliste.Add(new Vare(benny[i], decimal.Parse(benny[j])));
                i += 2;
                j += 2;
            }
        }
        public void Print_varer_list()
        {
            foreach (Vare v in madliste)
            {
                
                Console.WriteLine("{0} {1}", v._Navn, v._Pris);
            }
        }
    }
}*/