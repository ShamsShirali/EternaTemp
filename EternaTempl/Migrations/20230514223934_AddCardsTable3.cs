using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EternaTempl.Migrations
{
    public partial class AddCardsTable3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RandmId",
                table: "Cards",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cards_RandmId",
                table: "Cards",
                column: "RandmId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Randms_RandmId",
                table: "Cards",
                column: "RandmId",
                principalTable: "Randms",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Randms_RandmId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_RandmId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "RandmId",
                table: "Cards");
        }
    }
}
