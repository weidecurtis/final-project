﻿using HtmlAgilityPack;
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
        public void GetData(Game game)
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
                            } 
                        }
                    }
                }
            }


            //HtmlWeb pitcherhHw = new HtmlWeb();
            //HtmlDocument pitcherDoc = hw.Load("https://gd2.mlb.com" + game.Directory + "/pitchers");

            //var pitcherHtmlNodes = doc.DocumentNode.SelectNodes("//a[@href]");
            //if (pitcherHtmlNodes != null)
            //{
            //    foreach (HtmlNode link in pitcherHtmlNodes)
            //    {
            //        if (link != null)
            //        {
            //            HtmlAttribute att = link.Attributes["href"];
            //            string path = ("https://gd2.mlb.com" + game.Directory + "/" + att.Value);

            //            PitcherPlayer pitcher;
            //            Pitcher updatePitcher;

            //            WebClient client = new WebClient();
            //            try
            //            {
            //                string data = Encoding.Default.GetString(client.DownloadData(path));
            //                Stream stream = new MemoryStream(Encoding.UTF8.GetBytes(data));
            //                XmlSerializer serializer = new XmlSerializer(typeof(PitcherPlayer));
            //                pitcher = (PitcherPlayer)serializer.Deserialize(stream);
            //            }
            //            catch (WebException ex)
            //            {
            //                HttpWebResponse webResponse = (HttpWebResponse)ex.Response;
            //                if (webResponse.StatusCode == HttpStatusCode.NotFound)
            //                {
            //                    continue;
            //                }
            //                else
            //                {
            //                    throw;
            //                }
            //            }

            //            var existingPitcher = _context.Pitchers.Any(p => p.PlayerID == player.id);
            //            var existingPlayer = _context.PositionPlayers.Any(x => x.PlayerID == player.id);

            //            if (!existingPlayer && !existingPitcher)
            //            {
            //                if (player.pos != "P")
            //                {
            //                    newPlayer = new PositionPlayer()
            //                    {
            //                        FirstName = player.first_name,
            //                        LastName = player.last_name,
            //                        TeamName = player.team.ToUpper(),
            //                        PlayerID = player.id,
            //                        Position = player.pos
            //                    };
            //                    _context.PositionPlayers.Add(newPlayer);

            //                }
            //                else
            //                {
            //                    newPitcher = new Pitcher()
            //                    {
            //                        FirstName = player.first_name,
            //                        LastName = player.last_name,
            //                        TeamName = player.team.ToUpper(),
            //                        PlayerID = player.id
            //                    };
            //                    _context.Pitchers.Add(newPitcher);

            //                }
            //            }
            //            else
            //            {
            //                if (existingPlayer)
            //                {
            //                    updatePlayer = _context.PositionPlayers.Single(p => p.PlayerID == player.id);

            //                    updatePlayer.SeasonAb = player.season.ab;
            //                    updatePlayer.SeasonAvg = player.season.avg;
            //                    updatePlayer.SeasonCs = player.season.cs;
            //                    updatePlayer.SeasonHr = player.season.hr;
            //                    updatePlayer.SeasonOps = player.season.ops;
            //                    updatePlayer.SeasonRbi = player.season.rbi;
            //                    updatePlayer.SeasonRun = player.season.r;
            //                    updatePlayer.SeasonSb = player.season.sb;
            //                    updatePlayer.SeasonWalk = player.season.bb;
            //                    updatePlayer.VsLhpAb = player.vs_LHP.ab;
            //                    updatePlayer.VsLhpAvg = player.vs_LHP.avg;
            //                    updatePlayer.VsLhpCs = player.vs_LHP.cs;
            //                    updatePlayer.VsLhpHr = player.vs_LHP.hr;
            //                    updatePlayer.VsLhpOps = player.vs_LHP.ops;
            //                    updatePlayer.VsLhpRbi = player.vs_LHP.rbi;
            //                    updatePlayer.VsLhpRun = player.vs_LHP.r;
            //                    updatePlayer.VsLhpSb = player.vs_LHP.sb;
            //                    updatePlayer.VsLhpWalk = player.vs_LHP.bb;
            //                    updatePlayer.VsRhpAb = player.vs_RHP.ab;
            //                    updatePlayer.VsRhpAvg = player.vs_RHP.avg;
            //                    updatePlayer.VsRhpCs = player.vs_RHP.cs;
            //                    updatePlayer.VsRhpHr = player.vs_RHP.hr;
            //                    updatePlayer.VsRhpOps = player.vs_RHP.ops;
            //                    updatePlayer.VsRhpRbi = player.vs_RHP.rbi;
            //                    updatePlayer.VsRhpRun = player.vs_RHP.r;
            //                    updatePlayer.VsRhpSb = player.vs_RHP.sb;
            //                    updatePlayer.VsRhpWalk = player.vs_RHP.bb;


            //                    if (player.Team.des == "Away")
            //                    {
            //                        updatePlayer.AwayAb = player.Team.ab;
            //                        updatePlayer.AwayAvg = player.Team.avg;
            //                        updatePlayer.AwayCs = player.Team.cs;
            //                        updatePlayer.AwayHr = player.Team.hr;
            //                        updatePlayer.AwayOps = player.Team.ops;
            //                        updatePlayer.AwayRbi = player.Team.rbi;
            //                        updatePlayer.AwayRun = player.Team.r;
            //                        updatePlayer.AwaySb = player.Team.sb;
            //                        updatePlayer.AwayWalk = player.Team.bb;
            //                    }
            //                    else
            //                    {
            //                        updatePlayer.HomeAb = player.Team.ab;
            //                        updatePlayer.HomeAvg = player.Team.avg;
            //                        updatePlayer.HomeCs = player.Team.cs;
            //                        updatePlayer.HomeHr = player.Team.hr;
            //                        updatePlayer.HomeOps = player.Team.ops;
            //                        updatePlayer.HomeRbi = player.Team.rbi;
            //                        updatePlayer.HomeRun = player.Team.r;
            //                        updatePlayer.HomeSb = player.Team.sb;
            //                        updatePlayer.HomeWalk = player.Team.bb;
            //                    }
            //                    _context.PositionPlayers.Update(updatePlayer);
            //                }
            //            }
            //        }
            //    }
            //}
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
                var duplicateEntry = _context.IndividualGamePosPlayers.Where(p => p.PlayerID == singlePlayer.PlayerID).Select(gd => gd.GameDate == date);

                if (duplicateEntry != null)
                {
                    if (player.ab != 0)
                    {
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
                            Position = singlePlayer.Position
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
                    if (webResponse.StatusCode == HttpStatusCode.NotFound)
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
                            CompleteGameShutOut = completeGameShutOut
                        };

                        _context.IndividualGamePitchers.Add(newPitcher);
                    }
                }
            }

            _context.SaveChanges();
        }

        

    }
}

