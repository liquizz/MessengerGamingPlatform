using Microsoft.EntityFrameworkCore.Migrations;

namespace Component.Web.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedievalBattleStats",
                columns: table => new
                {
                    MedievalBattleStatsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedievalBattleStats", x => x.MedievalBattleStatsId);
                });

            migrationBuilder.CreateTable(
                name: "SessionMedievalBattles",
                columns: table => new
                {
                    SessionMedievalBattleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionMedievalBattles", x => x.SessionMedievalBattleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    Telegram = table.Column<string>(nullable: true),
                    Discord = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "MedievalBattles",
                columns: table => new
                {
                    MedievalBatlleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionMedievalBattleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedievalBattles", x => x.MedievalBatlleId);
                    table.ForeignKey(
                        name: "FK_MedievalBattles_SessionMedievalBattles_SessionMedievalBattleId",
                        column: x => x.SessionMedievalBattleId,
                        principalTable: "SessionMedievalBattles",
                        principalColumn: "SessionMedievalBattleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersSessionsMedievalBattle",
                columns: table => new
                {
                    UsersSessionsMedievalBattleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    SessionMedievalBattleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersSessionsMedievalBattle", x => x.UsersSessionsMedievalBattleId);
                    table.ForeignKey(
                        name: "FK_UsersSessionsMedievalBattle_SessionMedievalBattles_SessionMedievalBattleId",
                        column: x => x.SessionMedievalBattleId,
                        principalTable: "SessionMedievalBattles",
                        principalColumn: "SessionMedievalBattleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersSessionsMedievalBattle_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserStatistics",
                columns: table => new
                {
                    UserStatisticsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStatistics", x => x.UserStatisticsId);
                    table.ForeignKey(
                        name: "FK_UserStatistics_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedievalBattleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Players_MedievalBattles_MedievalBattleId",
                        column: x => x.MedievalBattleId,
                        principalTable: "MedievalBattles",
                        principalColumn: "MedievalBatlleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MapPositionings",
                columns: table => new
                {
                    MapPositioningId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapPositionings", x => x.MapPositioningId);
                    table.ForeignKey(
                        name: "FK_MapPositionings_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    PositionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PositionNumber = table.Column<int>(nullable: false),
                    MapPositioningId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.PositionId);
                    table.ForeignKey(
                        name: "FK_Positions_MapPositionings_MapPositioningId",
                        column: x => x.MapPositioningId,
                        principalTable: "MapPositionings",
                        principalColumn: "MapPositioningId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    UnitId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitCustomName = table.Column<string>(nullable: true),
                    UnitCurrentHP = table.Column<int>(nullable: false),
                    UnitCurrentDP = table.Column<int>(nullable: false),
                    MapPositioningId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.UnitId);
                    table.ForeignKey(
                        name: "FK_Units_MapPositionings_MapPositioningId",
                        column: x => x.MapPositioningId,
                        principalTable: "MapPositionings",
                        principalColumn: "MapPositioningId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnitClasses",
                columns: table => new
                {
                    UnitClassesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(nullable: true),
                    HealPoints = table.Column<int>(nullable: false),
                    DefencePoints = table.Column<int>(nullable: false),
                    AttackRange = table.Column<float>(nullable: false),
                    AttackCooldown = table.Column<float>(nullable: false),
                    UnitId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitClasses", x => x.UnitClassesId);
                    table.ForeignKey(
                        name: "FK_UnitClasses_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MapPositionings_PlayerId",
                table: "MapPositionings",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_MedievalBattles_SessionMedievalBattleId",
                table: "MedievalBattles",
                column: "SessionMedievalBattleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_MedievalBattleId",
                table: "Players",
                column: "MedievalBattleId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_MapPositioningId",
                table: "Positions",
                column: "MapPositioningId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UnitClasses_UnitId",
                table: "UnitClasses",
                column: "UnitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Units_MapPositioningId",
                table: "Units",
                column: "MapPositioningId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsersSessionsMedievalBattle_SessionMedievalBattleId",
                table: "UsersSessionsMedievalBattle",
                column: "SessionMedievalBattleId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersSessionsMedievalBattle_UserId",
                table: "UsersSessionsMedievalBattle",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserStatistics_UserId",
                table: "UserStatistics",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedievalBattleStats");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "UnitClasses");

            migrationBuilder.DropTable(
                name: "UsersSessionsMedievalBattle");

            migrationBuilder.DropTable(
                name: "UserStatistics");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "MapPositionings");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "MedievalBattles");

            migrationBuilder.DropTable(
                name: "SessionMedievalBattles");
        }
    }
}
