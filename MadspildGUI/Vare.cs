using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MadspildGUI
{
    public abstract class Vare
    {
        public string _Navn;

        public virtual bool ForGammelDatoTjek(DateTime dato) { return false; }

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

        public virtual string VareNavnOgVolumen()
        {
            return "";
        }
    }
}
