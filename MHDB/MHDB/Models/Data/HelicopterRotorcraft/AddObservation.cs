using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;
namespace MHDB.Models.Data.HelicopterRotorcraft
{
    internal class AddObservation
    {
        public static void InitObservation()
        {
            using (var db = new DatabaseContext())
            {
                db.HelicopterRotorcraft.Add(new Observation { Image = "https://upload.wikimedia.org/wikipedia/commons/0/0a/OH-58D_1st_Squadron%2C_17th_Cavalry_Regiment_%28cropped%29.jpg", ModelName = "OH-58 Kiowa", Manufacturer = "Bell Helicopter", StartService = "1969", EndService = "Present", Designed = "1960s", StartProduction = "1966", EndProduction = "1989", NoBuilt = 2200, Cost = 6700000, Weight = 1737, Length = 12.85, Width = 10.67, Height = 3.91, Armament = "2 Hardpoints for Hydra 70 Rockets or 2 AGM-114 Hellfire missiles", Engine = "1 Rolls-Royse T703-AD-700A Turboshaft 650 hp", MaxSpeed = 240, MaxAltitude = 4600});
                db.HelicopterRotorcraft.Add(new Observation { Image = "https://upload.wikimedia.org/wikipedia/commons/c/c9/Rah-66.jpg", ModelName = "RAH-66 Comanche", Manufacturer = "Boeing Helicopters/Sikorsky Aircraft", StartService = "Never", EndService = "Never", Designed = "1991", StartProduction = "1996", EndProduction = "2004", NoBuilt = 2, Weight = 4218, Length = 14.28, Width = 11.90, Height = 3.37, Armament = "1 20mm XM301 Gataling Cannon, Various Missiles and Rockets", Engine = "2 LHTEC T800-LHT-801 Turboshaft engine 1563 hp", MaxSpeed = 324, MaxAltitude = 4566});
                db.SaveChanges();
            }
        }
    }
}
