using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models
{
    public class Batter : Player 
    {
        public int AtBats { get; set; }
        public int Hits {get;set;}
        public int Doubles { get; set; }
        public int Triples { get; set; }
        public int HomeRuns { get; set; }
        public int Walks { get; set; }
        public int RBIs { get; set; }
        public int SB { get; set; }
        public int CS { get; set; }
        public int Runs { get; set; }
        public int LastFiveAb { get; set; }
        public int LastFiveSingle { get; set; }
        public int LastFiveDouble { get; set; }
        public int LastFiveTriple { get; set; }
        public int LastFiveHR { get; set; }
        public int LastFiveWalk { get; set; }
        public int LastFiveRuns { get; set; }
        public int LastFiveRBI { get; set; }
        public int LastFiveSB { get; set; }
        public decimal LastTenLaunchAvg { get; set; }
        public decimal LastTenSpeedAvg { get; set; }
        public decimal DistanceAvg { get; set; }

    }
}
