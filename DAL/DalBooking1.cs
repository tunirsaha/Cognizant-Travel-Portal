using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAL
{
 public class DalBooking1
 {
 public int SearchUser(BeBooking user)
 {

 var connectionString = ConfigurationManager.ConnectionStrings["BusResSysConnectionString"].ConnectionString;
 SqlConnection con = new SqlConnection(connectionString);
 con.Open();
 SqlCommand cmd = new SqlCommand("usp_SearchUser", con);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.AddWithValue("@n", user.uid);
 
 try
 {
 SqlDataReader dr = cmd.ExecuteReader();
 if (dr.HasRows)
 {
 return 1;
 }
 else
 {
 return 0;
 }
 
 }
 catch
 {
 throw;
 }
 finally
 {
 con.Close();
 con.Dispose();
 }
 }
 }
}
