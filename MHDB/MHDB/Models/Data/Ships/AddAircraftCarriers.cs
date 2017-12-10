using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;
namespace MHDB.Models.Data.Ships
{
    internal class AddAircraftCarriers
    {
        public static void InitAircraftCarriers()
        {
            using (var db = new DatabaseContext())
            {
                db.Ships.Add(new AircraftCarriers { Image = "https://upload.wikimedia.org/wikipedia/commons/8/81/USS_Nimitz_in_Victoria_Canada_036.jpg", ModelName = "Nimitz-class", Manufacturer = "Newport News Shipbuilding Company", StartService = "1975", EndService = "Present", Designed = "", StartProduction = "1968", EndProduction = "2006", NoBuilt = 10, Cost = 8500000000, Length = 332.8, Beam = 76.8, Draft = 11.3, Displacement = 104600, Armament = "16-24 RIM-7 Sea Sparrow Missiles, 3/4 Phalanx CIWSs", Armor = "64mm Kevlar over vital spaces", Engine = "2 Westinghouse A4W nuclear reactors", MaxSpeed = 56, AircraftNo = 90});
                db.Ships.Add(new AircraftCarriers { Image = "https://upload.wikimedia.org/wikipedia/commons/b/b5/Bow_view_of_USS_Gerald_R._Ford_%28CVN-78%29_underway_on_8_April_2017.JPG", ModelName = "Gerald R. Forcd Class", Manufacturer = "Newport News Shipbuilding", StartService = "2017", EndService = "Present", Designed = "1990s", StartProduction = "2009", EndProduction = "Present", NoBuilt = 1, Cost = 10440000000, Length = 337, Beam = 78, Draft = 12, Displacement = 100000, Armament = "2 RIM-162 ESSM Launchers, 2 RIM-116 RAM, 3 Phalanx CIWS, 4 M2 .50 Cal Machine Guns", Armor = "Unknown", Engine = "2 A1B Nuclear Reactors", MaxSpeed = 56, AircraftNo = 75});
                db.SaveChanges();
            }
        }
    }
}
