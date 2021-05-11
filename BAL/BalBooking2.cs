using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using System.Configuration;
using System.Data.Sql;
using BE;

namespace BAL
{

 public class BalBooking2
 {
 
 DalBooking2 dal = new DalBooking2();
 public void InsertBooking(BeBooking bus)
 {
 dal.InsertBooking(bus);
 }
 public DataTable SearchBus(BeBooking bus)
 {
 
 try
 {
 DalBooking2 dal1 = new DalBooking2();
 DataTable dt = dal1.SearchBus(bus);
 return dt;
 }
 catch
 {
 throw;
 }
 finally
 {
 dal = null;
 }
 }

 public DataTable UpdateBus()
 {
 
 try
 {
 DataTable dt = dal.UpdateBus();
 return dt;

 }
 catch
 {
 throw;
 }
 finally
 {
 dal = null;
 }
 

 }
 public string GetUser(BeBooking user)
 {
 string name = dal.GetUser(user);
 return name;

 }
 public void UpdateTicket(BeBooking bus)
 {
 DalBooking2 dal = new DalBooking2();
 dal.UpdateTicket(bus);
 }
 }

}