using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LCFinalProject.Migrations
{
    public partial class AddedScoresToSpecificStats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectedTeams");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropColumn(
                name: "DkID",
                table: "PositionPlayers");

            migrationBuilder.DropColumn(
                name: "VsStarterAb",
                table: "PositionPlayers");

            migrationBuilder.DropColumn(
                name: "VsStarterAvg",
                table: "PositionPlayers");

            migrationBuilder.DropColumn(
                name: "VsStarterCs",
                table: "PositionPlayers");

            migrationBuilder.DropColumn(
                name: "VsStarterHit",
                table: "PositionPlayers");

            migrationBuilder.DropColumn(
                name: "VsStarterOps",
                table: "PositionPlayers");

            migrationBuilder.RenameColumn(
                name: "VsStarterWalk",
                table: "PositionPlayers",
                newName: "VsRhpTotalScore");

            migrationBuilder.RenameColumn(
                name: "VsStarterSb",
                table: "PositionPlayers",
                newName: "VsLhpTotalScore");

            migrationBuilder.RenameColumn(
                name: "VsStarterRun",
                table: "PositionPlayers",
                newName: "SeasonTotalScore");

            migrationBuilder.RenameColumn(
                name: "VsStarterRbi",
                table: "PositionPlayers",
                newName: "HomeTotalScore");

            migrationBuilder.RenameColumn(
                name: "VsStarterHr",
                table: "PositionPlayers",
                newName: "AwayTotalScore");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VsRhpTotalScore",
                table: "PositionPlayers",
                newName: "VsStarterWalk");

            migrationBuilder.RenameColumn(
                name: "VsLhpTotalScore",
                table: "PositionPlayers",
                newName: "VsStarterSb");

            migrationBuilder.RenameColumn(
                name: "SeasonTotalScore",
                table: "PositionPlayers",
                newName: "VsStarterRun");

            migrationBuilder.RenameColumn(
                name: "HomeTotalScore",
                table: "PositionPlayers",
                newName: "VsStarterRbi");

            migrationBuilder.RenameColumn(
                name: "AwayTotalScore",
                table: "PositionPlayers",
                newName: "VsStarterHr");

            migrationBuilder.AddColumn<int>(
                name: "DkID",
                table: "PositionPlayers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VsStarterAb",
                table: "PositionPlayers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "VsStarterAvg",
                table: "PositionPlayers",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "VsStarterCs",
                table: "PositionPlayers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VsStarterHit",
                table: "PositionPlayers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "VsStarterOps",
                table: "PositionPlayers",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "ProjectedTeams",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CatcherName = table.Column<string>(nullable: true),
                    CatcherPrice = table.Column<int>(nullable: false),
                    CatcherProjectedScore = table.Column<decimal>(nullable: false),
                    FirstBaseName = table.Column<string>(nullable: true),
                    FirstBasePrice = table.Column<int>(nullable: false),
                    FirstBaseProjectScore = table.Column<decimal>(nullable: false),
                    OutfieldOneName = table.Column<string>(nullable: true),
                    OutfieldOnePrice = table.Column<int>(nullable: false),
                    OutfieldOneProjectedScore = table.Column<decimal>(nullable: false),
                    OutfieldThreeName = table.Column<string>(nullable: true),
                    OutfieldThreePrice = table.Column<int>(nullable: false),
                    OutfieldThreeProjectedScore = table.Column<decimal>(nullable: false),
                    OutfieldTwoName = table.Column<string>(nullable: true),
                    OutfieldTwoPrice = table.Column<int>(nullable: false),
                    OutfieldTwoProjectedScore = table.Column<decimal>(nullable: false),
                    PitcherOneName = table.Column<string>(nullable: true),
                    PitcherOnePrice = table.Column<int>(nullable: false),
                    PitcherOneProjectedScore = table.Column<decimal>(nullable: false),
                    PitcherTwoName = table.Column<string>(nullable: true),
                    PitcherTwoPrice = table.Column<int>(nullable: false),
                    PitcherTwoProjectedScore = table.Column<decimal>(nullable: false),
                    Position = table.Column<string>(nullable: true),
                    ProjectedResults = table.Column<decimal>(nullable: false),
                    SecondBaseName = table.Column<string>(nullable: true),
                    SecondBasePrice = table.Column<int>(nullable: false),
                    SecondBaseProjectedScore = table.Column<decimal>(nullable: false),
                    ShortStopName = table.Column<string>(nullable: true),
                    ShortStopPrice = table.Column<int>(nullable: false),
                    ShortStopProjectedScore = table.Column<decimal>(nullable: false),
                    ThirdBaseName = table.Column<string>(nullable: true),
                    ThirdBasePrice = table.Column<int>(nullable: false),
                    ThirdBaseProjectedScore = table.Column<decimal>(nullable: false),
                    TotalProjectedScore = table.Column<decimal>(nullable: false),
                    TotalTeamPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectedTeams", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.ID);
                });
        }
    }
}
