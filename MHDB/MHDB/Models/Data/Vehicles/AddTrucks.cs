using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHDB.Models.DatabaseItems;
namespace MHDB.Models.Data.Vehicles
{
    internal class AddTrucks
    {
        public static void InitTrucks()
        {
            using (var db = new DatabaseContext())
            {
                db.Vehicles.Add(new Trucks { Image = "https://upload.wikimedia.org/wikipedia/commons/6/6d/US_Navy_060322-N-5438H-018_U.S._Army_soldiers_assigned_to_the_Bravo_Battery_3rd_Battalion_320th_Field_Artillery_Regiment_along_with_Iraq_Army_soldiers_from_the_1st_Battalion_1st_Brigade_4th_Division_perform_a_routine_patrol.jpg", ModelName = "HMMWV", Manufacturer = "AM General", StartService = "1984", EndService = "Present", Designed = "1980s", StartProduction = "1984", EndProduction = "2002", NoBuilt=281000, Weight = 2676, Length = 4.57, Width = 2.16, Height = 1.83, Armament = "Numerous variants", Engine = "V8 diesel or Turbo-diesel 190 hp", Transmission = "3 or 4-speed automatic", Suspension = "Independent 4x4", FuelCapacity = 95, MaxSpeed = 113 });
                db.Vehicles.Add(new Trucks { Image = "https://upload.wikimedia.org/wikipedia/commons/2/24/USMC_Growler.jpg", ModelName = "M1161 Growler", Manufacturer = "American Growler, General Dynamics", StartService = "2009", EndService = "Present", Designed = "1999", StartProduction = "2009", EndProduction = "Present", Cost= 209000, Weight = 2058, Length = 4.14, Width = 1.5, Height = 1.84, Armament = "M2HB 50.cal BMG machine gun", Engine = "2.8L 4-cylinder SOHC turbo-diesel 132 bhp", Transmission = "General Motors 4L70E 4-speed automatic", Suspension = "Air ride gas bladder suspension", FuelCapacity = 91, MaxSpeed = 137 });
                db.SaveChanges();
            }
        }
    }
}
