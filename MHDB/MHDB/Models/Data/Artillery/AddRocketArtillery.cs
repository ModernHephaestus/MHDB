using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;

namespace MHDB.Models.Data.Artillery
{
    internal class AddRocketArtillery
    {
        public static void InitRocketArtillery()
        {
            using (var db = new DatabaseContext())
            {
                db.Artillery.Add(new RocketArtillery { Image = "https://upload.wikimedia.org/wikipedia/commons/1/18/Bundesarchiv_Bild_101I-278-0888-27%2C_Russland%2C_Raketenwerfer.jpg", ModelName = "NbW 42", Manufacturer = "", StartService = "", EndService = "", Designed = "", StartProduction = "", EndProduction = "", Shell = "", Weight = , BarrelLength = , Carriage = "", MinimumElevation = , MaximumElevation = , RateOfFire =  });
                db.Artillery.Add(new RocketArtillery { Image = "", ModelName = "", Manufacturer = "", StartService = "", EndService = "", Designed = "", StartProduction = "", EndProduction = "", Shell = "", Weight = , BarrelLength = , Carriage = "", MinimumElevation = , MaximumElevation = , RateOfFire =  });
                db.Artillery.Add(new RocketArtillery { Image = "", ModelName = "", Manufacturer = "", StartService = "", EndService = "", Designed = "", StartProduction = "", EndProduction = "", Shell = "", Weight = , BarrelLength = , Carriage = "", MinimumElevation = , MaximumElevation = , RateOfFire =  });
                db.Artillery.Add(new RocketArtillery { Image = "", ModelName = "", Manufacturer = "", StartService = "", EndService = "", Designed = "", StartProduction = "", EndProduction = "", Shell = "", Weight = , BarrelLength = , Carriage = "", MinimumElevation = , MaximumElevation = , RateOfFire =  });
                db.SaveChanges();
            }
        }
    }
}
