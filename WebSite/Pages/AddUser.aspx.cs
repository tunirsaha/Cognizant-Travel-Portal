using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BE;
using BAL;
using System.Data;

namespace WebSite
{
 public partial class AddUser : System.Web.UI.Page
 {
 protected void Page_Load(object sender, EventArgs e)
 {
 Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
 Response.Cache.SetNoStore();
 if (!Page.IsPostBack)
 {
 DataTable dt = tblCountry();
 LstAddCountry.DataSource = dt;
 LstAddCountry.DataTextField = "country_name";
 LstAddCountry.DataValueField = "country_name";
 LstAddCountry.DataBind();
 string count = LstAddCountry.SelectedValue;
 DataTable dt1 = tblstate(count);
 LstAddState.DataSource = dt1;
 LstAddState.DataBind();
 DataTable dt2 = tblcity(LstAddState.SelectedValue);
 LstAddCity.DataSource = dt2;
 LstAddCity.DataBind();
 }


 }
 public DataTable tblCountry()
 {
 BeAddUser obj1 = new BeAddUser();
 BalClass obj = new BalClass();
  DataTable dt = obj.UpdateCountry();
 return dt;
 }
 public DataTable tblstate(string count)
 {
 BeAddUser obj1 = new BeAddUser();
 BalClass obj = new BalClass();
 obj1.Country = count;
 DataTable dt = obj.UpdateState(obj1);
 return dt;
 }
 public DataTable tblcity(string state)
 {
 BeAddUser obj1 = new BeAddUser();
 BalClass obj = new BalClass();
 obj1.State = state;
 DataTable dt = obj.UpdateCity(obj1);
 return dt;
 }

 protected void BtnAddRst_Click(object sender, EventArgs e)
 {
 TxtAddName.Text = String.Empty;
 TxtAddAddress.Text = String.Empty;
 TxtAddContact.Text = String.Empty;
 TxtAddDob.Text = String.Empty;
 TxtAddEmail.Text = String.Empty;
 TxtAddPin.Text = String.Empty;
 LstAddCity.ClearSelection();
 LstAddCountry.ClearSelection();
 LstAddState.ClearSelection();
 }

 protected void BtnAddSubmit_Click(object sender, EventArgs e)
 {
 BeAddUser a = new BeAddUser();
 BalClass b = new BalClass();

 char gender;

 if (RdoAddMale.Checked)
 gender = 'M';
 else if (RdoAddFemale.Checked)
 gender = 'F';
 else
 gender = 'O';

 if (gender != 'O')
 {

     Random rnd = new Random();
     int num = rnd.Next(1000, 9999);
     DateTime dt = DateTime.Now;
     string[] date = dt.ToString("MM/dd/yyyy").Split(' ');
     a.uid = Convert.ToInt64(date[0].Substring(6, 4) + date[0].Substring(0, 2) + num.ToString());


 a.Name = TxtAddName.Text.Trim();
 a.Address = TxtAddAddress.Text.Trim();
 a.Country = LstAddCountry.SelectedItem.ToString();
 a.State = LstAddState.SelectedItem.ToString();
 a.City = LstAddCity.SelectedItem.ToString();
 a.PinCode = Convert.ToInt64(TxtAddPin.Text.Trim());
 a.Email = TxtAddEmail.Text.Trim();
 a.Contact = Convert.ToInt64(TxtAddContact.Text.Trim());
 a.Dob = Convert.ToDateTime(TxtAddDob.Text.Trim());
 a.Gender = gender;

 int error = b.AddUser(a); //passing BE to BAL layer

 if (error == 1)
 {
string script = "alert('User Added Successfully !!');";
 Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);
 Session["a_uid"] = a.uid;
Response.Redirect("Success.aspx");
 }

 else
 {
 string script = "alert('User could not be added !! Check Database Connection !!');";
 Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);
 }
 }

 else
 {
 string script = "alert('Gender needs to be filled !!');";
 Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);
 }

 }

 protected void LstAddState_SelectedIndexChanged(object sender, EventArgs e)
 {
 string state = LstAddState.SelectedItem.Value;
 DataTable dt = tblcity(state);
 LstAddCity.DataSource = dt;
 LstAddCity.DataTextField = "city_name";
 LstAddCity.DataValueField = "city_name";
 LstAddCity.DataBind();
 }

 protected void LstAddCountry_SelectedIndexChanged(object sender, EventArgs e)
 {
 string count = LstAddCountry.SelectedItem.Value;
 DataTable dt = tblstate(count);
 LstAddState.DataSource = dt;
 LstAddState.DataTextField = "state_name";
 LstAddState.DataValueField = "state_name";
 LstAddState.DataBind();
 string state = LstAddState.SelectedItem.Value;
 DataTable dt1 = tblcity(state);
 LstAddCity.DataSource = dt1;
 LstAddCity.DataTextField = "city_name";
 LstAddCity.DataValueField = "city_name";
 LstAddCity.DataBind();
 }
 }
}