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
    public partial class ForeslaaEfterVarerPrompt : Form
    {
        private List<Opskrift> _forslag;

        public List<Opskrift> Forslag
        {
            get { return _forslag; }
        }
        
        // Constructor
        public ForeslaaEfterVarerPrompt()
        {
            InitializeComponent();
        }

        // Event der sker, når man trykker på Giv Forslag knappen
        // Giver forslag ud fra indtastede varenavne
        private void givForslagKnap_Click(object sender, EventArgs e)
        {
            string[] vareNavne = vareBox.Lines;
            Opskrift o = new Opskrift();
            o.Indlæs("Opskrifter.txt");
            if (findesVarenavniProduktkatalog())
            {
               _forslag = o.ForeslåEfterVarer(vareNavne); 
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("De(t) indtastede varenavn(e) findes ikke i produktkataloget");
            }
        }

        // Metode til at tjekke om varenavn findes i produktkatalog
        private bool findesVarenavniProduktkatalog()
        {
            List<Vare> produktkatalog = new List<Vare>();
            Producent p = new Producent();
            produktkatalog = p.indlaesProdukter("Produktkatalog.txt");
            foreach (Vare v in produktkatalog)
            {
                for (int linje = 0; linje < vareBox.Lines.Length; linje++)
                {
                    if (vareBox.Lines[linje] == v._Navn)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
