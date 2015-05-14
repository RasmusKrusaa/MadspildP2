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
        private List<Vare> MidlertidigIndkoebskurv = new List<Vare>();
        
        public List<Vare> PropMidlertidigIndkoebskurv
        {
            get { return MidlertidigIndkoebskurv; }
            set { MidlertidigIndkoebskurv = value; }
        }
        
        public IndkoebskurvPrompt()
        {
            InitializeComponent();
            indlaesproduktkatalogIindkoeb();
        }

        private void indlaesproduktkatalogIindkoeb()
        {  
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
            Producent p = new Producent();
            List<Vare> produktkatalogindkoeb = p.indlaesProdukter("Produktkatalog.txt");
            PropMidlertidigIndkoebskurv.Add(listBoxIndkoebProduktKatalog.SelectedItem as Vare);
            listBoxIndkoebIndkoebskurv.Items.Add(PropMidlertidigIndkoebskurv[listBoxIndkoebProduktKatalog.SelectedIndex]._Navn);
        }

        private void listBoxIndkoebIndkoebskurv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InkoebskurvSletVareMidlertidigIndkoebskurv_Click(object sender, EventArgs e)
        {
            if (listBoxIndkoebIndkoebskurv.SelectedIndex != -1)
            {
                PropMidlertidigIndkoebskurv.Remove(PropMidlertidigIndkoebskurv[listBoxIndkoebIndkoebskurv.SelectedIndex]);
                listBoxIndkoebIndkoebskurv.Items.RemoveAt(listBoxIndkoebIndkoebskurv.SelectedIndex);
            }
        }

        private void TilføjTilInkoebskruv_Click(object sender, EventArgs e)
        {               
            DialogResult = DialogResult.OK;
            Close();
        }

        private void listBoxIndkoebProduktKatalog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {    
            List<Vare> produktkatalogindkoeb = p.indlaesProdukter("Produktkatalog.txt");
            textBox1.ForeColor = Color.Black;
            listBoxIndkoebProduktKatalog.Items.Clear();
            PropMidlertidigIndkoebskurv.Clear();
            foreach (Vare V in produktkatalogindkoeb)
            {
                if (V._Navn.Contains(textBox1.Text))
                {
                    PropMidlertidigIndkoebskurv.Add(V);
                    listBoxIndkoebProduktKatalog.Items.Add(V._Navn);
                }
            }
        }
        private void textBox1_TextEnter(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;

        }
        private void textBox1_TextLeave(object sender, EventArgs e)
        {
            //indlaesproduktkatalogIindkoeb();
        }
    }
}
