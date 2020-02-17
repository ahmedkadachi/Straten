using System;
using System.Collections.Generic;
using System.Text;

namespace Straten
{
    class Graaf
    {
        public int GraafID { get; set; }
        Dictionary<Knoop, List<Segment>> map = new Dictionary<Knoop, List<Segment>>();

        public Graaf(int graafid, Dictionary<Knoop, List<Segment>> map)
        {
            this.GraafID = graafid;
            this.map = map;
        }
    }
}
