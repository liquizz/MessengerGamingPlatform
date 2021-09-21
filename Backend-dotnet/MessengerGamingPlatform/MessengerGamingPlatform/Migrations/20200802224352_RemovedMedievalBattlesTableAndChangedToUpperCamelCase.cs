using Microsoft.EntityFrameworkCore.Migrations;

namespace Component.Web.Migrations
{
    public partial class RemovedMedievalBattlesTableAndChangedToUpperCamelCase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbstractFields_AbstractFields_abstractFieldId1",
                table: "AbstractFields");

            migrationBuilder.DropForeignKey(
                name: "FK_AbstractFields_GameControllers_gameControllerId",
                table: "AbstractFields");

            migrationBuilder.DropForeignKey(
                name: "FK_aliveFieldsCount_GameControllers_gameControllerId",
                table: "aliveFieldsCount");

            migrationBuilder.DropForeignKey(
                name: "FK_Coins_GameControllers_gameControllerId",
                table: "Coins");

            migrationBuilder.DropForeignKey(
                name: "FK_GameControllers_SessionMedievalBattles_SessionMedievalBattleId",
                table: "GameControllers");

            migrationBuilder.DropForeignKey(
                name: "FK_Units_AbstractFields_parentObjectabstractFieldId",
                table: "Units");

            migrationBuilder.DropTable(
                name: "MedievalBattles");

            migrationBuilder.DropIndex(
                name: "IX_GameControllers_SessionMedievalBattleId",
                table: "GameControllers");

            migrationBuilder.RenameColumn(
                name: "parentObjectabstractFieldId",
                table: "Units",
                newName: "ParentObjectAbstractFieldId");

            migrationBuilder.RenameColumn(
                name: "hp",
                table: "Units",
                newName: "Hp");

            migrationBuilder.RenameColumn(
                name: "damage",
                table: "Units",
                newName: "Damage");

            migrationBuilder.RenameColumn(
                name: "armorDurability",
                table: "Units",
                newName: "ArmorDurability");

            migrationBuilder.RenameColumn(
                name: "armor",
                table: "Units",
                newName: "Armor");

            migrationBuilder.RenameColumn(
                name: "unitId",
                table: "Units",
                newName: "UnitId");

            migrationBuilder.RenameIndex(
                name: "IX_Units_parentObjectabstractFieldId",
                table: "Units",
                newName: "IX_Units_ParentObjectAbstractFieldId");

            migrationBuilder.RenameColumn(
                name: "unitDeadCount",
                table: "LocalStatistic",
                newName: "UnitDeadCount");

            migrationBuilder.RenameColumn(
                name: "unitAliveCount",
                table: "LocalStatistic",
                newName: "UnitAliveCount");

            migrationBuilder.RenameColumn(
                name: "gameAvaliable",
                table: "GameControllers",
                newName: "GameAvaliable");

            migrationBuilder.RenameColumn(
                name: "defeatTeam",
                table: "GameControllers",
                newName: "DefeatTeam");

            migrationBuilder.RenameColumn(
                name: "currentTurn",
                table: "GameControllers",
                newName: "CurrentTurn");

            migrationBuilder.RenameColumn(
                name: "gameControllerId",
                table: "GameControllers",
                newName: "GameControllerId");

            migrationBuilder.RenameColumn(
                name: "value",
                table: "Coins",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "gameControllerId",
                table: "Coins",
                newName: "GameControllerId");

            migrationBuilder.RenameColumn(
                name: "coinId",
                table: "Coins",
                newName: "CoinId");

            migrationBuilder.RenameIndex(
                name: "IX_Coins_gameControllerId",
                table: "Coins",
                newName: "IX_Coins_GameControllerId");

            migrationBuilder.RenameColumn(
                name: "gameControllerId",
                table: "aliveFieldsCount",
                newName: "GameControllerId");

            migrationBuilder.RenameColumn(
                name: "fieldIndex",
                table: "aliveFieldsCount",
                newName: "FieldIndex");

            migrationBuilder.RenameColumn(
                name: "aliveFieldId",
                table: "aliveFieldsCount",
                newName: "AliveFieldId");

            migrationBuilder.RenameIndex(
                name: "IX_aliveFieldsCount_gameControllerId",
                table: "aliveFieldsCount",
                newName: "IX_aliveFieldsCount_GameControllerId");

            migrationBuilder.RenameColumn(
                name: "unitCost",
                table: "AbstractFields",
                newName: "UnitCost");

            migrationBuilder.RenameColumn(
                name: "teamId",
                table: "AbstractFields",
                newName: "TeamId");

            migrationBuilder.RenameColumn(
                name: "positionId",
                table: "AbstractFields",
                newName: "PositionId");

            migrationBuilder.RenameColumn(
                name: "hpPerUnit",
                table: "AbstractFields",
                newName: "HpPerUnit");

            migrationBuilder.RenameColumn(
                name: "gameControllerId",
                table: "AbstractFields",
                newName: "GameControllerId");

            migrationBuilder.RenameColumn(
                name: "fieldUnitCount",
                table: "AbstractFields",
                newName: "FieldUnitCount");

            migrationBuilder.RenameColumn(
                name: "fieldSize",
                table: "AbstractFields",
                newName: "FieldSize");

            migrationBuilder.RenameColumn(
                name: "fieldHp",
                table: "AbstractFields",
                newName: "FieldHp");

            migrationBuilder.RenameColumn(
                name: "fieldDamage",
                table: "AbstractFields",
                newName: "FieldDamage");

            migrationBuilder.RenameColumn(
                name: "fieldArmor",
                table: "AbstractFields",
                newName: "FieldArmor");

            migrationBuilder.RenameColumn(
                name: "damagePerUnit",
                table: "AbstractFields",
                newName: "DamagePerUnit");

            migrationBuilder.RenameColumn(
                name: "abstractFieldId1",
                table: "AbstractFields",
                newName: "AbstractFieldId1");

            migrationBuilder.RenameColumn(
                name: "abstractFieldId",
                table: "AbstractFields",
                newName: "AbstractFieldId");

            migrationBuilder.RenameIndex(
                name: "IX_AbstractFields_gameControllerId",
                table: "AbstractFields",
                newName: "IX_AbstractFields_GameControllerId");

            migrationBuilder.RenameIndex(
                name: "IX_AbstractFields_abstractFieldId1",
                table: "AbstractFields",
                newName: "IX_AbstractFields_AbstractFieldId1");

            migrationBuilder.AlterColumn<int>(
                name: "SessionMedievalBattleId",
                table: "GameControllers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GameControllers_SessionMedievalBattleId",
                table: "GameControllers",
                column: "SessionMedievalBattleId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AbstractFields_AbstractFields_AbstractFieldId1",
                table: "AbstractFields",
                column: "AbstractFieldId1",
                principalTable: "AbstractFields",
                principalColumn: "AbstractFieldId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbstractFields_GameControllers_GameControllerId",
                table: "AbstractFields",
                column: "GameControllerId",
                principalTable: "GameControllers",
                principalColumn: "GameControllerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_aliveFieldsCount_GameControllers_GameControllerId",
                table: "aliveFieldsCount",
                column: "GameControllerId",
                principalTable: "GameControllers",
                principalColumn: "GameControllerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Coins_GameControllers_GameControllerId",
                table: "Coins",
                column: "GameControllerId",
                principalTable: "GameControllers",
                principalColumn: "GameControllerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GameControllers_SessionMedievalBattles_SessionMedievalBattleId",
                table: "GameControllers",
                column: "SessionMedievalBattleId",
                principalTable: "SessionMedievalBattles",
                principalColumn: "SessionMedievalBattleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Units_AbstractFields_ParentObjectAbstractFieldId",
                table: "Units",
                column: "ParentObjectAbstractFieldId",
                principalTable: "AbstractFields",
                principalColumn: "AbstractFieldId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbstractFields_AbstractFields_AbstractFieldId1",
                table: "AbstractFields");

            migrationBuilder.DropForeignKey(
                name: "FK_AbstractFields_GameControllers_GameControllerId",
                table: "AbstractFields");

            migrationBuilder.DropForeignKey(
                name: "FK_aliveFieldsCount_GameControllers_GameControllerId",
                table: "aliveFieldsCount");

            migrationBuilder.DropForeignKey(
                name: "FK_Coins_GameControllers_GameControllerId",
                table: "Coins");

            migrationBuilder.DropForeignKey(
                name: "FK_GameControllers_SessionMedievalBattles_SessionMedievalBattleId",
                table: "GameControllers");

            migrationBuilder.DropForeignKey(
                name: "FK_Units_AbstractFields_ParentObjectAbstractFieldId",
                table: "Units");

            migrationBuilder.DropIndex(
                name: "IX_GameControllers_SessionMedievalBattleId",
                table: "GameControllers");

            migrationBuilder.RenameColumn(
                name: "ParentObjectAbstractFieldId",
                table: "Units",
                newName: "parentObjectabstractFieldId");

            migrationBuilder.RenameColumn(
                name: "Hp",
                table: "Units",
                newName: "hp");

            migrationBuilder.RenameColumn(
                name: "Damage",
                table: "Units",
                newName: "damage");

            migrationBuilder.RenameColumn(
                name: "ArmorDurability",
                table: "Units",
                newName: "armorDurability");

            migrationBuilder.RenameColumn(
                name: "Armor",
                table: "Units",
                newName: "armor");

            migrationBuilder.RenameColumn(
                name: "UnitId",
                table: "Units",
                newName: "unitId");

            migrationBuilder.RenameIndex(
                name: "IX_Units_ParentObjectAbstractFieldId",
                table: "Units",
                newName: "IX_Units_parentObjectabstractFieldId");

            migrationBuilder.RenameColumn(
                name: "UnitDeadCount",
                table: "LocalStatistic",
                newName: "unitDeadCount");

            migrationBuilder.RenameColumn(
                name: "UnitAliveCount",
                table: "LocalStatistic",
                newName: "unitAliveCount");

            migrationBuilder.RenameColumn(
                name: "GameAvaliable",
                table: "GameControllers",
                newName: "gameAvaliable");

            migrationBuilder.RenameColumn(
                name: "DefeatTeam",
                table: "GameControllers",
                newName: "defeatTeam");

            migrationBuilder.RenameColumn(
                name: "CurrentTurn",
                table: "GameControllers",
                newName: "currentTurn");

            migrationBuilder.RenameColumn(
                name: "GameControllerId",
                table: "GameControllers",
                newName: "gameControllerId");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Coins",
                newName: "value");

            migrationBuilder.RenameColumn(
                name: "GameControllerId",
                table: "Coins",
                newName: "gameControllerId");

            migrationBuilder.RenameColumn(
                name: "CoinId",
                table: "Coins",
                newName: "coinId");

            migrationBuilder.RenameIndex(
                name: "IX_Coins_GameControllerId",
                table: "Coins",
                newName: "IX_Coins_gameControllerId");

            migrationBuilder.RenameColumn(
                name: "GameControllerId",
                table: "aliveFieldsCount",
                newName: "gameControllerId");

            migrationBuilder.RenameColumn(
                name: "FieldIndex",
                table: "aliveFieldsCount",
                newName: "fieldIndex");

            migrationBuilder.RenameColumn(
                name: "AliveFieldId",
                table: "aliveFieldsCount",
                newName: "aliveFieldId");

            migrationBuilder.RenameIndex(
                name: "IX_aliveFieldsCount_GameControllerId",
                table: "aliveFieldsCount",
                newName: "IX_aliveFieldsCount_gameControllerId");

            migrationBuilder.RenameColumn(
                name: "UnitCost",
                table: "AbstractFields",
                newName: "unitCost");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "AbstractFields",
                newName: "teamId");

            migrationBuilder.RenameColumn(
                name: "PositionId",
                table: "AbstractFields",
                newName: "positionId");

            migrationBuilder.RenameColumn(
                name: "HpPerUnit",
                table: "AbstractFields",
                newName: "hpPerUnit");

            migrationBuilder.RenameColumn(
                name: "GameControllerId",
                table: "AbstractFields",
                newName: "gameControllerId");

            migrationBuilder.RenameColumn(
                name: "FieldUnitCount",
                table: "AbstractFields",
                newName: "fieldUnitCount");

            migrationBuilder.RenameColumn(
                name: "FieldSize",
                table: "AbstractFields",
                newName: "fieldSize");

            migrationBuilder.RenameColumn(
                name: "FieldHp",
                table: "AbstractFields",
                newName: "fieldHp");

            migrationBuilder.RenameColumn(
                name: "FieldDamage",
                table: "AbstractFields",
                newName: "fieldDamage");

            migrationBuilder.RenameColumn(
                name: "FieldArmor",
                table: "AbstractFields",
                newName: "fieldArmor");

            migrationBuilder.RenameColumn(
                name: "DamagePerUnit",
                table: "AbstractFields",
                newName: "damagePerUnit");

            migrationBuilder.RenameColumn(
                name: "AbstractFieldId1",
                table: "AbstractFields",
                newName: "abstractFieldId1");

            migrationBuilder.RenameColumn(
                name: "AbstractFieldId",
                table: "AbstractFields",
                newName: "abstractFieldId");

            migrationBuilder.RenameIndex(
                name: "IX_AbstractFields_GameControllerId",
                table: "AbstractFields",
                newName: "IX_AbstractFields_gameControllerId");

            migrationBuilder.RenameIndex(
                name: "IX_AbstractFields_AbstractFieldId1",
                table: "AbstractFields",
                newName: "IX_AbstractFields_abstractFieldId1");

            migrationBuilder.AlterColumn<int>(
                name: "SessionMedievalBattleId",
                table: "GameControllers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateTable(
                name: "MedievalBattles",
                columns: table => new
                {
                    MedievalBatlleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionMedievalBattleId = table.Column<int>(type: "int", nullable: false),
                    abstractFieldId = table.Column<int>(type: "int", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_MedievalBattles_AbstractFields_abstractFieldId",
                        column: x => x.abstractFieldId,
                        principalTable: "AbstractFields",
                        principalColumn: "abstractFieldId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameControllers_SessionMedievalBattleId",
                table: "GameControllers",
                column: "SessionMedievalBattleId");

            migrationBuilder.CreateIndex(
                name: "IX_MedievalBattles_SessionMedievalBattleId",
                table: "MedievalBattles",
                column: "SessionMedievalBattleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedievalBattles_abstractFieldId",
                table: "MedievalBattles",
                column: "abstractFieldId");

            migrationBuilder.AddForeignKey(
                name: "FK_AbstractFields_AbstractFields_abstractFieldId1",
                table: "AbstractFields",
                column: "abstractFieldId1",
                principalTable: "AbstractFields",
                principalColumn: "abstractFieldId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbstractFields_GameControllers_gameControllerId",
                table: "AbstractFields",
                column: "gameControllerId",
                principalTable: "GameControllers",
                principalColumn: "gameControllerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_aliveFieldsCount_GameControllers_gameControllerId",
                table: "aliveFieldsCount",
                column: "gameControllerId",
                principalTable: "GameControllers",
                principalColumn: "gameControllerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Coins_GameControllers_gameControllerId",
                table: "Coins",
                column: "gameControllerId",
                principalTable: "GameControllers",
                principalColumn: "gameControllerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GameControllers_SessionMedievalBattles_SessionMedievalBattleId",
                table: "GameControllers",
                column: "SessionMedievalBattleId",
                principalTable: "SessionMedievalBattles",
                principalColumn: "SessionMedievalBattleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Units_AbstractFields_parentObjectabstractFieldId",
                table: "Units",
                column: "parentObjectabstractFieldId",
                principalTable: "AbstractFields",
                principalColumn: "abstractFieldId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
