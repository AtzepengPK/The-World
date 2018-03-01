using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld.Core.Abstractions.Classes
{
    public class Stats
    {
        public double stat1 { get; set; }
        public double stat2 { get; set; }
        public double stat3 { get; set; }
        public double stat4 { get; set; }

        int _statsBoost;

        public int minBoost = 1;
        public int maxBoost = 5;


        public int statsBoost { get { return _statsBoost; } set { _statsBoost = value; addStatsBoost(_statsBoost); } }

        public Stats(double s1, double s2, double s3, double s4)
        {
            stat1 = s1;
            stat2 = s2;
            stat3 = s3;
            stat4 = s4;
        }

        public Stats()
        {
            stat1 = 10;
            stat2 = 10;
            stat3 = 10;
            stat4 = 10;
        }

        public void addStatsBoost(double boost) {
            stat1 *= boost;
            stat2 *= boost;
            stat3 *= boost;
            stat4 *= boost;
        }

    }
}
