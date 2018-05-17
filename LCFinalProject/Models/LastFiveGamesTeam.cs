using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models
{
    public class LastFiveGamesTeam
    {
        public int ID { get; set; }
        public string TeamName { get; set; }
        public int StrikeOutTotal { get; set; }
        public int HomeRunTotal { get; set; }
        public int RunTotal { get; set; }
    }
}
