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
    public partial class TilfoejOpskriftPrompt : Form
    {
        public TilfoejOpskriftPrompt()
        {
            InitializeComponent();
        }

        private void tilfoejKnap_Click(object sender, EventArgs e)
        {
            Opskrift o = new Opskrift();
            string[] ingredienser = new string[ingrediensVolumenBox.Lines.Length];
            string[] instruktioner = instruktionerBox.Lines;
            string[] ingredienserVolumen = ingrediensVolumenBox.Lines;
 
            for (int linje = 0; linje < ingrediensVolumenBox.Lines.Length; linje++)
            {
                string[] str = ingrediensVolumenBox.Lines[linje].Split(' ');
                if (str.Length == 2)
                {
                    ingredienserVolumen[linje] = str[0] + "_" + str[1];
                }
                else if (str.Length > 2)
                {
                    MessageBox.Show("Det ser ud til at du har tilføjet mellemrum efter en ingrediensvolumen", "Fejl");
                }
            }

            if (ingrediensNavnBox.Lines.Length == ingrediensVolumenBox.Lines.Length)
            {
                for (int linje = 0; linje < ingrediensVolumenBox.Lines.Length; linje++)
                {
                    ingredienser[linje] = ingredienserVolumen[linje] + "_" + ingrediensNavnBox.Lines[linje];
                }

            o.TilføjOpskriftTilFil(retNavnBox.Text, ingredienser, instruktioner);
            }
            else
            {
                MessageBox.Show("Der er ikke samme antal ingrediensnavne som ingrediensvolumener", "Fejl");
            }
        }   
    }
}
