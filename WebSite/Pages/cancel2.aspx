<%@ Page Language="C#" MasterPageFile="~/Master/master.Master" AutoEventWireup="true" CodeBehind="cancel2.aspx.cs" Inherits="Cancel.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <style type="text/css">
 .style1
 {
 width: 168px;
 }
 </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table style="margin-left:50px; margin-top:50px;">
<tr>
<td>User ID :
</td>
<td class="style1">
 <asp:TextBox ID="txtid1" class="inputs" runat="server" 
 style="margin-left: 0px; margin-top: 0px;" Width="135px" BackColor="#FF9955"></asp:TextBox>
</td>
<td>No of Tickets :
</td>
<td><asp:TextBox ID="txttickets" runat="server" class="inputs" 
 style="margin-left: 0px" Width="120px" BackColor="#FF9955"></asp:TextBox>
</td>
</tr>

<tr>
<td>User Name :
</td>
<td class="style1"><asp:TextBox ID="txtname" class="inputs" runat="server" 
 Width="135px" BackColor="#FF9955"></asp:TextBox >
</td>
<td>Start :
</td>
<td><asp:TextBox ID="txtstart" class="inputs" runat="server" Width="120px" 
 BackColor="#FF9955"></asp:TextBox>
</td>
</tr>

<tr>
<td>Bus ID :
</td>
<td class="style1"><asp:TextBox ID="txtbid" class="inputs" runat="server" 
 Width="135px" BackColor="#FF9955"></asp:TextBox>
</td>
<td>Destination :
</td>
<td><asp:TextBox ID="txtdest" class="inputs" runat="server" Width="120px" 
 BackColor="#FF9955" ></asp:TextBox>
</td>
</tr>

<tr>
<td>Bus Name :
</td>
<td class="style1"><asp:TextBox ID="txtbname" class="inputs" runat="server" 
 Width="135px" BackColor="#FF9955"></asp:TextBox>
</td>
<td>Date of Journey :
</td>
<td><asp:TextBox ID="txtdoj" class="inputs" runat="server" Width="120px" BackColor="#FF9955"></asp:TextBox>
</td>
</tr>

<tr>
<td>&nbsp;</td>
<td class="style1">&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>

<tr>
<td></td>
<td>
</td>
<td><asp:Button ID="Button1" class="inputsButton" runat="server" Text="Cancel My Ticket" 
onclientclick="if(confirm('Are you sure you want to cancel ticket?')){
window.location='Cancel3.aspx';
 
 return false;
 }
 else{}"
 onclick="Button1_Click" Height="33px" style="margin-left: 0px" Width="141px" />

</td>
<td>
</td>
</tr>

</table>

</asp:Content>
<asp:Content ID="Content3" runat="server" 
contentplaceholderid="ContentPlaceHolder2">
Ticket Details
</asp:Content>
