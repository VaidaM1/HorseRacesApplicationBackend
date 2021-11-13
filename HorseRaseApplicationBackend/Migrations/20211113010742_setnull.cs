using Microsoft.EntityFrameworkCore.Migrations;

namespace HorseRaseApplicationBackend.Migrations
{
    public partial class setnull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Betters_Horses_HorseId",
                table: "Betters");

            migrationBuilder.AddForeignKey(
                name: "FK_Betters_Horses_HorseId",
                table: "Betters",
                column: "HorseId",
                principalTable: "Horses",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Betters_Horses_HorseId",
                table: "Betters");

            migrationBuilder.AddForeignKey(
                name: "FK_Betters_Horses_HorseId",
                table: "Betters",
                column: "HorseId",
                principalTable: "Horses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
