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

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Artillery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BarrelLength");

                    b.Property<string>("Carriage");

                    b.Property<double?>("Cost");

                    b.Property<double>("Crew");

                    b.Property<string>("Designed");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer")
                        .IsRequired();

                    b.Property<double>("MaximumElevation");

                    b.Property<double>("MinimumElevation");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double?>("NoBuilt");

                    b.Property<double>("RateOfFire");

                    b.Property<string>("Shell");

                    b.Property<string>("StartProduction")
                        .IsRequired();

                    b.Property<string>("StartService")
                        .IsRequired();

                    b.Property<double>("Weight");

                    b.Property<string>("_ArtilleryType")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Artillery");

                    b.HasDiscriminator<string>("_ArtilleryType").HasValue("Artillery");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.FixedWingAircraft", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Armament");

                    b.Property<double?>("Cost");

                    b.Property<string>("Designed");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine");

                    b.Property<double>("Height");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer")
                        .IsRequired();

                    b.Property<double>("MaxAltitude");

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double?>("NoBuilt");

                    b.Property<string>("StartProduction")
                        .IsRequired();

                    b.Property<string>("StartService")
                        .IsRequired();

                    b.Property<double>("Weight");

                    b.Property<double>("Width");

                    b.Property<string>("_AircraftType")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Aircraft");

                    b.HasDiscriminator<string>("_AircraftType").HasValue("FixedWingAircraft");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.HelicopterRotorcraft", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Armament")
                        .IsRequired();

                    b.Property<double?>("Cost");

                    b.Property<string>("Designed");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine")
                        .IsRequired();

                    b.Property<double>("Height");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer")
                        .IsRequired();

                    b.Property<double>("MaxAltitude");

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double?>("NoBuilt");

                    b.Property<string>("StartProduction")
                        .IsRequired();

                    b.Property<string>("StartService")
                        .IsRequired();

                    b.Property<double>("Weight");

                    b.Property<double>("Width");

                    b.Property<string>("_HelicopterType")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Helicopters");

                    b.HasDiscriminator<string>("_HelicopterType").HasValue("HelicopterRotorcraft");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Ships", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double?>("AircraftNo")
                        .IsRequired();

                    b.Property<string>("Armament")
                        .IsRequired();

                    b.Property<string>("Armor");

                    b.Property<double?>("Beam");

                    b.Property<double?>("Cost");

                    b.Property<string>("Designed");

                    b.Property<double?>("Displacement")
                        .IsRequired();

                    b.Property<double?>("Draft");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine");

                    b.Property<string>("Image");

                    b.Property<double?>("Length");

                    b.Property<string>("Manufacturer")
                        .IsRequired();

                    b.Property<double?>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double?>("NoBuilt");

                    b.Property<string>("StartProduction")
                        .IsRequired();

                    b.Property<string>("StartService")
                        .IsRequired();

                    b.Property<double?>("Weight");

                    b.Property<string>("_ShipType")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Ships");

                    b.HasDiscriminator<string>("_ShipType").HasValue("Ships");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.SmallArms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Action");

                    b.Property<double>("BarrelLength");

                    b.Property<string>("Calibre");

                    b.Property<string>("Cartridge")
                        .IsRequired();

                    b.Property<double?>("Cost");

                    b.Property<string>("Designed");

                    b.Property<double>("EffectiveRange");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("FeedSystem");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer")
                        .IsRequired();

                    b.Property<double?>("MaxRange");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double?>("MuzzleVelocity");

                    b.Property<double?>("NoBuilt");

                    b.Property<double?>("RateOfFire");

                    b.Property<string>("Sights");

                    b.Property<string>("StartProduction")
                        .IsRequired();

                    b.Property<string>("StartService")
                        .IsRequired();

                    b.Property<double>("Weight");

                    b.Property<string>("_FirearmType")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Small Arms");

                    b.HasDiscriminator<string>("_FirearmType").HasValue("SmallArms");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Vehicles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Armament")
                        .IsRequired();

                    b.Property<double?>("Cost");

                    b.Property<string>("Designed");

                    b.Property<string>("EndProduction");

                    b.Property<string>("EndService");

                    b.Property<string>("Engine")
                        .IsRequired();

                    b.Property<double>("FuelCapacity");

                    b.Property<double>("Height");

                    b.Property<string>("Image");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer")
                        .IsRequired();

                    b.Property<double>("MaxSpeed");

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<double?>("NoBuilt");

                    b.Property<string>("StartProduction")
                        .IsRequired();

                    b.Property<string>("StartService")
                        .IsRequired();

                    b.Property<string>("Suspension");

                    b.Property<string>("Transmission");

                    b.Property<double>("Weight");

                    b.Property<double>("Width");

                    b.Property<string>("_VehicleType")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Vehicles");

                    b.HasDiscriminator<string>("_VehicleType").HasValue("Vehicles");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.AirDefense", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.Artillery");


                    b.ToTable("Artillery");

                    b.HasDiscriminator().HasValue("AirDefense");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Howitzers", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.Artillery");


                    b.ToTable("Artillery");

                    b.HasDiscriminator().HasValue("Howitzers");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Mortars", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.Artillery");


                    b.ToTable("Artillery");

                    b.HasDiscriminator().HasValue("Mortars");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Bomber", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.FixedWingAircraft");


                    b.ToTable("Aircraft");

                    b.HasDiscriminator().HasValue("Bomber");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.CommandAndControl", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.FixedWingAircraft");


                    b.ToTable("Aircraft");

                    b.HasDiscriminator().HasValue("CommandAndControl");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Fighter", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.FixedWingAircraft");


                    b.ToTable("Aircraft");

                    b.HasDiscriminator().HasValue("Fighter");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.GroundAttack", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.FixedWingAircraft");


                    b.ToTable("Aircraft");

                    b.HasDiscriminator().HasValue("GroundAttack");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Gunship", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.FixedWingAircraft");


                    b.ToTable("Aircraft");

                    b.HasDiscriminator().HasValue("Gunship");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Transport", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.FixedWingAircraft");


                    b.ToTable("Aircraft");

                    b.HasDiscriminator().HasValue("Transport");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.UAV", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.FixedWingAircraft");


                    b.ToTable("Aircraft");

                    b.HasDiscriminator().HasValue("UAV");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Attack", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.HelicopterRotorcraft");


                    b.ToTable("Helicopters");

                    b.HasDiscriminator().HasValue("Attack");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Observation", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.HelicopterRotorcraft");


                    b.ToTable("Helicopters");

                    b.HasDiscriminator().HasValue("Observation");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Utility", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.HelicopterRotorcraft");


                    b.ToTable("Helicopters");

                    b.HasDiscriminator().HasValue("Utility");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.AircraftCarriers", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.Ships");


                    b.ToTable("Ships");

                    b.HasDiscriminator().HasValue("AircraftCarriers");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.AmphibiousWarfare", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.Ships");


                    b.ToTable("Ships");

                    b.HasDiscriminator().HasValue("AmphibiousWarfare");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Cruisers", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.Ships");


                    b.ToTable("Ships");

                    b.HasDiscriminator().HasValue("Cruisers");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Destroyers", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.Ships");


                    b.ToTable("Ships");

                    b.HasDiscriminator().HasValue("Destroyers");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Frigates", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.Ships");


                    b.ToTable("Ships");

                    b.HasDiscriminator().HasValue("Frigates");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Submarines", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.Ships");


                    b.ToTable("Ships");

                    b.HasDiscriminator().HasValue("Submarines");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.AntiMaterial", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.SmallArms");


                    b.ToTable("Small Arms");

                    b.HasDiscriminator().HasValue("AntiMaterial");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.DMRSniperRifles", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.SmallArms");


                    b.ToTable("Small Arms");

                    b.HasDiscriminator().HasValue("DMRSniperRifles");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.MachineGuns", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.SmallArms");


                    b.ToTable("Small Arms");

                    b.HasDiscriminator().HasValue("MachineGuns");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Pistols", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.SmallArms");


                    b.ToTable("Small Arms");

                    b.HasDiscriminator().HasValue("Pistols");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.RiflesAndCarbines", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.SmallArms");


                    b.ToTable("Small Arms");

                    b.HasDiscriminator().HasValue("RiflesAndCarbines");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Shotguns", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.SmallArms");


                    b.ToTable("Small Arms");

                    b.HasDiscriminator().HasValue("Shotguns");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.SubmachineGuns", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.SmallArms");


                    b.ToTable("Small Arms");

                    b.HasDiscriminator().HasValue("SubmachineGuns");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.APCs", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.Vehicles");


                    b.ToTable("Vehicles");

                    b.HasDiscriminator().HasValue("APCs");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.IFVs", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.Vehicles");


                    b.ToTable("Vehicles");

                    b.HasDiscriminator().HasValue("IFVs");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Tanks", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.Vehicles");


                    b.ToTable("Vehicles");

                    b.HasDiscriminator().HasValue("Tanks");
                });

            modelBuilder.Entity("MHDB.Models.DatabaseItems.Trucks", b =>
                {
                    b.HasBaseType("MHDB.Models.DatabaseItems.Vehicles");


                    b.ToTable("Vehicles");

                    b.HasDiscriminator().HasValue("Trucks");
                });
        }
    }
}
