using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Madspildprojekt
{
    public class Beholdning
    {
        const int navnIndex = 0, prisIndex = 1, stkIndex = 2, vægtIndex = 3,
            mindstHoldbarIndex = 4, sidsteAnvendelseIndex = 5;

        protected List<VareStkMH> ListVareStkMH = new List<VareStkMH>();
        protected List<VareStkSA> ListVareStkSA = new List<VareStkSA>();
        protected List<VareVægtMH> ListVareVægtMH = new List<VareVægtMH>();
        protected List<VareVægtSA> ListVareVægtSA = new List<VareVægtSA>();

        //public VareVægtSA VareVægtS
        //{
        //    get { }
        //    set { }
        //}

        //public VareVægtMH VareVægtM
        //{
        //    get { }
        //    set { }
        //}

        //public VareStkMH VareStkM
        //{
        //    get { }
        //    set { }
        //}

        //public VareStkSA VareStk
        //{
        //    get { }
        //    set { }
        //}

        public void VareTypeOpdeling() 
        {
            // Test om en linje både har stk, vægt, mh og SA 
            // Enten stk eller vægt og mh eller sa!

            string v1 = "Æg 5,5 10 0 7 0";
            string v2 = "Bacon 30,2 0 300 0 5";
            string v3 = "Ost 25,4 0 200 8 0";
            string v4 = "Banan 2,3 4 0 0 6";

            List<string> varer = new List<string>();
            varer.Add(v1);
            varer.Add(v2);
            varer.Add(v3);
            varer.Add(v4);
            
            foreach (string s in varer)
            {   
                string[] str = s.Split(' ');

                if (str[stkIndex] != "0" && str[mindstHoldbarIndex] != "0")
                {
                    VareStkMH v = new VareStkMH(str[navnIndex], decimal.Parse(str[prisIndex]));
                    v.MindstHoldbar = int.Parse(str[mindstHoldbarIndex]);
                    v.Stk = decimal.Parse(str[stkIndex]);
                    ListVareStkMH.Add(v);
                }
                if (str[vægtIndex] != "0" && str[mindstHoldbarIndex] != "0")
                {
                    VareVægtMH v = new VareVægtMH(str[navnIndex], decimal.Parse(str[prisIndex]));
                    v.MindstHoldbar = int.Parse(str[mindstHoldbarIndex]);
                    v.Vægt = decimal.Parse(str[vægtIndex]);
                    ListVareVægtMH.Add(v);
                }
                if (str[stkIndex] != "0" && str[sidsteAnvendelseIndex] != "0")
                {
                    VareStkSA v = new VareStkSA(str[navnIndex], decimal.Parse(str[prisIndex]));
                    v.SidsteAnvendelse = int.Parse(str[sidsteAnvendelseIndex]);
                    v.Stk = decimal.Parse(str[stkIndex]);
                    ListVareStkSA.Add(v);
                }
                if (str[vægtIndex] != "0" && str[sidsteAnvendelseIndex] != "0")
                {
                    VareVægtSA v = new VareVægtSA(str[navnIndex], decimal.Parse(str[prisIndex]));
                    v.SidsteAnvendelse = int.Parse(str[sidsteAnvendelseIndex]);
                    v.Vægt = decimal.Parse(str[vægtIndex]);
                    ListVareVægtSA.Add(v);
                }
            }
        }

        public void TilføjVare(string vareType, string navn, decimal pris, 
            decimal stk_Vægt, int MH_SA)
        {
            switch (vareType)
            {
                case "VareStkMH":
                    VareStkMH v1 = new VareStkMH(navn, pris);
                    v1.Stk = stk_Vægt;
                    v1.MindstHoldbar = MH_SA;
                    ListVareStkMH.Add(v1);
                    break;
                case "VareVægtMH":
                    VareVægtMH v2 = new VareVægtMH(navn, pris);
                    v2.Vægt = stk_Vægt;
                    v2.MindstHoldbar = MH_SA;
                    ListVareVægtMH.Add(v2);
                    break;
                case "VareStkSA":
                    VareStkSA v3 = new VareStkSA(navn, pris);
                    v3.Stk = stk_Vægt;
                    v3.SidsteAnvendelse = MH_SA;
                    ListVareStkSA.Add(v3);
                    break;
                case "VareVægtSA":
                    VareVægtSA v4 = new VareVægtSA(navn, pris);
                    v4.Vægt = stk_Vægt;
                    v4.SidsteAnvendelse = MH_SA;
                    ListVareVægtSA.Add(v4);
                    break;
                default:
                    // Kast en exception : varetype ikke fundet.
                    break;
            }
        }

        protected void SletVare(string varenavn)
        {
            throw new System.NotImplementedException();
        }

        protected void SorterBeholdning()
        {
            throw new System.NotImplementedException();
        }
    }
}
