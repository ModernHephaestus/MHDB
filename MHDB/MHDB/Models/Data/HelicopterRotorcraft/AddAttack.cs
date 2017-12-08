using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;
namespace MHDB.Models.Data.HelicopterRotorcraft
{
    internal class AddAttack
    {
        public static void InitAttack()
        {
            using (var db = new DatabaseContext())
            {
                db.HelicopterRotorcraft.Add(new Attack { Image = "https://upload.wikimedia.org/wikipedia/commons/a/a8/Ah-1cobra_1.jpg", ModelName = "AH-1 Huey Cobra", Manufacturer = "Bell Helicopter", StartService = "1967", EndService = "Present", Designed = "1965", StartProduction = "1967", EndProduction = "Present", NoBuilt = 1116, Cost = 11300000, Weight = 2630, Length = 16.2, Width = 13.4, Height = 4.12, Armament = "2 Miniguns or 2 M129 Grenade Launchers, Multiple 70mm Rockets and a M18 Minigun pod", Engine = "1 Lycoming T53-L-13 Turboshaft 1100 shp", MaxSpeed = 277, MaxAltitude = 3475});
                db.HelicopterRotorcraft.Add(new Attack { Image = "https://upload.wikimedia.org/wikipedia/commons/6/66/AH-64D_Apache_Longbow.jpg", ModelName = "AH-64 Apache", Manufacturer = "Boeing Defense", StartService = "1986", EndService = "Present", Designed = "1970s and 1980s", StartProduction = "1983", EndProduction = "Present", NoBuilt = 2000, Cost = 35500000, Weight = 5165, Length = 17.73, Width = 14.63, Height = 3.87, Armament = "1 30mm M230 Chain Gun, Multiple hardpoints for various Missles and Rockets", Engine = "2 General Electric T700-GE-701C Turboshaft engines 1890 shp each", MaxSpeed = 293, MaxAltitude = 6400});
                db.SaveChanges();
            }
        }
    }
}
