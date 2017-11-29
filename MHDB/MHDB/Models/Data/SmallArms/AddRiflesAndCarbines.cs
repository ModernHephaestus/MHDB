using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;
namespace MHDB.Models.Data.SmallArms
{
    internal class AddRiflesAndCarbines
    {
        public static void InitRiflesAndCarbines()
        {
            using (var db = new DatabaseContext())
            {
                db.RiflesAndCarbines.Add(new RiflesAndCarbines { Image = "https://upload.wikimedia.org/wikipedia/commons/a/a7/M4A1_ACOG.jpg", ModelName = "M4", Manufacturer = "FN Herstal", StartService = "1994", EndService = "Present", Designed = "1984", StartProduction = "1993", EndProduction = "Present", Cost = 700, Weight = 2.9, Length = 840, BarrelLength = 370, Cartridge = "5.56x45mm NATO", Calibre = "5.56mm", Action = "Gas-operated, rotating bolt", RateOfFire = 700, MuzzleVelocity = 910, EffectiveRange = 500, FeedSystem = "30-round box magazine", Sights = "Iron sights or various optics" });
                db.RiflesAndCarbines.Add(new RiflesAndCarbines { Image = "https://upload.wikimedia.org/wikipedia/commons/3/39/AUG_A1_508mm_04.jpg", ModelName = "Steyr AUG", Manufacturer = "Steyr Mannlicher", StartService = "1978", EndService = "Present", Designed = "1977", StartProduction = "1978", EndProduction = "Present", Weight = 3.3, Length = 790, BarrelLength = 508, Cartridge = "5.56x45mm NATO", Action = "Gas-operated, rotating bolt", RateOfFire = 680, MuzzleVelocity = 970, EffectiveRange = 300, MaxRange = 2700, FeedSystem = "30-round detachable box magazine", Sights = "Swarovski 1.5x telescopic sight" });
                db.RiflesAndCarbines.Add(new RiflesAndCarbines { Image = "https://upload.wikimedia.org/wikipedia/commons/e/e7/FN-FAL_belgian.jpeg", ModelName = "FN FAL", Manufacturer = "FN Herstal", StartService = "1954", EndService = "Present", Designed = "1947", StartProduction = "1953", EndProduction = "Present", NoBuilt = 2000000, Weight = 4.3, Length = 1090, BarrelLength = 533, Cartridge = "7.62 NATO", Action = "Gas-operated tilting breechblock", RateOfFire = 700, MuzzleVelocity = 840, EffectiveRange = 600, FeedSystem = "30-round detachable box magazine", Sights = "Iron sights" });
                db.RiflesAndCarbines.Add(new RiflesAndCarbines { Image = "https://upload.wikimedia.org/wikipedia/commons/3/32/%D0%90%D0%9A-47.jpg", ModelName = "AK47", Manufacturer = "Kalashnikov Concern", StartService = "1949", EndService = "Present", Designed = "1947", StartProduction = "1949", EndProduction = "Present", NoBuilt = 75000000, Weight = 3.47, Length = 880, BarrelLength = 415, Cartridge = "7.62x39mm", Action = "Gas-operated, rotating bolt", RateOfFire = 600, MuzzleVelocity = 715, EffectiveRange = 350, FeedSystem = "30-round detachable box magazine", Sights = "Iron sights" });
                db.SaveChanges();
            }
        }
    }
}
