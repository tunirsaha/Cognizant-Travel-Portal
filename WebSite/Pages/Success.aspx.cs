using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSite.Pages
{
 public partial class Success : System.Web.UI.Page
 {
 protected void Page_Load(object sender, EventArgs e)
 {

     if (Session["a_uid"] != null)
     {
         UserID.Text = Session["a_uid"].ToString();
         Session.Remove("a_uid");
     }

     else
     {
         Response.Redirect("Home.aspx");
     }

 }

 protected void Button1_Click(object sender, EventArgs e)
 {
 Response.Redirect("Home.aspx");
 }

 protected void Button2_Click(object sender, EventArgs e)
 {
 Response.Redirect("AddUser.aspx");
 }
 }
}