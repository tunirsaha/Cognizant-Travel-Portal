using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
 public class BeBooking
 {
 public string start { get; set; }
 public string destination { get; set; }
 public DateTime dte { get; set; }
 public long uid { get; set; }
 public string bus_name { get; set; }
 public string bus_id { get; set; }
 public string route_id { get; set; }
 public int noOfTickets { get; set; }
 public string schedule_id { get; set; }
 public string bookingid { get; set; }
 public DateTime time { get; set; }
 public float cost { get; set; }
 public int tot_tck { get; set; }
 } 
}
