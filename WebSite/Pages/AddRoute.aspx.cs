using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using BAL;
using BE;


namespace WebSite
{
 public partial class addRoute : System.Web.UI.Page
 {

 protected void Page_Load(object sender, EventArgs e)
 {
 Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
 Response.Cache.SetNoStore();
 }

 protected void btnSubmit_Click(object sender, EventArgs e)
 {
 string confirmValue = Request.Form["confirm_value"];
 if (confirmValue == "Yes" && txtCost.Text != "" && txtRouteId.Text != "")
 {

  
 addRouteBE obj = new addRouteBE();
 obj.route_id = txtRouteId.Text;
 obj.from = drpFrom.SelectedItem.Value;
 obj.to = drpTo.SelectedItem.Value;
 obj.cost = Convert.ToInt32(txtCost.Text);
 MasterBAL obj1 = new MasterBAL();
 int error = obj1.BalAddRoute(obj);

 if (error == 1)
 {
 string script = "alert('Route Added Successfully');";
 Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);

 txtRouteId.Text = "";
 txtCost.Text = "";
 drpFrom.SelectedIndex = 0;
 drpTo.SelectedIndex = 0;

 }
 else
 {
 string script = "alert('Route Already Exists!!!');";
 Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);

 txtRouteId.Text = "";
 txtCost.Text = "";
 drpFrom.SelectedIndex = 0;
 drpTo.SelectedIndex = 0;
 }


 }
 else
 {
 string script = "alert('Fill All Fields!!!');";
 Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);

 txtRouteId.Text = "";
 txtCost.Text = "";
 drpFrom.SelectedIndex = 0;
 drpTo.SelectedIndex = 0;
 }
 

  
 }

 protected void btnReset_Click(object sender, EventArgs e)
 {
 txtRouteId.Text = "";
 txtCost.Text = "";
 drpFrom.SelectedIndex = 0;
 drpTo.SelectedIndex = 0;
 }

 

 
 }
}