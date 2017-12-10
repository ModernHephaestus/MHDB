using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;

namespace MHDB.Models.Data.FixedWingAircraft
{
    internal class AddGroundAttack
    {
        public static void InitGroundAttack()
        {
            using (var db = new DatabaseContext())
            {
                db.FixedWingAircraft.Add(new GroundAttack { Image = "https://upload.wikimedia.org/wikipedia/commons/c/cd/A-10_-_32156159151.jpg", ModelName = "A-10 Thunderbolt II", Manufacturer = "Fairchild Republic", StartService = "1977", EndService = "Present", Designed = "1960s and 1970s", StartProduction = "1972", EndProduction = "1982", NoBuilt = 716, Cost = 18800000, Weight = 11321, Length = 16.26, Width = 17.53, Height = 4.47, Armament = "1 30mm GAU-8A Avenger rotary cannon, 11 Rocket/Missile/Bomb hardpoints", Engine = "General Electric TF34-GE-100A Turbofan engines", MaxSpeed = 706, MaxAltitude = 13700});
                db.FixedWingAircraft.Add(new GroundAttack { Image = "https://upload.wikimedia.org/wikipedia/commons/d/d3/Junkers_Ju_87Ds_in_flight_Oct_1943.jpg", ModelName = "Ju-87", Manufacturer = "Junkers", StartService = "1936", EndService = "1945", Designed = "1933", StartProduction = "1936", EndProduction = "1944", NoBuilt = 6500, Weight = 3205, Length = 11, Width = 13.8, Height = 4.23, Armament = "2 7.92mm MG17 machine Guns, 450 kg of Bombs", Engine = "1 Junkers Jumo 211D V12 engine 1184 hp", MaxSpeed = 390, MaxAltitude = 8200});
                db.SaveChanges();
            }
        }
    }
}
