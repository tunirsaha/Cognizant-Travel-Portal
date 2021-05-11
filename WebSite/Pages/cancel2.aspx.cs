using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using BE;


namespace Cancel
{
 public partial class WebForm2 : System.Web.UI.Page
 {
 CancelUser be = new CancelUser();
 balCancel1 bal1 = new balCancel1();
 


 protected void Page_Load(object sender, EventArgs e)
 {
 if (Session["bookingId"] != null)
 {
 string bkngid = Session["bookingId"].ToString();
 try
 {
 be = bal1.search_user1(bkngid);
 }
 catch
 {
 throw;
 }
 txtid1.Text = be.userid.ToString();
 txtbid.Text = be.busid;
 txtbname.Text = be.busName;
 txtstart.Text = be.start;
 txtdest.Text = be.destination;
 txttickets.Text = be.noOfTickets.ToString();
 txtname.Text = be.userName;
 txtdoj.Text = be.doj.ToString();
 Session["doj"] = txtdoj.Text;
 Session["noOfTickets"] = txttickets.Text;
 Session["cost"] = be.cost;
 Session["wt_type"] = be.wt_type;

 }

 txtid1.ReadOnly = true;
 txtbid.ReadOnly = true;
 txtbname.ReadOnly = true;
 txtstart.ReadOnly = true;
 txtdest.ReadOnly = true;
 txttickets.ReadOnly = true;
 txtname.ReadOnly = true;
 txtdoj.ReadOnly = true;

 }

 protected void Button1_Click(object sender, EventArgs e)
 {
 
 }
 }
}