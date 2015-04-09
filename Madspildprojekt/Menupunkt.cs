using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madspildprojekt
{
    class Menupunkt : Menu
    {
        public Menupunkt(string title) : base(title)
        {
        }

        public override void select()
        {
            Console.Clear();
            Console.WriteLine("Ged");
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
