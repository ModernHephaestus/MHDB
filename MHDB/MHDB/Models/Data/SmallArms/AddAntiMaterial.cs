using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;

namespace MHDB.Models.Data.SmallArms
{
    internal class AddAntiMaterial
    {
        public static void InitAntiMaterial()
        {
            using (var db = new DatabaseContext())
            {
                db.SmallArms.Add(new AntiMaterial { Image= "https://upload.wikimedia.org/wikipedia/commons/c/cc/Mauser_Tank-Gewehr_M1918.jpg", ModelName = "M1918", Manufacturer = "Mauser", StartService = "1918", EndService = "1933", Designed = "1910s", StartProduction = "1918", EndProduction = "1918", NoBuilt = 15800, Weight = 15.9, Length = 1691, BarrelLength = 125, Cartridge = "13.2 mm TuF", Action = "Bolt-Action", MuzzleVelocity = 807, EffectiveRange = 500, MaxRange = 500, FeedSystem = "Manual", Sights = "Notched Rear; Front Post" });
                db.SmallArms.Add(new AntiMaterial { Image = "https://upload.wikimedia.org/wikipedia/commons/b/bb/Boys_Mk_I_AT_Rifle.jpg", ModelName = "Boys AT MK-1", Manufacturer = "Royal Small Arms Factory", StartService = "1937", EndService = "1943", Designed = "1937", StartProduction = "1937", EndProduction = "1940", NoBuilt = 62000, Weight = 16, Length = 1575, BarrelLength = 910, Cartridge = "Kynoch & RG .55 Boys", Action = "Bolt-Action", RateOfFire=10, MuzzleVelocity = 747, EffectiveRange = 460, MaxRange = 460, FeedSystem = "5-round detachable box magazine", Sights = "Iron Sights" });
                db.SmallArms.Add(new AntiMaterial { Image= "https://upload.wikimedia.org/wikipedia/commons/5/5a/M82A1_barrett.jpeg", ModelName="M82A1", Manufacturer="Barret", StartService = "1989", EndService = "Present", Designed = "1980", StartProduction = "1982", EndProduction = "Present", Cost=5050, Weight = 14, Length = 1400, BarrelLength = 740, Cartridge = "50 BMG", Action = "Recoil-operated rotating bolt", MuzzleVelocity = 853, EffectiveRange = 1800, MaxRange = 1800, FeedSystem = "10-round detachable box magazine", Sights = "Fixed front, adjustable rear sights; Standard rail for optics" });
                db.SmallArms.Add(new AntiMaterial { Image = "http://modernfirearms.net/userfiles/images/sniper/sn60/osv96_1.jpg", ModelName = "OSV-96", Manufacturer = "KBP Instrument Design Bureau", StartService = "1990s", EndService = "Present", Designed = "1990s", StartProduction = "1990s", EndProduction = "Present", Weight = 12.9, Length = 1746, BarrelLength = 1000, Cartridge = "12.7x108mm", Action = "Direct impingement gas-operated, rotating bolt", MuzzleVelocity = 870, EffectiveRange = 2000, MaxRange = 2000, FeedSystem = "5-round detachable box magazine", Sights = "various mounting sniper sights and backup-iron sights" });
                db.SaveChanges();
            }
        }
    }
}
