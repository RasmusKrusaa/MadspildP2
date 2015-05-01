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
        public Opskrift o = new Opskrift();
        public List<Opskrift> opskrifterIGUI = new List<Opskrift>();

        public MadspildGUI()
        {
            InitializeComponent();

            // husholdning tab
            IndlaesVarerIHus();
            SletGamleVarerFraHus();

            // opskrifter tab
            IndlaesOpskrifter();
        }

        // husholdningtab
        private void IndlaesVarerIHus()
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
                IndlaesVarerIHus();
            }
        }

        private void sletVareKnap_Click(object sender, EventArgs e)
        {
            if (ListBoxVarerIHus.SelectedIndex >= 0 && 
                ListBoxVarerIHus.SelectedIndex <= h.HusBeholdning.Count)
            {
                b.SletVare(h.HusBeholdning[ListBoxVarerIHus.SelectedIndex], h.HusBeholdning);
                b.SkrivListeAfVarerTilFil("Husholdning.txt", h.HusBeholdning);
                IndlaesVarerIHus();
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
            IndlaesVarerIHus();
        }

        private void SletGamleVarerFraHus()
        {
            h.SletGammelVare(DateTime.Today.AddDays(-30));
        }

        // opskriftertab
        private void IndlaesOpskrifter()
        {
            o.Indlæs("Opskrifter.txt");
            listBoxOpskrifter.Items.Clear();
            foreach (Opskrift op in o.Opskrifter)
            {
                listBoxOpskrifter.Items.Add(op.retNavn);
            }
            opskrifterIGUI = o.Opskrifter;
        }

        private void MadspildGUI_Shown(object sender, EventArgs e)
        {
            OenskerBrugerAtSletteVare();
        }

        private void listBoxOpskrifter_DoubleClick(object sender, EventArgs e)
        {
            listBoxOpskriftInfo.Items.Clear();
            if (listBoxOpskrifter.SelectedIndex <= opskrifterIGUI.Count &&
                listBoxOpskrifter.SelectedIndex >= 0)
            {
                listBoxOpskriftInfo.Items.Add("Ingredienser");
                for (int i = 0; i < opskrifterIGUI[listBoxOpskrifter.SelectedIndex].Ingredienser.Count; i++)
                {
                    listBoxOpskriftInfo.Items.Add(opskrifterIGUI[listBoxOpskrifter.SelectedIndex].Ingredienser[i].VareNavnOgVolumen());
                }
                listBoxOpskriftInfo.Items.Add("");
                listBoxOpskriftInfo.Items.Add("Instruktioner");
                for (int i = 0; i < opskrifterIGUI[listBoxOpskrifter.SelectedIndex].Instruktioner.Count; i++)
                {
                    listBoxOpskriftInfo.Items.Add(opskrifterIGUI[listBoxOpskrifter.SelectedIndex].Instruktioner[i]);
                }
            }
        }

        private void foreslaaOpskrifterEfterBeholdningKnap_Click(object sender, EventArgs e)
        {
            List<Opskrift> forslag = o.ForeslåEfterListe(h.HusBeholdning);
            listBoxOpskrifter.Items.Clear();
            foreach (Opskrift op in forslag)
            {
                listBoxOpskrifter.Items.Add(op.retNavn);
            }
            opskrifterIGUI = forslag;
        }
    }
}
