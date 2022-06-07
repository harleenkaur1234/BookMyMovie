using Microsoft.EntityFrameworkCore.Migrations;

namespace BookMyMovie.DB.Migrations
{
    public partial class newChanges1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShowTimes_Movies_MovieId",
                table: "ShowTimes");

            migrationBuilder.AlterColumn<long>(
                name: "MovieId",
                table: "ShowTimes",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_ShowTimes_Movies_MovieId",
                table: "ShowTimes",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShowTimes_Movies_MovieId",
                table: "ShowTimes");

            migrationBuilder.AlterColumn<long>(
                name: "MovieId",
                table: "ShowTimes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ShowTimes_Movies_MovieId",
                table: "ShowTimes",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
