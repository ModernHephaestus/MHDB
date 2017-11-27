using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using MHDB.Models.DatabaseItems;
namespace MHDB.Models
{
    internal class DatabaseContext : DbContext
    {
        public DbSet<Pistols> Pistols { get; set; }
        public DbSet<SubmachineGuns> SubmachineGuns {get; set; }
        public DbSet<RiflesAndCarbines> RiflesAndCarbines { get; set; }
        public DbSet<Shotguns> Shotguns { get; set; }
        public DbSet<MachineGuns> MachineGuns { get; set; }
        public DbSet<DMRSniperRifles> DMRSniperRifles { get; set; }
        public DbSet<AntiMaterial> AntiMaterial { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MHDB.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Pistols>().HasKey(p => new { p.Id });
            //modelBuilder.Entity<Pistols>().Property(r => new { r.ModelName }).IsRequired();
            //modelBuilder.Entity<Pistols>().Property(r => new { r.Manufacturer}).IsRequired();
        }
    }
    internal class GenericHardware
    {
        /// <summary>
        /// Each property is a column in the SQLite database table.
        /// Properties must be public for the Entity Framework SQLite to work.
        /// As the whole class is internal, each public property in the class is also, in effect, internal.
        /// </summary>   
        [Key]
        public int Id { get; set; }

        //Image URL: Must be full web url, i.e. ending with name.jpg or name.png etc.
        public string Image { get; set; } = "N/A";
        //Model Name, such as M9, M4, M1911
        [Required]
        public string ModelName { get; set; }
        //Manufacturer Name, such as Beretta, or Colt
        [Required]
        public string Manufacturer { get; set; }
        //Designed Date, usually simply a year or decade like 1988 or 1980s
        public DateTime Designed { get; set; }

        [Required]
        //public string StartService { get; set; }

        public DateTime StartService { get; set; }

        //public string EndService { get; set; } = "Present";
        private string _EndService;
        public string EndService
        {
            get { return _EndService; }
            set
            {
                if (Convert.ToInt32(value) >= DateTime.Now.Year)
                    this._EndService = "Present";
                else
                    this._EndService = value;
            }
        }

        [Required]
        public string StartProduction { get; set; }

        //public string EndProduction { get; set; } = "Present";
        private string _EndProduction;
        public string EndProduction
        {
            get { return _EndProduction; }
            set
            {
                if (Convert.ToInt32(value) >= DateTime.Now.Year)
                    this._EndProduction = "Present";
                else
                    this._EndProduction = value;
            }
        }

        public double NoBuilt { get; set; } = 0;
    }
}
