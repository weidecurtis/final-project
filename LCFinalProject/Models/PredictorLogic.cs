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
                int totalHBP = 0;

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
                    LastTenGamesPosPlayer newPlayer = new LastTenGamesPosPlayer()
                    {
                        FirstName = player.FirstName,
                        LastName = player.LastName,
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
                }
            }

        }
    }
}
