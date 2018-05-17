using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LCFinalProject.Migrations
{
    public partial class AddedYesterdayPerformers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YesterdayCatchers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YesterdayCatchers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "YesterdayFirstBasemen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YesterdayFirstBasemen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "YesterdayOutfielders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YesterdayOutfielders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "YesterdaySecondBasemen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YesterdaySecondBasemen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "YesterdayShortstops",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YesterdayShortstops", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "YesterdayThirdBasemen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YesterdayThirdBasemen", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YesterdayCatchers");

            migrationBuilder.DropTable(
                name: "YesterdayFirstBasemen");

            migrationBuilder.DropTable(
                name: "YesterdayOutfielders");

            migrationBuilder.DropTable(
                name: "YesterdaySecondBasemen");

            migrationBuilder.DropTable(
                name: "YesterdayShortstops");

            migrationBuilder.DropTable(
                name: "YesterdayThirdBasemen");
        }
    }
}
