using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;
namespace MHDB.Models.Data.HelicopterRotorcraft
{
    internal class AddUtility
    {
        public static void InitUtility()
        {
            using (var db = new DatabaseContext())
            {
                db.HelicopterRotorcraft.Add(new Utility { Image = "https://upload.wikimedia.org/wikipedia/commons/0/01/Blackhawk.jpg", ModelName = "UH-60 Black Hawk", Manufacturer = "Sikorsky Aircraft", StartService = "1979", EndService = "Present", Designed = "1972", StartProduction = "1979", EndProduction = "Present", NoBuilt = 4000, Cost = 21300000, Weight = 4819, Length = 19.76, Width = 16.36, Height = 5.13, Armament = "2 M240 machine guns with 2 M134 Miniguns or 2 GAU-19 gatling guns", Engine = "2 General Electric T700-GE-701C Turboshaft engines 1890 hp each", MaxSpeed = 294, MaxAltitude = 5790});
                db.HelicopterRotorcraft.Add(new Utility { Image = "https://upload.wikimedia.org/wikipedia/commons/4/4f/French_Navy_NH90_lands_on_USS_Antietam_%28CG-54%29_in_the_Bay_of_Bengal_%28cropped%29.jpg", ModelName = "NH90", Manufacturer = "NHIndustries", StartService = "2007", EndService = "Present", Designed = "1990s", StartProduction = "1995", EndProduction = "Present", NoBuilt = 300, Cost = 42000000, Weight = 6400, Length = 19.56, Width = 16.30, Height = 5.31, Armament = "2xDoor guns with Anti-submarine or Air to surface Missiles", Engine = "2 Rolls-Royce Turbomeca RTM322 at 2230 shp or 2 General Electric T700 Turboshaft engines at 2116 shp", MaxSpeed = 300, MaxAltitude = 6000 });
                db.SaveChanges();
            }
        }
    }
}
