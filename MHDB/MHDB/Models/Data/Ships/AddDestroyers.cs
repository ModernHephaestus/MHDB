using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;

namespace MHDB.Models.Data.Ships
{
    internal class AddDestroyers
    {
        public static void InitDestroyers()
        {
            using (var db = new DatabaseContext())
            {
                db.Ships.Add(new Destroyers { Image = "https://upload.wikimedia.org/wikipedia/commons/4/49/PHIBRON-MEU_integrated_training_130920-N-NX070-025.jpg", ModelName = "Arleigh Burke-Class Destroyer", Manufacturer = "Bath Iron Works", StartService = "1991", EndService = "Present", Designed = "1980s", StartProduction = "1988", EndProduction = "Present", NoBuilt = 66, Cost = 1843000000, Length = 155, Beam = 20, Draft = 9.3, Displacement = 9600, Armament = "96 cell Mk41 Vertical Launching System, 2 Mk141 Harpoon missile launcher", Armor = "Unknown", Engine = "4 General Electric LM2500 gas turbines, 26250 bhp each", MaxSpeed = 56, AircraftNo = 2 });
                db.Ships.Add(new Destroyers { Image = "https://upload.wikimedia.org/wikipedia/commons/3/32/Future_USS_Zumwalt%27s_first_underway_at_sea.jpg", ModelName = "Zumwalt-Class Destroyer", Manufacturer = "Bath Iron Works", StartService = "2016", EndService = "Present", Designed = "2010s", StartProduction = "2011", EndProduction = "Present", NoBuilt = 2, Cost = 3960000000, Length = 180, Beam = 24.6, Draft = 8.4, Displacement = 14564, Armament = "80 cells 20 Mk57 VLS modules, 2 155mm Advanced Gun System, 2 30mm Mk46 Mod 2 Gun Weapon System", Armor = "Unknown", Engine = "2 Rolls-Royce MT30 gas turbines, 47500 hp each", MaxSpeed = 56, AircraftNo = 4 });
                db.SaveChanges();
            }
        }
    }
}
