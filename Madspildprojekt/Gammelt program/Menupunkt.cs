using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madspildprojekt
{
    class Menupunkt : Menu
    {
        public Menupunkt(string title)
            : base(title)
        {
        }

        public override void select()
        {
            Console.Clear();
            Console.Title = _Title;

            //Beholdning b = new Beholdning(_Title);
            //b.Read_file_beholdning();
            //int i = b.Beholdningsliste.IndexOf(b);
            //Console.WriteLine("{0}", b.Beholdningsliste.ElementAt(i)._Pris);
            Console.WriteLine("ged");

            Console.CursorVisible = false;
            ConsoleKeyInfo KeyPressed = Console.ReadKey();
            if (KeyPressed.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            else if (KeyPressed.Key == ConsoleKey.Backspace)
            {
                displayMenu();
            }
        }
    }
}
