using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Madspildprojekt
{
    public partial class Varer
    {
        public string _Navn;
        public string _Pris;

        public Varer(string navn, string pris)
        {
            _Navn = navn;
            _Pris = pris;
        }
        public static void Read_file_varer()
        {
         /*   string[] lines = System.IO.File.ReadAllLines(@"D:\\Sample.txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
          */
            foreach (string line in File.ReadAllLines(@"D:\\Sample.txt"))
            {
                int i = 0;
                int j = 1;
                string[] benny = line.Split(' ');
                     Varer v = new Varer(benny[i], benny[j]); 
                i += 2;
                j += 2;
            }
        }
    }
}
