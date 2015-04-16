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
            p.Varedannelse("C:\\Users\\Bilgram\\Desktop\\Program\\MadspildP2\\Varer.txt");
            Opskrift o = new Opskrift();
            o.Indlæs();
            o.ForeslåEfterListe(p.ProduktKatalog);
            Console.ReadKey();
        }
    }
}
