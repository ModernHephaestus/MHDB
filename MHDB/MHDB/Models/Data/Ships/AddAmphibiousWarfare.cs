using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;

namespace MHDB.Models.Data.Ships
{
    internal class AddAmphibiousWarfare
    {
        public static void InitAmphibiousWarfare()
        {
            using (var db = new DatabaseContext())
            {
                db.Ships.Add(new AmphibiousWarfare { Image = "https://upload.wikimedia.org/wikipedia/commons/6/60/USS_Wasp_%28LHD_1%29.jpg", ModelName = "Wasp Class Amphibious Assault Ship", Manufacturer = "Ingalls Shipbuilding", StartService = "1989", EndService = "Present", Designed = "1970s and 1980s", StartProduction = "1985", EndProduction = "2006", NoBuilt = 8, Length = 257, Beam = 31.8, Draft = 8.1, Displacement = 40500, Armament = "4 RIM-116/RIM-7 Missile Launchers, 3 Phalanx CIWSs, 25mm Mk38 chain guns, 4 .50 BMG machine Guns", Armor = "Unknown", Engine = "2 General Electric LM2500 geared Gas Turbines", MaxSpeed = 41, AircraftNo = 22 });
                db.Ships.Add(new AmphibiousWarfare { Image = "https://upload.wikimedia.org/wikipedia/commons/4/46/US_Navy_110609-N-VL218-336_The_amphibious_transport_dock_ships_USS_San_Antonio_%28LPD_17%29_and_USS_New_York_%28LPD_21%29_are_underway_together_in_the_Atla.jpg", ModelName = "San Antonio-Class Amphibibious Transport Dock", Manufacturer = "Huntington Ingalls Industries", StartService = "2006", EndService = "Present", Designed = "1990s and 2000s", StartProduction = "2000", EndProduction = "Present", NoBuilt = 10, Cost = 2021000000, Length = 208, Beam = 32, Draft = 7, Displacement = 25300, Armament = "2 BUshmaster II 30mm close-in guns, Two Rolling Airframe Missile launchers, 2 Mk 41 VLS", Armor = "Unknown", Engine = "4 Colt-Pielstick diesel engines, 41600 shp", MaxSpeed = 41, AircraftNo = 5 });
                db.SaveChanges();
            }
        }
    }
}
