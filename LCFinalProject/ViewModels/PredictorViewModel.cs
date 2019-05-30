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
        public IList<Batter> Catchers { get; set; }
        public IList<Pitcher> Pitchers { get; set; }
        public IList<Batter> FirstBasemen { get; set; }
        public IList<Batter> SecondBasemen { get; set; }
        public IList<Batter> ShortStops { get; set; }
        public IList<Batter> ThirdBasemen { get; set; }
        public IList<Batter> Outfielders { get; set; }

        public IList<TopGame> YesterdayTopFive { get; set; }

        //public IList<Team> Teams { get; set; }
        //public IList<ProjectedTeam> ProjectedTeams { get; set; }

    }
}
