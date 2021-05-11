using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BE;
using BAL;

namespace WebSite
{
 public partial class addBus : System.Web.UI.Page
 {
 protected void Page_Load(object sender, EventArgs e)
 {
 Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
 Response.Cache.SetNoStore();
 }

 protected void drpBusType_SelectedIndexChanged(object sender, EventArgs e)
 {

 }

 protected void btnSubmit_Click(object sender, EventArgs e)
 {
 string confirmValue = Request.Form["confirm_value"];
 if (confirmValue == "Yes" && txtBusID.Text!="" && txtBusName.Text!="")
 {
 addBusBE obj = new addBusBE();
 obj.bus_no = txtBusID.Text;
 obj.bus_name = txtBusName.Text;
 obj.bus_type = drpBusType.SelectedItem.Value;
 MasterBAL obj1 = new MasterBAL();
 int error = obj1.BalAddBus(obj);

 if (error == 1)
 {
 string script = "alert('Bus Added Successfully');";
 Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);

 txtBusID.Text = "";
 txtBusName.Text = "";
 drpBusType.SelectedIndex = 0;

 }
 else
 {
 string script = "alert('Bus Already Exists!!');";
 Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);

 txtBusID.Text = "";
 txtBusName.Text = "";
 drpBusType.SelectedIndex = 0;
 }
 }
 else
 {
 string script = "alert('Fill All Fields!!!');";
 Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);

 txtBusID.Text = "";
 txtBusName.Text = "";
 drpBusType.SelectedIndex = 0;
 
 }
 }

 protected void btnReset_Click(object sender, EventArgs e)
 {
 txtBusID.Text = "";
 txtBusName.Text = "";
 drpBusType.SelectedIndex = 0;
 }

 
 }
}