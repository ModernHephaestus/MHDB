
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MHDB.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using MHDB.Models.DatabaseItems;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Reflection;

namespace MHDBUnitTests
{
    [TestClass]
    public class DatabaseUnitTests
    {
        [TestMethod]
        public void CreateDataBaseUnitTest()
        {
            //Arrange
            DatabaseContext db = new DatabaseContext();
            db.Database.Migrate();
            int ExpectedInitialCount = 0;
            int ActualInitialCount;
            //Act
            ActualInitialCount = db.SmallArms.Count() + db.Artillery.Count() + db.FixedWingAircraft.Count() + db.HelicopterRotorcraft.Count() + db.Vehicles.Count() + db.Ships.Count();
            //Assert
            Assert.AreEqual(ExpectedInitialCount, ActualInitialCount);
        }
        [TestMethod]
        public void AddToDataBaseUnitTest()
        {
            //Arrange
            DatabaseContext db = new DatabaseContext();
            db.Database.Migrate();
            Pistols TestItem = null;
            int ExpectedPostAddedCount = 1;
            int ActualPostAddedCount;
            //Act
            TestItem = new Pistols { Image = "https://upload.wikimedia.org/wikipedia/commons/6/61/M9-pistolet.jpg", ModelName = "M9", Manufacturer = "Beretta", StartService = "1985", EndService = "Present", Designed = "1980", StartProduction = "1990", EndProduction = "Present", Weight = 0.97, Length = 217, BarrelLength = 125, Cartridge = "9x19mm Parabellum", Action = "Short Recoil", MuzzleVelocity = 381, EffectiveRange = 100, MaxRange = 200, FeedSystem = "15-round detachable box magazine", Sights = "Iron sights" };
            DatabaseHelper.InsertItem(TestItem, "Small Arms", "Pistols");
            db.SaveChanges();
            ActualPostAddedCount = db.SmallArms.Count();
            //Assert
            Assert.AreEqual(ExpectedPostAddedCount, ActualPostAddedCount);
        }
        [TestMethod]
        public void DeleteFromDataBaseUnitTest()
        {
            //Arrange
            DatabaseContext db = new DatabaseContext();
            db.Database.Migrate();
            int ExpectedPostDeletedCount = 1;
            int ActualPostDeletedCount;
            //Act
            var TestItem = new Pistols { Image = "https://upload.wikimedia.org/wikipedia/commons/6/61/M9-pistolet.jpg", ModelName = "M9", Manufacturer = "Beretta", StartService = "1985", EndService = "Present", Designed = "1980", StartProduction = "1990", EndProduction = "Present", Weight = 0.97, Length = 217, BarrelLength = 125, Cartridge = "9x19mm Parabellum", Action = "Short Recoil", MuzzleVelocity = 381, EffectiveRange = 100, MaxRange = 200, FeedSystem = "15-round detachable box magazine", Sights = "Iron sights" };
            var TestItem2 = new Howitzers { Image = "https://upload.wikimedia.org/wikipedia/commons/1/1b/M777_Light_Towed_Howitzer_1.jpg", ModelName = "M777", Manufacturer = "BAE Systems", StartService = "2005", EndService = "Present", Designed = "2000s", StartProduction = "2002", EndProduction = "Present", Shell = "M107 155mm HE", Weight = 4200, Length = 10.7, BarrelLength = 5.08, Carriage = "Split Trail", Crew = 8, MinimumElevation = 0, MaximumElevation = 71.7, RateOfFire = 5 };
            DatabaseHelper.InsertItem(TestItem, "Small Arms", "Pistols");
            DatabaseHelper.InsertItem(TestItem2, "Artillery", "Howitzers");
            db.SaveChanges();
            var FirstItem = db.SmallArms.First();
            DatabaseHelper.DeleteItem(FirstItem);
            db.SaveChanges();
            ActualPostDeletedCount = db.SmallArms.Count();
            //Assert
            Assert.AreEqual(ExpectedPostDeletedCount, ActualPostDeletedCount);
        }

        [TestMethod]
        public void IsEmptyUnitTest()
        {
            //Arrange
            DatabaseContext db = new DatabaseContext();
            db.Database.Migrate();
            db.SmallArms.RemoveRange(db.SmallArms);
            db.Artillery.RemoveRange(db.Artillery);
            db.Vehicles.RemoveRange(db.Vehicles);
            db.FixedWingAircraft.RemoveRange(db.FixedWingAircraft);
            db.HelicopterRotorcraft.RemoveRange(db.HelicopterRotorcraft);
            db.Ships.RemoveRange(db.Ships);
            //Save
            db.SaveChanges();
            bool ExpectedInitialCount;
            bool ActualInitialCount = true;
            //Act
            ExpectedInitialCount = DatabaseHelper.IsEmpty();
            //Assert
            Assert.AreEqual(ExpectedInitialCount, ActualInitialCount);
        }

        [TestMethod]
        public void FillTableListUnitTest()
        {
            //Arrange
            DatabaseContext db = new DatabaseContext();
            db.Database.Migrate();
            List<string> ExpectedListCount = new List<string> { "AirDefense", "Howitzers", "Mortars"};
            List<string> ActualListCount;
            //Act
            ActualListCount = DatabaseHelper.FillTableList("Artillery");
            //Assert
            CollectionAssert.AreEqual(ExpectedListCount, ActualListCount);
        }

    }
}
