using Microsoft.EntityFrameworkCore;
using LCFinalProject.Models;

namespace LCFinalProject.Data
{
    public class BeatTheShiftDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<PositionPlayer> PositionPlayers { get; set; }
        public DbSet<Pitcher> Pitchers { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<IndividualGamePitcher> IndividualGamePitchers { get; set; }
        public DbSet<IndividualGamePosPlayer> IndividualGamePosPlayers { get; set; }
        public DbSet<ProjectedTeam> ProjectedTeams { get; set; }
        public DbSet<LastTenGamesPosPlayer> LastTenGamesPosPlayers { get; set; }
        public DbSet<LastThreeGamesPitcher> LastThreeGamesPitchers { get; set; }



        public BeatTheShiftDbContext(DbContextOptions<BeatTheShiftDbContext> options) : base(options) { }
    }
}
