using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LCFinalProject.Migrations
{
    public partial class AddedTeamToModelsMissed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "HomeSecondBasemen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "HomeOutfielders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "HomeFirstBasemen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "HomeCatchers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Team",
                table: "HomeSecondBasemen");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "HomeOutfielders");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "HomeFirstBasemen");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "HomeCatchers");
        }
    }
}
