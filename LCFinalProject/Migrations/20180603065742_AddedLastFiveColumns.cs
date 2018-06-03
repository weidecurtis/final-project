using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LCFinalProject.Migrations
{
    public partial class AddedLastFiveColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LastFiveDouble",
                table: "PositionPlayer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastFiveHR",
                table: "PositionPlayer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastFiveHit",
                table: "PositionPlayer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastFiveRuns",
                table: "PositionPlayer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastFiveTriple",
                table: "PositionPlayer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LastFiveWalk",
                table: "PositionPlayer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastFiveDouble",
                table: "PositionPlayer");

            migrationBuilder.DropColumn(
                name: "LastFiveHR",
                table: "PositionPlayer");

            migrationBuilder.DropColumn(
                name: "LastFiveHit",
                table: "PositionPlayer");

            migrationBuilder.DropColumn(
                name: "LastFiveRuns",
                table: "PositionPlayer");

            migrationBuilder.DropColumn(
                name: "LastFiveTriple",
                table: "PositionPlayer");

            migrationBuilder.DropColumn(
                name: "LastFiveWalk",
                table: "PositionPlayer");
        }
    }
}
