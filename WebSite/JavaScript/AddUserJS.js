/* ----------- AddUser.aspx -----------------*/

function NameValidate() {
 var pattern = /^([A-Za-z\ \.]{1,30})$/;
 var name = 0;
 var userid = document.getElementById('ContentPlaceHolder1_TxtAddName').value;

 if (userid == "") {
 document.getElementById("NameError").innerHTML = "Cannot be Blank!!";
 document.getElementById("NameError").style.color = "red";
 }
 else {
 document.getElementById("NameError").innerHTML = "";
 if (!userid.match(pattern)) {
 document.getElementById("NameError").innerHTML = "Invalid Characters Present!!";
 document.getElementById("NameError").style.color = "red";

 }
 else {
 document.getElementById("NameError").innerHTML = "";
 name = 1;
 }

 }
 return name;
}



function AddressValidate() {
 var pattern = /^([A-Za-z\.\-\/0-9\ \,]{1,50})$/;
 var address = 0;
 var userid = document.getElementById('ContentPlaceHolder1_TxtAddAddress').value;

 if (userid == "") {
 document.getElementById("AddressError").innerHTML = "Cannot be Blank!!";
 document.getElementById("AddressError").style.color = "red";
 }
 else {
 document.getElementById("AddressError").innerHTML = "";
 if (!userid.match(pattern)) {
 document.getElementById("AddressError").innerHTML = "Invalid Characters Present!!";
 document.getElementById("AddressError").style.color = "red";

 }
 else {
 document.getElementById("AddressError").innerHTML = "";
 address = 1;
 }

 }
 return address;
}



function PinValidate() {
 var pattern1 = /^([1-9]{1}[0-9]{5})$/;
 var pin = 0;
 var userid1 = document.getElementById('ContentPlaceHolder1_TxtAddPin').value;

 if (userid1 == "") {
 document.getElementById("PinError").innerHTML = "Cannot be Blank!!";
 document.getElementById("PinError").style.color = "red";
 }
 else {
 document.getElementById("PinError").innerHTML = "";

 if (!userid1.match(pattern1)) {
 document.getElementById("PinError").innerHTML = "Should be a 6 digit number !!";
 document.getElementById("PinError").style.color = "red";

 }

 else {
 document.getElementById("PinError").innerHTML = "";
 pin = 1;
 }

 }
 return pin;
}


function EmailValidate() {
 var pattern2 = /^([0-9a-zA-Z\.\_]{1,20})\@([0-9a-zA-Z]{1,20})\.([0-9a-zA-Z]{1,20}).?([a-zA-Z]{1,20})?$/;
 var email = 0;
 var userid2 = document.getElementById('ContentPlaceHolder1_TxtAddEmail').value;

 if (userid2 == "") {
 document.getElementById("EmailError").innerHTML = "Cannot be Blank!!";
 document.getElementById("EmailError").style.color = "red";
 }
 else {
 document.getElementById("EmailError").innerHTML = "";

 if (!userid2.match(pattern2)) {
 document.getElementById("EmailError").innerHTML = "Not a Valid E-mail ID !!";
 document.getElementById("EmailError").style.color = "red";

 }

 else {
 document.getElementById("EmailError").innerHTML = "";
 email = 1;
 }

 }
 return email;
}

function ContactValidate() {
 var pattern3 = /^(([0]{1})?([1-9]{1})([0-9]{9}))$/;
 var contact = 0;
 var userid3 = document.getElementById('ContentPlaceHolder1_TxtAddContact').value;

 if (userid3 == "") {
 document.getElementById("ContactError").innerHTML = "Cannot be Blank!!";
 document.getElementById("ContactError").style.color = "red";
 }
 else {
 document.getElementById("ContactError").innerHTML = "";

 if (!userid3.match(pattern3)) {
 document.getElementById("ContactError").innerHTML = "Not a Valid Contact Number !!";
 document.getElementById("ContactError").style.color = "red";

 }

 else {
 document.getElementById("ContactError").innerHTML = "";
 contact = 1;
 }

 }
 return contact;
}


function DobValidate() {
 var pattern3 = /^((0[13578]|1[02])[\/.](0[1-9]|[12][0-9]|3[01])[\/.](18|19|20)[0-9]{2})|((0[469]|11)[\/.](0[1-9]|[12][0-9]|30)[\/.](18|19|20)[0-9]{2})|((02)[\/.](0[1-9]|1[0-9]|2[0-8])[\/.](18|19|20)[0-9]{2})|((02)[\/.]29[\/.](((18|19|20)(04|08|[2468][048]|[13579][26]))|2000))$/;
 var dob = 0;
 var now = new Date();
 var userid3 = document.getElementById('ContentPlaceHolder1_TxtAddDob').value;
 var bdate = new Date(userid3);

 if (userid3 == "") {
 document.getElementById("DobError").innerHTML = "Cannot be Blank!!";
 document.getElementById("DobError").style.color = "red";
 }
 else {
 document.getElementById("DobError").innerHTML = "";

 if (!userid3.match(pattern3)) {
 document.getElementById("DobError").innerHTML = "Use MM/dd/yyyy format !!";
 document.getElementById("DobError").style.color = "red";

 }
 else {
 document.getElementById("DobError").innerHTML = " ";
 var age = now.getYear() - bdate.getYear();
 if (now.getMonth() < bdate.getMonth() || (now.getMonth() == bdate.getMonth() && now.getDay() < bdate.getDay()))
 age--;
 else { }
 if (age < 18) {
 document.getElementById("DobError").innerHTML = "Age below 18 not allowed !!";
 document.getElementById("DobError").style.color = "red";
 }
 else if (age > 80) {
 document.getElementById("DobError").innerHTML = "Age above 80 not allowed !!";
 document.getElementById("DobError").style.color = "red";
 }
 else {
 document.getElementById("DobError").innerHTML = " ";
 dob = 1;
 }

 }
 }
 return dob;
}

function SubmitCheck() {
 var m1 = NameValidate();
 var m2 = AddressValidate();
 var m3 = PinValidate();
 var m4 = EmailValidate();
 var m5 = ContactValidate();
 var m6 = DobValidate();

 var k = m1 + m2 + m3 + m4 + m5 + m6;

 if (k == 6) {
 return true;
 }

 else {
 return false;
 }
}


/* ----------- AddUser.aspx -----------------*/