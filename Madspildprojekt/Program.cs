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
            Indkøb i = new Indkøb();
            VareVægtMH V = new VareVægtMH("kylling");
            V.Vægt = 23m;
            //i.VolumenTjek(V);
            Husholdning H = new Husholdning();

            Console.ReadKey();
        }
    }
}
