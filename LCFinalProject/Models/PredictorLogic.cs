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
                    decimal noRunsRbi = 0;
                    decimal hrCount = 0;
                    foreach (var game in lastFive)
                    {
                        totalScore += game.TotalScore;
                        noRunsRbi -= game.RBI + game.Run;
                        hrCount += game.HomeRun;
                    }
                    hrCount = hrCount * 4;

                    player.LastFiveTotalScore = (totalScore + hrCount)+ noRunsRbi;
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

                    foreach (var game in lastThree)
                    {
                        totalScore += game.TotalScore;
                        ip += game.IP;
                        strikeouts += game.StrikeOuts;
                        homeruns += game.HomeRunsAllowed;
                        runs += game.EarnedRuns;
                    }
                    pitcher.LastThreeERA = runs;
                    pitcher.LastThreeHRA = homeruns;
                    pitcher.LastThreeStrikeouts = strikeouts;
                    pitcher.LastThreeTotalScore = totalScore;
                    pitcher.LastThreeInningsPitched = ip;

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

                        hits += playerGames.Single + playerGames.Double + playerGames.Triple + playerGames.HomeRun;
                        strikeOuts += playerGames.StrikeOut;
                        homeRuns += playerGames.HomeRun;
                        runs += playerGames.Run;

                        playerTeam.Hits = hits;
                        playerTeam.StrikeOuts = strikeOuts;
                        playerTeam.HomeRuns = homeRuns;
                        playerTeam.Runs = runs;

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

            foreach (var pitcher in _context.Pitchers)
            {
                pitcher.ProbableStarter = false;
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
                    var opponentPitcherTeam = gameNode.Attributes["home_team_name"].InnerText;
                   // var matchUp = gameMatchUpNode.Attributes["title"].InnerText;

                    var startingPitcher = _context.Pitchers.Where(p => p.PlayerID == int.Parse(awayPitcherID)).FirstOrDefault();
                    var pitcherTeam = _context.Teams.Where(p => p.TeamName == awayPitcherTeam).FirstOrDefault();

                    pitcherTeam.Opponent = opponentPitcherTeam;
                    _context.Teams.Update(pitcherTeam);

                    if (startingPitcher != null)
                    {
                        startingPitcher.ProbableStarter = true;
                        startingPitcher.ThrowingHand = awayPitcherThrowingHand;
                        startingPitcher.TeamName = awayPitcherTeam;
                        startingPitcher.Opponent = opponentPitcherTeam;

                        //if (matchUp != null)
                        //{
                        //    startingPitcher.MatchUp = matchUp;
                        //}

                        _context.Pitchers.Update(startingPitcher);
                    }

                    if (startingPitcher == null)
                    {
                        Pitcher newPitcher = new Pitcher()
                        {
                            FirstName = awayPitcherFirstName,
                            LastName = awayPitcherLastName,
                            PlayerID = int.Parse(awayPitcherID),
                            ThrowingHand = awayPitcherThrowingHand,
                            ProbableStarter = true,
                            TeamName = awayPitcherTeam,
                            Opponent = opponentPitcherTeam
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
                    //var matchUp = gameMatchUpNode.Attributes["title"].InnerText;
                    var pitcherTeam = _context.Teams.Where(p => p.TeamName == homePitcherTeam).FirstOrDefault();

                    pitcherTeam.Opponent = opponentPitcherTeam;
                    _context.Teams.Update(pitcherTeam);



                    var startingPitcher = _context.Pitchers.Where(p => p.PlayerID == int.Parse(homePitcherID)).FirstOrDefault();

                    if (startingPitcher != null)
                    {
                        startingPitcher.ProbableStarter = true;
                        startingPitcher.ThrowingHand = homePitcherThrowingHand;
                       // startingPitcher.MatchUp = matchUp;
                        startingPitcher.TeamName = homePitcherTeam;
                        startingPitcher.Opponent = opponentPitcherTeam;

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
                            Opponent = opponentPitcherTeam
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

                if (opponentStarter != null)
                {
                    foreach (var player in positionPlayers)
                    {
                        player.OpponentStarter = opponentStarter.FirstName + " " + opponentStarter.LastName;
                        player.MatchUp = opponentStarter.MatchUp;
                        _context.Update(player);
                    }
                }

            }
            _context.SaveChanges();



            //var serializer = new DataContractJsonSerializer(typeof(List<GameData>));

            //starterClient.DefaultRequestHeaders.Accept.Clear();
            //starterClient.DefaultRequestHeaders.Accept.Add(
            //    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            //var urlString = "https://gd2.mlb.com/components/game/mlb/year_" + year + "/month_" + month + "/day_" + day + "/master_scoreboard.json";

            //var streamTask = starterClient.GetStreamAsync(urlString);
            //var games = serializer.ReadObject(await streamTask) as List<GameData>;

            //return games;
        }
    }
}