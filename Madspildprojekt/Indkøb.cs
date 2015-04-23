using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Madspildprojekt
{
    public class Indkøb : Beholdning
    {
        public List<Vare> Indkøbskurv = new List<Vare>();

        public List<Vare> UdfraOpskrift(Opskrift opskrift, Husholdning hjemmeBeholdning)
        {
            decimal d1, d2, d3;
            foreach (Vare opskriftVare in opskrift.Ingredienser)
            {
                Indkøbskurv.Add(opskriftVare);
                foreach (Vare husholdningVare in hjemmeBeholdning.HusBeholdning)
                {
                    if (opskriftVare._Navn == husholdningVare._Navn)
                    {
                        if (opskriftVare is VareVægtMH || opskriftVare is VareVægtSA)
                        {
                            d1 = VolumenTjek(husholdningVare);
                            d2 = VolumenTjek(opskriftVare);
                            if (d1 >= d2)
                            {
                                Indkøbskurv.Remove(opskriftVare);
                            }
                            else if (opskriftVare is VareVægtMH)
                            {
                                VareVægtMH v1 = opskriftVare as VareVægtMH;
                                d3 = d2 - d1;
                                v1.Vægt = d3;
                            }
                            else if (opskriftVare is VareVægtSA)
                            {
                                VareVægtSA v1 = opskriftVare as VareVægtSA;
                                d3 = d2 - d1;
                                v1.Vægt = d3;
                            }
                        }
                        else if (opskriftVare is VareStkMH || opskriftVare is VareStkSA)
                        {
                            d1 = VolumenTjek(husholdningVare);
                            d2 = VolumenTjek(opskriftVare);
                            if (d1 >= d2)
                            {
                                Indkøbskurv.Remove(opskriftVare);
                            }
                            else if (opskriftVare is VareStkMH)
                            {
                                VareStkMH v1 = opskriftVare as VareStkMH;
                                d3 = d2 - d1;
                                v1.Stk = d3;
                            }
                            else if (opskriftVare is VareStkSA)
                            {
                                VareStkSA v1 = opskriftVare as VareStkSA;
                                d3 = d2 - d1;
                                v1.Stk = d3;
                            }
                        }
                    }
                }
            }
            return Indkøbskurv;
        }
        public decimal VolumenTjek(Vare v)
        {
            if (v is VareVægtMH || v is VareVægtSA)
            {
                VareVægtMH v1 = v as VareVægtMH;
                VareVægtSA v2 = v as VareVægtSA;
                if (v1 == null)
                {
                    return v2.Vægt;
                }
                else return v1.Vægt;
            }
            else
            {
                VareStkMH v1 = v as VareStkMH;
                VareStkSA v2 = v as VareStkSA;
                if (v1 == null)
                {
                    return  v2.Stk;
                }
                else return v1.Stk;
            }
        }
        public List<Vare> ManuelTilføjning (Vare v)
        {
            TilføjVare(v, Indkøbskurv);
            return Indkøbskurv;
        }
        public List<Vare> ManuelSlet(Vare v)
        {
            if (Indkøbskurv.Contains(v))
            {
                SletVare(v, Indkøbskurv);
            }
            else
            {
                throw new VareTypeNotFoundException(); //Indeholder ikke vare exception
            }
            return Indkøbskurv;
        }
        public void TilføjTilHjemmeBeholdning(List<Vare> liste, List<Vare> Produktkatalog)
        {
            foreach (Vare v in Indkøbskurv)
            {
                foreach (Vare Produkt in Produktkatalog)
                {
                    if (v._Navn == Produkt._Navn)
                    {
                        decimal Antal = Math.Ceiling(VolumenTjek(v) / VolumenTjek(Produkt));
                        Indkøbskurv.Remove(v);
                        for (int i = 0; i < Antal; i++)
                        {
                            Indkøbskurv.Add(Produkt);
                        }
                    }
                }
                TilføjVare(v, liste);
            }
            Indkøbskurv = new List<Vare>();
        }

    }
}
