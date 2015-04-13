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
            //VareVægtSA v = new VareVægtSA("bacon", 5.9m);
            //v.Vægt = 2.3m;
            //v.SidsteAnvendelse = 5;
            //Console.WriteLine(v._Navn + " " + v.Vægt + " " + v._Pris + " " + v.SidsteAnvendelse);
            Beholdning b = new Beholdning();
            b.VareTilføjelse();
            b.TilføjVare("VareVægtMH", "Kylling", 50.5m, 200m, 10);
            b.SorterBeholdning();
            Console.ReadKey();
        }
    }
}
