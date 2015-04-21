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
            List<Vare> l = new List<Vare>();
            p.Varedannelse(@"C:\Users\Bilgram\Desktop\Program\MadspildP2\Produktkatalog.txt" , l);
            Console.ReadKey();
        }
    }
}
