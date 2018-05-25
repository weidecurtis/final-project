using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LCFinalProject.Migrations
{
    public partial class AddedPosPlayerFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "LastFiveTotalScore",
                table: "PositionPlayers",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "YesterdayTotalScore",
                table: "PositionPlayers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastFiveTotalScore",
                table: "PositionPlayers");

            migrationBuilder.DropColumn(
                name: "YesterdayTotalScore",
                table: "PositionPlayers");
        }
    }
}
