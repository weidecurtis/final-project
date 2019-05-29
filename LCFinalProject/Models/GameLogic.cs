using LCFinalProject.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using System.Xml;

namespace LCFinalProject.Models
{
    public class GameLogic
    {
        private BeatTheShiftDbContext _context;

        private static readonly HttpClient client = new HttpClient();

        public GameLogic(BeatTheShiftDbContext dbContext)
        {
            _context = dbContext;
        }

        // This downloads the gamePks (gameIds)
        public List<Game> UpdateYesterdayGames(string strJson, DateTime dateTime)
        {
            List<Game> gameList = new List<Game>();
            var json = new WebClient().DownloadString(strJson);
            var deJson = JsonConvert.DeserializeObject<dynamic>(json);
            int gameCount = 0;

            var date = dateTime.Date;

            foreach (var game in deJson.dates[0].games)
            {
                gameCount += 1;
            }

            for (int i = 0; i < gameCount; i++)
            {
                Game newGame = new Game
                {
                    Venue = deJson.dates[0].games[i].venue.name,
                    VenueID = deJson.dates[0].games[i].venue.id,
                    GameDate = date,
                    GameID = deJson.dates[0].games[i].gamePk
                };

                var duplicateGame = _context.Games.Any(g => g.GameID == newGame.GameID);

                if (!duplicateGame)
                {
                    _context.Games.Add(newGame);
                }

               gameList.Add(newGame);
            }

            _context.SaveChanges();
            return gameList;
        }

