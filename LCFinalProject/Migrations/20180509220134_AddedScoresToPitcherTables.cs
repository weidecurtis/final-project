using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LCFinalProject.Migrations
{
    public partial class AddedScoresToPitcherTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AwayTotalScore",
                table: "Pitchers",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "HomeTotalScore",
                table: "Pitchers",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SeasonTotalScore",
                table: "Pitchers",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "SeasonWins",
                table: "Pitchers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwayTotalScore",
                table: "Pitchers");

            migrationBuilder.DropColumn(
                name: "HomeTotalScore",
                table: "Pitchers");

            migrationBuilder.DropColumn(
                name: "SeasonTotalScore",
                table: "Pitchers");

            migrationBuilder.DropColumn(
                name: "SeasonWins",
                table: "Pitchers");
        }
    }
}
