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
            Opskrift o = new Opskrift();
            List<Vare> v =  p.indlaesProdukter("Produktkatalog.txt");
            o.Indlæs("Opskrifter.txt");
            Console.ReadKey();
        }
    }
}
