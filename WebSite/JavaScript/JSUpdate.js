function Username_validate() {
 var re = /^([A-Za-z\ \.]{1,30})$/;
 var f1 = 1;

 var name = document.getElementById('ContentPlaceHolder1_txtName').value;
 if (name== "") {
 document.getElementById("s1").innerHTML = "user name blank";
 document.getElementById("s1").style.color = "red";
 f1 = 0;
 }
 else {
 document.getElementById("s1").innerHTML = " ";
 if (!name.match(re)) {
 document.getElementById("s1").innerHTML = "Invalid User Name";
 document.getElementById("s1").style.color = "red";
 f1 = 0;
 }
 else {
 document.getElementById("s1").innerHTML = " ";
 }

 }
 return f1;
}
function Address_validate() {
 var pattern = /^([A-Za-z\.\-\/0-9\ \,]{1,50})$/;
 var f1 = 1;

 var name = document.getElementById('ContentPlaceHolder1_txtAdd').value;
 if (name == "") {
 document.getElementById("s2").innerHTML = "Address blank";
 document.getElementById("s2").style.color = "red";
 f1 = 0;
 }
 else {
 document.getElementById("s2").innerHTML = " ";
 if (!name.match(pattern)) {
 document.getElementById("s2").innerHTML = "Invalid Characters Present!!";
 document.getElementById("s2").style.color = "red";

 }
 else {
 document.getElementById("s2").innerHTML = " ";
 }
 }
 
 return f1;
}
function Country_validate() {
 var f1 = 1;

 if (document.getElementById('ContentPlaceHolder1_ddCount').selectedIndex == 0) {
 document.getElementById("s3").innerHTML = "Please Choose a country";
 document.getElementById("s3").style.color = "red";
 f1 = 0;
 }
 else {
 document.getElementById("s3").innerHTML = " ";
 }

 return f1;
}
function State_validate() {
 var f1 = 1;

 if (document.getElementById('ContentPlaceHolder1_ddState').selectedIndex == 0) {
 document.getElementById("s7").innerHTML = "Please Choose a state";
 document.getElementById("s7").style.color = "red";
 f1 = 0;
 }
 else {
 document.getElementById("s7").innerHTML = " ";
 }

 return f1;
}
function City_validate() {
 var f1 = 1;

 if (document.getElementById('ContentPlaceHolder1_ddCity').selectedIndex == 0) {
 document.getElementById("s8").innerHTML = "Please Choose a city";
 document.getElementById("s8").style.color = "red";
 f1 = 0;
 }
 else {
 document.getElementById("s8").innerHTML = " ";
 }

 return f1;
}
function Pincode_validate() {
 var re = /^([1-9]{1}[0-9]{5})$/;
 var f1 = 1;

 var name = document.getElementById('ContentPlaceHolder1_txtPin').value;
 if (name == "") {
 document.getElementById("s4").innerHTML = "Pincode blank";
 document.getElementById("s4").style.color = "red";
 f1 = 0;
 }
 else {
 document.getElementById("s4").innerHTML = " ";
 if (!name.match(re)) {
 document.getElementById("s4").innerHTML = "Invalid Pincode";
 document.getElementById("s4").style.color = "red";
 f1 = 0;
 }
 else {
 document.getElementById("s4").innerHTML = " ";
 }

 }
 return f1;
}
function Email_validate() {
 var re = /^([0-9a-zA-Z\.\_]{1,20})\@([0-9a-zA-Z]{1,20})\.([0-9a-zA-Z]{1,20}).?([a-zA-Z]{1,20})?$/;
 var f1 = 1;

 var name = document.getElementById('ContentPlaceHolder1_txtEmail').value;
 if (name == "") {
 document.getElementById("s5").innerHTML = "Email blank";
 document.getElementById("s5").style.color = "red";
 f1 = 0;
 }
 else {
 document.getElementById("s5").innerHTML = " ";
 if (!name.match(re)) {
 document.getElementById("s5").innerHTML = "Invalid Email";
 document.getElementById("s5").style.color = "red";
 f1 = 0;
 }
 else {
 document.getElementById("s5").innerHTML = " ";
 }

 }
 return f1;
}
function Contact_validate() {
 var re = /^(([0]{1})?([1-9]{1})([0-9]{9}))$/;
 var f1 = 1;

 var name = document.getElementById('ContentPlaceHolder1_txtCont').value;
 if (name == "") {
 document.getElementById("s6").innerHTML = "Contact blank";
 document.getElementById("s6").style.color = "red";
 f1 = 0;
 }
 else {
 document.getElementById("s6").innerHTML = " ";
 if (!name.match(re)) {
 document.getElementById("s6").innerHTML = "Invalid Contact";
 document.getElementById("s6").style.color = "red";
 f1 = 0;
 }
 else {
 document.getElementById("s6").innerHTML = " ";
 }

 }
 return f1;
}

function Validate() {
 f1 = Username_validate();
 f2 = Address_validate();
 f3 = Country_validate();
 f4 = Pincode_validate();
 f5 = Email_validate();
 f6 = Contact_validate();
 f7 = State_validate();
 f8 = City_validate();

 if (f1 == 1 && f2 == 1 && f3 == 1 && f4 == 1 && f5 == 1 && f6 == 1&&f7==1&&f8==1) {
 var retVal = confirm("Are you sure you want to update this user?");

 if (retVal == true) {
 alert("Updation Successfull !!");
 return true;
 } else {
 alert("Updation canceled !!");
 return false;
 }
 }
 else
 return false;

}

function DeleteConfirm() {
 var ret = confirm("Are you sure you want to delete this user?");

 if (ret == true) {
 alert("Deletion Successfull");
 return true;
 } else {
 alert("Deletion Canceled");
 return false;
 }
}

function Rdirect() {
 if (1 == 1)
 return confirm("Are you sure you want to exit?");
 else
 return false;
}
