using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LCFinalProject.Migrations
{
    public partial class AddedProjectedColumnsPitcher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ProjectedHRA",
                table: "Pitchers",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectedHit",
                table: "Pitchers",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectedRA",
                table: "Pitchers",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectedStrikeout",
                table: "Pitchers",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectedWalk",
                table: "Pitchers",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectedHRA",
                table: "Pitchers");

            migrationBuilder.DropColumn(
                name: "ProjectedHit",
                table: "Pitchers");

            migrationBuilder.DropColumn(
                name: "ProjectedRA",
                table: "Pitchers");

            migrationBuilder.DropColumn(
                name: "ProjectedStrikeout",
                table: "Pitchers");

            migrationBuilder.DropColumn(
                name: "ProjectedWalk",
                table: "Pitchers");
        }
    }
}
