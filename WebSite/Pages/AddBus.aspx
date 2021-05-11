<%@ Page Title="" Language="C#" MasterPageFile="~/Master/master.Master" AutoEventWireup="true" CodeBehind="AddBus.aspx.cs" Inherits="WebSite.addBus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <table style="margin-top:40px; margin-left:50px;">
  <tr>
  <td><asp:Label ID="lblBusNo" runat="server" Text="Bus No."></asp:Label></td>
  <td><asp:TextBox ID="txtBusID" class="inputs" runat="server" onblur="bus_id()" onchange="bus_id()" onfocus="document.getElementById('s1').innerHTML = ' ';" ></asp:TextBox></td>
  <td><span id="s1"></span></td>
  </tr>
  <tr>
  <td><asp:Label ID="lblBusName" runat="server" Text="Bus Name"></asp:Label></td>
  <td><asp:TextBox ID="txtBusName" class="inputs" runat="server" onblur="bus_name()" onchange="bus_name()" onfocus="document.getElementById('s2').innerHTML = ' ';" ></asp:TextBox></td>
  <td><span id="s2"></span></td>
  </tr>

  <tr>
  <td><asp:Label ID="lblBusType" runat="server" Text="Bus Type"></asp:Label></td>
  <td><asp:DropDownList ID="drpBusType" class="inputs" runat="server" DataSourceID="SqlDataSource1" 
 DataTextField="bus_type" DataValueField="bus_type" 
 onselectedindexchanged="drpBusType_SelectedIndexChanged"></asp:DropDownList>
  <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
 ConnectionString="<%$ ConnectionStrings:BusResSysConnectionString %>" 
 SelectCommand="SELECT [bus_type] FROM [tblBus_info]"></asp:SqlDataSource></td>
 </tr>

  <tr>
  <td>&nbsp;</td>
  <td>&nbsp;</td>
 </tr>

  <tr>
  <td><asp:Button ID="btnSubmit" class="inputsButton" runat="server" Text="SUBMIT" 
 onclick="btnSubmit_Click" OnClientClick = "return ConfirmBus()"/>
 
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
 Add New Bus
</asp:Content>

