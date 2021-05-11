using System;
using System.Linq;
using System.Text;
using System.Data;
using BE;
using System.Data.Sql;

using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace DAL
{
 public class GetPassword
 {
 public string GetPass() //function to fetch password from DB
 {
 var connectionString = ConfigurationManager.ConnectionStrings["BusResSysConnectionString"].ConnectionString;
 SqlConnection con = new SqlConnection(connectionString);
 con.Open();
 SqlCommand cmd = new SqlCommand("EXEC usp_GetPass", con);

 try
 {
 SqlDataReader dr = cmd.ExecuteReader();
 string pass = null;
 while (dr.Read())
 {
 pass = dr[0].ToString().TrimEnd().TrimStart();
 }
 return pass;
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

 public DataTable UpdateCountry()
 { 
 var connectionString = ConfigurationManager.ConnectionStrings["BusResSysConnectionString"].ConnectionString;
 SqlConnection con = new SqlConnection(connectionString);
 con.Open();
 SqlCommand cmd = new SqlCommand("usp_UpdateCountry", con);
 cmd.CommandType = CommandType.StoredProcedure;
 

 SqlDataAdapter da = new SqlDataAdapter(cmd);
 DataTable dt = new DataTable();
 da.Fill(dt);

 try
 {

 return dt;
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

 public DataTable UpdateState(BeAddUser obj)
 {
 var connectionString = ConfigurationManager.ConnectionStrings["BusResSysConnectionString"].ConnectionString;
 SqlConnection con = new SqlConnection(connectionString);
 con.Open();
 SqlCommand cmd = new SqlCommand("usp_UpdateState", con);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.AddWithValue("@count", obj.Country);

 SqlDataAdapter da = new SqlDataAdapter(cmd);
 DataTable dt = new DataTable();
 da.Fill(dt);

 try
 {

 return dt;
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

 public DataTable UpdateCity(BeAddUser obj)
 {
 var connectionString = ConfigurationManager.ConnectionStrings["BusResSysConnectionString"].ConnectionString;
 SqlConnection con = new SqlConnection(connectionString);
 con.Open();
 SqlCommand cmd = new SqlCommand("usp_UpdateCity", con);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.AddWithValue("@statename", obj.State);

 SqlDataAdapter da = new SqlDataAdapter(cmd);
 DataTable dt = new DataTable();
 da.Fill(dt);

 try
 {

 return dt;
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

 public class ChangePassword
 {
 public int ChangePass(BeChange a)
 {
 var connectionString = ConfigurationManager.ConnectionStrings["BusResSysConnectionString"].ConnectionString;
 SqlConnection con = new SqlConnection(connectionString);
 con.Open();
 SqlCommand cmd = new SqlCommand("usp_InsertPass", con);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.AddWithValue("@pass", a.NewPassword);
 cmd.ExecuteNonQuery();

 try
 {
 return 1;
 }

 catch
 {
 return -1;
 throw;
 }

 finally
 {
 con.Close();
 con.Dispose();
 }
 }
 }

 public class InsertUser
 {
 public int Insert(BeAddUser a)
 {
 var connectionString = ConfigurationManager.ConnectionStrings["BusResSysConnectionString"].ConnectionString;
 SqlConnection con = new SqlConnection(connectionString);
 con.Open();
 SqlCommand cmd = new SqlCommand("usp_InsertUser", con);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.AddWithValue("@uid", a.uid);
 cmd.Parameters.AddWithValue("@name", a.Name);
 cmd.Parameters.AddWithValue("@address", a.Address);
 cmd.Parameters.AddWithValue("@city", a.City);
 cmd.Parameters.AddWithValue("@state", a.State);
 cmd.Parameters.AddWithValue("@country", a.Country);
 cmd.Parameters.AddWithValue("@pincode", a.PinCode);
 cmd.Parameters.AddWithValue("@email", a.Email);
 cmd.Parameters.AddWithValue("@contact", a.Contact);
 cmd.Parameters.AddWithValue("@dob", a.Dob);
 cmd.Parameters.AddWithValue("@gender", a.Gender);


 try
 {
 cmd.ExecuteNonQuery();
 return 1;
 }

 catch
 {
 return -1;
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