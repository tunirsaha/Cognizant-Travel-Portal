using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using BE;



namespace WebSite
{
 public partial class BookingLogin : System.Web.UI.Page
 {
 protected void Page_Load(object sender, EventArgs e)
 {
 Response.Cache.SetExpires(DateTime.Now.AddMinutes(-1));
 Response.Cache.SetNoStore();

 
 }

 protected void btnSubmit_Click(object sender, EventArgs e)
 {
 BalBooking1 bal = new BalBooking1();
 BeBooking user = new BeBooking();
 user.uid = Convert.ToInt32(userid.Text);
 if (bal.SearchUser(user) == 1)
 {
 Session["uid"] = userid.Text;
 Response.Redirect("BookingRoute.aspx");

 }
 else
 {
 string script = "alert('No User Found');";
 Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);
 userid.Text = "";
 }
 
 }

 
 }
}