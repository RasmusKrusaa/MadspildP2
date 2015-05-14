using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Madspildprojekt
{
    /* 
    * Denne klasse er en underklasse af vare, som har ansvaret for at tilskrive
    * stk og sidsteanvendelse på vare som skal have disse specifikationer.
    */
    public class VareStkSA : Vare2
    {
        private decimal _Stk;
        private DateTime _SidsteAnvendelse;

        public VareStkSA(string navn)
        {
            _Navn = navn;
        }
        public DateTime SidsteAnvendelse
        {
            get { return _SidsteAnvendelse; }
            set { _SidsteAnvendelse = value; }
        }

        public decimal Stk
        {
            get { return _Stk; }
            set { _Stk = value; }
        }
        /*
        * Metoden "ForGammelDatoTjek" overskriver den som findes i superklassen Vare og
        * tjekker efter sidsteanvendelsesdato i forhold til et DateTime input.
        */
        public override void ForGammelDatoTjek(DateTime dato)
        {
            if (_SidsteAnvendelse <= dato)
            {
                MessageBox.Show(_Navn + " er måske for gammel. Tjek dato! Hvis for gammel smid ud!");
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
        * Metoden "VolumenTjek" returnerer Stk fra en instans
        */ 
        public override decimal VolumenTjek()
        {
            return this._Stk;
        }
        /* 
        * Metoden "SetVolumen" sætter en instansens stk til det input, som "SetVolumen" får.
        */
        public override void setVolumen(decimal volumen)
        {
            this._Stk = volumen;
        }
        /* 
        * Metoden "skrivInfoTilFil" returner en string med _Navn, _Stk og _SidsteAnvendelse på en specifik måde.
        */
        public override string skrivInfoTilFil()
        {
            return _Navn + "_" + _Stk + "_0_0_" + _SidsteAnvendelse.ToShortDateString(); 
        }
    }
}
