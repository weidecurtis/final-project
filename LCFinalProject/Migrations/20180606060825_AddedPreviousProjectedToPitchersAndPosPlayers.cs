using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LCFinalProject.Migrations
{
    public partial class AddedPreviousProjectedToPitchersAndPosPlayers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "YesterdayProjected",
                table: "PositionPlayer",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LastStartProjected",
                table: "Pitchers",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YesterdayProjected",
                table: "PositionPlayer");

            migrationBuilder.DropColumn(
                name: "LastStartProjected",
                table: "Pitchers");
        }
    }
}
