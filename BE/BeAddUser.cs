using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
 public class BeAddUser
 {
 public long uid { get; set; }
 public string Name { get; set; }
 public string Address { get; set; }
 public string City { get; set; }
 public string State { get; set; }
 public string Country { get; set; }
 public long PinCode { get; set; }
 public string Email { get; set; }
 public char Gender { get; set; }
 public long Contact { get; set; }
 public DateTime Dob { get; set; }

 }

 public class BeLogin
 {
 public string LoginName { get; set; }
 public string LoginPassword { get; set; }
 }

 public class BeChange
 {
 public string OldPassword { get; set; }
 public string NewPassword { get; set; }
 public string DatabaseFetch { get; set; }
 }

 public class Booking
 {
 public int CustId { get; set; }
 public string FromLocation { get; set; }
 public string ToLocation { get; set; }
 public DateTime DateOfBooking { get; set; }
 }
}
