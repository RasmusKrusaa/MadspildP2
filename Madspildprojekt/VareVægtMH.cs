using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Madspildprojekt
{
    /* 
    * Denne klasse er en underklasse af vare, som har ansvaret for at tilskrive
    * vægt og mindstholdbarhedsdato på vare som skal have disse specifikationer.
    */
    public class VareVægtMH : Vare
    {
        private decimal _Vægt;
        private DateTime _MindstHoldbar;

        public VareVægtMH(string navn)
        {
            _Navn = navn;
        }

        public DateTime MindstHoldbar
        {
            get { return _MindstHoldbar; }
            set { _MindstHoldbar = value; }
        }

        public decimal Vægt
        {
            get { return _Vægt; }
            set { _Vægt = value; }
        }

        public override void ForGammelDatoTjek(DateTime dato)
        {
            if (_MindstHoldbar <= dato)
            {
                MessageBox.Show(_Navn + " er måske for gammel. Tjek dato!");
            }
        }

        public override bool SletVareFraListeHvisGammel(DateTime dato, List<Vare> liste)
        {
            if (_MindstHoldbar <= dato)
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
            this.Vægt = volumen;
        }

    }
}
