function Cancel_BookingVal() 
{

 var textbox = document.getElementById("ContentPlaceHolder1_TextBox1").value;
 var reg1=/^[0-9]{10}$/;
 if (!(textbox)) 
 {
 document.getElementById("bookingspan").innerHTML = "Please enter booking id";
 document.getElementById("bookingspan").style.color = "red";
 return false;
 }

 else {
 
 if(!textbox.match(reg1))
  {
  document.getElementById("bookingspan").innerHTML = "Invalid booking id";
  document.getElementById("bookingspan").style.color = "red";
  return false;
 }
  else 
  {
  document.getElementById("bookingspan").innerHTML = "";
  return true; 
  }
  }
 }
