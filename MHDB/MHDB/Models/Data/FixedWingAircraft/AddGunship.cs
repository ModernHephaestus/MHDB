using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;

namespace MHDB.Models.Data.FixedWingAircraft
{
    internal class AddGunship
    {
        public static void InitGunship()
        {
            using (var db = new DatabaseContext())
            {
                db.FixedWingAircraft.Add(new Gunship { Image = "https://upload.wikimedia.org/wikipedia/commons/1/1d/AC-130U_gunship_from_the_4th_Special_Operations_Squadron.jpg", ModelName = "AC-130", Manufacturer = "Lockheed Martin/Boeing", StartService = "1968", EndService = "Present", Designed = "1960s", StartProduction = "1960s", EndProduction = "Unknown", NoBuilt = 47, Cost = 210000000, Weight = 55520, Length = 29.8, Width = 40.4, Height = 11.7, Armament = "1 30mm ATK GAU-23/A autocannon, 1 105mm M102 howitzer, Various hardpoints for Milles/Bombs", Engine = "4 Allison T56-A-15 Turboprop engines 4910 shp each", MaxSpeed = 480, MaxAltitude = 9100});
                db.FixedWingAircraft.Add(new Gunship { Image = "https://upload.wikimedia.org/wikipedia/commons/7/76/AC-119G_of_17th_SOS_over_Tan_Son_Nhut_Air_Base_1969.jpg", ModelName = "AC-119G Shadow", Manufacturer = "Fairchild Aircraft", StartService = "1968", EndService = "1975", Designed = "1960s", StartProduction = "1968", EndProduction = "Unknown", NoBuilt = 52, Weight = 18200, Length = 26.36, Width = 33.31, Height = 8.12, Armament = "4 GAU-2/A 7.62mm miniguns, 2 M61 Vulcan 20mm Gatling cannons, and 60 Mk 24 Flares", Engine = "2 Wright R-33550-85 Duplex Cyclone radial engines 3500 hp each", MaxSpeed = 335, MaxAltitude = 7100});
                db.SaveChanges();
            }
        }
    }
}