        public void GetBatterData(Game game)
        {
            var idJson = new WebClient().DownloadString("http://statsapi.mlb.com/api/v1/game/" + game.GameID + "/boxscore");
            var deIdJson = JsonConvert.DeserializeObject<dynamic>(idJson);

            var playerIds = new List<string>();

            var home = deIdJson.teams.home;
            var away = deIdJson.teams.away;


            foreach (string id in home.batters)
            {
                playerIds.Add(id);

            }

            foreach (string id in away.batters)
            {
                playerIds.Add(id);

            }

            foreach (var player in playerIds)
            {
                var downloadString = "http://statsapi.mlb.com/api/v1/people/" + player;
                //var downloadString = "http://statsapi.mlb.com/api/v1/people/665742";
                //Player information Json
                var playerJson = new WebClient().DownloadString(downloadString);
                var dePlayerJson = JsonConvert.DeserializeObject<dynamic>(playerJson);
                var people = dePlayerJson.people[0];
                var dupBatter = _context.Batters.Any(p => p.PlayerID.ToString() == player);

                //GameStats Json
                var statJson = new WebClient().DownloadString("http://statsapi.mlb.com/api/v1/people/" + player + "/stats/game/" + game.GameID);
                var deStatJson = JsonConvert.DeserializeObject<dynamic>(statJson);


                if (!dupBatter)
                {
                    var statsCount = 0;

                    foreach (var item in deStatJson.stats)
                    {
                        statsCount += 1;
                    }
                    if (statsCount > 3) {
                        
                        var countingStats = deStatJson.stats[0].splits[2].stat;
                        var hitData = deStatJson.stats[3];
                        var hitDataCount = 0;

                        if (hitData != null && countingStats.hits != null)
                        {
                            GameStat newGameStat = new GameStat()
                            {
                                PlayerID = people.id,
                                Hits = countingStats.hits,
                                Doubles = countingStats.doubles,
                                Triples = countingStats.triples,
                                HomeRuns = countingStats.homeRuns,
                                Walks = countingStats.baseOnBalls,
                                RBIs = countingStats.rbi,
                                Runs = countingStats.runs,
                                SB = countingStats.stolenBases,
                                CS = countingStats.caughtStealing,
                                Date = game.GameDate,
                                Position = people.primaryPosition.abbreviation,
                                Score = (countingStats.hits * 3) + (countingStats.doubles * 2) + (countingStats.triples * 4) + (countingStats.homeRuns * 10)
                                 + (countingStats.baseOnBalls * 2) + (countingStats.rbi * 2) + (countingStats.runs * 2) + (countingStats.stolenBases * 5)
                            };

                            Batter newBatter = new Batter()
                            {
                                PlayerID = people.id,
                                FirstName = people.firstName,
                                LastName = people.lastName,
                                Position = people.primaryPosition.abbreviation,
                                AtBats = countingStats.atBats,
                                Hits = countingStats.hits,
                                Doubles = countingStats.doubles,
                                Triples = countingStats.triples,
                                HomeRuns = countingStats.homeRuns,
                                Walks = countingStats.baseOnBalls,
                                RBIs = countingStats.rbi,
                                Runs = countingStats.runs,
                                SB = countingStats.stolenBases,
                                CS = countingStats.caughtStealing
                            };



                            foreach (var data in hitData.splits)
                            {
                                hitDataCount += 1;
                            }

                            for (int i = 0; i < hitDataCount; i++)
                            {
                                var dataTest = hitData.splits[i].stat;

                                if (dataTest != null && dataTest.play != null && dataTest.play.hitData != null && dataTest.play.hitData.launchAngle != null && dataTest.play.hitData.launchSpeed != null && dataTest.play.hitData.totalDistance != null)
                                {
                                    HitData newHitData = new HitData()
                                    {
                                        PlayerID = people.id,
                                        LaunchAngle = hitData.splits[i].stat.play.hitData.launchAngle,
                                        LaunchSpeed = hitData.splits[i].stat.play.hitData.launchSpeed,
                                        Distance = hitData.splits[i].stat.play.hitData.totalDistance,
                                        Date = DateTime.Now.Date
                                    };

                                    _context.HitDatas.Add(newHitData);
                                }

                            }
                            _context.GameStats.Add(newGameStat);
                            _context.Batters.Add(newBatter);
                        }
                    }
                }
                    
                else
                {
                    var statsCount = 0;

                    foreach (var item in deStatJson.stats)
                    {
                        statsCount += 1;
                    }
                    if (statsCount > 3)
                    {
                        if (deStatJson.stats[3] != null && deStatJson.stats[0] != null)
                        {
                            var batter = _context.Batters.Where(p => p.PlayerID.ToString() == player).FirstOrDefault();
                            var countingStats = deStatJson.stats[0].splits[2].stat;
                            var hitData = deStatJson.stats[3];
                            var hitDataCount = 0;

                            GameStat newGameStat = new GameStat()
                            {
                                PlayerID = people.id,
                                Hits = countingStats.hits,
                                Doubles = countingStats.doubles,
                                Triples = countingStats.triples,
                                HomeRuns = countingStats.homeRuns,
                                Walks = countingStats.baseOnBalls,
                                RBIs = countingStats.rbi,
                                Runs = countingStats.runs,
                                SB = countingStats.stolenBases,
                                CS = countingStats.caughtStealing,
                                Position = batter.Position,
                                Date = game.GameDate
                            };

                            int AB = countingStats.atBats;
                            int Hits = countingStats.hits;
                            int Doubles = countingStats.doubles;
                            int Triples = countingStats.triples;
                            int HR = countingStats.homeRuns;
                            int BB = countingStats.baseOnBalls;
                            int RBI = countingStats.rbi;
                            int runs = countingStats.runs;
                            int SB = countingStats.stolenBases;
                            int CS = countingStats.caughtStealing;

                            batter.AtBats += AB;
                            batter.Hits += Hits;
                            batter.Doubles += Doubles;
                            batter.Triples += Triples;
                            batter.HomeRuns += HR;
                            batter.Walks += BB;
                            batter.RBIs += RBI;
                            batter.Runs += runs;
                            batter.SB += SB;
                            batter.CS += CS;

                            foreach (var data in hitData.splits)
                            {
                                hitDataCount += 1;
                            }

                            for (int i = 0; i < hitDataCount; i++)
                            {
                                var dataTest = hitData.splits[i].stat;

                                if (dataTest != null && dataTest.play != null && dataTest.play.hitData != null && dataTest.play.hitData.launchAngle != null && dataTest.play.hitData.launchSpeed != null && dataTest.play.hitData.totalDistance != null)
                                {
                                    HitData newHitData = new HitData()
                                    {
                                        PlayerID = people.id,
                                        LaunchAngle = hitData.splits[i].stat.play.hitData.launchAngle,
                                        LaunchSpeed = hitData.splits[i].stat.play.hitData.launchSpeed,
                                        Distance = hitData.splits[i].stat.play.hitData.totalDistance,
                                        Date = DateTime.Now.Date
                                    };

                                    _context.HitDatas.Add(newHitData);
                                    _context.Batters.Update(batter);
                                }

                            }
                            _context.GameStats.Add(newGameStat);
                        }
                    }
                }
            }
            _context.SaveChanges(); 
        }

