using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LCFinalProject.Migrations
{
    public partial class AddedTeamToStats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "ProjectedSecondBasemen");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "ProjectedOutfielders");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "ProjectedFirstBasemen");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "ProjectedCatchers");

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "YesterdayThirdBasemen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "YesterdayShortstops",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "YesterdaySecondBasemen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "YesterdayOutfielders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "YesterdayFirstBasemen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "YesterdayCatchers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "RhpThirdBasemen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "RhpShortstops",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "RhpSecondBasemen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "RhpOutfielders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "RhpFirstBasemen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "RhpCatchers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "ProjectedThirdBasemen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "ProjectedShortstops",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "ProjectedSecondBasemen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "ProjectedPitchers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "ProjectedOutfielders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "ProjectedFirstBasemen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "ProjectedCatchers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "LhpThirdBasemen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "LhpShortstops",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "LhpSecondBasemen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "LhpOutfielders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "LhpFirstBasemen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "LhpCatchers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "HomeThirdBasemen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "HomeShortstops",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "AwayThirdBasemen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "AwayShortstops",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "AwaySecondBasemen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "AwayPitchers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "AwayOutfielders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "AwayFirstBasemen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "AwayCatchers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Team",
                table: "YesterdayThirdBasemen");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "YesterdayShortstops");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "YesterdaySecondBasemen");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "YesterdayOutfielders");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "YesterdayFirstBasemen");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "YesterdayCatchers");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "RhpThirdBasemen");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "RhpShortstops");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "RhpSecondBasemen");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "RhpOutfielders");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "RhpFirstBasemen");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "RhpCatchers");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "ProjectedThirdBasemen");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "ProjectedShortstops");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "ProjectedSecondBasemen");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "ProjectedPitchers");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "ProjectedOutfielders");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "ProjectedFirstBasemen");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "ProjectedCatchers");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "LhpThirdBasemen");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "LhpShortstops");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "LhpSecondBasemen");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "LhpOutfielders");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "LhpFirstBasemen");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "LhpCatchers");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "HomeThirdBasemen");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "HomeShortstops");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "AwayThirdBasemen");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "AwayShortstops");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "AwaySecondBasemen");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "AwayPitchers");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "AwayOutfielders");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "AwayFirstBasemen");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "AwayCatchers");

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "ProjectedSecondBasemen",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "ProjectedOutfielders",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "ProjectedFirstBasemen",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "ProjectedCatchers",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
