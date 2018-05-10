using Microsoft.EntityFrameworkCore;
using LCFinalProject.Models;

namespace LCFinalProject.Data
{
    public class BeatTheShiftDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<PositionPlayer> PositionPlayers { get; set; }
        public DbSet<Pitcher> Pitchers { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<IndividualGamePitcher> IndividualGamePitchers { get; set; }
        public DbSet<IndividualGamePosPlayer> IndividualGamePosPlayers { get; set; }
        public DbSet<LastTenGamesPosPlayer> LastTenGamesPosPlayers { get; set; }
        public DbSet<LastThreeGamesPitcher> LastThreeGamesPitchers { get; set; }
        public DbSet<ProjectedCatcher> ProjectedCatchers { get; set; }
        public DbSet<ProjectedPitcher> ProjectedPitchers { get; set; }
        public DbSet<ProjectedFirstBaseman> ProjectedFirstBasemen { get; set; }
        public DbSet<ProjectedSecondBaseman> ProjectedSecondBasemen { get; set; }
        public DbSet<ProjectedShortstop> ProjectedShortstops { get; set; }
        public DbSet<ProjectedThirdBaseman> ProjectedThirdBasemen { get; set; }
        public DbSet<ProjectedOutfielder> ProjectedOutfielders { get; set; }
        public DbSet<HomeCatcher> HomeCatchers { get; set; }
        public DbSet<HomePitcher> HomePitchers { get; set; }
        public DbSet<HomeFirstBaseman> HomeFirstBasemen { get; set; }
        public DbSet<HomeSecondBaseman> HomeSecondBasemen { get; set; }
        public DbSet<HomeThirdBaseman> HomeThirdBasemen { get; set; }
        public DbSet<HomeShortstop> HomeShortstops { get; set; }
        public DbSet<HomeOutfielder> HomeOutfielders { get; set; }
        public DbSet<AwayCatcher> AwayCatchers { get; set; }
        public DbSet<AwayPitcher> AwayPitchers { get; set; }
        public DbSet<AwayFirstBaseman> AwayFirstBasemen { get; set; }
        public DbSet<AwaySecondBaseman> AwaySecondBasemen { get; set; }
        public DbSet<AwayThirdBaseman> AwayThirdBasemen { get; set; }
        public DbSet<AwayShortstop> AwayShortstops { get; set; }
        public DbSet<AwayOutfielder> AwayOutfielders { get; set; }
        public DbSet<LhpCatcher> LhpCatchers { get; set; }
        public DbSet<LhpFirstBaseman> LhpFirstBasemen { get; set; }
        public DbSet<LhpSecondBaseman> LhpSecondBasemen { get; set; }
        public DbSet<LhpThirdBaseman> LhpThirdBasemen { get; set; }
        public DbSet<LhpShortstop> LhpShortstops { get; set; }
        public DbSet<LhpOutfielder> LhpOutfielders { get; set; }
        public DbSet<RhpCatcher> RhpCatchers { get; set; }
        public DbSet<RhpFirstBaseman> RhpFirstBasemen { get; set; }
        public DbSet<RhpSecondBaseman> RhpSecondBasemen { get; set; }
        public DbSet<RhpThirdBaseman> RhpThirdBasemen { get; set; }
        public DbSet<RhpShortstop> RhpShortstops { get; set; }
        public DbSet<RhpOutfielder> RhpOutfielders { get; set; }

        public BeatTheShiftDbContext(DbContextOptions<BeatTheShiftDbContext> options) : base(options) { }
    }
}
