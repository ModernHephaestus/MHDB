using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;

namespace MHDB.Models.Data.Artillery
{
    internal class AddMortars
    {
        public static void InitMortars()
        {
            using (var db = new DatabaseContext())
            {
                db.Artillery.Add(new Mortars { Image = "https://upload.wikimedia.org/wikipedia/commons/3/30/25cm_minenwerfer_Waterford_Ont_4.jpg", ModelName = "25 cm schwerer Minenwerfer", Manufacturer = "Rheinmetall", StartService = "1910", EndService = "1918", Designed = "1907", StartProduction = "1910", EndProduction = "1918", Shell = "separate-loding, 4 disk charges 250mm", Weight = 768, BarrelLength = 1.25, Carriage = "Box Trail", MinimumElevation = 45, MaximumElevation = 75, RateOfFire = 20 });
                db.Artillery.Add(new Mortars { Image = "https://upload.wikimedia.org/wikipedia/commons/1/1a/B%C3%B6hler_26cm_Minenwerfer_M_1917_pic3.jpg", ModelName = "M17", Manufacturer = "Skoda", StartService = "1917", EndService = "1939", Designed = "1917", StartProduction = "1917", EndProduction = "1918", Shell = "83kg 260mm HE", Weight = 1550, Crew = 6, MinimumElevation = 34, MaximumElevation = 80});
                db.Artillery.Add(new Mortars { Image = "https://upload.wikimedia.org/wikipedia/commons/d/dc/10cmNbW35.jpg", ModelName = "NbW 35", Manufacturer = "Rheinmetall", StartService = "1939", EndService = "1945", Designed = "1934", StartProduction = "1939", EndProduction = "1941", Shell = "7.38kg 100mm HE", Weight = 105,BarrelLength = 1.344, Crew = 7, MinimumElevation = 45, MaximumElevation = 90, RateOfFire = 15 });
                db.Artillery.Add(new Mortars { Image = "https://upload.wikimedia.org/wikipedia/commons/c/c4/280mm_mortar_M1938-01.jpg", ModelName = "Br-5", Manufacturer = "Barrikady", StartService = "1939", EndService = "1970", Designed = "1930s", StartProduction = "1939", EndProduction = "1940", Shell = "279.4mm HE", Weight = 18400, Length = 4.750, BarrelLength = 3.975, Carriage = "Quad-tank Track", Crew = 15, MinimumElevation = 0, MaximumElevation = 60, RateOfFire = 0.25 });
                db.SaveChanges();
            }
        }
    }
}
