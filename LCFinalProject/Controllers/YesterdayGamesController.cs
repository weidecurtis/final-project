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
    [XmlType("urlset")]
    public class YesterdayGamesController : Controller
    {
        private BeatTheShiftDbContext _context;

        public YesterdayGamesController(BeatTheShiftDbContext dbContext)
        {
            _context = dbContext;
        }

        public IActionResult Index()
        {

            //DateTime yesterday = DateTime.Today.AddDays(-1);
            //var year = yesterday.ToString("yyyy");
            //var month = yesterday.ToString("MM");
            //var day = yesterday.ToString("dd");

            //PitcherPlayer player;


            //foreach (Pitcher pitcher in _context.Pitchers)
            //{
            //    string path = "https://gd2.mlb.com/components/game/mlb/year_" + year + "/month_" + month + "/day_" + day + "/pitchers/" + pitcher.PlayerID + "_1.xml";
            //    WebClient client = new WebClient();
            //    try
            //    {
            //        string data = Encoding.Default.GetString(client.DownloadData(path));
            //        Stream stream = new MemoryStream(Encoding.UTF8.GetBytes(data));
            //        XmlSerializer serializer = new XmlSerializer(typeof(PitcherPlayer));
            //        player = (PitcherPlayer)serializer.Deserialize(stream);
            //    }
            //    catch (WebException ex)
            //    {
            //        HttpWebResponse webResponse = (HttpWebResponse)ex.Response;
            //        if (webResponse.StatusCode == HttpStatusCode.NotFound)
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }


            //    IndividualGamePitcher newPitcher = new IndividualGamePitcher()
            //    {
            //        FirstName = pitcher.FirstName,
            //        LastName = pitcher.LastName,
            //        PlayerID = pitcher.PlayerID,
            //        GameDate = yesterday
            //    };


            //}

            DateTime yesterday = DateTime.Now.AddDays(-1);
            var year = yesterday.ToString("yyyy");
            var month = yesterday.ToString("MM");
            var day = yesterday.ToString("dd");

            Player player;


            foreach (PositionPlayer playa in _context.PositionPlayers)
            {
                WebClient client = new WebClient();
                var path = "http://gd2.mlb.com/components/game/mlb/year_" + year + "/month_" + month +
                    "/day_" + day + "/batters/" + playa.PlayerID + "_1.xml";
                var returnedData = client.DownloadString(new Uri(path));
                var batterXmlDoc = new XmlDocument();

                var battingNodes = batterXmlDoc.GetElementsByTagName("batting");

                if (battingNodes != null)
                {
                    var battingNode = battingNodes.Item(0);

                    var singles = battingNode.Attributes["single"].InnerText;
                    var runs = battingNode.Attributes["r"].InnerText;
                    var hits = battingNode.Attributes["h"].InnerText;
                    var rbi = battingNode.Attributes["rbi"].InnerText;
                    var stolenBase = battingNode.Attributes["sb"].InnerText;
                    var dbl = battingNode.Attributes["double"].InnerText;
                    var triple = battingNode.Attributes["triple"].InnerText;
                    var walk = battingNode.Attributes["bb"].InnerText;
                    var atbat = battingNode.Attributes["ab"].InnerText;
                    var homeRun = battingNode.Attributes["hr"].InnerText;

                    var caughtStealing = battingNode.Attributes["cs"].InnerText;

                    IndividualGamePosPlayer newPosPlayer = new IndividualGamePosPlayer()
                    {
                        PlayerID = playa.PlayerID,
                        FirstName = playa.FirstName,
                        LastName = playa.LastName,
                        GameDate = yesterday,
                        Ab = int.Parse(atbat),
                        Run = int.Parse(runs),
                        Single = int.Parse(singles),
                        Double = int.Parse(dbl),
                        Triple = int.Parse(triple),
                        HomeRun = int.Parse(homeRun),
                        Walk = int.Parse(walk),
                        StolenBase = int.Parse(stolenBase),
                        CaughtStealing = int.Parse(caughtStealing)
                    };

                    _context.IndividualGamePosPlayers.Add(newPosPlayer);
                    _context.SaveChanges();
                }
                



                IndividualGamePitcher newPitcher = new IndividualGamePitcher()
                {
                    FirstName = playa.FirstName,
                    LastName = playa.LastName,
                    PlayerID = playa.PlayerID,
                    GameDate = yesterday
                };


            }
            return View();
        }
    }
}
