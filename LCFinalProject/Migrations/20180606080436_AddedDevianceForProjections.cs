using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LCFinalProject.Migrations
{
    public partial class AddedDevianceForProjections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "LastFiveDeviance",
                table: "PositionPlayer",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LastFiveProjected",
                table: "PositionPlayer",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "YesterdayDeviance",
                table: "PositionPlayer",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastFiveDeviance",
                table: "PositionPlayer");

            migrationBuilder.DropColumn(
                name: "LastFiveProjected",
                table: "PositionPlayer");

            migrationBuilder.DropColumn(
                name: "YesterdayDeviance",
                table: "PositionPlayer");
        }
    }
}
