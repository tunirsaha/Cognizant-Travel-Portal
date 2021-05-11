function GetSelected() {


 
 var e = document.getElementById("ContentPlaceHolder1_ddlCost");
 var noOfTickets = Number(e.options[e.selectedIndex].text);
 var text = document.getElementById("ContentPlaceHolder1_cost1");
 if (String(noOfTickets) == "NaN") {
 text.value = "";
 }
 else {
 var cost1 = String(cost * noOfTickets);

 text.value = cost1 + ".00";
 }
}

function userid_validate(){

 var userid = document.getElementById("ContentPlaceHolder1_userid").value;
 if (userid == "") {
 document.getElementById("userid_span").innerHTML = "Please Enter User id";
 document.getElementById("userid_span").style.color = "red";
 document.getElementById("userid_span").style.font = "Calibri";
 return false;
 }
 else {
 document.getElementById("userid_span").innerHTML = " ";
 var reg = /^\d{10}$/;
 
 if (!reg.test(userid)) {
 document.getElementById("userid_span").innerHTML = "Invalid user name";
 document.getElementById("userid_span").style.color = "red";
 return false;
 }

 else {
 document.getElementById("userid_span").innerHTML = "";
 return true;
 
 }
 }

}

function Grid_Validate() {
 var gv = document.getElementById("ContentPlaceHolder1_GridView1");
 var radio = gv.getElementsByTagName("input");
 var check= false;
 for (i = 0; i < radio.length; i++) {
 if (radio[i].type = "radio") {
 if (radio[i].checked)
 check = true;
 }
 }
 if (check)
 return true;
 else {
 document.getElementById("GridView1_span").innerHTML = "Please Select a Bus";
 document.getElementById("GridView1_span").style.color = "red";
 document.getElementById("GridView1_span").style.font = "Calibri";
 return false;
 }
}

function Route_Validate() {
 var from = document.getElementById("ContentPlaceHolder1_ddlFrom");
 var value1 = from.options[from.selectedIndex].value;
 var to = document.getElementById("ContentPlaceHolder1_ddlTo");
 var value2 = to.options[to.selectedIndex].value;
 if (value1 == value2) {
 document.getElementById("route_span").innerHTML = "Source and Destination cannot be same";
 document.getElementById("route_span").style.color = "red";
 document.getElementById("route_span").style.font = "Calibri";
 return false;
 }
 else {
 return true;
 }


}

function Date_Validate() {

 var pattern3 = /^((0[13578]|1[02])[\/.](0[1-9]|[12][0-9]|3[01])[\/.](18|19|20)[0-9]{2})|((0[469]|11)[\/.](0[1-9]|[12][0-9]|30)[\/.](18|19|20)[0-9]{2})|((02)[\/.](0[1-9]|1[0-9]|2[0-8])[\/.](18|19|20)[0-9]{2})|((02)[\/.]29[\/.](((18|19|20)(04|08|[2468][048]|[13579][26]))|2000))$/;
 var now = new Date();
 var userid3 = document.getElementById("ContentPlaceHolder1_txtDate").value;
 var bdate = new Date(userid3);
 if (userid3 == "") {
 document.getElementById("date_span").innerHTML = "Please Enter Date";
 document.getElementById("date_span").style.color = "red";
 return false;
 }
 else {
 document.getElementById("date_span").innerHTML = "";

 if (!userid3.match(pattern3)) {
 document.getElementById("date_span").innerHTML = "Please Enter Valid Date";
 document.getElementById("date_span").style.color = "red";
 return false;

 }
 else {
 document.getElementById("date_span").innerHTML = " ";
 return true;
 }
 }


}
 function validate2() {
 var route=Route_Validate();
 var date= Date_Validate();
 if(route && date){
 return true;
 }
 else{
 return false;
 }
 }

 function cost_validate() {
 var cost=document.getElementById("ContentPlaceHolder1_cost1").value;
 if(cost==""){
 document.getElementById("cost_span").innerHTML = "Select Tickets !!";
 document.getElementById("cost_span").style.color = "red";
 return false;
 }
 else {
 document.getElementById("cost_span").innerHTML = " ";
 return true;
 }
 }
