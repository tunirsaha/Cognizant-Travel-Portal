using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
 public class addBusBE
 {
 public string bus_no { get; set; }
 public string bus_name { get; set; }
 public string bus_type { get; set; }
 
 }

 public class addRouteBE
 {
 public string route_id { get; set; }
 public string from { get; set; }
 public string to { get; set; }
 public Int32 cost { get; set; }

 }

 public class addScheduleBE
 {
 public string schedule_id { get; set; }
 public string bus_name{ get; set; }
 public string from{ get; set; }
 public string to{ get; set; }
 public string time { get; set; }
 }

 public class viewSchedule
 {
 public string bus_id { get; set; }
 public string bus_name{ get; set; }
 public string bus_type{ get; set; }
 public Int32 Max_seats{ get; set; }
 public string from{ get; set; }
 public string to{ get; set; }
 public Int32 cost{ get; set; }
 public string time { get; set; }
 }



 
 
}
