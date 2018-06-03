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
                var posPlayer = _context.IndividualGamePosPlayers.Where(p => p.PlayerID == player.PlayerID).OrderByDescending(p => p.GameDate).FirstOrDefault();

                if (posPlayer != null)
                {
                    player.YesterdayTotalScore = posPlayer.TotalScore;
                }

                _context.PositionPlayers.Update(player);

            };

            foreach (var player in _context.PositionPlayers)
            {
                var lastFive = _context.IndividualGamePosPlayers.Where(p => p.PlayerID == player.PlayerID).OrderByDescending(p => p.GameDate).Take(5);

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

            foreach (var player in _context.PositionPlayers)
            {
                for (int i = -5; i < 0; i++)
                {
                    var loopDate = DateTime.Today.Date.AddDays(i);
                    IndividualGamePosPlayer playerGames = _context.IndividualGamePosPlayers.Where(p => p.PlayerID == player.PlayerID && p.GameDate == loopDate).FirstOrDefault();
                    Team playerTeam = _context.Teams.Single(p => p.TeamName == player.TeamName);

                    if (playerGames != null)
                    {
                        int hits = playerTeam.Hits;
                        int strikeOuts = playerTeam.StrikeOuts;
                        int homeRuns = playerTeam.HomeRuns;
                        int runs = playerTeam.Runs;
                        int walks = playerTeam.Walks;

                        hits += playerGames.Single + playerGames.Double + playerGames.Triple + playerGames.HomeRun;
                        strikeOuts += playerGames.StrikeOut;
                        homeRuns += playerGames.HomeRun;
                        runs += playerGames.Run;
                        walks += playerGames.Walk;

                        playerTeam.Hits = hits;
                        playerTeam.StrikeOuts = strikeOuts;
                        playerTeam.HomeRuns = homeRuns;
                        playerTeam.Runs = runs;
                        playerTeam.Walks = walks;

                        _context.Teams.Update(playerTeam);
                    }

                }

            }

            foreach (var pitcher in _context.Pitchers)
            {

                for (int i = -5; i < 0; i++)
                {
                    var loopDate = DateTime.Today.Date.AddDays(i);
                    IndividualGamePitcher pitcherGames = _context.IndividualGamePitchers.Where(p => p.PlayerID == pitcher.PlayerID && p.GameDate == loopDate).FirstOrDefault();
                    Team playerTeam = _context.Teams.Single(p => p.TeamName == pitcher.TeamName);

                    if (pitcherGames != null)
                    {
                        decimal count = playerTeam.GamesPlayedGauge;
                        decimal runsAllowed = playerTeam.RunsAllowed;
                        decimal homeRunsAllowed = playerTeam.HomeRunsAllowed;
                        decimal hitsAllowed = playerTeam.HitsAllowed;
                        decimal pointsGivenUp = playerTeam.PointsGivenUp;

                        count += 1;
                        runsAllowed += pitcherGames.RunsAllowed;
                        homeRunsAllowed += pitcherGames.HomeRunsAllowed;
                        hitsAllowed += pitcherGames.HitsAllowed;
                        pointsGivenUp += (pitcherGames.HitsAllowed * 3) + (pitcherGames.RunsAllowed * 2) + (pitcherGames.HomeRunsAllowed * 10);

                        playerTeam.HomeRunsAllowed = homeRunsAllowed;
                        playerTeam.RunsAllowed = runsAllowed;
                        playerTeam.HitsAllowed = hitsAllowed;
                        playerTeam.GamesPlayedGauge = count;
                        playerTeam.PointsGivenUp = pointsGivenUp;

                        _context.Teams.Update(playerTeam);
                    }
                }
            }

            foreach (var team in _context.Teams)
            {
                team.PointsPerPitcherUsed = team.PointsGivenUp / team.GamesPlayedGauge;
                team.TotalPoints = (team.Hits * 3) + (team.Runs * 2) + (team.HomeRuns * 5) + (team.StrikeOuts * -2);
            }
        }

        private static readonly HttpClient starterClient = new HttpClient();

        public void TodayGameData()
        {
            foreach (var team in _context.Teams)
            {
                team.OpponentStarter = "UNKNOWN";
                _context.Teams.Update(team);
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




                    var startingPitcher = _context.Pitchers.Where(p => p.PlayerID == int.Parse(homePitcherID)).FirstOrDefault();

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

                    if (startingPitcher == null)
                    {
                        Pitcher newPitcher = new Pitcher()
                        {
                            FirstName = homePitcherFirstName,
                            LastName = homePitcherLastName,
                            PlayerID = int.Parse(homePitcherID),
                            ThrowingHand = homePitcherThrowingHand,
                            ProbableStarter = true,
                            TeamName = homePitcherTeam,
                            Opponent = opponentPitcherTeam,
                            MatchUp = matchUp,
                            HomeAway = "Home"
                        };

                        _context.Pitchers.Add(newPitcher);
                    }


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
        }


        public void AssignSalaries()
        {
          using (var reader = new StreamReader(@"C:\Users\Visitor\Source\Repos\final-project\LCFinalProject\CSV\DKSalaries.csv"))
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
                    decimal pitcherAwayHit = 1;
                    decimal pitcherAwayRun = 1;
                    decimal pitcherAwayHr = 1;
                    decimal pitcherAwayWalk = 1;
                    decimal pitcherHomeHit = 1;
                    decimal pitcherHomeRun = 1;
                    decimal pitcherHomeHr = 1;
                    decimal pitcherHomeWalk = 1;
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



                    

                    if (opponentStarter != null)
                    {
                        if (player.HomeAway == "Away")
                        {
                         
                            if (opponentStarter.ThrowingHand == "RHP" && player.AwayAb != 0 && player.LastFiveTotalScore != 0 && player.VsRhpAb != 0 && opponentStarter.HomeIp != 0)
                            {
                                projectedHit = (((player.VsRhpHit / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.AwayHit / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveHit / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentHits / Convert.ToDecimal(3)) + (pitcherAwayHit / Convert.ToDecimal(9)) / Convert.ToDecimal(5));
                                projectedDouble = ((player.LastFiveDouble / player.LastFiveAb) * Convert.ToDecimal(2)) + ((player.SeasonDouble / player.SeasonAb) * Convert.ToDecimal(3)) * (opponentHRA / Convert.ToDecimal(3));
                                projectedTriple = ((player.LastFiveTriple / player.LastFiveAb) * Convert.ToDecimal(2)) + ((player.SeasonTriple / player.SeasonAb) * Convert.ToDecimal(3)) * (opponentHRA / Convert.ToDecimal(3));
                                projectedHR = (((player.VsRhpHr / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.AwayHr / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveHR / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentHRA / Convert.ToDecimal(3)) + (pitcherAwayHr / Convert.ToDecimal(9)) / Convert.ToDecimal(5));
                                projectedR = (((player.VsRhpRun / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.AwayRun / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveRuns / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentRuns / Convert.ToDecimal(3)) + (pitcherAwayRun / Convert.ToDecimal(9)) / Convert.ToDecimal(5));
                                projectedRBI = (((player.VsRhpRbi / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.AwayRbi / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveRBI / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentRuns / Convert.ToDecimal(3)) + (pitcherAwayRun / Convert.ToDecimal(9)) / Convert.ToDecimal(5));
                                projectedWalk = (((player.VsRhpWalk / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.AwayWalk / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveWalk / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentWalks / Convert.ToDecimal(3)) + (pitcherAwayWalk / Convert.ToDecimal(9)) / Convert.ToDecimal(5));
                                projectedSB = (((player.VsRhpSb / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.AwaySb / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveSB / player.LastFiveAb) * Convert.ToDecimal(2)) / Convert.ToDecimal(3));

                                player.Projection = (projectedHit * Convert.ToDecimal(3)) + (projectedDouble * Convert.ToDecimal(2)) + (projectedTriple * Convert.ToDecimal(4)) + (projectedHR * Convert.ToDecimal(10)) + (projectedSB * Convert.ToDecimal(5)) + (projectedWalk * Convert.ToDecimal(2)) + (projectedR * Convert.ToDecimal(2)) + (projectedRBI * Convert.ToDecimal(2));
                                _context.PositionPlayers.Update(player);
                            }

                            if (opponentStarter.ThrowingHand == "LHP" && player.AwayAb != 0 && player.LastFiveTotalScore != 0 && player.VsLhpAb != 0 && opponentStarter.HomeIp != 0)
                            {
                                projectedHit = (((player.VsLhpHit / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.AwayHit / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveHit / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentHits / Convert.ToDecimal(3)) + (pitcherAwayHit / Convert.ToDecimal(9)) / Convert.ToDecimal(5));
                                projectedDouble = ((player.LastFiveDouble / player.LastFiveAb) * Convert.ToDecimal(2)) + ((player.SeasonDouble / player.SeasonAb) * Convert.ToDecimal(1.5)) * (opponentHRA / Convert.ToDecimal(3));
                                projectedTriple = ((player.LastFiveTriple / player.LastFiveAb) * Convert.ToDecimal(2)) + ((player.SeasonTriple / player.SeasonAb) * Convert.ToDecimal(1.5)) * (opponentHRA / Convert.ToDecimal(3));
                                projectedHR = (((player.VsLhpHr / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.AwayHr / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveHR / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentHRA / Convert.ToDecimal(3)) + (pitcherAwayHr / Convert.ToDecimal(9)) / Convert.ToDecimal(5));
                                projectedR = (((player.VsLhpRun / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.AwayRun / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveRuns / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentRuns / Convert.ToDecimal(3)) + (pitcherAwayRun / Convert.ToDecimal(9)) / Convert.ToDecimal(5));
                                projectedRBI = (((player.VsLhpRbi / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.AwayRbi / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveRBI / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentRuns / Convert.ToDecimal(3)) + (pitcherAwayRun / Convert.ToDecimal(9)) / Convert.ToDecimal(5));
                                projectedWalk = (((player.VsLhpWalk / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.AwayWalk / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveWalk / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentWalks / Convert.ToDecimal(3)) + (pitcherAwayWalk / Convert.ToDecimal(9)) / Convert.ToDecimal(5));
                                projectedSB = (((player.VsLhpSb / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.AwaySb / player.AwayAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveSB / player.LastFiveAb) * Convert.ToDecimal(2)) / Convert.ToDecimal(3));


                                player.Projection = (projectedHit * Convert.ToDecimal(3)) + (projectedDouble * Convert.ToDecimal(2)) + (projectedTriple * Convert.ToDecimal(4)) + (projectedHR * Convert.ToDecimal(10)) + (projectedSB * Convert.ToDecimal(5)) + (projectedWalk * Convert.ToDecimal(2)) + (projectedR * Convert.ToDecimal(2)) + (projectedRBI * Convert.ToDecimal(2));
                                _context.PositionPlayers.Update(player);
                            }
                        }

                        if (player.HomeAway == "Home")
                        {
                            if (opponentStarter.ThrowingHand == "RHP" && player.HomeAb != 0 && player.LastFiveTotalScore != 0 && player.VsRhpAb != 0 && opponentStarter.AwayIp != 0)
                            {
                                projectedHit = (((player.VsRhpHit / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeHit / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveHit / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentHits / Convert.ToDecimal(3)) + (pitcherHomeHit / Convert.ToDecimal(9)) / Convert.ToDecimal(5));
                                projectedDouble = ((player.LastFiveDouble / player.LastFiveAb) * Convert.ToDecimal(3)) + ((player.SeasonDouble / player.SeasonAb) * Convert.ToDecimal(2)) * (opponentHRA / Convert.ToDecimal(3));
                                projectedTriple = ((player.LastFiveTriple / player.LastFiveAb) * Convert.ToDecimal(3)) + ((player.SeasonTriple / player.SeasonAb) * Convert.ToDecimal(2)) * (opponentHRA / Convert.ToDecimal(3));
                                projectedHR = (((player.VsRhpHr / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeHr / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveHR / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentHRA / Convert.ToDecimal(3)) + (pitcherHomeHr / Convert.ToDecimal(9)) / Convert.ToDecimal(5));
                                projectedR = (((player.VsRhpRun / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeRun / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveRuns / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentRuns / Convert.ToDecimal(3)) + (pitcherHomeRun / Convert.ToDecimal(9)) / Convert.ToDecimal(5));
                                projectedRBI = (((player.VsRhpRbi / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeRbi / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveRBI / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentRuns / Convert.ToDecimal(3)) + (pitcherHomeRun / Convert.ToDecimal(9)) / Convert.ToDecimal(5));
                                projectedWalk = (((player.VsRhpWalk / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeWalk / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveWalk / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentWalks / Convert.ToDecimal(3)) + (pitcherHomeWalk / Convert.ToDecimal(9)) / Convert.ToDecimal(4));
                                projectedSB = (((player.VsRhpSb / player.VsRhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeSb / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveSB / player.LastFiveAb) * Convert.ToDecimal(2)) / Convert.ToDecimal(3));

                                player.Projection = (projectedHit * Convert.ToDecimal(3)) + (projectedDouble * Convert.ToDecimal(2)) + (projectedTriple * Convert.ToDecimal(4)) + (projectedHR * Convert.ToDecimal(10)) + (projectedSB * Convert.ToDecimal(5)) + (projectedWalk * Convert.ToDecimal(2)) + (projectedR * Convert.ToDecimal(2)) + (projectedRBI * Convert.ToDecimal(2));
                                _context.PositionPlayers.Update(player);
                            }

                            if (opponentStarter.ThrowingHand == "LHP" && player.HomeAb != 0 && player.LastFiveTotalScore != 0 && player.VsLhpAb != 0 && opponentStarter.AwayIp != 0)
                            {
                                projectedHit = (((player.VsLhpHit / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeHit / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveHit / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentHits / Convert.ToDecimal(3)) + (pitcherHomeHit / Convert.ToDecimal(9)) / Convert.ToDecimal(5));
                                projectedDouble = ((player.LastFiveDouble / player.LastFiveAb) * Convert.ToDecimal(2)) + ((player.SeasonDouble / player.SeasonAb) * Convert.ToDecimal(3)) * (opponentHRA / Convert.ToDecimal(3));
                                projectedTriple = ((player.LastFiveTriple / player.LastFiveAb) * Convert.ToDecimal(2)) + ((player.SeasonTriple / player.SeasonAb) * Convert.ToDecimal(3)) * (opponentHRA / Convert.ToDecimal(3));
                                projectedHR = (((player.VsLhpHr / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeHr / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveHR / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentHRA / Convert.ToDecimal(3)) + (pitcherHomeHr / Convert.ToDecimal(9)) / Convert.ToDecimal(5));
                                projectedR = (((player.VsLhpRun / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeRun / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveRuns / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentRuns / Convert.ToDecimal(3)) + (pitcherHomeRun / Convert.ToDecimal(9)) / Convert.ToDecimal(5));
                                projectedRBI = (((player.VsLhpRbi / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeRbi / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveRBI / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentRuns / Convert.ToDecimal(3)) + (pitcherHomeRun / Convert.ToDecimal(9)) / Convert.ToDecimal(5));
                                projectedWalk = (((player.VsLhpWalk / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeWalk / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveWalk / player.LastFiveAb) * Convert.ToDecimal(2)) + (opponentWalks / Convert.ToDecimal(3)) + (pitcherHomeWalk / Convert.ToDecimal(9)) / Convert.ToDecimal(5));
                                projectedSB = (((player.VsLhpSb / player.VsLhpAb) * Convert.ToDecimal(1.5)) + ((player.HomeSb / player.HomeAb) * Convert.ToDecimal(1.5)) + ((player.LastFiveSB / player.LastFiveAb) * Convert.ToDecimal(2)) / Convert.ToDecimal(3));

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
                var opponentStrikeOuts = opponent.StrikeOuts * .66;
                var opponentHR = opponent.HomeRuns * .66;
                var opponentR = opponent.Runs *  .66;
                var opponentWalk = opponent.Walks * .66;
                var opponentHit = opponent.Hits * .66;
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
                        pitcher.Projection = Convert.ToInt32(Math.Ceiling((projectedStrikeOuts * Convert.ToDecimal(2)) + (projectedRuns * Convert.ToDecimal(-2)) + (projectedHits * Convert.ToDecimal(-.6)) + (projectedHR * Convert.ToDecimal(-3)) + (projectedWalks * Convert.ToDecimal(-.6)) + (pitcher.HomePointsPerIP * (pitcher.LastThreeInningsPitched / Convert.ToDecimal(3)))));
                    _context.Pitchers.Update(pitcher);
                    }

                    if (pitcher.HomeAway == "Away" && pitcher.LastThreeInningsPitched != 0 && pitcher.AwayIp != 0)
                    {
                        pitcher.Projection = Convert.ToInt32(Math.Ceiling((projectedStrikeOuts * Convert.ToDecimal(2)) + (projectedRuns * Convert.ToDecimal(-2)) + (projectedHits * Convert.ToDecimal(-.6)) + (projectedHR * Convert.ToDecimal(-3)) + (projectedWalks * Convert.ToDecimal(-.6)) + (pitcher.AwayPointsPerIP * (pitcher.LastThreeInningsPitched / Convert.ToDecimal(3)))));
                        _context.Pitchers.Update(pitcher);
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
    }
}