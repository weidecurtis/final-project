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
        public string Ab { get; set; }
        public string Single { get; set; }
        public string Double { get; set; }
        public string Triple { get; set; }
        public string HomeRun { get; set; }
        public string Run { get; set; }
        public string RBI { get; set; }
        public string CaughtStealing { get; set; }
        public string StolenBase { get; set; }
        public string Walk { get; set; }
        public DateTime GameDate { get; set; }
        public string Position { get; set; }
    }
}
