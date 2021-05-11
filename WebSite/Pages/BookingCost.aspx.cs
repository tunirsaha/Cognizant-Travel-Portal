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
 public partial class BookingCost : System.Web.UI.Page
 {
 public float cost;
 BeBooking bus;
 protected void Page_Load(object sender, EventArgs e)
 {
 Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
 Response.Cache.SetNoStore();
 if (Session.Count == 0)
 {
 Response.Redirect("Home.aspx");
 }
 else
 {
 BalBooking2 bal = new BalBooking2();
 bus = (BeBooking)Session["bus"];
 userid.Value = bus.uid.ToString();
 uname.Value = bal.GetUser(bus);
 start.Value = bus.start;
 destination.Value = bus.destination;
 time.Value = bus.time.ToLongTimeString().Substring(0, 8);
 busname.Value = bus.bus_name;
 date.Value = bus.dte.Date.ToString().Substring(0, 9);
 cost = bus.cost;
 ClientScript.RegisterArrayDeclaration("cost", "'" + cost + "'");
 
 }

 
 
 }

 protected void btnBookTicket_Click(object sender, EventArgs e)
 {
 string[] st = new string[10];
 st = bus.dte.ToString("MM/dd/yyyy").Split(' ');
 Random rnd = new Random();
 int num = rnd.Next(1000, 9999);
 bus.cost = Convert.ToSingle(cost1.Value);
 bus.noOfTickets = Convert.ToInt32(ddlCost.SelectedValue);
 string bus_id = bus.bus_id;
 string date = st[0];
 string result = bus_id + date.Substring(3, 2) + date.Substring(0, 2) + date.Substring(8, 2) + num.ToString();
 bus.bookingid = result;
 BalBooking2 bal = new BalBooking2();
 bal.InsertBooking(bus);
 Session["bus"] = bus;
 bal.UpdateTicket(bus);
 Response.Redirect("BookingTicket.aspx");
 }
 }
}