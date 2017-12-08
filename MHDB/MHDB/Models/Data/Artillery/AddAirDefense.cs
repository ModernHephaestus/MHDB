using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;
namespace MHDB.Models.Data.Artillery
{
    internal class AddAirDefense
    {
        public static void InitAirDefense()
        {
            using (var db = new DatabaseContext())
            {
                db.Artillery.Add(new AirDefense { Image = "https://upload.wikimedia.org/wikipedia/commons/f/ff/Flak18-36.jpg", ModelName = "8.8 cm Flak 36", Manufacturer = "Krupp", StartService = "1936", EndService = "1945", Designed = "1928", StartProduction = "1933", EndProduction = "1945", Shell="Fixed QF 88x571mm R",NoBuilt=21310, Weight = 7407, Length=5.791, BarrelLength=4.938, Carriage="Sonderhanger 202", Crew=10, MinimumElevation=-3, MaximumElevation=85, RateOfFire=20 });
                db.Artillery.Add(new AirDefense { Image = "https://upload.wikimedia.org/wikipedia/commons/e/e6/VickersModel1931.JPG", ModelName = "Vikers Model 1931", Manufacturer = "Vickers Resita", StartService = "1937", EndService = "1950", Designed = "1930s", StartProduction = "1931", EndProduction = "1939", Shell = "75x495mm R", Weight = 2825, BarrelLength = 3.225, Carriage = "Cruciform", MinimumElevation = 0, MaximumElevation = 90, RateOfFire = 12 });
                db.Artillery.Add(new AirDefense { Image = "https://upload.wikimedia.org/wikipedia/commons/5/53/Bundesarchiv_Bild_101I-301-1953-24%2C_Seine-et-Oise%2C_Soldaten_mit_Flak-Gesch%C3%BCtz.jpg", ModelName = "2 cm Flak 30", Manufacturer = "Rheinmetall-Borsig", StartService = "1934", EndService = "1945", StartProduction = "1934", EndProduction = "1945", Shell = "20x138mmB", NoBuilt = 144000, Weight = 450, Length = 4.08, BarrelLength = 1.3, Carriage="Towed", Crew = 5, MinimumElevation = -12, MaximumElevation = 90, RateOfFire =180 });
                db.Artillery.Add(new AirDefense { Image = "https://www.armyrecognition.com/images/stories/east_europe/russia/weapons/zpu-4/ZPU-4_14-5mm_quadruple_anti-aircraft_guns_Russia_Russian_army_defence_industry_640.jpg", ModelName = "ZPU-4", Manufacturer = "State Factories - Soviet Union / China", StartService = "1949", EndService = "Present", Designed = "", StartProduction = "1949", EndProduction = "Present", Shell = "", NoBuilt = 20000, Weight = 1810, Length = 4.53, Carriage = "Towed", Crew = 5, MinimumElevation = -10, MaximumElevation = 90, RateOfFire =  150});
                db.SaveChanges();
            }
        }
    }
}
