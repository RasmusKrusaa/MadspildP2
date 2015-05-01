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
        public Husholdning h = new Husholdning();
        public Beholdning b = new Beholdning();

        public MadspildGUI()
        {
            InitializeComponent();

            indlaesVarerIHus();

            SletGamleVarerFraHus();
        }

        private void indlaesVarerIHus()
        {
            h.HusBeholdning = h.IndlæsVarer("Husholdning.txt");
            ListBoxVarerIHus.Items.Clear();
            foreach (Vare v in h.HusBeholdning)
            {
                ListBoxVarerIHus.Items.Add(v._Navn);
            }
        }

        private void ListBoxVarerIHus_DoubleClick(object sender, EventArgs e)
        {
            int antalVarer = h.HusBeholdning.Count;
            if (ListBoxVarerIHus.SelectedIndex >= 0 &&
                ListBoxVarerIHus.SelectedIndex <= antalVarer)
            {
                MessageBox.Show(h.HusBeholdning[ListBoxVarerIHus.SelectedIndex].ToString(),
                h.HusBeholdning[ListBoxVarerIHus.SelectedIndex]._Navn);
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
            if (ListBoxVarerIHus.SelectedIndex >= 0 && 
                ListBoxVarerIHus.SelectedIndex <= h.HusBeholdning.Count)
            {
                b.SletVare(h.HusBeholdning[ListBoxVarerIHus.SelectedIndex], h.HusBeholdning);
                b.SkrivListeAfVarerTilFil("Husholdning.txt", h.HusBeholdning);
                indlaesVarerIHus();
            }
            else
            {
                MessageBox.Show("Markér venligst den vare, du ønsker at slette.", "Markér en vare");
            }
        }

        private void OenskerBrugerAtSletteVare()
        {
            h.DatoAdvarsel(DateTime.Today);
            b.SkrivListeAfVarerTilFil("Husholdning.txt", h.HusBeholdning);
            indlaesVarerIHus();
        }

        private void SletGamleVarerFraHus()
        {
            h.SletGammelVare(DateTime.Today.AddDays(-30));
        }

        private void MadspildGUI_Shown(object sender, EventArgs e)
        {
            OenskerBrugerAtSletteVare();
        }
    }
}
