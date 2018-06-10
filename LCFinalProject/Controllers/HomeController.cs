﻿using System;
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
            List<Pitcher> pitchers = _context.Pitchers.Where(p => p.ProbableStarter == true).ToList();
            var pitcherNight = pitchers.Where(p => p.TeamName == "Braves" || p.TeamName == "Dodgers").ToList();
            List<PositionPlayer> catchers = _context.PositionPlayers.Where(p => p.Position == "C" && p.Salary > 0 && p.SeasonAb > 50 && p.LastFiveTotalScore > 25 && p.Starting == true).ToList();
            var catcherNight = catchers.Where(p => p.LastFiveDeviance < 10 && p.LastFiveDeviance > -5).ToList();
            List<PositionPlayer> firstBasemen = _context.PositionPlayers.Where(p => p.Position == "1B" && p.Salary > 0 && p.SeasonAb > 50 && p.LastFiveTotalScore > 25 && p.Starting == true).ToList();
            var firstNight = firstBasemen.Where(p => p.LastFiveDeviance < 10 && p.LastFiveDeviance > -5).ToList();
            List<PositionPlayer> secondBasemen = _context.PositionPlayers.Where(p => p.Position == "2B" && p.Salary > 0 && p.SeasonAb > 50 && p.LastFiveTotalScore > 25 && p.Starting == true).ToList();
            var secondNight = secondBasemen.Where(p => p.LastFiveDeviance < 10 && p.LastFiveDeviance > -5).ToList();
            List<PositionPlayer> shortstops = _context.PositionPlayers.Where(p => p.Position == "SS" && p.Salary > 0 && p.SeasonAb > 50 && p.LastFiveTotalScore > 25 && p.Starting == true).ToList();
            var shortNight = shortstops.Where(p => p.LastFiveDeviance < 10 && p.LastFiveDeviance > -5).ToList();
            List<PositionPlayer> thirdBasemen = _context.PositionPlayers.Where(p => p.Position == "3B" && p.Salary > 0 && p.SeasonAb > 50 && p.LastFiveTotalScore > 25 && p.Starting == true).ToList();
            var thirdNight = thirdBasemen.Where(p => p.LastFiveDeviance < 10 && p.LastFiveDeviance > -5).ToList();
            List<PositionPlayer> outfielders = _context.PositionPlayers.Where(p => p.Position == "OF" && p.Salary > 0 && p.SeasonAb > 50 && p.LastFiveTotalScore > 25 && p.Starting == true).ToList();
            var outfieldNight = outfielders.Where(p => p.LastFiveDeviance < 10 && p.LastFiveDeviance > -5).ToList();

            List<Team> teams = _context.Teams.ToList();
            List<ProjectedTeam> projectedTeams = _context.ProjectedTeams.ToList();

           


            PredictorViewModel predictorViewModel = new PredictorViewModel
            {
                Pitchers = pitchers,
                Catchers = catcherNight,
                FirstBasemen = firstNight,
                SecondBasemen = secondNight,
                ThirdBasemen = thirdNight,
                ShortStops = shortNight,
                Outfielders = outfieldNight,
                Teams = teams,
                ProjectedTeams = projectedTeams

            };

            return View(predictorViewModel);
        }

        public IActionResult TestView()
        {
            List<Pitcher> pitchers = _context.Pitchers.ToList();
            List<PositionPlayer> catchers = _context.PositionPlayers.Where(p => p.Position == "C").ToList();
            List<PositionPlayer> firstBasemen = _context.PositionPlayers.Where(p => p.Position == "1B").ToList();
            List<PositionPlayer> secondBasemen = _context.PositionPlayers.Where(p => p.Position == "2B").ToList();
            List<PositionPlayer> shortstops = _context.PositionPlayers.Where(p => p.Position == "SS").ToList();
            List<PositionPlayer> thirdBasemen = _context.PositionPlayers.Where(p => p.Position == "3B").ToList();
            List<PositionPlayer> outfielders = _context.PositionPlayers.Where(p => p.Position == "OF").ToList();



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
            };

            return View(predictorViewModel);
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
