using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madspildprojekt
{
    public class Program
    {
        static void Main(string[] args)
        {
            Varer Porrer = new Varer("porrer", 3, 200.5);
            Console.WriteLine("Du har tilføjet {0} stk. {1}, som vejer {2}g.", 
                Porrer._Stk, Porrer._Navn, Porrer._Vaegt);
            Console.ReadKey();
        }
    }
}
