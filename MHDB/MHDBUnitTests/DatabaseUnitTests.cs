
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MHDB.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using MHDB.Models.DatabaseItems;
using System.Threading.Tasks;

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
            int ExpectedInitialCount = 12;
            int ActualInitialCount;
            //Act
            DatabaseHelper.ResetDatabase();
            ActualInitialCount = db.SmallArms.Count();
            //Assert
            Assert.AreEqual(ExpectedInitialCount, ActualInitialCount);
        }
        [TestMethod]
        public void AddToDataBaseUnitTest()
        {
            //Arrange
            DatabaseContext db = new DatabaseContext();
            db.Database.Migrate();
            int ExpectedInitialCount = 13;
            int ActualInitialCount;
            //Act
            DatabaseHelper.ResetDatabase();
            db.Add(new Pistols { Image = "https://upload.wikimedia.org/wikipedia/commons/6/61/M9-pistolet.jpg", ModelName = "M9", Manufacturer = "Beretta", StartService = "1985", EndService = "Present", Designed = "1980", StartProduction = "1990", EndProduction = "Present", Weight = 0.97, Length = 217, BarrelLength = 125, Cartridge = "9x19mm Parabellum", Action = "Short Recoil", MuzzleVelocity = 381, EffectiveRange = 100, MaxRange = 200, FeedSystem = "15-round detachable box magazine", Sights = "Iron sights" });
            db.SaveChanges();
            ActualInitialCount = db.SmallArms.Count();
            //Assert
            Assert.AreEqual(ExpectedInitialCount, ActualInitialCount);
        }
        [TestMethod]
        public void DeleteFromDataBaseUnitTest()
        {
            //Arrange
            DatabaseContext db = new DatabaseContext();
            db.Database.Migrate();
            int ExpectedInitialCount = 11;
            int ActualInitialCount;
            //Act
            DatabaseHelper.ResetDatabase();
            var FirstItem = db.SmallArms.First();
            db.Remove(FirstItem);
            db.SaveChanges();
            ActualInitialCount = db.SmallArms.Count();
            //Assert
            Assert.AreEqual(ExpectedInitialCount, ActualInitialCount);
        }
    }
}
