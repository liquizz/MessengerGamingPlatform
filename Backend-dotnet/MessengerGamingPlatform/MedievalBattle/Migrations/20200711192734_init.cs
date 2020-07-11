using Microsoft.EntityFrameworkCore.Migrations;

namespace MedievalBattle.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameControllers",
                columns: table => new
                {
                    gameControllerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gameAvaliable = table.Column<bool>(nullable: false),
                    defeatTeam = table.Column<int>(nullable: false),
                    currentTurn = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameControllers", x => x.gameControllerId);
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
                    hpPerUnit = table.Column<int>(nullable: false),
                    damagePerUnit = table.Column<int>(nullable: false),
                    unitCost = table.Column<int>(nullable: false),
                    fieldHp = table.Column<int>(nullable: false),
                    fieldDamage = table.Column<int>(nullable: false),
                    fieldArmor = table.Column<int>(nullable: false),
                    fieldCount = table.Column<int>(nullable: false),
                    unitAliveCoun = table.Column<int>(nullable: false),
                    unitDeadCount = table.Column<int>(nullable: false),
                    gameControllerId = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    abstractFieldId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbstractFields", x => x.abstractFieldId);
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
                name: "Units",
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
                    table.PrimaryKey("PK_Units", x => x.unitId);
                    table.ForeignKey(
                        name: "FK_Units_AbstractFields_parentObjectabstractFieldId",
                        column: x => x.parentObjectabstractFieldId,
                        principalTable: "AbstractFields",
                        principalColumn: "abstractFieldId",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_Units_parentObjectabstractFieldId",
                table: "Units",
                column: "parentObjectabstractFieldId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aliveFieldsCount");

            migrationBuilder.DropTable(
                name: "Coins");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "AbstractFields");

            migrationBuilder.DropTable(
                name: "GameControllers");
        }
    }
}
