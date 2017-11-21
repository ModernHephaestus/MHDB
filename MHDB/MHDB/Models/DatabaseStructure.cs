using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace MHDB.Models
{
    class DatabaseContext : DbContext
    {
        public DbSet<Pistols> Pistols { get; set; }

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

    internal class Pistols
    {
        /// <summary>
        /// Each property is a column in the SQLite Database.
        /// Properties must be public for the Entity Framework SQLite to work.
        /// As the whole class is internal, each public property in the class is also, in effect, internal.
        /// </summary>   
        [Key]
        public int Id { get; set; }

        //Image URL: Must be full url, i.e. ending with name.jpg or name.png etc.
        public string Image { get; set; } = "x";
        //Model Name, such as M9, M4, M1911
        [Required]
        public string ModelName { get; set; } = "x";
        //Manufacturer Name, such as Beretta, or Colt
        [Required]
        public string Manufacturer { get; set; } = "x";
        //Designed Date, usually simply a year or decade like 1988 or 1980s
        public string Designed { get; set; } = "x";

        //1st = start service year, 2nd = end service year (present if still in use)
        //public Tuple<string, string> Service { get; set; } = Tuple.Create("x", "x");
        //1st = start production year, 2nd = end production year (present if still being produced)
        //public Tuple<string, string> Production { get; set; } = Tuple.Create("x", "x");

        //public string ServiceStart { get; set; }
        //public string ServiceEnd { get; set; }
        //public string ProductionStart { get; set; }
        //public string ProductionEnd { get; set; }

        Pistols()
        {
            Image = "X";
        }
    }
}
