using MedievalBattle.Models.Primitives;
using MedievalBattle.Models.UnitClasses;
using Microsoft.EntityFrameworkCore;

namespace MedievalBattle.Models
{
    public class MedievalBattleContext : DbContext
    {
        public MedievalBattleContext()
        {
        }

        public MedievalBattleContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AbstractField> AbstractFields { get; set; }
        public DbSet<GameController> GameControllers { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Archer> Archers { get; set; }
        public DbSet<Fighter> Fighters { get; set; }
        public DbSet<Flank> Flanks { get; set; }
        public DbSet<Coin> Coins { get; set; }
        public DbSet<AliveField> aliveFieldsCount { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=25.98.56.253;Database=MGP_MedievalBattle;MultipleActiveResultSets=true;User ID=sa;Password=OKTyaBRSkOE123;");
            }
        }
    }
}