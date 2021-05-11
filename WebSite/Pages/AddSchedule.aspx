<%@ Page Title="" Language="C#" MasterPageFile="~/Master/master.Master" AutoEventWireup="true" CodeBehind="AddSchedule.aspx.cs" Inherits="WebSite.addSchedule" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table style="margin-top: 20px; margin-left: 50px;">
<tr>
<td>
<asp:Label ID="lblScheduleID" runat="server" Text="Schedule Id"></asp:Label>
</td>
<td>

<asp:TextBox ID="txtScheduleID" class="inputs" runat="server"></asp:TextBox><td><span id="s5"></span></td>
</td>
</tr>
<tr>
<td>

<asp:Label ID="lblBusName" runat="server" Text="Bus Name"></asp:Label>
</td>
<td>

<asp:DropDownList ID="drpBusName" class="inputs" runat="server" 
onselectedindexchanged="drpBusName_SelectedIndexChanged">
</asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblTime" runat="server" Text="Time"></asp:Label>
</td>
<td>



<asp:TextBox ID="txtTime" class="inputs" runat="server" onblur="time()" onchange="time()" onfocus="document.getElementById(' ').innerHTML = ' ';" ></asp:TextBox><td><span id="s6"></span></td>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblFrom" runat="server" Text="From"></asp:Label>
</td>
<td>
 
 <asp:DropDownList ID="drpFrom" class="inputs" runat="server" 
DataTextField="city_name" DataValueField="city_name" 
onselectedindexchanged="drpFrom_SelectedIndexChanged" AutoPostBack="True" 
Height="36px" Width="132px">
</asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblTo" runat="server" Text="To"></asp:Label>
</td>
<td>


<asp:DropDownList ID="drpTo" class="inputs" runat="server" 
DataTextField="destination" DataValueField="destination" 
onselectedindexchanged="drpTo_SelectedIndexChanged" Height="36px" 
Width="127px">
</asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Button ID="btnSubmit" class="inputsButton" runat="server" Text="SUBMIT" 
onclick="btnSubmit_Click" OnClientClick = "ConfirmSchedule()" 
Width="79px"/>
</td>
<td>
<asp:Button ID="btnReset" class="inputsButton" runat="server" Text="RESET" 
onclick="btnReset_Click" />
</td>
</tr>
</table>
</asp:Content>
<asp:Content ID="Content3" runat="server" 
contentplaceholderid="ContentPlaceHolder2">
Add New Schedule 
</asp:Content>

