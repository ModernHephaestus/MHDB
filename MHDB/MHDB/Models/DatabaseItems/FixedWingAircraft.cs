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

        public static bool operator >(FixedWingAircraft A, FixedWingAircraft B)
        {
            int valA = 0;
            int valB = 0;

            if (A.Weight < B.Weight)
                valA += 1;
            else
                valB += 1;

            if (A.Length > B.Length)
                valA += 1;
            else
                valB += 1;

            if (A.Width > B.Width)
                valA += 1;
            else
                valB += 1;

            if (A.Height > B.Height)
                valA += 1;
            else
                valB += 1;

            if (A.MaxSpeed > B.MaxSpeed)
                valA += 1;
            else
                valB += 1;

            if (A.MaxAltitude > B.MaxAltitude)
                valA += 1;
            else
                valB += 1;

            return valA > valB;

        }
        public static bool operator <(FixedWingAircraft A, FixedWingAircraft B)
        {
            int valA = 0;
            int valB = 0;


            if (A.Weight > B.Weight)
                valA += 1;
            else
                valB += 1;

            if (A.Length < B.Length)
                valA += 1;
            else
                valB += 1;

            if (A.Width < B.Width)
                valA += 1;
            else
                valB += 1;

            if (A.Height < B.Height)
                valA += 1;
            else
                valB += 1;

            if (A.MaxSpeed < B.MaxSpeed)
                valA += 1;
            else
                valB += 1;

            if (A.MaxAltitude < B.MaxAltitude)
                valA += 1;
            else
                valB += 1;

            return valA < valB;
        }

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
