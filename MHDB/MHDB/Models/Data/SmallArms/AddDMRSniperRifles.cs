using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;
namespace MHDB.Models.Data.SmallArms
{
    internal class AddDMRSniperRifles
    {
        public static void InitDMRSniperRifles()
        {
            using (var db = new DatabaseContext())
            {
                db.SmallArms.Add(new DMRSniperRifles { Image = "https://upload.wikimedia.org/wikipedia/commons/6/69/M1903_Springfield_-_USA_-_30-06_-_Arm%C3%A9museum.jpg", ModelName = "M1903", Manufacturer = "Springfield Armory", StartService = "1903", EndService = "Present", Designed = "1903", StartProduction = "1903", EndProduction = "1949", NoBuilt = 3004079, Weight = 3.94, Length = 1097, BarrelLength = 610, Cartridge = ".30-06 Springfield", Action = "Bolt Action",RateOfFire=15, MuzzleVelocity = 854, EffectiveRange = 914, MaxRange = 5029, FeedSystem = "5-round stripper clip", Sights = "Iron Sights" });
                db.SmallArms.Add(new DMRSniperRifles { Image = "http://www.dragunov.net/ndm86/em-352norinco_787x.jpg", ModelName = "SVD", Manufacturer = "Kalashnikov Concerns", StartService = "1963", EndService = "Present", Designed = "1958-1963", StartProduction = "1963", EndProduction = "Present", Weight = 4.3, Length = 1225, BarrelLength = 620, Cartridge = "7.62x54mmR", Action = "Gas-operated, rotating bolt", RateOfFire=30, MuzzleVelocity = 830, EffectiveRange = 800, MaxRange = 800, FeedSystem = "10-round detachable box magazine", Sights = "Telescopic Sight, with Iron Sights" });
                db.SmallArms.Add(new DMRSniperRifles { Image = "https://upload.wikimedia.org/wikipedia/commons/c/ce/Vss_vintorez_01.jpeg", ModelName = "VSS", Manufacturer = "Tula Arms Plant", StartService = "1987", EndService = "Present", Designed = "1980s", StartProduction = "1987", EndProduction = "Present", Weight = 2.6, Length = 894, BarrelLength = 200, Cartridge = "9x39mm", Action = "Gas-operated", RateOfFire=700, MuzzleVelocity = 292, EffectiveRange = 400, MaxRange = 400, FeedSystem = "10-round detachable box magazine", Sights = "telescopic, Night Vision, or Iron Sights" });
                db.SmallArms.Add(new DMRSniperRifles { Image = "https://upload.wikimedia.org/wikipedia/commons/4/40/M14_rifle_-_USA_-_7%2C62x51mm_-_Arm%C3%A9museum.jpg", ModelName = "M14", Manufacturer = "Springfield Armory", StartService = "1959", EndService = "Present", Designed = "1954", StartProduction = "1959", EndProduction = "1964", NoBuilt = 1300000, Weight = 4.1, Length = 1126, BarrelLength = 559, Cartridge = "7.62x51mm NATO", Action = "Gas-operated, rotating bolt",RateOfFire=700, MuzzleVelocity = 850, EffectiveRange = 460, MaxRange = 800, FeedSystem = "20-round detachable box magazine", Sights = "Iron Sights or Telescopic" });
                db.SaveChanges();
            }
        }
    }
}
