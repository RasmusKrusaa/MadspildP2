﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MadspildGUI
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
        /*
       * Metoden "ForGammelDatoTjek" overskriver den som findes i superklassen Vare og
       * tjekker efter Mindstholdbar dato i forhold til et DateTime input.
       */
        public override bool ForGammelDatoTjek(DateTime dato)
        {
            if (_MindstHoldbar <= dato)
            {
                MessageBox.Show(_Navn + " er måske for gammel. Tjek datoen! Hvis for gammel undersøg, om varen dufter mærkeligt eller andre usædvanligheder.");
                return true;
            }
            return false;
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
         * Metoden "GetDate" returnere dato for mindstholdbarhed- eller sidsteanvendelses-dato
         */
        public override DateTime GetDate()
        {
            return _MindstHoldbar;
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
            this.Vægt = volumen;
        }
        /* 
         * Metoden "skrivInfoTilFil" returner en string med _Navn, _vægt og _Mindstholdbar på en specifik måde.
         */
        public override string skrivInfoTilFil()
        {
            return _Navn + "_0_" + _Vægt + "_" + _MindstHoldbar.ToShortDateString() + "_0"; 
        }
        /*
         * Metoden "ToString" overrider den oprindelige ToString og returnere 
         * varens- navn vægt og mindstholdbarhedsdato
         */
        public override string ToString()
        {
            return "Navn: " + _Navn + "\nVægt: " + _Vægt + "g" +
                "\nMindst holdbarhedsdato: " + _MindstHoldbar.ToShortDateString();
        }
        /*
        * Metoden "VareNavnOgVolumen" returnere en string med ens vares navn og volumen
        */
        public override string VareNavnOgVolumen()
        {
            return _Vægt + "g " + _Navn;
        }
    }
}
