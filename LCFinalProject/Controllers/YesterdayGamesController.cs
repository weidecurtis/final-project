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
    public class YesterdayGamesController : Controller
    {
        private BeatTheShiftDbContext _context;

        public YesterdayGamesController(BeatTheShiftDbContext dbContext)
        {
            _context = dbContext;
        }

        public IActionResult Index()
        {

            DateTime yesterday = DateTime.Now.AddDays(-1);
            var year = yesterday.ToString("yyyy");
            var month = yesterday.ToString("MM");
            var day = yesterday.ToString("dd");

            PitcherPlayer player;


            foreach (Pitcher pitcher in _context.Pitchers)
            {
                string path = "https://gd2.mlb.com/components/game/mlb/year_" + year + "/month_" + month + "/day_" + day + "/pitchers/" + pitcher.PlayerID + "_1.xml";
                WebClient client = new WebClient();
                try
                {
                    string data = Encoding.Default.GetString(client.DownloadData(path));
                    Stream stream = new MemoryStream(Encoding.UTF8.GetBytes(data));
                    XmlSerializer serializer = new XmlSerializer(typeof(PitcherPlayer));
                    player = (PitcherPlayer)serializer.Deserialize(stream);
                }
                catch (WebException ex)
                {
                    HttpWebResponse webResponse = (HttpWebResponse)ex.Response;
                    if (webResponse.StatusCode == HttpStatusCode.NotFound)
                    {
                        continue;
                    }
                    else
                    {
                        throw;
                    }
                }

                
                IndividualGamePitcher newPitcher = new IndividualGamePitcher()
                {
                    FirstName = pitcher.FirstName,
                    LastName = pitcher.LastName,
                    PlayerID = pitcher.PlayerID,
                    GameDate = yesterday
                };


            }
            return View();
        }
    }
}
