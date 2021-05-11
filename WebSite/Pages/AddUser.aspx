<%@ Page Title="" Language="C#" MasterPageFile="~/Master/master.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="WebSite.AddUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <style type="text/css">
 .style1
 {
 width: 159px;
 }
 .style2
 {
 width: 101px;
 }
 </style>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
 @ Offers Today
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
<asp:Image ID="Image1" runat="server" ImageUrl="~/Images/ad.gif" />
 </asp:Content>
<asp:Content ID="Content6" runat="server" 
 contentplaceholderid="ContentPlaceHolder2">
 Add New User
</asp:Content>
<asp:Content ID="Content7" runat="server" 
 contentplaceholderid="ContentPlaceHolder1">
 <br />
 <table style="width: 478px; margin-left: 146px">
 <tr><td class="style2">&nbsp;</td><td class="style1">
 &nbsp;</td><td>&nbsp;</td>
 </tr>
 <tr><td class="style2">Name :</td><td class="style1">
 <asp:TextBox ID="TxtAddName" class="inputs" runat="server" MaxLength="30" onchange="NameValidate()" onblur="NameValidate()" onfocus="document.getElementById('NameError').innerHTML = ''" 
 Width="150px" Height="20px"></asp:TextBox></td><td><span id="NameError"></span></td>
 </tr>
 <tr><td class="style2"></td><td class="style1"></td><td></td></tr>
 <tr>
 <td class="style2">Address :</td><td class="style1">
 <asp:TextBox ID="TxtAddAddress" class="inputs" runat="server" MaxLength="50" onchange="AddressValidate()" onblur="AddressValidate()" onfocus="document.getElementById('AddressError').innerHTML = ''" 
 Width="157px" Height="99px" TextMode="MultiLine"></asp:TextBox></td>
 <td><span id="AddressError"></span></td>
 </tr><tr><td class="style2"></td><td class="style1"></td><td></td></tr>
 <tr>
 <td class="style2">Country :</td>
 <td class="style1">
 <asp:DropDownList ID="LstAddCountry" class="inputs" runat="server" 
 Width="172px" Height="37px" 
 onselectedindexchanged="LstAddCountry_SelectedIndexChanged" 
 AutoPostBack="True">
 </asp:DropDownList></td><td>
 &nbsp;</td>
 </tr><tr><td class="style2"></td><td class="style1"></td><td></td></tr>
 <tr><td class="style2">State :</td><td class="style1">
 <asp:DropDownList ID="LstAddState" class="inputs" runat="server" Width="172px" Height="37px" 
 DataTextField="state_name" DataValueField="state_name" 
 onselectedindexchanged="LstAddState_SelectedIndexChanged" 
 AutoPostBack="True">
 </asp:DropDownList></td><td>&nbsp;</td>
 </tr><tr><td class="style2"></td><td class="style1">&nbsp;</td><td></td></tr>
 <tr><td class="style2">City :</td><td class="style1"> 
 <asp:DropDownList ID="LstAddCity" class="inputs" runat="server" Width="172px" Height="37px" 
 DataTextField="city_name" DataValueField="city_name">
 </asp:DropDownList></td><td>&nbsp;</td>
 </tr><tr><td class="style2"></td><td class="style1">&nbsp;</td><td></td></tr>
 <tr>
 <td class="style2">PinCode :</td><td class="style1">
 <asp:TextBox ID="TxtAddPin" class="inputs" MaxLength="6" onblur="PinValidate()" onchange="PinValidate()" onfocus="document.getElementById('PinError').innerHTML = ''" runat="server" Width="150px" 
  Height="25px"></asp:TextBox></td>
 <td><span id="PinError"></span></td>
 </tr>
 <tr>
 <td class="style2">&nbsp;</td><td class="style1">
 &nbsp;</td>
 <td>&nbsp;</td>
 </tr>
 <td class="style2">E-mail ID :</td><td class="style1">
 <asp:TextBox ID="TxtAddEmail" class="inputs" MaxLength="20" onblur="EmailValidate()" onchange="EmailValidate()" onfocus="document.getElementById('EmailError').innerHTML = ''" runat="server" 
 Width="150px" Height="25px"></asp:TextBox></td><td><span id="EmailError"></span></td>
 </tr><tr><td class="style2"></td><td class="style1"></td><td></td></tr>
 <tr>
 <td class="style2">Contact :</td><td class="style1">
 <asp:TextBox ID="TxtAddContact" class="inputs" MaxLength="11" onchange="ContactValidate()" onblur="ContactValidate()" onfocus="document.getElementById('ContactError').innerHTML = ''" runat="server" 
  Width="150px" Height="25px"></asp:TextBox></td>
 <td><span id="ContactError"></span></td>
 </tr><tr><td class="style2"></td><td class="style1"></td><td></td></tr>
 <tr>
 <td class="style2">DOB :</td><td class="style1">
 <asp:TextBox ID="TxtAddDob" class="inputs" MaxLength="10" runat="server" onblur="DobValidate()" onchange="DobValidate()" onfocus="document.getElementById('DobError').innerHTML = ''" Width="150px" 
 Height="25px"></asp:TextBox></td>
 <td><span id="DobError"></span></td>
 </tr><tr><td class="style2"></td><td class="style1"></td><td></td></tr>
 <tr>
 <td class="style2">Gender :</td><td class="style1">
 <asp:RadioButton ID="RdoAddMale" runat="server" Text="Male" 
  GroupName="Gender" /> &nbsp; <asp:RadioButton ID="RdoAddFemale" 
  runat="server" Text="Female" GroupName="Gender" />
 </td><td></td>
 </tr><tr><td class="style2"></td><td class="style1" height="35px"></td><td class="style5"></td></tr>
 <tr><td class="style2">
 <asp:Button ID="BtnAddSubmit" class="inputsButton" runat="server" onclick="BtnAddSubmit_Click" 
 Text="SUBMIT" Width="72px" Font-Names="Trebuchet MS" 
  onClientClick="return SubmitCheck()" Height="33px" />
 </td><td class="style1">
  &nbsp;</td><td>
 <asp:Button ID="BtnAddRst" class="inputsButton" runat="server" onclick="BtnAddRst_Click" 
 Text="RESET" Width="72px" Font-Names="Trebuchet MS" Height="33px" />
 </td></tr></table>
</asp:Content>


