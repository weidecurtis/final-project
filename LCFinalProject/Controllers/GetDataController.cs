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
    [XmlRoot("urlset")]
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
            List<string> playerData = new List<string>();

            HtmlWeb hw = new HtmlWeb();
            HtmlDocument doc = hw.Load("https://gd2.mlb.com/components/game/mlb/year_2017/month_07/day_18/gid_2017_07_18_arimlb_cinmlb_1/batters/");

            foreach(HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
            {
                HtmlAttribute att = link.Attributes["href"];
                playerData.Add(att.Value);
            }

            // This removes the first two links of the page (Parent Directory and '/')
            playerData.RemoveAt(0);
            playerData.RemoveAt(0);

            foreach (string singlePlayer in playerData)
            {
                string waterfall = singlePlayer;
                Player player;

                string path = "https://gd2.mlb.com/components/game/mlb/year_2017/month_07/day_18/gid_2017_07_18_arimlb_cinmlb_1/batters/" + singlePlayer;
                WebClient client = new WebClient();

                string data = Encoding.Default.GetString(client.DownloadData(path));

                Stream stream = new MemoryStream(Encoding.UTF8.GetBytes(data));

                XmlSerializer serializer = new XmlSerializer(typeof(Player));
                //StreamReader reader = new StreamReader(path);

                player = (Player)serializer.Deserialize(stream);
                //reader.Close();

                PositionPlayer newPlayer = new PositionPlayer()
                {
                    PlayerID = player.id,
                    FirstName = player.first_name,
                    LastName = player.last_name
                };

                _context.PositionPlayers.Add(newPlayer);
                _context.SaveChanges();
            }



            return View();



        }

        [HttpPost]
        public IActionResult Index(GetDataViewModel getDataViewModel)
        {

            return View();
        }
    }
}
