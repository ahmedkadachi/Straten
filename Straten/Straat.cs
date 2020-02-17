using System;
using System.Collections.Generic;
using System.Text;

namespace Straten
{
    class Straat
    {
        public Graaf graaf { get; set; }
        public int StraatID { get; set; }
        public string StraatNaam { get; set; }

        public Straat(Graaf graaf, int straatid, string straatnaam)
        {
            this.graaf = graaf;
            this.StraatID = straatid;
            this.StraatNaam = straatnaam;
        }
    }
}
