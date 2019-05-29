using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models
{
    public class GameStat
    {
        public int ID { get; set; }
        public int PlayerID { get; set; }
        public DateTime Date { get; set; }
        public int Hits { get; set; }
        public int Doubles { get; set; }
        public int Triples { get; set; }
        public int HomeRuns { get; set; }
        public int SB { get; set; }
        public int CS { get; set; }
        public int RBIs { get; set; }
        public int Runs { get; set; }
        public int Walks { get; set; }

        public string Position { get; set; }

        public int Score { get; set; }
    }
}
