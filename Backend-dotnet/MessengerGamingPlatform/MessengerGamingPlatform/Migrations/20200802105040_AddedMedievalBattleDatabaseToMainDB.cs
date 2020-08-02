using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class AddedMedievalBattleDatabaseToMainDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MapPositionings_Players_PlayerId",
                table: "MapPositionings");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_MapPositionings_MapPositioningId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Units_MapPositionings_MapPositioningId",
                table: "Units");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Positions",
                table: "Positions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MapPositionings",
                table: "MapPositionings");

            migrationBuilder.RenameTable(
                name: "Positions",
                newName: "Position");

            migrationBuilder.RenameTable(
                name: "MapPositionings",
                newName: "MapPositioning");

            migrationBuilder.RenameIndex(
                name: "IX_Positions_MapPositioningId",
                table: "Position",
                newName: "IX_Position_MapPositioningId");

            migrationBuilder.RenameIndex(
                name: "IX_MapPositionings_PlayerId",
                table: "MapPositioning",
                newName: "IX_MapPositioning_PlayerId");

            migrationBuilder.AddColumn<int>(
                name: "abstractFieldId",
                table: "MedievalBattles",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Position",
                table: "Position",
                column: "PositionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MapPositioning",
                table: "MapPositioning",
                column: "MapPositioningId");

            migrationBuilder.CreateTable(
                name: "GameControllers",
                columns: table => new
                {
                    gameControllerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionMedievalBattleId = table.Column<int>(nullable: true),
                    gameAvaliable = table.Column<bool>(nullable: false),
                    defeatTeam = table.Column<int>(nullable: false),
                    currentTurn = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameControllers", x => x.gameControllerId);
                    table.ForeignKey(
                        name: "FK_GameControllers_SessionMedievalBattles_SessionMedievalBattleId",
                        column: x => x.SessionMedievalBattleId,
                        principalTable: "SessionMedievalBattles",
                        principalColumn: "SessionMedievalBattleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LocalStatistic",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    unitAliveCount = table.Column<int>(nullable: false),
                    unitDeadCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalStatistic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "aliveFieldsCount",
                columns: table => new
                {
                    aliveFieldId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fieldIndex = table.Column<int>(nullable: false),
                    gameControllerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aliveFieldsCount", x => x.aliveFieldId);
                    table.ForeignKey(
                        name: "FK_aliveFieldsCount_GameControllers_gameControllerId",
                        column: x => x.gameControllerId,
                        principalTable: "GameControllers",
                        principalColumn: "gameControllerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Coins",
                columns: table => new
                {
                    coinId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    value = table.Column<int>(nullable: false),
                    gameControllerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coins", x => x.coinId);
                    table.ForeignKey(
                        name: "FK_Coins_GameControllers_gameControllerId",
                        column: x => x.gameControllerId,
                        principalTable: "GameControllers",
                        principalColumn: "gameControllerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AbstractFields",
                columns: table => new
                {
                    abstractFieldId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    teamId = table.Column<int>(nullable: false),
                    positionId = table.Column<int>(nullable: false),
                    fieldSize = table.Column<int>(nullable: false),
                    fieldHp = table.Column<int>(nullable: false),
                    fieldDamage = table.Column<int>(nullable: false),
                    fieldArmor = table.Column<int>(nullable: false),
                    fieldUnitCount = table.Column<int>(nullable: false),
                    hpPerUnit = table.Column<int>(nullable: false),
                    damagePerUnit = table.Column<int>(nullable: false),
                    unitCost = table.Column<int>(nullable: false),
                    LocalStatisticId = table.Column<int>(nullable: true),
                    gameControllerId = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    abstractFieldId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbstractFields", x => x.abstractFieldId);
                    table.ForeignKey(
                        name: "FK_AbstractFields_LocalStatistic_LocalStatisticId",
                        column: x => x.LocalStatisticId,
                        principalTable: "LocalStatistic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AbstractFields_AbstractFields_abstractFieldId1",
                        column: x => x.abstractFieldId1,
                        principalTable: "AbstractFields",
                        principalColumn: "abstractFieldId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AbstractFields_GameControllers_gameControllerId",
                        column: x => x.gameControllerId,
                        principalTable: "GameControllers",
                        principalColumn: "gameControllerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    unitId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hp = table.Column<int>(nullable: false),
                    damage = table.Column<int>(nullable: false),
                    armor = table.Column<int>(nullable: false),
                    armorDurability = table.Column<int>(nullable: false),
                    parentObjectabstractFieldId = table.Column<int>(nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_MedievalBattles_abstractFieldId",
                table: "MedievalBattles",
                column: "abstractFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_AbstractFields_LocalStatisticId",
                table: "AbstractFields",
                column: "LocalStatisticId");

            migrationBuilder.CreateIndex(
                name: "IX_AbstractFields_abstractFieldId1",
                table: "AbstractFields",
                column: "abstractFieldId1");

            migrationBuilder.CreateIndex(
                name: "IX_AbstractFields_gameControllerId",
                table: "AbstractFields",
                column: "gameControllerId");

            migrationBuilder.CreateIndex(
                name: "IX_aliveFieldsCount_gameControllerId",
                table: "aliveFieldsCount",
                column: "gameControllerId");

            migrationBuilder.CreateIndex(
                name: "IX_Coins_gameControllerId",
                table: "Coins",
                column: "gameControllerId");

            migrationBuilder.CreateIndex(
                name: "IX_GameControllers_SessionMedievalBattleId",
                table: "GameControllers",
                column: "SessionMedievalBattleId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_parentObjectabstractFieldId",
                table: "Unit",
                column: "parentObjectabstractFieldId");

            migrationBuilder.AddForeignKey(
                name: "FK_MapPositioning_Players_PlayerId",
                table: "MapPositioning",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedievalBattles_AbstractFields_abstractFieldId",
                table: "MedievalBattles",
                column: "abstractFieldId",
                principalTable: "AbstractFields",
                principalColumn: "abstractFieldId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Position_MapPositioning_MapPositioningId",
                table: "Position",
                column: "MapPositioningId",
                principalTable: "MapPositioning",
                principalColumn: "MapPositioningId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Units_MapPositioning_MapPositioningId",
                table: "Units",
                column: "MapPositioningId",
                principalTable: "MapPositioning",
                principalColumn: "MapPositioningId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MapPositioning_Players_PlayerId",
                table: "MapPositioning");

            migrationBuilder.DropForeignKey(
                name: "FK_MedievalBattles_AbstractFields_abstractFieldId",
                table: "MedievalBattles");

            migrationBuilder.DropForeignKey(
                name: "FK_Position_MapPositioning_MapPositioningId",
                table: "Position");

            migrationBuilder.DropForeignKey(
                name: "FK_Units_MapPositioning_MapPositioningId",
                table: "Units");

            migrationBuilder.DropTable(
                name: "aliveFieldsCount");

            migrationBuilder.DropTable(
                name: "Coins");

            migrationBuilder.DropTable(
                name: "Unit");

            migrationBuilder.DropTable(
                name: "AbstractFields");

            migrationBuilder.DropTable(
                name: "LocalStatistic");

            migrationBuilder.DropTable(
                name: "GameControllers");

            migrationBuilder.DropIndex(
                name: "IX_MedievalBattles_abstractFieldId",
                table: "MedievalBattles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Position",
                table: "Position");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MapPositioning",
                table: "MapPositioning");

            migrationBuilder.DropColumn(
                name: "abstractFieldId",
                table: "MedievalBattles");

            migrationBuilder.RenameTable(
                name: "Position",
                newName: "Positions");

            migrationBuilder.RenameTable(
                name: "MapPositioning",
                newName: "MapPositionings");

            migrationBuilder.RenameIndex(
                name: "IX_Position_MapPositioningId",
                table: "Positions",
                newName: "IX_Positions_MapPositioningId");

            migrationBuilder.RenameIndex(
                name: "IX_MapPositioning_PlayerId",
                table: "MapPositionings",
                newName: "IX_MapPositionings_PlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Positions",
                table: "Positions",
                column: "PositionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MapPositionings",
                table: "MapPositionings",
                column: "MapPositioningId");

            migrationBuilder.AddForeignKey(
                name: "FK_MapPositionings_Players_PlayerId",
                table: "MapPositionings",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_MapPositionings_MapPositioningId",
                table: "Positions",
                column: "MapPositioningId",
                principalTable: "MapPositionings",
                principalColumn: "MapPositioningId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Units_MapPositionings_MapPositioningId",
                table: "Units",
                column: "MapPositioningId",
                principalTable: "MapPositionings",
                principalColumn: "MapPositioningId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
