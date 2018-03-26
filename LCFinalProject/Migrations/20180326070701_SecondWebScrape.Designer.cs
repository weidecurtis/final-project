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
    [Migration("20180326070701_SecondWebScrape")]
    partial class SecondWebScrape
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LCFinalProject.Models.Pitcher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("Projection");

                    b.HasKey("ID");

                    b.ToTable("Pitchers");
                });

            modelBuilder.Entity("LCFinalProject.Models.PositionPlayer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

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
