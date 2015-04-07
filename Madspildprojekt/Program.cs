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
           /* Menu startmenu = new Menu("Startmenu");
            Menu beholdning = new Menu("Beholdning");
            Menu indkoeb = new Menu("Indkøb");
            Menu opskrifter = new Menu("Opskrifter");
            startmenu.addMenuItem(beholdning);
            startmenu.addMenuItem(indkoeb);
            startmenu.addMenuItem(opskrifter);
            startmenu.displayMenu();
            */
            Varer v = new Varer("title", 1337);
            v.Read_file_varer();
            v.Print_varer_list();
            Console.ReadKey();
        }

    }
}
