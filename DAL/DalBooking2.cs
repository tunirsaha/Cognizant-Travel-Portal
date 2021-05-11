using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using BE;
using System.Configuration;

namespace DAL
{
 public class DalBooking2
 {
 
 BeBooking bus = new BeBooking();

 public void InsertBooking(BeBooking bus)
 {
 var connectionString = ConfigurationManager.ConnectionStrings["BusResSysConnectionString"].ConnectionString;
 SqlConnection con = new SqlConnection(connectionString);
 con.Open();
 SqlCommand cmd = new SqlCommand("usp_FetchBusId", con);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.AddWithValue("@bus_name", bus.bus_name);
 SqlParameter bus_id = new SqlParameter("@bus_id", SqlDbType.VarChar, 50);
 bus_id.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(bus_id);

 cmd.ExecuteNonQuery();
 bus.bus_id = bus_id.Value.ToString();


 SqlCommand cmd1 = new SqlCommand("usp_FetchRouteId", con);
 cmd1.CommandType = CommandType.StoredProcedure;
 cmd1.Parameters.AddWithValue("@from", bus.start);
 cmd1.Parameters.AddWithValue("@to", bus.destination);
 SqlParameter route_id = new SqlParameter("@route_id", SqlDbType.VarChar, 50);
 route_id.Direction = ParameterDirection.Output;
 cmd1.Parameters.Add(route_id);

 cmd1.ExecuteNonQuery();
 bus.route_id = route_id.Value.ToString();



 SqlCommand cmd2 = new SqlCommand("usp_FetchScheduleId", con);
 cmd2.CommandType = CommandType.StoredProcedure;
 cmd2.Parameters.AddWithValue("@route_id", bus.route_id);
 cmd2.Parameters.AddWithValue("@bus_id", bus.bus_id);
 SqlParameter schedule_id = new SqlParameter("@schedule_id", SqlDbType.VarChar, 50);
 schedule_id.Direction = ParameterDirection.Output;
 cmd2.Parameters.Add(schedule_id);

 cmd2.ExecuteNonQuery();
 bus.schedule_id = schedule_id.Value.ToString();

 SqlCommand cmd3 = new SqlCommand("usp_InsertBooking", con);
 cmd3.CommandType = CommandType.StoredProcedure;
 cmd3.Parameters.AddWithValue("@booking_id", bus.bookingid);
 cmd3.Parameters.AddWithValue("@schedule_id", bus.schedule_id);
 cmd3.Parameters.AddWithValue("@user_id", bus.uid);
 cmd3.Parameters.AddWithValue("@noOfTickets", bus.noOfTickets);
 cmd3.Parameters.AddWithValue("@doj", Convert.ToDateTime(bus.dte.Date.ToString().Substring(0,9)));
 cmd3.ExecuteNonQuery();

 con.Close();
 con.Dispose();
 }

 public DataTable SearchBus(BeBooking bus)
 {
 var connectionString = ConfigurationManager.ConnectionStrings["BusResSysConnectionString"].ConnectionString;
 SqlConnection con = new SqlConnection(connectionString);
 con.Open();
 SqlCommand cmd = new SqlCommand("usp_SearchBus", con);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.AddWithValue("@start", bus.start);
 cmd.Parameters.AddWithValue("@destination", bus.destination);
 cmd.Parameters.AddWithValue("@date",bus.dte);

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

 public string GetUser(BeBooking user)
 {

 var connectionString = ConfigurationManager.ConnectionStrings["BusResSysConnectionString"].ConnectionString;
 SqlConnection con = new SqlConnection(connectionString);
 con.Open();
 SqlCommand cmd = new SqlCommand("usp_GetUser", con);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.AddWithValue("@uid", user.uid);
 SqlParameter parm = new SqlParameter("@name", SqlDbType.VarChar,50);
 parm.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(parm);

 cmd.ExecuteNonQuery();
 string nam = parm.Value.ToString();
 string name = cmd.Parameters["@name"].Value.ToString();
  
 con.Close();
 return name;


 }
 
 public DataTable UpdateBus()
 {

 var connectionString = ConfigurationManager.ConnectionStrings["BusResSysConnectionString"].ConnectionString;
 SqlConnection con = new SqlConnection(connectionString);
 SqlCommand cmd = new SqlCommand("usp_SearchCity", con);
 cmd.CommandType = CommandType.StoredProcedure;
 SqlDataAdapter da = new SqlDataAdapter(cmd);
 
 try
 {
 DataTable dt = new DataTable();
 da.Fill(dt);
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

 public void UpdateTicket(BeBooking bus)
 {
 var connectionString = ConfigurationManager.ConnectionStrings["BusResSysConnectionString"].ConnectionString;
 SqlConnection con = new SqlConnection(connectionString);
 con.Open();
 SqlCommand cmd = new SqlCommand("usp_UpdateTicket", con);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.AddWithValue("@from", bus.start);
 cmd.Parameters.AddWithValue("@to", bus.destination);
 cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(bus.dte.Date.ToString().Substring(0, 9)));
 cmd.Parameters.AddWithValue("@tickets", bus.tot_tck-bus.noOfTickets);
 cmd.Parameters.AddWithValue("@busid", bus.bus_id);
 cmd.ExecuteNonQuery();

 con.Close();
 con.Dispose();
 }
 
 }
 }

