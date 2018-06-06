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
using MoreLinq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using static LCFinalProject.Models.gd2Models.GameData;
using System.Xml;

namespace LCFinalProject.Models
{
    public class PredictorLogic
    {
        private BeatTheShiftDbContext _context;

        public PredictorLogic(BeatTheShiftDbContext dbContext)
        {
            _context = dbContext;
        }

        public void UpdateTeamNames()
        {
            foreach (var player in _context.IndividualGamePosPlayers)
            {
                if (player.Team == "ANA")
                {
                    player.Team = "Angels";
                }
                if (player.Team == "ARI")
                {
                    player.Team = "Diamondbacks";
                }
                if (player.Team == "ATL")
                {
                    player.Team = "Braves";
                }
                if (player.Team == "BAL")
                {
                    player.Team = "Orioles";
                }
                if (player.Team == "BOS")
                {
                    player.Team = "Red Sox";
                }
                if (player.Team == "CHA")
                {
                    player.Team = "White Sox";
                }
                if (player.Team == "CHN")
                {
                    player.Team = "Cubs";
                }
                if (player.Team == "CIN")
                {
                    player.Team = "Reds";
                }
                if (player.Team == "CLE")
                {
                    player.Team = "Indians";
                }
                if (player.Team == "COL")
                {
                    player.Team = "Rockies";
                }
                if (player.Team == "DET")
                {
                    player.Team = "Tigers";
                }
                if (player.Team == "HOU")
                {
                    player.Team = "Astros";
                }
                if (player.Team == "KCA")
                {
                    player.Team = "Royals";
                }
                if (player.Team == "LAN")
                {
                    player.Team = "Dodgers";
                }
                if (player.Team == "MIA")
                {
                    player.Team = "Marlins";
                }
                if (player.Team == "MIL")
                {
                    player.Team = "Brewers";
                }
                if (player.Team == "MIN")
                {
                    player.Team = "Twins";
                }
                if (player.Team == "NYA")
                {
                    player.Team = "Yankees";
                }
                if (player.Team == "NYN")
                {
                    player.Team = "Mets";
                }
                if (player.Team == "OAK")
                {
                    player.Team = "Athletics";
                }
                if (player.Team == "PHI")
                {
                    player.Team = "Phillies";
                }
                if (player.Team == "PIT")
                {
                    player.Team = "Pirates";
                }
                if (player.Team == "SDN")
                {
                    player.Team = "Padres";
                }
                if (player.Team == "SEA")
                {
                    player.Team = "Mariners";
                }
                if (player.Team == "SFN")
                {
                    player.Team = "Giants";
                }
                if (player.Team == "SLN")
                {
                    player.Team = "Cardinals";
                }
                if (player.Team == "TBA")
                {
                    player.Team = "Rays";
                }
                if (player.Team == "TEX")
                {
                    player.Team = "Rangers";
                }
                if (player.Team == "TOR")
                {
                    player.Team = "Blue Jays";
                }
                if (player.Team == "WAS")
                {
                    player.Team = "Nationals";
                }

                if (player.Team == "D-backs")
                {
                    player.Team = "Diamondbacks";
                }
            }

            foreach (var player in _context.PositionPlayers)
            {
                if (player.TeamName == "ANA")
                {
                    player.TeamName = "Angels";
                }
                if (player.TeamName == "ARI")
                {
                    player.TeamName = "Diamondbacks";
                }
                if (player.TeamName == "ATL")
                {
                    player.TeamName = "Braves";
                }
                if (player.TeamName == "BAL")
                {
                    player.TeamName = "Orioles";
                }
                if (player.TeamName == "BOS")
                {
                    player.TeamName = "Red Sox";
                }
                if (player.TeamName == "CHA")
                {
                    player.TeamName = "White Sox";
                }
                if (player.TeamName == "CHN")
                {
                    player.TeamName = "Cubs";
                }
                if (player.TeamName == "CIN")
                {
                    player.TeamName = "Reds";
                }
                if (player.TeamName == "CLE")
                {
                    player.TeamName = "Indians";
                }
                if (player.TeamName == "COL")
                {
                    player.TeamName = "Rockies";
                }
                if (player.TeamName == "DET")
                {
                    player.TeamName = "Tigers";
                }
                if (player.TeamName == "HOU")
                {
                    player.TeamName = "Astros";
                }
                if (player.TeamName == "KCA")
                {
                    player.TeamName = "Royals";
                }
                if (player.TeamName == "LAN")
                {
                    player.TeamName = "Dodgers";
                }
                if (player.TeamName == "MIA")
                {
                    player.TeamName = "Marlins";
                }
                if (player.TeamName == "MIL")
                {
                    player.TeamName = "Brewers";
                }
                if (player.TeamName == "MIN")
                {
                    player.TeamName = "Twins";
                }
                if (player.TeamName == "NYA")
                {
                    player.TeamName = "Yankees";
                }
                if (player.TeamName == "NYN")
                {
                    player.TeamName = "Mets";
                }
                if (player.TeamName == "OAK")
                {
                    player.TeamName = "Athletics";
                }
                if (player.TeamName == "PHI")
                {
                    player.TeamName = "Phillies";
                }
                if (player.TeamName == "PIT")
                {
                    player.TeamName = "Pirates";
                }
                if (player.TeamName == "SDN")
                {
                    player.TeamName = "Padres";
                }
                if (player.TeamName == "SEA")
                {
                    player.TeamName = "Mariners";
                }
                if (player.TeamName == "SFN")
                {
                    player.TeamName = "Giants";
                }
                if (player.TeamName == "SLN")
                {
                    player.TeamName = "Cardinals";
                }
                if (player.TeamName == "TBA")
                {
                    player.TeamName = "Rays";
                }
                if (player.TeamName == "TEX")
                {
                    player.TeamName = "Rangers";
                }
                if (player.TeamName == "TOR")
                {
                    player.TeamName = "Blue Jays";
                }
                if (player.TeamName == "WAS")
                {
                    player.TeamName = "Nationals";
                }

                if (player.TeamName == "D-backs")
                {
                    player.TeamName = "Diamondbacks";
                }

            }

            foreach (var player in _context.Pitchers)
            {
                if (player.TeamName == "ANA")
                {
                    player.TeamName = "Angels";
                }
                if (player.TeamName == "ARI")
                {
                    player.TeamName = "Diamondbacks";
                }
                if (player.TeamName == "ATL")
                {
                    player.TeamName = "Braves";
                }
                if (player.TeamName == "BAL")
                {
                    player.TeamName = "Orioles";
                }
                if (player.TeamName == "BOS")
                {
                    player.TeamName = "Red Sox";
                }
                if (player.TeamName == "CHA")
                {
                    player.TeamName = "White Sox";
                }
                if (player.TeamName == "CHN")
                {
                    player.TeamName = "Cubs";
                }
                if (player.TeamName == "CIN")
                {
                    player.TeamName = "Reds";
                }
                if (player.TeamName == "CLE")
                {
                    player.TeamName = "Indians";
                }
                if (player.TeamName == "COL")
                {
                    player.TeamName = "Rockies";
                }
                if (player.TeamName == "DET")
                {
                    player.TeamName = "Tigers";
                }
                if (player.TeamName == "HOU")
                {
                    player.TeamName = "Astros";
                }
                if (player.TeamName == "KCA")
                {
                    player.TeamName = "Royals";
                }
                if (player.TeamName == "LAN")
                {
                    player.TeamName = "Dodgers";
                }
                if (player.TeamName == "MIA")
                {
                    player.TeamName = "Marlins";
                }
                if (player.TeamName == "MIL")
                {
                    player.TeamName = "Brewers";
                }
                if (player.TeamName == "MIN")
                {
                    player.TeamName = "Twins";
                }
                if (player.TeamName == "NYA")
                {
                    player.TeamName = "Yankees";
                }
                if (player.TeamName == "NYN")
                {
                    player.TeamName = "Mets";
                }
                if (player.TeamName == "OAK")
                {
                    player.TeamName = "Athletics";
                }
                if (player.TeamName == "PHI")
                {
                    player.TeamName = "Phillies";
                }
                if (player.TeamName == "PIT")
                {
                    player.TeamName = "Pirates";
                }
                if (player.TeamName == "SDN")
                {
                    player.TeamName = "Padres";
                }
                if (player.TeamName == "SEA")
                {
                    player.TeamName = "Mariners";
                }
                if (player.TeamName == "SFN")
                {
                    player.TeamName = "Giants";
                }
                if (player.TeamName == "SLN")
                {
                    player.TeamName = "Cardinals";
                }
                if (player.TeamName == "TBA")
                {
                    player.TeamName = "Rays";
                }
                if (player.TeamName == "TEX")
                {
                    player.TeamName = "Rangers";
                }
                if (player.TeamName == "TOR")
                {
                    player.TeamName = "Blue Jays";
                }
                if (player.TeamName == "WAS")
                {
                    player.TeamName = "Nationals";
                }

                if (player.TeamName == "D-backs")
                {
                    player.TeamName = "Diamondbacks";
                }

            }
        }


        private List<string> teams = new List<string>(new string[] { "Angels", "Diamondbacks", "Braves", "Orioles", "Red Sox", "White Sox", "Cubs", "Reds", "Indians", "Rockies", "Tigers", "Astros", "Royals", "Dodgers",
            "Marlins", "Brewers", "Twins", "Yankees", "Athletics", "Phillies", "Pirates", "Padres", "Mariners", "Giants", "Cardinals", "Rays", "Rangers", "Blue Jays", "Mets", "Nationals"});

        public void RefreshTeams()
        {
            foreach (var team in _context.Teams)
            {
                _context.Remove(team);
            }

            foreach (var team in teams)
            {
                Team newTeam = new Team()
                {
                    TeamName = team
                };

                _context.Teams.Add(newTeam);
            }
        }

        public void IndividualTotalScore()
        {
            foreach (var player in _context.IndividualGamePosPlayers)
            {
                player.TotalScore = (player.Single * 3) + (player.Double * 5) + (player.StolenBase * 5) + (player.Walk * 2) + (player.Triple * 7) + (player.HomeRun * 10) + (player.Run * 2) + (player.RBI * 2);
            }
        }

