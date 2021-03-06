﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.EntityFrameworkCore;
using MHDB.Models.DatabaseItems;
using MHDB.Views;
using MHDB.Models.Data;
using System.Reflection;
namespace MHDB.Models
{
    internal static class DatabaseHelper
    {
        internal static void MigrateDb()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.Database.Migrate();
            }
        }
        internal static bool IsEmpty()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                if (db.SmallArms.Any())
                    return false;
                if (db.Artillery.Any())
                    return false;
                if (db.Vehicles.Any())
                    return false;
                if (db.FixedWingAircraft.Any())
                    return false;
                if (db.HelicopterRotorcraft.Any())
                    return false;
                if (db.Ships.Any())
                    return false;
                else
                    return true;
            }
        }

        internal static void ResetDatabase()
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
        internal static void DeleteItem<T>(T Item) where T : GenericHardware
        {
            using (var db = new DatabaseContext())
            {
                db.Remove(Item);
                db.SaveChanges();
            }
        }
        internal static void InsertItem(object Item, string Table, string SType)
        {
            switch(Table)
            {
                case "Small Arms":
                    AddItems.AddSA((SmallArms)Item, SType);
                    break;
                case "Artillery":
                    AddItems.AddArt(Item, SType);
                    break;
                case "Vehicles":
                    AddItems.AddVeh(Item, SType);
                    break;
                case "Aircraft":
                    AddItems.AddFWA(Item, SType);
                    break;
                case "Helicopters":
                    AddItems.AddHR(Item, SType);
                    break;
                case "Ships":
                    AddItems.AddSh(Item, SType);
                    break;
            }
        }

        internal static void InitializeDatabase()
        {
            using (var db = new DatabaseContext())
            {
                InitializeData.InitializeDatabase();
            }
        }
        internal static object SelectTable(string Table)
        {
            var db = new DatabaseContext();
            return db.GetType().GetProperty(Table).GetValue(db);
        }
        internal static List<string> FillTableList(string GivenTable)
        {
            using (var db = new DatabaseContext())
            {
                var names = new List<string>();
                var Tables = db.Model.GetEntityTypes().Where(c => c.Relational().TableName.ToString() == GivenTable);
                foreach (var x in Tables)
                {
                    var temp = x.Relational().DiscriminatorValue.ToString();
                    if (!temp.Contains(GivenTable) && !temp.Equals("Aircraft") && !temp.Contains("Helicopter") && !temp.Contains("SmallArms"))
                        names.Add(temp);
                }
                return names;
            }
        }
    }
}
