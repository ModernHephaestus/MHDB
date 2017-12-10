using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;

namespace MHDB.Models.Data.FixedWingAircraft
{
    internal class AddTransport
    {
        public static void InitTransport()
        {
            using (var db = new DatabaseContext())
            {
                db.FixedWingAircraft.Add(new Transport { Image = "https://upload.wikimedia.org/wikipedia/commons/c/cc/Lockheed_C-130_Hercules.jpg", ModelName = "C-130 Hercules", Manufacturer = "Lockheed Martin", StartService = "1969", EndService = "Present", Designed = "1950s", StartProduction = "1954", EndProduction = "Present", NoBuilt = 2500, Cost = 30100000, Weight = 34400, Length = 29.8, Width = 40.4, Height = 11.6, Armament = "None", Engine = "4 Allison T56-A-15 Turboprops 4590 shp each", MaxSpeed = 592, MaxAltitude =  10060});
                db.FixedWingAircraft.Add(new Transport { Image = "https://upload.wikimedia.org/wikipedia/commons/b/bc/C-17_test_sortie.jpg", ModelName = "C-17 Globemaster III", Manufacturer = "McDonnel Douglas/Boeing", StartService = "1995", EndService = "Present", Designed = "1970s", StartProduction = "1991", EndProduction = "2015", NoBuilt = 279, Cost = 218000000, Weight = 128100, Length = 53, Width = 51.75, Height = 16.8, Armament = "None", Engine = "4 Pratt & Whitney F117-PW-100 Turbofan engines", MaxSpeed = 829, MaxAltitude =  13716});
                db.SaveChanges();
            }
        }
    }
}
