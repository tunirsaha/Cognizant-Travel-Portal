using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BE;
using System.Configuration;
using System.Text.RegularExpressions;
using DAL;
using System.Web.Security;

namespace BAL
{
 public class BalClass
 {
 GetPassword obj2 = new GetPassword(); // fetches password from database
 GetPassword obj3 = new GetPassword();

 public int CheckLogin(BeLogin a) //Login Info Checker
 {
 if ((a.LoginPassword == obj2.GetPass()) && (a.LoginName == "admin"))
 {
 FormsAuthentication.SetAuthCookie(a.LoginPassword, true);
 return 1;
 }

 else if ((a.LoginPassword == obj2.GetPass()) && (a.LoginName != "admin"))
 {
 return 2;
 }

 else if ((a.LoginPassword != obj2.GetPass()) && (a.LoginName == "admin"))
 {
 return 3;
 }

 else if (a.LoginName == "" && a.LoginPassword == "")
 {
 return 0;
 }

 else
 {
 return -1;
 }
 } /*CHECK COMPLETE*/
 public DataTable UpdateCountry()
 {
 GetPassword obj = new GetPassword();
 try
 {
 DataTable dt = obj.UpdateCountry();
 return dt;

 }
 catch
 {
 throw;
 }
 finally
 {
 obj = null;
 }
 }
 public DataTable UpdateState(BeAddUser obj)
 {
 DataTable dt = obj2.UpdateState(obj);
 return dt;
 } //fetching state from database

 public DataTable UpdateCity(BeAddUser obj)
 {
 DataTable dt1 = obj2.UpdateCity(obj);
 return dt1;
 } //fetching city from table


 public int CheckOldPass(BeChange a)
 {
 if ((a.OldPassword == obj3.GetPass()))
 {
 return 1;
 }

 else
 {
 return -1;
 }
 } /*CHECK COMPLETE*/

 public int StartChangePass(BeChange a)
 {
 ChangePassword temp = new ChangePassword();
 if (temp.ChangePass(a) == 1)
 {
 return 1;
 }
 else
 return 0;
 }

 public int AddUser(BeAddUser a)
 {
     InsertUser obj = new InsertUser();
     int error = obj.Insert(a);
     return error;
 }
 }
}