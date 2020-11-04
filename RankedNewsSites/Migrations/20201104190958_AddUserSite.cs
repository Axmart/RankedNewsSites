using Microsoft.EntityFrameworkCore.Migrations;

namespace RankedNewsSites.Migrations
{
    public partial class AddUserSite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserSite",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    SiteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSite", x => new { x.UserId, x.SiteId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSite");
        }
    }
}
