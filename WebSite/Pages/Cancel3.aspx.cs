using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;

namespace Cancel
{
 public partial class Cancel : System.Web.UI.Page
 {
 balCancel1 bal1 = new balCancel1();
 protected void Page_Load(object sender, EventArgs e)
 {
 string bkngid = Session["bookingId"].ToString();
 string doj = Session["doj"].ToString();
 int noOfTickets = Convert.ToInt32(Session["noOfTickets"]);
 bal1.update_seats1(bkngid,doj,noOfTickets);
 bal1.dltbkingId(bkngid);
 DateTime time=Convert.ToDateTime(Session["doj"]);
 float cost, return_amount;
 cost = Convert.ToSingle(Session["cost"]);
 DateTime time1=DateTime.Now.Date;
 int time2=Convert.ToInt32(time1.Subtract(time).Days);
 int wt_type = Convert.ToInt32(Session["wt_type"]);
 if (wt_type == 2)
 {
 if (time2 >= 2)
 return_amount = Convert.ToSingle(cost * noOfTickets * 0.9);
 else if (time2 >= 1 && time2 < 2)
 return_amount = Convert.ToSingle(cost * noOfTickets * 0.75);
 else
 return_amount = Convert.ToSingle(cost * noOfTickets * 0.5);
 }
 else
 {
 return_amount = Convert.ToSingle(cost * noOfTickets);
 }

 Label2.Text =(return_amount).ToString();
 }
 }
}