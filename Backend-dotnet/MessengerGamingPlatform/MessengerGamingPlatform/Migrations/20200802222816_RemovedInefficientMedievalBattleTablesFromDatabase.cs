using Microsoft.EntityFrameworkCore.Migrations;

namespace Component.Web.Migrations
{
    public partial class RemovedInefficientMedievalBattleTablesFromDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Units_MapPositioning_MapPositioningId",
                table: "Units");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Unit");

            migrationBuilder.DropTable(
                name: "UnitClasses");

            migrationBuilder.DropTable(
                name: "MapPositioning");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Units_MapPositioningId",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "MapPositioningId",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "UnitCurrentDP",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "UnitCurrentHP",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "UnitCustomName",
                table: "Units");

            migrationBuilder.RenameColumn(
                name: "UnitId",
                table: "Units",
                newName: "unitId");

            migrationBuilder.AddColumn<int>(
                name: "armor",
                table: "Units",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "armorDurability",
                table: "Units",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "damage",
                table: "Units",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "hp",
                table: "Units",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "parentObjectabstractFieldId",
                table: "Units",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Units_parentObjectabstractFieldId",
                table: "Units",
                column: "parentObjectabstractFieldId");

            migrationBuilder.AddForeignKey(
                name: "FK_Units_AbstractFields_parentObjectabstractFieldId",
                table: "Units",
                column: "parentObjectabstractFieldId",
                principalTable: "AbstractFields",
                principalColumn: "abstractFieldId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Units_AbstractFields_parentObjectabstractFieldId",
                table: "Units");

            migrationBuilder.DropIndex(
                name: "IX_Units_parentObjectabstractFieldId",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "armor",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "armorDurability",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "damage",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "hp",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "parentObjectabstractFieldId",
                table: "Units");

            migrationBuilder.RenameColumn(
                name: "unitId",
                table: "Units",
                newName: "UnitId");

            migrationBuilder.AddColumn<int>(
                name: "MapPositioningId",
                table: "Units",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnitCurrentDP",
                table: "Units",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnitCurrentHP",
                table: "Units",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UnitCustomName",
                table: "Units",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedievalBattleId = table.Column<int>(type: "int", nullable: false)
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
                name: "Unit",
                columns: table => new
                {
                    unitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    armor = table.Column<int>(type: "int", nullable: false),
                    armorDurability = table.Column<int>(type: "int", nullable: false),
                    damage = table.Column<int>(type: "int", nullable: false),
                    hp = table.Column<int>(type: "int", nullable: false),
                    parentObjectabstractFieldId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.unitId);
                    table.ForeignKey(
                        name: "FK_Unit_AbstractFields_parentObjectabstractFieldId",
                        column: x => x.parentObjectabstractFieldId,
                        principalTable: "AbstractFields",
                        principalColumn: "abstractFieldId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnitClasses",
                columns: table => new
                {
                    UnitClassesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttackCooldown = table.Column<float>(type: "real", nullable: false),
                    AttackRange = table.Column<float>(type: "real", nullable: false),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefencePoints = table.Column<int>(type: "int", nullable: false),
                    HealPoints = table.Column<int>(type: "int", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "MapPositioning",
                columns: table => new
                {
                    MapPositioningId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapPositioning", x => x.MapPositioningId);
                    table.ForeignKey(
                        name: "FK_MapPositioning_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    PositionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MapPositioningId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.PositionId);
                    table.ForeignKey(
                        name: "FK_Position_MapPositioning_MapPositioningId",
                        column: x => x.MapPositioningId,
                        principalTable: "MapPositioning",
                        principalColumn: "MapPositioningId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Units_MapPositioningId",
                table: "Units",
                column: "MapPositioningId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MapPositioning_PlayerId",
                table: "MapPositioning",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_MedievalBattleId",
                table: "Players",
                column: "MedievalBattleId");

            migrationBuilder.CreateIndex(
                name: "IX_Position_MapPositioningId",
                table: "Position",
                column: "MapPositioningId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Unit_parentObjectabstractFieldId",
                table: "Unit",
                column: "parentObjectabstractFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitClasses_UnitId",
                table: "UnitClasses",
                column: "UnitId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Units_MapPositioning_MapPositioningId",
                table: "Units",
                column: "MapPositioningId",
                principalTable: "MapPositioning",
                principalColumn: "MapPositioningId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
