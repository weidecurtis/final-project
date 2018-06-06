using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models
{
    public class IndividualGamePosPlayer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PlayerID { get; set; }
        public int Ab { get; set; }
        public int Single { get; set; }
        public int Double { get; set; }
        public int Triple { get; set; }
        public int HomeRun { get; set; }
        public int Run { get; set; }
        public int RBI { get; set; }
        public int CaughtStealing { get; set; }
        public int StolenBase { get; set; }
        public int Walk { get; set; }
        public DateTime GameDate { get; set; }
        public string Position { get; set; }
        public string Team { get; set; }
        public decimal TotalScore { get; set; }
        public int StrikeOut { get; set; }
        public decimal Projection { get; set; }
        public bool Played { get; set; }
    }
}