        //This gathers all data for players (home/away splits .. vs lhp and rhp)
        public void UpdatePlayers()
        {


            foreach (var player in _context.PositionPlayers)
            {
                if (player.AwayAb != 0 && player.HomeAb != 0 && player.VsLhpTotalScore != 0 && player.VsRhpTotalScore != 0)
                {
                    player.AwayScorePerAB = player.AwayTotalScore / player.AwayAb;
                    player.HomeScorePerAB = player.HomeTotalScore / player.HomeAb;
                    player.VsLhpScorePerAB = player.VsLhpTotalScore / player.VsLhpAb;
                    player.VsRhpScorePerAB = player.VsRhpTotalScore / player.VsRhpAb;
                }
                _context.PositionPlayers.Update(player);

            }

            foreach (var player in _context.PositionPlayers)
            {
                var posPlayer = _context.IndividualGamePosPlayers.Where(p => p.PlayerID == player.PlayerID && p.Played == true).OrderByDescending(p => p.GameDate).FirstOrDefault();

                if (posPlayer != null)
                {
                    player.YesterdayTotalScore = posPlayer.TotalScore;
                }

                _context.PositionPlayers.Update(player);

            };

            foreach (var player in _context.PositionPlayers)
            {
                var lastFive = _context.IndividualGamePosPlayers.Where(p => p.PlayerID == player.PlayerID && p.Played == true).OrderByDescending(p => p.GameDate).Take(5);

                if (lastFive != null)
                {
                    decimal totalScore = 0;

                    var hr = 0;
                    var hits = 0;
                    var doubles = 0;
                    var triples = 0;
                    var walks = 0;
                    var runs = 0;
                    var rbi = 0;
                    var ab = 0;
                    var sb = 0;

                    foreach (var game in lastFive)
                    {
                        totalScore += game.TotalScore;
                        rbi += game.RBI;
                        hr += game.HomeRun;
                        hits += game.Single + game.Double + game.Triple + game.HomeRun;
                        doubles += game.Double;
                        walks += game.Walk;
                        runs += game.Run;
                        triples += game.Triple;
                        ab += game.Ab;
                        sb += game.StolenBase;
                    }

                    player.LastFiveHR = hr;
                    player.LastFiveHit = hits;
                    player.LastFiveDouble = doubles;
                    player.LastFiveTriple = triples;
                    player.LastFiveRuns = runs;
                    player.LastFiveRBI = rbi;
                    player.LastFiveWalk = walks;
                    player.LastFiveAb = ab;
                    player.LastFiveTotalScore = totalScore;
                    player.LastFiveSB = sb;
                    _context.PositionPlayers.Update(player);
                }

            }

            foreach (var pitcher in _context.Pitchers)
            {
                if (pitcher.AwayIp != 0 && pitcher.HomeIp != 0)
                {
                    pitcher.AwayPointsPerIP = pitcher.AwayTotalScore / pitcher.AwayIp;
                    pitcher.HomePointsPerIP = pitcher.HomeTotalScore / pitcher.HomeIp;

                    _context.Pitchers.Update(pitcher);
                }

            }

            foreach (var pitcher in _context.Pitchers)
            {
                var lastThree = _context.IndividualGamePitchers.Where(p => p.PlayerID == pitcher.PlayerID).OrderByDescending(p => p.GameDate).Take(3);

                if (lastThree != null)
                {
                    decimal totalScore = 0;
                    decimal ip = 0;
                    int strikeouts = 0;
                    int homeruns = 0;
                    int runs = 0;
                    int hits = 0;
                    int walks = 0;

                    foreach (var game in lastThree)
                    {
                        totalScore += game.TotalScore;
                        ip += game.IP;
                        strikeouts += game.StrikeOuts;
                        homeruns += game.HomeRunsAllowed;
                        runs += game.EarnedRuns;
                        hits += game.HitsAllowed;
                        walks += game.Walks;
                    }
                    pitcher.LastThreeHitsAllowed = hits;
                    pitcher.LastThreeERA = runs;
                    pitcher.LastThreeHRA = homeruns;
                    pitcher.LastThreeStrikeouts = strikeouts;
                    pitcher.LastThreeTotalScore = totalScore;
                    pitcher.LastThreeInningsPitched = ip;
                    pitcher.LastThreeWalks = walks;

                    _context.Pitchers.Update(pitcher);
                }
            }


            foreach (var pitcher in _context.Pitchers)
            {
                var lastStart = _context.IndividualGamePitchers.Where(p => p.PlayerID == pitcher.PlayerID).OrderByDescending(p => p.GameDate).FirstOrDefault();

                if (lastStart != null)
                {
                    pitcher.LastStartScore = lastStart.TotalScore;
                    _context.Pitchers.Update(pitcher);
                }

            }
            foreach (var pitcherPlayer in _context.IndividualGamePitchers)
            {
                pitcherPlayer.TotalScore = (pitcherPlayer.IP * Convert.ToDecimal(2.25)) + (pitcherPlayer.EarnedRuns * Convert.ToDecimal(-2)) + (pitcherPlayer.Walks * Convert.ToDecimal(-.6)) + (pitcherPlayer.HitsAllowed * Convert.ToDecimal(-.6)) + (pitcherPlayer.StrikeOuts * Convert.ToDecimal(2)) + (pitcherPlayer.CompleteGame * Convert.ToDecimal(2.5)) + (pitcherPlayer.CompleteGameShutOut * Convert.ToDecimal(2.5));


                _context.IndividualGamePitchers.Update(pitcherPlayer);
            }

            _context.SaveChanges();
        }


        public void UpdateTeams()
        {

            foreach (var team in _context.Teams)
            {
                team.Hits = 0;
                team.HitsAllowed = 0;
                team.HomeRuns = 0;
                team.HomeRunsAllowed = 0;
                team.StrikeOuts = 0;
                team.Runs = 0;
                team.Walks = 0;
                team.RunsAllowed = 0;
                team.PointsGivenUp = 0;

                var lastFiveGames = _context.TeamGameDates.Where(t => t.TeamName == team.TeamName).OrderByDescending(t => t.GameDate).Take(5).ToList();

                foreach (var game in lastFiveGames)
                {
                    foreach (var player in _context.IndividualGamePosPlayers.Where(p => p.Team == game.TeamName && p.GameDate == game.GameDate))
                    {
                        int hits = team.Hits;
                        int strikeOuts = team.StrikeOuts;
                        int homeRuns = team.HomeRuns;
                        int runs = team.Runs;
                        int walks = team.Walks;

                        hits += player.Single + player.Double + player.Triple + player.HomeRun;
                        strikeOuts += player.StrikeOut;
                        homeRuns += player.HomeRun;
                        runs += player.Run;
                        walks += player.Walk;

                        team.Hits = hits;
                        team.StrikeOuts = strikeOuts;
                        team.HomeRuns = homeRuns;
                        team.Runs = runs;
                        team.Walks = walks;

                    }

                    foreach (var pitcher in _context.IndividualGamePitchers.Where(p => p.TeamName == game.TeamName && p.GameDate == game.GameDate))
                    {
                        decimal runsAllowed = team.RunsAllowed;
                        decimal homeRunsAllowed = team.HomeRunsAllowed;
                        decimal hitsAllowed = team.HitsAllowed;
                        decimal pointsGivenUp = team.PointsGivenUp;

                        runsAllowed += pitcher.RunsAllowed;
                        homeRunsAllowed += pitcher.HomeRunsAllowed;
                        hitsAllowed += pitcher.HitsAllowed;
                        pointsGivenUp += (pitcher.HitsAllowed * 3) + (pitcher.RunsAllowed * 2) + (pitcher.HomeRunsAllowed * 10);

                        team.HomeRunsAllowed = homeRunsAllowed;
                        team.RunsAllowed = runsAllowed;
                        team.HitsAllowed = hitsAllowed;
                        team.PointsGivenUp = pointsGivenUp;
                    }
                }

            }

            foreach (var team in _context.Teams)
            {
                var starter = _context.Pitchers.Where(p => p.TeamName == team.TeamName && p.ProbableStarter == true).FirstOrDefault();

                if (starter != null)
                {
                    team.Opponent = starter.Opponent;
                    team.Starter = starter.FirstName + " " + starter.LastName;
                    team.HomeAway = starter.HomeAway;
                }

                team.TotalPoints = (team.Hits * 3) + (team.Runs * 2) + (team.HomeRuns * 10) + (team.StrikeOuts * -2);
            }
        }

        private static readonly HttpClient starterClient = new HttpClient();

