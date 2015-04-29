﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Madspildprojekt
{
    /* 
     * Denne klasse er en underklasse af vare, som har ansvaret for at tilskrive
     * stk og mindstholbarhedsdato på vare som skal have disse specifikationer.
    */
    public class VareStkMH : Vare
    {
        private decimal _Stk;
        private DateTime _MindstHoldbar;
        
        public VareStkMH(string navn)
        {
            _Navn = navn;
        }
        public DateTime MindstHoldbar
        {
            get { return _MindstHoldbar; }
            set { _MindstHoldbar = value; }
        }

        public decimal Stk
        {
            get { return _Stk; }
            set { _Stk = value; }
        }

        /*
         * Metoden "ForGammelDatoTjek" overskriver den som findes i superklassen Vare og
         * tjekker efter Mindstholdbar dato i forhold til et DateTime input.
         */
        public override void ForGammelDatoTjek(DateTime dato)
        {
            if (_MindstHoldbar <= dato)
            {
                MessageBox.Show(_Navn + " er måske for gammel. Tjek dato!");
            }
        }

        /*
         * Metoden "SletVareFraListeHvisGammel" overskriver den som findes i superklassen Vare
         * og fjerner en Vare fra en liste hvis Varen har overskredet datoen.
         */ 
        public override bool SletVareFraListeHvisGammel(DateTime dato, List<Vare> liste)
        {
            if (_MindstHoldbar <= dato)
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
         * Metoden "skrivInfoTilFil" returner en string med _Navn, _Stk og _Mindstholdbar på en specifik måde.
         */
        public override string skrivInfoTilFil()
        {
            return _Navn + "_" + _Stk + "_0_" + _MindstHoldbar.ToShortDateString() + "_0";
        }
    }
}
