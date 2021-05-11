using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using BE;
using System.Data.SqlClient;

namespace MasterData
{
 public partial class WebForm1 : System.Web.UI.Page
 {
 GetUser user = new GetUser();
 protected void Page_Load(object sender, EventArgs e)
 {
 Response.Cache.SetExpires(DateTime.Now.AddMinutes(-1));
 Response.Cache.SetNoStore();
 if (Session["uid"] != null)
 {
 lblUserID.Text = Session["uid"].ToString();
 UpdateBal b = new UpdateBal();
 user = b.show(lblUserID.Text);
 lblNAME.Text = user.name.ToString();
 lblADD.Text = user.add.ToString();
 lblSTATE.Text = user.city.ToString();
 lblCITY.Text = user.state.ToString();
 lblCOUNT.Text = user.count.ToString();
 lblPIN.Text = user.pin.ToString();
 lblEMAIL.Text = user.email.ToString();
 lblCONT.Text = user.cont.ToString();
 lblDOB.Text = user.date.ToString("MM/dd/yyy");
 lblGEND.Text = user.gend.ToString();
 }
 else
 {
 Response.Redirect("UserSearch.aspx");
 }
 }

 protected void Button2_Click(object sender, EventArgs e)
 {
 Session["name"] = lblNAME.Text;
 Session["add"] = lblADD.Text;
 Session["pin"] = lblPIN.Text;
 Session["email"] = lblEMAIL.Text;
 Session["cont"] = lblCONT.Text;
 Session["dob"] = lblDOB.Text;
 Session["gend"] = lblGEND.Text;
 Response.Redirect("EditProfile.aspx");
 }

 protected void Button3_Click(object sender, EventArgs e)
 {
 Session.Clear(); //session object will be there but all the keys will be deleted//
 Session.Abandon(); //session itself will be destroyed//
 Session.Remove("uname"); //this will remove the particular key from the session//
 Response.Redirect("UserSearch.aspx");
 }

 protected void LinkButton1_Click(object sender, EventArgs e)
 {
 Session.Clear(); //session object will be there but all the keys will be deleted//
 Session.Abandon(); //session itself will be destroyed//
 Session.Remove("uname"); //this will remove the particular key from the session//
 Response.Redirect("UserSearch.aspx");
 }

 protected void btnDELETE_Click(object sender, EventArgs e)
 {
 int i = 1;
 UpdateBal b = new UpdateBal();
 try
 {
 b.delete(lblUserID.Text);
 }
 catch(SqlException sqle)
 {
 i = 0;
 }
 
 Session.Clear();//session object will be there but all the keys will be deleted//
 Session.Abandon(); //session itself will be destroyed//
 Session.Remove("uname"); //this will remove the particular key from the session//
 //Session.Remove("dob");
 //Session.Remove("gend");
 Response.Redirect("UserSearch.aspx");
 }

 
 }
}