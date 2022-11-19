using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace MauiApp1
{
    class DBAccess
    {
        static Object getXLocation(int id)
        {
            string serverDBName = "JacksParkingDB";
            string serverName = "192.168.1.183";
            string serverUsername = "JPAdmin";
            string serverPassword = "lumberjacks";

            string sqlconn = $"Data Source ={serverName}; InitialCatalog = {serverDBName}; User ID = {serverUsername}; Password = {serverPassword}; Trusted_Connection = true";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.open();

            string queryString = "SELECT x_location FROM dbo.ParkingLots WHERE dbo.ParkingLots.ID = " + id;
            SqlCommand command = new SqlCommand(queryString, sqlConnection);
            SqlDataReader sdr = command.ExecuteReader();

            Object returnVal = sdr.HasRows && sdr.Read() ? sdr["x_location"] : 0;
            sqlConnection.close();
            return returnVal;
        }

        static Object getYLocation(int id)
        {
            string serverDBName = "JacksParkingDB";
            string serverName = "192.168.1.183";
            string serverUsername = "JPAdmin";
            string serverPassword = "lumberjacks";

            string sqlconn = $"Data Source ={serverName}; InitialCatalog = {serverDBName}; User ID = {serverUsername}; Password = {serverPassword}; Trusted_Connection = true";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.open();

            string queryString = "SELECT y_location FROM dbo.ParkingLots WHERE dbo.ParkingLots.ID = " + id;
            SqlCommand command = new SqlCommand(queryString, sqlConnection);
            SqlDataReader sdr = command.ExecuteReader();

            Object returnVal = sdr.HasRows && sdr.Read() ? sdr["y_location"] : 0;
            sqlConnection.close();
            return returnVal;
        }

        static Object getTotalSpaces(int id)
        {
            string serverDBName = "JacksParkingDB";
            string serverName = "192.168.1.183";
            string serverUsername = "JPAdmin";
            string serverPassword = "lumberjacks";

            string sqlconn = $"Data Source ={serverName}; InitialCatalog = {serverDBName}; User ID = {serverUsername}; Password = {serverPassword}; Trusted_Connection = true";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.open();

            string queryString = "SELECT total_spaces FROM dbo.ParkingLots WHERE dbo.ParkingLots.ID = " + id;
            SqlCommand command = new SqlCommand(queryString, sqlConnection);
            SqlDataReader sdr = command.ExecuteReader();

            Object returnVal = sdr.HasRows && sdr.Read() ? sdr["total_spaces"] : 0;
            sqlConnection.close();
            return returnVal;
        }
        static Object getSpacesOcc(int id)
        {
            string serverDBName = "JacksParkingDB";
            string serverName = "192.168.1.183";
            string serverUsername = "JPAdmin";
            string serverPassword = "lumberjacks";

            string sqlconn = $"Data Source ={serverName}; InitialCatalog = {serverDBName}; User ID = {serverUsername}; Password = {serverPassword}; Trusted_Connection = true";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.open();

            string queryString = "SELECT spaces_occ FROM dbo.ParkingLots WHERE dbo.ParkingLots.ID = " + id;
            SqlCommand command = new SqlCommand(queryString, sqlConnection);
            SqlDataReader sdr = command.ExecuteReader();

            Object returnVal = sdr.HasRows && sdr.Read() ? sdr["spaces_occ"] : 0;
            sqlConnection.close();
            return returnVal;
        }

        static Object getLevel(int id)
        {
            string serverDBName = "JacksParkingDB";
            string serverName = "192.168.1.183";
            string serverUsername = "JPAdmin";
            string serverPassword = "lumberjacks";

            string sqlconn = $"Data Source ={serverName}; InitialCatalog = {serverDBName}; User ID = {serverUsername}; Password = {serverPassword}; Trusted_Connection = true";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.open();

            string queryString = "SELECT level FROM dbo.ParkingLots WHERE dbo.ParkingLots.ID = " + id;
            SqlCommand command = new SqlCommand(queryString, sqlConnection);
            SqlDataReader sdr = command.ExecuteReader();

            Object returnVal = sdr.HasRows && sdr.Read() ? sdr["level"] : 0;
            sqlConnection.close();
            return returnVal;
        }

        static Object getPrimaryBuilding(int id)
        {
            string serverDBName = "JacksParkingDB";
            string serverName = "192.168.1.183";
            string serverUsername = "JPAdmin";
            string serverPassword = "lumberjacks";

            string sqlconn = $"Data Source ={serverName}; InitialCatalog = {serverDBName}; User ID = {serverUsername}; Password = {serverPassword}; Trusted_Connection = true";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.open();

            string queryString = "SELECT primary_building FROM dbo.ParkingLots WHERE dbo.ParkingLots.ID = " + id;
            SqlCommand command = new SqlCommand(queryString, sqlConnection);
            SqlDataReader sdr = command.ExecuteReader();

            Object returnVal = sdr.HasRows && sdr.Read() ? sdr["primary_building"] : 0;
            sqlConnection.close();
            return returnVal;
        }

        static Object getSecondaryBuilding(int id)
        {
            string serverDBName = "JacksParkingDB";
            string serverName = "192.168.1.183";
            string serverUsername = "JPAdmin";
            string serverPassword = "lumberjacks";

            string sqlconn = $"Data Source ={serverName}; InitialCatalog = {serverDBName}; User ID = {serverUsername}; Password = {serverPassword}; Trusted_Connection = true";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.open();

            string queryString = "SELECT secondary_building FROM dbo.ParkingLots WHERE dbo.ParkingLots.ID = " + id;
            SqlCommand command = new SqlCommand(queryString, sqlConnection);
            SqlDataReader sdr = command.ExecuteReader();

            Object returnVal = sdr.HasRows && sdr.Read() ? sdr["secondary_building"] : 0;
            sqlConnection.close();
            return returnVal;
        }

        static Object getName(int id)
        {
            string serverDBName = "JacksParkingDB";
            string serverName = "192.168.1.183";
            string serverUsername = "JPAdmin";
            string serverPassword = "lumberjacks";

            string sqlconn = $"Data Source ={serverName}; InitialCatalog = {serverDBName}; User ID = {serverUsername}; Password = {serverPassword}; Trusted_Connection = true";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.open();

            string queryString = "SELECT name FROM dbo.ParkingLots WHERE dbo.ParkingLots.ID = " + id;
            SqlCommand command = new SqlCommand(queryString, sqlConnection);
            SqlDataReader sdr = command.ExecuteReader();

            Object returnVal = sdr.HasRows && sdr.Read() ? sdr["name"] : 0;
            sqlConnection.close();
            return returnVal;
        }

        static Object getPermits(int id)
        {
            string serverDBName = "JacksParkingDB";
            string serverName = "192.168.1.183";
            string serverUsername = "JPAdmin";
            string serverPassword = "lumberjacks";

            string sqlconn = $"Data Source ={serverName}; InitialCatalog = {serverDBName}; User ID = {serverUsername}; Password = {serverPassword}; Trusted_Connection = true";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.open();

            string queryString = "SELECT permits FROM dbo.ParkingLots WHERE dbo.ParkingLots.ID = " + id;
            SqlCommand command = new SqlCommand(queryString, sqlConnection);
            SqlDataReader sdr = command.ExecuteReader();

            Object returnVal = sdr.HasRows && sdr.Read() ? sdr["permits"] : 0;
            sqlConnection.close();
            return returnVal;
        }

        static Object getSpecCase(int id)
        {
            string serverDBName = "JacksParkingDB";
            string serverName = "192.168.1.183";
            string serverUsername = "JPAdmin";
            string serverPassword = "lumberjacks";

            string sqlconn = $"Data Source ={serverName}; InitialCatalog = {serverDBName}; User ID = {serverUsername}; Password = {serverPassword}; Trusted_Connection = true";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.open();

            string queryString = "SELECT spec_case FROM dbo.ParkingLots WHERE dbo.ParkingLots.ID = " + id;
            SqlCommand command = new SqlCommand(queryString, sqlConnection);
            SqlDataReader sdr = command.ExecuteReader();

            Object returnVal = sdr.HasRows && sdr.Read() ? sdr["spec_case"] : 0;
            sqlConnection.close();
            return returnVal;
        }

        static void setSpaces(int id, int newSpaces)
        {
            string serverDBName = "JacksParkingDB";
            string serverName = "192.168.1.183";
            string serverUsername = "JPAdmin";
            string serverPassword = "lumberjacks";

            string sqlconn = $"Data Source ={serverName}; InitialCatalog = {serverDBName}; User ID = {serverUsername}; Password = {serverPassword}; Trusted_Connection = true";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.open();

            string queryString = "UPDATE dbo.ParkingLots SET spaces_occ = " + newSpaces " WHERE ID = " + id;
            SqlCommand command = new SqlCommand(queryString, sqlConnection);
            SqlDataReader sdr = command.ExecuteReader();

            Object returnVal = sdr.HasRows && sdr.Read() ? sdr["spec_case"] : 0;
            sqlConnection.close();
            return returnVal;
        }
    }
}