        public void GetPitcherData(Game game)
        {
            var idJson = new WebClient().DownloadString("http://statsapi.mlb.com/api/v1/game/" + game.GameID + "/boxscore");
            var deIdJson = JsonConvert.DeserializeObject<dynamic>(idJson);

            var playerIds = new List<string>();

            var home = deIdJson.teams.home;
            var away = deIdJson.teams.away;

            foreach (string id in home.pitchers)
            {
                playerIds.Add(id);
            }
            foreach (string id in away.pitchers)
            {
                playerIds.Add(id);
            }

            foreach (var player in playerIds)
            {
                var downloadString = "http://statsapi.mlb.com/api/v1/people/" + player;
                //var downloadString = "http://statsapi.mlb.com/api/v1/people/665742";
                //Player information Json
                var playerJson = new WebClient().DownloadString(downloadString);
                var dePlayerJson = JsonConvert.DeserializeObject<dynamic>(playerJson);
                var people = dePlayerJson.people[0];
                var dupPitcher = _context.Pitchers.Any(p => p.PlayerID.ToString() == player);

                //GameStats Json
                var statJson = new WebClient().DownloadString("http://statsapi.mlb.com/api/v1/people/" + player + "/stats/game/" + game.GameID);
                var deStatJson = JsonConvert.DeserializeObject<dynamic>(statJson);

                if (dupPitcher)
                {
                    var statsCount = 0;

                    foreach (var item in deStatJson.stats)
                    {
                        statsCount += 1;
                    }

                    if (statsCount > 1)
                    {
                        if (deStatJson.stats[1] != null && deStatJson.stats[0] != null)
                        {
                            var pitcher = _context.Pitchers.Where(p => p.PlayerID.ToString() == player).FirstOrDefault();
                            var countingStats = deStatJson.stats[0].splits[1].stat;

                            PitcherGameStat newGameStat = new PitcherGameStat()
                            {
                                PlayerID = people.id,
                                Hits = countingStats.hits,
                                Doubles = countingStats.doubles,
                                Triples = countingStats.triples,
                                HomeRuns = countingStats.homeRuns,
                                Walks = countingStats.baseOnBalls,
                                RBIs = countingStats.rbi,
                                Runs = countingStats.runs,
                                EarnedRuns = countingStats.earnedRuns,
                                SB = countingStats.stolenBases,
                                CS = countingStats.caughtStealing,
                                Date = game.GameDate,
                                OpponentScore = (countingStats.hits * 3) + (countingStats.doubles * 2) + (countingStats.triples * 4) + (countingStats.homeRuns * 10)
                                 + (countingStats.baseOnBalls * 2) + (countingStats.rbi * 2) + (countingStats.runs * 2) + (countingStats.stolenBases * 5),
                                Score = (countingStats.hits * -.6) + (countingStats.earnedRuns * -2) +  (countingStats.baseOnBalls * -.6) + (countingStats.hitBatsmen * -.6) 
                                 + (countingStats.inningsPitched * 2.25)
                            };

                            int gHits = countingStats.hits;
                            int gDoubles = countingStats.doubles;
                            int gTriples = countingStats.triples;
                            int gHomeRuns = countingStats.homeRuns;
                            int gWalks = countingStats.baseOnBalls;
                            int gRBIs = countingStats.rbi;
                            int gRuns = countingStats.runs;
                            int gSB = countingStats.stolenBases;
                            int gCS = countingStats.caughtStealing;

                            pitcher.Hits += gHits;
                            pitcher.Doubles += gDoubles;
                            pitcher.Triples += gTriples;
                            pitcher.HomeRuns += gHomeRuns;
                            pitcher.Walks += gWalks;
                            pitcher.RBIs += gRBIs;
                            pitcher.Runs += gRuns;
                            pitcher.SB += gSB;
                            pitcher.CS += gCS;

                            _context.PitcherGameStats.Add(newGameStat);
                            _context.Pitchers.Update(pitcher);
                        }
                    }
                }

                else
                {
                    var statsCount = 0;

                    foreach (var item in deStatJson.stats)
                    {
                        statsCount += 1;
                    }

                    if (statsCount > 1)
                    {
                        if (deStatJson.stats[1] != null && deStatJson.stats[0] != null)
                        {
                            var batter = _context.Batters.Where(p => p.PlayerID.ToString() == player).FirstOrDefault();
                            var countingStats = deStatJson.stats[0].splits[1].stat;

                            PitcherGameStat newGameStat = new PitcherGameStat()
                            { 
                                PlayerID = people.id,
                                Hits = countingStats.hits,
                                Doubles = countingStats.doubles,
                                Triples = countingStats.triples,
                                HomeRuns = countingStats.homeRuns,
                                Walks = countingStats.baseOnBalls,
                                RBIs = countingStats.rbi,
                                Runs = countingStats.runs,
                                EarnedRuns = countingStats.earnedRuns,
                                SB = countingStats.stolenBases,
                                CS = countingStats.caughtStealing,
                                Date = game.GameDate,
                                OpponentScore = (countingStats.hits * 3) + (countingStats.doubles * 2) + (countingStats.triples * 4) + (countingStats.homeRuns * 10)
                                 + (countingStats.baseOnBalls * 2) + (countingStats.rbi * 2) + (countingStats.runs * 2) + (countingStats.stolenBases * 5),
                                Score = (countingStats.hits * -.6) + (countingStats.earnedRuns * -2) + (countingStats.baseOnBalls * -.6) + (countingStats.hitBatsmen * -.6)
                                 + (countingStats.inningsPitched * 2.25)
                            };

                            Pitcher newPitcher = new Pitcher()
                            {
                                PlayerID = people.id,
                                FirstName = people.firstName,
                                LastName = people.lastName,
                                Hits = countingStats.hits,
                                Doubles = countingStats.doubles,
                                Triples = countingStats.triples,
                                HomeRuns = countingStats.homeRuns,
                                Walks = countingStats.baseOnBalls,
                                RBIs = countingStats.rbi,
                                Runs = countingStats.runs,
                                SB = countingStats.stolenBases,
                                CS = countingStats.caughtStealing
                            };
                            _context.PitcherGameStats.Add(newGameStat);
                            _context.Pitchers.Add(newPitcher);
                        }
                    }
                }
            }
            _context.SaveChanges();
        }

