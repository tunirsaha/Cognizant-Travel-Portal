function LoginButton() {
 var m1 = NameCheck();
 var m2 = PassCheck();

 var k = m1 + m2;

 if (k == 2)
 return true;

 else
 return false;
}

function NameCheck() {
 var pattern = /^([A-Za-z]{1,10})$/;
 var name = 0;
 var userid1 = document.getElementById('ContentPlaceHolder1_TxtLoginName').value;

 if (userid1 == "") {
 document.getElementById("NameErrorLogin").innerHTML = "Cannot be Blank!!";
 document.getElementById("NameErrorLogin").style.color = "red";
 }

 else {
 document.getElementById("NameErrorLogin").innerHTML = " ";
 name = 1;
 }
 return name;
}

function PassCheck() {
 var pattern = /^([0-9A-Za-z\!\@\#\*]{1,10})$/;
 var name = 0;
 var userid2 = document.getElementById('ContentPlaceHolder1_TxtLoginPass').value;

 if (userid2 == "") {
 document.getElementById("PassError").innerHTML = "Cannot be Blank!!";
 document.getElementById("PassError").style.color = "red";
 }

 else {
 document.getElementById("PassError").innerHTML = "";
 name = 1;
 }
 return name;
}