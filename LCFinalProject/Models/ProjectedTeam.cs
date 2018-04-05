using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models
{
    public class ProjectedTeam
    {
        public int ID { get; set; }
        public decimal ProjectedResults { get; set; }
        public string Position { get; set; }
        public decimal TotalProjectedScore { get; set; }
        public int TotalTeamPrice { get; set; }


        public string PitcherOneName { get; set; }
        public decimal PitcherOneProjectedScore { get; set; }
        public int PitcherOnePrice { get; set; }

        public string PitcherTwoName { get; set; }
        public decimal PitcherTwoProjectedScore { get; set; }
        public int PitcherTwoPrice { get; set; }

        public string CatcherName { get; set; }
        public decimal CatcherProjectedScore { get; set; }
        public int CatcherPrice { get; set; }

        public string FirstBaseName { get; set; }
        public decimal FirstBaseProjectScore { get; set; }
        public int FirstBasePrice { get; set; }

        public string SecondBaseName { get; set; }
        public decimal SecondBaseProjectedScore { get; set; }
        public int SecondBasePrice { get; set; }

        public string ThirdBaseName { get; set; }
        public decimal ThirdBaseProjectedScore { get; set; }
        public int ThirdBasePrice { get; set; }

        public string ShortStopName { get; set; }
        public decimal ShortStopProjectedScore { get; set; }
        public int ShortStopPrice { get; set; }

        public string OutfieldOneName { get; set; }
        public decimal OutfieldOneProjectedScore { get; set; }
        public int OutfieldOnePrice { get; set; }

        public string OutfieldTwoName { get; set; }
        public decimal OutfieldTwoProjectedScore { get; set; }
        public int OutfieldTwoPrice { get; set; }

        public string OutfieldThreeName { get; set; }
        public decimal OutfieldThreeProjectedScore { get; set; }
        public int OutfieldThreePrice { get; set; }

    }
}
