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
        public Indkøb i = new Indkøb();
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
            o.Opskrifter = forslag;
            listBoxOpskrifter.Items.Clear();
            foreach (Opskrift op in forslag)
            {
                listBoxOpskrifter.Items.Add(op.retNavn);
            }
            opskrifterIGUI = forslag;
        }
        public void IndlaesIndkoebskurv() // public da den skal kaldes fra den anden klasse
        {
            ListBoxIndkoeb.Items.Clear();
            foreach (Vare v in i.Indkøbskurv)
            {
                ListBoxIndkoeb.Items.Add(v._Navn);
            }
        }

        private void ListBoxIndkoeb_Doubleclick(object sender, EventArgs e)
        {
            int antalVarer = i.Indkøbskurv.Count;
            if (ListBoxIndkoeb.SelectedIndex >= 0 &&
                ListBoxIndkoeb.SelectedIndex <= antalVarer)
            {
                if (i.Indkøbskurv[ListBoxIndkoeb.SelectedIndex] is VareStkMH || i.Indkøbskurv[ListBoxIndkoeb.SelectedIndex] is VareStkSA)
                {
                    MessageBox.Show("Stk: " + i.Indkøbskurv[ListBoxIndkoeb.SelectedIndex].VolumenTjek().ToString(),
                    i.Indkøbskurv[ListBoxIndkoeb.SelectedIndex]._Navn);
                }
                else if (i.Indkøbskurv[ListBoxIndkoeb.SelectedIndex] is VareVægtMH || i.Indkøbskurv[ListBoxIndkoeb.SelectedIndex] is VareVægtSA)
                {
                    MessageBox.Show("Vægt: " + i.Indkøbskurv[ListBoxIndkoeb.SelectedIndex].VolumenTjek().ToString() + "g",
                    i.Indkøbskurv[ListBoxIndkoeb.SelectedIndex]._Navn);
                }
                
            }
        }

        private void TiljoejTilBeholdningKnap_Click(object sender, EventArgs e)
        {
            bool temp = false;
            temp = ValidTilfoejTilHusbeholdning();
            Producent P = new Producent();
            List<Vare> Produktkatalog = P.indlaesProdukter("Produktkatalog.txt");
            if (temp == true)
            {
                i.TilføjTilHjemmeBeholdning(h.HusBeholdning,Produktkatalog);
                ListBoxIndkoeb.Items.Clear();
                h.SkrivListeAfVarerTilFil("Husholdning.txt", h.HusBeholdning);
                IndlaesVarerIHus();
                //foreach (Vare v in i.Indkøbskurv)
                //{
                //    h.HusBeholdning.Add(v);
                //    ListBoxVarerIHus.Items.Add(v._Navn);
                //    ListBoxIndkoeb.Items.Clear();
                //}
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
            if (ListBoxIndkoeb.SelectedIndex >= 0 &&
                ListBoxIndkoeb.SelectedIndex <= i.Indkøbskurv.Count)
            {
                ListBoxIndkoeb.Items.Remove(ListBoxIndkoeb.SelectedIndex);
                i.Indkøbskurv.Remove(i.Indkøbskurv[ListBoxIndkoeb.SelectedIndex]);
                IndlaesIndkoebskurv();
            }
            else
            {
                MessageBox.Show("Markér venligst den vare, du ønsker at slette.", "Markér en vare");
            }
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
            if (indkoebskurvPrompt.ShowDialog() == DialogResult.OK)
            {
                ListBoxIndkoeb.Items.Clear();
                foreach (Vare v in indkoebskurvPrompt.PropMidlertidigIndkoebskurv)
                {
                    i.Indkøbskurv.Add(v);                    
                }
                foreach (Vare v in i.Indkøbskurv)
                {
                    ListBoxIndkoeb.Items.Add(v._Navn);
                }
            }
        }

        private void ListBoxIndkoeb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ListBoxVarerIHus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tilføj_Opskrifts_Ingredienser_Til_Inkoebskurv_Click(object sender, EventArgs e)
        {
            if (listBoxOpskrifter.SelectedIndex == -1)
            {
                MessageBox.Show("Du skal markere en opskrift!");
            }
            else
	        {
                i.UdfraOpskrift(o.Opskrifter[listBoxOpskrifter.SelectedIndex], h);
                IndlaesIndkoebskurv();
                MessageBox.Show("De manglende varer er blevet tilføjet til inkøbskurven");
            }
        }

        private void funktionsKnapperOpskrifter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Opskriften_Er_Lavet_Click(object sender, EventArgs e)
        {
            if (listBoxOpskrifter.SelectedIndex == -1)
            {
                MessageBox.Show("Du skal markere en ret før du laver den!");
            }
            else
            {
                bool k = true;
                k = h.SletVareUdFraOpskrift(o.Opskrifter[listBoxOpskrifter.SelectedIndex], "Husholdning.txt");
                IndlaesVarerIHus();
                if (k == true)
                {
                    MessageBox.Show("Du har lavet retten " + o.Opskrifter[listBoxOpskrifter.SelectedIndex].retNavn + " og ingredienserne er fjernet fra beholdningen");
                }
                else
                {
                    MessageBox.Show("Du har ikke nok varer til at lave " + o.Opskrifter[listBoxOpskrifter.SelectedIndex].retNavn);
                }
                IndlaesOpskrifter();
            }

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
                o.Opskrifter = foreslaaPrompt.Forslag;
                listBoxOpskrifter.Items.Clear();
                foreach (Opskrift op in foreslaaPrompt.Forslag)
                {
                    listBoxOpskrifter.Items.Add(op.retNavn);
                }
            }
        }

        private void MadspildGUI_Load(object sender, EventArgs e)
        {

        }

        private void listBoxOpskrifter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
