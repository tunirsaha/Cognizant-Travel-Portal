using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using BAL;
using BE;

namespace WebSite
{
 public partial class addSchedule : System.Web.UI.Page
 {
 
 
 
 public DataTable fillforbus()
 {
 addScheduleBE obj1 = new addScheduleBE();
 MasterBAL obj = new MasterBAL();
 DataTable dt = obj.findbusType();
 return dt;
 }

 public DataTable fillforcity()
 {
 addScheduleBE obj = new addScheduleBE();
 MasterBAL obj1 = new MasterBAL();
 DataTable dt = obj1.searchCity(obj);
 return dt;
 }

 public DataTable fillforcitycorre(string city)
 {
 addScheduleBE obj = new addScheduleBE();
 obj.from = city;
 MasterBAL obj1 = new MasterBAL();
 DataTable dt = obj1.findToBus(obj);
 return dt;
 }
 
 
 protected void Page_Load(object sender, EventArgs e)
 { //bus selection
 if (!Page.IsPostBack)
 {
 DataTable dt = fillforbus();
 drpBusName.DataSource = dt;
 drpBusName.DataTextField = "Buses";
 drpBusName.DataValueField = "Buses";
 drpBusName.DataBind();
 
 DataTable dt1 = fillforcity();
 drpFrom.DataSource = dt1;
 drpFrom.DataTextField = "city_name";
 drpFrom.DataValueField = "city_name";
 drpFrom.DataBind();
 drpTo.Items.Insert(0, new ListItem("--Select--", "0"));
 }
 Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
 Response.Cache.SetNoStore();
 
 }
 
 protected void btnSubmit_Click(object sender, EventArgs e)
 {
 string confirmValue = Request.Form["confirm_value"];
 if (confirmValue == "Yes" && txtScheduleID.Text != "" && txtTime.Text != "")
 {
  
 addScheduleBE obj = new addScheduleBE();
 obj.schedule_id = txtScheduleID.Text;
 obj.bus_name = drpBusName.SelectedItem.Value;
 obj.from = drpFrom.SelectedItem.Value;
 obj.to = drpTo.SelectedItem.Value;
 obj.time = txtTime.Text;
 MasterBAL obj1 = new MasterBAL();
 int error = obj1.BalAddSchedule(obj);

 if (error == 1)
 {
 string script = "alert('Schedule Added Successfully');";
 Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);

 txtScheduleID.Text = "";
 txtTime.Text = "";
 drpBusName.SelectedIndex = 0;
 drpFrom.SelectedIndex = 0;
 drpTo.SelectedIndex = 0;
 }
 else
 {
 string script = "alert('Schedule Already Exists!!');";
 Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);

 txtScheduleID.Text = "";
 txtTime.Text = "";
 drpBusName.SelectedIndex = 0;
 drpFrom.SelectedIndex = 0;
 drpTo.SelectedIndex = 0;
 }
 }
 else
 {
 string script = "alert('Fill All Fields!!!');";
 Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);

 txtScheduleID.Text = "";
 txtTime.Text = "";
 drpBusName.SelectedIndex = 0;
 drpFrom.SelectedIndex = 0;
 drpTo.SelectedIndex = 0;
 }
 

  
 }

 protected void btnReset_Click(object sender, EventArgs e)
 {
 txtScheduleID.Text = "";
 txtTime.Text = "";
 drpBusName.SelectedIndex = 0;
 drpFrom.SelectedIndex = 0;
 drpTo.SelectedIndex = 0;
 }

 protected void drpFrom_SelectedIndexChanged(object sender, EventArgs e)
 
 {
 //string city = drpFrom.SelectedIndex;
 string city = drpFrom.Items[drpFrom.SelectedIndex].ToString();
 string city1 = drpFrom.Text;


 DataTable dt2 = fillforcitycorre(city);
 drpTo.DataSource = dt2;
 drpTo.DataTextField = "destination";
 drpTo.DataValueField = "destination";
 drpTo.DataBind();
 
 }

 protected void drpTo_SelectedIndexChanged(object sender, EventArgs e)
 {
 
 
 }

 protected void drpBusName_SelectedIndexChanged(object sender, EventArgs e)
 {

 }

 

 

 
 }
}