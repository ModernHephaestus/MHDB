using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;

namespace MHDB.Models.Data.FixedWingAircraft
{
    internal class AddCommandAndControl
    {
        public static void InitCommandAndControl()
        {
            using (var db = new DatabaseContext())
            {
                db.FixedWingAircraft.Add(new CommandAndControl { Image = "https://upload.wikimedia.org/wikipedia/commons/1/1b/E-3_Sentry_exercise_Green_Flag_2012_%28Cropped%29.jpg", ModelName = "E-3 Sentry", Manufacturer = "Boeing Defense", StartService = "1997", EndService = "Present", Designed = "1970s", StartProduction = "1977", EndProduction = "1992", NoBuilt = 68, Cost = 270000000, Weight = 73480, Length = 46.61, Width = 44.42, Height = 12.6, Armament = "None", Engine = "4 Pratt and Whitney TF33-PW-100A Turbofan engines", MaxSpeed = 855, MaxAltitude = 12500});
                db.FixedWingAircraft.Add(new CommandAndControl { Image = "https://upload.wikimedia.org/wikipedia/commons/d/d8/USN_E-2C_Scewtops.jpg", ModelName = "E-2 Hawkeye", Manufacturer = "Northrop Grumman", StartService = "1964", EndService = "Present", Designed = "1950s", StartProduction = "1960", EndProduction = "Present", Cost = 176000000, Weight = 18090, Length = 17.6, Width = 24.56, Height = 5.58, Armament = "", Engine = "2 Rolls-Royce T56-A-427 Turboprop engines", MaxSpeed = 648, MaxAltitude = 10576});
                db.SaveChanges();
            }
        }
    }
}
