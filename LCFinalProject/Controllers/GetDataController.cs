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
           

            for (int i = 0; i >= -3; i--)
            {
                DateTime yesterday = DateTime.Today.Date.AddDays(i);
                var date = yesterday.Date;
                var year = date.ToString("yyyy");
                var month = date.ToString("MM");
                var day = date.ToString("dd");


                string strJson = "http://statsapi.mlb.com/api/v1/schedule?sportId=1&date=" + month + "/" + day + "/" + year;


                ////This gets the List of Game URLS for that day.
                var gameLogic = new GameLogic(_context);
                List<Game> gameUrls = gameLogic.UpdateYesterdayGames(strJson);

                foreach (Game game in gameUrls)
                {
                    gameLogic.GetData(game);
                }

            }
           

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

