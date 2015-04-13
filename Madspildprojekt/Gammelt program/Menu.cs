using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madspildprojekt
{
    public class Menu : IMenuItem
    {
        protected string _Title;
        protected int _Selected;
        public Menu(string title)
        {
            _Title = title;
            _Selected = 1;
        }
        protected List<IMenuItem> menuItems = new List<IMenuItem>();
        
        public void addMenuItem(IMenuItem menu)
        {
            menuItems.Add(menu);
        }
        public void drawMenu(int selected)
        {
            Console.Clear();
            Console.Title = Title;
            int i = 1;
            foreach (IMenuItem m in menuItems)
            {
                Console.Write("{0}: {1}", i, m.Title);
                if (i == selected)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                i++;
            }
        }

        public void displayMenu()
        {
            if (stack.Count == 0)
                stack.Push(this);

            do
            {
                Menu currentMenu = stack.Peek();
                currentMenu.drawMenu(_Selected);
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("");
                }
                Console.WriteLine("Navigate through the menu with Up- and Downarrow."
                    + Environment.NewLine +
                    "Press Enter to enter a menu."
                    + Environment.NewLine +
                    "Press backspace to go back."
                    + Environment.NewLine +
                    "Press Escape to exit the program.");
                Console.CursorVisible = false;
                ConsoleKeyInfo KeyPressed = Console.ReadKey();
                if (KeyPressed.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                else
                {
                    switch (KeyPressed.Key)
                    {
                        case ConsoleKey.DownArrow:
                            if (_Selected == currentMenu.menuItems.Count)
                            {
                                _Selected = 1;
                            }
                            else
                            {
                                _Selected += 1;
                            }
                            break;
                        case ConsoleKey.UpArrow:
                            if (_Selected == 1)
                            {
                                _Selected = currentMenu.menuItems.Count;
                            }
                            else
                            {
                                _Selected -= 1;
                            }
                            break;
                        case ConsoleKey.Enter:
                            currentMenu.menuItems.ElementAt(_Selected - 1).select();
                            _Selected = 1;
                            break;
                        case ConsoleKey.Backspace:
                            stack.Pop();
                            _Selected = 1;
                            break;
                    }
                }
            } while (stack.Count > 0);
        }
        public string Title
        {
            get { return _Title; }
        }
        protected static Stack<Menu> stack = new Stack<Menu>();
        public virtual void select()
        {
            stack.Push(this);
        }
    } 
       
}
