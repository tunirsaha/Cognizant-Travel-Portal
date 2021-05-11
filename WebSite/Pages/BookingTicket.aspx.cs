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
 public partial class BookingTicket : System.Web.UI.Page
 {
 protected void Page_Load(object sender, EventArgs e)
 {
     if (!Page.IsPostBack)
     {
 BeBooking bus = (BeBooking)Session["bus"];
 BalBooking2 bal=new BalBooking2();
 userid.Disabled = true;
 userid.Value = bus.uid.ToString();
 uname.Value = bal.GetUser(bus);
 date.Value = bus.dte.Date.ToString().Substring(0,9);
 cost.Value = bus.cost.ToString()+".00";
 time.Value = bus.time.ToLongTimeString().ToString().Substring(0,8);
 bookingid.Value = bus.bookingid.ToString();
 from.Value = bus.start;
 to.Value = bus.destination;
 busname.Value = bus.bus_name;
 noOftickets.Value = bus.noOfTickets.ToString();
 Session.Clear();
     }
 


 }

 protected void Button1_Click(object sender, EventArgs e)
 {
 Response.Redirect("Home.aspx");
 }
 }
}