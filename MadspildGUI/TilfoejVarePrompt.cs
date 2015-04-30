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
        public TilfoejVarePrompt(MadspildGUI main)
        {
            InitializeComponent();
            MadspildGUI m = main;
        }

        public void tilfoejKnap_Click(object sender, EventArgs e)
        {
            Beholdning b = new Beholdning();
            MadspildGUI m = new MadspildGUI();
            
            if (isValidVare())
            {
                if (vaegtKnap.Checked && mindstHoldbarKnap.Checked)
                {
                    VareVægtMH v = new VareVægtMH(navnBox.Text);
                    v.Vægt = Convert.ToDecimal(volumenBox.Text);
                    v.MindstHoldbar = datoVaelger.Value.Date;
                    b.TilføjVare(v, m.VarerIHus);
                }
                else if (vaegtKnap.Checked && sidsteAnvKnap.Checked)
                {
                    VareVægtSA v = new VareVægtSA(navnBox.Text);
                    v.Vægt = Convert.ToDecimal(volumenBox.Text);
                    v.SidsteAnvendelse = datoVaelger.Value.Date;
                    b.TilføjVare(v, m.VarerIHus);
                }
                else if (stkKnap.Checked && mindstHoldbarKnap.Checked)
                {
                    VareStkMH v = new VareStkMH(navnBox.Text);
                    v.Stk = Convert.ToDecimal(volumenBox.Text);
                    v.MindstHoldbar = datoVaelger.Value.Date;
                    b.TilføjVare(v, m.VarerIHus);
                }
                else if (stkKnap.Checked && sidsteAnvKnap.Checked)
                {
                    VareStkSA v = new VareStkSA(navnBox.Text);
                    v.Stk = Convert.ToDecimal(volumenBox.Text);
                    v.SidsteAnvendelse = datoVaelger.Value.Date;
                    b.TilføjVare(v, m.VarerIHus);
                }
                b.SkrivListeAfVarerTilFil("Husholdning.txt", m.VarerIHus);
                m.ListBoxVarerIHus.Items.Add("Hej");
                Close();
            }
        }

        private bool isValidVare()
        {
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
            return true;
        }
    }
}
