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
            Producent p = new Producent();
            int MICount = 0;
            List<Vare> produktkatalogindkoeb = p.indlaesProdukter("Produktkatalog.txt");
            PropMidlertidigIndkoebskurv.Add(produktkatalogindkoeb[listBoxIndkoebProduktKatalog.SelectedIndex]);
            MICount = PropMidlertidigIndkoebskurv.Count;
            listBoxIndkoebIndkoebskurv.Items.Add(PropMidlertidigIndkoebskurv[--MICount]._Navn);
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
    }
}
