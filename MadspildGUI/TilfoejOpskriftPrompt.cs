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

        public string retNavn
        {
            get { return retNavnBox.Text; }
        }

        private void tilfoejKnap_Click(object sender, EventArgs e)
        {
            string filnavn = "Opskrifter.txt";
            Opskrift o = new Opskrift();
            string[] ingredienser = new string[ingrediensVolumenBox.Lines.Length];
            string[] instruktioner = instruktionerBox.Lines;
            string[] ingredienserVolumen = ingrediensVolumenBox.Lines;

            if (isChangedAlleBokse())
            {
                for (int linje = 0; linje < ingrediensVolumenBox.Lines.Length; linje++)
                {
                    string[] str = ingrediensVolumenBox.Lines[linje].Split(' ');
                    if (str.Length == 2)
                    {
                        ingredienserVolumen[linje] = str[0] + "_" + str[1];
                    }
                    else if (str.Length > 2)
                    {
                        MessageBox.Show("Du har indtastet forkert i volumenboksen! Skriv fx 450 g", "Fejl");
                    }
                }
                if (ingrediensNavnBox.Lines.Length == ingrediensVolumenBox.Lines.Length)
                {
                    if (isValidIngrediensVolumen() && isValidIngrediensNavn())
                    {
                        for (int linje = 0; linje < ingrediensVolumenBox.Lines.Length; linje++)
                        {
                            ingredienser[linje] = ingredienserVolumen[linje] + "_" + ingrediensNavnBox.Lines[linje];
                        }
                        if (MessageBox.Show("Er du sikker på, at du vil tilføje " + retNavnBox.Text + " til opskrifter?",
                            "Tilføj opskrift?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            DialogResult = DialogResult.Yes;
                            o.TilføjOpskriftTilFil(retNavnBox.Text, ingredienser, instruktioner, filnavn);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Der er ikke samme antal ingrediensnavne som ingrediensvolumener", "Fejl");
                }
            }
        }

        private bool isValidIngrediensVolumen()
        {
            for (int linje = 0; linje < ingrediensVolumenBox.Lines.Length; linje++)
            {
                if (ingrediensVolumenBox.Lines[linje].Length > 1)
                {
                    char sidsteChar = ingrediensVolumenBox.Lines[linje][ingrediensVolumenBox.Lines[linje].Length - 1];
                    char andenSidsteChar = ingrediensVolumenBox.Lines[linje][ingrediensVolumenBox.Lines[linje].Length - 2];
                    if (sidsteChar == 'g' && andenSidsteChar != ' ')
                    {
                        MessageBox.Show("Der skal være mellemrum mellem volumen og g! Fx 450 g", "Fejl");
                        return false;
                    }
                }
                if (!Char.IsDigit(ingrediensVolumenBox.Lines[linje][0]))
                {
                    MessageBox.Show("Skriv først antal styk eller vægt i volumenboksen!", "Fejl");
                    return false;
                }
                foreach (char c in ingrediensVolumenBox.Lines[linje])
                {
                    if (char.IsLetter(c) && c != 'g')
                    {
                        MessageBox.Show("Det eneste bogstav, du kan skrive i volumenboksen er 'g' for gram!", "Fejl");
                        return false;
                    }
                }
            }
            return true;
        }

        private bool isValidIngrediensNavn()
        {
            Producent p = new Producent();
            List<Vare> produktkatalog = p.indlaesProdukter("Produktkatalog.txt");

            bool findesVareIProduktkatalog = false;
            foreach (Vare v in produktkatalog)
            {
                for (int linje = 0; linje < ingrediensNavnBox.Lines.Length; linje++)
                {
                    if (v._Navn == ingrediensNavnBox.Lines[linje])
                    {
                        findesVareIProduktkatalog = true;
                    }
                }
            }
            if (findesVareIProduktkatalog == false)
            {
                MessageBox.Show("Et af de indtastede varenavne findes ikke i produktkataloget", "Fejl i varenavn");
                return false;
            }
            return true;
        }

        private bool isChangedAlleBokse()
        {
            if (retNavnBox.Text == "Indtast rettens navn" ||
                ingrediensNavnBox.Text == "Indtast ingrediensers volumen\n(1 per linje)\nfx 450 g" ||
                ingrediensVolumenBox.Text == "Indtast ingrediensers navn\n(1 per linje)\nfx hakket oksekød" ||
                instruktionerBox.Text == "Indtast instruktioner (1 per linje)") 
            {
                MessageBox.Show("Det ser ud til, at du har glemt at udfylde nogle felter", "Fejl");
                return false;
            }
            return true;
        }
    }
}
