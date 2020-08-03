using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class UpdatedAbstractFieldModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AliveUnitCount",
                table: "AbstractFields",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeadUnitCount",
                table: "AbstractFields",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AliveUnitCount",
                table: "AbstractFields");

            migrationBuilder.DropColumn(
                name: "DeadUnitCount",
                table: "AbstractFields");
        }
    }
}
