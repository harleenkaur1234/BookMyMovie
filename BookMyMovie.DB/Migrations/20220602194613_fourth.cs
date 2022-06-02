using Microsoft.EntityFrameworkCore.Migrations;

namespace BookMyMovie.DB.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Cinemas_CinemaId",
                table: "Seats");

            migrationBuilder.DropIndex(
                name: "IX_Seats_CinemaId",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "CinemaId",
                table: "Seats");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CinemaId",
                table: "Seats",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seats_CinemaId",
                table: "Seats",
                column: "CinemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Cinemas_CinemaId",
                table: "Seats",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
