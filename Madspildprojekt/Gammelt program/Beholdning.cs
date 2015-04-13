using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Madspildprojekt
{
    class Beholdning : Menu
    {
        public List<Vare> Beholdningsliste = new List<Vare>();
        public Beholdning(string title) : base(title)
        {
        }

        public void Read_file_beholdning()
        {
            foreach (string line in File.ReadAllLines(@"C:\\Users\\Bilgram\\Desktop\\Program\\MadspildP2\\Beholdning.txt"))
            {
                
                string[] Varer_str = line.Split(' ');
                Vare v = new Vare(Varer_str[0], decimal.Parse(Varer_str[1]));
                Beholdningsliste.Add(v);
            }
        }
        public override void select()
        {
            foreach (Vare v in Beholdningsliste)
            {
                Menupunkt mp = new Menupunkt("" + v._Navn); 
                menuItems.Add(mp);
            }
            stack.Push(this);
            displayMenu();
        }
    }
}
