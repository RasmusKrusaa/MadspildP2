using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MadspildGUI
{
    /*
     * Klassen Producent producerer de varer som kan handles, ud fra en fil
     * og på den måde laver den et produktkatalog.
     */
    public class Producent
    {
        private const int navnIndex = 0, stkIndex = 1, vægtIndex = 2,
            mindstHoldbarIndex = 3, sidsteAnvendelseIndex = 4;
        List<Vare> produktKatalog = new List<Vare>();

        /*
         * Metoden "setDato" får en string, og hvis det er på formen "dd/mm/yy" konvertere den stringen til en Datetime.
         * Derudover kan den også returnerer en DateTime, hvis den får antallet af dage en vare kan holde sig som parameter.
         */
        public DateTime setDato(string dato)
        {
            if (dato.Contains("/"))
            {
                return Convert.ToDateTime(dato);
            }
            else if (dato.Contains("-"))
	        {
                return Convert.ToDateTime(dato);
        	}
            else
            {
                return DateTime.Today.AddDays(double.Parse(dato));
            }
        }
        /*
        * Metoden "Varedannelse" Indlæser fra en fil og instansiere varer over i en liste.
        */
        private List<Vare> Varedannelse(string filnavn, List<Vare> liste)
        {
            string filsti = Directory.GetParent(Directory.GetParent(Directory.GetParent(
                Directory.GetCurrentDirectory()).ToString()).ToString()).ToString() + @"\" + filnavn;
            foreach (string line in File.ReadAllLines(filsti))
            {
                string[] str = line.Split('_');
                if (str[0] == "")
                {
                    return liste;
                }
                else
                {
                    DateTime dagsDato = DateTime.Today;
                    if (str[stkIndex] != "0" && str[mindstHoldbarIndex] != "0")
                    {
                        VareStkMH v = new VareStkMH(str[navnIndex]);
                        v.MindstHoldbar = setDato(str[mindstHoldbarIndex]);
                        v.Stk = decimal.Parse(str[stkIndex]);
                        liste.Add(v);
                    }
                    else if (str[vægtIndex] != "0" && str[mindstHoldbarIndex] != "0")
                    {
                        VareVægtMH v = new VareVægtMH(str[navnIndex]);
                        v.MindstHoldbar = setDato(str[mindstHoldbarIndex]);
                        v.Vægt = decimal.Parse(str[vægtIndex]);
                        liste.Add(v);
                    }
                    else if (str[stkIndex] != "0" && str[sidsteAnvendelseIndex] != "0")
                    {
                        VareStkSA v = new VareStkSA(str[navnIndex]);
                        v.SidsteAnvendelse = setDato(str[sidsteAnvendelseIndex]);
                        v.Stk = decimal.Parse(str[stkIndex]);
                        liste.Add(v);
                    }
                    else if (str[vægtIndex] != "0" && str[sidsteAnvendelseIndex] != "0")
                    {
                        VareVægtSA v = new VareVægtSA(str[navnIndex]);
                        v.SidsteAnvendelse = setDato(str[sidsteAnvendelseIndex]);
                        v.Vægt = decimal.Parse(str[vægtIndex]);
                        liste.Add(v);
                    }
                    else
                    {
                        try
                        {
                            throw new VareTypeNotFoundException("Varetype ikke fundet.");
                        }
                        catch (VareTypeNotFoundException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
            return liste;
        }
        /*
         * Metoden "indlaesProdukter" kalder på Varedannelse metoden, med filnavn som parameter, og returnerer produktliste. 
         */
        public List<Vare> indlaesProdukter(string filnavn)
        {
            List<Vare> produktListe = new List<Vare>();
            
            Varedannelse(filnavn, produktListe);
            return produktListe;
        }
    }
}

