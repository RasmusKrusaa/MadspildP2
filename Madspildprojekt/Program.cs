using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Madspildprojekt
{
    public class Program
    {
        static void Main(string[] args)
        {
            Producent p = new Producent();
            Husholdning h = new Husholdning();

            h.HusBeholdning = h.IndlæsVarer("Husholdning.txt");
            
            Console.ReadKey();
        }
    }
}
