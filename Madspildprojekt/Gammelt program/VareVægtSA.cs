using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Madspildprojekt
{
    /* 
    * Denne klasse er en underklasse af vare, som har ansvaret for at tilskrive
    * vægt og sidsteanvendelse på vare som skal have disse specifikationer.
    */
    public class VareVægtSA : Vare2
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
        /*
        * Metoden "ForGammelDatoTjek" overskriver den som findes i superklassen Vare og
        * tjekker efter sidsteanvendelsesdato i forhold til et DateTime input.
        */
        public override void ForGammelDatoTjek(DateTime dato)
        {
            if (_SidsteAnvendelse <= dato)
            {
                MessageBox.Show(_Navn + " er måske for gammel. Tjek dato! Hvis for gammel smid ud.");
            }
        }
        /*
        * Metoden "SletVareFraListeHvisGammel" overskriver den som findes i superklassen Vare
        * og fjerner en Vare fra en liste hvis Varen har overskredet datoen.
        */ 
        public override bool SletVareFraListeHvisGammel(DateTime dato, List<Vare2> liste)
        {
            if (_SidsteAnvendelse <= dato)
            {
                liste.Remove(this);
                return true;
            }
            return false;
        }
        /* 
         * Metoden "VolumenTjek" returnerer vægt fra en instans
         */
        public override decimal VolumenTjek()
        {
            return this._Vægt;
        }
        /* 
        * Metoden "SetVolumen" sætter en instansens vægt til det input, som "SetVolumen" får.
        */
        public override void setVolumen(decimal volumen)
        {
            this._Vægt = volumen;
        }
        /* 
         * Metoden "skrivInfoTilFil" returner en string med _Navn, _vægt og _SidsteAnvendelse på en specifik måde.
         */
        public override string skrivInfoTilFil()
        {
            return _Navn + "_0_" + _Vægt + "_0_" + _SidsteAnvendelse.ToShortDateString();  
        }
    }
}
