using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LCFinalProject.Migrations
{
    public partial class AddedDevianceToPitchers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "LastStartDeviance",
                table: "Pitchers",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LastThreeDeviance",
                table: "Pitchers",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LastThreeProjected",
                table: "Pitchers",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectedScore",
                table: "IndividualGamePitchers",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastStartDeviance",
                table: "Pitchers");

            migrationBuilder.DropColumn(
                name: "LastThreeDeviance",
                table: "Pitchers");

            migrationBuilder.DropColumn(
                name: "LastThreeProjected",
                table: "Pitchers");

            migrationBuilder.DropColumn(
                name: "ProjectedScore",
                table: "IndividualGamePitchers");
        }
    }
}
