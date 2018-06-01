using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models
{
    public class ProjectedTeam
    {
        public int ID { get; set; }

        public string PitcherOne { get; set; }
        public decimal PitcherOneProjection { get; set; }
        public int PitcherOneSalary { get; set; }

        public string PitcherTwo { get; set; }
        public decimal PitcherTwoProjection { get; set; }
        public int PitcherTwoSalary { get; set; }

        public string Catcher { get; set; }
        public decimal CatcherProjection { get; set; }
        public int CatcherSalary { get; set; }

        public string FirstBase { get; set; }
        public decimal FirstBaseProjection { get; set; }
        public int FirstBaseSalary { get; set; }

        public string SecondBase { get; set; }
        public decimal SecondBaseProjection { get; set; }
        public int SecondBaseSalary { get; set; }

        public string ThirdBase { get; set; }
        public decimal ThirdBaseProjection { get; set; }
        public int ThirdBaseSalary { get; set; }

        public string Shortstop { get; set; }
        public decimal ShortstopProjection { get; set; }
        public int ShortstopSalary { get; set; }

        public string OutfieldOne { get; set; }
        public decimal OutfieldOneProjection { get; set; }
        public int OutfieldOneSalary { get; set; }

        public string OutfieldTwo { get; set; }
        public decimal OutfieldTwoProjection { get; set; }
        public int OutfieldTwoSalary { get; set; }

        public string OutfieldThree { get; set; }
        public int OutfieldThreeProjection { get; set; }
        public int OutfieldThreeSalary { get; set; }

        public int TotalCost { get; set; }
        public decimal TeamProjection { get; set; }









    }
}
