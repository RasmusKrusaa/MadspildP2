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
        public IndkoebskurvPrompt()
        {
            InitializeComponent();
            indlaesproduktkatalogIindkoeb();
        }

        private void indlaesproduktkatalogIindkoeb()
        {
            Producent p = new Producent();
            List<Vare> produktkatalogindkoeb = p.indlaesProdukter("Produktkatalog.txt");
            foreach (Vare v in produktkatalogindkoeb)
            {
                listBoxIndkoebProduktKatalog.Items.Add(v._Navn);
            }
        }
            //        Beholdning b = new Beholdning(); 
        // Produktkatalog
            //Husholdning h = new Husholdning();
        //list
            //h.HusBeholdning = h.IndlæsVarer("Husholdning.txt");
        
        private void IndkoebskurvTilfoejtilMidlertidigIndkoebskurv_Click(object sender, EventArgs e)
        {
            List<Vare> ML = new List<Vare>();
            Producent p = new Producent();
            List<Vare> produktkatalogindkoeb = p.indlaesProdukter("Produktkatalog.txt");
            ML.Add(produktkatalogindkoeb[listBoxIndkoebProduktKatalog.SelectedIndex]);
            listBoxIndkoebIndkoebskurv.Items.Add(ML[0]._Navn);
        //    return ML;
        //Skal til hjælpe funktion
        
        }
    }
}
