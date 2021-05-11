<%@ Page Title="" Language="C#" MasterPageFile="~/Master/master.Master" AutoEventWireup="true" CodeBehind="BookingCost.aspx.cs" Inherits="WebSite.BookingCost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
 .style1
 {
 width: 99px;
 }
 .style2
 {
 width: 99px;
 height: 48px;
 }
 .style3
 {
 height: 48px;
 }
        .style4
        {
            width: 120px;
            height: 48px;
        }
        .style5
        {
            width: 120px;
            text-align:left;
        }
 </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    Confirm number of Seats
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="margin-top: 55px; margin-left: 95px; font-family: Trebuchet MS;">

<tr>
<td class="style2" bgcolor="#FF9909">
 <br />
 CUST ID :</td>
<td style="text-align:left;" class="style3">
 <br />
 <input id="userid" type="text" runat="server" class="transparent_textbox" readonly/></td>
<td bgcolor="#FF9909" class="style4">
 <br />
 BUS NAME :</td>
<td class="style3">
 <br />
 <input id="busname" type="text" runat="server" class="transparent_textbox" readonly/></td>
</tr>

<tr>
<td class="style1">
 &nbsp;</td>
<td style="text-align:left;">
 &nbsp;</td>
<td class="style5">
    &nbsp;</td>
<td>
    &nbsp;</td>
</tr>

<tr>
<td class="style1" bgcolor="#FF9909">
 <br />
 NAME :</td>
<td>
 <br />
 <input id="uname" type="text" runat="server" class="transparent_textbox" readonly/></td>
<td bgcolor="#FF9909" class="style5">
 <br />
 DATE :</td>
<td>
 <br />
 <input id="date" type="text" runat="server" class="transparent_textbox" readonly/></td>
</tr>

<tr>
<td class="style1">
 &nbsp;</td>
<td>
 &nbsp;</td>
<td class="style5">
    &nbsp;</td>
<td>
    &nbsp;</td>
</tr>

<tr>
<td class="style1" bgcolor="#FF9909">
 <br />
 FROM : </td>
<td>
 <br />
 <input id="start" type="text" runat="server" class="transparent_textbox" readonly/></td>
<td bgcolor="#FF9909" class="style5">
 <br />
 TO :</td>
<td>
 <br />
 <input id="destination" type="text" runat="server" class="transparent_textbox" readonly/></td>
</tr>

<tr>
<td class="style1">
 &nbsp;</td>
<td>
 &nbsp;</td>
<td class="style5">
    &nbsp;</td>
<td>
    &nbsp;</td>
</tr>

<tr>
<td class="style1" bgcolor="#FF9909">
 <br />
 COST :</td>
<td>
 <br />
 <br />
 <input id="cost1" type="text" runat="server" class="transparent_textbox"/></td>
<td class="style5"></td>
<td>
 <br />
 </td>
</tr>

<tr>
<td class="style1">
 &nbsp;</td>
<td>
 &nbsp;</td>
<td class="style5">&nbsp;</td>
<td>
    &nbsp;</td>
</tr>

<tr>
<td class="style1" bgcolor="#FF9909">
 <br />
 TIME :</td>
<td>
 <br />
 <input id="time" type="text" runat="server" class="transparent_textbox" readonly/></td>
<td class="style5">
 <br />
 </td>
</tr>

<tr>
<td class="style1">
 &nbsp;</td>
<td>
 &nbsp;</td>
<td class="style5">
    &nbsp;</td>
</tr>

<tr>
<td class="style1" bgcolor="#FF9909">
 BOOK NO. 
 <br />
 OF TICKETS :<br />
</td>
<td><asp:DropDownList ID="ddlCost" class="inputs" runat="server" OnChange="GetSelected()">
 <asp:ListItem Selected="True">Select</asp:ListItem>
 <asp:ListItem>1</asp:ListItem>
 <asp:ListItem>2</asp:ListItem>
 <asp:ListItem>3</asp:ListItem>
 <asp:ListItem>4</asp:ListItem>
 <asp:ListItem>5</asp:ListItem>
 <asp:ListItem>6</asp:ListItem>
 <asp:ListItem>7</asp:ListItem>
 <asp:ListItem>8</asp:ListItem>
 <asp:ListItem>9</asp:ListItem>
 <asp:ListItem>10</asp:ListItem>
 </asp:DropDownList>
 </td>
<td class="style5"><span id="cost_span"></span></td>
<td>
 <br />
 <br />
 <asp:Button ID="btnBookTicket" class="inputsButton" runat="server" onclientclick="return cost_validate()" 
 onclick="btnBookTicket_Click" Text="BOOK TICKET" /></td>
</tr> 
</table>
</asp:Content>
