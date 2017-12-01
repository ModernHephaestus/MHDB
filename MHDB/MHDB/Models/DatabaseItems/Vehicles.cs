using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MHDB.Models.DatabaseItems
{
    [Table("Vehicles")]
    internal class Vehicles : GenericHardware
    {
        public const string TopLevelClass = "Ground Vehicles";
        //Weight is in kg, kilograms.
        public double Weight { get; set; }
        //Length, Width, and Height are in m, meters.
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        [Required]
        public string Armament { get; set; }
        [Required]
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string Suspension { get; set; }
        //FuelCapacity is in L, litres
        public double FuelCapacity { get; set; }
        //MaxSpeed is in km/h, kilometers per hour.
        public double MaxSpeed { get; set; }
    }
    internal class Trucks : Vehicles
    {

    }
    internal class APCs : Vehicles
    {

    }
    internal class IFVs : Vehicles
    {

    }
    internal class Tanks : Vehicles
    {

    }
}
