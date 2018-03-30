﻿// <auto-generated />
using LCFinalProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace LCFinalProject.Migrations
{
    [DbContext(typeof(BeatTheShiftDbContext))]
    [Migration("20180330005516_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LCFinalProject.Models.Game", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Directory");

                    b.Property<string>("GameDate");

                    b.Property<string>("Venue");

                    b.Property<int>("VenueID");

                    b.HasKey("ID");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("LCFinalProject.Models.Pitcher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("PlayerID");

                    b.HasKey("ID");

                    b.ToTable("Pitchers");
                });

            modelBuilder.Entity("LCFinalProject.Models.PositionPlayer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AwayAb");

                    b.Property<decimal>("AwayAvg");

                    b.Property<int>("AwayCs");

                    b.Property<int>("AwayHit");

                    b.Property<int>("AwayHr");

                    b.Property<decimal>("AwayOps");

                    b.Property<int>("AwayRbi");

                    b.Property<int>("AwayRun");

                    b.Property<int>("AwaySb");

                    b.Property<int>("AwayWalk");

                    b.Property<string>("FirstName");

                    b.Property<int>("HomeAb");

                    b.Property<decimal>("HomeAvg");

                    b.Property<int>("HomeCs");

                    b.Property<int>("HomeHit");

                    b.Property<int>("HomeHr");

                    b.Property<decimal>("HomeOps");

                    b.Property<int>("HomeRbi");

                    b.Property<int>("HomeRun");

                    b.Property<int>("HomeSb");

                    b.Property<int>("HomeWalk");

                    b.Property<string>("LastName");

                    b.Property<int>("MonthAb");

                    b.Property<decimal>("MonthAvg");

                    b.Property<int>("MonthCs");

                    b.Property<int>("MonthHit");

                    b.Property<int>("MonthHr");

                    b.Property<decimal>("MonthOps");

                    b.Property<int>("MonthRbi");

                    b.Property<int>("MonthRun");

                    b.Property<int>("MonthSb");

                    b.Property<int>("MonthWalk");

                    b.Property<string>("PitchHates");

                    b.Property<string>("PitchLoves");

                    b.Property<int>("PlayerID");

                    b.Property<int>("SeasonAb");

                    b.Property<decimal>("SeasonAvg");

                    b.Property<int>("SeasonCs");

                    b.Property<int>("SeasonHit");

                    b.Property<int>("SeasonHr");

                    b.Property<decimal>("SeasonOps");

                    b.Property<int>("SeasonRbi");

                    b.Property<int>("SeasonRun");

                    b.Property<int>("SeasonSb");

                    b.Property<int>("SeasonWalk");

                    b.Property<string>("TeamName");

                    b.Property<int>("VsLhpAb");

                    b.Property<decimal>("VsLhpAvg");

                    b.Property<int>("VsLhpCs");

                    b.Property<int>("VsLhpHit");

                    b.Property<int>("VsLhpHr");

                    b.Property<decimal>("VsLhpOps");

                    b.Property<int>("VsLhpRbi");

                    b.Property<int>("VsLhpRun");

                    b.Property<int>("VsLhpSb");

                    b.Property<int>("VsLhpWalk");

                    b.Property<int>("VsRhpAb");

                    b.Property<decimal>("VsRhpAvg");

                    b.Property<int>("VsRhpCs");

                    b.Property<int>("VsRhpHit");

                    b.Property<int>("VsRhpHr");

                    b.Property<decimal>("VsRhpOps");

                    b.Property<int>("VsRhpRbi");

                    b.Property<int>("VsRhpRun");

                    b.Property<int>("VsRhpSb");

                    b.Property<int>("VsRhpWalk");

                    b.Property<int>("VsStarterAb");

                    b.Property<decimal>("VsStarterAvg");

                    b.Property<int>("VsStarterCs");

                    b.Property<int>("VsStarterHit");

                    b.Property<int>("VsStarterHr");

                    b.Property<decimal>("VsStarterOps");

                    b.Property<int>("VsStarterRbi");

                    b.Property<int>("VsStarterRun");

                    b.Property<int>("VsStarterSb");

                    b.Property<int>("VsStarterWalk");

                    b.HasKey("ID");

                    b.ToTable("PositionPlayers");
                });

            modelBuilder.Entity("LCFinalProject.Models.ProjectedTeam", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PitcherID");

                    b.Property<int>("PositionPlayerID");

                    b.HasKey("ID");

                    b.HasIndex("PitcherID");

                    b.HasIndex("PositionPlayerID");

                    b.ToTable("ProjectedTeams");
                });

            modelBuilder.Entity("LCFinalProject.Models.Result", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.HasKey("ID");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("LCFinalProject.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LCFinalProject.Models.ProjectedTeam", b =>
                {
                    b.HasOne("LCFinalProject.Models.Pitcher", "Pitcher")
                        .WithMany()
                        .HasForeignKey("PitcherID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LCFinalProject.Models.PositionPlayer", "PositionPlayer")
                        .WithMany()
                        .HasForeignKey("PositionPlayerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}