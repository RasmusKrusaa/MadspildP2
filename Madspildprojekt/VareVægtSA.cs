using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Madspildprojekt
    /* 
     * Denne klasse er en underklasse af vare, som har ansvaret for at tilskrive
     * vægt og sidsteanvendelsesdato på vare som skal have disse specifikationer.
    */
{
    public class VareVægtSA : Vare
    {
        private decimal _Vægt;
        private DateTime _SidsteAnvendelse;

        public VareVægtSA(string navn)
        {
            _Navn = navn;
        }
        public decimal Vægt
        {
            get { return _Vægt; }
            set { _Vægt = value; }
        }

        public DateTime SidsteAnvendelse
        {
            get { return _SidsteAnvendelse; }
            set { _SidsteAnvendelse = value; }
        }

        public override void ForGammelDatoTjek(DateTime dato)
        {
            if (_SidsteAnvendelse <= dato)
            {
                MessageBox.Show(_Navn + " er måske for gammel. Tjek dato! Hvis for gammel smid ud.");
            }
        }

        public override bool SletVareFraListeHvisGammel(DateTime dato, List<Vare> liste)
        {
            if (_SidsteAnvendelse <= dato)
            {
                liste.Remove(this);
                return true;
            }
            return false;
        }

        public override decimal VolumenTjek()
        {
            return this._Vægt;
        }

        public override void setVolumen(decimal volumen)
        {
            this._Vægt = volumen;
        }
    }
}
