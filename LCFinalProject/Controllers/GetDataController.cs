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

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LCFinalProject.Controllers
{
    public class GetDataController : Controller
    {
        private BeatTheShiftDbContext _context;

        public GetDataController(BeatTheShiftDbContext dbContext)
        {
            _context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            // This works

            Player player;

            string path = $"C:/Batter.xml"; //"~/xml/view-source_https___gd2.mlb.com_components_game_mlb_year_2017_month_08_day_14_gid_2017_08_14_atlmlb_colmlb_1_batters_408252.xml");

            XmlSerializer serializer = new XmlSerializer(typeof(Player));
            StreamReader reader = new StreamReader(path);

            player = (Player)serializer.Deserialize(reader);
            reader.Close();

            return View();
        }

        [HttpPost]
        public IActionResult Index(GetDataViewModel getDataViewModel)
        {
            // This doesn't work

            Player player;

            string path = "~/xml/view-source_https___gd2.mlb.com_components_game_mlb_year_2017_month_08_day_14_gid_2017_08_14_atlmlb_colmlb_1_batters_408252.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(Player));
            StreamReader reader = new StreamReader(path);

            player = (Player)serializer.Deserialize(reader);
            reader.Close();

            return View();
        }
    }
}
