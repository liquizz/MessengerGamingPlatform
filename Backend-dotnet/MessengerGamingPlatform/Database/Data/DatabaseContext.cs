using Microsoft.EntityFrameworkCore;

namespace Database.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<MapPositioning> MapPositionings { get; set; }
        DbSet<MedievalBattle> MedievalBattles { get; set; }
        DbSet<MedievalBattleStats> MedievalBattleStats { get; set; }
        DbSet<Player> Players { get; set; }
        DbSet<Position> Positions { get; set; }
        DbSet<SessionMedievalBattle> SessionMedievalBattles { get; set; }
        DbSet<Unit> Units { get; set; }
        DbSet<UnitClasses> UnitClasses { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<UserStatistics> UserStatistics { get; set; }
    }
}