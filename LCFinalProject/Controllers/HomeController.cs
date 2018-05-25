using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LCFinalProject.Models;
using LCFinalProject.Data;
using LCFinalProject.ViewModels;
using MoreLinq;

namespace LCFinalProject.Controllers
{
    public class HomeController : Controller
    {
        private BeatTheShiftDbContext _context;

        public HomeController(BeatTheShiftDbContext dbContext)
        {
            _context = dbContext;
        }

        public IActionResult Index()
        {
            List<ProjectedPitcher> pitchers = _context.ProjectedPitchers.OrderByDescending(p => p.ProjectedScore).ToList();
            List<PositionPlayer> catchers = _context.PositionPlayers.Where(p => p.Position == "C").ToList();
            List<PositionPlayer> firstBasemen = _context.PositionPlayers.OrderByDescending(p => p.Position == "1B").ToList();
            List<PositionPlayer> secondBasemen = _context.PositionPlayers.OrderByDescending(p => p.Position == "2B").ToList();
            List<PositionPlayer> shortstops = _context.PositionPlayers.OrderByDescending(p => p.Position == "SS").ToList();
            List<PositionPlayer> thirdBasemen = _context.PositionPlayers.OrderByDescending(p => p.Position == "3B").ToList();
            List<PositionPlayer> outfielders = _context.PositionPlayers.OrderByDescending(p => p.Position == "OF").ToList();

            List<AwayCatcher> awayCatchers = _context.AwayCatchers.OrderByDescending(p => p.TotalScore).ToList();
            List<AwayPitcher> awayPitchers = _context.AwayPitchers.OrderByDescending(p => p.TotalScore).ToList();
            List<AwayFirstBaseman> awayFirstBasemen = _context.AwayFirstBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<AwaySecondBaseman> awaySecondBasemen = _context.AwaySecondBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<AwayThirdBaseman> awayThirdBasemen = _context.AwayThirdBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<AwayShortstop> awayShortstops = _context.AwayShortstops.OrderByDescending(p => p.TotalScore).ToList();
            List<AwayOutfielder> awayOutfielders = _context.AwayOutfielders.OrderByDescending(p => p.TotalScore).ToList();

            List<HomeCatcher> homeCatchers = _context.HomeCatchers.OrderByDescending(p => p.TotalScore).ToList();
            List<HomePitcher> homePitchers = _context.HomePitchers.OrderByDescending(p => p.TotalScore).ToList();
            List<HomeFirstBaseman> homeFirstBasemen = _context.HomeFirstBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<HomeSecondBaseman> homeSecondBasemen = _context.HomeSecondBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<HomeThirdBaseman> homeThirdBasemen = _context.HomeThirdBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<HomeShortstop> homeShortstops = _context.HomeShortstops.OrderByDescending(p => p.TotalScore).ToList();
            List<HomeOutfielder> homeOutfielders = _context.HomeOutfielders.OrderByDescending(p => p.TotalScore).ToList();

            List<RhpCatcher> rhpCatchers = _context.RhpCatchers.OrderByDescending(p => p.TotalScore).ToList();
            List<RhpFirstBaseman> rhpFirstBasemen = _context.RhpFirstBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<RhpSecondBaseman> rhpSecondBasemen = _context.RhpSecondBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<RhpThirdBaseman> rhpThirdBasemen = _context.RhpThirdBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<RhpShortstop> rhpShortstops = _context.RhpShortstops.OrderByDescending(p => p.TotalScore).ToList();
            List<RhpOutfielder> rhpOutfielders = _context.RhpOutfielders.OrderByDescending(p => p.TotalScore).ToList();

            List<LhpCatcher> lhpCatchers = _context.LhpCatchers.OrderByDescending(p => p.TotalScore).ToList();
            List<LhpFirstBaseman> lhpFirstBasemen = _context.LhpFirstBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<LhpSecondBaseman> lhpSecondBasemen = _context.LhpSecondBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<LhpThirdBaseman> lhpThirdBasemen = _context.LhpThirdBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<LhpShortstop> lhpShortstops = _context.LhpShortstops.OrderByDescending(p => p.TotalScore).ToList();
            List<LhpOutfielder> lhpOutfielders = _context.LhpOutfielders.OrderByDescending(p => p.TotalScore).ToList();

            List<YesterdayCatchers> yesterdayCatchers = _context.YesterdayCatchers.OrderByDescending(p => p.TotalScore).ToList();
            List<YesterdayFirstBase> yesterdayFirstBasemen = _context.YesterdayFirstBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<YesterdaySecondBase> yesterdaySecondBasemen = _context.YesterdaySecondBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<YesterdayThirdBase> yesterdayThirdBasemen = _context.YesterdayThirdBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<YesterdayShortstop> yesterdayShortstops = _context.YesterdayShortstops.OrderByDescending(p => p.TotalScore).ToList();
            List<YesterdayOutfielder> yesterdayOutfielders = _context.YesterdayOutfielders.OrderByDescending(p => p.TotalScore).ToList();

            List<LastThreeGamesPitcher> pitcherStrikeOuts = _context.LastThreeGamesPitchers.OrderByDescending(p => p.AvgStrikeOut).Take(50).DistinctBy(p => p.PlayerID).ToList();
            List<LastThreeGamesPitcher> pitcherHomeRuns = _context.LastThreeGamesPitchers.OrderByDescending(p => p.AvgHomeRunAllowed).Take(50).DistinctBy(p => p.PlayerID).ToList();

            var teamStrikeOuts = _context.LastFiveGamesTeams.OrderByDescending(t => t.StrikeOutTotal).ToList();


            PredictorViewModel predictorViewModel = new PredictorViewModel
            {
                Pitchers = pitchers,
                Catchers = catchers,
                FirstBasemen = firstBasemen,
                SecondBasemen = secondBasemen,
                ThirdBasemen = thirdBasemen,
                ShortStops = shortstops,
                Outfielders = outfielders,
                AwayPitchers = awayPitchers,
                AwayCatchers = awayCatchers,
                AwayFirstBasemen = awayFirstBasemen,
                AwaySecondBasemen = awaySecondBasemen,
                AwayThirdBasemen = awayThirdBasemen,
                AwayShortStops = awayShortstops,
                AwayOutfielders = awayOutfielders,
                HomePitchers = homePitchers,
                HomeCatchers = homeCatchers,
                HomeFirstBasemen = homeFirstBasemen,
                HomeSecondBasemen = homeSecondBasemen,
                HomeThirdBasemen = homeThirdBasemen,
                HomeShortStops = homeShortstops,
                HomeOutfielders = homeOutfielders,
                LhpCatchers = lhpCatchers,
                LhpFirstBasemen = lhpFirstBasemen,
                LhpSecondBasemen = lhpSecondBasemen,
                LhpThirdBasemen = lhpThirdBasemen,
                LhpShortStops = lhpShortstops,
                LhpOutfielders = lhpOutfielders,
                RhpCatchers = rhpCatchers,
                RhpFirstBasemen = rhpFirstBasemen,
                RhpSecondBasemen = rhpSecondBasemen,
                RhpThirdBasemen = rhpThirdBasemen,
                RhpShortStops = rhpShortstops,
                RhpOutfielders = rhpOutfielders, 
                YesterdayCatchers = yesterdayCatchers,
                YesterdayFirstBasemen = yesterdayFirstBasemen,
                YesterdaySecondBasemen = yesterdaySecondBasemen,
                YesterdayShortstops = yesterdayShortstops,
                YesterdayOutfielders = yesterdayOutfielders,
                YesterdayThirdBasemen = yesterdayThirdBasemen,
                PitcherStrikeoutTrends = pitcherStrikeOuts,
                PitcherHRTrends = pitcherHomeRuns,
                TeamStrikeOuts = teamStrikeOuts
                

            };

            return View(predictorViewModel);
        }

