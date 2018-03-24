using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCFinalProject.Models
{
    public class ProjectedTeam
    {
        public int ID { get; set; }

        public int PitcherID { get; set; }  
        public int PositionPlayerID { get; set; }
        public PositionPlayer PositionPlayer { get; set; }
        public Pitcher Pitcher { get; set; }
    }
}
