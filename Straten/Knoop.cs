using System;
using System.Collections.Generic;
using System.Text;

namespace Straten
{
    class Knoop
    {
        public int KnoopID { get; set; }
        public Punt punt { get; set; }
        public Knoop(int knoopid, Punt punt)
        {
            this.KnoopID = knoopid;
            this.punt = punt;
        }
    }
}