        public void TodayGameData()
        {
            foreach (var team in _context.Teams)
            {
                team.OpponentStarter = "UNKNOWN";
            }

            foreach (var pitcher in _context.Pitchers)
            {
                pitcher.ProbableStarter = false;
                pitcher.MatchUp = null;
                _context.Pitchers.Update(pitcher);
            }

            var date = DateTime.Today.Date;
            var year = date.ToString("yyyy");
            var month = date.ToString("MM");
            var day = date.ToString("dd");

            WebClient webClient = new WebClient();
            var returnedData = webClient.DownloadString(new Uri("https://gd2.mlb.com/components/game/mlb/year_" + year + "/month_" + month + "/day_" + day + "/miniscoreboard.xml"));
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(returnedData);
            var awayPitcherNodes = xml.GetElementsByTagName("away_probable_pitcher");
            var homePitcherNodes = xml.GetElementsByTagName("home_probable_pitcher");
            var gameMatchUpNodes = xml.GetElementsByTagName("media");
            var gameNodes = xml.GetElementsByTagName("game");



            if (awayPitcherNodes != null)
            {
                for (int i = 0; i < awayPitcherNodes.Count; i++)
                {
                    var awayPitcherNode = awayPitcherNodes.Item(i);
                    var gameMatchUpNode = gameMatchUpNodes.Item(i);
                    var gameNode = gameNodes.Item(i);

                    var awayPitcherID = awayPitcherNode.Attributes["id"].InnerText;
                    var awayPitcherFirstName = awayPitcherNode.Attributes["first_name"].InnerText;
                    var awayPitcherLastName = awayPitcherNode.Attributes["last_name"].InnerText;
                    var awayPitcherThrowingHand = awayPitcherNode.Attributes["throwinghand"].InnerText;
                    var awayPitcherTeam = gameNode.Attributes["away_team_name"].InnerText;

                    if (awayPitcherTeam == "D-backs")
                    {
                        awayPitcherTeam = "Diamondbacks";
                    }
                    var opponentPitcherTeam = gameNode.Attributes["home_team_name"].InnerText;
                    if (opponentPitcherTeam == "D-backs")
                    {
                        opponentPitcherTeam = "Diamondbacks";
                    }
                    var matchUp = gameMatchUpNode.Attributes["title"].InnerText;


                    var startingPitcher = _context.Pitchers.Where(p => p.PlayerID.ToString() == awayPitcherID).FirstOrDefault();
                    var pitcherTeam = _context.Teams.Where(p => p.TeamName == awayPitcherTeam).FirstOrDefault();

                    pitcherTeam.HomeAway = "Away";
                    pitcherTeam.Opponent = opponentPitcherTeam;
                    _context.Teams.Update(pitcherTeam);

                    if (startingPitcher != null)
                    {
                        startingPitcher.ProbableStarter = true;
                        startingPitcher.ThrowingHand = awayPitcherThrowingHand;
                        startingPitcher.TeamName = awayPitcherTeam;
                        startingPitcher.Opponent = opponentPitcherTeam;
                        startingPitcher.MatchUp = matchUp;
                        startingPitcher.HomeAway = "Away";



                        _context.Pitchers.Update(startingPitcher);
                    }

                    if (startingPitcher == null && awayPitcherID != "")
                    {
                        Pitcher newPitcher = new Pitcher()
                        {
                            FirstName = awayPitcherFirstName,
                            LastName = awayPitcherLastName,
                            PlayerID = int.Parse(awayPitcherID),
                            ThrowingHand = awayPitcherThrowingHand,
                            ProbableStarter = true,
                            TeamName = awayPitcherTeam,
                            Opponent = opponentPitcherTeam,
                            MatchUp = matchUp,
                            HomeAway = "Away"
                        };

                        _context.Pitchers.Add(newPitcher);
                    }


                }

            }

            if (homePitcherNodes != null)
            {
                for (int i = 0; i < homePitcherNodes.Count; i++)
                {
                    var homePitcherNode = homePitcherNodes.Item(i);
                    var gameMatchUpNode = gameMatchUpNodes.Item(i);
                    var gameNode = gameNodes.Item(i);

                    var homePitcherID = homePitcherNode.Attributes["id"].InnerText;
                    var homePitcherFirstName = homePitcherNode.Attributes["first_name"].InnerText;
                    var homePitcherLastName = homePitcherNode.Attributes["last_name"].InnerText;
                    var homePitcherThrowingHand = homePitcherNode.Attributes["throwinghand"].InnerText;
                    var homePitcherTeam = gameNode.Attributes["home_team_name"].InnerText;
                    var opponentPitcherTeam = gameNode.Attributes["away_team_name"].InnerText;

                    if (opponentPitcherTeam == "D-backs")
                    {
                        opponentPitcherTeam = "Diamondbacks";
                    }


                    var matchUp = gameMatchUpNode.Attributes["title"].InnerText;
                    var pitcherTeam = _context.Teams.Where(p => p.TeamName == homePitcherTeam).FirstOrDefault();

                    if (homePitcherTeam == "D-backs")
                    {
                        homePitcherTeam = "Diamondbacks";
                    }

                    if (pitcherTeam != null)
                    {
                        pitcherTeam.HomeAway = "Home";
                        pitcherTeam.Opponent = opponentPitcherTeam;
                        _context.Teams.Update(pitcherTeam);
                    }




                    var startingPitcher = _context.Pitchers.Where(p => p.PlayerID.ToString() == homePitcherID).FirstOrDefault();

                    if (startingPitcher != null)
                    {
                        startingPitcher.ProbableStarter = true;
                        startingPitcher.ThrowingHand = homePitcherThrowingHand;
                        startingPitcher.MatchUp = matchUp;
                        startingPitcher.TeamName = homePitcherTeam;
                        startingPitcher.Opponent = opponentPitcherTeam;
                        startingPitcher.HomeAway = "Home";

                        _context.Pitchers.Update(startingPitcher);
                    }

                    //if (startingPitcher == null)
                    //{
                    //    Pitcher newPitcher = new Pitcher()
                    //    {
                    //        FirstName = homePitcherFirstName,
                    //        LastName = homePitcherLastName,
                    //        PlayerID = int.Parse(homePitcherID),
                    //        ThrowingHand = homePitcherThrowingHand,
                    //        ProbableStarter = true,
                    //        TeamName = homePitcherTeam,
                    //        Opponent = opponentPitcherTeam,
                    //        MatchUp = matchUp,
                    //        HomeAway = "Home"
                    //    };

                    //    _context.Pitchers.Add(newPitcher);
                    //}


                }

            }

            foreach (var pitcher in _context.Pitchers)
            {
                if (pitcher.ThrowingHand == "Right")
                {
                    pitcher.ThrowingHand = "RHP";
                }

                if (pitcher.ThrowingHand == "Left")
                {
                    pitcher.ThrowingHand = "LHP";
                }
                _context.Update(pitcher);
            }


            _context.SaveChanges();

        }

        public void AssignStarters()
        {
            foreach (var team in _context.Teams)
            {
                var opponent = _context.Teams.Where(p => p.TeamName == team.Opponent).FirstOrDefault();

                if (opponent != null)
                {
                    opponent.OpponentStarter = team.Starter;
                    opponent.Opponent = team.TeamName;
                    if (opponent.HomeAway == "Away")
                    {
                        team.HomeAway = "Home";
                    }
                    if (opponent.HomeAway == "Home")
                    {
                        team.HomeAway = "Away";
                    }
                    _context.Teams.Update(team);
                }
            }

            foreach (var team in _context.Teams)
            {
                List<PositionPlayer> positionPlayers = _context.PositionPlayers.Where(p => p.TeamName == team.TeamName).ToList();
                Pitcher opponentStarter = _context.Pitchers.Where(p => p.TeamName == team.Opponent && p.ProbableStarter == true).FirstOrDefault();
                Pitcher starter = _context.Pitchers.Where(p => p.TeamName == team.TeamName && p.ProbableStarter == true).FirstOrDefault();

                if (starter != null)
                {
                    team.Starter = starter.FirstName + " " + starter.LastName;
                }
                else
                {
                    team.Starter = "UNKNOWN";
                }




                if (opponentStarter != null)
                {
                    team.OpponentStarter = opponentStarter.FirstName + " " + opponentStarter.LastName;

                    foreach (var player in positionPlayers)
                    {
                        player.HomeAway = team.HomeAway;
                        player.OpponentStarter = team.OpponentStarter;
                        player.MatchUp = opponentStarter.MatchUp;
                        player.OpponentThrowingHand = opponentStarter.ThrowingHand;
                        player.OpponentPointsLastThree = opponentStarter.LastThreeTotalScore;
                        player.OpponentHRALastThree = opponentStarter.LastThreeHRA;
                        _context.Update(player);
                    }
                }
                else
                {
                    foreach (var player in positionPlayers)
                    {
                        player.OpponentStarter = "UNKNOWN";
                    }
                }

            }
        }


