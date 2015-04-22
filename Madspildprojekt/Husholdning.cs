using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;

namespace Madspildprojekt
{
    public class Husholdning : Beholdning
    {
        public List<Vare> HusBeholdning = new List<Vare>();
        
        public void indlæs(List<Vare> husholdning)
        {
            Producent p = new Producent();
            p.Varedannelse("C:\\Users\\Bilgram\\Desktop\\Program\\MadspildP2\\Husholdning.txt", husholdning);          
        }

        public void DatoAdvarsel(DateTime dato)
        {
            foreach (Vare v in HusBeholdning)
            {
                if (v is VareStkMH)
                {
                    VareStkMH v2 = v as VareStkMH;
                    if (v2.MindstHoldbar <= dato)
                    {
                        MessageBox.Show(v._Navn + " er ved at blive for gammel. Tjek dato.");
                    }
                }
                else if (v is VareVægtMH)
                {
                    VareVægtMH v2 = v as VareVægtMH;
                    if (v2.MindstHoldbar <= dato)
                    {
                        MessageBox.Show(v._Navn + " er ved at blive for gammel. Tjek dato.");
                    }
                }
                else if (v is VareStkSA)
                {
                    VareStkSA v2 = v as VareStkSA;
                    if (v2.SidsteAnvendelse <= dato)
                    {
                        MessageBox.Show(v._Navn + " er ved at blive for gammel. Tjek dato. Hvis for gammel smid ud");
                    }
                }
                else if (v is VareVægtSA)
                {
                    VareVægtSA v2 = v as VareVægtSA;
                    if (v2.SidsteAnvendelse <= dato)
                    {
                        MessageBox.Show(v._Navn + " er ved at blive for gammel. Tjek dato. Hvis for gammel smid ud");
                    }
                }
            }
        }        
        public void SletGammelVare(DateTime dato)
        {
            for (int i = 0; i < HusBeholdning.Count; i++)
            {
                if (HusBeholdning[i] is VareStkMH)
                {
                    VareStkMH v2 = HusBeholdning[i] as VareStkMH;
                    if (v2.MindstHoldbar <= dato)
                    {
                        SletVare(v2, HusBeholdning);
                        i--;
                    }
                }
                else if (HusBeholdning[i] is VareVægtMH)
                {
                    VareVægtMH v2 = HusBeholdning[i] as VareVægtMH;
                    if (v2.MindstHoldbar <= dato)
                    {
                        SletVare(v2, HusBeholdning);
                        i--;
                    }
                }
                else if (HusBeholdning[i] is VareStkSA)
                {
                    VareStkSA v2 = HusBeholdning[i] as VareStkSA;
                    if (v2.SidsteAnvendelse <= dato)
                    {
                        SletVare(v2, HusBeholdning);
                        i--;
                    }
                }
                else if (HusBeholdning[i] is VareVægtSA)
                {
                    VareVægtSA v2 = HusBeholdning[i] as VareVægtSA;
                    if (v2.SidsteAnvendelse <= dato)
                    {
                        SletVare(v2, HusBeholdning);
                        i--;
                    }
                }
            }
        }
    }
}
