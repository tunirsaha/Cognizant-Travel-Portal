using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using BE;
using System.Data;
using System.Globalization;

namespace WebSite
{
 public partial class BookingRoute : System.Web.UI.Page
 {
 BeBooking bus = new BeBooking();
 BalBooking2 bal = new BalBooking2();
 protected void Page_Load(object sender, EventArgs e)
 {
 if (!IsPostBack)
 {
 ddlTo.SelectedIndex = 1;
 lbl_custid.Text = Session["uid"].ToString();
 bus.uid = Convert.ToInt32(Session["uid"]);
 lbl_name.Text = bal.GetUser(bus);
 }
  
 }
 


 protected void btnSubmit_Click(object sender, EventArgs e)
 {
 BalBooking2 bal = new BalBooking2();
 bus.uid = Convert.ToInt32(lbl_custid.Text);
 bus.start = ddlFrom.SelectedValue.ToString();
 bus.destination = ddlTo.SelectedValue.ToString();
 bus.dte = Convert.ToDateTime(txtDate.Text).Date;
 Session["bus"] = bus;
 DataTable dt = bal.SearchBus(bus);
 if (dt.Rows.Count == 0)
 {
 string script = "alert('No Route Found');";
 Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);
 txtDate.Text = "";
 }
 else
 Response.Redirect("BookingBus.aspx");

 }

 protected void btnReset_Click(object sender, EventArgs e)
 {
 txtDate.Text = "";
 }
 
 
 

 

 


 }
}