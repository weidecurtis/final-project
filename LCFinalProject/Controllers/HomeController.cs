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
            List<PositionPlayer> catchers = _context.PositionPlayers.Where(p => p.Position == "C").Where(p => p.LastFiveTotalScore >= 40).ToList();
            List<PositionPlayer> firstBasemen = _context.PositionPlayers.Where(p => p.Position == "1B").Where(p => p.LastFiveTotalScore >= 40).ToList();
            List<PositionPlayer> secondBasemen = _context.PositionPlayers.Where(p => p.Position == "2B").Where(p => p.LastFiveTotalScore >= 40).ToList();
            List<PositionPlayer> shortstops = _context.PositionPlayers.Where(p => p.Position == "SS").Where(p => p.LastFiveTotalScore >= 40).ToList();
            List<PositionPlayer> thirdBasemen = _context.PositionPlayers.Where(p => p.Position == "3B").Where(p => p.LastFiveTotalScore >= 40).ToList();
            List<PositionPlayer> outfielders = _context.PositionPlayers.Where(p => p.Position == "OF").Where(p => p.LastFiveTotalScore >= 40).ToList();
            List<Team> teams = _context.Teams.ToList();

           


            PredictorViewModel predictorViewModel = new PredictorViewModel
            {
                Pitchers = pitchers,
                Catchers = catchers,
                FirstBasemen = firstBasemen,
                SecondBasemen = secondBasemen,
                ThirdBasemen = thirdBasemen,
                ShortStops = shortstops,
                Outfielders = outfielders,
                Teams = teams

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
