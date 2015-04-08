using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Madspildprojekt
{
    class Vareliste
    {
        private List<Vare> Madliste = new List<Vare>();

        public void Read_file_vareliste()
        {
            foreach (string line in File.ReadAllLines(@"C:\\Users\\Rasmus Krusaa\\Documents\\GitHub\\MadspildP2\\Varer.txt"))
            {
                int i = 0;
                int j = 1;

                string[] Varer_str = line.Split(' ');
                Madliste.Add(new Vare(Varer_str[i], decimal.Parse(Varer_str[j])));
            }
        }
    }
}
