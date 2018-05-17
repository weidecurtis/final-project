using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LCFinalProject.Migrations
{
    public partial class AddedPPAToAllPositions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "RhpThirdBasemen",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "RhpShortstops",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "RhpSecondBasemen",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "RhpOutfielders",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "RhpFirstBasemen",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "RhpCatchers",
                nullable: false,
                defaultValue: 0m);

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

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "LhpThirdBasemen",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "LhpShortstops",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "LhpSecondBasemen",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "LhpOutfielders",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "LhpFirstBasemen",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "LhpCatchers",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "HomeThirdBasemen",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "HomeShortstops",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "HomeSecondBasemen",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "HomeOutfielders",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "HomeFirstBasemen",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "AwayThirdBasemen",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "AwayShortstops",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "AwaySecondBasemen",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "AwayOutfielders",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "AwayFirstBasemen",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PointPerAtBat",
                table: "AwayCatchers",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "RhpThirdBasemen");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "RhpShortstops");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "RhpSecondBasemen");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "RhpOutfielders");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "RhpFirstBasemen");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "RhpCatchers");

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

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "LhpThirdBasemen");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "LhpShortstops");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "LhpSecondBasemen");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "LhpOutfielders");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "LhpFirstBasemen");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "LhpCatchers");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "HomeThirdBasemen");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "HomeShortstops");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "HomeSecondBasemen");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "HomeOutfielders");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "HomeFirstBasemen");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "AwayThirdBasemen");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "AwayShortstops");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "AwaySecondBasemen");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "AwayOutfielders");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "AwayFirstBasemen");

            migrationBuilder.DropColumn(
                name: "PointPerAtBat",
                table: "AwayCatchers");
        }
    }
}
