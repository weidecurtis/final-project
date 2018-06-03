using HtmlAgilityPack;
using LCFinalProject.Data;
using LCFinalProject.Models.gd2Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LCFinalProject.Models
{
    public class PlayerLogic
    {
        private BeatTheShiftDbContext _context;

        public PlayerLogic(BeatTheShiftDbContext dbContext)
        {
            _context = dbContext;
        }

        // This Loads all data from previous day. Gets a list of playerIDs, checks for new players, adds / updates season stats.
        public void GetData(YesterdayGame game)
        {
            HtmlWeb hw = new HtmlWeb();
            HtmlDocument doc = hw.Load("https://gd2.mlb.com" + game.Directory + "/batters");

            var htmlNodes = doc.DocumentNode.SelectNodes("//a[@href]");
            if (htmlNodes != null)
            {
                foreach (HtmlNode link in htmlNodes)
                {
                    if (link != null)
                    {
                        HtmlAttribute att = link.Attributes["href"];
                        string path = ("https://gd2.mlb.com" + game.Directory + "/" + att.Value);

                        Player player;
                        PositionPlayer newPlayer;
                        Pitcher newPitcher;
                        PositionPlayer updatePlayer;


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
                                    TeamName = player.team.ToUpper(),
                                    PlayerID = player.id,
                                    Position = player.pos
                                };
                                _context.PositionPlayers.Add(newPlayer);

                            }
                            else
                            {
                                newPitcher = new Pitcher()
                                {
                                    FirstName = player.first_name,
                                    LastName = player.last_name,
                                    TeamName = player.team.ToUpper(),
                                    PlayerID = player.id
                                };
                                _context.Pitchers.Add(newPitcher);

                            }
                        }
                        else
                        {
                            if (existingPlayer)
                            {
                                updatePlayer = _context.PositionPlayers.Single(p => p.PlayerID == player.id);

                                updatePlayer.SeasonAb = player.season.ab;
                                updatePlayer.SeasonHit = player.season.h;
                                updatePlayer.SeasonAvg = player.season.avg;
                                updatePlayer.SeasonCs = player.season.cs;
                                updatePlayer.SeasonHr = player.season.hr;
                                updatePlayer.SeasonOps = player.season.ops;
                                updatePlayer.SeasonRbi = player.season.rbi;
                                updatePlayer.SeasonRun = player.season.r;
                                updatePlayer.SeasonSb = player.season.sb;
                                updatePlayer.SeasonWalk = player.season.bb;
                                updatePlayer.SeasonTotalScore = (updatePlayer.SeasonHit * 4) + (updatePlayer.SeasonHr * 10) + (updatePlayer.SeasonRbi * 2) + (updatePlayer.SeasonRun * 2) + (updatePlayer.SeasonWalk * 2) + (updatePlayer.SeasonSb * 5);
                                updatePlayer.VsLhpAb = player.vs_LHP.ab;
                                updatePlayer.VsLhpHit = player.vs_LHP.h;
                                updatePlayer.VsLhpAvg = player.vs_LHP.avg;
                                updatePlayer.VsLhpCs = player.vs_LHP.cs;
                                updatePlayer.VsLhpHr = player.vs_LHP.hr;
                                updatePlayer.VsLhpOps = player.vs_LHP.ops;
                                updatePlayer.VsLhpRbi = player.vs_LHP.rbi;
                                updatePlayer.VsLhpRun = player.vs_LHP.r;
                                updatePlayer.VsLhpSb = player.vs_LHP.sb;
                                updatePlayer.VsLhpWalk = player.vs_LHP.bb;
                                updatePlayer.VsLhpTotalScore = (updatePlayer.VsLhpHit * 4) + (updatePlayer.VsLhpHr * 10) + (updatePlayer.VsLhpRbi * 2) + (updatePlayer.VsLhpRun * 2) + (updatePlayer.VsLhpWalk * 2) + (updatePlayer.VsLhpSb * 5);
                                updatePlayer.VsRhpAb = player.vs_RHP.ab;
                                updatePlayer.VsRhpHit = player.vs_RHP.h;
                                updatePlayer.VsRhpAvg = player.vs_RHP.avg;
                                updatePlayer.VsRhpCs = player.vs_RHP.cs;
                                updatePlayer.VsRhpHr = player.vs_RHP.hr;
                                updatePlayer.VsRhpOps = player.vs_RHP.ops;
                                updatePlayer.VsRhpRbi = player.vs_RHP.rbi;
                                updatePlayer.VsRhpRun = player.vs_RHP.r;
                                updatePlayer.VsRhpSb = player.vs_RHP.sb;
                                updatePlayer.VsRhpWalk = player.vs_RHP.bb;
                                updatePlayer.VsRhpTotalScore = (updatePlayer.VsRhpHit * 4) + (updatePlayer.VsRhpHr * 10) + (updatePlayer.VsRhpRbi * 2) + (updatePlayer.VsRhpRun * 2) + (updatePlayer.VsRhpWalk * 2) + (updatePlayer.VsRhpSb * 5);


                                if (player.Team.des == "Away")
                                {
                                    updatePlayer.AwayAb = player.Team.ab;
                                    updatePlayer.AwayHit = player.Team.h;
                                    updatePlayer.AwayAvg = player.Team.avg;
                                    updatePlayer.AwayCs = player.Team.cs;
                                    updatePlayer.AwayHr = player.Team.hr;
                                    updatePlayer.AwayOps = player.Team.ops;
                                    updatePlayer.AwayRbi = player.Team.rbi;
                                    updatePlayer.AwayRun = player.Team.r;
                                    updatePlayer.AwaySb = player.Team.sb;
                                    updatePlayer.AwayWalk = player.Team.bb;
                                    updatePlayer.AwayTotalScore = (updatePlayer.AwayHit * 4) + (updatePlayer.AwayHr * 10) + (updatePlayer.AwayRbi * 2) + (updatePlayer.AwayRun * 2) + (updatePlayer.AwayWalk * 2) + (updatePlayer.AwaySb * 5);
                                }
                                else
                                {
                                    updatePlayer.HomeAb = player.Team.ab;
                                    updatePlayer.HomeHit = player.Team.h;
                                    updatePlayer.HomeAvg = player.Team.avg;
                                    updatePlayer.HomeCs = player.Team.cs;
                                    updatePlayer.HomeHr = player.Team.hr;
                                    updatePlayer.HomeOps = player.Team.ops;
                                    updatePlayer.HomeRbi = player.Team.rbi;
                                    updatePlayer.HomeRun = player.Team.r;
                                    updatePlayer.HomeSb = player.Team.sb;
                                    updatePlayer.HomeWalk = player.Team.bb;
                                    updatePlayer.HomeTotalScore = (updatePlayer.HomeHit * 4) + (updatePlayer.HomeHr * 10) + (updatePlayer.HomeRbi * 2) + (updatePlayer.HomeRun * 2) + (updatePlayer.HomeWalk * 2) + (updatePlayer.HomeSb * 5);
                                }
                                _context.PositionPlayers.Update(updatePlayer);
                            }
                        }
                    }
                }
                _context.SaveChanges();
            }


            HtmlWeb pitcherHw = new HtmlWeb();
            HtmlDocument pitcherDoc = pitcherHw.Load("https://gd2.mlb.com" + game.Directory + "/pitchers");

            var pitcherHtmlNodes = pitcherDoc.DocumentNode.SelectNodes("//a[@href]");
            if (pitcherHtmlNodes != null)
            {
                foreach (HtmlNode link in pitcherHtmlNodes)
                {
                    if (link != null)
                    {
                        HtmlAttribute att = link.Attributes["href"];
                        string path = ("https://gd2.mlb.com" + game.Directory + "/" + att.Value);

                        Player player;
                        Pitcher updatePitcher;
                        Pitcher newPitcher;

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
                        
                        if(!existingPitcher)
                        {

                            newPitcher = new Pitcher()
                            {
                                FirstName = player.first_name,
                                LastName = player.last_name,
                                TeamName = player.team.ToUpper(),
                                PlayerID = player.id
                            };
                            _context.Pitchers.Add(newPitcher);

                        }
                        else
                        {

                            updatePitcher = _context.Pitchers.Single(p => p.PlayerID == player.id);

                            updatePitcher.SeasonIp = player.season.ip;
                            updatePitcher.SeasonRunsAllowed = player.season.r;
                            updatePitcher.SeasonWalks = player.season.bb;
                            updatePitcher.SeasonHitsAllowed = player.season.h;
                            updatePitcher.SeasonStrikeOuts = player.season.so;
                            updatePitcher.SeasonHomeRunAllowed = player.season.hr;
                            updatePitcher.SeasonWins = player.season.w;
                            updatePitcher.SeasonTotalScore = (player.season.ip * Convert.ToDecimal(2.25)) + (player.season.r * Convert.ToDecimal(-2)) + 
                                (player.season.bb * Convert.ToDecimal(-.6)) + (player.season.h * Convert.ToDecimal(-.6)) +(player.season.so * Convert.ToDecimal(2)) + 
                                (player.season.w * Convert.ToDecimal(4));

                            if (player.season.era == "-" || player.season.era == "-.--")
                            {
                                updatePitcher.SeasonEarnedRunsAllowed = Convert.ToDecimal(0.0);
                            }
                            else
                            {
                                updatePitcher.SeasonEarnedRunsAllowed = Convert.ToDecimal(player.season.era);
                            }
                            if (player.Team.des == "Away")
                            {
                                updatePitcher.AwayIp = player.Team.ip;
                                updatePitcher.AwayHitsAllowed = player.Team.h;
                                
                                updatePitcher.AwayRunsAllowed = player.Team.r;
                                updatePitcher.AwayWalks = player.Team.bb;
                                updatePitcher.AwayStrikeOuts = player.Team.so;
                                updatePitcher.AwayHomeRunAllowed = player.Team.hr;
                                updatePitcher.AwayTotalScore = (player.Team.ip * Convert.ToDecimal(2.25)) + (player.Team.r * Convert.ToDecimal(-2)) + (player.Team.bb * Convert.ToDecimal(-.6)) + (player.season.h * Convert.ToDecimal(-.6)) + (player.Team.so * Convert.ToDecimal(2));
                                if (player.Team.era == "-" || player.Team.era == "-.--")
                                {
                                    updatePitcher.AwayEarnedRunsAllowed = Convert.ToDecimal(0.0);
                                }
                                else
                                {
                                    updatePitcher.AwayEarnedRunsAllowed = Convert.ToDecimal(player.Team.era);
                                }
                            }
                            else
                            {
                                updatePitcher.HomeIp = player.Team.ip;
                                updatePitcher.HomeHitsAllowed = player.Team.h;
                                updatePitcher.HomeRunsAllowed = player.Team.r;
                                updatePitcher.HomeWalks = player.Team.bb;
                                updatePitcher.HomeStrikeOuts = player.Team.so;
                                updatePitcher.HomeHomeRunAllowed = player.Team.hr;
                                updatePitcher.HomeTotalScore = (player.Team.ip * Convert.ToDecimal(2.25)) + (player.Team.r * Convert.ToDecimal(-2)) + (player.Team.bb * Convert.ToDecimal(-.6)) + (player.season.h * Convert.ToDecimal(-.6)) + (player.Team.so * Convert.ToDecimal(2));

                                if (player.Team.era == "-" || player.Team.era == "-.--")
                                {
                                    updatePitcher.HomeEarnedRunsAllowed = Convert.ToDecimal(0.0);
                                }
                                else
                                {
                                    updatePitcher.HomeEarnedRunsAllowed = Convert.ToDecimal(player.Team.era);
                                }
                            }
                            _context.Pitchers.Update(updatePitcher);
                            
                        }
                    }
                }
            }
            _context.SaveChanges();
        }

        // This puts entrys for individual game performances into a table.
        public void LoadYesterdayGames(DateTime dateTime)
        {

            var date = dateTime.Date;
            var year = date.ToString("yyyy");
            var month = date.ToString("MM");
            var day = date.ToString("dd");

            batting player;
            pitching pitcherPlayer;
            foreach (PositionPlayer singlePlayer in _context.PositionPlayers)
            {

                string path = "http://gd2.mlb.com/components/game/mlb/year_" + year + "/month_" + month +
                    "/day_" + day + "/batters/" + singlePlayer.PlayerID + "_1.xml";
                WebClient client = new WebClient();
                try
                {
                    string data = Encoding.Default.GetString(client.DownloadData(path));
                    Stream stream = new MemoryStream(Encoding.UTF8.GetBytes(data));
                    XmlSerializer serializer = new XmlSerializer(typeof(batting));
                    player = (batting)serializer.Deserialize(stream);
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
                var duplicateEntry = _context.IndividualGamePosPlayers.Any(p => p.PlayerID == singlePlayer.PlayerID && p.GameDate == date);

                if (!duplicateEntry)
                {
                    if (player.ab != 0)
                    {
                        if (singlePlayer.Position == "LF" || singlePlayer.Position == "RF" || singlePlayer.Position == "CF")
                        {
                            singlePlayer.Position = "OF";
                        }

                        IndividualGamePosPlayer newPlayerEntry = new IndividualGamePosPlayer()
                        {
                            FirstName = singlePlayer.FirstName,
                            LastName = singlePlayer.LastName,
                            PlayerID = singlePlayer.PlayerID,
                            GameDate = date,
                            Ab = player.ab,
                            HomeRun = player.hr,
                            Single = player.single,
                            Double = player.@double,
                            Triple = player.triple,
                            RBI = player.rbi,
                            Run = player.r,
                            CaughtStealing = player.cs,
                            StolenBase = player.sb,
                            Position = singlePlayer.Position,
                            Walk = player.bb,
                            Team = singlePlayer.TeamName,
                            StrikeOut = player.so,
                            TotalScore = (player.single * 3) + (player.@double * 5) +  (player.sb * 5) + (player.bb * 2)
                        };
                        _context.IndividualGamePosPlayers.Add(newPlayerEntry);

                    }
                }
            }

            foreach (Pitcher pitcher in _context.Pitchers)
            {
                string path = "https://gd2.mlb.com/components/game/mlb/year_" + year + "/month_" + month + "/day_" + day + "/pitchers/" + pitcher.PlayerID + "_1.xml";
                WebClient client = new WebClient();
                try
                {
                    string data = Encoding.Default.GetString(client.DownloadData(path));
                    Stream stream = new MemoryStream(Encoding.UTF8.GetBytes(data));
                    XmlSerializer serializer = new XmlSerializer(typeof(pitching));
                    pitcherPlayer = (pitching)serializer.Deserialize(stream);
                }
                catch (WebException ex)
                {
                    HttpWebResponse webResponse = (HttpWebResponse)ex.Response;
                    if (webResponse.StatusCode == HttpStatusCode.NotFound || webResponse.StatusCode == HttpStatusCode.InternalServerError)
                    {
                        continue;
                    }
                    else
                    {
                        throw;
                    }
                }

                var duplicatePitcher = _context.IndividualGamePitchers.Where(p => p.PlayerID == pitcher.PlayerID).Select(g => g.GameDate == date);

                if (duplicatePitcher != null)
                {
                    if (pitcherPlayer.ip != 0)
                    {
                        var completeGame = 0;
                        var completeGameShutOut = 0;

                        if (pitcherPlayer.ip == 9)
                        {
                            completeGame = 1;
                        }
                        if (pitcherPlayer.ip == 9 && pitcherPlayer.r == 0)
                        {
                            completeGameShutOut = 1;
                        }

                        IndividualGamePitcher newPitcher = new IndividualGamePitcher()
                        {
                            FirstName = pitcher.FirstName,
                            LastName = pitcher.LastName,
                            PlayerID = pitcher.PlayerID,
                            GameDate = date,
                            IP = pitcherPlayer.ip,
                            StrikeOuts = pitcherPlayer.k,
                            Walks = pitcherPlayer.bb,
                            EarnedRuns = pitcherPlayer.er,
                            RunsAllowed = pitcherPlayer.r,
                            HitsAllowed = pitcherPlayer.h,
                            Wins = pitcherPlayer.w,
                            Losses = pitcherPlayer.l,
                            HomeRunsAllowed = pitcherPlayer.hra,
                            CompleteGame = completeGame,
                            CompleteGameShutOut = completeGameShutOut,
                            TotalScore = (pitcherPlayer.ip * Convert.ToDecimal(2.25)) + (pitcherPlayer.r * Convert.ToDecimal(-2)) + (pitcherPlayer.bb * Convert.ToDecimal(-.6)) + (pitcherPlayer.h * Convert.ToDecimal(-.6)) + (pitcherPlayer.k * Convert.ToDecimal(2)) + (completeGame * Convert.ToDecimal(2.5)) + (completeGameShutOut * Convert.ToDecimal(2.5))
                    };
                        _context.IndividualGamePitchers.Add(newPitcher);
                    }
                }
            }
            _context.SaveChanges();
        }
    }
}

