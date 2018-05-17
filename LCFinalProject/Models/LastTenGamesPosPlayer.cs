using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models
{
    public class LastTenGamesPosPlayer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PlayerID { get; set; }
        public string Position { get; set; }
        public DateTime DateEntered { get; set; }
        public int GamesPlayed { get; set; }
        public string Team { get; set; }

        public decimal AvgAtBat { get; set; }
        public decimal AvgSingle { get; set; }
        public decimal AvgDouble { get; set; }
        public decimal AvgTriple { get; set; }
        public decimal AvgHomeRun { get; set; }
        public decimal AvgRBI { get; set; }
        public decimal AvgRun { get; set; }
        public decimal AvgStolenBase { get; set; }
        public decimal AvgCaughtStealing { get; set; }
        public decimal AvgWalk { get; set; }
        public decimal AvgHBP { get; set; }
        public decimal AvgResults { get; set; }


    }
}
