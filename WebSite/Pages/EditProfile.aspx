<%@ Page Title="" Language="C#" MasterPageFile="~/Master/master.Master" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="MasterData.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <style type="text/css">
 .style5
 {
 width: 189px;
 }
 .style6
 {
 width: 189px;
 height: 59px;
 }
 .style7
 {
 width: 159px;
 }
 .style8
 {
 width: 159px;
 height: 59px;
 }
 .style9
 {
 width: 189px;
 height: 24px;
 }
 .style10
 {
 width: 159px;
 height: 24px;
 }
 .style11
 {
 height: 24px;
 }
 .style12
 {
 height: 23px;
 }
 </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <p>
 <table style="width:83%; margin-left: 147px; margin-top: 0px;">
 <tr>
 <td class="style5">
 </td><td></td>
 <td class="style7">
 </td>
 </tr>
 <tr>
 <td class="style5">
 UserID</td>
 <td class="style7">
 <asp:Label ID="lblUserId" runat="server" Text="Label" Height="34px" 
 Width="150px"></asp:Label>
 </td><td></td>
 </tr>
 <tr>
 <td class="style5">
 Name</td>
 <td class="style7">
 <asp:TextBox ID="txtName" runat="server" class="inputs" 
 onblur="Username_validate()" onchange="Username_validate()" onfocus="document.getElementById('s1').innerHTML = ' ';" Height="20px" Width="150px"></asp:TextBox></td>
 <td><span id="s1"></span></td>
 </tr>
 <tr>
 <td class="style5">
 Address</td>
 <td class="style7">
 <asp:TextBox ID="txtAdd" MaxLength="50" runat="server" class="inputs" 
 onblur="Address_validate()" onfocus="document.getElementById('s2').innerHTML = ' ';" onchange="Address_validate()" Height="20px" Width="150px"></asp:TextBox></td>
 <td><span id="s2"></span>
 </td>
 </tr>
 <tr>
 <td class="style5">
 Country</td>
 <td class="style7">
 <asp:DropDownList ID="ddCount" runat="server" class="inputs" onblur="Country_validate()" onfocus="document.getElementById('s3').innerHTML = ' ';" onchange="Country_validate()" 
 Height="28px" Width="128px" AppendDataBoundItems="True" 
 AutoPostBack="True" DataTextField="country_name" 
 DataValueField="country_name" 
 onselectedindexchanged="DropDownList4_SelectedIndexChanged">
 <asp:ListItem>---Select---</asp:ListItem>
 </asp:DropDownList></td>
 <td><span id="s3"></span>
 </td>
 </tr>
 <tr>
 <td class="style6">
 State</td>
 <td class="style8">
 <asp:DropDownList ID="ddState" runat="server" class="inputs" 
 onblur="State_validate()" onfocus="document.getElementById('s7').innerHTML = ' ';" onchange="State_validate()" DataTextField="state_name" 
 DataValueField="state_id" Height="28px" Width="128px" 
 AppendDataBoundItems="True" AutoPostBack="True" 
 onselectedindexchanged="DropDownList2_SelectedIndexChanged">
 <asp:ListItem>--Select--</asp:ListItem>
 </asp:DropDownList></td>
 <td><span id="s7"></span>
 </td>
 </tr>
 <tr>
 <td class="style5">
 City</td>
 <td class="style7">
 <asp:DropDownList ID="ddCity" runat="server" class="inputs" 
 onblur="City_validate()" onfocus="document.getElementById('s8').innerHTML = ' ';" onchange="City_validate()" DataTextField="city_name" 
 DataValueField="city_name" Height="28px" Width="127px" 
 AppendDataBoundItems="True" AutoPostBack="True" 
 onselectedindexchanged="DropDownList3_SelectedIndexChanged">
 <asp:ListItem>--Select--</asp:ListItem>
 </asp:DropDownList></td>
<td><span id="s8"></span></td>
 </tr>
 <tr>
 <td class="style5">
 PinCode</td>
 <td class="style7">
 <asp:TextBox ID="txtPin" MaxLength="6" runat="server" class="inputs" 
 onblur="Pincode_validate()" onfocus="document.getElementById('s4').innerHTML = ' ';" onchange="Pincode_validate()" Height="20px" Width="150px"></asp:TextBox></td>
 <td><span id="s4"></span>
 </td>
 </tr>
 <tr>
 <td class="style5">
 Email</td>
 <td class="style7">
 <asp:TextBox ID="txtEmail" MaxLength="20" runat="server" class="inputs" 
 onblur="Email_validate()" onfocus="document.getElementById('s5').innerHTML = ' ';" onchange="Email_validate()" Height="20px" Width="150px"></asp:TextBox></td>
 <td><span id="s5"></span>
 </td>
 </tr>
 <tr>
 <td class="style5">
 Contact</td>
 <td class="style7">
 <asp:TextBox ID="txtCont" runat="server" MaxLength="11" class="inputs" 
 onblur="Contact_validate()" onfocus="document.getElementById('s6').innerHTML = ' ';" Height="20px" Width="150px"></asp:TextBox></td>
 <td><span id="s6"></span>
 </td>
 </tr>
 <tr>
 <td class="style5">
 DOB</td>
 <td class="style7">
 <asp:Label ID="lblDob" runat="server" Text="Label" Height="34px" Width="150px"></asp:Label>
 </td><td></td>
 </tr>
 <tr>
 <td class="style9">
 Gender</td>
 <td class="style10">
 <asp:Label ID="lblGend" runat="server" Text="Label" Height="30px" Width="150px" 
 style="margin-bottom: 0px"></asp:Label>
 </td><td class="style11"></td>
 </tr>
 <tr><td class="style12"></td><td class="style12"></td><td class="style12"></td></tr>
 <tr>
 <td class="style5">
 <asp:Button ID="btnUPDATE" runat="server" class = "inputsButton" Text="UPDATE" onclick="Button1_Click" 
 onclientClick="if ( ! Validate()) return false;" />
 </td>
 <td class="style7">
 <asp:Button ID="btnBACK" runat="server" class = "inputsButton" onclick="Button2_Click" Text="BACK" />
 </td><td>
 &nbsp;</td>
 </tr>
</table></p>
</asp:Content>
<asp:Content ID="Content3" runat="server" 
 contentplaceholderid="ContentPlaceHolder2">
 Update Profile Details
</asp:Content>

