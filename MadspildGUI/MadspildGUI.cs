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
       
        // Constructor
        public MadspildGUI()
        {
            InitializeComponent();
            
            // husholdning tab
            IndlaesVarerIHus();
            SletGamleVarerFraHus();

            // opskrifter tab
            if (listBoxOpskrifter.Items.Count == 0)
            {
                IndlaesOpskrifter();
            }

            // indkøb tab
            IndlaesIndkoebskurv();
        }

        private void MadspildGUI_Shown(object sender, EventArgs e)
        {
            OenskerBrugerAtSletteVare();
        }

        // Alle events og metoder, der omhandler husholdning tab
        #region Husholdningtab
        // Metode der indlæser varer i husholdningen fra tekstfil
        public void IndlaesVarerIHus()
        {
            h.HusBeholdning = h.IndlæsVarer("Husholdning.txt");
            ListBoxVarerIHus.Items.Clear();
            foreach (Vare v in h.HusBeholdning)
            {
                ListBoxVarerIHus.Items.Add(v._Navn);
            }
        }

        // Event der sker, når man dobbeltklikker på en vare i husholdningen
        // Viser information om den valgte varer
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

        // Event der sker, når man klikker på "Tilføj vare"-knappen
        // Åbner et nyt vindue, hvor man kan indtaste informationer om sin vare
        private void tilfoejVareKnap_Click(object sender, EventArgs e)
        {
            TilfoejVarePrompt tilfoejVare = new TilfoejVarePrompt();
            if (tilfoejVare.ShowDialog() == DialogResult.OK)
            {
                IndlaesVarerIHus();
            }
        }

        // Event der sker, når man klikker på "Slet vare"-knappen
        // Fjerner valgte vare fra listen af varer
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

        // Metode der spørger brugeren, om han vil slette mulige gamle varer
        private void OenskerBrugerAtSletteVare()
        {
            h.DatoAdvarsel(DateTime.Today);
            b.SkrivListeAfVarerTilFil("Husholdning.txt", h.HusBeholdning);
            IndlaesVarerIHus();
        }

        // Metode der sletter 30 dage gamle varer fra husholdningen
        private void SletGamleVarerFraHus()
        {
            h.SletGammelVare(DateTime.Today.AddDays(-30));
        }
        #endregion

        // Alle events og metoder, der omhandler opskrifter tab
        #region Opskriftertab
        // Metode der indlæser opskrifter fra tekstfiler
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
        
        // Event der sker, når man dobbeltklikker på en opskrift i listen
        // Viser information om valgt opskrift
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

        // Event der sker, når man klikker på "Foreslå husholdning"-knappen
        // Giver forslag ud fra hvad der er i husholdningen
        private void foreslaaOpskrifterEfterBeholdningKnap_Click(object sender, EventArgs e)
        {
            listBoxOpskriftInfo.Items.Clear();
            List<Opskrift> forslag = o.ForeslåEfterListe(h.HusBeholdning);
            o.Opskrifter = forslag;
            listBoxOpskrifter.Items.Clear();
            foreach (Opskrift op in forslag)
            {
                listBoxOpskrifter.Items.Add(op.retNavn);
            }
            opskrifterIGUI = forslag;
        }

        // Event der sker, når man klikker på "Tilføj opskrift"-knappen
        // Åbner vindue, hvor man kan indtaste sin opskrift
        private void tilfoejOpskriftKnap_Click(object sender, EventArgs e)
        {
            TilfoejOpskriftPrompt tilfoejOpskrift = new TilfoejOpskriftPrompt();
            if (tilfoejOpskrift.ShowDialog() == DialogResult.Yes)
            {
                IndlaesOpskrifter();
            }
        }

        // Event der sker, når man klikker på "Indkøb"-knappen
        // Tilføjer manglende varer til valgte opskrift til indkøbskurv
        private void TilføjOpskriftIngredienserTilIndkoebskurv_Click(object sender, EventArgs e)
        {
            if (listBoxOpskrifter.SelectedIndex == -1)
            {
                MessageBox.Show("Du skal markere en opskrift!");
            }
            else
            {
                i.UdfraOpskrift(o.Opskrifter[listBoxOpskrifter.SelectedIndex], h);
                IndlaesIndkoebskurv();
                MessageBox.Show("De manglende varer er blevet tilføjet til indkøbskurven");
            }
        }

        // Event der sker, når man klikker på "Lav opskrift"-knappen
        // Fjerner en opskrifts varer fra husholdningen
        private void OpskriftenErLavet_Click(object sender, EventArgs e)
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
            }
        }

        // Event der sker, når man klikker på "Vis opskrifter"-knappen
        // Viser alle opskrifter fra tekstfil i listen
        private void visOpskrifterKnap_Click(object sender, EventArgs e)
        {
            listBoxOpskriftInfo.Items.Clear();
            IndlaesOpskrifter();
        }

        // Event der sker, når man klikker på "Foreslå efter varer"-knappen
        // Åbner nyt vindue, hvor man kan indtaste varer man vil have med i sin opskrift
        // Giver forslag ud fra indtastede varer
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
                listBoxOpskriftInfo.Items.Clear();
            }
        }
        #endregion

        // Alle events og metoder, der omhandler indkøbskurv tab
        #region Indkøbtab
        // Metode der indlæser indkøbskurven
        public void IndlaesIndkoebskurv() // public da den skal kaldes fra den anden klasse
        {
            ListBoxIndkoeb.Items.Clear();
            foreach (Vare v in i.Indkøbskurv)
            {
                ListBoxIndkoeb.Items.Add(v._Navn);
            }
        }

        // Event der sker, når man dobbeltklikker på en vare i indkøbskurven
        // Viser volumen af valgte vare
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

        // Event der sker, når man klikker på "Tilføj til husbeholdning"-knappen
        // Tilføjer varer i indkøbskurven til husholdningen
        private void TiljoejTilBeholdningKnap_Click(object sender, EventArgs e)
        {
            Producent P = new Producent();
            List<Vare> Produktkatalog = P.indlaesProdukter("Produktkatalog.txt");
            if (ValidTilfoejTilHusbeholdning() == true)
            {
                i.TilføjTilHjemmeBeholdning(h.HusBeholdning, Produktkatalog);
                ListBoxIndkoeb.Items.Clear();
                h.SkrivListeAfVarerTilFil("Husholdning.txt", h.HusBeholdning);
                IndlaesVarerIHus();
            }
        }

        // Metode til at tjekke om brugeren ønsker at tilføje varer i indkøbskurven til husholdning
        private bool ValidTilfoejTilHusbeholdning()
        {
            if (MessageBox.Show("Er du sikker på at du ønsker at tilføje din indkøbskurv til husbeholdningen?", "Tilføj til husbeholdning", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return false;
            }
            return true;
        }

        // Event der sker, når man trykker på "Slet vare"-knappen
        // Sletter valgte vare fra indkøbskurven
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

        // Event der sker, når man klikker på "Tilføj vare"-knappen
        // Åbner nyt vindue, hvor man kan vælge varer fra produktkataloget
        private void TilfoejVareKnapIndkoeb_Click(object sender, EventArgs e)
        {
            IndkoebskurvPrompt indkoebskurvPrompt = new IndkoebskurvPrompt();
            if (indkoebskurvPrompt.ShowDialog() == DialogResult.OK)
            {
                ListBoxIndkoeb.Items.Clear();
                foreach (Vare v in indkoebskurvPrompt.MidlertidigIndkoebskurv)
                {
                    i.Indkøbskurv.Add(v);
                }
                foreach (Vare v in i.Indkøbskurv)
                {
                    ListBoxIndkoeb.Items.Add(v._Navn);
                }
            }
        }
        #endregion
    }
}
