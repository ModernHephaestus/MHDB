using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MHDB.Models.DatabaseItems
{
    [Table("Small Arms")]
    internal class SmallArms : GenericHardware
    {
        /// <summary>
        /// Each property is a column in the SQLite database table.
        /// Properties must be public for the Entity Framework SQLite to work.
        /// As the whole class is internal, each public property in the class is also, in effect, internal.
        /// </summary>  
        public const string TopLevelClass = "Firearms";
        //Weight is in Kg, kilograms.

        public double Weight { get; set; }

        //Length and barrel length are in mm, milimeters.
        
        public double Length { get; set; }
        
        public double BarrelLength { get; set; }

        [Required]
        public string Cartridge { get; set; } = "";

        public string Calibre { get; set; } = "";
        
        public string Action { get; set; }
        //Muzzle Velocity is in m/s, meters per second.
        //RateOfFire is in rounds per minute
        public double? RateOfFire { get; set; } = null;
        public double? MuzzleVelocity { get; set; }
        //Effective and Max ranges are in m, meters.
        //Effective and Max ranges are the upper bound if data source gives a range.
        public double EffectiveRange { get; set; }
        public double? MaxRange { get; set; }
        
        public string FeedSystem { get; set; }
        
        public string Sights { get; set; }
    }

    internal class Pistols : SmallArms
    {

    }
    internal class SubmachineGuns : SmallArms
    {

    }
    internal class RiflesAndCarbines : SmallArms
    {

    }
    internal class Shotguns : SmallArms
    {

    }
    internal class MachineGuns : SmallArms
    {

    }
    internal class DMRSniperRifles : SmallArms
    {

    }
    internal class AntiMaterial : SmallArms
    {

    }

}
