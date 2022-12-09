using SQLite;
using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class Accessdbfe
    {
        public static SqliteConnection CreateConnection()
        {
            SqliteConnection sqlite_conn;

            sqlite_conn = new SqliteConnection("Data Source =" + Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "JacksParkingSQLiteDB.db"));
            
            return sqlite_conn;
        }

        public static string[] ReadData(SqliteConnection conn, int ID)
        {
            SqliteDataReader sqlite_datareader;
            SqliteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = $"SELECT * FROM ParkingLots WHERE ID = {ID};";
            conn.Open();
            sqlite_datareader = sqlite_cmd.ExecuteReader();
          
            string[] dbData = new string[10];
            sqlite_datareader.Read();
   
            dbData[0] = sqlite_datareader.GetString(1);
            dbData[1] = sqlite_datareader.GetString(2);
            dbData[2] = sqlite_datareader.GetString(3);
            dbData[3] = sqlite_datareader.GetString(4);
            dbData[4] = sqlite_datareader.GetString(5);
            dbData[5] = sqlite_datareader.GetString(6);
            dbData[6] = sqlite_datareader.GetString(7);
            dbData[7] = sqlite_datareader.GetString(8);
            dbData[8] = sqlite_datareader.GetString(9);
            dbData[9] = sqlite_datareader.GetString(10);

            conn.Close();
            return dbData;
        }
    }
}
