using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.EntityFrameworkCore;
using MHDB.Models.DatabaseItems;
namespace MHDB.Models
{
    internal class DatabaseHelper
    {
        public void ResetDatabase()
        {
            using (var db = new DatabaseContext())
            {
                using (var trans = db.Database.BeginTransaction())
                {
                    
                    try
                    {
                        //db.Database.ExecuteSqlCommand("DELETE FROM Pistols");
                        //db.Database.ExecuteSqlCommand("DELETE FROM SubmachineGuns");
                        //db.Database.ExecuteSqlCommand("DELETE FROM RiflesAndCarbines");
                        //db.Database.ExecuteSqlCommand("DELETE FROM Shotguns");
                        //db.Database.ExecuteSqlCommand("DELETE FROM MachineGuns");
                        //db.Database.ExecuteSqlCommand("DELETE FROM DMRSniperRifles");
                        //db.Database.ExecuteSqlCommand("DELETE FROM AntiMaterial");

                        //db.Database.ExecuteSqlCommand("DELETE FROM Mortars");
                        //db.Database.ExecuteSqlCommand("DELETE FROM Howitzers");
                        //db.Database.ExecuteSqlCommand("DELETE FROM RocketArtillery");
                        //db.Database.ExecuteSqlCommand("DELETE FROM AirDefense");

                        //db.Database.ExecuteSqlCommand("DELETE FROM Trucks");
                        //db.Database.ExecuteSqlCommand("DELETE FROM APCs");
                        //db.Database.ExecuteSqlCommand("DELETE FROM IFVs");
                        //db.Database.ExecuteSqlCommand("DELETE FROM Tanks");

                        //db.Database.ExecuteSqlCommand("DELETE FROM Fighter");
                        //db.Database.ExecuteSqlCommand("DELETE FROM GroundAttack");
                        //db.Database.ExecuteSqlCommand("DELETE FROM Gunship");
                        //db.Database.ExecuteSqlCommand("DELETE FROM Bomber");
                        //db.Database.ExecuteSqlCommand("DELETE FROM Transport");
                        //db.Database.ExecuteSqlCommand("DELETE FROM CommandAndControl");
                        //db.Database.ExecuteSqlCommand("DELETE FROM UAV");

                        //db.Database.ExecuteSqlCommand("DELETE FROM Attack");
                        //db.Database.ExecuteSqlCommand("DELETE FROM Utility");
                        //db.Database.ExecuteSqlCommand("DELETE FROM Observation");

                        //db.Database.ExecuteSqlCommand("DELETE FROM AircraftCarriers");
                        //db.Database.ExecuteSqlCommand("DELETE FROM AmphibiousWarfare");
                        //db.Database.ExecuteSqlCommand("DELETE FROM Cruisers");
                        //db.Database.ExecuteSqlCommand("DELETE FROM Destroyers");
                        //db.Database.ExecuteSqlCommand("DELETE FROM Frigates");
                        //db.Database.ExecuteSqlCommand("DELETE FROM Submarines");

                        //SmallArms
                        db.Pistols.RemoveRange(db.Pistols);
                        db.SubmachineGuns.RemoveRange(db.SubmachineGuns);
                        db.RiflesAndCarbines.RemoveRange(db.RiflesAndCarbines);
                        db.Shotguns.RemoveRange(db.Shotguns);
                        db.MachineGuns.RemoveRange(db.MachineGuns);
                        db.DMRSniperRifles.RemoveRange(db.DMRSniperRifles);
                        db.AntiMaterial.RemoveRange(db.AntiMaterial);
                        //Artillery
                        db.Mortars.RemoveRange(db.Mortars);
                        db.Howitzers.RemoveRange(db.Howitzers);
                        db.RocketArtillery.RemoveRange(db.RocketArtillery);
                        db.AirDefense.RemoveRange(db.AirDefense);
                        //Vehicles
                        db.Trucks.RemoveRange(db.Trucks);
                        db.APCs.RemoveRange(db.APCs);
                        db.IFVs.RemoveRange(db.IFVs);
                        db.Tanks.RemoveRange(db.Tanks);
                        //FixedWingAircraft
                        db.Fighter.RemoveRange(db.Fighter);
                        db.GroundAttack.RemoveRange(db.GroundAttack);
                        db.Gunship.RemoveRange(db.Gunship);
                        db.Bomber.RemoveRange(db.Bomber);
                        db.Transport.RemoveRange(db.Transport);
                        db.CommandAndControl.RemoveRange(db.CommandAndControl);
                        db.UAV.RemoveRange(db.UAV);
                        //HelicopterRotorcraft
                        db.Attack.RemoveRange(db.Attack);
                        db.Utility.RemoveRange(db.Utility);
                        db.Observation.RemoveRange(db.Observation);
                        //Ships
                        db.AircraftCarriers.RemoveRange(db.AircraftCarriers);
                        db.AmphibiousWarfare.RemoveRange(db.AmphibiousWarfare);
                        db.Cruisers.RemoveRange(db.Cruisers);
                        db.Destroyers.RemoveRange(db.Destroyers);
                        db.Frigates.RemoveRange(db.Frigates);
                        db.Submarines.RemoveRange(db.Submarines);
                        //Save
                        db.SaveChanges();
                        db.Database.CommitTransaction();
                    }
                    catch (Exception)
                    {

                    }
                    db.Database.ExecuteSqlCommand("UPDATE sqlite_sequence SET seq = 0");
                    InitializeDatabase();
                }
            }
        }
        internal void InitializeDatabase()
        {
            using (var db = new DatabaseContext())
            {
                InitializeData.InitializeDatabase();
            }
        }
    }
}
