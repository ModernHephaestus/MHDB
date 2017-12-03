using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.EntityFrameworkCore;
using MHDB.Models.DatabaseItems;
using MHDB.Views;
using System.Reflection;
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
        internal object SelectTable(string Table)
        {
            var db = new DatabaseContext();
            return db.GetType().GetProperty(Table).GetValue(db);
        }
        internal List<string> FillTableList(string GivenTable)
        {
            using (var db = new DatabaseContext())
            {
                var names = new List<string>();
                var test = db.Model.GetEntityTypes().Where(c => c.Relational().TableName.ToString() == "Small Arms");
                foreach (var x in test)
                {
                    names.Add(x.Relational().DiscriminatorValue.ToString());
                }
                return names;
            }
        }
    }
}
