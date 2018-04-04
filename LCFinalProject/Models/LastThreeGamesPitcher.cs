using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models
{
    public class LastThreeGamesPitcher
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PlayerID { get; set; }
        public int GamesPlayed { get; set; }
        public DateTime DateEntered { get; set; }

        public decimal AvgWin { get; set; }
        public decimal AvgLoss { get; set; }
        public decimal AvgIP { get; set; }
        public decimal AvgHitAllowed { get; set; }
        public decimal AvgRunAllowed { get; set; }
        public decimal AvgWalkAllowed { get; set; }
        public decimal AvgEarnedRun { get; set; }
        public decimal AvgStrikeOut { get; set; }
        public decimal AvgHomeRunAllowed { get; set; }
        public decimal AvgResults { get; set; }
        public decimal AvgCompleteGame { get; set; }
        public decimal AvgCompleteGameShutOut { get; set; }

    }
}
