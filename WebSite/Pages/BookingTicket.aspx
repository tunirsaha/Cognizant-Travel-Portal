<%@ Page Title="" Language="C#" MasterPageFile="~/Master/master.Master" AutoEventWireup="true" CodeBehind="BookingTicket.aspx.cs" Inherits="WebSite.BookingTicket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    E-Ticket
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="text-align:left; margin-left:50px; margin-top:50px;">

<tr>
<td>&nbsp;</td>
<td >&nbsp;</td>
<td >&nbsp;</td>
<td>&nbsp;</td>
</tr>

<tr>
<td>&nbsp;</td>
<td >&nbsp;</td>
<td >&nbsp;</td>
<td>&nbsp;</td>
</tr>

<tr>
<td class="inputsButton">DATE :</td>
<td ><input id="date" type="text" runat="server" class="transparent_textbox" readonly/></td>
<td ><input id="userid" type="text" style="text-align:left" runat="server" class="transparent_textbox" /></td>
<td><input id="uname" type="text" style="text-align:left" runat="server" class="transparent_textbox" /></td>
</tr>

<tr>
<td>&nbsp;</td>
<td >&nbsp;</td>
<td >&nbsp;</td>
<td>&nbsp;</td>
</tr>

<tr>
<td style="background-color:#FF9000">TIME :</td>
<td ><input id="time" type="text" runat="server" class="transparent_textbox" readonly/></td>
<td class="style3" ><div style="width: 76px; background-color:#FF9000;">BUS TYPE</div></td>
<td><input id="busname" type="text" style="text-align:left" runat="server" class="transparent_textbox" readonly/></td>
</tr>

<tr>
<td>&nbsp;</td>
<td >&nbsp;</td>
<td >&nbsp;</td>
<td>&nbsp;</td>
</tr>

<tr>
<td style="background-color:#FF9000">FARE :</td>
<td>Rs.<input id="cost" type="text" runat="server" class="transparent_textbox" style="text-align:left" readonly/></td>
<td >FROM :<input id="from" type="text" runat="server" style="text-align:left" class="transparent_textbox" readonly/></td>
<td>TO :<input id="to" type="text" runat="server" style="text-align:left" class="transparent_textbox" readonly/></td>
</tr>


<tr>
<td>&nbsp;</td>
<td >&nbsp;</td>
<td >&nbsp;</td>
<td>&nbsp;</td>
</tr>


<tr>
<td style="background-color:#FF9000">BKID</td>
<td ><input id="bookingid" type="text" runat="server" class="transparent_textbox" readonly/></td>
<td class="style3" style="text-align:right;">
<div style="margin-left: 76px; background-color:#FF9000;">SEATS BOOKED :</div></td>
<td><input id="noOftickets" type="text" style="text-align:left" runat="server" class="transparent_textbox" readonly/></td>
</tr>


<tr>
<td>&nbsp;</td>
<td >&nbsp;</td>
<td >&nbsp;</td>
<td>&nbsp;</td>
</tr>


<tr>
<td></td>
<td><button onclick="window.print()" class="inputsButton" id="BtnPrint">PRINT</button></td>
<td ><asp:Button ID="BtnHome" class="inputsButton" runat="server" 
 Text="HOME" Height="34px" onclick="Button1_Click" Width="79px" /></td>
<td >&nbsp;</td>
<td>&nbsp;</td>
</tr>


</table>

</asp:Content>
