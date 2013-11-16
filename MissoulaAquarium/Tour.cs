using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissoulaAquarium
{
    class Tour
    {
        private string tourName;
        private int tourID;
        private string tourGuide;
        private string tourDateTime;
        private string tourLocation;

        public Tour(string n, int i, string g, string d, string l)
        {
            tourName = n;
            tourID = i;
            tourGuide = g;
            tourDateTime = d;
            tourLocation = l;
        }
        public override string ToString()
        {
            return tourID + "\t" + tourName + "\t" + tourGuide + "\t" + tourDateTime + "\t"+tourLocation;
        }

        public int getID()
        {
            return tourID;
        }
    }
}
