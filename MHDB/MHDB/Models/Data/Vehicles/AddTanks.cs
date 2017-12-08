using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;
namespace MHDB.Models.Data.Vehicles
{
    internal class AddTanks
    {
       public static void InitTanks()
        {
            using (var db = new DatabaseContext())
            {
                db.Vehicles.Add(new Tanks { Image = "https://upload.wikimedia.org/wikipedia/commons/2/24/Leopard_2_A5_der_Bundeswehr.jpg", ModelName = "Leopard 2", Manufacturer = "Krauss-Maffei Wegmann", StartService = "1979", EndService = "Present", Designed = "1970s", StartProduction = "1979", EndProduction = "Present", Weight = 62300, Length = 9.97, Width = 3.75, Height = 3.0, Armament = "120mm Rheinmetall L/55 smoothbore gun", Engine = "MTU MB 873 Ka-501 V12 Twin-turbo diesel 1479 hp", Suspension = "Torsion bar suspension", FuelCapacity = 1200, MaxSpeed = 68 });
                db.Vehicles.Add(new Tanks { Image = "https://upload.wikimedia.org/wikipedia/commons/a/a6/Challenger_2_Main_Battle_Tank_patrolling_outside_Basra%2C_Iraq_MOD_45148325-_Grey_Background.png", ModelName = "Challenger 2", Manufacturer = "BAE Systems", StartService = "1998", EndService = "Present", Designed = "1990s", StartProduction = "1993", EndProduction = "2002", Weight = 62500, Length = 8.3, Width = 3.5, Height = 2.49, Armament = "L30A1 120mm rifled gun", Engine = "Perkins CV-12 V12 Diesel 1200 bhp", Transmission="TN54 epicyclic transmission", Suspension = "Hydropneumatic suspension", FuelCapacity = 1592, MaxSpeed = 59 });
                db.SaveChanges();
            }
        }
    }
}
