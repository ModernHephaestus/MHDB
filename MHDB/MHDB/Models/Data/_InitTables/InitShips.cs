using MHDB.Models.Data.Ships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHDB.Models.Data
{
    internal class InitShips
    {
        internal static void ShipsInit()
        {
            AddAircraftCarriers.InitAircraftCarriers();
            AddAmphibiousWarfare.InitAmphibiousWarfare();
            AddCruisers.InitCruisers();
            AddDestroyers.InitDestroyers();
            AddFrigates.InitFrigates();
            AddSubmarines.InitSubmarines();
        }
    }
}
