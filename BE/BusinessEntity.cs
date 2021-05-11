using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
 public class CancelUser
 {
 public string Booking_id { get; set; }
 public long userid { get; set; }
 public int noOfTickets { get; set; } 
 public string start { get; set; }
 public string destination { get; set; }
 public string busid { get; set; }
 public string busName { get; set; }
 public string userName { get; set; }
 public DateTime doj { get; set; }
 public float cost { get; set; }
 public int wt_type { get; set; }

 }
}
