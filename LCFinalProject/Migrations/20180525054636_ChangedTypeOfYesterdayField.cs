using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LCFinalProject.Migrations
{
    public partial class ChangedTypeOfYesterdayField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "YesterdayTotalScore",
                table: "PositionPlayers",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "YesterdayTotalScore",
                table: "PositionPlayers",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
