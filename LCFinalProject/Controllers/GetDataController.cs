﻿using System;
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


namespace LCFinalProject.Controllers
{
    [XmlRoot("urlset")]
    public class GetDataController : Controller
    {
        private BeatTheShiftDbContext _context;

        public GetDataController(BeatTheShiftDbContext dbContext)
        {
            _context = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(GetDataViewModel getDataViewModel)
        {

            var gameLogic = new GameLogic(_context);

            DateTime yesterday = DateTime.Today.Date.AddDays(-1);
            var date = yesterday.Date;
            var year = date.ToString("yyyy");
            var month = date.ToString("MM");
            var day = date.ToString("dd");


            string strJson = "http://statsapi.mlb.com/api/v1/schedule?sportId=1&date=" + month + "/" + day + "/" + year;
            //string strJson = "http://statsapi.mlb.com/api/v1/schedule?sportId=1&date=03/28/2019";

            //This gets the List of Game URLS for that day.

            //List<Game> gameUrls = gameLogic.UpdateYesterdayGames(strJson, yesterday);

            //foreach (Game game in gameUrls)
            //{
            //    gameLogic.GetBatterData(game);
            //    gameLogic.GetPitcherData(game);
            //}

            foreach (var game in _context.TopGames)
            {
                var player = _context.Batters.Where(p => p.PlayerID == game.PlayerID).FirstOrDefault(); ;

                game.PlayerName = player.FirstName + " " + player.LastName;
            }
            _context.SaveChanges();
            //gameLogic.TopGameData(yesterday);

            





            //gameLogic.UpdateRecentGames();
            return Redirect("GetData/Test");
        }

        public IActionResult Test()
        {
          




            //predictorLogic.ChangeAllToStartersForDataGathering();
            //_context.SaveChanges();

            //predictorLogic.TodayGameData();
            //_context.SaveChanges();

            //predictorLogic.TestAssignStarters();
            //_context.SaveChanges();

            //predictorLogic.UpdateTeams();
            //_context.SaveChanges();


            //predictorLogic.AssignSalaries();
            //_context.SaveChanges();

            //predictorLogic.GetDeviance();
            //_context.SaveChanges();
            //predictorLogic.GetProjections();
            //_context.SaveChanges();

            //predictorLogic.NewPitcher();
            //predictorLogic.TestTeamProjections();
            //predictorLogic.GetTeamProjections();
            _context.SaveChanges();
            //predictorLogic.YesterdayTotalScore();
            //_context.SaveChanges();


            return View();
        }
    }
}

