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

        public IActionResult Index()
        {
            //This block loads the individual game URLs.
            WebClient webClient = new WebClient();
            //TODO Edit this to be Dynamic
            var returnedData = webClient.DownloadString(new Uri("https://gd2.mlb.com/components/game/mlb/year_2017/month_07/day_18/playertracker.xml"));
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(returnedData);
            var gameNodes = xml.GetElementsByTagName("game");
            if (gameNodes != null)
            {
                for (int i = 0; i < gameNodes.Count; i++)
                {

                    var gameNode = gameNodes.Item(i);

                    var directory = gameNode.Attributes["game_data_directory"].InnerText;
                    var venue = gameNode.Attributes["venue"].InnerText;
                    var venueID = gameNode.Attributes["venue_id"].InnerText;
                    var date = gameNode.Attributes["original_date"].InnerText;

                    Game newGame = new Game()
                    {
                        Directory = directory,
                        Venue = venue,
                        VenueID = int.Parse(venueID),
                        GameDate = date
                    };

                    _context.Games.Add(newGame);
                    _context.SaveChanges();
                }


            }



            //TODO Need to make this Dynamic to YESTERDAY'S GAME
            string todaydate = "2017/07/18";

            //This is the List of Game URLS for that day.
            List<Game> gameUrls = new List<Game>();

            foreach (Game game in _context.Games)
            {
                if (game.GameDate == todaydate)
                {
                    gameUrls.Add(game);
                }
            }

            //This creates the List PlayerData, which is used to get the PlayerIDs off an XML page that lists them for that specific game (home vs away).
            List<string> playerData = new List<string>();

            //This genereates all data for games played **eventually** yesterday
            foreach (Game game in gameUrls)
            {


                // This Loads data for Players into a doc

                HtmlWeb hw = new HtmlWeb();
                //HtmlDocument doc = hw.Load("https://gd2.mlb.com/components/game/mlb/year_2017/month_07/day_18/gid_2017_07_18_texmlb_balmlb_1/batters/");
                HtmlDocument doc = hw.Load("https://gd2.mlb.com" + game.Directory + "/batters");
                foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
                {
                    HtmlAttribute att = link.Attributes["href"];
                    playerData.Add(att.Value);
                }

            // This removes the first two links of the page (Parent Directory and '/', and that troublesome 607219)

                playerData.RemoveAt(0);
                playerData.RemoveAt(0);
                playerData.Remove("batters//");
                playerData.Remove("/batters/595465.xml");
                playerData.Remove("batters/595465.xml");


                foreach (string singlePlayer in playerData)
                {


                    //if (game.Venue == "Oriole Park at Camden Yards")
                    //{
                        Player player;
                        PositionPlayer newPlayer;
                        //Pitcher newPitcher;


                        string path = "https://gd2.mlb.com" + game.Directory + "/" + singlePlayer;
                        WebClient client = new WebClient();
                        try
                        {
                            string data = Encoding.Default.GetString(client.DownloadData(path));
                            Stream stream = new MemoryStream(Encoding.UTF8.GetBytes(data));
                            XmlSerializer serializer = new XmlSerializer(typeof(Player));
                            player = (Player)serializer.Deserialize(stream);
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



                        var existingPlayer = _context.PositionPlayers.Any(x => x.PlayerID == player.id);

                        if (!existingPlayer)
                        {
                            newPlayer = new PositionPlayer()
                            {
                                PlayerID = player.id,
                                FirstName = player.first_name,
                                LastName = player.last_name,
                                MonthAb = player.month.ab,
                                MonthHit = player.month.h,
                                MonthAvg = player.month.avg,
                                MonthWalk = player.month.bb,
                                MonthRun = player.month.r,
                                MonthRbi = player.month.rbi,
                                MonthHr = player.month.hr,
                                MonthOps = player.month.ops,
                                MonthSb = player.month.sb,
                                MonthCs = player.month.cs,
                                TeamName = player.team.ToUpper()
                            };
                            _context.PositionPlayers.Add(newPlayer);
                            _context.SaveChanges();
                        }
                    //}
                }



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

