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
                    player.TeamName = "Athetlics";
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
                    player.TeamName = "Athetlics";
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
        //This takes the last 10 games for position players and averages out their performance.
        public void LastTenGames(PositionPlayer player)
        {
            var currentPlayerLastTen = _context.IndividualGamePosPlayers.Where(p => p.PlayerID == player.PlayerID).OrderByDescending(gd => gd.GameDate).Take(5);

            if (currentPlayerLastTen.Count() > 0)
            {
                int totalAtBats = 0;
                int totalSingles = 0;
                int totalRuns = 0;
                int totalDoubles = 0;
                int totalTriples = 0;
                int totalHomeRuns = 0;
                int totalWalks = 0;
                int totalRBI = 0;
                int totalStolenBase = 0;
                int totalCaughtStealing = 0;

                //Need to add HBP to Individual Games
                foreach (var game in currentPlayerLastTen)
                {
                    totalAtBats += game.Ab;
                    totalSingles += game.Single;
                    totalDoubles += game.Double;
                    totalTriples += game.Triple;
                    totalHomeRuns += game.HomeRun;
                    totalRuns += game.Run;
                    totalWalks += game.Walk;
                    totalRBI += game.RBI;
                    totalStolenBase += game.StolenBase;
                    totalCaughtStealing += game.CaughtStealing;
                }

                var avgAtBat = totalAtBats / currentPlayerLastTen.Count();
                var avgSingle = totalSingles;
                var avgDouble = totalDoubles;
                var avgTriple = totalTriples;
                var avgHomeRun = totalHomeRuns;
                var avgRBI = totalRBI;
                var avgRun = totalRuns;
                var avgStolenBase = totalStolenBase;
                var avgCaughtStealing = totalCaughtStealing / currentPlayerLastTen.Count();
                var avgWalk = totalWalks;
                var gamesPlayed = currentPlayerLastTen.Count();


                var duplicateLastTen = _context.LastTenGamesPosPlayers.Where(p => p.PlayerID == player.PlayerID).Any(d => d.DateEntered == DateTime.Now.Date);

                if (!duplicateLastTen)
                {
                    if (player.Position == "LF" || player.Position == "RF" || player.Position == "CF")
                    {
                        player.Position = "OF";
                    }
                    LastTenGamesPosPlayer newPlayer = new LastTenGamesPosPlayer()
                    {
                        FirstName = player.FirstName,
                        LastName = player.LastName,
                        Position = player.Position,
                        PlayerID = player.PlayerID,
                        AvgAtBat = totalAtBats,
                        AvgSingle = totalSingles,
                        AvgDouble = totalDoubles,
                        AvgTriple = totalTriples,
                        AvgHomeRun = totalHomeRuns,
                        AvgRBI = totalRBI,
                        AvgRun = totalRuns,
                        AvgStolenBase = totalStolenBase,
                        AvgWalk = totalWalks,
                        Team = player.TeamName,
                        DateEntered = DateTime.Now.Date,
                        GamesPlayed = currentPlayerLastTen.Count(),
                        AvgResults = (avgSingle * 3) + (avgDouble * 5) + (avgTriple * 8) + (avgHomeRun * 10) + (avgRBI * 2) + (avgRun * 2) + (avgWalk * 2) + (avgStolenBase * 5)
                    };
                    _context.LastTenGamesPosPlayers.Add(newPlayer);
                }

            }

        }

        //This takes the last 3 games for Pitchers and averages out their performance.
        public void LastThreeGamesPitcher(Pitcher pitcher)
        {
            var currentPitcherLastThree = _context.IndividualGamePitchers.Where(p => p.PlayerID == pitcher.PlayerID).OrderByDescending(gd => gd.GameDate).Take(3);

            if (currentPitcherLastThree.Count() > 0)
            {
                decimal totalIP = 0;
                var totalHitsAllowed = 0;
                var totalRunsAllowed = 0;
                var totalWalksAllowed = 0;
                var totalEarnedRuns = 0;
                var totalStrikeOuts = 0;
                var totalHomeRunsAllowed = 0;
                var totalWins = 0;
                var totalLosses = 0;

                foreach (var game in currentPitcherLastThree)
                {
                    totalIP += game.IP;
                    totalHitsAllowed += game.HitsAllowed;
                    totalRunsAllowed += game.RunsAllowed;
                    totalWalksAllowed += game.Walks;
                    totalEarnedRuns += game.EarnedRuns;
                    totalStrikeOuts += game.StrikeOuts;
                    totalHomeRunsAllowed += game.HomeRunsAllowed;
                    totalWins += game.Wins;
                    totalLosses += game.Losses;
                }

                var duplicateLastThree = _context.LastThreeGamesPitchers.Where(p => p.PlayerID == pitcher.PlayerID).Any(d => d.DateEntered == DateTime.Now.Date);

                var avgIP = totalIP;
                var avgHitsAllowed = totalHitsAllowed;
                var avgRunsAllowed = totalRunsAllowed;
                var avgWalksAllowed = totalWalksAllowed;
                var avgEarnedRuns = totalEarnedRuns;
                var avgStrikeOuts = totalStrikeOuts;
                var avgLosses = totalLosses;
                var avgWins = totalWins;
                var avgHomeRunsAllowed = totalHomeRunsAllowed;

                if (!duplicateLastThree)
                {


                    LastThreeGamesPitcher newPitcher = new LastThreeGamesPitcher()
                    {
                        FirstName = pitcher.FirstName,
                        LastName = pitcher.LastName,
                        PlayerID = pitcher.PlayerID,
                        GamesPlayed = currentPitcherLastThree.Count(),
                        DateEntered = DateTime.Now.Date,
                        AvgIP = avgIP,
                        AvgHitAllowed = avgHitsAllowed,
                        AvgRunAllowed = avgRunsAllowed,
                        AvgWalkAllowed = avgWalksAllowed,
                        AvgEarnedRun = avgEarnedRuns,
                        AvgStrikeOut = avgStrikeOuts,
                        AvgHomeRunAllowed = avgHomeRunsAllowed,
                        AvgLoss = avgLosses,
                        AvgWin = avgWins,
                        AvgResults = (avgIP * Convert.ToDecimal(2.25)) + (avgEarnedRuns * -2) + (avgHitsAllowed * Convert.ToDecimal(-.6)) + (avgWalksAllowed * Convert.ToDecimal(-.6)) + (avgStrikeOuts * 2) + (avgWins * 4)

                    };
                    _context.LastThreeGamesPitchers.Add(newPitcher);
                }
            }
        }
        private List<string> teams = new List<string>(new string[] { "Angels", "Diamondbacks", "Braves", "Orioles", "Red Sox", "White Sox", "Cubs", "Reds", "Indians", "Rockies", "Tigers", "Astros", "Royals", "Dodgers",
            "Marlins", "Brewers", "Twins", "Yankees", "Athletics", "Phillies", "Pirates", "Padres", "Mariners", "Giants", "Cardinals", "Rays", "Rangers", "Blue Jays"});
        
        public void TeamStats()
        {
            foreach (var team in _context.LastFiveGamesTeams)
            {
                _context.LastFiveGamesTeams.Remove(team);
            }
           foreach (var team in teams)
            {
                int strikeOutTotal = 0;
                int homeRunTotal = 0;
                int runTotal = 0;

                for (int i = -5; i < 0; i++)
                {
                    DateTime gameDate = DateTime.Today.Date.AddDays(i);
                    var teamStats = _context.IndividualGamePosPlayers.Where(p => p.GameDate == gameDate && p.Team == team);

                    foreach (var player in teamStats)
                    {
                        homeRunTotal += player.HomeRun;
                        strikeOutTotal += player.StrikeOut;
                        runTotal += player.Run;
                    }
                }

                LastFiveGamesTeam newTeam = new LastFiveGamesTeam()
                {
                    TeamName = team,
                    StrikeOutTotal = strikeOutTotal,
                    HomeRunTotal = homeRunTotal,
                    RunTotal = runTotal
                };

                _context.LastFiveGamesTeams.Add(newTeam);
            }
        }

        //This clears the previous days "standings" for players
        public void ClearPreviousDay()
        {
            foreach (var pitcher in _context.LastThreeGamesPitchers)
            {
                _context.LastThreeGamesPitchers.Remove(pitcher);
            }

            foreach (var player in _context.LastTenGamesPosPlayers)
            {
                _context.LastTenGamesPosPlayers.Remove(player);
            }

            foreach (var pitcher in _context.ProjectedPitchers)
            {
                _context.ProjectedPitchers.Remove(pitcher);
            }

            foreach (var pitcher in _context.HomePitchers)
            {
                _context.HomePitchers.Remove(pitcher);
            }

            foreach (var pitcher in _context.AwayPitchers)
            {
                _context.AwayPitchers.Remove(pitcher);
            }

            foreach (var catcher in _context.AwayCatchers)
            {
                _context.AwayCatchers.Remove(catcher);
            }

            foreach (var catcher in _context.ProjectedCatchers)
            {
                _context.ProjectedCatchers.Remove(catcher);
            }

            foreach (var catcher in _context.HomeCatchers)
            {
                _context.HomeCatchers.Remove(catcher);
            }

            foreach (var catcher in _context.LhpCatchers)
            {
                _context.LhpCatchers.Remove(catcher);
            }

            foreach (var catcher in _context.RhpCatchers)
            {
                _context.RhpCatchers.Remove(catcher);
            }


            foreach (var firstBaseman in _context.ProjectedFirstBasemen)
            {
                _context.ProjectedFirstBasemen.Remove(firstBaseman);
            }

            foreach (var firstBaseman in _context.HomeFirstBasemen)
            {
                _context.HomeFirstBasemen.Remove(firstBaseman);
            }

            foreach (var firstBaseman in _context.AwayFirstBasemen)
            {
                _context.AwayFirstBasemen.Remove(firstBaseman);
            }

            foreach (var firstBaseman in _context.RhpFirstBasemen)
            {
                _context.RhpFirstBasemen.Remove(firstBaseman);
            }

            foreach (var firstBaseman in _context.LhpFirstBasemen)
            {
                _context.LhpFirstBasemen.Remove(firstBaseman);
            }


            foreach (var secondBaseman in _context.ProjectedSecondBasemen)
            {
                _context.ProjectedSecondBasemen.Remove(secondBaseman);
            }

            foreach (var secondBaseman in _context.HomeSecondBasemen)
            {
                _context.HomeSecondBasemen.Remove(secondBaseman);
            }

            foreach (var secondBaseman in _context.AwaySecondBasemen)
            {
                _context.AwaySecondBasemen.Remove(secondBaseman);
            }

            foreach (var secondBaseman in _context.LhpSecondBasemen)
            {
                _context.LhpSecondBasemen.Remove(secondBaseman);
            }

            foreach (var secondBaseman in _context.RhpSecondBasemen)
            {
                _context.RhpSecondBasemen.Remove(secondBaseman);
            }

            foreach (var thirdBaseman in _context.ProjectedThirdBasemen)
            {
                _context.ProjectedThirdBasemen.Remove(thirdBaseman);
            }

            foreach (var thirdBaseman in _context.HomeThirdBasemen)
            {
                _context.HomeThirdBasemen.Remove(thirdBaseman);
            }

            foreach (var thirdBaseman in _context.AwayThirdBasemen)
            {
                _context.AwayThirdBasemen.Remove(thirdBaseman);
            }

            foreach (var thirdBaseman in _context.LhpThirdBasemen)
            {
                _context.LhpThirdBasemen.Remove(thirdBaseman);
            }

            foreach (var thirdBaseman in _context.RhpThirdBasemen)
            {
                _context.RhpThirdBasemen.Remove(thirdBaseman);
            }

            foreach (var shortstop in _context.ProjectedShortstops)
            {
                _context.ProjectedShortstops.Remove(shortstop);
            }

            foreach (var shortstop in _context.HomeShortstops)
            {
                _context.HomeShortstops.Remove(shortstop);
            }

            foreach (var shortstop in _context.AwayShortstops)
            {
                _context.AwayShortstops.Remove(shortstop);
            }

            foreach (var shortstop in _context.RhpShortstops)
            {
                _context.RhpShortstops.Remove(shortstop);
            }

            foreach (var shortstop in _context.LhpShortstops)
            {
                _context.LhpShortstops.Remove(shortstop);
            }

            foreach (var outfielder in _context.ProjectedOutfielders)
            {
                _context.ProjectedOutfielders.Remove(outfielder);
            }

            foreach (var outfielder in _context.HomeOutfielders)
            {
                _context.HomeOutfielders.Remove(outfielder);
            }

            foreach (var outfielder in _context.AwayOutfielders)
            {
                _context.AwayOutfielders.Remove(outfielder);
            }

            foreach (var outfielder in _context.LhpOutfielders)
            {
                _context.LhpOutfielders.Remove(outfielder);
            }

            foreach (var outfielder in _context.RhpOutfielders)
            {
                _context.RhpOutfielders.Remove(outfielder);
            }

            foreach (var catcher in _context.YesterdayCatchers)
            {
                _context.YesterdayCatchers.Remove(catcher);
            }

            foreach (var outfielder in _context.YesterdayOutfielders)
            {
                _context.YesterdayOutfielders.Remove(outfielder);
            }

            foreach (var firstbase in _context.YesterdayFirstBasemen)
            {
                _context.YesterdayFirstBasemen.Remove(firstbase);
            }

            foreach (var secondbase in _context.YesterdaySecondBasemen)
            {
                _context.YesterdaySecondBasemen.Remove(secondbase);
            }

            foreach (var thirdbase in _context.YesterdayThirdBasemen)
            {
                _context.YesterdayThirdBasemen.Remove(thirdbase);
            }

            foreach (var shortstop in _context.YesterdayShortstops)
            {
                _context.YesterdayShortstops.Remove(shortstop);
            }
            _context.SaveChanges();
        }

        //This gathers all data for players (home/away splits .. vs lhp and rhp)
        public void UpdatePlayers()
        {
            var pitcher = _context.LastThreeGamesPitchers.OrderByDescending(p => p.AvgResults).Take(20).DistinctBy(p => p.PlayerID);
            var pitcherStrikeOuts = _context.LastThreeGamesPitchers.OrderByDescending(p => p.AvgStrikeOut).Take(20).DistinctBy(p => p.PlayerID);
            var catcher = _context.LastTenGamesPosPlayers.Where(p => p.Position == "C").OrderByDescending(p => p.AvgResults).Take(15).DistinctBy(p => p.PlayerID);
            var firstBase = _context.LastTenGamesPosPlayers.Where(p => p.Position == "1B").OrderByDescending(p => p.AvgResults).Take(15).DistinctBy(p => p.PlayerID);
            var secondBase = _context.LastTenGamesPosPlayers.Where(p => p.Position == "2B").OrderByDescending(p => p.AvgResults).Take(15).DistinctBy(p => p.PlayerID);
            var thirdBase = _context.LastTenGamesPosPlayers.Where(p => p.Position == "3B").OrderByDescending(p => p.AvgResults).Take(15).DistinctBy(p => p.PlayerID);
            var shortstop = _context.LastTenGamesPosPlayers.Where(p => p.Position == "SS").OrderByDescending(p => p.AvgResults).Take(15).DistinctBy(p => p.PlayerID);
            var outfield = _context.LastTenGamesPosPlayers.Where(p => p.Position == "OF").OrderByDescending(p => p.AvgResults).Take(25).DistinctBy(p => p.PlayerID);

            var awayPitchers = _context.Pitchers.OrderByDescending(p => p.AwayTotalScore).Take(20);
            var awayCatchers = _context.PositionPlayers.Where(p => p.Position == "C").OrderByDescending(p => p.AwayTotalScore).Take(15).DistinctBy(p => p.PlayerID);
            var awayFirstBasemen = _context.PositionPlayers.Where(p => p.Position == "1B").OrderByDescending(p => p.AwayTotalScore).Take(15).DistinctBy(p => p.PlayerID);
            var awaySecondBasemen = _context.PositionPlayers.Where(p => p.Position == "2B").OrderByDescending(p => p.AwayTotalScore).Take(15).DistinctBy(p => p.PlayerID);
            var awayThirdBasemen = _context.PositionPlayers.Where(p => p.Position == "3B").OrderByDescending(p => p.AwayTotalScore).Take(15).DistinctBy(p => p.PlayerID);
            var awayShortstops = _context.PositionPlayers.Where(p => p.Position == "SS").OrderByDescending(p => p.AwayTotalScore).Take(15).DistinctBy(p => p.PlayerID);
            var awayOutfielders = _context.PositionPlayers.Where(p => p.Position == "OF").OrderByDescending(p => p.AwayTotalScore).Take(25).DistinctBy(p => p.PlayerID);

            var homePitchers = _context.Pitchers.OrderByDescending(p => p.HomeTotalScore).Take(20).DistinctBy(p => p.PlayerID);
            var homeCatchers = _context.PositionPlayers.Where(p => p.Position == "C") .OrderByDescending(p => p.HomeTotalScore).Take(15).DistinctBy(p => p.PlayerID);
            var homeFirstBasemen = _context.PositionPlayers.Where(p => p.Position == "1B").OrderByDescending(p => p.HomeTotalScore).Take(15).DistinctBy(p => p.PlayerID);
            var homeSecondBasemen = _context.PositionPlayers.Where(p => p.Position == "2B").OrderByDescending(p => p.HomeTotalScore).Take(15).DistinctBy(p => p.PlayerID);
            var homeThirdBasemen = _context.PositionPlayers.Where(p => p.Position == "3B").OrderByDescending(p => p.HomeTotalScore).Take(15).DistinctBy(p => p.PlayerID);
            var homeShortstops = _context.PositionPlayers.Where(p => p.Position == "SS").OrderByDescending(p => p.HomeTotalScore).Take(15).DistinctBy(p => p.PlayerID);
            var homeOutfielders = _context.PositionPlayers.Where(p => p.Position == "OF").OrderByDescending(p => p.HomeTotalScore).Take(25).DistinctBy(p => p.PlayerID);

            var lhpCatchers = _context.PositionPlayers.Where(p => p.Position == "C").OrderByDescending(p => p.VsLhpTotalScore).Take(15).DistinctBy(p => p.PlayerID);
            var lhpFirstBasemen = _context.PositionPlayers.Where(p => p.Position == "1B").OrderByDescending(p => p.VsLhpTotalScore).Take(15).DistinctBy(p => p.PlayerID);
            var lhpSecondBasemen = _context.PositionPlayers.Where(p => p.Position == "2B").OrderByDescending(p => p.VsLhpTotalScore).Take(15).DistinctBy(p => p.PlayerID);
            var lhpThirdBasemen = _context.PositionPlayers.Where(p => p.Position == "3B").OrderByDescending(p => p.VsLhpTotalScore).Take(15).DistinctBy(p => p.PlayerID);
            var lhpShortstops = _context.PositionPlayers.Where(p => p.Position == "SS").OrderByDescending(p => p.VsLhpTotalScore).Take(15).DistinctBy(p => p.PlayerID);
            var lhpOutfielders = _context.PositionPlayers.Where(p => p.Position == "OF").OrderByDescending(p => p.VsLhpTotalScore).Take(25).DistinctBy(p => p.PlayerID);

            var rhpCatchers = _context.PositionPlayers.Where(p => p.Position == "C").OrderByDescending(p => p.VsRhpTotalScore).Take(15).DistinctBy(p => p.PlayerID);
            var rhpFirstBasemen = _context.PositionPlayers.Where(p => p.Position == "1B").OrderByDescending(p => p.VsRhpTotalScore).Take(15).DistinctBy(p => p.PlayerID);
            var rhpSecondBasemen = _context.PositionPlayers.Where(p => p.Position == "2B").OrderByDescending(p => p.VsRhpTotalScore).Take(15).DistinctBy(p => p.PlayerID);
            var rhpThirdBasemen = _context.PositionPlayers.Where(p => p.Position == "3B").OrderByDescending(p => p.VsRhpTotalScore).Take(15).DistinctBy(p => p.PlayerID);
            var rhpShortstops = _context.PositionPlayers.Where(p => p.Position == "SS").OrderByDescending(p => p.VsRhpTotalScore).Take(15).DistinctBy(p => p.PlayerID);
            var rhpOutfielders = _context.PositionPlayers.Where(p => p.Position == "OF").OrderByDescending(p => p.VsRhpTotalScore).Take(25).DistinctBy(p => p.PlayerID);

            var yesterdayCatchers = _context.IndividualGamePosPlayers.Where(p => p.Position == "C" && p.GameDate == DateTime.Today.Date.AddDays(-1)).OrderByDescending(p => p.TotalScore).Take(10).DistinctBy(p => p.PlayerID).ToList();
            var yesterdayFirstBasemen = _context.IndividualGamePosPlayers.Where(p => p.Position == "1B" && p.GameDate == DateTime.Today.Date.AddDays(-1)).OrderByDescending(p => p.TotalScore).Take(10).DistinctBy(p => p.PlayerID).ToList();
            var yesterdaySecondBasemen = _context.IndividualGamePosPlayers.Where(p => p.Position == "2B" && p.GameDate == DateTime.Today.Date.AddDays(-1)).OrderByDescending(p => p.TotalScore).Take(10).DistinctBy(p => p.PlayerID).ToList();
            var yesterdayThirdBasemen = _context.IndividualGamePosPlayers.Where(p => p.Position == "3B" && p.GameDate == DateTime.Today.Date.AddDays(-1)).OrderByDescending(p => p.TotalScore).Take(10).DistinctBy(p => p.PlayerID).ToList();
            var yesterdayShortstops = _context.IndividualGamePosPlayers.Where(p => p.Position == "SS" && p.GameDate == DateTime.Today.Date.AddDays(-1)).OrderByDescending(p => p.TotalScore).Take(10).DistinctBy(p => p.PlayerID).ToList();
            var yesterdayOutfielders = _context.IndividualGamePosPlayers.Where(p => p.Position == "OF" && p.GameDate == DateTime.Today.Date.AddDays(-1)).OrderByDescending(p => p.TotalScore).Take(20).DistinctBy(p => p.PlayerID).ToList();





            foreach (var newPitcher in pitcher)
            {
                ProjectedPitcher projectedPitcher = new ProjectedPitcher()
                {
                    PlayerID = newPitcher.PlayerID,
                    Name = newPitcher.FirstName + " " + newPitcher.LastName,
                    ProjectedScore = newPitcher.AvgResults
                };
                var existingPitcher = _context.ProjectedPitchers.Any(p => p.PlayerID == newPitcher.PlayerID);


                if (!existingPitcher)
                {
                    _context.ProjectedPitchers.Add(projectedPitcher);
                }

            }

            foreach (var player in catcher)
            {
                ProjectedCatcher projectedCatcher = new ProjectedCatcher()
                {
                    PlayerID = player.PlayerID,
                    Name = player.FirstName + " " + player.LastName,
                    ProjectedScore = player.AvgResults,
                    Team = player.Team
                };
                var existingCatcher = _context.ProjectedCatchers.Any(p => p.PlayerID == player.PlayerID);

                if (!existingCatcher)
                {
                    _context.ProjectedCatchers.Add(projectedCatcher);
                }
            }

            foreach (var player in firstBase)
            {
                ProjectedFirstBaseman projectedFirstBaseman = new ProjectedFirstBaseman()
                {
                    PlayerID = player.PlayerID,
                    Name = player.FirstName + " " + player.LastName,
                    ProjectedScore = player.AvgResults,
                    Team = player.Team

                };
                var existingFirstBaseman = _context.ProjectedFirstBasemen.Any(p => p.PlayerID == player.PlayerID);

                if (!existingFirstBaseman)
                {
                    _context.ProjectedFirstBasemen.Add(projectedFirstBaseman);
                }
            }

            foreach (var player in secondBase)
            {
                ProjectedSecondBaseman projectedSecondBaseman = new ProjectedSecondBaseman()
                {
                    PlayerID = player.PlayerID,
                    Name = player.FirstName + " " + player.LastName,
                    ProjectedScore = player.AvgResults,
                    Team = player.Team
                };

                var existingSecondBaseman = _context.ProjectedSecondBasemen.Any(p => p.PlayerID == player.PlayerID);

                if (!existingSecondBaseman)
                {
                    _context.ProjectedSecondBasemen.Add(projectedSecondBaseman);
                }
            }

            foreach (var player in thirdBase)
            {
                ProjectedThirdBaseman projectedThirdBaseman = new ProjectedThirdBaseman()
                {
                    PlayerID = player.PlayerID,
                    Name = player.FirstName + " " + player.LastName,
                    ProjectedScore = player.AvgResults,
                    Team = player.Team
                };
                var existingThirdBaseman = _context.ProjectedThirdBasemen.Any(p => p.PlayerID == player.PlayerID);

                if (!existingThirdBaseman)
                {
                    _context.ProjectedThirdBasemen.Add(projectedThirdBaseman);
                }
            }

            foreach (var player in shortstop)
            {
                ProjectedShortstop projectedShortstop = new ProjectedShortstop()
                {
                    PlayerID = player.PlayerID,
                    Name = player.FirstName + " " + player.LastName,
                    ProjectedScore = player.AvgResults,
                    Team = player.Team
                };
                var existingShortstop = _context.ProjectedShortstops.Any(p => p.PlayerID == player.PlayerID);

                if (!existingShortstop)
                {
                    _context.ProjectedShortstops.Add(projectedShortstop);
                }
            }

            foreach (var player in outfield)
            {
                ProjectedOutfielder projectedOutfielder = new ProjectedOutfielder()
                {
                    PlayerID = player.PlayerID,
                    Name = player.FirstName + " " + player.LastName,
                    ProjectedScore = player.AvgResults,
                    Team = player.Team
                };
                var existingOutfielder = _context.ProjectedOutfielders.Any(p => p.PlayerID == player.PlayerID);

                if (!existingOutfielder)
                {
                    _context.ProjectedOutfielders.Add(projectedOutfielder);
                }

            }

            foreach (var awayPitcher in awayPitchers)
            {
                AwayPitcher newAwayPitcher = new AwayPitcher()
                {
                    PlayerID =awayPitcher.PlayerID,
                    Name = awayPitcher.FirstName + " " + awayPitcher.LastName,
                    TotalScore = awayPitcher.AwayTotalScore,
                };

                var existingPitcher = _context.AwayPitchers.Any(p => p.PlayerID == awayPitcher.PlayerID);

                if (!existingPitcher)
                {
                    _context.AwayPitchers.Add(newAwayPitcher);
                }
            }

            foreach (var player in awayCatchers)
            {
                if (player.AwayAb != 0)
                {
                    AwayCatcher newAwayCatcher = new AwayCatcher()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.AwayTotalScore,
                        PointPerAtBat = player.AwayTotalScore / player.AwayAb,
                        Team = player.TeamName
                    };

                    var existingCatcher = _context.AwayCatchers.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingCatcher)
                    {
                        _context.AwayCatchers.Add(newAwayCatcher);
                    }
                }
            }

            foreach (var player in awayFirstBasemen)
            {
                if (player.AwayAb != 0)
                {
                    AwayFirstBaseman newAwayFirstBase = new AwayFirstBaseman()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.AwayTotalScore,
                        PointPerAtBat = player.AwayTotalScore / player.AwayAb,
                        Team = player.TeamName
                    };
                    var existingFirstBaseman = _context.AwayFirstBasemen.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingFirstBaseman)
                    {
                        _context.AwayFirstBasemen.Add(newAwayFirstBase);
                    }
                }
            }

            foreach (var player in awaySecondBasemen)
            {
                if (player.AwayAb != 0)
                {
                    AwaySecondBaseman newAwaySecondBase = new AwaySecondBaseman()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.AwayTotalScore,
                        PointPerAtBat = player.AwayTotalScore / player.AwayAb,
                        Team = player.TeamName
                    };
                    var existingSecondBaseman = _context.AwaySecondBasemen.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingSecondBaseman)
                    {
                        _context.AwaySecondBasemen.Add(newAwaySecondBase);
                    }
                }
            }

            foreach (var player in awayThirdBasemen)
            {
                if (player.AwayAb != 0)
                {
                    AwayThirdBaseman newAwayThridBase = new AwayThirdBaseman()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.AwayTotalScore,
                        PointPerAtBat = player.AwayTotalScore / player.AwayAb,
                        Team = player.TeamName
                    };
                    var existingThirdBaseman = _context.AwayThirdBasemen.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingThirdBaseman)
                    {
                        _context.AwayThirdBasemen.Add(newAwayThridBase);
                    }
                }
            }

            foreach (var player in awayShortstops)
            {
                if (player.AwayAb != 0)
                {
                    AwayShortstop newAwayShortstop = new AwayShortstop()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.AwayTotalScore,
                        PointPerAtBat = player.AwayTotalScore / player.AwayAb,
                        Team = player.TeamName
                    };
                    var existingShortstop = _context.AwayShortstops.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingShortstop)
                    {
                        _context.AwayShortstops.Add(newAwayShortstop);
                    }
                }
            }

            foreach (var player in awayOutfielders)
            {
                if (player.AwayAb != 0)
                {
                    AwayOutfielder newAwayOutfielder = new AwayOutfielder()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.AwayTotalScore,
                        PointPerAtBat = player.AwayTotalScore / player.AwayAb,
                        Team = player.TeamName
                    };
                    var existingOutfielder = _context.AwayOutfielders.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingOutfielder)
                    {
                        _context.AwayOutfielders.Add(newAwayOutfielder);
                    }
                }
            }

            foreach (var homePitcher in homePitchers)
            {
                HomePitcher newHomePitcher = new HomePitcher()
                {
                    PlayerID = homePitcher.PlayerID,
                    Name = homePitcher.FirstName + " " + homePitcher.LastName,
                    TotalScore = homePitcher.HomeTotalScore
                };
                var existingPitcher = _context.HomePitchers.Any(p => p.PlayerID == homePitcher.PlayerID);

                if (!existingPitcher)
                {
                    _context.HomePitchers.Add(newHomePitcher);
                }
            }

            foreach (var player in homeCatchers)
            {
                if (player.HomeAb != 0)
                {
                    HomeCatcher newHomeCatcher = new HomeCatcher()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.HomeTotalScore,
                        PointPerAtBat = player.HomeTotalScore / player.HomeAb,
                        Team = player.TeamName
                    };

                    var existingCatcher = _context.HomeCatchers.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingCatcher)
                    {
                        _context.HomeCatchers.Add(newHomeCatcher);
                    }
                }
            }

            foreach (var player in homeFirstBasemen)
            {

                if (player.HomeAb != 0)
                {
                    HomeFirstBaseman newHomeFirstBase = new HomeFirstBaseman()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.HomeTotalScore,
                        PointPerAtBat = player.HomeTotalScore / player.HomeAb,
                        Team = player.TeamName
                    };
                    var existingFirstBaseman = _context.HomeFirstBasemen.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingFirstBaseman)
                    {
                        _context.HomeFirstBasemen.Add(newHomeFirstBase);
                    }
                }
                
            }

            foreach (var player in homeSecondBasemen)
            {
                if (player.HomeAb != 0)
                {
                    HomeSecondBaseman newHomeSecondBase = new HomeSecondBaseman()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.HomeTotalScore,
                        PointPerAtBat = player.HomeTotalScore / player.HomeAb,
                        Team = player.TeamName
                    };
                    var existingSecondBaseman = _context.HomeSecondBasemen.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingSecondBaseman)
                    {
                        _context.HomeSecondBasemen.Add(newHomeSecondBase);
                    }
                }
               
            }

            foreach (var player in homeThirdBasemen)
            {

                if (player.HomeAb != 0)
                {
                    HomeThirdBaseman newHomeThridBase = new HomeThirdBaseman()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.HomeTotalScore,
                        PointPerAtBat = player.HomeTotalScore / player.HomeAb,
                        Team = player.TeamName
                    };
                    var existingThirdBaseman = _context.HomeThirdBasemen.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingThirdBaseman)
                    {
                        _context.HomeThirdBasemen.Add(newHomeThridBase);
                    }
                }
                
            }

            foreach (var player in homeShortstops)
            {
                if (player.HomeAb != 0)
                {

                    HomeShortstop newHomeShortstop = new HomeShortstop()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.HomeTotalScore,
                        PointPerAtBat = player.HomeTotalScore / player.HomeAb,
                        Team = player.TeamName
                    };
                    var existingShortstop = _context.HomeShortstops.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingShortstop)
                    {
                        _context.HomeShortstops.Add(newHomeShortstop);
                    }
                }
            }

            foreach (var player in homeOutfielders)
            {
                if (player.HomeAb != 0)
                {
                    HomeOutfielder newHomeOutfielder = new HomeOutfielder()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.HomeTotalScore,
                        PointPerAtBat = player.HomeTotalScore / player.HomeAb,
                        Team = player.TeamName
                    };
                    var existingOutfielder = _context.HomeOutfielders.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingOutfielder)
                    {
                        _context.HomeOutfielders.Add(newHomeOutfielder);
                    }
                }
            }

            foreach (var player in rhpCatchers)
            {
                if (player.VsRhpAb != 0)
                {
                    RhpCatcher newRhpCatcher = new RhpCatcher()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.VsRhpTotalScore,
                        PointPerAtBat = player.VsRhpTotalScore / player.VsRhpAb,
                        Team = player.TeamName
                    };

                    var existingCatcher = _context.RhpCatchers.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingCatcher)
                    {
                        _context.RhpCatchers.Add(newRhpCatcher);
                    }
                }
            }

            foreach (var player in rhpFirstBasemen)
            {
                if (player.VsRhpAb != 0)
                {
                    RhpFirstBaseman newRhpFirstBase = new RhpFirstBaseman()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.VsRhpTotalScore,
                        PointPerAtBat = player.VsRhpTotalScore / player.VsRhpAb,
                        Team = player.TeamName
                    };
                    var existingFirstBase = _context.RhpFirstBasemen.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingFirstBase)
                    {
                        _context.RhpFirstBasemen.Add(newRhpFirstBase);
                    }
                }
            }

            foreach (var player in rhpSecondBasemen)
            {
                if (player.VsRhpAb != 0)
                {
                    RhpSecondBaseman newRhpSecondBase = new RhpSecondBaseman()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.VsRhpTotalScore,
                        PointPerAtBat = player.VsRhpTotalScore / player.VsRhpAb,
                        Team = player.TeamName
                    };
                    var existingSecondBaseman = _context.RhpSecondBasemen.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingSecondBaseman)
                    {
                        _context.RhpSecondBasemen.Add(newRhpSecondBase);
                    }
                }
            }

            foreach (var player in rhpThirdBasemen)
            {
                if (player.VsRhpAb != 0)
                {
                    RhpThirdBaseman newRhpThridBase = new RhpThirdBaseman()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.VsRhpTotalScore,
                        PointPerAtBat = player.VsRhpTotalScore / player.VsRhpAb,
                        Team = player.TeamName
                    };
                    var existingThirdBaseman = _context.RhpThirdBasemen.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingThirdBaseman)
                    {
                        _context.RhpThirdBasemen.Add(newRhpThridBase);
                    }
                }
            }

            foreach (var player in rhpShortstops)
            {
                if (player.VsRhpAb != 0)
                {
                    RhpShortstop newRhpShortstop = new RhpShortstop()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.VsRhpTotalScore,
                        PointPerAtBat = player.VsRhpTotalScore / player.VsRhpAb,
                        Team = player.TeamName
                    };
                    var existingShortstop = _context.RhpShortstops.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingShortstop)
                    {
                        _context.RhpShortstops.Add(newRhpShortstop);
                    }
                }
            }

            foreach (var player in rhpOutfielders)
            {
                if (player.VsRhpAb != 0)
                {
                    RhpOutfielder newRhpOutfielder = new RhpOutfielder()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.VsRhpTotalScore,
                        PointPerAtBat = player.VsRhpTotalScore / player.VsRhpAb,
                        Team = player.TeamName
                    };
                    var existingOutfielder = _context.RhpOutfielders.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingOutfielder)
                    {
                        _context.RhpOutfielders.Add(newRhpOutfielder);
                    }
                }
            }

            foreach (var player in lhpCatchers)
            {
                if (player.VsLhpAb != 0)
                {
                    LhpCatcher newLhpCatcher = new LhpCatcher()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.VsLhpTotalScore,
                        PointPerAtBat = player.VsLhpTotalScore / player.VsLhpAb,
                        Team = player.TeamName
                    };
                    var existingCatcher = _context.LhpCatchers.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingCatcher)
                    {
                        _context.LhpCatchers.Add(newLhpCatcher);
                    }
                }
            }

            foreach (var player in lhpFirstBasemen)
            {
                if (player.VsLhpAb != 0)
                {
                    LhpFirstBaseman newLhpFirstBase = new LhpFirstBaseman()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.VsLhpTotalScore,
                        PointPerAtBat = player.VsLhpTotalScore / player.VsLhpAb,
                        Team = player.TeamName
                    };
                    var existingFirstBase = _context.LhpFirstBasemen.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingFirstBase)
                    {
                        _context.LhpFirstBasemen.Add(newLhpFirstBase);
                    }
                }
            }

            foreach (var player in lhpSecondBasemen)
            {
                if (player.VsLhpAb != 0)
                {
                    LhpSecondBaseman newLhpSecondBase = new LhpSecondBaseman()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.VsLhpTotalScore,
                        PointPerAtBat = player.VsLhpTotalScore / player.VsLhpAb,
                        Team = player.TeamName
                    };
                    var existingSecondBase = _context.LhpSecondBasemen.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingSecondBase)
                    {
                        _context.LhpSecondBasemen.Add(newLhpSecondBase);
                    }
                }
            }

            foreach (var player in lhpThirdBasemen)
            {
                if (player.VsLhpAb != 0)
                {
                    LhpThirdBaseman newLhpThridBase = new LhpThirdBaseman()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.VsLhpTotalScore,
                        PointPerAtBat = player.VsLhpTotalScore / player.VsLhpAb,
                        Team = player.TeamName
                    };
                    var existingThirdBase = _context.LhpThirdBasemen.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingThirdBase)
                    {
                        _context.LhpThirdBasemen.Add(newLhpThridBase);
                    }
                }
            }

            foreach (var player in lhpShortstops)
            {
                if (player.VsLhpAb != 0)
                {
                    LhpShortstop newLhpShortstop = new LhpShortstop()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.VsLhpTotalScore,
                        PointPerAtBat = player.VsLhpTotalScore / player.VsLhpAb,
                        Team = player.TeamName
                    };
                    var existingShortstop = _context.LhpShortstops.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingShortstop)
                    {
                        _context.LhpShortstops.Add(newLhpShortstop);
                    }
                }
            }

            foreach (var player in lhpOutfielders)
            {
                if (player.VsLhpAb != 0)
                {
                    LhpOutfielder newLhpOutfielder = new LhpOutfielder()
                    {
                        PlayerID = player.PlayerID,
                        Name = player.FirstName + " " + player.LastName,
                        TotalScore = player.VsLhpTotalScore,
                        PointPerAtBat = player.VsLhpTotalScore / player.VsLhpAb,
                        Team = player.TeamName
                    };
                    var existingOutfielder = _context.LhpOutfielders.Any(p => p.PlayerID == player.PlayerID);

                    if (!existingOutfielder)
                    {
                        _context.LhpOutfielders.Add(newLhpOutfielder);
                    }
                }
            }

            foreach (var player in yesterdayCatchers)
            {
                YesterdayCatchers yesterdayCatcher = new YesterdayCatchers()
                {
                    Name = player.FirstName + " " + player.LastName,
                    TotalScore = player.TotalScore,
                    PlayerID = player.PlayerID
                };

                _context.YesterdayCatchers.Add(yesterdayCatcher);
            }

            foreach (var player in yesterdayOutfielders)
            {
                YesterdayOutfielder yesterdayOutfielder = new YesterdayOutfielder()
                {
                    Name = player.FirstName + " " + player.LastName,
                    TotalScore = player.TotalScore,
                    PlayerID = player.PlayerID
                };

                _context.YesterdayOutfielders.Add(yesterdayOutfielder);
            }

            foreach (var player in yesterdayFirstBasemen)
            {
                YesterdayFirstBase yesterdayFirstBase = new YesterdayFirstBase()
                {
                    Name = player.FirstName + " " + player.LastName,
                    TotalScore = player.TotalScore,
                    PlayerID = player.PlayerID
                };

                _context.YesterdayFirstBasemen.Add(yesterdayFirstBase);
            }

            foreach (var player in yesterdaySecondBasemen)
            {
                YesterdaySecondBase yesterdaySecondBase = new YesterdaySecondBase()
                {
                    Name = player.FirstName + " " + player.LastName,
                    TotalScore = player.TotalScore,
                    PlayerID = player.PlayerID
                };

                _context.YesterdaySecondBasemen.Add(yesterdaySecondBase);
            }

            foreach (var player in yesterdayThirdBasemen)
            {
                YesterdayThirdBase yesterdayThirdBase = new YesterdayThirdBase()
                {
                    Name = player.FirstName + " " + player.LastName,
                    TotalScore = player.TotalScore,
                    PlayerID = player.PlayerID
                };

                _context.YesterdayThirdBasemen.Add(yesterdayThirdBase);
            }

            foreach (var player in yesterdayShortstops)
            {
                YesterdayShortstop yesterdayShortstop = new YesterdayShortstop()
                {
                    Name = player.FirstName + " " + player.LastName,
                    TotalScore = player.TotalScore,
                    PlayerID = player.PlayerID
                };

                _context.YesterdayShortstops.Add(yesterdayShortstop);
            }



            _context.SaveChanges();
        }

    }
}
