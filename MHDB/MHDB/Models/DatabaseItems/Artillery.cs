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

        public double Crew { get; set; }

        //Shell is a comma separated list of shells used.
        public string Shell { get; set; }
        public string Carriage { get; set; }
        //Minimum and Maximum elevation are in degrees.
        public double MinimumElevation { get; set; }
        public double MaximumElevation { get; set; }
        //RateOfFire is in rpm, rounds per minute.
        public double RateOfFire { get; set; }

        public static bool operator >(Artillery A, Artillery B)
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

            if (A.BarrelLength > B.BarrelLength)
                valA += 1;
            else
                valB += 1;

            if (A.Crew < B.Crew)
                valA += 1;
            else
                valB += 1;

            if (A.MinimumElevation < B.MinimumElevation)
                valA += 1;
            else
                valB += 1;

            if (A.MaximumElevation > B.MaximumElevation)
                valA += 1;
            else
                valB += 1;
            if (A.RateOfFire > B.RateOfFire)
                valA += 1;
            else
                valB += 1;

            return valA > valB;

        }
        public static bool operator <(Artillery A, Artillery B)
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

            if (A.BarrelLength < B.BarrelLength)
                valA += 1;
            else
                valB += 1;

            if (A.Crew > B.Crew)
                valA += 1;
            else
                valB += 1;

            if (A.MinimumElevation > B.MinimumElevation)
                valA += 1;
            else
                valB += 1;

            if (A.MaximumElevation < B.MaximumElevation)
                valA += 1;
            else
                valB += 1;
            if (A.RateOfFire < B.RateOfFire)
                valA += 1;
            else
                valB += 1;

            return valA < valB;
        }

    }
    internal class Mortars : Artillery
    {

    }
    internal class Howitzers : Artillery
    {

    }
    //internal class RocketArtillery : Artillery
    //{

    //}
    internal class AirDefense : Artillery
    {

    }
}
