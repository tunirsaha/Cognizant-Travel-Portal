using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BE;
using BAL;

namespace WebSite.Pages
{
 public partial class ChangePass : System.Web.UI.Page
 {
 protected void Page_Load(object sender, EventArgs e)
 {
 Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
 Response.Cache.SetNoStore();
 }

 protected void BtnPasschangeReset_Click(object sender, EventArgs e)
 {
 OldPassChange.Text = string.Empty;
 NewPassChange.Text = string.Empty;
 ConfirmPassChange.Text = string.Empty;
 }

 protected void BtnPasschangeSubmit_Click(object sender, EventArgs e)
 {
 BeChange a = new BeChange();
 BalClass b = new BalClass();

 a.NewPassword = NewPassChange.Text;
 a.OldPassword = OldPassChange.Text;

 int error = b.CheckOldPass(a);

 if (error == -1)
 {
 string script = "alert('Incorrect OLD Password !!');";
 Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);
 }

 else
 {
 if (b.StartChangePass(a) == 1)
 {
 Response.Redirect("../Pages/LogOut2.aspx");
 }
 else
 { }
 }
 }

 }
}