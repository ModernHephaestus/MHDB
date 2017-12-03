using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using MHDB.Models;
namespace UnitTests
{
    [TestClass]
    public class DatabaseUnitTests
    {
        [TestMethod]
        public void DatabaseCreationUnitTest()
        {
            //Arrange
            var connection = new SqliteConnection("DataSourceAttribute=:memory:");
            connection.Open();
            //Act
            try
            {
                var options = new DbContextOptionsBuilder<DatabaseContext>();
            }
            finally
            {

            }
            //Assert
        }
    }
}
