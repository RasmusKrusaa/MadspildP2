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
    public partial class TilfoejVarePrompt : Form
    {
        public TilfoejVarePrompt()
        {
            InitializeComponent();
        }

        private string nyListboxVarerIHusItem;

        public string NyListboxVarerIHusItem
        {
            get { return nyListboxVarerIHusItem; }
        }

        public void tilfoejKnap_Click(object sender, EventArgs e)
        {
            Beholdning b = new Beholdning();
            Husholdning h = new Husholdning();
            h.HusBeholdning = h.IndlæsVarer("Husholdning.txt");

            if (isValidVare())
            {
                if (vaegtKnap.Checked && mindstHoldbarKnap.Checked)
                {
                    VareVægtMH v = new VareVægtMH(navnBox.Text.ToLower());
                    v.Vægt = Convert.ToDecimal(volumenBox.Text);
                    v.MindstHoldbar = datoVaelger.Value.Date;
                    b.TilføjVare(v, h.HusBeholdning);
                    nyListboxVarerIHusItem = v._Navn;
                }
                else if (vaegtKnap.Checked && sidsteAnvKnap.Checked)
                {
                    VareVægtSA v = new VareVægtSA(navnBox.Text.ToLower());
                    v.Vægt = Convert.ToDecimal(volumenBox.Text);
                    v.SidsteAnvendelse = datoVaelger.Value.Date;
                    b.TilføjVare(v, h.HusBeholdning);
                    nyListboxVarerIHusItem = v._Navn;
                }
                else if (stkKnap.Checked && mindstHoldbarKnap.Checked)
                {
                    VareStkMH v = new VareStkMH(navnBox.Text.ToLower());
                    v.Stk = Convert.ToDecimal(volumenBox.Text);
                    v.MindstHoldbar = datoVaelger.Value.Date;
                    b.TilføjVare(v, h.HusBeholdning);
                    nyListboxVarerIHusItem = v._Navn;
                }
                else if (stkKnap.Checked && sidsteAnvKnap.Checked)
                {
                    VareStkSA v = new VareStkSA(navnBox.Text.ToLower());
                    v.Stk = Convert.ToDecimal(volumenBox.Text);
                    v.SidsteAnvendelse = datoVaelger.Value.Date;
                    b.TilføjVare(v, h.HusBeholdning);
                    nyListboxVarerIHusItem = v._Navn;
                }
                b.SkrivListeAfVarerTilFil("Husholdning.txt", h.HusBeholdning);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        
        private bool isValidVare()
        {
            Producent p = new Producent();
            List<Vare> produktkatalog = p.indlaesProdukter("Produktkatalog.txt");

            if (navnBox.Text == "Indtast varenavn" ||
                volumenBox.Text == "Indtast volumen" ||
                (!vaegtKnap.Checked && !stkKnap.Checked) ||
                (!sidsteAnvKnap.Checked && !mindstHoldbarKnap.Checked)
                )
            {
                MessageBox.Show("Det ser ud til, at du har glemt at udfylde nogle felter"
                    , "Manglende input", MessageBoxButtons.OK);
                return false;
            }
            foreach (Char c in volumenBox.Text)
            {
                if (!Char.IsDigit(c))
                {
                    MessageBox.Show("Du kan kun indtaste tal i volumenfeltet"
                    , "Forkert volumen", MessageBoxButtons.OK);
                    return false;
                }
            }
            if (datoVaelger.Value.Date == DateTime.Today.Date)
            {
                if (MessageBox.Show("Er du sikker på, at varen " + navnBox.Text + " kun kan holde sig til i dag?"
                    , "I dag?", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return false;
                }
                return true;
            }
            if (datoVaelger.Value.Date < DateTime.Today.Date)
            {
                MessageBox.Show("Du kan ikke vælge en dato før i dag!", "Forkert dato");
                return false;
            }

            bool findesVareIProduktkatalog = false;
            foreach (Vare v in produktkatalog)
            {
                if (v._Navn == navnBox.Text.ToLower())
                {
                    findesVareIProduktkatalog = true; 
                }
            }
            if (findesVareIProduktkatalog == false)
            {
                MessageBox.Show("Det indtastede varenavn findes ikke i produktkataloget", "Fejl i varenavn");
                return false;
            }
            return true;
        }
    }
}
