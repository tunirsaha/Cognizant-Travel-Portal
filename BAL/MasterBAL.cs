using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using BE;
using System.Data;
using System.Data.SqlClient;

namespace BAL
{
 public class MasterBAL
 {
 
 
 public int BalAddBus(addBusBE a)
 {
 DAL.InsertBus obj = new DAL.InsertBus();
 int error = obj.newBus(a);
 return error;
 }
 
 public int BalAddRoute(addRouteBE a)
 {
 DAL.InsertBus obj = new DAL.InsertBus();
 int error = obj.newRoute(a);
 return error;
 }

 public DataTable findbusType()
 {
 DAL.InsertBus obj1 = new DAL.InsertBus();
 try
 {
 DataTable dt = obj1.findBusType();
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
 
 public int BalAddSchedule(addScheduleBE a)
 {
 DAL.InsertBus obj = new DAL.InsertBus();
 //int error=obj.
 int error = obj.newSchedule(a);
 return error;
 
 }
 
 public DataTable findToBus(addScheduleBE obj)
 {
 DAL.InsertBus obj1 = new DAL.InsertBus();
 DataTable dt = obj1.findToBus(obj);
 return dt;
 }
 
 public DataTable searchCity(addScheduleBE obj)
 {
 DAL.InsertBus obj1 = new DAL.InsertBus();
 DataTable dt = obj1.selectCity(obj);
 return dt;
 }

 public DataTable finalScheduleDetail()
 {
 DAL.InsertBus obj1 = new DAL.InsertBus();
 try
 {
 DataTable dt = obj1.getFinalSchedule();
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
 
 }
}
