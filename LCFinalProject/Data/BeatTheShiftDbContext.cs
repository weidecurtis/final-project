using Microsoft.EntityFrameworkCore;
using LCFinalProject.Models;

namespace LCFinalProject.Data
{
    public class BeatTheShiftDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<PositionPlayer> PositionPlayers { get; set; }
        public DbSet<Pitcher> Pitchers { get; set; }
        public DbSet<YesterdayGame> Games { get; set; }
        public DbSet<IndividualGamePitcher> IndividualGamePitchers { get; set; }
        public DbSet<IndividualGamePosPlayer> IndividualGamePosPlayers { get; set; }
        public DbSet<LastTenGamesPosPlayer> LastTenGamesPosPlayers { get; set; }
        public DbSet<LastThreeGamesPitcher> LastThreeGamesPitchers { get; set; }

        public DbSet<PositionPlayer> AwayCatchers { get; set; }
       
        public DbSet<Team> Teams { get; set; }
        public DbSet<ProjectedTeam> ProjectedTeams { get; set; }
        public DbSet<LastFiveGamesTeam> LastFiveGamesTeams { get; set; }
        public DbSet<TeamGameDate> TeamGameDates { get; set; }
        public DbSet<ProjectedGame> ProjectedGames { get; set; }


        public BeatTheShiftDbContext(DbContextOptions<BeatTheShiftDbContext> options) : base(options) { }
    }
}
