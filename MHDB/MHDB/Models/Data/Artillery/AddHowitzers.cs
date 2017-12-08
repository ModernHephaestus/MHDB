using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;

namespace MHDB.Models.Data.Artillery
{
    internal class AddHowitzers
    {
        public static void InitHowitzers()
        {
            using (var db = new DatabaseContext())
            {
                db.Artillery.Add(new Howitzers { Image = "https://upload.wikimedia.org/wikipedia/commons/1/1b/M777_Light_Towed_Howitzer_1.jpg", ModelName = "M777", Manufacturer = "BAE Systems", StartService = "2005", EndService = "Present", Designed = "2000s", StartProduction = "2002", EndProduction = "Present", Shell = "M107 155mm HE", Weight = 4200, Length = 10.7, BarrelLength = 5.08, Carriage = "Split Trail", Crew = 8, MinimumElevation = 0, MaximumElevation = 71.7, RateOfFire = 5 });
                db.Artillery.Add(new Howitzers { Image = "https://upload.wikimedia.org/wikipedia/commons/3/34/Royal_Thai_Army_firing_M198_howitzer.jpg", ModelName = "M198", Manufacturer = "Rock Island Arsenal", StartService = "1979", EndService = "Present", Designed = "1968", StartProduction = "1978", EndProduction = "1992", Shell = "Separate loading charage and 155mm projectile", NoBuilt = 1600, Weight = 7154, Length = 11, BarrelLength = 6.09, Carriage = "SPlit Trail", Crew = 9, MinimumElevation = -5, MaximumElevation = 72, RateOfFire =  4});
                db.Artillery.Add(new Howitzers { Image = "https://upload.wikimedia.org/wikipedia/commons/8/89/Bundesarchiv_Bild_183-S36048%2C_Frankreich%2C_Arras%2C_Artillerie.jpg", ModelName = "15cm sFH 13", Manufacturer = "Krupp", StartService = "1914", EndService = "1945", Designed = "1913", StartProduction = "1913", EndProduction = "1918", Shell = "Separate-loading, cased charge 149mm HE", NoBuilt = 3409, Weight = 2250, Length = 2.54, BarrelLength = 2.096, Carriage = "Box Trail", MinimumElevation = -4, MaximumElevation = 45, RateOfFire = 3 });
                db.Artillery.Add(new Howitzers { Image = "https://upload.wikimedia.org/wikipedia/commons/0/09/2A65_Msta-B.JPG", ModelName = "2A65 Msta-B", Manufacturer = "Motovilikha Plants", StartService = "1987", EndService = "Present", Designed = "1976", StartProduction = "1987", EndProduction = "Present", Shell = "OF45 152.4mm HE", Weight = 6800, Carriage = "Split Trail", Crew = 11, MinimumElevation = -3.5, MaximumElevation = 70, RateOfFire = 8 });
                db.SaveChanges();
            }
        }
    }
}
