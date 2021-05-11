/*----------------------------Login and ChangePass ------------------------------*/


function ok() {
 var k1 = CheckThreePass();
 if (k1 == 1)
 return true;
 else
 return false;
}

function CheckThreePass() {

 var c2 = CheckEmptyNewPass();
 var c3 = 0;
 var s2 = document.getElementById('ContentPlaceHolder1_ConfirmPassChange').value;
 var s1 = document.getElementById('ContentPlaceHolder1_NewPassChange').value;

 if(s2=="") {
 document.getElementById("CheckThreePass").innerHTML = "Empty Field!!";
 document.getElementById("CheckThreePass").style.color = "red";
 }
 else {
 if(s2==s1){
 document.getElementById("CheckThreePass").innerHTML = "Passwords Match!!";
 document.getElementById("CheckThreePass").style.color = "blue";
 c3 = 1;
 }
 else {
 document.getElementById("CheckThreePass").innerHTML = "Passwords do not Match!!";
 document.getElementById("CheckThreePass").style.color = "red";
 }
 }
 return c3;

 }

 function CheckEmptyOldPass() {
 var k1 = 0;
 var s1 = document.getElementById('ContentPlaceHolder1_OldPassChange').value;
 if (s1=="") {
 document.getElementById("CheckEmptyOldPass").innerHTML = "Empty Field!!";
 document.getElementById("CheckEmptyOldPass").style.color = "red";
 }
 else {
 document.getElementById("CheckEmptyOldPass").innerHTML = " ";
 k1 = 1;
 }
 return k1;
 }

 function CheckEmptyNewPass() {
 var k2 = 0;
 var s2 = document.getElementById('ContentPlaceHolder1_NewPassChange').value;
 if (s2 == "") {
 document.getElementById("CheckEmptyNewPass").innerHTML = "Empty Field!!";
 document.getElementById("CheckEmptyNewPass").style.color = "red";
 }
 else {
 document.getElementById("CheckEmptyNewPass").innerHTML = " ";
 k1 = 1;
 }
 return k2;
 }


 
 
 /*----------------------------Login and ChangePass ------------------------------*/