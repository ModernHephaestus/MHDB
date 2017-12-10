using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;

namespace MHDB.Models.Data.Ships
{
    internal class AddFrigates
    {
        public static void InitFrigates()
        {
            using (var db = new DatabaseContext())
            {
                db.Ships.Add(new Frigates { Image = "https://upload.wikimedia.org/wikipedia/commons/d/da/Project_1135M_Pytlivyy_2009_G1.jpg", ModelName = "Krivak-Class Frigate", Manufacturer = "Yantar Yard, Severnaya Verf, Baltik Verf, Zaliv Plant", StartService = "1970", EndService = "Present", Designed = "1960s - 1990s", StartProduction = "1968", EndProduction = "1992", NoBuilt = 40, Length = 123.5, Beam = 14.1, Draft = 4.6, Displacement = 3300, Armament = "4 URK-5 SSM/ASW missiles, 2 Osa-MA SAM systems, 4 76mm guns, 2 RBU-6000 anti-submarine rockets, 2x4 533mm torpedo tubes", Armor = "Unknown", Engine = "2 M-8k Gas Turbines, 40000 shp", MaxSpeed = 59, AircraftNo = 1 });
                db.Ships.Add(new Frigates { Image = "https://upload.wikimedia.org/wikipedia/commons/0/09/F220-Hamburg-130311-N-XQ474-229-crop.jpg", ModelName = "Sachsen-Class Frigate", Manufacturer = "Blohm + Voss, Howaldtswerke-Deutsche Werft, Nordseewerke", StartService = "2003", EndService = "Present", Designed = "1990s", StartProduction = "1999", EndProduction = "2005", NoBuilt = 3, Length = 469, Beam = 17.44, Draft = 6, Displacement = 5800, Armament = "1 OTO-Melara 76mm dual-purpose gun, 2 Mauser MLG 27 27mm autocannons, 1 VLS Tactical, 2 RAM launchers, 2x4 Harpoon ASM launchers", Armor = "Unknown", Engine = "2 MTU V20 diesel engines, 1 General Electric LM2500 gas turbine", MaxSpeed = 54, AircraftNo =  2});
                db.SaveChanges();
            }
        }
    }
}
