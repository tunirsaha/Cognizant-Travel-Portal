using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;

namespace MasterData
{
 public partial class UserSearch : System.Web.UI.Page
 {
 protected void Page_Load(object sender, EventArgs e)
 {
 if (!Page.IsPostBack)
 {
 Response.Cache.SetExpires(DateTime.Now.AddMinutes(-1));
 Response.Cache.SetNoStore();
 }
 }

 protected void Button1_Click(object sender, EventArgs e)
 {
 string t11 = txtUSERID.Text;
 UpdateBal bal = new UpdateBal();
 if (t11 != "" && bal.SearchUser(t11) == 1)
 {
 Session["uid"] = txtUSERID.Text;
 Response.Redirect("ShowProfile.aspx");
 }
 else
 {
 lblERROR.Text = "Invalid User";
 }

 }
 }
}