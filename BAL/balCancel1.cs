using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using BE;


namespace BAL
{
 public class balCancel1
 {
 CancelUser be2 = new CancelUser();
 DalCancel1 dal1 = new DalCancel1();
 public DataTable Search_bkng1(int userid)
 {
 return dal1.Search_bkng1(userid);
 }
 public int chkuserId1(long userid1)
 {
 try
 {
 return dal1.chkuserId1(userid1);
 }
 catch
 {
 throw;
 }

 }
 public CancelUser search_user1(string userid)
 {
  try
  {
  be2 = dal1.search_user(userid);
  return be2;
  }
  catch
  {
  throw;
  }
 
 }

 public void dltbkingId(string bkngid)
 {
 dal1.dltbkingId1(bkngid);
 }
 public void update_seats1(string bkngid,string doj,int noOfTickets)
 {
  dal1.update_seats(bkngid, doj, noOfTickets);
 }
 }
}
