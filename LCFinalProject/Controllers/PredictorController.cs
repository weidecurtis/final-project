using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LCFinalProject.Data;
using LCFinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using HtmlAgilityPack;
using System.Xml;
using LCFinalProject.Models.gd2Models;
using System.Xml.Serialization;
using System.IO;
using Microsoft.IdentityModel.Protocols;
using LCFinalProject.Models;
using System.Net;
using System.Text;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LCFinalProject.Controllers
{
    public class PredictorController : Controller
    {
        private BeatTheShiftDbContext _context;

        public PredictorController(BeatTheShiftDbContext dbContext)
        {
            _context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<ProjectedPitcher> pitchers = _context.ProjectedPitchers.OrderByDescending(p => p.ProjectedScore).ToList();
            List<ProjectedFirstBaseman> firstBasemen = _context.ProjectedFirstBasemen.OrderByDescending(p => p.ProjectedScore).ToList();
            List<ProjectedSecondBaseman> secondBasemen = _context.ProjectedSecondBasemen.OrderByDescending(p => p.ProjectedScore).ToList();
            List<ProjectedShortstop> shortstops = _context.ProjectedShortstops.OrderByDescending(p => p.ProjectedScore).ToList();
            List<ProjectedThirdBaseman> thirdBasemen = _context.ProjectedThirdBasemen.OrderByDescending(p => p.ProjectedScore).ToList();
            List<ProjectedOutfielder> outfielders = _context.ProjectedOutfielders.OrderByDescending(p => p.ProjectedScore).ToList();

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


            PredictorViewModel predictorViewModel = new PredictorViewModel
            {
                //Pitchers = pitchers,
                //FirstBasemen = firstBasemen,
                //SecondBasemen = secondBasemen,
                //ThirdBasemen = thirdBasemen,
                //ShortStops = shortstops,
                //Outfielders = outfielders,
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
                RhpOutfielders = rhpOutfielders
            };

            return View(predictorViewModel);
        }
    }
}
