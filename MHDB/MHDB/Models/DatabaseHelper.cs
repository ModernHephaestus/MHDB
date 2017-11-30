using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.EntityFrameworkCore;
using MHDB.Models.DatabaseItems;
using MHDB.Views;
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
                        //////SmallArms
                        ////db.Pistols.RemoveRange(db.Pistols);
                        ////db.SubmachineGuns.RemoveRange(db.SubmachineGuns);
                        ////db.RiflesAndCarbines.RemoveRange(db.RiflesAndCarbines);
                        ////db.Shotguns.RemoveRange(db.Shotguns);
                        ////db.MachineGuns.RemoveRange(db.MachineGuns);
                        ////db.DMRSniperRifles.RemoveRange(db.DMRSniperRifles);
                        ////db.AntiMaterial.RemoveRange(db.AntiMaterial);
                        //////Artillery
                        ////db.Mortars.RemoveRange(db.Mortars);
                        ////db.Howitzers.RemoveRange(db.Howitzers);
                        ////db.RocketArtillery.RemoveRange(db.RocketArtillery);
                        ////db.AirDefense.RemoveRange(db.AirDefense);
                        //////Vehicles
                        ////db.Trucks.RemoveRange(db.Trucks);
                        ////db.APCs.RemoveRange(db.APCs);
                        ////db.IFVs.RemoveRange(db.IFVs);
                        ////db.Tanks.RemoveRange(db.Tanks);
                        //////FixedWingAircraft
                        ////db.Fighter.RemoveRange(db.Fighter);
                        ////db.GroundAttack.RemoveRange(db.GroundAttack);
                        ////db.Gunship.RemoveRange(db.Gunship);
                        ////db.Bomber.RemoveRange(db.Bomber);
                        ////db.Transport.RemoveRange(db.Transport);
                        ////db.CommandAndControl.RemoveRange(db.CommandAndControl);
                        ////db.UAV.RemoveRange(db.UAV);
                        //////HelicopterRotorcraft
                        ////db.Attack.RemoveRange(db.Attack);
                        ////db.Utility.RemoveRange(db.Utility);
                        ////db.Observation.RemoveRange(db.Observation);
                        //////Ships
                        ////db.AircraftCarriers.RemoveRange(db.AircraftCarriers);
                        ////db.AmphibiousWarfare.RemoveRange(db.AmphibiousWarfare);
                        ////db.Cruisers.RemoveRange(db.Cruisers);
                        ////db.Destroyers.RemoveRange(db.Destroyers);
                        ////db.Frigates.RemoveRange(db.Frigates);
                        ////db.Submarines.RemoveRange(db.Submarines);
                        db.SmallArms.RemoveRange(db.SmallArms);
                        db.Artillery.RemoveRange(db.Artillery);
                        db.Vehicles.RemoveRange(db.Vehicles);
                        db.FixedWingAircraft.RemoveRange(db.FixedWingAircraft);
                        db.HelicopterRotorcraft.RemoveRange(db.HelicopterRotorcraft);
                        db.Ships.RemoveRange(db.Ships);
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
