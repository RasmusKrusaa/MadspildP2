using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Madspildprojekt
{
    public class Producent : Beholdning
    {
        public List<Vare> ProduktKatalog = new List<Vare>();
        const int navnIndex = 0, stkIndex = 1, vægtIndex = 2,
            mindstHoldbarIndex = 3, sidsteAnvendelseIndex = 4;

        public void Varedannelse(string Filnavn)
        {
            foreach (string line in File.ReadAllLines(Filnavn))
            {
                string[] str = line.Split('_');

                if (str[stkIndex] != "0" && str[mindstHoldbarIndex] != "0")
                {
                    VareStkMH v = new VareStkMH(str[navnIndex]);
                    v.MindstHoldbar = int.Parse(str[mindstHoldbarIndex]);
                    v.Stk = decimal.Parse(str[stkIndex]);
                    ProduktKatalog.Add(v);
                }
                else if (str[vægtIndex] != "0" && str[mindstHoldbarIndex] != "0")
                {
                    VareVægtMH v = new VareVægtMH(str[navnIndex]);
                    v.MindstHoldbar = int.Parse(str[mindstHoldbarIndex]);
                    v.Vægt = decimal.Parse(str[vægtIndex]);
                    ProduktKatalog.Add(v);
                }
                else if (str[stkIndex] != "0" && str[sidsteAnvendelseIndex] != "0")
                {
                    VareStkSA v = new VareStkSA(str[navnIndex]);
                    v.SidsteAnvendelse = int.Parse(str[sidsteAnvendelseIndex]);
                    v.Stk = decimal.Parse(str[stkIndex]);
                    ProduktKatalog.Add(v);
                }
                else if (str[vægtIndex] != "0" && str[sidsteAnvendelseIndex] != "0")
                {
                    VareVægtSA v = new VareVægtSA(str[navnIndex]);
                    v.SidsteAnvendelse = int.Parse(str[sidsteAnvendelseIndex]);
                    v.Vægt = decimal.Parse(str[vægtIndex]);
                    ProduktKatalog.Add(v);
                }
                else
                {
                    throw new Exception();
                }
            }
        }


    }
}

