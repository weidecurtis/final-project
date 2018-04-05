using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LCFinalProject.Migrations
{
    public partial class AddedProjectedResults : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectedTeams_Pitchers_PitcherID",
                table: "ProjectedTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectedTeams_PositionPlayers_PositionPlayerID",
                table: "ProjectedTeams");

            migrationBuilder.DropIndex(
                name: "IX_ProjectedTeams_PitcherID",
                table: "ProjectedTeams");

            migrationBuilder.DropIndex(
                name: "IX_ProjectedTeams_PositionPlayerID",
                table: "ProjectedTeams");

            migrationBuilder.RenameColumn(
                name: "PositionPlayerID",
                table: "ProjectedTeams",
                newName: "TotalTeamPrice");

            migrationBuilder.RenameColumn(
                name: "PitcherID",
                table: "ProjectedTeams",
                newName: "ThirdBasePrice");

            migrationBuilder.AddColumn<string>(
                name: "CatcherName",
                table: "ProjectedTeams",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatcherPrice",
                table: "ProjectedTeams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "CatcherProjectedScore",
                table: "ProjectedTeams",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "FirstBaseName",
                table: "ProjectedTeams",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FirstBasePrice",
                table: "ProjectedTeams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "FirstBaseProjectScore",
                table: "ProjectedTeams",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "OutfieldOneName",
                table: "ProjectedTeams",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OutfieldOnePrice",
                table: "ProjectedTeams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "OutfieldOneProjectedScore",
                table: "ProjectedTeams",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "OutfieldThreeName",
                table: "ProjectedTeams",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OutfieldThreePrice",
                table: "ProjectedTeams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "OutfieldThreeProjectedScore",
                table: "ProjectedTeams",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "OutfieldTwoName",
                table: "ProjectedTeams",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OutfieldTwoPrice",
                table: "ProjectedTeams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "OutfieldTwoProjectedScore",
                table: "ProjectedTeams",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "PitcherOneName",
                table: "ProjectedTeams",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PitcherOnePrice",
                table: "ProjectedTeams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "PitcherOneProjectedScore",
                table: "ProjectedTeams",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "PitcherTwoName",
                table: "ProjectedTeams",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PitcherTwoPrice",
                table: "ProjectedTeams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "PitcherTwoProjectedScore",
                table: "ProjectedTeams",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "ProjectedTeams",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ProjectedResults",
                table: "ProjectedTeams",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "SecondBaseName",
                table: "ProjectedTeams",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecondBasePrice",
                table: "ProjectedTeams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "SecondBaseProjectedScore",
                table: "ProjectedTeams",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ShortStopName",
                table: "ProjectedTeams",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShortStopPrice",
                table: "ProjectedTeams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "ShortStopProjectedScore",
                table: "ProjectedTeams",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ThirdBaseName",
                table: "ProjectedTeams",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ThirdBaseProjectedScore",
                table: "ProjectedTeams",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalProjectedScore",
                table: "ProjectedTeams",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CatcherName",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "CatcherPrice",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "CatcherProjectedScore",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "FirstBaseName",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "FirstBasePrice",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "FirstBaseProjectScore",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "OutfieldOneName",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "OutfieldOnePrice",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "OutfieldOneProjectedScore",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "OutfieldThreeName",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "OutfieldThreePrice",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "OutfieldThreeProjectedScore",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "OutfieldTwoName",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "OutfieldTwoPrice",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "OutfieldTwoProjectedScore",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "PitcherOneName",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "PitcherOnePrice",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "PitcherOneProjectedScore",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "PitcherTwoName",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "PitcherTwoPrice",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "PitcherTwoProjectedScore",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "ProjectedResults",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "SecondBaseName",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "SecondBasePrice",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "SecondBaseProjectedScore",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "ShortStopName",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "ShortStopPrice",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "ShortStopProjectedScore",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "ThirdBaseName",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "ThirdBaseProjectedScore",
                table: "ProjectedTeams");

            migrationBuilder.DropColumn(
                name: "TotalProjectedScore",
                table: "ProjectedTeams");

            migrationBuilder.RenameColumn(
                name: "TotalTeamPrice",
                table: "ProjectedTeams",
                newName: "PositionPlayerID");

            migrationBuilder.RenameColumn(
                name: "ThirdBasePrice",
                table: "ProjectedTeams",
                newName: "PitcherID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectedTeams_PitcherID",
                table: "ProjectedTeams",
                column: "PitcherID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectedTeams_PositionPlayerID",
                table: "ProjectedTeams",
                column: "PositionPlayerID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectedTeams_Pitchers_PitcherID",
                table: "ProjectedTeams",
                column: "PitcherID",
                principalTable: "Pitchers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectedTeams_PositionPlayers_PositionPlayerID",
                table: "ProjectedTeams",
                column: "PositionPlayerID",
                principalTable: "PositionPlayers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
