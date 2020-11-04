using Microsoft.EntityFrameworkCore.Migrations;

namespace RankedNewsSites.Migrations
{
    public partial class AddPointsToUserSite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "pont",
                table: "UserSite",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pont",
                table: "UserSite");
        }
    }
}
