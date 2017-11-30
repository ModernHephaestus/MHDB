﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MHDB.Migrations
{
    public partial class Inheritance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artillery",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Carriage = table.Column<string>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<string>(nullable: true),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: false),
                    MaximumElevation = table.Column<double>(nullable: false),
                    MinimumElevation = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    RateOfFire = table.Column<double>(nullable: false),
                    Shell = table.Column<string>(nullable: true),
                    StartProduction = table.Column<string>(nullable: false),
                    StartService = table.Column<string>(nullable: false),
                    _ArtilleryType = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artillery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FixedWingAircraft",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Armament = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<string>(nullable: true),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: true),
                    Height = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: false),
                    MaxAltitude = table.Column<double>(nullable: false),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: false),
                    StartService = table.Column<string>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false),
                    _AircraftType = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixedWingAircraft", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HelicopterRotorcraft",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Armament = table.Column<string>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<string>(nullable: true),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: false),
                    MaxAltitude = table.Column<double>(nullable: false),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: false),
                    StartService = table.Column<string>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false),
                    _HelicopterType = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HelicopterRotorcraft", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ships",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AircraftNo = table.Column<double>(nullable: false),
                    Armament = table.Column<string>(nullable: false),
                    Armor = table.Column<string>(nullable: true),
                    Beam = table.Column<double>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<string>(nullable: true),
                    Displacement = table.Column<double>(nullable: false),
                    Draft = table.Column<double>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: false),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: false),
                    StartService = table.Column<string>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    _ShipType = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SmallArms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Action = table.Column<string>(nullable: true),
                    BarrelLength = table.Column<double>(nullable: false),
                    Calibre = table.Column<string>(nullable: true),
                    Cartridge = table.Column<string>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<string>(nullable: true),
                    EffectiveRange = table.Column<double>(nullable: false),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    FeedSystem = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: false),
                    MaxRange = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    MuzzleVelocity = table.Column<double>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    RateOfFire = table.Column<double>(nullable: false),
                    Sights = table.Column<string>(nullable: true),
                    StartProduction = table.Column<string>(nullable: false),
                    StartService = table.Column<string>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    _FirearmType = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmallArms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Armament = table.Column<string>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    Designed = table.Column<string>(nullable: true),
                    EndProduction = table.Column<string>(nullable: true),
                    EndService = table.Column<string>(nullable: true),
                    Engine = table.Column<string>(nullable: false),
                    FuelCapacity = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: false),
                    MaxSpeed = table.Column<double>(nullable: false),
                    ModelName = table.Column<string>(nullable: false),
                    NoBuilt = table.Column<double>(nullable: false),
                    StartProduction = table.Column<string>(nullable: false),
                    StartService = table.Column<string>(nullable: false),
                    Suspension = table.Column<string>(nullable: true),
                    Transmission = table.Column<string>(nullable: true),
                    Weight = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false),
                    _VehicleType = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artillery");

            migrationBuilder.DropTable(
                name: "FixedWingAircraft");

            migrationBuilder.DropTable(
                name: "HelicopterRotorcraft");

            migrationBuilder.DropTable(
                name: "Ships");

            migrationBuilder.DropTable(
                name: "SmallArms");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
