using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MHDB.Models.Data.SmallArms;
using MHDB.Models.Data.Artillery;
using MHDB.Models.Data.Vehicles;
using MHDB.Models.Data.FixedWingAircraft;
using MHDB.Models.Data.HelicopterRotorcraft;
using MHDB.Models.Data.Ships;
namespace MHDB.Models.Data
{
    internal class InitializeData
    {
        internal static void InitializeDatabase()
        {
            //SmallArms
            InitSmallArms.SmallArmsInit();
            //Artillery
            InitArtillery.ArtilleryInit();
            //AddRocketArtillery.InitRocketArtillery();
            //Vehicles
            InitVehicles.VehiclesInit();
            //FixeWingAircraft
            InitAircraft.AircraftInit();
            //HelicopterRotorcraft
            InitHelicopters.HelicoptersInit();
            //Ships
            InitShips.ShipsInit();
        }
    }
}
