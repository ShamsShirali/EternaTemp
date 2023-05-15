using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EternaTempl.Migrations
{
    public partial class AddFeaturesTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RandmId",
                table: "Features",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Features_RandmId",
                table: "Features",
                column: "RandmId");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Randms_RandmId",
                table: "Features",
                column: "RandmId",
                principalTable: "Randms",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Features_Randms_RandmId",
                table: "Features");

            migrationBuilder.DropIndex(
                name: "IX_Features_RandmId",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "RandmId",
                table: "Features");
        }
    }
}
