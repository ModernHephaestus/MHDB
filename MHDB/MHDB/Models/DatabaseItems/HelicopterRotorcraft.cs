using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MHDB.Models.DatabaseItems
{
    internal class HelicopterRotorcraft : GenericHardware
    {
        //Weight is in kg, kilograms.
        public double Weight { get; set; }
        //Length, Width, and Height are in m, meters.
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        [Required]
        public string Engine { get; set; }
        [Required]
        public string Armament { get; set; }
        //MaxSpeed is in km/h, kilometers per hour.
        public double MaxSpeed { get; set; }
        //MaxAltitude is in km, kilometers.
        public double MaxAltitude { get; set; }
    }
    internal class Attack : HelicopterRotorcraft
    {

    }
    internal class Utility : HelicopterRotorcraft
    {

    }
    internal class Observation : HelicopterRotorcraft
    {

    }
}
