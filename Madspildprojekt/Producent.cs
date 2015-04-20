using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Madspildprojekt
{
    public class Producent
    {
        const int navnIndex = 0, stkIndex = 1, vægtIndex = 2,
            mindstHoldbarIndex = 3, sidsteAnvendelseIndex = 4;
        List<Vare> produktKatalog = new List<Vare>();

        public List<Vare> Varedannelse(string filnavn, List<Vare> liste)
        {
            foreach (string line in File.ReadAllLines(filnavn))
            {
                string[] str = line.Split('_');
                DateTime dagsDato = DateTime.Now;
                if (str[stkIndex] != "0" && str[mindstHoldbarIndex] != "0")
                {
                    VareStkMH v = new VareStkMH(str[navnIndex]);
                    v.MindstHoldbar = dagsDato.AddDays(double.Parse(str[mindstHoldbarIndex]));
                    v.Stk = decimal.Parse(str[stkIndex]);
                    liste.Add(v);
                }
                else if (str[vægtIndex] != "0" && str[mindstHoldbarIndex] != "0")
                {
                    VareVægtMH v = new VareVægtMH(str[navnIndex]);
                    v.MindstHoldbar = dagsDato.AddDays(double.Parse(str[mindstHoldbarIndex]));
                    v.Vægt = decimal.Parse(str[vægtIndex]);
                    liste.Add(v);
                }
                else if (str[stkIndex] != "0" && str[sidsteAnvendelseIndex] != "0")
                {
                    VareStkSA v = new VareStkSA(str[navnIndex]);
                    v.SidsteAnvendelse = dagsDato.AddDays(double.Parse(str[sidsteAnvendelseIndex]));
                    v.Stk = decimal.Parse(str[stkIndex]);
                    liste.Add(v);
                }
                else if (str[vægtIndex] != "0" && str[sidsteAnvendelseIndex] != "0")
                {
                    VareVægtSA v = new VareVægtSA(str[navnIndex]);
                    v.SidsteAnvendelse = dagsDato.AddDays(double.Parse(str[sidsteAnvendelseIndex]));
                    v.Vægt = decimal.Parse(str[vægtIndex]);
                    liste.Add(v);
                }
                else
                {
                    throw new Exception();
                }
            }
            return liste;
        }
        private List<Vare> indlaesProduktKatalog()
        {
            Varedannelse("C:\\Users\\Bilgram\\Desktop\\Program\\MadspildP2\\Produktkatalog.txt", produktKatalog);
            return produktKatalog;
        }
    }
}

