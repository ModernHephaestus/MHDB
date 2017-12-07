using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;
namespace MHDB.Models.Data.SmallArms
{
    internal class AddShotguns
    {
        public static void InitShotguns()
        {
            using (var db = new DatabaseContext())
            {
                db.SmallArms.Add(new Shotguns { Image = "https://upload.wikimedia.org/wikipedia/commons/9/98/Winchester_1897.jpg", ModelName = "M97", Manufacturer = "Winchester Repeating Arms", StartService = "1897", EndService = "Present", Designed = "1897", StartProduction = "1897", EndProduction = "1957", NoBuilt = 1024700, Weight = 3.6, Length = 1000, BarrelLength = 510, Cartridge = "12-guage, 16 guage", Action = "Pump-action", EffectiveRange = 20, MaxRange = 20, FeedSystem = "5+1-round tubular magazine", Sights = "Iron Sights" });
                db.SmallArms.Add(new Shotguns { Image = "https://upload.wikimedia.org/wikipedia/commons/0/09/SPAS-12_stock_folded.jpg", ModelName = "SPAS-12", Manufacturer = "Franchi", StartService = "1979", EndService = "Present", Designed = "1979", StartProduction = "1979", EndProduction = "2000", NoBuilt = 37000, Weight = 4.4, Length = 1041, BarrelLength = 500, Cartridge = "12 guage", Action = "Pump-action/gas-actuated", EffectiveRange = 40, MaxRange = 40, FeedSystem = "Internal tube magazine", Sights = "Iron Sight" });
                db.SmallArms.Add(new Shotguns { Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dd/PEO_Mossberg_590A1.jpg/800px-PEO_Mossberg_590A1.jpg", ModelName = "M590", Manufacturer = "Mossberg", StartService = "1960", EndService = "Present", Designed = "1960", StartProduction = "1960", EndProduction = "Present", Weight = 3.4, Length = 886, BarrelLength = 350, Cartridge = "12 guage", Action = "pump action", MuzzleVelocity = 403, EffectiveRange = 40, MaxRange = 50, FeedSystem = "5+1 to 8+1 internal tube magazine", Sights = "Iron Sights" });
                db.SmallArms.Add(new Shotguns { Image = "https://upload.wikimedia.org/wikipedia/commons/6/6f/RemingtonMd11.JPG", ModelName = "A-5", Manufacturer = "Browning Arms", StartService = "1905", EndService = "1975", Designed = "1898", StartProduction = "1902", EndProduction = "1998", Weight = 4.1, Length = 1270, BarrelLength = 711, Cartridge= "12 guage", Action = "Semi-automatic", EffectiveRange = 40, MaxRange = 50, FeedSystem = "2+1 or 4+1 round tubular magazine", Sights = "Iron Sights" });
                db.SaveChanges();
            }
        }
    }
}
