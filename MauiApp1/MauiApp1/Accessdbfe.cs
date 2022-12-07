using SQLite;
using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessdbfe
{
    public class Accessdbfe
    {
        static SqliteConnection CreateConnection()
        {
            SqliteConnection sqlite_conn;

            string currentDirectory = Directory.GetCurrentDirectory();
            string backDirectory = currentDirectory.Replace("MauiApp1", "");
            sqlite_conn = new SqliteConnection("Data Source =" +
                Path.Combine(backDirectory, "JacksParkingSQLiteDB.db") + ";Version=3;New=True;Compress=True;");

            try
            {
                sqlite_conn.Open();
            }
            catch(Exception ex)
            {

            }
            return sqlite_conn;
        }

        public static string ReadData(SqliteConnection conn, int ID)
        {
            SqliteDataReader sqlite_datareader;
            SqliteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = $"SELECT * FROM ParkingLots WHERE ID = {ID};";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            string myreader = "";
            while (sqlite_datareader.Read())
            {
                myreader += sqlite_datareader.GetString(0);
            }
            conn.Close();
            return myreader;
        }
    }
}
