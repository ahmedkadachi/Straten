using System;
using System.Collections.Generic;
using System.Text;

namespace Straten
{
    class Segment
    {
        public Knoop Beginknoop { get; set; }
        public Knoop EindKnoop { get; set; }
        public int SegmentID { get; set; }
        public List<Punt> Vertices = new List<Punt>();

        public Segment(Knoop beginknoop, Knoop eindeknoop, int segmentid, List<Punt> vertices)
        {
            this.Beginknoop = beginknoop;
            this.EindKnoop = eindeknoop;
            this.SegmentID = segmentid;
            this.Vertices = vertices;
        }
    }
}
