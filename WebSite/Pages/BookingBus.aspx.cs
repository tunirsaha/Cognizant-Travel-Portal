using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BAL;
using BE;

namespace WebSite
{
 public partial class BookingBus : System.Web.UI.Page
 {
 BalBooking2 bal = new BalBooking2();
 
 string cost;
 
 
 protected void Page_Load(object sender, EventArgs e)
 {
 if (!IsPostBack)
 {
 var bus = (BeBooking)Session["bus"];
 DataTable dt = bal.SearchBus(bus);
 foreach (DataRow dr in dt.Rows)
 {
 cost=dr["cost"].ToString();
 dr["cost"] = cost.Substring(0, 6);
 }
 txtSrc.Value = bus.start.ToString();
 txtDst.Value = bus.destination.ToString();
 txtDoj.Value = bus.dte.Date.ToString().Substring(0, 9);
 
 //GridView2.Columns[0].
 GridView1.DataSource = dt;
 GridView1.DataBind();
  
 }
 
 }
 
 
 protected void rbSelector_CheckedChanged(object sender, EventArgs e)
 {
 foreach (GridViewRow oldrow in GridView1.Rows)
 {
 ((RadioButton)oldrow.FindControl("rbBus")).Checked = false;
 }
 //Set the new selected row
 RadioButton rb = (RadioButton)sender;
 GridViewRow row = (GridViewRow)rb.NamingContainer;
 ((RadioButton)row.FindControl("rbBus")).Checked = true;
 //Label1.Text = row.Cells[1].Text;
 BeBooking bus = (BeBooking)Session["bus"];
 bus.bus_id = row.Cells[1].Text;
 bus.bus_name = row.Cells[2].Text;
 bus.time = (Convert.ToDateTime(row.Cells[7].Text));
 bus.cost = Convert.ToSingle(row.Cells[8].Text);
 bus.tot_tck = Convert.ToInt32(row.Cells[6].Text); 
 Session["bus"] = bus;
  

  
 }

 
 protected void btnSubmit_Click(object sender, EventArgs e)
 {
 
 Response.Redirect("BookingCost.aspx");
 
 }




 
 }
}