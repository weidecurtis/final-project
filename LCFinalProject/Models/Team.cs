using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string TeamName { get; set; }
        public int StrikeOuts { get; set; }
        public int HomeRuns { get; set; }
        public int Hits { get; set; }
        public int Runs { get; set; }
        public int TotalPoints { get; set; }
        [DataType("decimal(18,2)")]
        public decimal RunsAllowed { get; set; }
        [DataType("decimal(18,2)")]
        public decimal HomeRunsAllowed { get; set; }
        [DataType("decimal(18,2)")]
        public decimal HitsAllowed { get; set; }
        [DataType("decimal(18,2)")]
        public decimal GamesPlayedGauge { get; set; }
        [DataType("decimal(18,2)")]
        public decimal PointsPerPitcherUsed { get; set; }
        [DataType("decimal(18,2)")]
        public decimal PointsGivenUp { get; set; }

        public string Opponent { get; set; }
        public string HomeAway { get; set; }
        public string OpponentStarter { get; set; }
        public string Starter { get; set; }



    }
}
