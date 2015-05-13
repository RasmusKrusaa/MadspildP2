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


            if (ListBoxVarerIHus.Items.Count == 0)
            {
                IndlaesVarerIHus();
            }

            IndlaesIndkoebskurv();
            // husholdning tab
            IndlaesVarerIHus();
            SletGamleVarerFraHus();

            // opskrifter tab
            if (listBoxOpskrifter.Items.Count == 0)
            {
                IndlaesOpskrifter();
            }
        }

        // husholdningtab
        public void IndlaesVarerIHus()
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
        private void IndlaesIndkoebskurv()
        {
            VareStkMH v = new VareStkMH("Gris");
            v.MindstHoldbar = DateTime.Today;
            v.Stk = 2;

            VareVægtSA v1 = new VareVægtSA("Nakkeost");
            v1.SidsteAnvendelse = DateTime.Today;
            v1.Vægt = 200;

            Indkoebskurv.Add(v);
            Indkoebskurv.Add(v1);

            ListBoxIndkoeb.Items.Add(v._Navn);
            ListBoxIndkoeb.Items.Add(v1._Navn);
        }

        private void ListBoxIndkoeb_Doubleclick(object sender, EventArgs e)
        {
            int antalVarer = Indkoebskurv.Count;
            if (ListBoxIndkoeb.SelectedIndex >= 0 &&
                ListBoxIndkoeb.SelectedIndex <= antalVarer)
            {
                MessageBox.Show(Indkoebskurv[ListBoxIndkoeb.SelectedIndex].ToString(),
                Indkoebskurv[ListBoxIndkoeb.SelectedIndex]._Navn);
            }
        }

        private void TiljoejTilBeholdningKnap_Click(object sender, EventArgs e)
        {
            //Indkøb i = new Indkøb();
            //Producent p = new Producent();
            //List<Vare> produktkatalog = new List<Vare>();
            //p.Varedannelse("Produktkatalog.txt", produktkatalog);

            bool temp = false;
            temp = ValidTilfoejTilHusbeholdning();

            if (temp == true)
            {
                foreach (Vare v in Indkoebskurv)
                {
                    //VarerIHus.Add(v);
                    ListBoxVarerIHus.Items.Add(v._Navn);
                }

            }
        }
        private bool ValidTilfoejTilHusbeholdning()
        {
            if(MessageBox.Show("Er du sikker på at du ønsker at tilføje din indkøbskurv til husbeholdningen?", "Tilføj til husbeholdning" , MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return false;
            }
            return true;
        }

        private void SletVareKnapIndkoeb_Click(object sender, EventArgs e)
        {
            Indkøb i = new Indkøb();
            ListBoxIndkoeb.Items.Remove(ListBoxIndkoeb.SelectedIndex);
            IndlaesIndkoebskurv();
        }

        private void tilfoejOpskriftKnap_Click(object sender, EventArgs e)
        {
            TilfoejOpskriftPrompt tilfoejOpskrift = new TilfoejOpskriftPrompt();
            if (tilfoejOpskrift.ShowDialog() == DialogResult.Yes)
            {
                IndlaesOpskrifter();
            }
        }

        private void TilfoejVareKnapIndkoeb_Click(object sender, EventArgs e)
        {
            IndkoebskurvPrompt indkoebskurvPrompt = new IndkoebskurvPrompt();
            indkoebskurvPrompt.Show();
        }

        private void visOpskrifterKnap_Click(object sender, EventArgs e)
        {
            IndlaesOpskrifter();
        }

        private void foreslaaEfterVarerKnap_Click(object sender, EventArgs e)
        {
            ForeslaaEfterVarerPrompt foreslaaPrompt = new ForeslaaEfterVarerPrompt();
            if (foreslaaPrompt.ShowDialog() == DialogResult.OK)
            {
                opskrifterIGUI = foreslaaPrompt.Forslag;
                listBoxOpskrifter.Items.Clear();
                foreach (Opskrift op in foreslaaPrompt.Forslag)
                {
                    listBoxOpskrifter.Items.Add(op.retNavn);
                }
            }
        }
    }
}
