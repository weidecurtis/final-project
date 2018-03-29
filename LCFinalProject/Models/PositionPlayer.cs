using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models
{
    public class PositionPlayer
    {

        public int ID { get; set; }
        public int PlayerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //TODO Find Source For Pitches faced.
        public string PitchLoves { get; set; }
        public string PitchHates { get; set; }

        public int MonthAb { get; set; }
        public int MonthHit { get; set; }
        public decimal MonthAvg { get; set; }
        public int MonthWalk { get; set; }
        public int MonthRun { get; set; }
        public int MonthRbi { get; set; }
        public int MonthHr { get; set; }
        public decimal MonthOps { get; set; }
        public int MonthSb { get; set; }
        public int MonthCs { get; set; }

        public int SeasonAb { get; set; }
        public int SeasonHit { get; set; }
        public decimal SeasonAvg { get; set; }
        public int SeasonWalk { get; set; }
        public int SeasonRun { get; set; }
        public int SeasonRbi { get; set; }
        public int SeasonHr { get; set; }
        public decimal SeasonOps { get; set; }
        public int SeasonSb { get; set; }
        public int SeasonCs { get; set; }

        public int AwayAb { get; set; }
        public int AwayHit { get; set; }
        public decimal AwayAvg { get; set; }
        public int AwayWalk { get; set; }
        public int AwayRun { get; set; }
        public int AwayRbi { get; set; }
        public int AwayHr { get; set; }
        public decimal AwayOps { get; set; }
        public int AwaySb { get; set; }
        public int AwayCs { get; set; }

        public int HomeAb { get; set; }
        public int HomeHit { get; set; }
        public decimal HomeAvg { get; set; }
        public int HomeWalk { get; set; }
        public int HomeRun { get; set; }
        public int HomeRbi { get; set; }
        public int HomeHr { get; set; }
        public decimal HomeOps { get; set; }
        public int HomeSb { get; set; }
        public int HomeCs { get; set; }

        public int VsLhpAb { get; set; }
        public int VsLhpHit { get; set; }
        public decimal VsLhpAvg { get; set; }
        public int VsLhpWalk { get; set; }
        public int VsLhpRun { get; set; }
        public int VsLhpRbi { get; set; }
        public int VsLhpHr { get; set; }
        public decimal VsLhpOps { get; set; }
        public int VsLhpSb { get; set; }
        public int VsLhpCs { get; set; }

        public int VsRhpAb { get; set; }
        public int VsRhpHit { get; set; }
        public decimal VsRhpAvg { get; set; }
        public int VsRhpWalk { get; set; }
        public int VsRhpRun { get; set; }
        public int VsRhpRbi { get; set; }
        public int VsRhpHr { get; set; }
        public decimal VsRhpOps { get; set; }
        public int VsRhpSb { get; set; }
        public int VsRhpCs { get; set; }


        //TODO Find Source For Batter Vs ExpectedStarter
        public int VsStarterAb { get; set; }
        public int VsStarterHit { get; set; }
        public decimal VsStarterAvg { get; set; }
        public int VsStarterWalk { get; set; }
        public int VsStarterRun { get; set; }
        public int VsStarterRbi { get; set; }
        public int VsStarterHr { get; set; }
        public decimal VsStarterOps { get; set; }
        public int VsStarterSb { get; set; }
        public int VsStarterCs { get; set; }








































    }
}

