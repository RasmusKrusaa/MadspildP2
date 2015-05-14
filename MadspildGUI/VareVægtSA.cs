﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MadspildGUI
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

        public override bool ForGammelDatoTjek(DateTime dato)
        {
            if (_SidsteAnvendelse <= dato)
            {
                MessageBox.Show(_Navn + " er måske for gammel. Tjek datoen! Hvis for gammel smid ud!");
                return true;
            }
            return false;
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
        public override DateTime GetDate()
        {
            return SidsteAnvendelse;
        }
        public override decimal VolumenTjek()
        {
            return this._Vægt;
        }

        public override void setVolumen(decimal volumen)
        {
            this._Vægt = volumen;
        }

        public override string skrivInfoTilFil()
        {
            return _Navn + "_0_" + _Vægt + "_0_" + _SidsteAnvendelse.ToShortDateString();  
        }

        public override string ToString()
        {
            return "Navn: " + _Navn + "\nVægt: " + _Vægt + "g" +
                "\nSidste anvendelsesdato: " + _SidsteAnvendelse.ToShortDateString();
        }

        public override string VareNavnOgVolumen()
        {
            return _Vægt + "g " + _Navn;
        }
    }
}
