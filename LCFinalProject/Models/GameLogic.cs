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
        public List<Game> UpdateYesterdayGames(string strJson)
        {
            List<Game> gameList = new List<Game>();
            var json = new WebClient().DownloadString(strJson);
            var deJson = JsonConvert.DeserializeObject<dynamic>(json);
            int gameCount = 0;

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
                    GameDate = deJson.dates[0].games[i].gameDate,
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

        public void GetData(Game game)
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

            foreach (string id in home.pitchers)
            {
                playerIds.Add(id);

            }
            foreach (string id in away.batters)
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
                                Hits = countingStats.hits,
                                Doubles = countingStats.doubles,
                                Triples = countingStats.triples,
                                HomeRuns = countingStats.homeRuns,
                                Walks = countingStats.baseOnBalls,
                                RBIs = countingStats.rbi,
                                Runs = countingStats.runs,
                                SB = countingStats.stolenBases,
                                CS = countingStats.caughtStealing,
                                Score = (countingStats.hits * 3) + (countingStats.doubles * 2) + (countingStats.triples * 4) + (countingStats.homeRuns * 10)
                                 + (countingStats.baseOnBalls * 2) + (countingStats.rbi * 2) + (countingStats.runs * 2) + (countingStats.stolenBases * 5)
                            };

                            Batter newBatter = new Batter()
                            {
                                PlayerID = people.id,
                                FirstName = people.firstName,
                                LastName = people.lastName,
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

                                    _context.Add(newHitData);
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

                                    _context.Add(newHitData);
                                }

                            }
                            _context.GameStats.Add(newGameStat);
                        }
                    }
                }
            }
            _context.SaveChanges();
        }
        
    }
}
