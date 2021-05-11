<%@ Page Title="" Language="C#" MasterPageFile="~/Master/master.Master" AutoEventWireup="true" CodeBehind="AddRoute.aspx.cs" Inherits="WebSite.addRoute" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table style="margin-top:20px; margin-left:50px;">
<tr>
 <td>
<asp:Label ID="lblRouteID" runat="server" Text="Route ID"></asp:Label>
 </td>
 <td><asp:TextBox ID="txtRouteId" class="inputs" runat="server" 
onblur="route_id()" onchange="route_id()" onfocus="document.getElementById('s3').innerHTML = ' ';" Width="80px"></asp:TextBox> <span id ="s3"></span>
 </td>
</tr>
<tr>
 <td>
<asp:Label ID="lblFrom" runat="server" Text="From"></asp:Label>
 </td>
 <td>
<asp:DropDownList ID="drpFrom" class="inputs" runat="server" DataSourceID="SqlDataSource2" 
DataTextField="city_name" DataValueField="city_name" >

</asp:DropDownList>
<asp:SqlDataSource ID="SqlDataSource2" runat="server" 
ConnectionString="<%$ ConnectionStrings:BusResSysConnectionString %>" 
SelectCommand="SELECT [city_name] FROM [tblCity]"></asp:SqlDataSource>
 </td>
</tr>
<tr>
 <td>
<asp:Label ID="LblTo" runat="server" Text="To"></asp:Label>
 </td>
 <td>
<asp:DropDownList ID="drpTo" class="inputs" onblur="routeName()" runat="server" DataSourceID="SqlDataSource1" 
DataTextField="city_name" DataValueField="city_name">
</asp:DropDownList><span id="route"></span>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
ConnectionString="<%$ ConnectionStrings:BusResSysConnectionString %>" 
SelectCommand="SELECT [city_name] FROM [tblCity]"></asp:SqlDataSource>
 </td>
</tr>
<tr>
 <td>
<asp:Label ID="lblCost" runat="server" Text="Cost"></asp:Label>
 </td>
 <td>
<asp:TextBox ID="txtCost" class="inputs" runat="server" onblur="cost()" 
onchange="cost()" onfocus="document.getElementById('s4').innerHTML = ' ';" 
Width="80px" ></asp:TextBox> <span id="s4"></span>
 </td>
</tr>
<tr>
 <td>
<asp:Button ID="btnSubmit" class="inputsButton" runat="server" Text="SUBMIT" 
onclick="btnSubmit_Click" OnClientClick = "ConfirmRoute()"/>
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
 Add New Route 
</asp:Content>