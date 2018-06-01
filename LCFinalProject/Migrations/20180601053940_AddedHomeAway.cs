using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LCFinalProject.Migrations
{
    public partial class AddedHomeAway : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HomeAway",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAway",
                table: "PositionPlayer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAway",
                table: "Pitchers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HomeAway",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "HomeAway",
                table: "PositionPlayer");

            migrationBuilder.DropColumn(
                name: "HomeAway",
                table: "Pitchers");
        }
    }
}
