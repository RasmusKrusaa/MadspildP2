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

            if (ListBoxVarerIHus.Items.Count == 0)
            {
                indlaesVarerIHus();
            }
        }

        private void indlaesVarerIHus()
        {
            Husholdning h = new Husholdning();
            VarerIHus = h.IndlæsVarer("Husholdning.txt");
            ListBoxVarerIHus.Items.Clear();
            foreach (Vare v in VarerIHus)
            {
                ListBoxVarerIHus.Items.Add(v._Navn);
            }
        }

        private void ListBoxVarerIHus_DoubleClick(object sender, EventArgs e)
        {
            int antalVarer = VarerIHus.Count;
            if (ListBoxVarerIHus.SelectedIndex >= 0 &&
                ListBoxVarerIHus.SelectedIndex <= antalVarer)
            {
                MessageBox.Show(VarerIHus[ListBoxVarerIHus.SelectedIndex].ToString(),
                VarerIHus[ListBoxVarerIHus.SelectedIndex]._Navn);
            }

        }

        private void tilfoejVareKnap_Click(object sender, EventArgs e)
        {
            TilfoejVarePrompt tilfoejVare = new TilfoejVarePrompt();
            if (tilfoejVare.ShowDialog() == DialogResult.OK)
            {
                ListBoxVarerIHus.Items.Add(tilfoejVare.NyListboxVarerIHusItem);
                indlaesVarerIHus();
            }
        }

        private void sletVareKnap_Click(object sender, EventArgs e)
        {
            Beholdning b = new Beholdning();
            b.SletVare(VarerIHus[ListBoxVarerIHus.SelectedIndex], VarerIHus);
            b.SkrivListeAfVarerTilFil("Husholdning.txt", VarerIHus);
            indlaesVarerIHus();
        }
    }
}
