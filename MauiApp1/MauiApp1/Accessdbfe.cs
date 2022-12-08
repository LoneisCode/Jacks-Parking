using SQLite;
using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls.PlatformConfiguration;
using System.ComponentModel;

namespace MauiApp1;

public class Accessdbfe
{
    public static SqliteConnection CreateConnection()
    {
        SqliteConnection sqlite_conn;

        //string currentDirectory = Directory.GetCurrentDirectory();
        // backDirectory = currentDirectory.Replace("MauiApp1/", "");
        sqlite_conn = new SqliteConnection("Data Source =" +
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "JacksParkingSQLiteDB.db"));


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
            myreader += "|";
        }
        conn.Close();
        return myreader;
    }
}
