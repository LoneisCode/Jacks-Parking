using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

class GetTable
{
    static string getLocation(int id)
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = WebConfigurationManager.ConnectionStrings["JacksParkingConnectionString"].ConnectionString;

        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "SELECT x_location, y_location FROM ParkingLots";

        SqlDataAdapter sda = new SqlDataAdapter();
        sda.SelectCommand = cmd;

        


    }
    
}