using Microsoft.EntityFrameworkCore;

namespace Database.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<MapPositioning> MapPositionings { get; set; }
        DbSet<MedievalBattle> MedievalBattles { get; set; }
        DbSet<MedievalBattleStats> MedievalBattleStats { get; set; }
        DbSet<Player> Players { get; set; }
        DbSet<Position> Positions { get; set; }
        public DbSet<SessionMedievalBattle> SessionMedievalBattles { get; set; }
        DbSet<Unit> Units { get; set; }
        DbSet<UnitClasses> UnitClasses { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<UserStatistics> UserStatistics { get; set; }
        public DbSet<UsersSessionsMedievalBattle> UsersSessionsMedievalBattle { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=25.98.56.253;Database=MGP;MultipleActiveResultSets=true;User ID=sa;Password=OKTyaBRSkOE123;");
            }
        }
    }
}