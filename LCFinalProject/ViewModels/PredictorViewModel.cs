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
        public IList<ProjectedCatcher> Catchers { get; set; }
        public IList<ProjectedPitcher> Pitchers { get; set; }
        public IList<ProjectedFirstBaseman> FirstBasemen { get; set; }
        public IList<ProjectedSecondBaseman> SecondBasemen { get; set; }
        public IList<ProjectedShortstop> ShortStops { get; set; }
        public IList<ProjectedThirdBaseman> ThirdBasemen { get; set; }
        public IList<ProjectedOutfielder> Outfielders { get; set; }

        public IList<AwayCatcher> AwayCatchers { get; set; }
        public IList<AwayPitcher> AwayPitchers { get; set; }
        public IList<AwayFirstBaseman> AwayFirstBasemen { get; set; }
        public IList<AwaySecondBaseman> AwaySecondBasemen { get; set; }
        public IList<AwayShortstop> AwayShortStops { get; set; }
        public IList<AwayThirdBaseman> AwayThirdBasemen { get; set; }
        public IList<AwayOutfielder> AwayOutfielders { get; set; }

        public IList<HomeCatcher> HomeCatchers { get; set; }
        public IList<HomePitcher> HomePitchers { get; set; }
        public IList<HomeFirstBaseman> HomeFirstBasemen { get; set; }
        public IList<HomeSecondBaseman> HomeSecondBasemen { get; set; }
        public IList<HomeShortstop> HomeShortStops { get; set; }
        public IList<HomeThirdBaseman> HomeThirdBasemen { get; set; }
        public IList<HomeOutfielder> HomeOutfielders { get; set; }

        public IList<LhpCatcher> LhpCatchers { get; set; }
        public IList<LhpFirstBaseman> LhpFirstBasemen { get; set; }
        public IList<LhpSecondBaseman> LhpSecondBasemen { get; set; }
        public IList<LhpShortstop> LhpShortStops { get; set; }
        public IList<LhpThirdBaseman> LhpThirdBasemen { get; set; }
        public IList<LhpOutfielder> LhpOutfielders { get; set; }

        public IList<RhpCatcher> RhpCatchers { get; set; }
        public IList<RhpFirstBaseman> RhpFirstBasemen { get; set; }
        public IList<RhpSecondBaseman> RhpSecondBasemen { get; set; }
        public IList<RhpShortstop> RhpShortStops { get; set; }
        public IList<RhpThirdBaseman> RhpThirdBasemen { get; set; }
        public IList<RhpOutfielder> RhpOutfielders { get; set; }


    }
}
