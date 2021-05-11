using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using BE;

namespace BAL
{
 public class BalBooking1
 {
 public int SearchUser(BeBooking user)
 {
 DalBooking1 dal = new DalBooking1();
 try
 {
 int val = dal.SearchUser(user);
 return val;
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
 }
}
