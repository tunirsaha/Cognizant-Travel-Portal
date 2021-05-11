using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Data.Sql;

namespace DAL
{
 public class DalCancel1
 {
 CancelUser be1 = new CancelUser();
 SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["BusResSysConnectionString"].ConnectionString);
 
 public int chkuserId1(long userd1)
 {
 con.Open();
 SqlCommand cmd = new SqlCommand("search_userid", con);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.AddWithValue("@n",userd1);
 SqlParameter parm = new SqlParameter("@count", SqlDbType.Int);
 parm.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(parm);
 cmd.ExecuteNonQuery();
 con.Close();
 return Convert.ToInt32(parm.Value);
 
 }
 public DataTable Search_bkng1(int userid)
 {
 con.Open();
 SqlCommand cmdd = new SqlCommand("search_bkng1", con);
 cmdd.CommandType = CommandType.StoredProcedure;
 cmdd.Parameters.AddWithValue("@userid", userid);
 SqlDataAdapter sdf = new SqlDataAdapter();
 DataTable datatable = new DataTable();
 sdf.SelectCommand = cmdd;
 sdf.Fill(datatable);
 int a = datatable.Rows.Count;

 return datatable;
 }
 public CancelUser search_user(string bkngid1)
 {
 con.Open();
 SqlCommand cmd = new SqlCommand("cnclTckt1",con);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.AddWithValue("@n",bkngid1);
 SqlParameter parm = new SqlParameter("@usrid",SqlDbType.BigInt, 50);
 parm.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(parm);
 SqlParameter parm1 = new SqlParameter("@notckts",SqlDbType.Int, 50);
 parm1.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(parm1);
 SqlParameter parm2 = new SqlParameter("@frm", SqlDbType.VarChar, 50);
 parm2.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(parm2);
 SqlParameter parm3 = new SqlParameter("@to", SqlDbType.VarChar, 50);
 parm3.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(parm3);
 SqlParameter parm4 = new SqlParameter("@bId", SqlDbType.VarChar, 50);
 parm4.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(parm4);
 SqlParameter parm5 = new SqlParameter("@bName", SqlDbType.VarChar, 50);
 parm5.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(parm5);
 SqlParameter parm6 = new SqlParameter("@userName",SqlDbType.VarChar, 50);
 parm6.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(parm6);
 SqlParameter parm7 = new SqlParameter("@doj", SqlDbType.Date, 50);
 parm7.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(parm7);

 SqlParameter parm8 = new SqlParameter("@cost", SqlDbType.Float);
 parm8.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(parm8);
 SqlParameter parm9 = new SqlParameter("@wt_type", SqlDbType.Int);
 parm9.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(parm9);

 try
 {
 cmd.ExecuteNonQuery();
 be1.userid = Convert.ToInt64(parm.Value);
 be1.noOfTickets = Convert.ToInt32(parm1.Value);
 be1.busid = parm4.Value.ToString();
 be1.busName = parm5.Value.ToString();
 be1.start = parm2.Value.ToString();
 be1.destination = parm3.Value.ToString();
 be1.userName = parm6.Value.ToString();
 be1.doj = Convert.ToDateTime(parm7.Value);
 be1.wt_type = Convert.ToInt32(parm9.Value);
 be1.cost = Convert.ToSingle(parm8.Value);
 return be1;
 }
 catch
 {
 throw;
 }
 finally
 {
 
 con.Close();
 
 }
 
 }
 public void dltbkingId1(string bkngid1)
 {
 con.Open();
 SqlCommand cmd = new SqlCommand("dltbkngId", con);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.AddWithValue("@n", bkngid1); 
 cmd.ExecuteNonQuery();
 con.Close();

 }
 public void update_seats(string bkngid, string doj, int noOfTickets)
 {

 DateTime date=(Convert.ToDateTime(doj)).Date;
 con.Open();
 SqlCommand cmd = new SqlCommand("update1_11", con);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.AddWithValue("@bkngid", bkngid);
 cmd.Parameters.AddWithValue("@doj", date );
 SqlParameter parm8 = new SqlParameter("@available", SqlDbType.Int);
 parm8.Direction = ParameterDirection.Output;
 cmd.Parameters.Add(parm8);
 cmd.ExecuteNonQuery();
 int available1 = Convert.ToInt32(parm8.Value);
 int available = available1 + noOfTickets;
 SqlCommand cmd1 = new SqlCommand("update1_1", con);
 cmd1.CommandType = CommandType.StoredProcedure;
 cmd1.Parameters.AddWithValue("@available1",available);
 cmd1.Parameters.AddWithValue("@bkngid",bkngid);
 cmd1.Parameters.AddWithValue("@doj",date);
 cmd1.ExecuteNonQuery();
 con.Close();

 }
 }
}