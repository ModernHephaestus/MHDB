using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MHDB.Models.DatabaseItems
{
    [Table("Aircraft")]
    internal class FixedWingAircraft : GenericHardware
    {
        //Weight is in kg, kilograms.
        public double Weight { get; set; }
        //Length, Width, and Height are in m, meters.
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public string Engine { get; set; }
        public string Armament { get; set; }
        //MaxSpeed is in km/h, kilometers per hour.
        public double MaxSpeed { get; set; }
        //MaxAltitude is in km, kilometers.
        public double MaxAltitude { get; set; }
    }
    internal class Fighter : FixedWingAircraft
    {

    }
    internal class GroundAttack : FixedWingAircraft
    {

    }
    internal class Gunship : FixedWingAircraft
    {

    }
    internal class Bomber : FixedWingAircraft
    {

    }
    internal class Transport : FixedWingAircraft
    {

    }
    internal class CommandAndControl : FixedWingAircraft
    {

    }
    internal class UAV : FixedWingAircraft
    {

    }
}
