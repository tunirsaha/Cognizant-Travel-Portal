using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using BE;
using System.Data;

namespace DAL
{
 public class InsertBus
 {
 string conn = ConfigurationManager.ConnectionStrings["BusResSysConnectionString"].ConnectionString;
 
 public int newSchedule(addScheduleBE user)
 {
 string[] str = user.bus_name.Split('-');
 SqlConnection con = new SqlConnection(conn);
 con.Open();
 SqlCommand cmd = new SqlCommand("usp_InsertSchedule", con);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.AddWithValue("@schedule_id", user.schedule_id);
 cmd.Parameters.AddWithValue("@bus_type", str[1]);
 cmd.Parameters.AddWithValue("@name", str[0]);
 cmd.Parameters.AddWithValue("@start", user.from);
 cmd.Parameters.AddWithValue("@to", user.to);
 cmd.Parameters.AddWithValue("@time", user.time);

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
 
 public int newBus(addBusBE user)
 {
  SqlConnection con = new SqlConnection(conn);
  con.Open();
  SqlCommand cmd = new SqlCommand("usp_InsertBus", con);
 cmd.CommandType = CommandType.StoredProcedure;
  cmd.Parameters.AddWithValue("@bus_id", user.bus_no);
  cmd.Parameters.AddWithValue("@name", user.bus_name);
  cmd.Parameters.AddWithValue("@bus_type", user.bus_type);

  try
  {
  cmd.ExecuteNonQuery();
  return 1;
  }

  catch
  {
 
  return -1;
  throw ;
  }

  finally
  {
  con.Close();
  con.Dispose();
  }
 }
 
 public int newRoute(addRouteBE user)
 {
  SqlConnection con = new SqlConnection(conn);
  con.Open();
  SqlCommand cmd = new SqlCommand("usp_InsertRoute", con);
  cmd.CommandType = CommandType.StoredProcedure;
  cmd.Parameters.AddWithValue("@route_id", user.route_id);
  cmd.Parameters.AddWithValue("@from", user.from);
  cmd.Parameters.AddWithValue("@to", user.to);
  cmd.Parameters.AddWithValue("@cost", user.cost);
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
 
 public DataTable findBusType()
 {
 SqlConnection con = new SqlConnection(conn);
 con.Open();
 SqlCommand cmd = new SqlCommand("usp_findBus", con);
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

 public DataTable findToBus(addScheduleBE user)
 {
 SqlConnection con = new SqlConnection(conn);
 con.Open();
 SqlCommand cmd = new SqlCommand("usp_findDestination", con);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.AddWithValue("@from", user.from);

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

 public DataTable selectCity(addScheduleBE user)
 {
 SqlConnection con = new SqlConnection(conn);
 con.Open();
 SqlCommand cmd = new SqlCommand("usp_SearchCity", con);
 cmd.CommandType = CommandType.StoredProcedure;
 //cmd.Parameters.AddWithValue("@from", user.from);

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

 public DataTable getFinalSchedule()
 {

 string conn = ConfigurationManager.ConnectionStrings["BusResSysConnectionString"].ConnectionString;
 SqlConnection con = new SqlConnection(conn);
 con.Open();
 SqlCommand cmd = new SqlCommand("usp_GetFinalSchedule", con);
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
 }
}
