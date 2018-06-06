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

            
            DateTime yesterday = DateTime.Today.Date.AddDays(-1);

            ////This gets the List of Game URLS for that day.
            var gameLogic = new GameLogic(_context);
            List<YesterdayGame> gameUrls = gameLogic.GetGames(yesterday);

            ////This loops through each player in each game.
            var playerLogic = new PlayerLogic(_context);
            foreach (YesterdayGame game in gameUrls)
            {
                playerLogic.GetData(game);
            }
            ////This loops through every players individual stats for that day
            playerLogic.LoadYesterdayGames(yesterday);
            





            return Redirect("GetData/Test");
        }

        public IActionResult Test()
        {
            PredictorLogic predictorLogic = new PredictorLogic(_context);

            //predictorLogic.IndividualTotalScore();
            //_context.SaveChanges();
            //predictorLogic.RefreshTeams();
            //_context.SaveChanges();
            //predictorLogic.UpdatePlayers();
            //_context.SaveChanges();
            //predictorLogic.UpdateTeamNames();
            //_context.SaveChanges();
            //predictorLogic.TodayGameData();
            //_context.SaveChanges();
            //predictorLogic.UpdateTeams();
            //_context.SaveChanges();
            //predictorLogic.UpdateTriplesAndDoubles();
            //_context.SaveChanges();
            //predictorLogic.GetTeamGameDates();
            //_context.SaveChanges();
            //predictorLogic.AssignSalaries();
            //_context.SaveChanges();
            //predictorLogic.AssignStarters();
            //_context.SaveChanges();
            predictorLogic.GetProjections();
            _context.SaveChanges();
            //predictorLogic.GetDeviance();
            //_context.SaveChanges();

            //predictorLogic.TestTeamProjections();
            //predictorLogic.GetTeamProjections();


            return View();
        }
    }
}

