using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadspildGUI
{
    public partial class MadspildGUI : Form
    {   
        public MadspildGUI()
        {
            InitializeComponent();

            addMenu();
        }

        void beholdning_Click(object sender, EventArgs e)
        {
        }

        void opskrifter_Click(object sender, EventArgs e)
        {
            Opskrift o = new Opskrift();
            o.Indlæs("Opskrifter.txt");
            ListBox opskrifter = new ListBox();

            foreach (Opskrift opskrift in o.Opskrifter)
            {
                opskrifter.Items.Add(opskrift);
            }
            
            Controls.Add(opskrifter);
        }

        void addMenu()
        {
            MenuStrip menu = new MenuStrip();
            menu.Dock = DockStyle.Top;
            ToolStripMenuItem indkøbskurv = new ToolStripMenuItem();
            menu.Items.Add(indkøbskurv);
            indkøbskurv.Text = "Indkøbskurv";
            ToolStripMenuItem beholdning = new ToolStripMenuItem();
            menu.Items.Add(beholdning);
            beholdning.Text = "Beholdning";
            ToolStripMenuItem opskrifter = new ToolStripMenuItem();
            menu.Items.Add(opskrifter);
            opskrifter.Text = "Opskrifter";

            Controls.Add(menu);
        }
    }
}
