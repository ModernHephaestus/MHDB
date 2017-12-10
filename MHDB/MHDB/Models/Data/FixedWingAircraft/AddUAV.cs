using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;

namespace MHDB.Models.Data.FixedWingAircraft
{
    internal class AddUAV
    {
        public static void InitUAV()
        {
            using (var db = new DatabaseContext())
            {
                db.FixedWingAircraft.Add(new UAV { Image = "https://upload.wikimedia.org/wikipedia/commons/0/08/MQ-1_Predator_unmanned_aircraft.jpg", ModelName = "MQ-1 Predator", Manufacturer = "General Atomics", StartService = "1995", EndService = "Present", Designed = "1990s", StartProduction = "1995", EndProduction = "Present", NoBuilt = 75, Cost = 4030000, Weight = 512, Length = 8.22, Width = 14.8, Height = 2.1, Armament = "2 hardpoints for AGM-114 Hellfire or AIM-92 Stinger missiles, or 6 AGM-176 Griffin Air-to-surface missiles", Engine = "1 Rotax 914F Turbocharged engine 115 hp", MaxSpeed = 217, MaxAltitude = 7620});
                db.FixedWingAircraft.Add(new UAV { Image = "https://upload.wikimedia.org/wikipedia/commons/9/9d/Global_Hawk_1.jpg", ModelName = "RQ-4 Global Hawk", Manufacturer = "Northrop Grumman", StartService = "2001", EndService = "Present", Designed = "1990s", StartProduction = "1998", EndProduction = "Present", NoBuilt = 42, Cost = 131400000, Weight = 6781, Length = 14.5, Width = 39.9, Height = 4.7, Armament = "None", Engine = "1 Rolls-Royce F137-RR-100 Turbofan engine.", MaxSpeed = 629, MaxAltitude = 18000});
                db.SaveChanges();
            }
        }
    }
}
