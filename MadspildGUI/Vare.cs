using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MadspildGUI
{
    /*
     * Vare er superklassen til VareStkMH, VareStkSA, VareVægtMH og VareVægtSA. '
     * Derudover indeholder Vare også nogle virtuelle metoder.
     */
    public abstract class Vare
    {
        public string _Navn;

        public virtual bool ForGammelDatoTjek(DateTime dato) { return false; }

        public virtual bool SletVareFraListeHvisGammel(DateTime dato, List<Vare> liste)
        {
            return false;
        }

        public virtual void setVolumen(decimal volumen) { }

        public virtual string skrivInfoTilFil()
        {
            return "";
        }

        public virtual string VareNavnOgVolumen()
        {
            return "";
        }
        public virtual DateTime GetDate()
        {
            return DateTime.Now;
        }
    }
}
