using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using BE;
using System.Data;

namespace BAL
{
 public class UpdateBal
 {
 UpdateDal obj2 = new UpdateDal();
 public DataTable findCountry()
 {
 UpdateDal obj1 = new UpdateDal();
 try
 {
 DataTable dt = obj1.UpdateCountry();
 return dt;

 }
 catch
 {
 throw;
 }
 finally
 {
 obj1 = null;
 }


 }
 public DataTable UpdateState(GetUser obj)
 {
 DataTable dt = obj2.UpdateState(obj);
 return dt;
 }

 public DataTable UpdateCity(GetUser obj)
 {
 DataTable dt1 = obj2.UpdateCity(obj);
 return dt1;
 }
 public GetUser show(string t11)
 {
 UpdateDal d = new UpdateDal();
 GetUser bus = d.show(t11);
 return bus;

 }
 public GetUser show1(string t1, string t2, string t3, string t4, string t5, string t6, string t7, string t8, string t9, string t10, string t11)
 {
 UpdateDal d = new UpdateDal();
 GetUser bus = d.show1(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
 return bus;
 }
 public int SearchUser(string t11)
 {
 UpdateDal dal = new UpdateDal();
 return dal.SearchUser(t11);

 }
 public GetUser delete(string t11)
 {
 UpdateDal d = new UpdateDal();
 GetUser bus = new GetUser();
 try
 {
 bus = d.delete(t11);
 }
 catch
 {
 throw;
 }
 return bus;
 }
 }
}
