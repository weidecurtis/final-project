using Microsoft.EntityFrameworkCore;
using LCFinalProject.Models;

namespace LCFinalProject.Data
{
    public class BeatTheShiftDbContext : DbContext
    {
        public DbSet<GameStat> GameStats { get; set; }
        public DbSet<Pitcher> Pitchers { get; set; }
        public DbSet<Game> Games { get; set; }

        public DbSet<PitcherGameStat> PitcherGameStats { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Batter> Batters { get; set; }
        public DbSet<HitData> HitDatas { get; set; }
        public DbSet<PitchData> PitchDatas { get; set; }


        public BeatTheShiftDbContext(DbContextOptions<BeatTheShiftDbContext> options) : base(options) { }
    }
}
