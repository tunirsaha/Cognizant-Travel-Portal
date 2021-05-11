using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using BE;
using BAL;

namespace WebSite.Pages
{
 public partial class LogIn : System.Web.UI.Page
 {
 protected void Page_Load(object sender, EventArgs e)
 {
 Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
 Response.Cache.SetNoStore();
 }

 protected void Button1_Click(object sender, EventArgs e)
 {
 TxtLoginName.Text = string.Empty;
 TxtLoginPass.Text = string.Empty;
 // Resets the fields to empty
 }

 protected void Button2_Click(object sender, EventArgs e)
 {
 BeLogin a = new BeLogin();
 // Business Entity object to store login info

 a.LoginName = TxtLoginName.Text;
 a.LoginPassword = TxtLoginPass.Text;

 BalClass b = new BalClass();
 // BAL object

 int error = b.CheckLogin(a);

 if (error == 1)
 {
 Response.Redirect("~/Pages/Home.aspx");
 }

 else if (error == 2)
 {
 string script = "alert('Invalid User !!');";
 Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);
 }

 else if (error == 3)
 {
 string script = "alert('Wrong Password !!');";
 Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);
 }

 else if (error == -1)
 {
 string script = "alert('Wrong Credentials !!');";
 Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);
 }

 else
 {
 string script = "alert('Fields Cannot be Empty !!');";
 Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);
 }
 }
 }
}