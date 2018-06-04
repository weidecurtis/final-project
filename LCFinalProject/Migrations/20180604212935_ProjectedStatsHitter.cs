using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LCFinalProject.Migrations
{
    public partial class ProjectedStatsHitter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ProjectedDouble",
                table: "PositionPlayer",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectedHR",
                table: "PositionPlayer",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectedHit",
                table: "PositionPlayer",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectedRBI",
                table: "PositionPlayer",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectedRun",
                table: "PositionPlayer",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectedSB",
                table: "PositionPlayer",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectedTriple",
                table: "PositionPlayer",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectedWalk",
                table: "PositionPlayer",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectedDouble",
                table: "PositionPlayer");

            migrationBuilder.DropColumn(
                name: "ProjectedHR",
                table: "PositionPlayer");

            migrationBuilder.DropColumn(
                name: "ProjectedHit",
                table: "PositionPlayer");

            migrationBuilder.DropColumn(
                name: "ProjectedRBI",
                table: "PositionPlayer");

            migrationBuilder.DropColumn(
                name: "ProjectedRun",
                table: "PositionPlayer");

            migrationBuilder.DropColumn(
                name: "ProjectedSB",
                table: "PositionPlayer");

            migrationBuilder.DropColumn(
                name: "ProjectedTriple",
                table: "PositionPlayer");

            migrationBuilder.DropColumn(
                name: "ProjectedWalk",
                table: "PositionPlayer");
        }
    }
}
