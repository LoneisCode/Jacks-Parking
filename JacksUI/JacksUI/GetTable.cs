using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

class GetTable
{
    string connString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = C:\\blabla; Integrated Security = True";
    SqlConnection conn = new SqlConnection(connString);
    
    static string getLocation(int id)
    {
        conn.Open();
        string query = @"SELECT l.location
                        FROM dbo.Table.sql l
                        WHERE l.Id=" + id + ";";

        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataReader dr = cmd.ExecuteReader();
        conn.Close();
        dr.Read();

        string returnVal = dr.GetString();

        dr.Close();
        
        return returnVal;
    }

    static string getName(int id)
    {
        conn.Open();
        string query = @"SELECT l.name
                        FROM dbo.Table.sql l
                        WHERE l.Id=" + id + ";";

        SqlCommand cmd = new SqlCommand(query, conn);
        conn.Close();
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();

        string returnVal = dr.GetString();

        dr.Close();

        return returnVal;
    }

    static string getPermits(int id)
    {
        conn.Open();
        string query = @"SELECT l.permits
                        FROM dbo.Table.sql l
                        WHERE l.Id=" + id + ";";

        SqlCommand cmd = new SqlCommand(query, conn);
        conn.Close();
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();

        string returnVal = dr.GetInt();

        dr.Close();

        return returnVal;
    }

    static string getSpaces(int id)
    {
        conn.Open();
        string query = @"SELECT l.#_of_spaces
                        FROM dbo.Table.sql l
                        WHERE l.Id=" + id + ";";

        SqlCommand cmd = new SqlCommand(query, conn);
        conn.Close();
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();

        string returnVal = dr.GetInt();

        dr.Close();

        return returnVal;
    }

    static string getLevel(int id)
    {
        conn.Open();
        string query = @"SELECT l.level
                        FROM dbo.Table.sql l
                        WHERE l.Id=" + id + ";";

        SqlCommand cmd = new SqlCommand(query, conn)
        conn.Close();
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();

        string returnVal = dr.GetInt();

        dr.Close();

        return returnVal;
    }

    static string getBuilding(int id)
    {
        conn.Open();
        string query = @"SELECT l.building_near
                        FROM dbo.Table.sql l
                        WHERE l.Id=" + id + ";";

        SqlCommand cmd = new SqlCommand(query, conn)
        conn.Close();
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();

        string returnVal = dr.GetInt();

        dr.Close();

        return returnVal;
    }
}