using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;
namespace MHDB.Models.Data.Vehicles
{
    internal class AddIFVs
    {
        public static void InitIFVs()
        {
            using (var db = new DatabaseContext())
            {
                db.Vehicles.Add(new IFVs { Image = "https://upload.wikimedia.org/wikipedia/commons/5/5d/Puma%2C_first_series.jpg", ModelName = "Puma", Manufacturer = "Krauss-Maffei Wegmann and Rheinmetall", StartService = "2015", EndService = "Present", Designed = "1996", StartProduction = "2009", EndProduction = "Present", NoBuilt = 100, Cost=7000000, Weight = 28530, Length = 7.6, Width = 3.9, Height = 3.6, Armament = "30 mm MK30-2/ABM autocannon", Engine = "MTU V10 892 diesel 1100 hp", Suspension = "hydropneumatic", MaxSpeed = 70 });
                db.Vehicles.Add(new IFVs { Image = "https://upload.wikimedia.org/wikipedia/commons/1/1f/Ukrainian_BMD-2_tank_%282%29.JPG", ModelName = "BMD-2", Manufacturer = "Volgograd Tractor Plant", StartService = "1985", EndService = "Present", Designed = "1981", StartProduction = "1985", EndProduction = "1991", Weight = 11500, Length = 7.85, Width = 2.94, Height = 2.45, Armament = "30mm 2A42 Autocannon", Engine = "5d-20 6-cylinder 4-stroke Diesel 241 hp", Suspension = "Torsion-bar", FuelCapacity=300, MaxSpeed = 80 });
                db.SaveChanges();
            }
        }
    }
}
