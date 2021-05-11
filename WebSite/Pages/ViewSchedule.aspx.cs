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

namespace WebSite
{
 public partial class viewSchedule : System.Web.UI.Page
 {
 public DataTable ScheduleFinal()
 {
 viewSchedule obj1 = new viewSchedule();
 MasterBAL obj = new MasterBAL();
 DataTable dt = obj.finalScheduleDetail();
 return dt;
 }
 public void fillGrid()
 {

 DataTable dt = ScheduleFinal();
 gvViewData.DataSource = dt;
 gvViewData.DataBind();
 }
 protected void Page_Load(object sender, EventArgs e)
 {

 fillGrid();
 

 
 }
 protected void btnDelete_Click(object sender, EventArgs e)
 {
 
 }

 protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
 {
 gvViewData.PageIndex = e.NewPageIndex;
 fillGrid();
 }
 }
}