using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;
namespace MHDB.Models.Data.SmallArms
{
    internal class AddSubmachineGuns
    {
        public static void InitSubmachineGuns()
        {
            using (var db = new DatabaseContext())
            {
                db.SmallArms.Add(new SubmachineGuns { Image = " https://upload.wikimedia.org/wikipedia/commons/7/70/MP_40_AYF_3.JPG", ModelName = "MP40", Manufacturer = "Steyr-Mannlicher", StartService = "1938", EndService = "1945", Designed = "1938", StartProduction = "1940", EndProduction = "1945", NoBuilt = 1100000, Weight = 3.97, Length = 833, BarrelLength = 251, Cartridge = "9x19mm Parabellum", Action = "Straight blowback, open bolt", RateOfFire = 500, MuzzleVelocity = 400, EffectiveRange = 200, MaxRange = 250, FeedSystem = "32-round detachable box magazine", Sights = "Hooded front blade iron sights" });
                db.SmallArms.Add(new SubmachineGuns { Image = " https://upload.wikimedia.org/wikipedia/commons/0/01/PPSh-41_from_soviet.jpg", ModelName = "PPSH-41", Manufacturer = "Numerous", StartService = "1941", EndService = "1960", Designed = "1941", StartProduction = "1941", EndProduction = "1947", NoBuilt = 6000000, Weight = 3.63, Length = 843, BarrelLength = 269, Cartridge = "7.62x25mm Tokarev", Action = "blowback, open bolt", RateOfFire = 900, MuzzleVelocity = 488, EffectiveRange = 150, MaxRange = 250, FeedSystem = "35-round box magazine", Sights = "Iron sights" });
                db.SmallArms.Add(new SubmachineGuns { Image = " https://upload.wikimedia.org/wikipedia/commons/5/58/Uzi_of_the_israeli_armed_forces.jpg", ModelName = "UZI", Manufacturer = "Israel Military Industries", StartService = "1954", EndService = "Present", Designed = "1950", StartProduction = "1950", EndProduction = "Present", Weight = 3.5, Length = 470, BarrelLength = 260, Cartridge = "9x19mm Parabellum", Action = "Blowback, open bolt", RateOfFire = 600, MuzzleVelocity = 400, EffectiveRange = 200, FeedSystem = "20-round detachable box magazine", Sights = "Iron sights" });
                db.SmallArms.Add(new SubmachineGuns { Image = "https://upload.wikimedia.org/wikipedia/commons/d/d6/HKUMP45.JPG", ModelName = "UMP45", Manufacturer = "Heckler & Koch", StartService = "1999", EndService = "Present", Designed = "1990s", StartProduction = "1999", EndProduction = "Present", Weight = 2.5, Length = 690, BarrelLength = 200, Cartridge = ".45 ACP", Action = "Blowback, closed bolt", RateOfFire = 600, MuzzleVelocity = 285, EffectiveRange = 65, FeedSystem = "25-round detachable box magazine", Sights= "Iron sights or various optics" });
                db.SaveChanges();
            }
        }
    }
}
