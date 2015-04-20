using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Madspildprojekt
{
    public class Indkøb : Beholdning
    {
        public List<Vare> Indkøbskurv = new List<Vare>();

        private List<Vare> UdfraOpskrift(Opskrift opskrift, Husholdning hjemmeBeholdning)
        {
            foreach (Vare opskriftVare in opskrift.Ingredienser)
            {
                Indkøbskurv.Add(opskriftVare);
                foreach (Vare husholdningVare in hjemmeBeholdning.HusBeholdning)
                {
                    if (opskriftVare._Navn == husholdningVare._Navn)
                    { //Tjek efter vægt
                        Indkøbskurv.Remove(opskriftVare);
                    }
                }
            }
            return Indkøbskurv;
        }
        //public decimal VolumenTjek(Vare v)
        //{
        //    var u =v.GetType().GetProperties();
        //    if (v.GetType().GetProperties == VareVægtMH)
        //    {

        //    }
        //    return 2;
        //}
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
                throw new Exception(); //Indeholder ikke vare exception
            }
            return Indkøbskurv;
        }
        private void TilføjTilListe(List<Vare> liste)
        {
            foreach (Vare v in Indkøbskurv)
            {
                TilføjVare(v, liste);
            }
            Indkøbskurv = new List<Vare>();
        }

    }
}
