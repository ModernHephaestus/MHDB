using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;

namespace MHDB.Models.Data.Ships
{
    internal class AddSubmarines
    {
        public static void InitSubmarines()
        {
            using (var db = new DatabaseContext())
            {
                db.Ships.Add(new Submarines { Image = "https://upload.wikimedia.org/wikipedia/commons/b/bb/US_Navy_040730-N-1234E-002_PCU_Virginia_%28SSN_774%29_returns_to_the_General_Dynamics_Electric_Boat_shipyard.jpg", ModelName = "Virginia-class Fast Attack Submarine", Manufacturer = "General Dynamics, Newport News Shipbuilding", StartService = "2004", EndService = "Present", Designed = "1990s-2000s", StartProduction = "2000", EndProduction = "Present", NoBuilt = 16, Cost = 2688000000, Length = 115, Beam = 10, Displacement = 7800, Armament = "12 VLS tubes, 4 533mm Mk-48 torpedo tubes, 37 torpedoes & missiles", Armor = "Unknown", Engine = "S9G Reactor, 40,000 shp", MaxSpeed = 46, AircraftNo = 0 });
                db.Ships.Add(new Submarines { Image = "https://upload.wikimedia.org/wikipedia/commons/b/be/USS_Michigan_%28SSBN-727%29.jpg", ModelName = "Ohio-Class Ballistic Missile Submarine", Manufacturer = "General Dynamics", StartService = "1981", EndService = "Present", Designed = "1970s", StartProduction = "1976", EndProduction = "1997", NoBuilt = 18, Length = 170, Beam = 13, Displacement = 18450, Armament = "4 533mm Mark-48 Torpedo Tubes, 24 Trident I/II Ballistic Missiles", Armor = "Unknown", Engine = "1 S8G PWR Nuclear Reactor, 2 geared Fairbanks Morse auxiliary diesel turbines, 1 325 hp auxiliary motor", MaxSpeed = 23, AircraftNo =  0 });
                db.SaveChanges();
            }
        }
    }
}
