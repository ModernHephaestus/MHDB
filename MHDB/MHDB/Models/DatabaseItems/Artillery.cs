﻿using System;
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
