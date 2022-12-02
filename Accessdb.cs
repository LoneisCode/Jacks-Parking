using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessdb
{
    public class Accessdb
    {
        
        static void Main(string[] args)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            CreateTable(sqlite_conn);
            InsertData(sqlite_conn);
        }

        static SQLiteConnection CreateConnection()
        {
            SqLiteConnection sqlite_conn;

            sqlite_conn = new SqLiteConnection("Data Source =" +
                "JacksParkingSQLiteDB; Version=3;New=True;Compress=True;");

            try
            {
                sqlite_conn.Open();
            }
            catch(Exception ex)
            {

            }
            return sqlite_conn;
        }

        static void CreateTable(SQLiteConection conn)
        {
            SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE ParkingLots " +
                "(ID PRIMARY INT, x_location VARCHAR(20), y_location VARCHAR(20), " +
                "total_spaces INT, spaces_occ INT, level INT, primary_building VARCHAR(50), " +
                "secondary_building VARCHAR(50), name VARCHAR(20), permits INT, spec_case INT);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
        }

        static void InsertData(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO ParkingLots " +
                "(ID, xlocation, y_location, total_spaces, spaces_occ, level, primary_building, secondary_building, name, permits, spec_case)" +
                " VALUES (1, '31.616705', '-94.651066', 118, 0, 0, 'Village', 'STEM', 'Village Lot', 1, 3);";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO ParkingLots " +
                "(ID, xlocation, y_location, total_spaces, spaces_occ, level, primary_building, secondary_building, name, permits, spec_case)" +
                " VALUES (2, '31.618384', '-94.648453', 56, 0, 0, 'STEM', 'Village', 'STEM Faculty Lot', 3, 3);";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO ParkingLots " +
                "(ID, xlocation, y_location, total_spaces, spaces_occ, level, primary_building, secondary_building, name, permits, spec_case)" +
                " VALUES (3, '31.620085', '-94.645305', 167, 0, 0, 'Library', 'Village', 'Library Lot', 1, 3);";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO ParkingLots " +
                "(ID, xlocation, y_location, total_spaces, spaces_occ, level, primary_building, secondary_building, name, permits, spec_case)" +
                " VALUES (4, '31.617439', '-94.645807', 118, 0, 0, 'REC', 'Library', 'REC Lot', 1, 2);";
            sqlite_cmd.ExecuteNonQuery();
        }

        static string ReadData(SQLiteConnection conn, int ID)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = $"SELECT * FROM ParkingLots WHERE ID = {ID};";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader += sqlite_datareader.GetString(0);
            }
            conn.Close();
            return myreader;
        }

        static void UpdateSpacesOccupied(SQLiteConnection conn, int newSpaces, int ID)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = $"UPDATE ParkingLots SET spaces_occ = {newSpaces} WHERE ID = {ID};";

            sqlite_cmd.ExecuteQuery();

            conn.Close();
        }
    }
}
