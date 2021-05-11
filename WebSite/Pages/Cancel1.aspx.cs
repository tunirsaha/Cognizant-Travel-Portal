using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using System.Data;

namespace Cancel
{
 public partial class WebForm1 : System.Web.UI.Page
 {
 balCancel1 bal1 = new balCancel1();
 protected void Page_Load(object sender, EventArgs e)
 {
 Button3.Visible = false;
 }

 protected void Button1_Click(object sender, EventArgs e)
 {
 GridView1.Visible = false;
 Session["userId"] = TextBox1.Text;
 int val = bal1.chkuserId1(Convert.ToInt64(TextBox1.Text));
 if (val== 0)
 {
 string script = "alert('No Booking exists for ths User ID');";
 Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);
 TextBox1.Text = "";
 }
 else
 {
 Button3.Visible = true;
 DataTable dt = bal1.Search_bkng1(Convert.ToInt32(TextBox1.Text));
  GridView1.DataSource = dt;
  GridView1.DataBind();
  GridView1.Visible = true;
  
 }
 }

 protected void Button2_Click(object sender, EventArgs e)
 {
 TextBox1.Text = "";
 GridView1.Visible = false;
 }

 protected void Button3_Click(object sender, EventArgs e)
 {
 HiddenField hf = new HiddenField();

 for (int i = 0; i < GridView1.Rows.Count; i++)
 {

 RadioButton rb = (RadioButton)GridView1.Rows[i].Cells[0].FindControl("RadioButton1");

 if (rb != null)
 {

 if (rb.Checked)
 {

 hf = (HiddenField)GridView1.Rows[i].Cells[0].FindControl("HiddenField1");

 if (hf != null)
 {

 ViewState["SelectedContact"] = hf.Value;

 }



 break;


 }
 }
 }


 string s = hf.Value;
 Session["bookingId"] = s;
 Response.Redirect("cancel2.aspx");
 }

 protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
 {

 }
  
 }
}