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
    public partial class IndkoebskurvPrompt : Form
    {
        Producent p = new Producent();
        private List<Vare> _midlertidigIndkoebskurv = new List<Vare>();
        private List<Vare> _produkter = new List<Vare>();
        
        public List<Vare> MidlertidigIndkoebskurv
        {
            get { return _midlertidigIndkoebskurv; }
        }
        
        // Constructor
        public IndkoebskurvPrompt()
        {
            InitializeComponent();
            IndlaesProduktkatalogIndkoeb();
        }

        // Metode til at indlæse alle produkter fra produktkataloget
        private void IndlaesProduktkatalogIndkoeb()
        {  
            List<Vare> produktkatalogindkoeb = p.indlaesProdukter("Produktkatalog.txt");         
            foreach (Vare v in produktkatalogindkoeb)
            {
                listBoxIndkoebProduktKatalog.Items.Add(v._Navn);
            }
        }
        
        // Event der sker, når man trykker på "Tilføj Vare"-knappen
        // Tilføjer til den midlertidige indkøbskurv
        private void IndkoebskurvTilfoejtilMidlertidigIndkoebskurv_Click(object sender, EventArgs e)
        {
            Producent p = new Producent();
            List<Vare> produktkatalog = p.indlaesProdukter("Produktkatalog.txt");
            if (textBox1.Text == "Søg")
            {
                _midlertidigIndkoebskurv.Add(produktkatalog[listBoxIndkoebProduktKatalog.SelectedIndex] as Vare);
                listBoxIndkoebIndkoebskurv.Items.Add(produktkatalog[listBoxIndkoebProduktKatalog.SelectedIndex]._Navn);  
            }
            else
            {
                _midlertidigIndkoebskurv.Add(_produkter[listBoxIndkoebProduktKatalog.SelectedIndex]);
                listBoxIndkoebIndkoebskurv.Items.Add(_produkter[listBoxIndkoebProduktKatalog.SelectedIndex]._Navn);
            } 
        }

        // Event der sker, når man trykker på "Slet Vare"-knappen
        // Sletter vare fra den midlertidige indkøbskurv
        private void IndkoebskurvSletVareMidlertidigIndkoebskurv_Click(object sender, EventArgs e)
        {
            if (listBoxIndkoebIndkoebskurv.SelectedIndex != -1)
            {
                MidlertidigIndkoebskurv.Remove(MidlertidigIndkoebskurv[listBoxIndkoebIndkoebskurv.SelectedIndex]);
                listBoxIndkoebIndkoebskurv.Items.RemoveAt(listBoxIndkoebIndkoebskurv.SelectedIndex);
            }
        }

        // Event der sker, når man trykker på "Tilføj til husholdning"-knappen
        // Lukker vinduet og sætter DialogResult til OK
        private void TilføjTilIndkoebskurv_Click(object sender, EventArgs e)
        {               
            DialogResult = DialogResult.OK;
            Close();
        }
        
        // Event der sker, når man ændrer teksten i søgefeltet
        // Opdaterer listen til alle de varer der indeholder søgeordet
        private void textBox1_TextChanged(object sender, EventArgs e)
        {    
            List<Vare> produktkatalogindkoeb = p.indlaesProdukter("Produktkatalog.txt");
            textBox1.ForeColor = Color.Black;
            listBoxIndkoebProduktKatalog.Items.Clear();
            _produkter.Clear();
            foreach (Vare v in produktkatalogindkoeb)
            {
                if (v._Navn.Contains(textBox1.Text))
                {
                    _produkter.Add(v);
                    listBoxIndkoebProduktKatalog.Items.Add(v._Navn);
                }
            }
        }
        
        // Event der sker, når man sætter cursoren i søgefeltet
        private void textBox1_TextEnter(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }
    }
}
