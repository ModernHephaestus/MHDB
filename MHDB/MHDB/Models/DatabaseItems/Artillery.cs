using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MHDB.Models.DatabaseItems
{
    [Table("Artillery")]
    internal class Artillery : GenericHardware
    {
        public const string TopLevelClass = "Artillery";
        //Shell is a comma separated list of shells used.
        public string Shell { get; set; }
        [Required]
        public string Carriage { get; set; }
        //Minimum and Maximum elevation are in degrees.
        public double MinimumElevation { get; set; }
        public double MaximumElevation { get; set; }
        //RateOfFire is in rpm, rounds per minute.
        public double RateOfFire { get; set; }
    }
    internal class Mortars : Artillery
    {

    }
    internal class Howitzers : Artillery
    {

    }
    internal class RocketArtillery : Artillery
    {

    }
    internal class AirDefense : Artillery
    {

    }
}
