using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MHDB.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AircraftCarriers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AircraftNo = table.Column<double>(nullable: false),
                    Armament = table.Column<string>(nullable: false),
                    Armor = table.Column<string>(nullable: true),
                    Beam = table.Column<double>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    Displacement = table.Column<double>(nullable: false),
                    Draft = table.Column<double>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftCarriers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AirDefense",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Carriage = table.Column<string>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaximumElevation = table.Column<double>(nullable: false),
                    MinimumElevation = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    RateOfFire = table.Column<double>(nullable: false),
                    Shell = table.Column<string>(nullable: true),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirDefense", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmphibiousWarfare",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AircraftNo = table.Column<double>(nullable: false),
                    Armament = table.Column<string>(nullable: false),
                    Armor = table.Column<string>(nullable: true),
                    Beam = table.Column<double>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    Displacement = table.Column<double>(nullable: false),
                    Draft = table.Column<double>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmphibiousWarfare", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AntiMaterial",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Action = table.Column<string>(nullable: true),
                    BarrelLength = table.Column<double>(nullable: false),
                    Calibre = table.Column<string>(nullable: true),
                    Cartridge = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EffectiveRange = table.Column<double>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    FeedSystem = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxRange = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    MuzzleVelocity = table.Column<double>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    Sights = table.Column<string>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AntiMaterial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "APCs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Armament = table.Column<string>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: false),
                    FuelCapacity = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Suspension = table.Column<string>(nullable: true),
                    Transmission = table.Column<string>(nullable: true),
                    Weight = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APCs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attack",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Armament = table.Column<string>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxAltitude = table.Column<double>(nullable: false),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attack", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bomber",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Armament = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: true),
                    Height = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxAltitude = table.Column<double>(nullable: false),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bomber", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommandAndControl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Armament = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: true),
                    Height = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxAltitude = table.Column<double>(nullable: false),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommandAndControl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cruisers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AircraftNo = table.Column<double>(nullable: false),
                    Armament = table.Column<string>(nullable: false),
                    Armor = table.Column<string>(nullable: true),
                    Beam = table.Column<double>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    Displacement = table.Column<double>(nullable: false),
                    Draft = table.Column<double>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cruisers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Destroyers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AircraftNo = table.Column<double>(nullable: false),
                    Armament = table.Column<string>(nullable: false),
                    Armor = table.Column<string>(nullable: true),
                    Beam = table.Column<double>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    Displacement = table.Column<double>(nullable: false),
                    Draft = table.Column<double>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destroyers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DMRSniperRifles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Action = table.Column<string>(nullable: true),
                    BarrelLength = table.Column<double>(nullable: false),
                    Calibre = table.Column<string>(nullable: true),
                    Cartridge = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EffectiveRange = table.Column<double>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    FeedSystem = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxRange = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    MuzzleVelocity = table.Column<double>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    Sights = table.Column<string>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMRSniperRifles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fighter",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Armament = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: true),
                    Height = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxAltitude = table.Column<double>(nullable: false),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fighter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Frigates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AircraftNo = table.Column<double>(nullable: false),
                    Armament = table.Column<string>(nullable: false),
                    Armor = table.Column<string>(nullable: true),
                    Beam = table.Column<double>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    Displacement = table.Column<double>(nullable: false),
                    Draft = table.Column<double>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frigates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroundAttack",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Armament = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: true),
                    Height = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxAltitude = table.Column<double>(nullable: false),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroundAttack", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gunship",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Armament = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: true),
                    Height = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxAltitude = table.Column<double>(nullable: false),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gunship", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Howitzers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Carriage = table.Column<string>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaximumElevation = table.Column<double>(nullable: false),
                    MinimumElevation = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    RateOfFire = table.Column<double>(nullable: false),
                    Shell = table.Column<string>(nullable: true),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Howitzers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IFVs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Armament = table.Column<string>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: false),
                    FuelCapacity = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Suspension = table.Column<string>(nullable: true),
                    Transmission = table.Column<string>(nullable: true),
                    Weight = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IFVs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MachineGuns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Action = table.Column<string>(nullable: true),
                    BarrelLength = table.Column<double>(nullable: false),
                    Calibre = table.Column<string>(nullable: true),
                    Cartridge = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EffectiveRange = table.Column<double>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    FeedSystem = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxRange = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    MuzzleVelocity = table.Column<double>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    Sights = table.Column<string>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineGuns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mortars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Carriage = table.Column<string>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaximumElevation = table.Column<double>(nullable: false),
                    MinimumElevation = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    RateOfFire = table.Column<double>(nullable: false),
                    Shell = table.Column<string>(nullable: true),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mortars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Observation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Armament = table.Column<string>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxAltitude = table.Column<double>(nullable: false),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Observation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pistols",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Action = table.Column<string>(nullable: true),
                    BarrelLength = table.Column<double>(nullable: false),
                    Calibre = table.Column<string>(nullable: true),
                    Cartridge = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EffectiveRange = table.Column<double>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    FeedSystem = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxRange = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    MuzzleVelocity = table.Column<double>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    Sights = table.Column<string>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pistols", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RiflesAndCarbines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Action = table.Column<string>(nullable: true),
                    BarrelLength = table.Column<double>(nullable: false),
                    Calibre = table.Column<string>(nullable: true),
                    Cartridge = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EffectiveRange = table.Column<double>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    FeedSystem = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxRange = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    MuzzleVelocity = table.Column<double>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    Sights = table.Column<string>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiflesAndCarbines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RocketArtillery",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Carriage = table.Column<string>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaximumElevation = table.Column<double>(nullable: false),
                    MinimumElevation = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    RateOfFire = table.Column<double>(nullable: false),
                    Shell = table.Column<string>(nullable: true),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RocketArtillery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shotguns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Action = table.Column<string>(nullable: true),
                    BarrelLength = table.Column<double>(nullable: false),
                    Calibre = table.Column<string>(nullable: true),
                    Cartridge = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EffectiveRange = table.Column<double>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    FeedSystem = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxRange = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    MuzzleVelocity = table.Column<double>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    Sights = table.Column<string>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shotguns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubmachineGuns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Action = table.Column<string>(nullable: true),
                    BarrelLength = table.Column<double>(nullable: false),
                    Calibre = table.Column<string>(nullable: true),
                    Cartridge = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EffectiveRange = table.Column<double>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    FeedSystem = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxRange = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    MuzzleVelocity = table.Column<double>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    Sights = table.Column<string>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubmachineGuns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Submarines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AircraftNo = table.Column<double>(nullable: false),
                    Armament = table.Column<string>(nullable: false),
                    Armor = table.Column<string>(nullable: true),
                    Beam = table.Column<double>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    Displacement = table.Column<double>(nullable: false),
                    Draft = table.Column<double>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submarines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tanks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Armament = table.Column<string>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: false),
                    FuelCapacity = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Suspension = table.Column<string>(nullable: true),
                    Transmission = table.Column<string>(nullable: true),
                    Weight = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transport",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Armament = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: true),
                    Height = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxAltitude = table.Column<double>(nullable: false),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trucks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Armament = table.Column<string>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: false),
                    FuelCapacity = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Suspension = table.Column<string>(nullable: true),
                    Transmission = table.Column<string>(nullable: true),
                    Weight = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trucks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UAV",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Armament = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: true),
                    Height = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxAltitude = table.Column<double>(nullable: false),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UAV", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utility",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Armament = table.Column<string>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<DateTime>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaxAltitude = table.Column<double>(nullable: false),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: true),
                    StartService = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utility", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AircraftCarriers");

            migrationBuilder.DropTable(
                name: "AirDefense");

            migrationBuilder.DropTable(
                name: "AmphibiousWarfare");

            migrationBuilder.DropTable(
                name: "AntiMaterial");

            migrationBuilder.DropTable(
                name: "APCs");

            migrationBuilder.DropTable(
                name: "Attack");

            migrationBuilder.DropTable(
                name: "Bomber");

            migrationBuilder.DropTable(
                name: "CommandAndControl");

            migrationBuilder.DropTable(
                name: "Cruisers");

            migrationBuilder.DropTable(
                name: "Destroyers");

            migrationBuilder.DropTable(
                name: "DMRSniperRifles");

            migrationBuilder.DropTable(
                name: "Fighter");

            migrationBuilder.DropTable(
                name: "Frigates");

            migrationBuilder.DropTable(
                name: "GroundAttack");

            migrationBuilder.DropTable(
                name: "Gunship");

            migrationBuilder.DropTable(
                name: "Howitzers");

            migrationBuilder.DropTable(
                name: "IFVs");

            migrationBuilder.DropTable(
                name: "MachineGuns");

            migrationBuilder.DropTable(
                name: "Mortars");

            migrationBuilder.DropTable(
                name: "Observation");

            migrationBuilder.DropTable(
                name: "Pistols");

            migrationBuilder.DropTable(
                name: "RiflesAndCarbines");

            migrationBuilder.DropTable(
                name: "RocketArtillery");

            migrationBuilder.DropTable(
                name: "Shotguns");

            migrationBuilder.DropTable(
                name: "SubmachineGuns");

            migrationBuilder.DropTable(
                name: "Submarines");

            migrationBuilder.DropTable(
                name: "Tanks");

            migrationBuilder.DropTable(
                name: "Transport");

            migrationBuilder.DropTable(
                name: "Trucks");

            migrationBuilder.DropTable(
                name: "UAV");

            migrationBuilder.DropTable(
                name: "Utility");
        }
    }
}
