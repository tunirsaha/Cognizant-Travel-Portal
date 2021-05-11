using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Configuration;


namespace DAL
{
 public class UpdateDal
 {
 GetUser bus = new GetUser();
 string conn = ConfigurationManager.ConnectionStrings["BusResSysConnectionString"].ConnectionString;

 public GetUser show(string t11)
 {
 string id1 = t11.ToString();

 SqlConnection con = new SqlConnection(conn);

 con.Open();

 SqlCommand cmd = new SqlCommand("usp_FetchDetails", con);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.AddWithValue("@uid", id1);

 SqlParameter name = new SqlParameter("@name", SqlDbType.VarChar, 50);
 name.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(name);

 SqlParameter add = new SqlParameter("@add", SqlDbType.VarChar, 50);
 add.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(add);

 SqlParameter city = new SqlParameter("@city", SqlDbType.VarChar, 50);
 city.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(city);

 SqlParameter count = new SqlParameter("@count", SqlDbType.VarChar, 50);
 count.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(count);

 SqlParameter state = new SqlParameter("@state", SqlDbType.VarChar, 50);
 state.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(state);

 SqlParameter pin = new SqlParameter("@pin", SqlDbType.BigInt);
 pin.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(pin);

 SqlParameter email = new SqlParameter("@email", SqlDbType.VarChar, 50);
 email.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(email);

 SqlParameter gend = new SqlParameter("@gend", SqlDbType.Char, 1);
 gend.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(gend);

 SqlParameter cont = new SqlParameter("@cont", SqlDbType.BigInt);
 cont.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(cont);

 SqlParameter date = new SqlParameter("@date", SqlDbType.DateTime);
 date.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(date);

 cmd.ExecuteNonQuery();

 bus.name = name.Value.ToString();
 bus.add = add.Value.ToString();
 bus.city = city.Value.ToString();
 bus.count = count.Value.ToString();
 bus.state = state.Value.ToString();
 bus.pin = Convert.ToInt64(pin.Value.ToString());
 bus.email = email.Value.ToString();
 bus.gend = Convert.ToChar(gend.Value.ToString());
 bus.cont = Convert.ToInt64(cont.Value.ToString());
 bus.date = Convert.ToDateTime(date.Value.ToString());

 con.Close();
 return bus;
 }


 public GetUser show1(string t1, string t2, string t3, string t4, string t5, string t6, string t7, string t8, string t9, string t10, string t11)
 {
 string id1 = t11.ToString();
 long i = Convert.ToInt64(id1);
 string s1 = t1;
 string s2 = t2;
 string s3 = t3;
 string s4 = t4;
 string s5 = t5;
 string s6 = t6;
 string s7 = t7;
 string id3 = t8.ToString();
 char k = Convert.ToChar(id3);
 string id4 = t9.ToString();
 long l = Convert.ToInt64(id4);
 string s10 = t10.ToString();
 DateTime dt = Convert.ToDateTime(s10);
 SqlConnection con = new SqlConnection(conn);
 con.Open();

 SqlCommand cmd = new SqlCommand("usp_UpdateDetails", con);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.AddWithValue("@uid", id1);
 cmd.Parameters.AddWithValue("@name", t1);
 cmd.Parameters.AddWithValue("@add", t2);
 cmd.Parameters.AddWithValue("@city", t3);
 cmd.Parameters.AddWithValue("@count", t4);
 cmd.Parameters.AddWithValue("@state", t5);
 cmd.Parameters.AddWithValue("@pin", t6);
 cmd.Parameters.AddWithValue("@email", t7);
 cmd.Parameters.AddWithValue("@gend", id3);
 cmd.Parameters.AddWithValue("@cont", id4);
 cmd.Parameters.AddWithValue("@date", dt);

 cmd.ExecuteNonQuery();
 con.Close();
 return bus;

 }
 public GetUser delete(string t11)
 {
 string id1 = t11.ToString();
 long i = Convert.ToInt64(id1);

 SqlConnection con = new SqlConnection(conn);
 con.Open();
 try
 {
 SqlCommand cmd = new SqlCommand("usp_DeleteUser", con);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.AddWithValue("@uid", id1);
 cmd.ExecuteNonQuery();
 return bus;
 }
 catch
 {
 throw;
 }
 //finally
 //{
 // con.Close();
 // con.Dispose();
 //}
 }

 public int SearchUser(string t11)
 {

 long uid;
 if (!Int64.TryParse(t11, out uid))
 return 0;
 else
 {
 SqlConnection con = new SqlConnection(conn);
 con.Open();
 SqlCommand cmd = new SqlCommand("usp_SearchUser", con);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.AddWithValue("@n", Convert.ToInt64(t11));

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
 public DataTable UpdateState(GetUser obj)
 {
 string conn = ConfigurationManager.ConnectionStrings["BusResSysConnectionString"].ConnectionString;

 SqlConnection con = new SqlConnection(conn);
 con.Open();
 SqlCommand cmd = new SqlCommand("usp_UpdateState", con);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.AddWithValue("@count", obj.count);
 cmd.ExecuteNonQuery();
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

 public DataTable UpdateCity(GetUser obj)
 {
 string conn = ConfigurationManager.ConnectionStrings["BusResSysConnectionString"].ConnectionString;

 SqlConnection con = new SqlConnection(conn);
 con.Open();
 SqlCommand cmd = new SqlCommand("usp_UpdateCity", con);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.AddWithValue("@statename", obj.state);
 cmd.ExecuteNonQuery();
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
 public DataTable UpdateCountry()
 {
 string conn = ConfigurationManager.ConnectionStrings["BusResSysConnectionString"].ConnectionString;

 SqlConnection con = new SqlConnection(conn);
 con.Open();
 SqlCommand cmd = new SqlCommand("usp_UpdateCountry", con);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.ExecuteNonQuery();

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