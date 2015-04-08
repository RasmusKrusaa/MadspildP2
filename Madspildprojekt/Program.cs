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
            Vareliste Vl = new Vareliste();
            Vl.Read_file_vareliste();
            Beholdning Bl = new Beholdning("Beholdning");
            Bl.Read_file_beholdning();

            Menu startmenu = new Menu("Startmenu");
            Menu indkoeb = new Menu("Indkøb");
            Menu opskrifter = new Menu("Opskrifter");
            startmenu.addMenuItem(indkoeb);
            startmenu.addMenuItem(opskrifter);
            startmenu.addMenuItem(Bl);
            startmenu.displayMenu();
        }
    }
}
