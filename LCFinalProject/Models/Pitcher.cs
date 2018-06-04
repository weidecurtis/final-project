using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models
{
    public class Pitcher
    {
        public int ID { get; set; }
        public int PlayerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TeamName { get; set; }

        [DataType("decimal(18,2)")]
        public decimal SeasonIp { get; set; }
        public int SeasonHitsAllowed { get; set; }
        public decimal SeasonEarnedRunsAllowed { get; set; } 
        public int SeasonRunsAllowed { get; set; }
        public int SeasonWalks { get; set; }
        public int SeasonStrikeOuts { get; set; }
        public int SeasonHomeRunAllowed { get; set; }
        [DataType("decimal(18,2)")]
        public decimal SeasonTotalScore { get; set; }
        public int SeasonWins { get; set; }
        [DataType("decimal(18,2)")]
        public decimal SeasonPointsPerIP { get; set; }

        [DataType("decimal(18,2)")]
        public decimal HomeIp { get; set; }
        public int HomeHitsAllowed { get; set; }
        public decimal HomeEarnedRunsAllowed { get; set; }
        public int HomeRunsAllowed { get; set; }
        public int HomeWalks { get; set; }
        public int HomeStrikeOuts { get; set; }
        public int HomeHitByPitch { get; set; }
        public int HomeHomeRunAllowed { get; set; }
        [DataType("decimal(18,2)")]
        public decimal HomeTotalScore { get; set; }
        [DataType("decimal(18,2)")]
        public decimal HomePointsPerIP { get; set; }

        [DataType("decimal(18,2)")]
        public decimal AwayIp { get; set; }
        public int AwayHitsAllowed { get; set; }
        public decimal AwayEarnedRunsAllowed { get; set; }
        public int AwayRunsAllowed { get; set; }
        public int AwayWalks { get; set; }
        public int AwayStrikeOuts { get; set; }
        public int AwayHitByPitch { get; set; }
        public int AwayHomeRunAllowed { get; set; }
        [DataType("decimal(18,2)")]
        public decimal AwayTotalScore { get; set; }
        [DataType("decimal(18,2)")]
        public decimal AwayPointsPerIP { get; set; }

        [DataType("decimal(18,2)")]
        public decimal LastThreeTotalScore { get; set; }
        public int LastThreeHRA { get; set; }
        public int LastThreeStrikeouts { get; set; }
        public int LastThreeERA { get; set; }
        public decimal LastThreeInningsPitched { get; set; }
        public decimal LastStartScore { get; set; }
        public int LastThreeHitsAllowed { get; set; }
        public int LastThreeWalks { get; set; }

        public string ThrowingHand { get; set; }

        public bool ProbableStarter { get; set; }
        public string MatchUp { get; set; }
        public string Opponent { get; set; }

        public int Salary { get; set; }
        public int DKID { get; set; }

        public int Projection { get; set; }
        public string HomeAway { get; set; }

        [DataType("decimal(18,4)")]
        public decimal ProjectedStrikeout { get; set; }
        [DataType("decimal(18,4)")]
        public decimal ProjectedWalk { get; set; }
        [DataType("decimal(18,4)")]
        public decimal ProjectedHit { get; set; }
        [DataType("decimal(18,4)")]
        public decimal ProjectedHRA { get; set; }
        [DataType("decimal(18,4)")]
        public decimal ProjectedRA { get; set; }

    }
}
