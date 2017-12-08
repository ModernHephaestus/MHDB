using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;

namespace MHDB.Models.Data.SmallArms
{
    internal class AddPistols
    {
        public static void InitPistols()
        {
            using (var db = new DatabaseContext())
            {
                db.SmallArms.Add(new Pistols { Image = "https://upload.wikimedia.org/wikipedia/commons/6/61/M9-pistolet.jpg", ModelName = "M9", Manufacturer = "Beretta", StartService = "1985", EndService = "Present", Designed = "1980", StartProduction = "1990", EndProduction = "Present", Weight = 0.97, Length = 217, BarrelLength = 125, Cartridge = "9x19mm Parabellum", Action = "Short Recoil", MuzzleVelocity = 381, EffectiveRange = 100, MaxRange = 200, FeedSystem = "15-round detachable box magazine", Sights = "Iron sights" });
                db.SmallArms.Add(new Pistols { Image = "https://upload.wikimedia.org/wikipedia/commons/2/26/M1911A1.png", ModelName = "M1911", Manufacturer = "Colt", StartService = "1911", EndService = "Present", Designed = "1911", StartProduction = "1911", EndProduction = "Present", NoBuilt = 2700000, Weight = 1.105, Length = 210, BarrelLength = 127, Cartridge = ".45 APC", Action = "Short recoil operation", MuzzleVelocity = 253, FeedSystem = "7 round standard detachable box magazine", Sights = "Iron sights" });
                db.SmallArms.Add(new Pistols { Image = "https://upload.wikimedia.org/wikipedia/commons/2/2e/Luger_P08_%286971793777%29.jpg", ModelName = "P08", Manufacturer = "Deutsche Waffen- und Munitionsfabriken", StartService = "1904", Designed = "1898", EndService = "1945", StartProduction = "1900", EndProduction = "1942", Weight = 0.871, Length = 0.222, BarrelLength = 100, Cartridge = "9x19mm Parabellum", Action = "Toggle-locked, short recoil", MuzzleVelocity = 400, EffectiveRange = 50, MaxRange = 50, FeedSystem = "8-round detachable box magazine", Sights = "Iron sights" });
                db.SmallArms.Add(new Pistols { Image = "https://upload.wikimedia.org/wikipedia/commons/9/9a/TT-33_2.JPG", ModelName = "TT-33", Manufacturer = "Tula Arsenal", StartService = "1930", EndService = "Present", Designed = "1930", StartProduction = "1930", EndProduction = "1952", NoBuilt = 1700000, Weight = 0.854, Length = 194, BarrelLength = 116, Cartridge = "7.62x25mm Tokarev", Action = "Short recoil actuated, locked breech, single action", MuzzleVelocity = 450, EffectiveRange = 50, MaxRange = 50, FeedSystem = "8-round detachable box magazine", Sights = "Iron sights" });
                db.SaveChanges();
            }
        }
    }
}
