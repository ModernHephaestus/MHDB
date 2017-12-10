using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;

namespace MHDB.Models.Data.FixedWingAircraft
{
    internal class AddBomber
    {
        public static void InitBomber()
        {
            using (var db = new DatabaseContext())
            {
                db.FixedWingAircraft.Add(new Bomber { Image = "https://upload.wikimedia.org/wikipedia/commons/d/d0/Usaf.Boeing_B-52.jpg", ModelName = "B-52 Stratofortress", Manufacturer = "Boeing", StartService = "1955", EndService = "Present", Designed = "1950s", StartProduction = "1952", EndProduction = "1962", NoBuilt = 744, Cost = 310000000, Weight = 83250, Length = 48.5, Width = 56.4, Height = 12.4, Armament = "Up to 31,500 kg of mixed ordinance bombs, mines, and missiles", Engine = "8 Pratt & Whitney TF33-P-3/103 turbofan engines", MaxSpeed = 1047, MaxAltitude = 15000});
                db.FixedWingAircraft.Add(new Bomber { Image = "https://upload.wikimedia.org/wikipedia/commons/4/47/B-2_Spirit_original.jpg", ModelName = "B-2 Spirit", Manufacturer = "Northrop Grumman", StartService = "1997", EndService = "Present", Designed = "1970s and 1980s", StartProduction = "1987", EndProduction = "2000", NoBuilt = 21, Cost = 737000000, Weight = 71700, Length = 21, Width = 52.4, Height = 5.18, Armament = "2 internal bays with an 18000 limit and a mixed ordinance", Engine = "4 General Electric F118-GE-100 Turbofan engines", MaxSpeed = 1010, MaxAltitude = 15200});
                db.SaveChanges();
            }
        }
    }
}
