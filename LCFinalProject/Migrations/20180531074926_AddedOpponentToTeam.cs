using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LCFinalProject.Migrations
{
    public partial class AddedOpponentToTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Oppenent",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpponentStarter",
                table: "PositionPlayer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Oppenent",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "OpponentStarter",
                table: "PositionPlayer");
        }
    }
}
