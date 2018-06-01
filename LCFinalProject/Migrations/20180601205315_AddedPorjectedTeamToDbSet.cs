using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LCFinalProject.Migrations
{
    public partial class AddedPorjectedTeamToDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectedTeams",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Catcher = table.Column<string>(nullable: true),
                    CatcherProjection = table.Column<decimal>(nullable: false),
                    CatcherSalary = table.Column<int>(nullable: false),
                    FirstBase = table.Column<string>(nullable: true),
                    FirstBaseProjection = table.Column<decimal>(nullable: false),
                    FirstBaseSalary = table.Column<int>(nullable: false),
                    OutfieldOne = table.Column<string>(nullable: true),
                    OutfieldOneProjection = table.Column<decimal>(nullable: false),
                    OutfieldOneSalary = table.Column<int>(nullable: false),
                    OutfieldThree = table.Column<string>(nullable: true),
                    OutfieldThreeProjection = table.Column<int>(nullable: false),
                    OutfieldThreeSalary = table.Column<int>(nullable: false),
                    OutfieldTwo = table.Column<string>(nullable: true),
                    OutfieldTwoProjection = table.Column<decimal>(nullable: false),
                    OutfieldTwoSalary = table.Column<int>(nullable: false),
                    PitcherOne = table.Column<string>(nullable: true),
                    PitcherOneProjection = table.Column<decimal>(nullable: false),
                    PitcherOneSalary = table.Column<int>(nullable: false),
                    PitcherTwo = table.Column<string>(nullable: true),
                    PitcherTwoProjection = table.Column<decimal>(nullable: false),
                    PitcherTwoSalary = table.Column<int>(nullable: false),
                    SecondBase = table.Column<string>(nullable: true),
                    SecondBaseProjection = table.Column<decimal>(nullable: false),
                    SecondBaseSalary = table.Column<int>(nullable: false),
                    Shortstop = table.Column<string>(nullable: true),
                    ShortstopProjection = table.Column<decimal>(nullable: false),
                    ShortstopSalary = table.Column<int>(nullable: false),
                    TeamProjection = table.Column<decimal>(nullable: false),
                    ThirdBase = table.Column<string>(nullable: true),
                    ThirdBaseProjection = table.Column<decimal>(nullable: false),
                    ThirdBaseSalary = table.Column<int>(nullable: false),
                    TotalCost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectedTeams", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectedTeams");
        }
    }
}
