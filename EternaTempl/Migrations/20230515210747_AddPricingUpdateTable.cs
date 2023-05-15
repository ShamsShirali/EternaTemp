﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EternaTempl.Migrations
{
    public partial class AddPricingUpdateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Pricings",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Pricings");
        }
    }
}
