using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MHDB.Models.DatabaseItems;
namespace MHDB.Models
{
    internal class DatabaseContext : DbContext
    {
        public DbSet<SmallArms> SmallArms { get; set; }
        public DbSet<Artillery> Artillery { get; set; }
        public DbSet<Vehicles> Vehicles { get; set; }
        public DbSet<FixedWingAircraft> FixedWingAircraft { get; set; }
        public DbSet<HelicopterRotorcraft> HelicopterRotorcraft { get; set; }
        public DbSet<Ships> Ships { get; set; }
        //SmallArms
        public DbSet<Pistols> Pistols { get; set; }
        public DbSet<SubmachineGuns> SubmachineGuns { get; set; }
        public DbSet<RiflesAndCarbines> RiflesAndCarbines { get; set; }
        public DbSet<Shotguns> Shotguns { get; set; }
        public DbSet<MachineGuns> MachineGuns { get; set; }
        public DbSet<DMRSniperRifles> DMRSniperRifles { get; set; }
        public DbSet<AntiMaterial> AntiMaterial { get; set; }
        //Artillery
        public DbSet<Mortars> Mortars { get; set; }
        public DbSet<Howitzers> Howitzers { get; set; }
        //public DbSet<RocketArtillery> RocketArtillery { get; set; }
        public DbSet<AirDefense> AirDefense { get; set; }
        //Vehicles
        public DbSet<Trucks> Trucks { get; set; }
        public DbSet<APCs> APCs { get; set; }
        public DbSet<IFVs> IFVs { get; set; }
        public DbSet<Tanks> Tanks { get; set; }
        //FixedWingAircraft
        public DbSet<Fighter> Fighter { get; set; }
        public DbSet<GroundAttack> GroundAttack { get; set; }
        public DbSet<Gunship> Gunship { get; set; }
        public DbSet<Bomber> Bomber { get; set; }
        public DbSet<Transport> Transport { get; set; }
        public DbSet<CommandAndControl> CommandAndControl { get; set; }
        public DbSet<UAV> UAV { get; set; }
        //HelicopterRotorcraft
        public DbSet<Attack> Attack { get; set; }
        public DbSet<Utility> Utility { get; set; }
        public DbSet<Observation> Observation { get; set; }
        //Ships
        public DbSet<AircraftCarriers> AircraftCarriers { get; set; }
        public DbSet<AmphibiousWarfare> AmphibiousWarfare { get; set; }
        public DbSet<Cruisers> Cruisers { get; set; }
        public DbSet<Destroyers> Destroyers { get; set; }
        public DbSet<Frigates> Frigates { get; set; }
        public DbSet<Submarines> Submarines { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MHDB.db");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<SmallArms>().HasDiscriminator<string>("_FirearmType");
            //modelBuilder.Entity<Artillery>().HasDiscriminator<string>("_ArtilleryType");
            //modelBuilder.Entity<Vehicles>().HasDiscriminator<string>("_VehicleType");
            //modelBuilder.Entity<FixedWingAircraft>().HasDiscriminator<string>("_AircraftType");
            //modelBuilder.Entity<HelicopterRotorcraft>().HasDiscriminator<string>("_HelicopterType");
            //modelBuilder.Entity<Ships>().HasDiscriminator<string>("_ShipType");
            modelBuilder.Entity<SmallArms>().HasDiscriminator<string>("_Type");
            modelBuilder.Entity<Artillery>().HasDiscriminator<string>("_Type");
            modelBuilder.Entity<Vehicles>().HasDiscriminator<string>("_Type");
            modelBuilder.Entity<FixedWingAircraft>().HasDiscriminator<string>("_Type");
            modelBuilder.Entity<HelicopterRotorcraft>().HasDiscriminator<string>("_Type");
            modelBuilder.Entity<Ships>().HasDiscriminator<string>("_Type");
        }
    }
    internal abstract class GenericHardware
    {
        /// <summary>
        /// Each property is a column in the SQLite database table.
        /// Properties must be public for the Entity Framework SQLite to work.
        /// As the whole class is internal, each public property in the class is also, in effect, internal.
        /// </summary>   
        [Key]
        public int Id { get; set; }

        //Image URL: Must be full web url, i.e. ending with name.jpg or name.png etc.
        public string Image { get; set; } = "";
        //Model Name, such as M9, M4, M1911
        [Required]
        public string ModelName { get; set; }
        //Manufacturer Name, such as Beretta, or Colt
        [Required]
        public string Manufacturer { get; set; }
        //Designed Date, usually simply a year or decade like 1988 or 1980s
        public string Designed { get; set; } = "";

        [Required]
        public string StartService { get; set; }
        
        
        private string _EndService;
        public string EndService
        {
            get { return _EndService; }
            set
            {
                    if (int.TryParse(value, out int temp))
                    {
                        if (Convert.ToInt32(value) >= DateTime.Now.Year)
                            this._EndService = "Present";
                        else
                            this._EndService = temp.ToString();
                    }
                    else
                    {
                        this._EndService = value;
                    }
            }
        }

        [Required]
        public string StartProduction { get; set; }
        
        private string _EndProduction;
        public string EndProduction
        {
            get { return _EndProduction; }
            set
            {
                    if (int.TryParse(value, out int temp))
                    {
                        if (Convert.ToInt32(value) >= DateTime.Now.Year)
                            this._EndProduction = "Present";
                        else
                            this._EndProduction = temp.ToString();
                    }
                    else
                    {
                        this._EndProduction = value;
                    }
            }
        }

        public double? NoBuilt { get; set; } = null;
        public double? Cost { get; set; } = null;
    }
}
