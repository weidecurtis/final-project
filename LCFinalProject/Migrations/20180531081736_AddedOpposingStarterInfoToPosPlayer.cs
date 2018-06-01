using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LCFinalProject.Migrations
{
    public partial class AddedOpposingStarterInfoToPosPlayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OpponentHRALastThree",
                table: "PositionPlayer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OpponentPointsLastThree",
                table: "PositionPlayer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OpponentThrowingHand",
                table: "PositionPlayer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OpponentHRALastThree",
                table: "PositionPlayer");

            migrationBuilder.DropColumn(
                name: "OpponentPointsLastThree",
                table: "PositionPlayer");

            migrationBuilder.DropColumn(
                name: "OpponentThrowingHand",
                table: "PositionPlayer");
        }
    }
}
