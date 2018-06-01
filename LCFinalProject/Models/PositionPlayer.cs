using LCFinalProject.Models.gd2Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string TeamName { get; set; }
        public string Position { get; set; }

        [DataType("decimal(18,2)")]
        public decimal SeasonAb { get; set; }
        public int SeasonHit { get; set; }
        public decimal SeasonAvg { get; set; }
        public int SeasonSingle { get; set; }
        public int SeasonDouble { get; set; }
        public int SeasonTriple { get; set; }
        public int SeasonWalk { get; set; }
        public int SeasonRun { get; set; }
        public int SeasonRbi { get; set; }
        public int SeasonHr { get; set; }
        public decimal SeasonOps { get; set; }
        public int SeasonSb { get; set; }
        public int SeasonCs { get; set; }
        [DataType("decimal(18,2)")]
        public decimal SeasonTotalScore { get; set; }

        [DataType("decimal(18,2)")]
        public decimal AwayAb { get; set; }
        public int AwayHit { get; set; }
        public decimal AwayAvg { get; set; }
        public int AwayWalk { get; set; }
        public int AwayRun { get; set; }
        public int AwayRbi { get; set; }
        public int AwayHr { get; set; }
        public decimal AwayOps { get; set; }
        public int AwaySb { get; set; }
        public int AwayCs { get; set; }
        [DataType("decimal(18,2)")]
        public decimal AwayTotalScore { get; set; }

        [DataType("decimal(18,2)")]
        public decimal HomeAb { get; set; }
        public int HomeHit { get; set; }
        public decimal HomeAvg { get; set; }
        public int HomeWalk { get; set; }
        public int HomeRun { get; set; }
        public int HomeRbi { get; set; }
        public int HomeHr { get; set; }
        public decimal HomeOps { get; set; }
        public int HomeSb { get; set; }
        public int HomeCs { get; set; }
        [DataType("decimal(18,2)")]
        public decimal HomeTotalScore { get; set; }

        [DataType("decimal(18,2)")]
        public decimal VsLhpAb { get; set; }
        public int VsLhpHit { get; set; }
        public decimal VsLhpAvg { get; set; }
        public int VsLhpWalk { get; set; }
        public int VsLhpRun { get; set; }
        public int VsLhpRbi { get; set; }
        public int VsLhpHr { get; set; }
        public decimal VsLhpOps { get; set; }
        public int VsLhpSb { get; set; }
        public int VsLhpCs { get; set; }
        [DataType("decimal(18,2)")]
        public decimal VsLhpTotalScore { get; set; }

        [DataType("decimal(18,2)")]
        public decimal VsRhpAb { get; set; }
        public int VsRhpHit { get; set; }
        public decimal VsRhpAvg { get; set; }
        public int VsRhpWalk { get; set; }
        public int VsRhpRun { get; set; }
        public int VsRhpRbi { get; set; }
        public int VsRhpHr { get; set; }
        public decimal VsRhpOps { get; set; }
        public int VsRhpSb { get; set; }
        public int VsRhpCs { get; set; }
        [DataType("decimal(18,2)")]
        public decimal VsRhpTotalScore { get; set; }

        [DataType("decimal(18,2)")]
        public decimal YesterdayTotalScore { get; set; }
        [DataType("decimal(18,2)")]
        public decimal LastFiveTotalScore { get; set; }
        [DataType("decimal(18,2)")]
        public decimal AwayScorePerAB { get; set; }
        [DataType("decimal(18,2)")]
        public decimal HomeScorePerAB { get; set; }
        [DataType("decimal(18,2)")]
        public decimal VsLhpScorePerAB { get; set; }
        [DataType("decimal(18,2)")]
        public decimal VsRhpScorePerAB { get; set; }

        public string OpponentStarter { get; set; }
        public string MatchUp { get; set; }
        public decimal OpponentPointsLastThree { get; set; }
        public int OpponentHRALastThree { get; set; }
        public string OpponentThrowingHand { get; set; }




































    }
}

