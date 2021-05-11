using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using BE;
using System.Data;
using System.Data.SqlClient;

namespace MasterData
{
 public partial class WebForm2 : System.Web.UI.Page
 {
 GetUser obj1 = new GetUser();
 UpdateBal obj = new UpdateBal();
 public DataTable tblCountry()
 {
 GetUser obj1 = new GetUser();
 UpdateBal obj = new UpdateBal();
  DataTable dt = obj.findCountry();
 return dt;
 }
 public DataTable tblstate(string count)
 {
 GetUser obj1 = new GetUser();
 UpdateBal obj = new UpdateBal();
 obj1.count = count;
 DataTable dt = obj.UpdateState(obj1);
 return dt;
 }
 public DataTable tblcity(string state)
 {
 GetUser obj1 = new GetUser();
 UpdateBal obj = new UpdateBal();
 obj1.state = state;
 DataTable dt = obj.UpdateCity(obj1);
 return dt;
 }
 protected void Page_Load(object sender, EventArgs e)
 {
 if (!Page.IsPostBack)
 {
 DataTable dt = tblCountry();
 ddCount.DataSource = dt;
 ddCount.DataTextField = "country_name";
 ddCount.DataValueField = "country_name";
 ddCount.DataBind();
 }
 Response.Cache.SetExpires(DateTime.Now.AddMinutes(-1));
 Response.Cache.SetNoStore();
 if (Session["uid"] == null)
 Response.Redirect("UserSearch.aspx");
 if (Session["uid"] == null)
 Response.Redirect("UserSearch.aspx");
 if (!Page.IsPostBack)
 {
 if (Session["uid"] != null)
 {
 lblUserId.Text = Session["uid"].ToString();
 lblDob.Text = Session["dob"].ToString();
 lblGend.Text = Session["gend"].ToString();
 txtName.Text = Session["name"].ToString();
 txtAdd.Text = Session["add"].ToString();
 txtPin.Text = Session["pin"].ToString();
 txtEmail.Text = Session["email"].ToString();
 txtCont.Text = Session["cont"].ToString();
 }
 else
 {
 Response.Redirect("UserSearch.aspx");
 }
 }
 }

 protected void Button1_Click(object sender, EventArgs e)
 {
 UpdateBal b = new UpdateBal();
 b.show1(txtName.Text, txtAdd.Text, ddCity.SelectedItem.Text, ddCount.SelectedItem.Text, ddState.SelectedItem.Text, txtPin.Text, txtEmail.Text, lblGend.Text, txtCont.Text, lblDob.Text, lblUserId.Text);
 Session.Clear();//session object will be there but all the keys will be deleted//
 Session.Abandon(); //session itself will be destroyed//
 Session.Remove("uname"); //this will remove the particular key from the session//
 //Session.Remove("dob");
 //Session.Remove("gend");
 Response.Redirect("UserSearch.aspx");
 }

 protected void Button2_Click(object sender, EventArgs e)
 {

 Response.Redirect("ShowProfile.aspx");
 }

 protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
 {
 ddCity.Items.Clear();
 ddState.Items.Clear();


 ddState.Items.Add(new ListItem("--Select--", "--Select--"));
 ddCity.Items.Add(new ListItem("--Select--", "--Select--"));

 string count = ddCount.SelectedItem.Value;
 DataTable dt = tblstate(count);
 ddState.DataSource = dt;
 ddState.DataTextField = "state_name";
 ddState.DataValueField = "state_name";
 ddState.DataBind();

 }

 protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
 {
 }

 protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
 {
 ddCity.Items.Clear();
 ddCity.Items.Add(new ListItem("--Select--", "--Select--"));
 string city = ddState.SelectedItem.Value;
 DataTable dt = tblcity(city);
 ddCity.DataSource = dt;
 ddCity.DataTextField = "city_name";
 ddCity.DataValueField = "city_name";
 ddCity.DataBind();
 }


 }
}