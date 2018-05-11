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

        //This takes the last 10 games for position players and averages out their performance.
        public void LastTenGames(PositionPlayer player)
        {
            var currentPlayerLastTen = _context.IndividualGamePosPlayers.Where(p => p.PlayerID == player.PlayerID).OrderByDescending(gd => gd.GameDate).Take(10);

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
                var avgSingle = totalSingles / currentPlayerLastTen.Count();
                var avgDouble = totalDoubles / currentPlayerLastTen.Count();
                var avgTriple = totalTriples / currentPlayerLastTen.Count();
                var avgHomeRun = totalHomeRuns / currentPlayerLastTen.Count();
                var avgRBI = totalRBI / currentPlayerLastTen.Count();
                var avgRun = totalRuns / currentPlayerLastTen.Count();
                var avgStolenBase = totalStolenBase / currentPlayerLastTen.Count();
                var avgCaughtStealing = totalCaughtStealing / currentPlayerLastTen.Count();
                var avgWalk = totalWalks / currentPlayerLastTen.Count();
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
                        AvgAtBat = avgAtBat,
                        AvgSingle = avgSingle,
                        AvgDouble = avgDouble,
                        AvgTriple = avgTriple,
                        AvgHomeRun = avgHomeRun,
                        AvgRBI = avgRBI,
                        AvgRun = avgRun,
                        AvgStolenBase = avgStolenBase,
                        AvgCaughtStealing = avgCaughtStealing,
                        AvgWalk = avgWalk,
                        DateEntered = DateTime.Now.Date,
                        GamesPlayed = gamesPlayed,
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

                var avgIP = totalIP / currentPitcherLastThree.Count();
                var avgHitsAllowed = totalHitsAllowed / currentPitcherLastThree.Count();
                var avgRunsAllowed = totalRunsAllowed / currentPitcherLastThree.Count();
                var avgWalksAllowed = totalWalksAllowed / currentPitcherLastThree.Count();
                var avgEarnedRuns = totalEarnedRuns / currentPitcherLastThree.Count();
                var avgStrikeOuts = totalStrikeOuts / currentPitcherLastThree.Count();
                var avgLosses = totalLosses / currentPitcherLastThree.Count();
                var avgWins = totalWins / currentPitcherLastThree.Count();
                var avgHomeRunsAllowed = totalHomeRunsAllowed / currentPitcherLastThree.Count();

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

        //This clears the previous days "standings" for players
        public void ClearPreviousDay()
        {
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

            _context.SaveChanges();
        }

        //This gathers all data for players (home/away splits .. vs lhp and rhp)
        public void UpdatePlayers()
        {
            var pitcher = _context.LastThreeGamesPitchers.OrderByDescending(p => p.AvgResults).Take(20).DistinctBy(p => p.PlayerID);
            var catcher = _context.LastTenGamesPosPlayers.Where(p => p.Position == "C").OrderByDescending(p => p.AvgResults).Take(5).DistinctBy(p => p.PlayerID);
            var firstBase = _context.LastTenGamesPosPlayers.Where(p => p.Position == "1B").OrderByDescending(p => p.AvgResults).Take(5).DistinctBy(p => p.PlayerID);
            var secondBase = _context.LastTenGamesPosPlayers.Where(p => p.Position == "2B").OrderByDescending(p => p.AvgResults).Take(5).DistinctBy(p => p.PlayerID);
            var thirdBase = _context.LastTenGamesPosPlayers.Where(p => p.Position == "3B").OrderByDescending(p => p.AvgResults).Take(5).DistinctBy(p => p.PlayerID);
            var shortstop = _context.LastTenGamesPosPlayers.Where(p => p.Position == "SS").OrderByDescending(p => p.AvgResults).Take(5).DistinctBy(p => p.PlayerID);
            var outfield = _context.LastTenGamesPosPlayers.Where(p => p.Position == "OF").OrderByDescending(p => p.AvgResults).Take(15).DistinctBy(p => p.PlayerID);

            var awayPitchers = _context.Pitchers.OrderByDescending(p => p.AwayTotalScore).Take(20);
            var awayCatchers = _context.PositionPlayers.Where(p => p.Position == "C").OrderByDescending(p => p.AwayTotalScore).Take(5).DistinctBy(p => p.PlayerID);
            var awayFirstBasemen = _context.PositionPlayers.Where(p => p.Position == "1B").OrderByDescending(p => p.AwayTotalScore).Take(5).DistinctBy(p => p.PlayerID);
            var awaySecondBasemen = _context.PositionPlayers.Where(p => p.Position == "2B").OrderByDescending(p => p.AwayTotalScore).Take(5).DistinctBy(p => p.PlayerID);
            var awayThirdBasemen = _context.PositionPlayers.Where(p => p.Position == "3B").OrderByDescending(p => p.AwayTotalScore).Take(5).DistinctBy(p => p.PlayerID);
            var awayShortstops = _context.PositionPlayers.Where(p => p.Position == "SS").OrderByDescending(p => p.AwayTotalScore).Take(5).DistinctBy(p => p.PlayerID);
            var awayOutfielders = _context.PositionPlayers.Where(p => p.Position == "OF").OrderByDescending(p => p.AwayTotalScore).Take(10).DistinctBy(p => p.PlayerID);

            var homePitchers = _context.Pitchers.OrderByDescending(p => p.HomeTotalScore).Take(20).DistinctBy(p => p.PlayerID);
            var homeCatchers = _context.PositionPlayers.Where(p => p.Position == "C").OrderByDescending(p => p.HomeTotalScore).Take(5).DistinctBy(p => p.PlayerID);
            var homeFirstBasemen = _context.PositionPlayers.Where(p => p.Position == "1B").OrderByDescending(p => p.HomeTotalScore).Take(5).DistinctBy(p => p.PlayerID);
            var homeSecondBasemen = _context.PositionPlayers.Where(p => p.Position == "2B").OrderByDescending(p => p.HomeTotalScore).Take(5).DistinctBy(p => p.PlayerID);
            var homeThirdBasemen = _context.PositionPlayers.Where(p => p.Position == "3B").OrderByDescending(p => p.HomeTotalScore).Take(5).DistinctBy(p => p.PlayerID);
            var homeShortstops = _context.PositionPlayers.Where(p => p.Position == "SS").OrderByDescending(p => p.HomeTotalScore).Take(5).DistinctBy(p => p.PlayerID);
            var homeOutfielders = _context.PositionPlayers.Where(p => p.Position == "OF").OrderByDescending(p => p.HomeTotalScore).Take(15).DistinctBy(p => p.PlayerID);

            var lhpCatchers = _context.PositionPlayers.Where(p => p.Position == "C").OrderByDescending(p => p.VsLhpTotalScore).Take(5).DistinctBy(p => p.PlayerID);
            var lhpFirstBasemen = _context.PositionPlayers.Where(p => p.Position == "1B").OrderByDescending(p => p.VsLhpTotalScore).Take(5).DistinctBy(p => p.PlayerID);
            var lhpSecondBasemen = _context.PositionPlayers.Where(p => p.Position == "2B").OrderByDescending(p => p.VsLhpTotalScore).Take(5).DistinctBy(p => p.PlayerID);
            var lhpThirdBasemen = _context.PositionPlayers.Where(p => p.Position == "3B").OrderByDescending(p => p.VsLhpTotalScore).Take(5).DistinctBy(p => p.PlayerID);
            var lhpShortstops = _context.PositionPlayers.Where(p => p.Position == "SS").OrderByDescending(p => p.VsLhpTotalScore).Take(5).DistinctBy(p => p.PlayerID);
            var lhpOutfielders = _context.PositionPlayers.Where(p => p.Position == "OF").OrderByDescending(p => p.VsLhpTotalScore).Take(15).DistinctBy(p => p.PlayerID);

            var rhpCatchers = _context.PositionPlayers.Where(p => p.Position == "C").OrderByDescending(p => p.VsRhpTotalScore).Take(5).DistinctBy(p => p.PlayerID);
            var rhpFirstBasemen = _context.PositionPlayers.Where(p => p.Position == "1B").OrderByDescending(p => p.VsRhpTotalScore).Take(5).DistinctBy(p => p.PlayerID);
            var rhpSecondBasemen = _context.PositionPlayers.Where(p => p.Position == "2B").OrderByDescending(p => p.VsRhpTotalScore).Take(5).DistinctBy(p => p.PlayerID);
            var rhpThirdBasemen = _context.PositionPlayers.Where(p => p.Position == "3B").OrderByDescending(p => p.VsRhpTotalScore).Take(5).DistinctBy(p => p.PlayerID);
            var rhpShortstops = _context.PositionPlayers.Where(p => p.Position == "SS").OrderByDescending(p => p.VsRhpTotalScore).Take(5).DistinctBy(p => p.PlayerID);
            var rhpOutfielders = _context.PositionPlayers.Where(p => p.Position == "OF").OrderByDescending(p => p.VsRhpTotalScore).Take(15).DistinctBy(p => p.PlayerID);


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

            foreach (var newCatcher in catcher)
            {
                ProjectedCatcher projectedCatcher = new ProjectedCatcher()
                {
                    PlayerID = newCatcher.PlayerID,
                    Name = newCatcher.FirstName + " " + newCatcher.LastName,
                    ProjectedScore = newCatcher.AvgResults
                };
                var existingCatcher = _context.ProjectedCatchers.Any(p => p.PlayerID == newCatcher.PlayerID);

                if (!existingCatcher)
                {
                    _context.ProjectedCatchers.Add(projectedCatcher);
                }
            }

            foreach (var newFirstBaseman in firstBase)
            {
                ProjectedFirstBaseman projectedFirstBaseman = new ProjectedFirstBaseman()
                {
                    PlayerID = newFirstBaseman.PlayerID,
                    Name = newFirstBaseman.FirstName + " " + newFirstBaseman.LastName,
                    ProjectedScore = newFirstBaseman.AvgResults
                };
                var existingFirstBaseman = _context.ProjectedFirstBasemen.Any(p => p.PlayerID == newFirstBaseman.PlayerID);

                if (!existingFirstBaseman)
                {
                    _context.ProjectedFirstBasemen.Add(projectedFirstBaseman);
                }
            }

            foreach (var newSecondBaseman in secondBase)
            {
                ProjectedSecondBaseman projectedSecondBaseman = new ProjectedSecondBaseman()
                {
                    PlayerID = newSecondBaseman.PlayerID,
                    Name = newSecondBaseman.FirstName + " " + newSecondBaseman.LastName,
                    ProjectedScore = newSecondBaseman.AvgResults
                };

                var existingSecondBaseman = _context.ProjectedSecondBasemen.Any(p => p.PlayerID == newSecondBaseman.PlayerID);

                if (!existingSecondBaseman)
                {
                    _context.ProjectedSecondBasemen.Add(projectedSecondBaseman);
                }
            }

            foreach (var newThirdBaseman in thirdBase)
            {
                ProjectedThirdBaseman projectedThirdBaseman = new ProjectedThirdBaseman()
                {
                    PlayerID = newThirdBaseman.PlayerID,
                    Name = newThirdBaseman.FirstName + " " + newThirdBaseman.LastName,
                    ProjectedScore = newThirdBaseman.AvgResults
                };
                var existingThirdBaseman = _context.ProjectedThirdBasemen.Any(p => p.PlayerID == newThirdBaseman.PlayerID);

                if (!existingThirdBaseman)
                {
                    _context.ProjectedThirdBasemen.Add(projectedThirdBaseman);
                }
            }

            foreach (var newShortstop in shortstop)
            {
                ProjectedShortstop projectedShortstop = new ProjectedShortstop()
                {
                    PlayerID = newShortstop.PlayerID,
                    Name = newShortstop.FirstName + " " + newShortstop.LastName,
                    ProjectedScore = newShortstop.AvgResults
                };
                var existingShortstop = _context.ProjectedShortstops.Any(p => p.PlayerID == newShortstop.PlayerID);

                if (!existingShortstop)
                {
                    _context.ProjectedShortstops.Add(projectedShortstop);
                }
            }

            foreach (var newOutfielder in outfield)
            {
                ProjectedOutfielder projectedOutfielder = new ProjectedOutfielder()
                {
                    PlayerID = newOutfielder.PlayerID,
                    Name = newOutfielder.FirstName + " " + newOutfielder.LastName,
                    ProjectedScore = newOutfielder.AvgResults
                };
                var existingOutfielder = _context.ProjectedOutfielders.Any(p => p.PlayerID == newOutfielder.PlayerID);

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
                    TotalScore = awayPitcher.AwayTotalScore
                };

                var existingPitcher = _context.AwayPitchers.Any(p => p.PlayerID == awayPitcher.PlayerID);

                if (!existingPitcher)
                {
                    _context.AwayPitchers.Add(newAwayPitcher);
                }
            }

            foreach (var awayCatcher in awayCatchers)
            {
                AwayCatcher newAwayCatcher = new AwayCatcher()
                {
                    PlayerID = awayCatcher.PlayerID,
                    Name = awayCatcher.FirstName + " " + awayCatcher.LastName,
                    TotalScore = awayCatcher.AwayTotalScore
                };

                var existingCatcher = _context.AwayCatchers.Any(p => p.PlayerID == awayCatcher.PlayerID);

                if (!existingCatcher)
                {
                    _context.AwayCatchers.Add(newAwayCatcher);
                }
            }

            foreach (var awayFirstBase in awayFirstBasemen)
            {
                AwayFirstBaseman newAwayFirstBase = new AwayFirstBaseman()
                {
                    PlayerID = awayFirstBase.PlayerID,
                    Name = awayFirstBase.FirstName + " " + awayFirstBase.LastName,
                    TotalScore = awayFirstBase.AwayTotalScore
                };
                var existingFirstBaseman = _context.AwayFirstBasemen.Any(p => p.PlayerID == awayFirstBase.PlayerID);

                if (!existingFirstBaseman)
                {
                    _context.AwayFirstBasemen.Add(newAwayFirstBase);
                }
            }

            foreach (var awaySecondBase in awaySecondBasemen)
            {
                AwaySecondBaseman newAwaySecondBase = new AwaySecondBaseman()
                {
                    PlayerID = awaySecondBase.PlayerID,
                    Name = awaySecondBase.FirstName + " " + awaySecondBase.LastName,
                    TotalScore = awaySecondBase.AwayTotalScore
                };
                var existingSecondBaseman = _context.AwaySecondBasemen.Any(p => p.PlayerID == awaySecondBase.PlayerID);

                if (!existingSecondBaseman)
                {
                    _context.AwaySecondBasemen.Add(newAwaySecondBase);
                }
            }

            foreach (var awayThirdBase in awayThirdBasemen)
            {
                AwayThirdBaseman newAwayThridBase = new AwayThirdBaseman()
                {
                    PlayerID = awayThirdBase.PlayerID,
                    Name = awayThirdBase.FirstName + " " + awayThirdBase.LastName,
                    TotalScore = awayThirdBase.AwayTotalScore
                };
                var existingThirdBaseman = _context.AwayThirdBasemen.Any(p => p.PlayerID == awayThirdBase.PlayerID);

                if (!existingThirdBaseman)
                {
                    _context.AwayThirdBasemen.Add(newAwayThridBase);
                }              
            }

            foreach (var awayShortstop in awayShortstops)
            {
                AwayShortstop newAwayShortstop = new AwayShortstop()
                {
                    PlayerID = awayShortstop.PlayerID,
                    Name = awayShortstop.FirstName + " " + awayShortstop.LastName,
                    TotalScore = awayShortstop.AwayTotalScore
                };
                var existingShortstop = _context.AwayShortstops.Any(p => p.PlayerID == awayShortstop.PlayerID);

                if (!existingShortstop)
                {
                    _context.AwayShortstops.Add(newAwayShortstop);
                }
            }

            foreach (var awayOutfielder in awayOutfielders)
            {
                AwayOutfielder newAwayOutfielder = new AwayOutfielder()
                {
                    PlayerID = awayOutfielder.PlayerID,
                    Name = awayOutfielder.FirstName + " " + awayOutfielder.LastName,
                    TotalScore = awayOutfielder.AwayTotalScore
                };
                var existingOutfielder = _context.AwayOutfielders.Any(p => p.PlayerID == awayOutfielder.PlayerID);

                if (!existingOutfielder)
                {
                    _context.AwayOutfielders.Add(newAwayOutfielder);
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

            foreach (var homeCatcher in homeCatchers)
            {
                HomeCatcher newHomeCatcher = new HomeCatcher()
                {
                    PlayerID = homeCatcher.PlayerID,
                    Name = homeCatcher.FirstName + " " + homeCatcher.LastName,
                    TotalScore = homeCatcher.HomeTotalScore
                };
                var existingCatcher = _context.HomeCatchers.Any(p => p.PlayerID == homeCatcher.PlayerID);

                if (!existingCatcher)
                {
                    _context.HomeCatchers.Add(newHomeCatcher);
                }
            }

            foreach (var homeFirstBase in homeFirstBasemen)
            {
                HomeFirstBaseman newHomeFirstBase = new HomeFirstBaseman()
                {
                    PlayerID = homeFirstBase.PlayerID,
                    Name = homeFirstBase.FirstName + " " + homeFirstBase.LastName,
                    TotalScore = homeFirstBase.HomeTotalScore
                };
                var existingFirstBaseman = _context.HomeFirstBasemen.Any(p => p.PlayerID == homeFirstBase.PlayerID);

                if (!existingFirstBaseman)
                {
                    _context.HomeFirstBasemen.Add(newHomeFirstBase);
                }
            }

            foreach (var homeSecondBase in homeSecondBasemen)
            {
                HomeSecondBaseman newHomeSecondBase = new HomeSecondBaseman()
                {
                    PlayerID = homeSecondBase.PlayerID,
                    Name = homeSecondBase.FirstName + " " + homeSecondBase.LastName,
                    TotalScore = homeSecondBase.HomeTotalScore
                };
                var existingSecondBaseman = _context.HomeSecondBasemen.Any(p => p.PlayerID == homeSecondBase.PlayerID);

                if (!existingSecondBaseman)
                {
                    _context.HomeSecondBasemen.Add(newHomeSecondBase);
                }
            }

            foreach (var homeThirdBase in homeThirdBasemen)
            {
                HomeThirdBaseman newHomeThridBase = new HomeThirdBaseman()
                {
                    PlayerID = homeThirdBase.PlayerID,
                    Name = homeThirdBase.FirstName + " " + homeThirdBase.LastName,
                    TotalScore = homeThirdBase.HomeTotalScore
                };
                var existingThirdBaseman = _context.HomeThirdBasemen.Any(p => p.PlayerID == homeThirdBase.PlayerID);
                
                if (!existingThirdBaseman)
                {
                    _context.HomeThirdBasemen.Add(newHomeThridBase);
                }
            }

            foreach (var homeShortstop in homeShortstops)
            {
                HomeShortstop newHomeShortstop = new HomeShortstop()
                {
                    PlayerID = homeShortstop.PlayerID,
                    Name = homeShortstop.FirstName + " " + homeShortstop.LastName,
                    TotalScore = homeShortstop.HomeTotalScore
                };
                var existingShortstop = _context.HomeShortstops.Any(p => p.PlayerID == homeShortstop.PlayerID);

                if (!existingShortstop)
                {
                    _context.HomeShortstops.Add(newHomeShortstop);
                }
            }

            foreach (var homeOutfielder in homeOutfielders)
            {
                HomeOutfielder newHomeOutfielder = new HomeOutfielder()
                {
                    PlayerID = homeOutfielder.PlayerID,
                    Name = homeOutfielder.FirstName + " " + homeOutfielder.LastName,
                    TotalScore = homeOutfielder.HomeTotalScore
                };
                var existingOutfielder = _context.HomeOutfielders.Any(p => p.PlayerID == homeOutfielder.PlayerID);

                if (!existingOutfielder)
                {
                    _context.HomeOutfielders.Add(newHomeOutfielder);
                }
            }

            foreach (var rhpCatcher in rhpCatchers)
            {
                RhpCatcher newRhpCatcher = new RhpCatcher()
                {
                    PlayerID = rhpCatcher.PlayerID,
                    Name = rhpCatcher.FirstName + " " + rhpCatcher.LastName,
                    TotalScore = rhpCatcher.VsRhpTotalScore
                };

                var existingCatcher = _context.RhpCatchers.Any(p => p.PlayerID == rhpCatcher.PlayerID);

                if (!existingCatcher)
                {
                    _context.RhpCatchers.Add(newRhpCatcher);
                }
            }

            foreach (var rhpFirstBase in rhpFirstBasemen)
            {
                RhpFirstBaseman newRhpFirstBase = new RhpFirstBaseman()
                {
                    PlayerID = rhpFirstBase.PlayerID,
                    Name = rhpFirstBase.FirstName + " " + rhpFirstBase.LastName,
                    TotalScore = rhpFirstBase.VsRhpTotalScore
                };
                var existingFirstBase = _context.RhpFirstBasemen.Any(p => p.PlayerID == rhpFirstBase.PlayerID);

                if (!existingFirstBase)
                {
                    _context.RhpFirstBasemen.Add(newRhpFirstBase);
                }
            }

            foreach (var rhpSecondBase in rhpSecondBasemen)
            {
                RhpSecondBaseman newRhpSecondBase = new RhpSecondBaseman()
                {
                    PlayerID = rhpSecondBase.PlayerID,
                    Name = rhpSecondBase.FirstName + " " + rhpSecondBase.LastName,
                    TotalScore = rhpSecondBase.VsRhpTotalScore
                };
                var existingSecondBaseman = _context.RhpSecondBasemen.Any(p => p.PlayerID == rhpSecondBase.PlayerID);

                if (!existingSecondBaseman)
                {
                    _context.RhpSecondBasemen.Add(newRhpSecondBase);
                }
            }

            foreach (var rhpThirdBase in rhpThirdBasemen)
            {
                RhpThirdBaseman newRhpThridBase = new RhpThirdBaseman()
                {
                    PlayerID = rhpThirdBase.PlayerID,
                    Name = rhpThirdBase.FirstName + " " + rhpThirdBase.LastName,
                    TotalScore = rhpThirdBase.VsRhpTotalScore
                };
                var existingThirdBaseman = _context.RhpThirdBasemen.Any(p => p.PlayerID == rhpThirdBase.PlayerID);

                if (!existingThirdBaseman)
                {
                    _context.RhpThirdBasemen.Add(newRhpThridBase);
                }
            }

            foreach (var rhpShortstop in rhpShortstops)
            {
                RhpShortstop newRhpShortstop = new RhpShortstop()
                {
                    PlayerID = rhpShortstop.PlayerID,
                    Name = rhpShortstop.FirstName + " " + rhpShortstop.LastName,
                    TotalScore = rhpShortstop.VsRhpTotalScore
                };
                var existingShortstop = _context.RhpShortstops.Any(p => p.PlayerID == rhpShortstop.PlayerID);

                if (!existingShortstop)
                {
                    _context.RhpShortstops.Add(newRhpShortstop);
                }
            }

            foreach (var rhpOutfielder in rhpOutfielders)
            {
                RhpOutfielder newRhpOutfielder = new RhpOutfielder()
                {
                    PlayerID = rhpOutfielder.PlayerID,
                    Name = rhpOutfielder.FirstName + " " + rhpOutfielder.LastName,
                    TotalScore = rhpOutfielder.VsRhpTotalScore
                };
                var existingOutfielder = _context.RhpOutfielders.Any(p => p.PlayerID == rhpOutfielder.PlayerID);

                if (!existingOutfielder)
                {
                    _context.RhpOutfielders.Add(newRhpOutfielder);
                }
            }

            foreach (var lhpCatcher in lhpCatchers)
            {
                LhpCatcher newLhpCatcher = new LhpCatcher()
                {
                    PlayerID = lhpCatcher.PlayerID,
                    Name = lhpCatcher.FirstName + " " + lhpCatcher.LastName,
                    TotalScore = lhpCatcher.VsLhpTotalScore
                };
                var existingCatcher = _context.LhpCatchers.Any(p => p.PlayerID == lhpCatcher.PlayerID);

                if (!existingCatcher)
                {
                    _context.LhpCatchers.Add(newLhpCatcher);
                }
            }

            foreach (var lhpFirstBase in lhpFirstBasemen)
            {
                LhpFirstBaseman newLhpFirstBase = new LhpFirstBaseman()
                {
                    PlayerID = lhpFirstBase.PlayerID,
                    Name = lhpFirstBase.FirstName + " " + lhpFirstBase.LastName,
                    TotalScore = lhpFirstBase.VsLhpTotalScore
                };
                var existingFirstBase = _context.LhpFirstBasemen.Any(p => p.PlayerID == lhpFirstBase.PlayerID);

                if (!existingFirstBase)
                {
                    _context.LhpFirstBasemen.Add(newLhpFirstBase);
                }
            }

            foreach (var lhpSecondBase in lhpSecondBasemen)
            {
                LhpSecondBaseman newLhpSecondBase = new LhpSecondBaseman()
                {
                    PlayerID = lhpSecondBase.PlayerID,
                    Name = lhpSecondBase.FirstName + " " + lhpSecondBase.LastName,
                    TotalScore = lhpSecondBase.VsLhpTotalScore
                };
                var existingSecondBase = _context.LhpSecondBasemen.Any(p => p.PlayerID == lhpSecondBase.PlayerID);

                if (!existingSecondBase)
                {
                    _context.LhpSecondBasemen.Add(newLhpSecondBase);
                }
            }

            foreach (var lhpThirdBase in lhpThirdBasemen)
            {
                LhpThirdBaseman newLhpThridBase = new LhpThirdBaseman()
                {
                    PlayerID = lhpThirdBase.PlayerID,
                    Name = lhpThirdBase.FirstName + " " + lhpThirdBase.LastName,
                    TotalScore = lhpThirdBase.VsLhpTotalScore
                };
                var existingThirdBase = _context.LhpThirdBasemen.Any(p => p.PlayerID == lhpThirdBase.PlayerID);

                if (!existingThirdBase)
                {
                    _context.LhpThirdBasemen.Add(newLhpThridBase);
                }
            }

            foreach (var lhpShortstop in lhpShortstops)
            {
                LhpShortstop newLhpShortstop = new LhpShortstop()
                {
                    PlayerID = lhpShortstop.PlayerID,
                    Name = lhpShortstop.FirstName + " " + lhpShortstop.LastName,
                    TotalScore = lhpShortstop.VsLhpTotalScore
                };
                var existingShortstop = _context.LhpShortstops.Any(p => p.PlayerID == lhpShortstop.PlayerID);

                if (!existingShortstop)
                {
                    _context.LhpShortstops.Add(newLhpShortstop);
                }
            }

            foreach (var lhpOutfielder in lhpOutfielders)
            {
                LhpOutfielder newLhpOutfielder = new LhpOutfielder()
                {
                    PlayerID = lhpOutfielder.PlayerID,
                    Name = lhpOutfielder.FirstName + " " + lhpOutfielder.LastName,
                    TotalScore = lhpOutfielder.VsLhpTotalScore
                };
                var existingOutfielder = _context.LhpOutfielders.Any(p => p.PlayerID == lhpOutfielder.PlayerID);

                if (!existingOutfielder)
                {
                    _context.LhpOutfielders.Add(newLhpOutfielder);
                }
            }


            _context.SaveChanges();
        }

    }
}