        public void TopGameData(DateTime dateTime) 
        {
            var batterList = new List<Batter>();
            var gameData = _context.GameStats.Where(d => d.Date == dateTime.Date).OrderByDescending(i => i.Score);
            var catcher = 0;
            var first = 0;
            var second = 0;
            var third = 0;
            var shortStop = 0;
            var outfield = 0;

            foreach (var game in gameData)
            {
                if (game.Position == "1B" && first < 5)
                {
                    var player = _context.Batters.Where(p => p.PlayerID == game.PlayerID).FirstOrDefault();

                    TopGame newTopGame = new TopGame()
                    {
                        PlayerID = player.PlayerID,
                        Score = game.Score,
                        Position = player.Position,
                        Date = game.Date
                    };
                    _context.TopGames.Add(newTopGame);
                    first += 1;
                    player.DaysInTop += 1;
                }

                if (game.Position == "2B" && second < 5)
                {
                    var player = _context.Batters.Where(p => p.PlayerID == game.PlayerID).FirstOrDefault();

                    TopGame newTopGame = new TopGame()
                    {
                        PlayerID = player.PlayerID,
                        Score = game.Score,
                        Position = player.Position,
                        Date = game.Date
                    };
                    _context.TopGames.Add(newTopGame);
                    second += 1;
                    player.DaysInTop += 1;
                }

                if (game.Position == "3B" && third < 5)
                {
                    var player = _context.Batters.Where(p => p.PlayerID == game.PlayerID).FirstOrDefault();

                    TopGame newTopGame = new TopGame()
                    {
                        PlayerID = player.PlayerID,
                        Score = game.Score,
                        Position = player.Position,
                        Date = game.Date
                    };
                    _context.TopGames.Add(newTopGame);
                    third += 1;
                    player.DaysInTop += 1;
                }

                if (game.Position == "SS" && shortStop < 5)
                {
                    var player = _context.Batters.Where(p => p.PlayerID == game.PlayerID).FirstOrDefault();

                    TopGame newTopGame = new TopGame()
                    {
                        PlayerID = player.PlayerID,
                        Score = game.Score,
                        Position = player.Position,
                        Date = game.Date
                    };
                    _context.TopGames.Add(newTopGame);
                    shortStop += 1;
                    player.DaysInTop += 1;
                }

                if (game.Position == "C" && catcher < 5)
                {
                    var player = _context.Batters.Where(p => p.PlayerID == game.PlayerID).FirstOrDefault();

                    TopGame newTopGame = new TopGame()
                    {
                        PlayerID = player.PlayerID,
                        Score = game.Score,
                        Position = player.Position,
                        Date = game.Date
                    };
                    _context.TopGames.Add(newTopGame);
                    catcher += 1;
                    player.DaysInTop += 1;
                }

                if (game.Position == "OF" || game.Position == "LF" || game.Position == "RF" || game.Position == "CF")
                {

                    if (outfield < 15)
                    {
                        var player = _context.Batters.Where(p => p.PlayerID == game.PlayerID).FirstOrDefault();

                        TopGame newTopGame = new TopGame()
                        {
                            PlayerID = player.PlayerID,
                            Score = game.Score,
                            Position = player.Position,
                            Date = game.Date
                        };
                        _context.TopGames.Add(newTopGame);
                        outfield += 1;
                        player.DaysInTop += 1;
                    }

                }
            }
            _context.SaveChanges();
        }
        
    }
}
