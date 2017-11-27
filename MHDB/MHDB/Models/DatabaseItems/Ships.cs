using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MHDB.Models.DatabaseItems
{
    internal class Ships
    {
        //Weight is in kg, kilograms.
        public double Weight { get; set; }
        //Length, Width, and Height are in m, meters.
        public double Length { get; set; }
        //Beam is like width.
        public double Beam { get; set; }
        //Draft is height under the waterline
        public double Draft { get; set; }
        //Displacement is in long tons.
        [Required]
        public double Displacement { get; set; }

        public string Engine { get; set; }
        [Required]
        public string Armament { get; set; }
        public string Armor { get; set; }
        [Required]
        public double AircraftNo { get; set; }
        //MaxSpeed is in km/h, kilometers per hour.
        public double MaxSpeed { get; set; }

    }
    internal class AircraftCarriers : Ships
    {

    }
    internal class AmphibiousWarfare : Ships
    {

    }
    internal class Cruisers : Ships
    {

    }
    internal class Destroyers : Ships
    {

    }
    internal class Frigates : Ships
    {

    }
    internal class Submarines : Ships
    {

    }
}
