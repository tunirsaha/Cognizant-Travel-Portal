
function checkSchedule() { 
 f1=Schedule_id();
 f2=time();
 if(f1==1 && f2==1){
 return 1;
 }
 else{
 return 0;
 }

}

function checkbus() { 
 f1=bus_id();
 f2=bus_name();
 if(f1==1 && f2==1){
 return true;
 }
 else {
 return false;
 }

}

function checkRoute() {
 f1 = route_id();
 f2 = cost();
 f3=routeName()
 if (f1 == 1 && f2 == 1 && f3 == 1) {
 return 1;
 }
 else {
 return 0;
 }

}

function routeName() {
 var f1 = 1;
var routeTo= document.getElementById("ContentPlaceHolder1_drpTo").value;
var routeFrom = document.getElementById("ContentPlaceHolder1_drpFrom").value;
if (routeTo == routeFrom) {
 document.getElementById("route").innerHTML = "Select Different Destination";
 document.getElementById("route").style.color = "red";
 f1 = 0;
}

}

function bus_id() {
 var re = /^[B]+([0-9]{3})$/;
 var f1 = 1;

 var userid ;
 userid = document.getElementById("ContentPlaceHolder1_txtBusID").value;
 if (userid == "") {
 document.getElementById("s1").innerHTML = "Enter Bus no.";
 document.getElementById("s1").style.color = "red";
 f1 = 0;
 }
 else {
 document.getElementById("s1").innerHTML = " ";
 if (!userid.match(re)) {
 document.getElementById("s1").innerHTML = "Incorrect ID !!";
 document.getElementById("s1").style.color = "red";
 f1 = 0;
 }
 else {
 document.getElementById("s1").innerHTML = " ";
 }

 }
 return f1;
}
function Schedule_id() {
 var re = /^[S]+([0-9]{3})$/;
 var f1 = 1;

 var userid;
 userid = document.getElementById("ContentPlaceHolder1_txtScheduleID").value;
 if (userid == "") {
 document.getElementById("s5").innerHTML = "Enter Schedule ID";
 document.getElementById("s5").style.color = "red";
 f1 = 0;
 }
 else {
 document.getElementById("s5").innerHTML = " ";
 if (!userid.match(re)) {
 document.getElementById("s5").innerHTML = "Invalid Schedule Id";
 document.getElementById("s5").style.color = "red";
 f1 = 0;
 }
 else {
 document.getElementById("s5").innerHTML = " ";
 }

 }
 return f1;
}
function ConfirmSchedule() {
 f1 = checkSchedule();
 
 if (f1 == 1) {
 var confirm_value = document.createElement("INPUT");
 confirm_value.type = "hidden";
 confirm_value.name = "confirm_value";
 if (confirm("Do you want to save data?")) {
 confirm_value.value = "Yes";
 } else {
 confirm_value.value = "No";
 }
 document.forms[0].appendChild(confirm_value);
 }
}

function ConfirmBus() {
 
 f1 = checkbus();
 
 if (f1 == 1) {
 var confirm_value = document.createElement("INPUT");
 confirm_value.type = "hidden";
 confirm_value.name = "confirm_value";
 if (confirm("Do you want to save data?")) {
 confirm_value.value = "Yes";
 } else {
 confirm_value.value = "No";
 }
 document.forms[0].appendChild(confirm_value);
 }
}

function ConfirmRoute() {
 
 f1 = checkRoute();
 if (f1 == 1) {
 var confirm_value = document.createElement("INPUT");
 confirm_value.type = "hidden";
 confirm_value.name = "confirm_value";
 if (confirm("Do you want to save data?")) {
 confirm_value.value = "Yes";
 } else {
 confirm_value.value = "No";
 }
 document.forms[0].appendChild(confirm_value);
 }
}

function bus_name() {
 
 var f1 = 1;

 var userid;
 userid = document.getElementById("ContentPlaceHolder1_txtBusID").value;
 if (userid == "") {
 document.getElementById("s2").innerHTML = "Enter Bus name";
 document.getElementById("s2").style.color = "red";
 f1 = 0;
 }
 
 return f1;
}
function cost() {

 var f1 = 1;

 var userid;
 userid = document.getElementById("ContentPlaceHolder1_txtCost").value;
 if (userid == "") {
 document.getElementById("s4").innerHTML = "Enter Cost";
 document.getElementById("s4").style.color = "red";
 f1 = 0;
 }

 return f1;
}


function route_id() {
 var re = /^[R]+([0-9]{3})$/;
 var f1 = 1;

 var userid;
 userid = document.getElementById("ContentPlaceHolder1_txtRouteId").value;
 if (userid == "") {
 document.getElementById("s3").innerHTML = "Enter Route Id";
 document.getElementById("s3").style.color = "red";

 f1 = 0;
 }
 else {
 document.getElementById("s3").innerHTML = " ";
 if (!userid.match(re)) {
 document.getElementById("s3").innerHTML = "Invalid Route Id.";
 document.getElementById("s3").style.color = "red";
 f1 = 0;
 }
 else {
 document.getElementById("s3").innerHTML = " ";
 }

 }
 return f1;
}
function time() {
 var f1 = 1;
 var re = /^([01]\d|2[0123])(:[0-5]\d){1}$/;
 var userid;
 userid = document.getElementById("ContentPlaceHolder1_txtTime").value;
 if (userid == "") {
 document.getElementById("s6").innerHTML = "Enter Time";
 document.getElementById("s6").style.color = "red";
 f1 = 0;
 }
 else {
 document.getElementById("s6").innerHTML = " ";
 if (!userid.match(re)) {
 document.getElementById("s6").innerHTML = "Invalid Time";
 document.getElementById("s6").style.color = "red";
 f1 = 0;
 }
 else {
 document.getElementById("s6").innerHTML = " ";
 }

 }
 return f1;
}