        public void AssignSalaries()
        {
            foreach (var player in _context.PositionPlayers)
            {
                player.Salary = 0;
            }

            foreach (var player in _context.Pitchers)
            {
                player.Salary = 0;
            }

            using (var reader = new StreamReader(@"C:\Users\cweid\source\repos\final-project\LCFinalProject\CSV\DKSalaries.csv"))
            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    listA.Add(values[0]);
                    listB.Add(values[8]);

                    var currentPitcher = _context.Pitchers.Where(p => p.FirstName + " " + p.LastName == values[2]).FirstOrDefault();
                    var currentPlayer = _context.PositionPlayers.Where(p => p.FirstName + " " + p.LastName == values[2]).FirstOrDefault();

                    if (currentPitcher != null && values[4] == "P")
                    {
                        currentPitcher.Salary = int.Parse(values[5]);
                        currentPitcher.DKID = int.Parse(values[3]);

                        _context.Pitchers.Update(currentPitcher);
                    }

                    if (currentPlayer != null && values[4] != "P")
                    {
                        currentPlayer.Salary = int.Parse(values[5]);
                        currentPlayer.DKID = int.Parse(values[3]);

                        _context.PositionPlayers.Update(currentPlayer);
                    }
                }

            }


        }

        public void GetProjections()
        {

            foreach (var player in _context.PositionPlayers)
            {
                if (player.MatchUp != null)
                {
                    var playerTeam = _context.Teams.Where(p => p.TeamName == player.TeamName).FirstOrDefault();
                    var opponentStarter = _context.Pitchers.Where(p => p.FirstName + " " + p.LastName == playerTeam.OpponentStarter).FirstOrDefault();
                    var opponent = _context.Teams.Where(p => p.TeamName == playerTeam.Opponent).FirstOrDefault();
                    var lastGame = _context.IndividualGamePosPlayers.Where(p => p.PlayerID == player.PlayerID && p.Played == true).OrderByDescending(p => p.GameDate).FirstOrDefault();



                    decimal pitcherAwayHit = 1;
                    decimal pitcherAwayRun = 1;
                    decimal pitcherAwayHr = 1;
                    decimal pitcherAwayWalk = 1;
                    decimal pitcherHomeHit = 1;
                    decimal pitcherHomeRun = 1;
                    decimal pitcherHomeHr = 1;
                    decimal pitcherHomeWalk = 1;
                    decimal opponentTeamRA = opponent.RunsAllowed / Convert.ToDecimal(135);
                    decimal opponentTeamHRA = opponent.HomeRunsAllowed / Convert.ToDecimal(135);
                    decimal opponentTeamPoints = opponent.PointsGivenUp / Convert.ToDecimal(135);
                    decimal opponentTeamHits = opponent.HitsAllowed / Convert.ToDecimal(135);
                    decimal opponentTeamWalks = opponent.Walks / Convert.ToDecimal(135);

                    if (opponentStarter.HomeIp != 0 && opponentStarter.AwayIp != 0)
                    {
                        pitcherAwayHit = opponentStarter.AwayHitsAllowed / Convert.ToDecimal(opponentStarter.AwayIp);
                        pitcherAwayRun = opponentStarter.AwayRunsAllowed / Convert.ToDecimal(opponentStarter.AwayIp);
                        pitcherAwayHr = opponentStarter.AwayHomeRunAllowed / Convert.ToDecimal(opponentStarter.AwayIp);
                        pitcherAwayWalk = opponentStarter.AwayWalks / Convert.ToDecimal(opponentStarter.AwayIp);
                        pitcherHomeHit = opponentStarter.HomeHitsAllowed / Convert.ToDecimal(opponentStarter.HomeIp);
                        pitcherHomeRun = opponentStarter.HomeRunsAllowed / Convert.ToDecimal(opponentStarter.HomeIp);
                        pitcherHomeHr = opponentStarter.HomeHomeRunAllowed / Convert.ToDecimal(opponentStarter.HomeIp);
                        pitcherHomeWalk = opponentStarter.HomeWalks / Convert.ToDecimal(opponentStarter.HomeIp);
                    }
                    decimal opponentHRA = opponentStarter.LastThreeHRA / Convert.ToDecimal(5);
                    decimal opponentHits = opponentStarter.LastThreeHitsAllowed / Convert.ToDecimal(5);
                    decimal opponentWalks = opponentStarter.LastThreeWalks / Convert.ToDecimal(5);
                    decimal opponentRuns = opponentStarter.LastThreeERA / Convert.ToDecimal(5);

                    decimal playerHR = player.LastFiveHR / Convert.ToDecimal(7);
                    decimal playerHit = player.LastFiveHit / Convert.ToDecimal(7);
                    decimal playerWalk = player.LastFiveWalk / Convert.ToDecimal(7);
                    decimal playerR = player.LastFiveRuns / Convert.ToDecimal(7);
                    decimal playerRBI = player.LastFiveRBI / Convert.ToDecimal(7);
                    decimal playerDouble = player.LastFiveDouble / Convert.ToDecimal(7);
                    decimal playerTriple = player.LastFiveTriple / Convert.ToDecimal(7);
                    decimal playerSB = player.LastFiveSB / Convert.ToDecimal(7);
                    decimal projectedHit = Convert.ToDecimal(0);
                    decimal projectedDouble = Convert.ToDecimal(0);
                    decimal projectedTriple = Convert.ToDecimal(0);
                    decimal projectedHR = Convert.ToDecimal(0);
                    decimal projectedWalk = Convert.ToDecimal(0);
                    decimal projectedR = Convert.ToDecimal(0);
                    decimal projectedRBI = Convert.ToDecimal(0);
                    decimal projectedSB = Convert.ToDecimal(0);

                    if (lastGame != null && lastGame.GameDate < DateTime.Today.Date.AddDays(-10))
                    {
                        player.YesterdayTotalScore = 0;
                        player.LastFiveTotalScore = 0;
                        player.Projection = 0;
                    }



                    if (opponentStarter != null && lastGame != null && lastGame.GameDate > DateTime.Today.Date.AddDays(-7))
                    {
                        if (player.HomeAway == "Away")
                        {

                            if (opponentStarter.ThrowingHand == "RHP" && player.AwayAb != 0 && player.LastFiveTotalScore != 0 && player.VsRhpAb != 0)
                            {
                                projectedHit = (((player.VsRhpHit / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.AwayHit / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveHit / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentHits / Convert.ToDecimal(3)) + (pitcherHomeHit / Convert.ToDecimal(9)) + (opponentTeamHits) / Convert.ToDecimal(6));
                                projectedHR = (((player.VsRhpHr / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.AwayHr / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveHR / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentHRA / Convert.ToDecimal(3)) + (pitcherHomeHr / Convert.ToDecimal(9)) + (opponentTeamHRA) / Convert.ToDecimal(6));
                                projectedDouble = ((player.LastFiveDouble / player.LastFiveAb) + ((player.SeasonDouble / player.SeasonAb) * Convert.ToDecimal(3)) + ((projectedHR) * Convert.ToDecimal(2))) / Convert.ToDecimal(3);
                                projectedTriple = ((player.LastFiveTriple / player.LastFiveAb) + ((player.SeasonTriple / player.SeasonAb) * Convert.ToDecimal(3)) + ((projectedHR) * Convert.ToDecimal(2))) / Convert.ToDecimal(3);
                                projectedR = (((player.VsRhpRun / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.AwayRun / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveRuns / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentRuns / Convert.ToDecimal(3)) + (pitcherHomeRun / Convert.ToDecimal(9)) + (opponentTeamRA) / Convert.ToDecimal(6));
                                projectedRBI = (((player.VsRhpRbi / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.AwayRbi / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveRBI / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentRuns / Convert.ToDecimal(3)) + (pitcherHomeRun / Convert.ToDecimal(9)) + (opponentTeamRA) / Convert.ToDecimal(6));
                                projectedWalk = (((player.VsRhpWalk / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.AwayWalk / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveWalk / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentWalks / Convert.ToDecimal(3)) + (pitcherHomeWalk / Convert.ToDecimal(9)) + (opponentTeamWalks) / Convert.ToDecimal(6));
                                projectedSB = ((player.VsRhpSb / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.AwaySb / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveSB / player.LastFiveAb) * Convert.ToDecimal(2) / Convert.ToDecimal(3));

                                player.ProjectedHit = projectedHit;
                                player.ProjectedDouble = projectedDouble;
                                player.ProjectedTriple = projectedTriple;
                                player.ProjectedHR = projectedHR;
                                player.ProjectedRun = projectedR;
                                player.ProjectedRBI = projectedRBI;
                                player.ProjectedWalk = projectedWalk;
                                player.ProjectedSB = projectedSB;

                                player.Projection = (projectedHit * Convert.ToDecimal(3)) + (projectedDouble * Convert.ToDecimal(2)) + (projectedTriple * Convert.ToDecimal(4)) + (projectedHR * Convert.ToDecimal(10)) + (projectedSB * Convert.ToDecimal(5)) + (projectedWalk * Convert.ToDecimal(2)) + (projectedR * Convert.ToDecimal(2)) + (projectedRBI * Convert.ToDecimal(2));
                                _context.PositionPlayers.Update(player);
                            }

                            if (opponentStarter.ThrowingHand == "LHP" && player.AwayAb != 0 && player.LastFiveTotalScore != 0 && player.VsLhpAb != 0)
                            {
                                projectedHit = (((player.VsLhpHit / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.AwayHit / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveHit / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentHits / Convert.ToDecimal(3)) + (pitcherHomeHit / Convert.ToDecimal(9)) + (opponentTeamHits) / Convert.ToDecimal(6));
                                projectedHR = (((player.VsLhpHr / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.AwayHr / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveHR / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentHRA / Convert.ToDecimal(3)) + (pitcherHomeHr / Convert.ToDecimal(9)) + (opponentTeamHRA) / Convert.ToDecimal(6));
                                projectedDouble = ((player.LastFiveDouble / player.LastFiveAb) + ((player.SeasonDouble / player.SeasonAb) * Convert.ToDecimal(3)) + ((projectedHR) * Convert.ToDecimal(2))) / Convert.ToDecimal(3);
                                projectedTriple = ((player.LastFiveTriple / player.LastFiveAb) + ((player.SeasonTriple / player.SeasonAb) * Convert.ToDecimal(3)) + ((projectedHR) * Convert.ToDecimal(2))) / Convert.ToDecimal(3);
                                projectedR = (((player.VsLhpRun / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.AwayRun / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveRuns / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentRuns / Convert.ToDecimal(3)) + (pitcherHomeRun / Convert.ToDecimal(9)) + (opponentTeamRA) / Convert.ToDecimal(6));
                                projectedRBI = (((player.VsLhpRbi / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.AwayRbi / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveRBI / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentRuns / Convert.ToDecimal(3)) + (pitcherHomeRun / Convert.ToDecimal(9)) + (opponentTeamRA) / Convert.ToDecimal(6));
                                projectedWalk = (((player.VsLhpWalk / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.AwayWalk / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveWalk / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentWalks / Convert.ToDecimal(3)) + (pitcherHomeWalk / Convert.ToDecimal(9)) + (opponentTeamWalks) / Convert.ToDecimal(6));
                                projectedSB = ((player.VsLhpSb / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.AwaySb / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveSB / player.LastFiveAb) * Convert.ToDecimal(2) / Convert.ToDecimal(3));

                                player.ProjectedHit = projectedHit;
                                player.ProjectedDouble = projectedDouble;
                                player.ProjectedTriple = projectedTriple;
                                player.ProjectedHR = projectedHR;
                                player.ProjectedRun = projectedR;
                                player.ProjectedRBI = projectedRBI;
                                player.ProjectedWalk = projectedWalk;
                                player.ProjectedSB = projectedSB;

                                player.Projection = (projectedHit * Convert.ToDecimal(3)) + (projectedDouble * Convert.ToDecimal(2)) + (projectedTriple * Convert.ToDecimal(4)) + (projectedHR * Convert.ToDecimal(10)) + (projectedSB * Convert.ToDecimal(5)) + (projectedWalk * Convert.ToDecimal(2)) + (projectedR * Convert.ToDecimal(2)) + (projectedRBI * Convert.ToDecimal(2));
                                _context.PositionPlayers.Update(player);
                            }
                        }

                        if (player.HomeAway == "Home")
                        {
                            if (opponentStarter.ThrowingHand == "RHP" && player.HomeAb != 0 && player.LastFiveTotalScore != 0 && player.VsRhpAb != 0)
                            {
                                projectedHit = (((player.VsRhpHit / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeHit / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveHit / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentHits / Convert.ToDecimal(3)) + (pitcherAwayHit / Convert.ToDecimal(9)) + (opponentTeamHits) / Convert.ToDecimal(6));
                                projectedHR = (((player.VsRhpHr / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeHr / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveHR / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentHRA / Convert.ToDecimal(3)) + (pitcherAwayHr / Convert.ToDecimal(9)) + (opponentTeamHRA) / Convert.ToDecimal(6));
                                projectedDouble = ((player.LastFiveDouble / player.LastFiveAb) + ((player.SeasonDouble / player.SeasonAb) * Convert.ToDecimal(3)) + ((projectedHR) * Convert.ToDecimal(2))) / Convert.ToDecimal(3);
                                projectedTriple = ((player.LastFiveTriple / player.LastFiveAb) + ((player.SeasonTriple / player.SeasonAb) * Convert.ToDecimal(3)) + ((projectedHR) * Convert.ToDecimal(2))) / Convert.ToDecimal(3);
                                projectedR = (((player.VsRhpRun / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeRun / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveRuns / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentRuns / Convert.ToDecimal(3)) + (pitcherAwayRun / Convert.ToDecimal(9)) + (opponentTeamRA) / Convert.ToDecimal(6));
                                projectedRBI = (((player.VsRhpRbi / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeRbi / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveRBI / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentRuns / Convert.ToDecimal(3)) + (pitcherAwayRun / Convert.ToDecimal(9)) + (opponentTeamRA) / Convert.ToDecimal(6));
                                projectedWalk = (((player.VsRhpWalk / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeWalk / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveWalk / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentWalks / Convert.ToDecimal(3)) + (pitcherAwayWalk / Convert.ToDecimal(9)) + (opponentTeamWalks) / Convert.ToDecimal(6));
                                projectedSB = ((player.VsRhpSb / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeSb / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveSB / player.LastFiveAb) * Convert.ToDecimal(2) / Convert.ToDecimal(3));

                                player.ProjectedHit = projectedHit;
                                player.ProjectedDouble = projectedDouble;
                                player.ProjectedTriple = projectedTriple;
                                player.ProjectedHR = projectedHR;
                                player.ProjectedRun = projectedR;
                                player.ProjectedRBI = projectedRBI;
                                player.ProjectedWalk = projectedWalk;
                                player.ProjectedSB = projectedSB;

                                player.Projection = (projectedHit * Convert.ToDecimal(3)) + (projectedDouble * Convert.ToDecimal(2)) + (projectedTriple * Convert.ToDecimal(4)) + (projectedHR * Convert.ToDecimal(10)) + (projectedSB * Convert.ToDecimal(5)) + (projectedWalk * Convert.ToDecimal(2)) + (projectedR * Convert.ToDecimal(2)) + (projectedRBI * Convert.ToDecimal(2));
                                _context.PositionPlayers.Update(player);
                            }

                            if (opponentStarter.ThrowingHand == "LHP" && player.HomeAb != 0 && player.LastFiveTotalScore != 0 && player.VsLhpAb != 0)
                            {
                                projectedHit = (((player.VsLhpHit / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeHit / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveHit / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentHits / Convert.ToDecimal(3)) + (pitcherAwayHit / Convert.ToDecimal(9) + (opponentTeamHits)) / Convert.ToDecimal(6));
                                projectedHR = (((player.VsLhpHr / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeHr / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveHR / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentHRA / Convert.ToDecimal(3)) + (pitcherAwayHr / Convert.ToDecimal(9)) + (opponentTeamHRA) / Convert.ToDecimal(6));
                                projectedDouble = ((player.LastFiveDouble / player.LastFiveAb) + ((player.SeasonDouble / player.SeasonAb) * Convert.ToDecimal(3)) + ((projectedHR) * Convert.ToDecimal(2))) / Convert.ToDecimal(3);
                                projectedTriple = ((player.LastFiveTriple / player.LastFiveAb) + ((player.SeasonTriple / player.SeasonAb) * Convert.ToDecimal(3)) + ((projectedHR) * Convert.ToDecimal(2))) / Convert.ToDecimal(3);
                                projectedR = (((player.VsLhpRun / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeRun / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveRuns / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentRuns / Convert.ToDecimal(3)) + (pitcherAwayRun / Convert.ToDecimal(9)) + (opponentTeamRA) / Convert.ToDecimal(6));
                                projectedRBI = (((player.VsLhpRbi / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeRbi / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveRBI / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentRuns / Convert.ToDecimal(3)) + (pitcherAwayRun / Convert.ToDecimal(9)) + (opponentTeamRA) / Convert.ToDecimal(6));
                                projectedWalk = (((player.VsLhpWalk / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeWalk / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveWalk / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentWalks / Convert.ToDecimal(3)) + (pitcherAwayWalk / Convert.ToDecimal(9)) + (opponentTeamWalks) / Convert.ToDecimal(6));
                                projectedSB = ((player.VsLhpSb / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeSb / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveSB / player.LastFiveAb) * Convert.ToDecimal(2) / Convert.ToDecimal(3));

                                player.ProjectedHit = projectedHit;
                                player.ProjectedDouble = projectedDouble;
                                player.ProjectedTriple = projectedTriple;
                                player.ProjectedHR = projectedHR;
                                player.ProjectedRun = projectedR;
                                player.ProjectedRBI = projectedRBI;
                                player.ProjectedWalk = projectedWalk;
                                player.ProjectedSB = projectedSB;

                                player.Projection = (projectedHit * Convert.ToDecimal(3)) + (projectedDouble * Convert.ToDecimal(2)) + (projectedTriple * Convert.ToDecimal(4)) + (projectedHR * Convert.ToDecimal(10)) + (projectedSB * Convert.ToDecimal(5)) + (projectedWalk * Convert.ToDecimal(2)) + (projectedR * Convert.ToDecimal(2)) + (projectedRBI * Convert.ToDecimal(2));
                                _context.PositionPlayers.Update(player);
                            }
                        }
                    }
                }
            }

            foreach (var pitcher in _context.Pitchers.Where(p => p.ProbableStarter == true))
            {
                var opponent = _context.Teams.Single(t => t.TeamName == pitcher.Opponent);
                var opponentStrikeOuts = (opponent.StrikeOuts / 3) * .66;
                var opponentHR = (opponent.HomeRuns / 3) * .66;
                var opponentR = (opponent.Runs / 3) * .66;
                var opponentWalk = (opponent.Walks / 3) * .66;
                var opponentHit = (opponent.Hits / 3) * .66;
                var pitcherStrikeOuts = pitcher.LastThreeStrikeouts / 3;
                var pitcherHRA = pitcher.LastThreeHRA / 3;
                var pitcherERA = pitcher.LastThreeERA / 3;
                var pitcherHit = pitcher.LastThreeHitsAllowed / 3;
                var pitcherWalk = pitcher.LastThreeWalks / 3;
                decimal projectedStrikeOuts = 0;
                decimal projectedRuns = 0;
                decimal projectedHits = 0;
                decimal projectedWalks = 0;
                decimal projectedHR = 0;

                pitcher.OpposingTeamProjected = 0;

                foreach (var player in _context.PositionPlayers.Where(p => p.TeamName == opponent.TeamName))
                {
                    pitcher.OpposingTeamProjected += player.Projection;
                }

                if (pitcherStrikeOuts > opponentStrikeOuts)
                {
                    projectedStrikeOuts = (pitcherStrikeOuts + Convert.ToDecimal(pitcherStrikeOuts - opponentStrikeOuts) / Convert.ToDecimal(2));
                }
                if (opponentStrikeOuts > pitcherStrikeOuts)
                {
                    projectedStrikeOuts = (pitcherStrikeOuts + Convert.ToDecimal(opponentStrikeOuts - pitcherStrikeOuts) / Convert.ToDecimal(2));
                }
                if (opponentStrikeOuts == pitcherStrikeOuts)
                {
                    projectedStrikeOuts = pitcherStrikeOuts;
                }

                if (pitcherHit > opponentHit)
                {
                    projectedHits = (pitcherHit + Convert.ToDecimal(pitcherHit - opponentHit) / Convert.ToDecimal(2));
                }
                if (opponentHit > pitcherHit)
                {
                    projectedHits = (pitcherHit + Convert.ToDecimal(opponentHit - pitcherHit) / Convert.ToDecimal(2));
                }
                if (opponentHit == pitcherHit)
                {
                    projectedHits = pitcherHit;
                }

                if (pitcherWalk > opponentWalk)
                {
                    projectedWalks = (pitcherWalk + Convert.ToDecimal(pitcherWalk - opponentWalk) / Convert.ToDecimal(2));
                }
                if (opponentWalk > pitcherWalk)
                {
                    projectedWalks = (pitcherWalk + Convert.ToDecimal(opponentWalk - pitcherWalk) / Convert.ToDecimal(2));
                }
                if (opponentWalk == pitcherWalk)
                {
                    projectedWalks = pitcherWalk;
                }

                if (pitcherERA > opponentR)
                {
                    projectedRuns = (pitcherERA + Convert.ToDecimal(pitcherERA - opponentR) / Convert.ToDecimal(2));
                }
                if (opponentR > pitcherERA)
                {
                    projectedRuns = (pitcherERA + Convert.ToDecimal(opponentR - pitcherERA) / Convert.ToDecimal(2));
                }
                if (opponentR == pitcherERA)
                {
                    projectedRuns = pitcherERA;
                }

                if (pitcherHRA > opponentHR)
                {
                    projectedHR = (pitcherHRA + Convert.ToDecimal(pitcherHRA - opponentHR) / Convert.ToDecimal(2));
                }
                if (opponentHR > pitcherHRA)
                {
                    projectedHR = (pitcherHRA + Convert.ToDecimal(opponentHR - pitcherHRA) / Convert.ToDecimal(2));
                }
                if (pitcherHRA == opponentHR)
                {
                    projectedHR = pitcherHRA;
                }

                if (pitcher.HomeAway == "Home" && pitcher.LastThreeInningsPitched != 0 && pitcher.HomeIp != 0)
                {
                    pitcher.ProjectedStrikeout = projectedStrikeOuts;
                    pitcher.ProjectedWalk = projectedWalks;
                    pitcher.ProjectedHit = projectedHits;
                    pitcher.ProjectedHRA = projectedHR;
                    pitcher.ProjectedRA = projectedRuns;
                    pitcher.Projection = Convert.ToInt32(Math.Ceiling((projectedStrikeOuts * Convert.ToDecimal(2)) + (projectedRuns * Convert.ToDecimal(-2)) + (projectedHits * Convert.ToDecimal(-.6)) + (projectedHR * Convert.ToDecimal(-3)) + (projectedWalks * Convert.ToDecimal(-.6)) + (pitcher.HomePointsPerIP * (pitcher.LastThreeInningsPitched / Convert.ToDecimal(3)))));
                    _context.Pitchers.Update(pitcher);
                }

                if (pitcher.HomeAway == "Away" && pitcher.LastThreeInningsPitched != 0 && pitcher.AwayIp != 0)
                {

                    pitcher.ProjectedStrikeout = projectedStrikeOuts;
                    pitcher.ProjectedWalk = projectedWalks;
                    pitcher.ProjectedHit = projectedHits;
                    pitcher.ProjectedHRA = projectedHR;
                    pitcher.ProjectedRA = projectedRuns;
                    pitcher.Projection = Convert.ToInt32(Math.Ceiling((projectedStrikeOuts * Convert.ToDecimal(2)) + (projectedRuns * Convert.ToDecimal(-2)) + (projectedHits * Convert.ToDecimal(-.6)) + (projectedHR * Convert.ToDecimal(-3)) + (projectedWalks * Convert.ToDecimal(-.6)) + (pitcher.AwayPointsPerIP * (pitcher.LastThreeInningsPitched / Convert.ToDecimal(3)))));
                    _context.Pitchers.Update(pitcher);
                }





            }

        }

        public void UpdateTriplesAndDoubles()
        {
            foreach (var player in _context.PositionPlayers)
            {
                var individualGames = _context.IndividualGamePosPlayers.Where(p => p.PlayerID == player.PlayerID && p.GameDate == DateTime.Today.Date.AddDays(-1)).ToList();

                foreach (var game in individualGames)
                {
                    player.SeasonTriple += game.Triple;
                    player.SeasonDouble += game.Double;
                }
            }
        }


        public void GetTeamGameDates()
        {
            foreach (var team in _context.TeamGameDates)
            {
                _context.TeamGameDates.Remove(team);
            }
            foreach (var team in _context.Teams)
            {
                var gameDate = _context.IndividualGamePosPlayers.Where(p => p.Team == team.TeamName).OrderByDescending(p => p.GameDate).DistinctBy(p => p.GameDate).Take(5).ToList();

                foreach (var game in gameDate)
                {
                    TeamGameDate newTeam = new TeamGameDate()
                    {
                        TeamName = team.TeamName,
                        GameDate = game.GameDate
                    };
                    _context.TeamGameDates.Add(newTeam);
                }
            }


        }



        //This May Be Dumb

        //public void GetTeamProjections()
        //{
        //    foreach (var team in _context.ProjectedTeams)
        //    {
        //        _context.ProjectedTeams.Remove(team);
        //    }

        //    var pitchers = _context.Pitchers.Where(p => p.ProbableStarter == true && p.Projection >= 15).ToList();
        //    var catchers = _context.PositionPlayers.Where(p => p.Position == "C" && p.Projection >= 5).ToList();
        //    var firstBase = _context.PositionPlayers.Where(p => p.Position == "1B" && p.Projection >= 5).ToList();
        //    var secondBase = _context.PositionPlayers.Where(p => p.Position == "2B" && p.Projection >= 5).ToList();
        //    var thirdBase = _context.PositionPlayers.Where(p => p.Position == "3B" && p.Projection >= 5).ToList();
        //    var shortstoppers = _context.PositionPlayers.Where(p => p.Position == "SS" && p.Projection >= 5).ToList();
        //    var outfield = _context.PositionPlayers.Where(p => p.Position == "OF" && p.Projection >= 5).ToList();

        //    foreach (var pitcher in pitchers)
        //    {

        //        var pitcherOne = pitcher.FirstName + " " + pitcher.LastName;
        //        var pitcherOneProjection = pitcher.Projection;
        //        var pitcherOneSalary = pitcher.Salary;

        //        foreach (var pitchertwo in _context.Pitchers.Where(p => p.ProbableStarter == true && p.PlayerID != pitcher.PlayerID && p.Projection >= 15))
        //        {
        //            var pitcherTwo = pitchertwo.FirstName + " " + pitchertwo.LastName;
        //            var pitcherTwoProjection = pitchertwo.Projection;
        //            var pitcherTwoSalary = pitchertwo.Salary;

        //            foreach (var catcher in _context.PositionPlayers.Where(p => p.Position == "C" && p.Projection >= 5))
        //            {
        //                var newCatcher = catcher.FirstName + " " + catcher.LastName;
        //                var newCatcherProjection = catcher.Projection;
        //                var newCatcherSalary = catcher.Salary;

        //                foreach (var firstBaseman in _context.PositionPlayers.Where(p => p.Position == "1B" && p.Projection >= 5))
        //                {
        //                    var newFirst = firstBaseman.FirstName + " " + firstBaseman.LastName;
        //                    var newFirstProjection = firstBaseman.Projection;
        //                    var newFirstSalary = firstBaseman.Salary;

        //                    foreach (var secondBaseman in _context.PositionPlayers.Where(p => p.Position == "2B" && p.Projection >= 5))
        //                    {
        //                        var newSecond = secondBaseman.FirstName + " " + secondBaseman.LastName;
        //                        var newSecondProjection = secondBaseman.Projection;
        //                        var newSecondSalary = secondBaseman.Salary;

        //                        foreach (var thirdBaseman in _context.PositionPlayers.Where(p => p.Position == "3B" && p.Projection >= 5))
        //                        {
        //                            var newThird = thirdBaseman.FirstName + " " + thirdBaseman.LastName;
        //                            var newThirdProjection = thirdBaseman.Projection;
        //                            var newThirdSalary = thirdBaseman.Salary;

        //                            foreach (var shortstop in _context.PositionPlayers.Where(p => p.Position == "SS" && p.Projection >= 5))
        //                            {
        //                                var newShort = shortstop.FirstName + " " + shortstop.LastName;
        //                                var newShortProjection = shortstop.Projection;
        //                                var newShortSalary = shortstop.Salary;

        //                                foreach (var outfielderOne in _context.PositionPlayers.Where(p => p.Position == "OF" && p.Projection >= 5))
        //                                {
        //                                    var outfieldOne = outfielderOne.FirstName + " " + outfielderOne.LastName;
        //                                    var outfieldOneProjection = outfielderOne.Projection;
        //                                    var outfieldOneSalary = outfielderOne.Salary;

        //                                    foreach (var outfielderTwo in _context.PositionPlayers.Where(p => p.Position == "OF" && p.Projection >= 5 && p.PlayerID != outfielderOne.PlayerID))
        //                                    {
        //                                        var outfieldTwo = outfielderTwo.FirstName + " " + outfielderTwo.LastName;
        //                                        var outfieldTwoProjection = outfielderTwo.Projection;
        //                                        var outfieldTwoSalary = outfielderTwo.Salary;

        //                                        foreach (var outfielderThree in _context.PositionPlayers.Where(p => p.Position == "OF" && p.Projection >= 5 && p.PlayerID != outfielderOne.PlayerID && p.PlayerID != outfielderTwo.PlayerID))
        //                                        {
        //                                            var outfieldThree = outfielderThree.FirstName + " " + outfielderThree.LastName;
        //                                            var outfieldThreeProjection = outfielderThree.Projection;
        //                                            var outfieldThreeSalary = outfielderThree.Salary;

        //                                            ProjectedTeam newTeam = new ProjectedTeam()
        //                                            {
        //                                                PitcherOne = pitcherOne,
        //                                                PitcherOneProjection = pitcherOneProjection,
        //                                                PitcherOneSalary = pitcherOneSalary,
        //                                                PitcherTwo = pitcherTwo,
        //                                                PitcherTwoProjection = pitcherTwoProjection,
        //                                                PitcherTwoSalary = pitcherTwoSalary,
        //                                                Catcher = newCatcher,
        //                                                CatcherProjection = newCatcherProjection,
        //                                                CatcherSalary = newCatcherSalary,
        //                                                FirstBase = newFirst,
        //                                                FirstBaseProjection = newFirstProjection,
        //                                                FirstBaseSalary = newFirstSalary,
        //                                                SecondBase = newSecond,
        //                                                SecondBaseProjection = newSecondProjection,
        //                                                SecondBaseSalary = newSecondSalary,
        //                                                ThirdBase = newThird,
        //                                                ThirdBaseProjection = newThirdProjection,
        //                                                ThirdBaseSalary = newThirdSalary,
        //                                                Shortstop = newShort,
        //                                                ShortstopProjection = newShortProjection,
        //                                                ShortstopSalary = newShortSalary,
        //                                                OutfieldOne = outfieldOne,
        //                                                OutfieldOneProjection = outfieldOneProjection,
        //                                                OutfieldOneSalary = outfieldOneSalary,
        //                                                OutfieldTwo = outfieldTwo,
        //                                                OutfieldTwoProjection = outfieldTwoProjection,
        //                                                OutfieldTwoSalary = outfieldTwoSalary,
        //                                                OutfieldThree = outfieldThree,
        //                                                OutfieldThreeProjection = outfieldThreeProjection,
        //                                                OutfieldThreeSalary = outfieldThreeSalary,
        //                                                TotalCost = pitcherOneSalary + pitcherTwoSalary + newCatcherSalary + newFirstSalary + newSecondSalary + newThirdSalary + newShortSalary + outfieldOneSalary + outfieldTwoSalary + outfieldThreeSalary,
        //                                                TeamProjection = pitcherOneProjection + pitcherTwoProjection + newCatcherProjection + newFirstProjection + newSecondProjection + newThirdProjection + newShortProjection + outfieldOneProjection + outfieldTwoProjection + outfieldThreeProjection
        //                                            };
        //                                            _context.ProjectedTeams.Add(newTeam);

        //                                        }
        //                                    }
        //                                }
        //                            }

        //                        }
        //                    }
        //                }
        //            }



        //        }
        //    }

        //}


        //This May Be Dumb

        public void NewPitcher()
        {
            Pitcher newPitcher = new Pitcher()
            {
                FirstName = "Caleb",
                LastName = "Ferguson",
                TeamName = "Dodgers",
                PlayerID = 657571,
                SeasonIp = 0,
                SeasonHitsAllowed = 0,
                SeasonEarnedRunsAllowed = 0,
                SeasonHomeRunAllowed = 0,
                SeasonPointsPerIP = 0,
                SeasonRunsAllowed = 0,
                SeasonStrikeOuts = 0,
                SeasonTotalScore = 0,
                SeasonWalks = 0,
                SeasonWins = 0,
                Salary = 0,
                AwayEarnedRunsAllowed = 0,
                AwayHitByPitch = 0,
                AwayHitsAllowed = 0,
                AwayHomeRunAllowed = 0,
                AwayIp = 0,
                AwayPointsPerIP = 0,
                AwayRunsAllowed = 0,
                AwayStrikeOuts = 0,
                AwayTotalScore = 0,
                AwayWalks = 0,
                HomeAway = "Away",
                HomeEarnedRunsAllowed = 0,
                HomeHitByPitch = 0,
                HomeHitsAllowed = 0,
                HomeHomeRunAllowed = 0,
                HomeIp = 0,
                HomePointsPerIP = 0,
                HomeRunsAllowed = 0,
                HomeStrikeOuts = 0,
                HomeTotalScore = 0,
                HomeWalks = 0,
                LastStartScore = 0,
                LastThreeERA = 0,
                LastThreeHitsAllowed = 0,
                LastThreeHRA = 0,
                LastThreeInningsPitched = 0,
                LastThreeStrikeouts = 0,
                LastThreeTotalScore = 0,
                LastThreeWalks = 0,
                Opponent = "Pirates",
                OpposingTeamProjected = 0,
                DKID = 10765327,
                ProbableStarter = true,
                ProjectedHit = 0,
                ProjectedHRA = 0,
                ProjectedRA = 0,
                ProjectedStrikeout = 0, 
                ProjectedWalk = 0,
                Projection = 0,
                ThrowingHand = "LHP"
            };
            _context.Pitchers.Add(newPitcher);
        }

        public void GetTeamProjections()
        {
            foreach (var team in _context.ProjectedTeams)
            {
                _context.ProjectedTeams.Remove(team);
            }

            var pitchers = _context.Pitchers.Where(p => (p.TeamName == "Phillies" || p.TeamName == "Athletics" || p.TeamName == "Rangers" || p.TeamName == "Cubs" || p.TeamName == "Astros" || p.TeamName == "Marlins" || p.TeamName == "Mariners" || p.TeamName == "Cardinals") && p.ProbableStarter == true);
            var catching = _context.PositionPlayers.Where(p => (p.TeamName == "Cubs" || p.TeamName == "Marlins" || p.TeamName == "Cardinals") && p.Position == "C" && p.Salary >= 2700 && p.LastFiveTotalScore >= 28);
            var firstBasemen = _context.PositionPlayers.Where(p => (p.TeamName == "Cubs" || p.TeamName == "Marlins" || p.TeamName == "Cardinals") && p.Position == "1B" && p.Salary >= 3000 && p.LastFiveTotalScore >= 28);
            var secondBasemen = _context.PositionPlayers.Where(p => (p.TeamName == "Cubs" || p.TeamName == "Marlins" || p.TeamName == "Cardinals") && p.Position == "2B" && p.Salary >= 3000 && p.LastFiveTotalScore >= 28);
            var thirdBasemen = _context.PositionPlayers.Where(p => (p.TeamName == "Cubs" || p.TeamName == "Marlins" || p.TeamName == "Cardinals") && p.Position == "3B" && p.Salary >= 3000 && p.LastFiveTotalScore >= 28);
            var shortstoppers = _context.PositionPlayers.Where(p => (p.TeamName == "Cubs" || p.TeamName == "Marlins" || p.TeamName == "Cardinals") && p.Position == "SS" && p.Salary >= 3000 && p.LastFiveTotalScore >= 28);
            var outfielderss = _context.PositionPlayers.Where(p => (p.TeamName == "Cubs" || p.TeamName == "Marlins" || p.TeamName == "Cardinals") && p.Position == "OF" && p.Salary >= 3000 && p.LastFiveTotalScore >= 35);

            foreach (var pitcher in pitchers)
            {
                var totalSalary = 0;   
                var pitcherOne = pitcher.FirstName + " " + pitcher.LastName;
                var pitcherOneProjection = pitcher.Projection;
                var pitcherOneSalary = pitcher.Salary;

                totalSalary = pitcher.Salary;

                foreach (var pitchertwo in pitchers.Where(p => p.PlayerID != pitcher.PlayerID))
                {
                    var pitcherTwo = pitchertwo.FirstName + " " + pitchertwo.LastName;
                    var pitcherTwoProjection = pitchertwo.Projection;
                    var pitcherTwoSalary = pitchertwo.Salary;

                    totalSalary = pitcher.Salary + pitchertwo.Salary;

                    if (totalSalary <= 20000)
                    {
                        foreach (var outOne in outfielderss)
                        {
                            var outfieldOne = outOne.FirstName + " " + outOne.LastName;
                            var outfieldOneProjection = outOne.Projection;
                            var outfieldOneSalary = outOne.Salary;

                            totalSalary = pitcher.Salary + pitchertwo.Salary +outOne.Salary;

                            if (totalSalary <= 25000)
                            {
                                foreach (var outTwo in outfielderss.Where(p => p.PlayerID != outOne.PlayerID))
                                {
                                    var outfieldTwo = outTwo.FirstName + " " + outTwo.LastName;
                                    var outfieldTwoProjection = outTwo.Projection;
                                    var outfieldTwoSalary = outTwo.Salary;

                                    totalSalary = pitcher.Salary + pitchertwo.Salary + outOne.Salary + outTwo.Salary;

                                    if (totalSalary <= 28500)
                                    {
                                        foreach (var outThree in outfielderss.Where(p => p.PlayerID != outOne.PlayerID && p.PlayerID != outTwo.PlayerID))
                                        {
                                            var outfieldThree = outThree.FirstName + " " + outThree.LastName;
                                            var outfieldThreeProjection = outThree.Projection;
                                            var outfieldThreeSalary = outThree.Salary;

                                            totalSalary = pitcher.Salary + pitchertwo.Salary + outOne.Salary + outTwo.Salary + outThree.Salary;

                                            if (totalSalary <= 33000)
                                            {
                                                foreach (var firstbase in firstBasemen)
                                                {
                                                    var first = firstbase.FirstName + " " + firstbase.LastName;
                                                    var firstProjection = firstbase.Projection;
                                                    var firstSalary = firstbase.Salary;

                                                    totalSalary = pitcher.Salary + pitchertwo.Salary + outOne.Salary + outTwo.Salary + outThree.Salary + firstbase.Salary;

                                                    if (totalSalary <= 37500)
                                                    {
                                                        foreach (var thirdbase in thirdBasemen)
                                                        {
                                                            var third = thirdbase.FirstName + " " + thirdbase.LastName;
                                                            var thirdProjection = thirdbase.Projection;
                                                            var thirdSalary = thirdbase.Salary;

                                                            totalSalary = pitcher.Salary + pitchertwo.Salary + outOne.Salary + outTwo.Salary + outThree.Salary + thirdbase.Salary + firstbase.Salary;

                                                            if (totalSalary <= 41600)
                                                            {
                                                                foreach (var secondbase in secondBasemen)
                                                                {
                                                                    var second = secondbase.FirstName + " " + secondbase.LastName;
                                                                    var secondProjection = secondbase.Projection;
                                                                    var secondSalary = secondbase.Salary;

                                                                    totalSalary = pitcher.Salary + pitchertwo.Salary + outOne.Salary + outTwo.Salary + outThree.Salary + thirdbase.Salary + firstbase.Salary + secondbase.Salary;

                                                                    if (totalSalary <= 44400)
                                                                    {
                                                                        foreach (var shortstops in shortstoppers)
                                                                        {
                                                                            var shortstop = shortstops.FirstName + " " + shortstops.LastName;
                                                                            var shortstopProjection = shortstops.Projection;
                                                                            var shortstopSalary = shortstops.Salary;

                                                                            totalSalary = pitcher.Salary + pitchertwo.Salary + outOne.Salary + outTwo.Salary + outThree.Salary + thirdbase.Salary + firstbase.Salary + secondbase.Salary + shortstops.Salary;

                                                                            if (totalSalary <= 47200)
                                                                            {
                                                                                foreach (var catchers in catching)
                                                                                {
                                                                                    var catcher = catchers.FirstName + " " + catchers.LastName;
                                                                                    var catcherProjection = catchers.Projection;
                                                                                    var catcherSalary = catchers.Salary;

                                                                                    totalSalary = pitcher.Salary + pitchertwo.Salary + outOne.Salary + outTwo.Salary + outThree.Salary + thirdbase.Salary + firstbase.Salary + secondbase.Salary + catchers.Salary + shortstops.Salary;

                                                                                    if (totalSalary <= 50000)
                                                                                    {
                                                                                        ProjectedTeam newTeam = new ProjectedTeam()
                                                                                        {
                                                                                            PitcherOne = pitcherOne,
                                                                                            PitcherOneProjection = pitcherOneProjection,
                                                                                            PitcherOneSalary = pitcherOneSalary,
                                                                                            PitcherTwo = pitcherTwo,
                                                                                            PitcherTwoProjection = pitcherTwoProjection,
                                                                                            PitcherTwoSalary = pitcherTwoSalary,
                                                                                            Catcher = catcher,
                                                                                            CatcherProjection = catcherProjection,
                                                                                            CatcherSalary = catcherSalary,
                                                                                            FirstBase = first,
                                                                                            FirstBaseProjection = firstProjection,
                                                                                            FirstBaseSalary = firstSalary,
                                                                                            SecondBase = second,
                                                                                            SecondBaseProjection = secondProjection,
                                                                                            SecondBaseSalary = secondSalary,
                                                                                            ThirdBase = third,
                                                                                            ThirdBaseProjection = thirdProjection,
                                                                                            ThirdBaseSalary = thirdSalary,
                                                                                            Shortstop = shortstop,
                                                                                            ShortstopProjection = shortstopProjection,
                                                                                            ShortstopSalary = shortstopSalary,
                                                                                            OutfieldOne = outfieldOne,
                                                                                            OutfieldOneProjection = outfieldOneProjection,
                                                                                            OutfieldOneSalary = outfieldOneSalary,
                                                                                            OutfieldTwo = outfieldTwo,
                                                                                            OutfieldTwoProjection = outfieldTwoProjection,
                                                                                            OutfieldTwoSalary = outfieldTwoSalary,
                                                                                            OutfieldThree = outfieldThree,
                                                                                            OutfieldThreeProjection = outfieldThreeProjection,
                                                                                            OutfieldThreeSalary = outfieldThreeSalary,
                                                                                            TotalCost = totalSalary,
                                                                                            TeamProjection = pitcherTwoProjection + pitcherOneProjection + catcherProjection + firstProjection + secondProjection + thirdProjection + shortstopProjection + outfieldOneProjection + outfieldThreeProjection + outfieldTwoProjection
                                                                                        };
                                                                                        _context.ProjectedTeams.Add(newTeam);
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            


                                        }
                                    }
                                    
                                }
                            }
                            
                        }
                    }
                    

                }
            }
        }

        public void TestTeamProjections()
        {

            foreach (var team in _context.ProjectedTeams)
            {
                _context.ProjectedTeams.Remove(team);
            }

            var pitchers = _context.Pitchers.Where(p => p.ProbableStarter == true);
            var players = _context.PositionPlayers.Where(p => p.Salary >= 2700 && p.SeasonAb >= 50 && p.LastFiveTotalScore >= 25).OrderByDescending(p => p.Projection);
           

            foreach (var pitcher in pitchers)
            {
                var totalSalary = 0;

                var pitcherOne = pitcher.FirstName + " " + pitcher.LastName;
                var pitcherOneProjection = pitcher.Projection;
                var pitcherOneSalary = pitcher.Salary;

                totalSalary = pitcherOneSalary;

                foreach (var pitcher2 in pitchers.Where(p => p.PlayerID != pitcher.PlayerID))
                {
                    var pitcherTwo = pitcher2.FirstName + " " + pitcher2.LastName;
                    var pitcherTwoProjection = pitcher2.Projection;
                    var pitcherTwoSalary = pitcher2.Salary;

                    totalSalary = pitcherOneSalary + pitcherTwoSalary;
                    var catcher = " ";
                    decimal catcherProjection = 0;
                    var catcherSalary = 0;
                    var firstBase = " ";
                    decimal firstBaseProjection = 0;
                    var firstBaseSalary = 0;
                    var secondBase = " ";
                    decimal secondBaseProjection = 0;
                    var secondBaseSalary = 0;
                    var thirdBase = " ";
                    decimal thirdBaseProjection = 0;
                    var thirdBaseSalary = 0;
                    var shortstop = " ";
                    decimal shortstopProjection = 0;
                    var shortstopSalary = 0;
                    var outfieldOne = " ";
                    decimal outfieldOneProjection = 0;
                    var outfieldOneSalary = 0;
                    var outfieldTwo = " ";
                    decimal outfieldTwoProjection = 0;
                    var outfieldTwoSalary = 0;
                    var outfieldThree = " ";
                    decimal outfieldThreeProjection = 0;
                    var outfieldThreeSalary = 0;

                    var outfieldOneID = 0;
                    var outfieldTwoID = 0;
                    var catcherCount = 0;
                    var firstCount = 0;
                    var secondCount = 0;
                    var thirdCount = 0;
                    var shortCount = 0;
                    var outfieldCount = 0;

                    foreach (var player in players)
                    {

                        if (totalSalary <= 50000)
                        {
                            if (player.Position == "C" && catcherCount == 0 && totalSalary <= 50000)
                            {
                                catcher = player.FirstName + " " + player.LastName;
                                catcherProjection = player.Projection;
                                catcherSalary = player.Salary;
                                catcherCount += 1;

                                totalSalary += player.Salary;
                            }

                            if (player.Position == "1B" && firstCount == 0 && totalSalary <= 50000)
                            {
                                firstBase = player.FirstName + " " + player.LastName;
                                firstBaseProjection = player.Projection;
                                firstBaseSalary = player.Salary;
                                firstCount += 1;

                                totalSalary += player.Salary;
                            }

                            if (player.Position == "2B" && secondCount == 0 && totalSalary <= 50000)
                            {
                                secondBase = player.FirstName + " " + player.LastName;
                                secondBaseProjection = player.Projection;
                                secondBaseSalary = player.Salary;
                                secondCount += 1;

                                totalSalary += player.Salary;
                            }

                            if (player.Position == "3B" && thirdCount == 0 && totalSalary <= 50000)
                            {
                                thirdBase = player.FirstName + " " + player.LastName;
                                thirdBaseProjection = player.Projection;
                                thirdBaseSalary = player.Salary;
                                thirdCount += 1;

                                totalSalary += player.Salary;
                            }

                            if (player.Position == "SS" && shortCount == 0 && totalSalary <= 50000)
                            {
                                shortstop = player.FirstName + " " + player.LastName;
                                shortstopProjection = player.Projection;
                                shortstopSalary = player.Salary;
                                shortCount += 1;

                                totalSalary += player.Salary;
                            }

                            if (player.Position == "OF" && outfieldCount == 0 && totalSalary <= 50000)
                            {
                                outfieldOne = player.FirstName + " " + player.LastName;
                                outfieldOneProjection = player.Projection;
                                outfieldOneSalary = player.Salary;
                                outfieldCount += 1;
                                outfieldOneID = player.PlayerID;

                                totalSalary += player.Salary;
                            }

                            if (player.Position == "OF" && outfieldCount == 1 && totalSalary <= 50000 && player.PlayerID != outfieldOneID)
                            {
                                outfieldTwo = player.FirstName + " " + player.LastName;
                                outfieldTwoProjection = player.Projection;
                                outfieldTwoSalary = player.Salary;
                                outfieldCount += 1;
                                outfieldTwoID = player.PlayerID;
                                totalSalary += player.Salary;
                            }

                            if (player.Position == "OF" && outfieldCount == 2 && totalSalary <= 50000 && player.PlayerID != outfieldOneID && player.PlayerID != outfieldTwoID)
                            {
                                outfieldThree = player.FirstName + " " + player.LastName;
                                outfieldThreeProjection = player.Projection;
                                outfieldThreeSalary = player.Salary;
                                outfieldCount += 1;

                                totalSalary += player.Salary;
                            }

                            if (catcherCount == 1 && firstCount == 1 && secondCount == 1 && thirdCount == 1 && shortCount == 1 && outfieldCount == 3 && totalSalary <= 50000)
                            {
                                ProjectedTeam newTeam = new ProjectedTeam()
                                {
                                    PitcherOne = pitcherOne,
                                    PitcherOneSalary = pitcherOneSalary,
                                    PitcherOneProjection = pitcherOneProjection,
                                    PitcherTwo = pitcherTwo,
                                    PitcherTwoProjection = pitcherTwoProjection,
                                    PitcherTwoSalary = pitcherTwoSalary,
                                    Catcher = catcher,
                                    CatcherProjection = catcherProjection,
                                    CatcherSalary = catcherSalary,
                                    FirstBase = firstBase,
                                    FirstBaseProjection = firstBaseProjection,
                                    FirstBaseSalary = firstBaseSalary,
                                    SecondBase = secondBase,
                                    SecondBaseProjection = secondBaseProjection,
                                    SecondBaseSalary = secondBaseSalary,
                                    ThirdBase = thirdBase,
                                    ThirdBaseProjection = thirdBaseProjection,
                                    ThirdBaseSalary = thirdBaseSalary,
                                    Shortstop = shortstop,
                                    ShortstopProjection = shortstopProjection,
                                    ShortstopSalary = shortstopSalary,
                                    OutfieldOne = outfieldOne,
                                    OutfieldOneProjection = outfieldOneProjection,
                                    OutfieldOneSalary = outfieldOneSalary,
                                    OutfieldThree = outfieldThree,
                                    OutfieldThreeProjection = outfieldThreeProjection,
                                    OutfieldThreeSalary = outfieldThreeSalary,
                                    OutfieldTwo = outfieldTwo,
                                    OutfieldTwoProjection = outfieldTwoProjection,
                                    OutfieldTwoSalary = outfieldTwoSalary,
                                    TeamProjection = pitcherOneProjection + pitcherTwoProjection + catcherProjection + firstBaseProjection + secondBaseProjection + thirdBaseProjection + shortstopProjection + outfieldTwoProjection + outfieldOneProjection + outfieldThreeProjection,
                                    TotalCost = totalSalary
                                };
                                _context.ProjectedTeams.Add(newTeam);
                            }

                        }
                    }
                }
            }
        }


        public void GetDeviance()
        {
            foreach (var player in _context.PositionPlayers)
            {
                player.YesterdayDeviance = player.YesterdayTotalScore - player.YesterdayProjected;

                var lastFiveGames = _context.IndividualGamePosPlayers.Where(p => p.PlayerID == player.PlayerID && p.Played == true).OrderByDescending(p => p.GameDate).Take(5);

                decimal lastFiveScore = 0;
                decimal  lastFiveProjected = 0;

                foreach (var game in lastFiveGames)
                {
                    lastFiveScore += game.TotalScore;
                    lastFiveProjected += game.Projection;
                }

                player.LastFiveProjected = lastFiveProjected;
                player.LastFiveDeviance = lastFiveScore - lastFiveProjected;
            }

            foreach (var pitcher in _context.Pitchers)
            {
                var lastStart = _context.IndividualGamePitchers.Where(p => p.PlayerID == pitcher.PlayerID).OrderByDescending(p => p.GameDate).FirstOrDefault();
                var lastThreeStarts = _context.IndividualGamePitchers.Where(p => p.PlayerID == pitcher.PlayerID).OrderByDescending(p => p.GameDate).Take(3);

                if (lastStart != null)
                {
                    pitcher.LastStartProjected = lastStart.ProjectedScore;
                    pitcher.LastStartDeviance = lastStart.TotalScore - lastStart.ProjectedScore;
                }

                decimal lastThreeScore = 0;
                decimal lastThreeProjected = 0;

                foreach (var start in lastThreeStarts)
                {
                    lastThreeScore += start.TotalScore;
                    lastThreeProjected = start.ProjectedScore;
                }

                pitcher.LastThreeProjected = lastThreeProjected;
                pitcher.LastThreeDeviance = lastThreeScore - lastThreeProjected;
            }
        }
    }
}