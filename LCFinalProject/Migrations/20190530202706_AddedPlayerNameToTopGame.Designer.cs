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
    [Migration("20190530202706_AddedPlayerNameToTopGame")]
    partial class AddedPlayerNameToTopGame
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LCFinalProject.Models.Batter", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AtBats");

                    b.Property<int>("CS");

                    b.Property<int>("DaysInTop");

                    b.Property<decimal>("DistanceAvg");

                    b.Property<int>("Doubles");

                    b.Property<string>("FirstName");

                    b.Property<int>("Hits");

                    b.Property<int>("HomeRuns");

                    b.Property<int>("LastFiveAb");

                    b.Property<int>("LastFiveDouble");

                    b.Property<int>("LastFiveHR");

                    b.Property<int>("LastFiveRBI");

                    b.Property<int>("LastFiveRuns");

                    b.Property<int>("LastFiveSB");

                    b.Property<int>("LastFiveSingle");

                    b.Property<int>("LastFiveTriple");

                    b.Property<int>("LastFiveWalk");

                    b.Property<string>("LastName");

                    b.Property<decimal>("LastTenLaunchAvg");

                    b.Property<decimal>("LastTenSpeedAvg");

                    b.Property<int>("PlayerID");

                    b.Property<string>("Position");

                    b.Property<int>("RBIs");

                    b.Property<int>("Runs");

                    b.Property<int>("SB");

                    b.Property<string>("TeamName");

                    b.Property<int>("Triples");

                    b.Property<int>("Walks");

                    b.HasKey("ID");

                    b.ToTable("Batters");
                });

            modelBuilder.Entity("LCFinalProject.Models.Game", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("GameDate");

                    b.Property<int>("GameID");

                    b.Property<string>("Venue");

                    b.Property<int>("VenueID");

                    b.HasKey("ID");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("LCFinalProject.Models.GameStat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CS");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Doubles");

                    b.Property<int>("Hits");

                    b.Property<int>("HomeRuns");

                    b.Property<int>("PlayerID");

                    b.Property<string>("Position");

                    b.Property<int>("RBIs");

                    b.Property<int>("Runs");

                    b.Property<int>("SB");

                    b.Property<int>("Score");

                    b.Property<int>("Triples");

                    b.Property<int>("Walks");

                    b.HasKey("ID");

                    b.ToTable("GameStats");
                });

            modelBuilder.Entity("LCFinalProject.Models.HitData", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<decimal>("Distance");

                    b.Property<decimal>("LaunchAngle");

                    b.Property<decimal>("LaunchSpeed");

                    b.Property<int>("PlayerID");

                    b.HasKey("ID");

                    b.ToTable("HitDatas");
                });

            modelBuilder.Entity("LCFinalProject.Models.PitchData", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.HasKey("ID");

                    b.ToTable("PitchDatas");
                });

            modelBuilder.Entity("LCFinalProject.Models.Pitcher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CS");

                    b.Property<int>("Doubles");

                    b.Property<string>("FirstName");

                    b.Property<int>("Hits");

                    b.Property<int>("HomeRuns");

                    b.Property<string>("LastName");

                    b.Property<int>("PlayerID");

                    b.Property<int>("RBIs");

                    b.Property<int>("Runs");

                    b.Property<int>("SB");

                    b.Property<string>("TeamName");

                    b.Property<int>("Triples");

                    b.Property<int>("Walks");

                    b.HasKey("ID");

                    b.ToTable("Pitchers");
                });

            modelBuilder.Entity("LCFinalProject.Models.PitcherGameStat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BattersFaced");

                    b.Property<int>("CS");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Doubles");

                    b.Property<int>("EarnedRuns");

                    b.Property<int>("FlyOuts");

                    b.Property<int>("GroundOuts");

                    b.Property<int>("Hits");

                    b.Property<int>("HomeRuns");

                    b.Property<int>("OpponentScore");

                    b.Property<int>("PitchesThrown");

                    b.Property<int>("PlayerID");

                    b.Property<int>("RBIs");

                    b.Property<int>("Runs");

                    b.Property<int>("SB");

                    b.Property<decimal>("Score");

                    b.Property<int>("Triples");

                    b.Property<int>("Walks");

                    b.HasKey("ID");

                    b.ToTable("PitcherGameStats");
                });

            modelBuilder.Entity("LCFinalProject.Models.Team", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TeamName");

                    b.HasKey("ID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("LCFinalProject.Models.TopGame", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int>("PlayerID");

                    b.Property<string>("PlayerName");

                    b.Property<string>("Position");

                    b.Property<int>("Score");

                    b.HasKey("ID");

                    b.ToTable("TopGames");
                });
#pragma warning restore 612, 618
        }
    }
}