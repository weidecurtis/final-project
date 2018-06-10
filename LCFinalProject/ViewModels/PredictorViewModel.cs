using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LCFinalProject.Models;

namespace LCFinalProject.ViewModels
{
    public class PredictorViewModel
    {
        public IList<PositionPlayer> Catchers { get; set; }
        public IList<Pitcher> Pitchers { get; set; }
        public IList<PositionPlayer> FirstBasemen { get; set; }
        public IList<PositionPlayer> SecondBasemen { get; set; }
        public IList<PositionPlayer> ShortStops { get; set; }
        public IList<PositionPlayer> ThirdBasemen { get; set; }
        public IList<PositionPlayer> Outfielders { get; set; }
        public IList<Team> Teams { get; set; }
        public IList<ProjectedTeam> ProjectedTeams { get; set; }

    }
}
