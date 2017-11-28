using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MHDB.Models;

namespace MHDB.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.4");

            modelBuilder.Entity("MHDB.Models.DatabaseItems.AircraftCarriers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AircraftNo");

                    b.Property<string>("Armament")
                        .IsRequired();

                    b.Property<string>("Armor");

                    b.Property<double>("Beam");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<double>("Displacement");

                    b.Property<double>("Draft");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.ToTable("AircraftCarriers");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.AirDefense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Carriage")
                        .IsRequired();

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Image");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaximumElevation");

                    b.Property<double>("MinimumElevation");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<double>("RateOfFire");

                    b.Property<string>("Shell");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.HasKey("Id");

                    b.ToTable("AirDefense");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.AmphibiousWarfare", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AircraftNo");

                    b.Property<string>("Armament")
                        .IsRequired();

                    b.Property<string>("Armor");

                    b.Property<double>("Beam");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<double>("Displacement");

                    b.Property<double>("Draft");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.ToTable("AmphibiousWarfare");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.AntiMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Action");

                    b.Property<double>("BarrelLength");

                    b.Property<string>("Calibre");

                    b.Property<string>("Cartridge");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<double>("EffectiveRange");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("FeedSystem");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxRange");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("MuzzleVelocity");

                    b.Property<double>("NoBuilt");

                    b.Property<string>("Sights")
                        .IsRequired();

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.ToTable("AntiMaterial");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.APCs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Armament")
                        .IsRequired();

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine")
                        .IsRequired();

                    b.Property<double>("FuelCapacity");

                    b.Property<double>("Height");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<string>("Suspension");

                    b.Property<string>("Transmission");

                    b.Property<double>("Weight");

                    b.Property<double>("Width");

                    b.HasKey("Id");

                    b.ToTable("APCs");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Attack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Armament")
                        .IsRequired();

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine")
                        .IsRequired();

                    b.Property<double>("Height");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxAltitude");

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<double>("Weight");

                    b.Property<double>("Width");

                    b.HasKey("Id");

                    b.ToTable("Attack");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Bomber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Armament");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine");

                    b.Property<double>("Height");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxAltitude");

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<double>("Weight");

                    b.Property<double>("Width");

                    b.HasKey("Id");

                    b.ToTable("Bomber");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.CommandAndControl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Armament");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine");

                    b.Property<double>("Height");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxAltitude");

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<double>("Weight");

                    b.Property<double>("Width");

                    b.HasKey("Id");

                    b.ToTable("CommandAndControl");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Cruisers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AircraftNo");

                    b.Property<string>("Armament")
                        .IsRequired();

                    b.Property<string>("Armor");

                    b.Property<double>("Beam");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<double>("Displacement");

                    b.Property<double>("Draft");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.ToTable("Cruisers");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Destroyers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AircraftNo");

                    b.Property<string>("Armament")
                        .IsRequired();

                    b.Property<string>("Armor");

                    b.Property<double>("Beam");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<double>("Displacement");

                    b.Property<double>("Draft");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.ToTable("Destroyers");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.DMRSniperRifles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Action");

                    b.Property<double>("BarrelLength");

                    b.Property<string>("Calibre");

                    b.Property<string>("Cartridge");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<double>("EffectiveRange");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("FeedSystem");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxRange");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("MuzzleVelocity");

                    b.Property<double>("NoBuilt");

                    b.Property<string>("Sights")
                        .IsRequired();

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.ToTable("DMRSniperRifles");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Fighter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Armament");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine");

                    b.Property<double>("Height");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxAltitude");

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<double>("Weight");

                    b.Property<double>("Width");

                    b.HasKey("Id");

                    b.ToTable("Fighter");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Frigates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AircraftNo");

                    b.Property<string>("Armament")
                        .IsRequired();

                    b.Property<string>("Armor");

                    b.Property<double>("Beam");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<double>("Displacement");

                    b.Property<double>("Draft");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.ToTable("Frigates");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.GroundAttack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Armament");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine");

                    b.Property<double>("Height");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxAltitude");

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<double>("Weight");

                    b.Property<double>("Width");

                    b.HasKey("Id");

                    b.ToTable("GroundAttack");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Gunship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Armament");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine");

                    b.Property<double>("Height");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxAltitude");

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<double>("Weight");

                    b.Property<double>("Width");

                    b.HasKey("Id");

                    b.ToTable("Gunship");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Howitzers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Carriage")
                        .IsRequired();

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Image");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaximumElevation");

                    b.Property<double>("MinimumElevation");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<double>("RateOfFire");

                    b.Property<string>("Shell");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.HasKey("Id");

                    b.ToTable("Howitzers");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.IFVs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Armament")
                        .IsRequired();

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine")
                        .IsRequired();

                    b.Property<double>("FuelCapacity");

                    b.Property<double>("Height");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<string>("Suspension");

                    b.Property<string>("Transmission");

                    b.Property<double>("Weight");

                    b.Property<double>("Width");

                    b.HasKey("Id");

                    b.ToTable("IFVs");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.MachineGuns", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Action");

                    b.Property<double>("BarrelLength");

                    b.Property<string>("Calibre");

                    b.Property<string>("Cartridge");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<double>("EffectiveRange");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("FeedSystem");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxRange");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("MuzzleVelocity");

                    b.Property<double>("NoBuilt");

                    b.Property<string>("Sights")
                        .IsRequired();

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.ToTable("MachineGuns");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Mortars", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Carriage")
                        .IsRequired();

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Image");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaximumElevation");

                    b.Property<double>("MinimumElevation");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<double>("RateOfFire");

                    b.Property<string>("Shell");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.HasKey("Id");

                    b.ToTable("Mortars");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Observation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Armament")
                        .IsRequired();

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine")
                        .IsRequired();

                    b.Property<double>("Height");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxAltitude");

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<double>("Weight");

                    b.Property<double>("Width");

                    b.HasKey("Id");

                    b.ToTable("Observation");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Pistols", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Action");

                    b.Property<double>("BarrelLength");

                    b.Property<string>("Calibre");

                    b.Property<string>("Cartridge");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<double>("EffectiveRange");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("FeedSystem");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxRange");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("MuzzleVelocity");

                    b.Property<double>("NoBuilt");

                    b.Property<string>("Sights")
                        .IsRequired();

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.ToTable("Pistols");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.RiflesAndCarbines", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Action");

                    b.Property<double>("BarrelLength");

                    b.Property<string>("Calibre");

                    b.Property<string>("Cartridge");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<double>("EffectiveRange");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("FeedSystem");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxRange");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("MuzzleVelocity");

                    b.Property<double>("NoBuilt");

                    b.Property<string>("Sights")
                        .IsRequired();

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.ToTable("RiflesAndCarbines");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.RocketArtillery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Carriage")
                        .IsRequired();

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Image");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaximumElevation");

                    b.Property<double>("MinimumElevation");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<double>("RateOfFire");

                    b.Property<string>("Shell");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.HasKey("Id");

                    b.ToTable("RocketArtillery");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Shotguns", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Action");

                    b.Property<double>("BarrelLength");

                    b.Property<string>("Calibre");

                    b.Property<string>("Cartridge");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<double>("EffectiveRange");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("FeedSystem");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxRange");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("MuzzleVelocity");

                    b.Property<double>("NoBuilt");

                    b.Property<string>("Sights")
                        .IsRequired();

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.ToTable("Shotguns");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.SubmachineGuns", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Action");

                    b.Property<double>("BarrelLength");

                    b.Property<string>("Calibre");

                    b.Property<string>("Cartridge");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<double>("EffectiveRange");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("FeedSystem");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxRange");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("MuzzleVelocity");

                    b.Property<double>("NoBuilt");

                    b.Property<string>("Sights")
                        .IsRequired();

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.ToTable("SubmachineGuns");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Submarines", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AircraftNo");

                    b.Property<string>("Armament")
                        .IsRequired();

                    b.Property<string>("Armor");

                    b.Property<double>("Beam");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<double>("Displacement");

                    b.Property<double>("Draft");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.ToTable("Submarines");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Tanks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Armament")
                        .IsRequired();

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine")
                        .IsRequired();

                    b.Property<double>("FuelCapacity");

                    b.Property<double>("Height");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<string>("Suspension");

                    b.Property<string>("Transmission");

                    b.Property<double>("Weight");

                    b.Property<double>("Width");

                    b.HasKey("Id");

                    b.ToTable("Tanks");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Transport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Armament");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine");

                    b.Property<double>("Height");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxAltitude");

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<double>("Weight");

                    b.Property<double>("Width");

                    b.HasKey("Id");

                    b.ToTable("Transport");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Trucks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Armament")
                        .IsRequired();

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine")
                        .IsRequired();

                    b.Property<double>("FuelCapacity");

                    b.Property<double>("Height");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<string>("Suspension");

                    b.Property<string>("Transmission");

                    b.Property<double>("Weight");

                    b.Property<double>("Width");

                    b.HasKey("Id");

                    b.ToTable("Trucks");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.UAV", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Armament");

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine");

                    b.Property<double>("Height");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxAltitude");

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<double>("Weight");

                    b.Property<double>("Width");

                    b.HasKey("Id");

                    b.ToTable("UAV");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Utility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Armament")
                        .IsRequired();

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Designed");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine")
                        .IsRequired();

                    b.Property<double>("Height");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<double>("MaxAltitude");

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double>("NoBuilt");

                    b.Property<string>("StartProduction");

                    b.Property<DateTime>("StartService");

                    b.Property<double>("Weight");

                    b.Property<double>("Width");

                    b.HasKey("Id");

                    b.ToTable("Utility");
                });
        }
    }
}
