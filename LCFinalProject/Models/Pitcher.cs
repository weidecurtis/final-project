using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models
{
    public class Pitcher
    {
        public int ID { get; set; }
        public int PlayerID { get; set; }
        public int DkID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TeamName { get; set; }

        public int SeasonIp { get; set; }
        public int SeasonHitsAllowed { get; set; }
        public int SeasonEarnedRuns { get; set; } 
        public int SeasonRunsAllowed { get; set; }
        public int SeasonWalks { get; set; }
        public int SeasonStrikeOuts { get; set; }
        public int SeasonHitByPitch { get; set; }
        public int SeasonHomeRunAllowed { get; set; }

        public int HomeIp { get; set; }
        public int HomeHitsAllowed { get; set; }
        public int HomeEarnedRuns { get; set; }
        public int HomeRunsAllowed { get; set; }
        public int HomeWalks { get; set; }
        public int HomeStrikeOuts { get; set; }
        public int HomeHitByPitch { get; set; }
        public int HomeHomeRunAllowed { get; set; }

        public int AwayIp { get; set; }
        public int AwayHitsAllowed { get; set; }
        public int AwayEarnedRuns { get; set; }
        public int AwayRunsAllowed { get; set; }
        public int AwayWalks { get; set; }
        public int AwayStrikeOuts { get; set; }
        public int AwayHitByPitch { get; set; }
        public int AwayHomeRunAllowed { get; set; }

    }
}
