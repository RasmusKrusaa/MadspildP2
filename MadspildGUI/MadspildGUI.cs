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

            IndlaesIndkoebskurv();
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
                    VarerIHus.Add(v);
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
    }
}