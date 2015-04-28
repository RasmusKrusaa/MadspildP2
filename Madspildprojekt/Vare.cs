using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Madspildprojekt
{
    /*
     * Vare er superklassen til VareStkMH, VareStkSA, VareVægtMH og VareVægtSA. Derudover indeholder Vare også de virtuelle metoder.
     */
    public abstract class Vare
    {
        public string _Navn;

        public virtual void ForGammelDatoTjek(DateTime dato) { }

        public virtual bool SletVareFraListeHvisGammel(DateTime dato, List<Vare> liste)
        {
            return false;
        }

        public virtual decimal VolumenTjek()
        {
            return 0;
        }

        public virtual void setVolumen(decimal volumen) { }

        public virtual string skrivInfoTilFil()
        {
            return "";
        }
    }
}
