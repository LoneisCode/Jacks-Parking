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
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["JacksParkingConnectionString"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT x_location FROM ParkingLots WHERE ParkingLots.ID = " + id;

            SqlDataReader sdr = cmd.ExecuteReader();

            Object returnVal = sdr.HasRows && sdr.Read() ? sdr["x_location"] : 0;

            return returnVal;
        }

        static Object getYLocation(int id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["JacksParkingConnectionString"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT y_location FROM ParkingLots WHERE ParkingLots.ID = " + id;

            SqlDataReader sdr = cmd.ExecuteReader();

            Object returnVal = sdr.HasRows && sdr.Read() ? sdr["y_location"] : 0;

            return returnVal;
        }

        static Object getTotalSpaces(int id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["JacksParkingConnectionString"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT total_spaces FROM ParkingLots WHERE ParkingLots.ID = " + id;

            SqlDataReader sdr = cmd.ExecuteReader();

            Object returnVal = sdr.HasRows && sdr.Read() ? sdr["total_spaces"] : 0;

            return returnVal;
        }
        static Object getSpacesOcc(int id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["JacksParkingConnectionString"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT spaces_occ FROM ParkingLots WHERE ParkingLots.ID = " + id;

            SqlDataReader sdr = cmd.ExecuteReader();

            Object returnVal = sdr.HasRows && sdr.Read() ? sdr["spaces_occ"] : 0;

            return returnVal;
        }

        static Object getLevel(int id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["JacksParkingConnectionString"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Level FROM ParkingLots WHERE ParkingLots.ID = " + id;

            SqlDataReader sdr = cmd.ExecuteReader();

            Object returnVal = sdr.HasRows && sdr.Read() ? sdr["level"] : 0;

            return returnVal;
        }

        static Object getPrimaryBuilding(int id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["JacksParkingConnectionString"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT primary_building FROM ParkingLots WHERE ParkingLots.ID = " + id;

            SqlDataReader sdr = cmd.ExecuteReader();

            Object returnVal = sdr.HasRows && sdr.Read() ? sdr["primary_building"] : 0;

            return returnVal;
        }

        static Object getSecondaryBuilding(int id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["JacksParkingConnectionString"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT secondary_building FROM ParkingLots WHERE ParkingLots.ID = " + id;

            SqlDataReader sdr = cmd.ExecuteReader();

            Object returnVal = sdr.HasRows && sdr.Read() ? sdr["secondary_building"] : 0;

            return returnVal;
        }

        static Object getName(int id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["JacksParkingConnectionString"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT name FROM ParkingLots WHERE ParkingLots.ID = " + id;

            SqlDataReader sdr = cmd.ExecuteReader();

            Object returnVal = sdr.HasRows && sdr.Read() ? sdr["name"] : 0;

            return returnVal;
        }

        static Object getPermits(int id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["JacksParkingConnectionString"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT permits FROM ParkingLots WHERE ParkingLots.ID = " + id;

            SqlDataReader sdr = cmd.ExecuteReader();

            Object returnVal = sdr.HasRows && sdr.Read() ? sdr["permits"] : 0;

            return returnVal;
        }

        static Object getSpecCase(int id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["JacksParkingConnectionString"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT spec_case FROM ParkingLots WHERE ParkingLots.ID = " + id;

            SqlDataReader sdr = cmd.ExecuteReader();

            Object returnVal = sdr.HasRows && sdr.Read() ? sdr["spec_case"] : 0;

            return returnVal;
        }
    }
}
