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

            string[] a = { "250_g_kulling", "100_g_fisk" };
            string[] b = { "dyp kulling i fisk", "steg fisk" };
            Opskrift o = new Opskrift();
            o.TilføjOpskriftTilFil("lækker kulling", a, b);
            o.Indlæs();
            Console.ReadKey();
        }
    }
}
