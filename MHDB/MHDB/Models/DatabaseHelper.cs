using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.EntityFrameworkCore;
namespace MHDB.Models
{
    internal class DatabaseHelper
    {
        public void CreateDatabase()
        {
            //if (!File.Exists(DB_PATH))
            //{
            //using (SQLiteConnection conn = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), DB_PATH))
            //{
            //    conn.CreateTable<Pistols>();
            //}
                //SQLiteConnection conn = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), App.DB_PATH);
                //conn.CreateTable<Pistols>();
            //if (!File.Exists(App.DB_PATH))
            //{
            //    using (SQLiteConnection conn = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), App.DB_PATH))
            //    {
            //        conn.CreateTable<Pistols>();
            //        conn.Dispose();
            //        conn.Close();
            //        GC.Collect();
            //    }
            //}
            

            //return conn;
            //}
        }
        public void ResetDatabase()
        {
            using (var db = new Database())
            {
            }
        }
        //public void ResetDatabase(SQLiteConnection conn)
        //{
        //    conn.DropTable<Pistols>();
        //    string sql = "DELETE FROM Pistols WHERE 1 = 1";
        //    SQLiteCommand cmd = new SQLiteCommand
        //    {
        //        CommandText = sql
        //    };
        //    //CreateDatabase();
        //    //conn.DropTable<Pistols>();
        //    //DatabaseHelper DbHelper = new DatabaseHelper();
        //    //DbHelper.CreateDatabase();
        //    //return conn;
        //}
        //public void Insert(Pistols objContact)
        //{
        //    using (SQLiteConnection conn = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), App.DB_PATH))
        //    {
        //        conn.RunInTransaction(() =>
        //        {
        //            conn.Insert(objContact);
        //        });
        //        conn.Close();
        //    }
        //}
        //internal SQLiteConnection ConnectToDatabase()
        //{
        //    //SQLiteConnection conn = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), App.DB_PATH);
        //    //using (SQLiteConnection conn = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), App.DB_PATH))
        //    //{
        //    //    return conn;
        //    //}
        //    return new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), App.DB_PATH);
        //}

        //internal Pistols GetRow()
        //{
        //    using (SQLiteConnection conn = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), App.DB_PATH))
        //    {
        //        var query = conn.Table<Pistols>();
        //        var query2 = query.First();
        //        conn.Close();
        //        return query2;
        //    }
        //}
    }
}
