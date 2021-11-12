using Microsoft.EntityFrameworkCore.Migrations;

namespace HorseRaseApplicationBackend.Migrations
{
    public partial class better : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "About",
                table: "Betters");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "Betters",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
