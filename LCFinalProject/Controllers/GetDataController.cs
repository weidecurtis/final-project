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

            DateTime yesterday = DateTime.Today.AddDays(-1);
            var year = yesterday.ToString("yyyy");
            var month = yesterday.ToString("MM");
            var day = yesterday.ToString("dd");

            //This block loads the individual game URLs.
            WebClient webClient = new WebClient();
            //TODO Edit this to be Dynamic
            var returnedData = webClient.DownloadString(new Uri("https://gd2.mlb.com/components/game/mlb/year_" + year + "/month_" + month + "/day_" + day + "/playertracker.xml"));
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
                    var gameID = gameNode.Attributes["game_pk"].InnerText;

                    var gameDuplicate = _context.Games.Any(g => g.GameID == int.Parse(gameID));

                    if (!gameDuplicate)
                    {
                        Game newGame = new Game()
                        {
                            Directory = directory,
                            Venue = venue,
                            VenueID = int.Parse(venueID),
                            GameDate = yesterday,
                            GameID = int.Parse(gameID)
                        };

                        _context.Games.Add(newGame);
                        _context.SaveChanges();
                    }
                   
                }

            }

            //This is the List of Game URLS for that day.
            List<Game> gameUrls = new List<Game>();

            foreach (Game game in _context.Games)
            {
                if (game.GameDate == yesterday)
                {
                    gameUrls.Add(game);
                }
            }

            //This creates the List PlayerData, which is used to get the PlayerIDs off an XML page that lists them for that specific game (home vs away).
            List<string> playerData = new List<string>();

            //This genereates all data for games played **eventually** yesterday
            foreach (Game game in gameUrls)
            {

                HtmlWeb hw = new HtmlWeb();

                HtmlDocument doc = hw.Load("https://gd2.mlb.com" + game.Directory + "/batters");
                //HtmlDocument doc = hw.Load("https://gd2.mlb.com/components/game/mlb/year_2018/month_03/day_31/gid_2018_03_31_chamlb_kcamlb_1/batters/");
                foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
                {
                    HtmlAttribute att = link.Attributes["href"];
                    playerData.Add(att.Value);
                }

                playerData.RemoveAt(0);
                playerData.RemoveAt(0);
                playerData.Remove("batters//");
                playerData.Remove("/batters/595465.xml");
                playerData.Remove("batters/595465.xml");
                playerData.Remove("batters/501992.xml");
                playerData.Remove("/batters/501992.xml");
                playerData.Remove("batters/622098.xml");
                playerData.Remove("/batters/622098.xml");
                playerData.Remove("batters/476589.xml");
                playerData.Remove("/batters/476589.xml");

                foreach (string singlePlayer in playerData)
                {
                    Player player;
                    PositionPlayer newPlayer;
                    Pitcher newPitcher;
                    PositionPlayer updatePlayer;
                    Pitcher updatePitcher;


                    string path = "https://gd2.mlb.com" + game.Directory + "/" +  singlePlayer;
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

                    var existingPitcher = _context.Pitchers.Any(p => p.PlayerID == player.id);
                    var existingPlayer = _context.PositionPlayers.Any(x => x.PlayerID == player.id);

                    if (!existingPlayer && !existingPitcher)
                    {
                        if (player.pos != "P")
                        {
                            newPlayer = new PositionPlayer()
                            {
                                FirstName = player.first_name,
                                LastName = player.last_name,
                                TeamName = player.team,
                                PlayerID = player.id,
                                Position = player.pos
                            };
                            _context.PositionPlayers.Add(newPlayer);
                            _context.SaveChanges();
                        }
                        else
                        {
                            newPitcher = new Pitcher()
                            {
                                FirstName = player.first_name,
                                LastName = player.last_name,
                                TeamName = player.team,
                                PlayerID = player.id
                            };
                            _context.Pitchers.Add(newPitcher);
                            _context.SaveChanges();
                        }
                    }
                    else
                    {
                        if (existingPlayer)
                        {
                            updatePlayer = _context.PositionPlayers.Single(p => p.PlayerID == player.id);

                            
                            updatePlayer.SeasonAb = player.season.ab;
                            updatePlayer.SeasonAvg = player.season.avg;
                            updatePlayer.SeasonCs = player.season.cs;
                            updatePlayer.SeasonHr = player.season.hr;
                            updatePlayer.SeasonOps = player.season.ops;
                            updatePlayer.SeasonRbi = player.season.rbi;
                            updatePlayer.SeasonRun = player.season.r;
                            updatePlayer.SeasonSb = player.season.sb;
                            updatePlayer.SeasonWalk = player.season.bb;
                            updatePlayer.VsLhpAb = player.vs_LHP.ab;
                            updatePlayer.VsLhpAvg = player.vs_LHP.avg;
                            updatePlayer.VsLhpCs = player.vs_LHP.cs;
                            updatePlayer.VsLhpHr = player.vs_LHP.hr;
                            updatePlayer.VsLhpOps = player.vs_LHP.ops;
                            updatePlayer.VsLhpRbi = player.vs_LHP.rbi;
                            updatePlayer.VsLhpRun = player.vs_LHP.r;
                            updatePlayer.VsLhpSb = player.vs_LHP.sb;
                            updatePlayer.VsLhpWalk = player.vs_LHP.bb;
                            updatePlayer.VsRhpAb = player.vs_RHP.ab;
                            updatePlayer.VsRhpAvg = player.vs_RHP.avg;
                            updatePlayer.VsRhpCs = player.vs_RHP.cs;
                            updatePlayer.VsRhpHr = player.vs_RHP.hr;
                            updatePlayer.VsRhpOps = player.vs_RHP.ops;
                            updatePlayer.VsRhpRbi = player.vs_RHP.rbi;
                            updatePlayer.VsRhpRun = player.vs_RHP.r;
                            updatePlayer.VsRhpSb = player.vs_RHP.sb;
                            updatePlayer.VsRhpWalk = player.vs_RHP.bb;


                            if (player.Team.des == "Away")
                            {
                                updatePlayer.AwayAb = player.Team.ab;
                                updatePlayer.AwayAvg = player.Team.avg;
                                updatePlayer.AwayCs = player.Team.cs;
                                updatePlayer.AwayHr = player.Team.hr;
                                updatePlayer.AwayOps = player.Team.ops;
                                updatePlayer.AwayRbi = player.Team.rbi;
                                updatePlayer.AwayRun = player.Team.r;
                                updatePlayer.AwaySb = player.Team.sb;
                                updatePlayer.AwayWalk = player.Team.bb;
                            }
                            else
                            {
                                updatePlayer.HomeAb = player.Team.ab;
                                updatePlayer.HomeAvg = player.Team.avg;
                                updatePlayer.HomeCs = player.Team.cs;
                                updatePlayer.HomeHr = player.Team.hr;
                                updatePlayer.HomeOps = player.Team.ops;
                                updatePlayer.HomeRbi = player.Team.rbi;
                                updatePlayer.HomeRun = player.Team.r;
                                updatePlayer.HomeSb = player.Team.sb;
                                updatePlayer.HomeWalk = player.Team.bb;
                            }
                            _context.PositionPlayers.Update(updatePlayer);
                            _context.SaveChanges();
                        }
                    }
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

