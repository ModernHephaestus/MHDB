using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;

namespace MHDB.Models.Data.Ships
{
    internal class AddCruisers
    {
        public static void InitCruisers()
        {
            using (var db = new DatabaseContext())
            {
                db.Ships.Add(new Cruisers { Image = "https://upload.wikimedia.org/wikipedia/commons/0/07/US_Navy_100304-N-6006S-046_The_Ticonderoga-class_guided-missile_cruiser_USS_Bunker_Hill_%28CG_52%29_transits_in_the_Atlantic_Ocean.jpg", ModelName = "Ticonderoga-class Cruiser", Manufacturer = "Ingalls Shipbuilding/Bath Iron Works", StartService = "1983", EndService = "Present", Designed = "1970s", StartProduction = "1980", EndProduction = "1994", NoBuilt = 27, Length = 173, Beam = 16.8, Draft = 10.2, Displacement = 9600, Armament = "2 Mk26 Missile launchers, 68 RIM-66 SM-2, 20 RUR-5 ASROC, and 8 RGM-84 Harpoon missiles", Armor = "Limited kevlar splinter protection", Engine = "4 General Electric LM2500 gas turbine engines 80000 shp", MaxSpeed = 60, AircraftNo = 2 });
                db.Ships.Add(new Cruisers { Image = "https://upload.wikimedia.org/wikipedia/commons/f/f0/%C2%AB%D0%9C%D0%B0%D1%80%D1%88%D0%B0%D0%BB_%D0%A3%D1%81%D1%82%D0%B8%D0%BD%D0%BE%D0%B2%C2%BB.jpg", ModelName = "Slava-Class Cruiser", Manufacturer = "61 Kommunara", StartService = "1982", EndService = "Present", Designed = "1960s and 1970s", StartProduction = "1976", EndProduction = "1990", NoBuilt = 3, Length = 186.4, Beam = 20.8, Draft = 8.4, Displacement = 10000, Armament = "16 P-500 Bazalt anti-ship missiles, 64 S-300F Surface-to-Air missiles, twin AK-130 130mm L70 dual purpose guns, 6x6 AK-630 CIWS", Armor = "Splinter plating", Engine = "2 M70 cruise gas turbines and 4 M90 boost gas turbines", MaxSpeed = 59, AircraftNo = 1});
                db.SaveChanges();
            }
        }
    }
}
