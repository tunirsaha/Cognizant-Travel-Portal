<%@ Page Title="" Language="C#" MasterPageFile="~/Master/master.Master" AutoEventWireup="true" CodeBehind="BookingRoute.aspx.cs" Inherits="WebSite.BookingRoute" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <style type="text/css">
 #div1
{ height: 702px;
 margin-top:30px;
 width:689px;
 
 }
 #div1_1
 {
 height: 514px;
 
 width:681px;
 float:left; 
 }
 #div1_2
 {
 height: 512px;
 
 width:384px;
 float:right;
 
 }
 
 #div2
 {
 height: 213px;
 width: 324px;
 }
 
 #div1_4
 {
 height: 185px;
 }
 
 
 .style1
 {
 width: 191px;
 background-color:#FF6600;
 
 }
 
 
 .style2
 { width: 147px;
 height: 55px;
 }
 .style3
 {
 width: 147px;
 height: 52px;
 }
 .style4
 {
 height: 52px;
 }
 
 
 
 .style6
 {
 height: 48px;
 background-color:#FF9000;
 }
 
 
 
 .style7
 {
 height: 41px;
 }
 
 
 
 </style>
 </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
 
 Journey Details
 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
 <div id="div1">
 <div id="div1_1">
 <div id="div1_4" style="margin-left:125px; width: 416px; margin-top: 3px;">
  <table style="width:100%; text-align:center; height: 101px; margin-top: 0px;">
  <tr>
  <td class="style1">
 <asp:Label ID="lblcustid" runat="server" Text="CUST ID" style="color:White;"></asp:Label>
  </td>
  <td class="style6">
  <asp:Label ID="lbl_custid" runat="server" Text="Label" style=" color:White;"></asp:Label>
  </td>
  </tr>
  <tr>
  <td class="style1"> 
 <asp:Label ID="lblname" runat="server" Text="NAME" style=" color:White;"></asp:Label>
 </td>
  <td class="style6" >
 <asp:Label ID="lbl_name" runat="server" style=" color:White;" Text="Label"></asp:Label>
 
  </td>
  </tr>
  </table>
 </div>
 <div id="1_5" style="height: 370px; width: 301px; margin-left:126px;">
 <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
 ConnectionString="<%$ ConnectionStrings:BusResSysConnectionString %>" 
 SelectCommand="SELECT [city_name] FROM [tblCity]"></asp:SqlDataSource>
 <ul style="list-style-type:none; margin-left:0px;">
 <li>
 Select source :</li>
 </ul>
 <table style="width:100%; text-align:center; height: 115px;">
 <tr>
 <td class="style2">
 <asp:Label ID="lblfrom" runat="server" Text="From"></asp:Label>
 </td>
 <td>
 <asp:DropDownList ID="ddlFrom" class="inputs" runat="server" 
 DataSourceID="SqlDataSource1" DataTextField="city_name" 
 DataValueField="city_name" style="margin-left: 7px;">
 </asp:DropDownList>
 </td>
 </tr>
 <tr>
 <td class="style7" colspan="2" style="text-align:left;">
 Select destination :</td>
 </tr>
 <tr>
 <td class="style3">
 <asp:Label ID="lblto" runat="server" Text="To"></asp:Label>
 </td>
 <td class="style4">
 <asp:DropDownList ID="ddlTo" class="inputs" runat="server" 
 DataSourceID="SqlDataSource1" DataTextField="city_name" 
 DataValueField="city_name" style="margin-left: 7px">
 </asp:DropDownList>
 </td>
 </tr>
 </table>
 
 <br />
 <ul style="list-style-type:none; margin-left:0px;">
 <li style="margin-top: 9px"><span id="route_span"></span></li>
 <li style="margin-top: 12px; margin-left: 8px;">
 <asp:Label ID="lbldate" runat="server" Text="Select Date :"></asp:Label></li>
 <li style="margin-left: 5px">
 <asp:TextBox ID="txtDate" class="inputs" runat="server" onchange="Date_Validate()" 
 style="margin-top: 11px; margin-left: 4px;"></asp:TextBox>
 </li>
 <li><span id ="date_span"></span>
 </li>
 </ul>
 <br />
 <br />
 <br />
 <br />
 <p>

 <asp:Button ID="btnReset" class="inputsButton" runat="server" Text="RESET" onclick="btnReset_Click" 
 style="margin-left: 24px" Width="70px" />

 <asp:Button ID="btnSubmit" runat="server" Text="SUBMIT" class="inputsButton" 
 onclientclick="return validate2()" onclick="btnSubmit_Click" 
 Width="70px" />

 </p>
 
 </div>
 </div> 
 </div> 
 </asp:Content>
