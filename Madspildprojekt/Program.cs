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
            DateTime d = DateTime.Today.AddDays(-1);
            Husholdning h = new Husholdning();
            Opskrift o = new Opskrift();
            Indkøb i = new Indkøb();
            Producent p = new Producent();
            List<Vare> produktKatalog = new List<Vare>();
            p.Varedannelse(@"C:\Users\Bilgram\Desktop\Program\MadspildP2\Produktkatalog.txt", produktKatalog);
            VareVægtMH v1 = new VareVægtMH("kulling");
            VareStkMH v2 = new VareStkMH("tomater");
            VareStkSA v3 = new VareStkSA("bacon");
            v1.MindstHoldbar = d;
            v2.MindstHoldbar = d;
            v3.SidsteAnvendelse = d.AddDays(10);
            v1.Vægt = 200;
            v2.Stk = 4;
            v3.Stk = 2;
            h.HusBeholdning.Add(v1);
            h.HusBeholdning.Add(v2);
            h.HusBeholdning.Add(v3);
            o.Indlæs();
            i.UdfraOpskrift(o.Opskrifter[1], h);
            i.TilføjTilHjemmeBeholdning(h.HusBeholdning, produktKatalog);
            Console.ReadKey();


            //h.SletGammelVare(d);
            //Producent p = new Producent();
            //List<Vare> l = new List<Vare>();
            //p.Varedannelse(@"C:\Users\Bilgram\Desktop\Program\MadspildP2\Produktkatalog.txt" , l);
            Console.ReadKey();
        }
    }
}
