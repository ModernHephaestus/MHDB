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
                        //db.Database.ExecuteSqlCommand("DELETE FROM ShotGuns");
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

                        db.Pistols.RemoveRange(db.Pistols);

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
                //var temp = new Pistols { ModelName = "M9", Sights = "Iron Sights"};
                var InitData = new InitializeData();
            }
        }
    }
}
