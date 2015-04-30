using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MadspildGUI
{
    public class VareStkSA : Vare
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

        public override void ForGammelDatoTjek(DateTime dato)
        {
            if (_SidsteAnvendelse <= dato)
            {
                MessageBox.Show(_Navn + " er måske for gammel. Tjek dato! Hvis for gammel smid ud!");
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
            return this._Stk;
        }

        public override void setVolumen(decimal volumen)
        {
            this._Stk = volumen;
        }

        public override string skrivInfoTilFil()
        {
            return _Navn + "_" + _Stk + "_0_0_" + _SidsteAnvendelse.ToShortDateString(); 
        }

        public override string ToString()
        {
            return "Navn: " + _Navn + "\nStk: " + _Stk +
                "\nSidste anvendelsesdato: " + _SidsteAnvendelse.ToShortDateString();
        }
    }
}