        public IActionResult TestView()
        {
            List<ProjectedPitcher> pitchers = _context.ProjectedPitchers.OrderByDescending(p => p.ProjectedScore).ToList();
            List<PositionPlayer> catchers = _context.PositionPlayers.Where(p => p.Position == "C").ToList();
            List<PositionPlayer> firstBasemen = _context.PositionPlayers.Where(p => p.Position == "1B").ToList();
            List<PositionPlayer> secondBasemen = _context.PositionPlayers.Where(p => p.Position == "2B").ToList();
            List<PositionPlayer> shortstops = _context.PositionPlayers.Where(p => p.Position == "SS").ToList();
            List<PositionPlayer> thirdBasemen = _context.PositionPlayers.Where(p => p.Position == "3B").ToList();
            List<PositionPlayer> outfielders = _context.PositionPlayers.Where(p => p.Position == "OF").ToList();

            List<AwayCatcher> awayCatchers = _context.AwayCatchers.OrderByDescending(p => p.TotalScore).ToList();
            List<AwayPitcher> awayPitchers = _context.AwayPitchers.OrderByDescending(p => p.TotalScore).ToList();
            List<AwayFirstBaseman> awayFirstBasemen = _context.AwayFirstBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<AwaySecondBaseman> awaySecondBasemen = _context.AwaySecondBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<AwayThirdBaseman> awayThirdBasemen = _context.AwayThirdBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<AwayShortstop> awayShortstops = _context.AwayShortstops.OrderByDescending(p => p.TotalScore).ToList();
            List<AwayOutfielder> awayOutfielders = _context.AwayOutfielders.OrderByDescending(p => p.TotalScore).ToList();

            List<HomeCatcher> homeCatchers = _context.HomeCatchers.OrderByDescending(p => p.TotalScore).ToList();
            List<HomePitcher> homePitchers = _context.HomePitchers.OrderByDescending(p => p.TotalScore).ToList();
            List<HomeFirstBaseman> homeFirstBasemen = _context.HomeFirstBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<HomeSecondBaseman> homeSecondBasemen = _context.HomeSecondBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<HomeThirdBaseman> homeThirdBasemen = _context.HomeThirdBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<HomeShortstop> homeShortstops = _context.HomeShortstops.OrderByDescending(p => p.TotalScore).ToList();
            List<HomeOutfielder> homeOutfielders = _context.HomeOutfielders.OrderByDescending(p => p.TotalScore).ToList();

            List<RhpCatcher> rhpCatchers = _context.RhpCatchers.OrderByDescending(p => p.TotalScore).ToList();
            List<RhpFirstBaseman> rhpFirstBasemen = _context.RhpFirstBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<RhpSecondBaseman> rhpSecondBasemen = _context.RhpSecondBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<RhpThirdBaseman> rhpThirdBasemen = _context.RhpThirdBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<RhpShortstop> rhpShortstops = _context.RhpShortstops.OrderByDescending(p => p.TotalScore).ToList();
            List<RhpOutfielder> rhpOutfielders = _context.RhpOutfielders.OrderByDescending(p => p.TotalScore).ToList();

            List<LhpCatcher> lhpCatchers = _context.LhpCatchers.OrderByDescending(p => p.TotalScore).ToList();
            List<LhpFirstBaseman> lhpFirstBasemen = _context.LhpFirstBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<LhpSecondBaseman> lhpSecondBasemen = _context.LhpSecondBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<LhpThirdBaseman> lhpThirdBasemen = _context.LhpThirdBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<LhpShortstop> lhpShortstops = _context.LhpShortstops.OrderByDescending(p => p.TotalScore).ToList();
            List<LhpOutfielder> lhpOutfielders = _context.LhpOutfielders.OrderByDescending(p => p.TotalScore).ToList();

            List<YesterdayCatchers> yesterdayCatchers = _context.YesterdayCatchers.OrderByDescending(p => p.TotalScore).ToList();
            List<YesterdayFirstBase> yesterdayFirstBasemen = _context.YesterdayFirstBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<YesterdaySecondBase> yesterdaySecondBasemen = _context.YesterdaySecondBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<YesterdayThirdBase> yesterdayThirdBasemen = _context.YesterdayThirdBasemen.OrderByDescending(p => p.TotalScore).ToList();
            List<YesterdayShortstop> yesterdayShortstops = _context.YesterdayShortstops.OrderByDescending(p => p.TotalScore).ToList();
            List<YesterdayOutfielder> yesterdayOutfielders = _context.YesterdayOutfielders.OrderByDescending(p => p.TotalScore).ToList();

            List<LastThreeGamesPitcher> pitcherStrikeOuts = _context.LastThreeGamesPitchers.OrderByDescending(p => p.AvgStrikeOut).Take(50).DistinctBy(p => p.PlayerID).ToList();
            List<LastThreeGamesPitcher> pitcherHomeRuns = _context.LastThreeGamesPitchers.OrderByDescending(p => p.AvgHomeRunAllowed).Take(50).DistinctBy(p => p.PlayerID).ToList();

            var teamStrikeOuts = _context.LastFiveGamesTeams.OrderByDescending(t => t.StrikeOutTotal).ToList();


            PredictorViewModel predictorViewModel = new PredictorViewModel
            {
                Pitchers = pitchers,
                Catchers = catchers,
                FirstBasemen = firstBasemen,
                SecondBasemen = secondBasemen,
                ThirdBasemen = thirdBasemen,
                ShortStops = shortstops,
                Outfielders = outfielders,
                AwayPitchers = awayPitchers,
                AwayCatchers = awayCatchers,
                AwayFirstBasemen = awayFirstBasemen,
                AwaySecondBasemen = awaySecondBasemen,
                AwayThirdBasemen = awayThirdBasemen,
                AwayShortStops = awayShortstops,
                AwayOutfielders = awayOutfielders,
                HomePitchers = homePitchers,
                HomeCatchers = homeCatchers,
                HomeFirstBasemen = homeFirstBasemen,
                HomeSecondBasemen = homeSecondBasemen,
                HomeThirdBasemen = homeThirdBasemen,
                HomeShortStops = homeShortstops,
                HomeOutfielders = homeOutfielders,
                LhpCatchers = lhpCatchers,
                LhpFirstBasemen = lhpFirstBasemen,
                LhpSecondBasemen = lhpSecondBasemen,
                LhpThirdBasemen = lhpThirdBasemen,
                LhpShortStops = lhpShortstops,
                LhpOutfielders = lhpOutfielders,
                RhpCatchers = rhpCatchers,
                RhpFirstBasemen = rhpFirstBasemen,
                RhpSecondBasemen = rhpSecondBasemen,
                RhpThirdBasemen = rhpThirdBasemen,
                RhpShortStops = rhpShortstops,
                RhpOutfielders = rhpOutfielders,
                YesterdayCatchers = yesterdayCatchers,
                YesterdayFirstBasemen = yesterdayFirstBasemen,
                YesterdaySecondBasemen = yesterdaySecondBasemen,
                YesterdayShortstops = yesterdayShortstops,
                YesterdayOutfielders = yesterdayOutfielders,
                YesterdayThirdBasemen = yesterdayThirdBasemen,
                PitcherStrikeoutTrends = pitcherStrikeOuts,
                PitcherHRTrends = pitcherHomeRuns,
                TeamStrikeOuts = teamStrikeOuts


            };

            return View(predictorViewModel);
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
