using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;
namespace MHDB.Models.Data.Vehicles
{
    internal class AddAPCs
    {
        public static void InitAPCs()
        {
            using (var db = new DatabaseContext())
            {
                db.Vehicles.Add(new APCs { Image = "https://upload.wikimedia.org/wikipedia/commons/3/3f/2011_Moscow_Victory_Day_Parade_%28360-06%29_%28cropped%29.jpg", ModelName = "BTR-80", Manufacturer = "Arzamas Machinery Plant", StartService = "1986", EndService = "Present", Designed = "1980s", StartProduction = "1984", EndProduction = "Present", NoBuilt = 5000, Weight = 13600, Length = 7.7, Width = 2.9, Height= 2.41, Armament= "14.5mm KPVT Machine Gun / 30mm 2A72 Automatic cannon", Engine="diesel KamAZ-7403 260 hp", Suspension="wheeled 8x8", MaxSpeed = 90});
                db.Vehicles.Add(new APCs { Image = "https://upload.wikimedia.org/wikipedia/commons/c/c9/Boxer_Land_400.jpg", ModelName = "Boxer", Manufacturer = "ARTEC GmbH", StartService = "2011", EndService = "Present", Designed = "2003", StartProduction = "2006", EndProduction = "Present", Weight = 24000, Length = 7.93, Width = 2.99, Height = 2.37, Armament = "", Engine = "MTU 8V199 TE20 Diesel 711 hp", Suspension = "wheeled independend 8x8", MaxSpeed = 103 });
                db.SaveChanges();
            }
        }
    }
}
