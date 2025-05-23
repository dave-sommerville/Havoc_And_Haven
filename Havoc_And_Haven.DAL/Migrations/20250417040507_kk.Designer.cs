﻿// <auto-generated />
using System;
using Havoc_And_Haven.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Havoc_And_Haven.DAL.Migrations
{
    [DbContext(typeof(HavocAndHavenDbContext))]
    [Migration("20250417040507_kk")]
    partial class kk
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CrisisEventHeroes", b =>
                {
                    b.Property<int>("CrisisEventId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CrisisEventId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("CrisisEventHeroes");
                });

            modelBuilder.Entity("CrisisEventVillains", b =>
                {
                    b.Property<int>("CrisisEventId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CrisisEventId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("CrisisEventVillains");
                });

            modelBuilder.Entity("Havoc_And_Haven.Models.Battle", b =>
                {
                    b.Property<int>("BattleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BattleId"));

                    b.Property<int>("CrisisId")
                        .HasColumnType("int");

                    b.Property<int?>("HeroId")
                        .HasColumnType("int");

                    b.Property<DateTime>("IncidentBegan")
                        .HasColumnType("datetime2");

                    b.Property<int?>("VillainId")
                        .HasColumnType("int");

                    b.Property<string>("Winner")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("BattleId");

                    b.HasIndex("CrisisId");

                    b.HasIndex("HeroId");

                    b.HasIndex("VillainId");

                    b.ToTable("Battles");
                });

            modelBuilder.Entity("Havoc_And_Haven.Models.CrisisEvent", b =>
                {
                    b.Property<int>("CrisisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CrisisId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsResolved")
                        .HasColumnType("bit");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CrisisId");

                    b.HasIndex("LocationId");

                    b.ToTable("CrisisEvents");
                });

            modelBuilder.Entity("Havoc_And_Haven.Models.Headquarters", b =>
                {
                    b.Property<int>("HeadquartersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HeadquartersId"));

                    b.Property<string>("BaseTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.HasKey("HeadquartersId");

                    b.HasIndex("LocationId");

                    b.ToTable("Headquarters");
                });

            modelBuilder.Entity("Havoc_And_Haven.Models.Lair", b =>
                {
                    b.Property<int>("LairId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LairId"));

                    b.Property<string>("BaseTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.HasKey("LairId");

                    b.HasIndex("LocationId");

                    b.ToTable("Lairs");
                });

            modelBuilder.Entity("Havoc_And_Haven.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Havoc_And_Haven.Models.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("HeadquartersId")
                        .HasColumnType("int");

                    b.Property<int?>("LairId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OriginStory")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("PowerLevel")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("HeadquartersId");

                    b.HasIndex("LairId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CrisisEventHeroes", b =>
                {
                    b.HasOne("Havoc_And_Haven.Models.CrisisEvent", null)
                        .WithMany()
                        .HasForeignKey("CrisisEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Havoc_And_Haven.Models.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CrisisEventVillains", b =>
                {
                    b.HasOne("Havoc_And_Haven.Models.CrisisEvent", null)
                        .WithMany()
                        .HasForeignKey("CrisisEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Havoc_And_Haven.Models.Users", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Havoc_And_Haven.Models.Battle", b =>
                {
                    b.HasOne("Havoc_And_Haven.Models.CrisisEvent", "CrisisEvent")
                        .WithMany()
                        .HasForeignKey("CrisisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Havoc_And_Haven.Models.Users", "Hero")
                        .WithMany()
                        .HasForeignKey("HeroId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Havoc_And_Haven.Models.Users", "Villain")
                        .WithMany()
                        .HasForeignKey("VillainId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CrisisEvent");

                    b.Navigation("Hero");

                    b.Navigation("Villain");
                });

            modelBuilder.Entity("Havoc_And_Haven.Models.CrisisEvent", b =>
                {
                    b.HasOne("Havoc_And_Haven.Models.Location", "Location")
                        .WithMany("CrisisEvents")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Havoc_And_Haven.Models.Headquarters", b =>
                {
                    b.HasOne("Havoc_And_Haven.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Havoc_And_Haven.Models.Lair", b =>
                {
                    b.HasOne("Havoc_And_Haven.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Havoc_And_Haven.Models.Users", b =>
                {
                    b.HasOne("Havoc_And_Haven.Models.Headquarters", "Headquarters")
                        .WithMany("Heroes")
                        .HasForeignKey("HeadquartersId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Havoc_And_Haven.Models.Lair", "Lair")
                        .WithMany("Villains")
                        .HasForeignKey("LairId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Headquarters");

                    b.Navigation("Lair");
                });

            modelBuilder.Entity("Havoc_And_Haven.Models.Headquarters", b =>
                {
                    b.Navigation("Heroes");
                });

            modelBuilder.Entity("Havoc_And_Haven.Models.Lair", b =>
                {
                    b.Navigation("Villains");
                });

            modelBuilder.Entity("Havoc_And_Haven.Models.Location", b =>
                {
                    b.Navigation("CrisisEvents");
                });
#pragma warning restore 612, 618
        }
    }
}
