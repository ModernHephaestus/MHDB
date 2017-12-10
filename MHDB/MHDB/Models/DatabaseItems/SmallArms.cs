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

        public SmallArms() : base()
        {
            this.Weight = 0;
            this.Length = 0;
            this.BarrelLength = 0;
            this.Cartridge = "";
            this.Calibre = "";
            this.RateOfFire = 0;
            this.MuzzleVelocity = 0;
            this.EffectiveRange = 0;
            this.MaxRange = 0;
            this.FeedSystem = "";
            this.Sights = "";
        }

        public static bool operator >(SmallArms A, SmallArms B)
        {
            int valA = 0;
            int valB = 0;

            if (A.Weight < B.Weight)
                valA += 1;
            else
                valB += 1;

            if (A.RateOfFire > B.RateOfFire)
                valA += 1;
            else
                valB += 1;

            if (A.MuzzleVelocity > B.MuzzleVelocity)
                valA += 1;
            else
                valB += 1;

            if (A.EffectiveRange > B.EffectiveRange)
                valA += 1;
            else
                valB += 1;

            if (A.MaxRange > B.MaxRange)
                valA += 1;
            else
                valB += 1;
            
            return valA > valB;

        }
        public static bool operator <(SmallArms A, SmallArms B)
        {
            int valA = 0;
            int valB = 0;

            if (A.Weight > B.Weight)
                valA += 1;
            else
                valB += 1;

            if (A.RateOfFire < B.RateOfFire)
                valA += 1;
            else
                valB += 1;

            if (A.MuzzleVelocity < B.MuzzleVelocity)
                valA += 1;
            else
                valB += 1;

            if (A.EffectiveRange < B.EffectiveRange)
                valA += 1;
            else
                valB += 1;

            if (A.MaxRange < B.MaxRange)
                valA += 1;
            else
                valB += 1;

            return valA < valB;
        }
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
