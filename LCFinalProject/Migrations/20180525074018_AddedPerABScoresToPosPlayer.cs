using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LCFinalProject.Migrations
{
    public partial class AddedPerABScoresToPosPlayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AwayScorePerAB",
                table: "PositionPlayers",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "HomeScorePerAB",
                table: "PositionPlayers",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "VsLhpScorePerAB",
                table: "PositionPlayers",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "VsRhpScorePerAB",
                table: "PositionPlayers",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwayScorePerAB",
                table: "PositionPlayers");

            migrationBuilder.DropColumn(
                name: "HomeScorePerAB",
                table: "PositionPlayers");

            migrationBuilder.DropColumn(
                name: "VsLhpScorePerAB",
                table: "PositionPlayers");

            migrationBuilder.DropColumn(
                name: "VsRhpScorePerAB",
                table: "PositionPlayers");
        }
    }
}
