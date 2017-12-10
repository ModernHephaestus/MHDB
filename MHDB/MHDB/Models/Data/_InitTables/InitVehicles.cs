using MHDB.Models.Data.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHDB.Models.Data
{
    internal class InitVehicles
    {
        internal static void VehiclesInit()
        {
            AddAPCs.InitAPCs();
            AddIFVs.InitIFVs();
            AddTanks.InitTanks();
            AddTrucks.InitTrucks();
        }
    }
}
