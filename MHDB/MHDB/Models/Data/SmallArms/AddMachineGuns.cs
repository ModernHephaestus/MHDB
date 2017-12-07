using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;
namespace MHDB.Models.Data.SmallArms
{
    internal class AddMachineGuns
    {
        public static void InitMachineGuns()
        {
            using (var db = new DatabaseContext())
            {
                db.SmallArms.Add(new MachineGuns { Image = "http://www.imfdb.org/images/thumb/4/43/MG42.jpg/400px-MG42.jpg", ModelName = "MG-42", Manufacturer = "Mauser Werke AG", StartService = "1942", EndService = "Present", Designed = "1942", StartProduction = "1942", EndProduction = "1945", NoBuilt = 423600, Weight = 11.57, Length = 1220, BarrelLength = 533, Cartridge = "7.92x57mm Mauser", Action = "Recoil-operated, roller-locked", RateOfFire = 1200, MuzzleVelocity = 740, EffectiveRange = 1000, MaxRange = 4700, FeedSystem = "50 or 250-round belt", Sights = "Iron, AntiAir, or Telescopic Sights" });
                db.SmallArms.Add(new MachineGuns { Image = "https://upload.wikimedia.org/wikipedia/commons/e/ea/PEO_M240B_Profile.jpg", ModelName = "M240", Manufacturer = "FN Herstel", StartService = "1977", EndService = "Present", Designed = "1950s", StartProduction = "1977", EndProduction = "Present", Weight = 12.5, Length = 1260, BarrelLength = 630, Cartridge = "7.62x51mm NATO", Action = "Gas-operated, open bolt", RateOfFire = 950, MuzzleVelocity = 853, EffectiveRange = 1100, MaxRange = 3725, FeedSystem = "Belt-Fed", Sights = "Iron Sights" });
                db.SmallArms.Add(new MachineGuns { Image = "https://upload.wikimedia.org/wikipedia/commons/9/91/M2_Browning%2C_Mus%C3%A9e_de_l%27Arm%C3%A9e.jpg", ModelName = "M2", Manufacturer = "General Dynamics", StartService = "1933", EndService = "Present", Designed = "1918", StartProduction = "1921", EndProduction = "Present", NoBuilt = 3000000, Weight = 58, Length = 1654, BarrelLength = 1143, Cartridge = ".50 BMG", Action = "Short recoil-operated", RateOfFire = 600, MuzzleVelocity = 890, EffectiveRange = 1800, MaxRange = 2500, FeedSystem = "Belt-Fed", Sights = "Iron Sights" });
                db.SmallArms.Add(new MachineGuns { Image = "https://upload.wikimedia.org/wikipedia/commons/0/0c/Machine_Gun_RPK.jpg", ModelName = "RPK", Manufacturer = "Vyatskie Polyany Machine-Building Plant", StartService = "1961", EndService = "Present", Designed = "1961", StartProduction = "1961", EndProduction = "1978", Weight = 5.1, Length = 1040, BarrelLength = 590, Cartridge = "7.62x39mm M43", Action = "Gas operated, rotating bolt", RateOfFire = 600, MuzzleVelocity = 745, EffectiveRange = 1000, MaxRange = 1000, FeedSystem = "75-round drum magazine", Sights = "Iron Sights" });
                db.SaveChanges();
            }
        }
    }
}
