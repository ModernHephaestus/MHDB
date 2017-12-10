using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;

namespace MHDB.Models.Data.FixedWingAircraft
{
    internal class AddFighter
    {
        public static void InitFighter()
        {
            using (var db = new DatabaseContext())
            {
                db.FixedWingAircraft.Add(new Fighter { Image = "https://upload.wikimedia.org/wikipedia/commons/c/c9/F-16_June_2008.jpg", ModelName = "F-16 Fighting Falcon", Manufacturer = "General Dynamics/Lockheed Martin", StartService = "1978", EndService = "Present", Designed = "1970s", StartProduction = "1973", EndProduction = "Present", NoBuilt = 4573, Cost = 18800000, Weight = 8570, Length = 15.06, Width = 9.96, Height = 4.88, Armament = "1 20mm M61A1 Vulcan cannon, 11 Missile/Rocket/Bomb hardpoints", Engine = "1 General Electric F110-GE-129 Afterburning turbofan engine", MaxSpeed = 1470, MaxAltitude = 15240});
                db.FixedWingAircraft.Add(new Fighter { Image = "https://upload.wikimedia.org/wikipedia/commons/6/64/RSAF_Typhoon_at_Malta_-_Gordon_Zammit.jpg", ModelName = "Eurofighter Typhoon", Manufacturer = "Eurofighter Jagdflugzeug GmbH", StartService = "2003", EndService = "Present", Designed = "1990s", StartProduction = "1994", EndProduction = "Present", NoBuilt = 599, Cost = 106000000, Weight = 11000, Length = 15.96, Width = 10.95, Height = 5.28, Armament = "1 27mm Mauser BK-27 Revolver Cannon, 13 Missile/Bomb hardpoints", Engine = "2 Eurojet EJ200 Afterburning Turbofan engines", MaxSpeed = 2495, MaxAltitude = 19812});
                db.SaveChanges();
            }
        }
    }
}
