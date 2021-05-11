<%@ Page Title="" Language="C#" MasterPageFile="~/Master/master.Master" AutoEventWireup="true" CodeBehind="ShowProfile.aspx.cs" Inherits="MasterData.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
 .style5
 {
 width: 206px;
 }
 .style6
 {
 width: 388px;
 }
 </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
 <table style="width:79%; margin-left: 137px;">
 <tr>
 <td class="style5">
 UserID</td>
 <td class="style6">
 <asp:Label ID="lblUserID" runat="server"></asp:Label>
 </td>
 </tr>
 <tr>
 <td class="style5">
 &nbsp;</td>
 <td class="style6">
 &nbsp;</td>
 </tr>
 <tr>
 <td class="style5">
 <asp:Label ID="NAME" runat="server" Text="Name"></asp:Label>
 </td>
 <td class="style6">
 <asp:Label ID="lblNAME" runat="server"></asp:Label>
 </td>
 </tr>
 <tr>
 <td class="style5">
 &nbsp;</td>
 <td class="style6">
 &nbsp;</td>
 </tr>
 <tr>
 <td class="style5">
 <asp:Label ID="ADD" runat="server" Text="Address"></asp:Label>
 </td>
 <td class="style6">
 <asp:Label ID="lblADD" runat="server"></asp:Label>
 </td>
 </tr>
 <tr>
 <td class="style5">
 &nbsp;</td>
 <td class="style6">
 &nbsp;</td>
 </tr>
 <tr>
 <td class="style5">
 <asp:Label ID="COUNT" runat="server" Text="Country"></asp:Label>
 </td>
 <td class="style6">
 <asp:Label ID="lblCOUNT" runat="server"></asp:Label>
 </td>
 </tr>
 <tr>
 <td class="style5">
 &nbsp;</td>
 <td class="style6">
 &nbsp;</td>
 </tr>
 <tr>
 <td class="style5">
 <asp:Label ID="STATE" runat="server" Text="State"></asp:Label>
 </td>
 <td class="style6">
 <asp:Label ID="lblSTATE" runat="server"></asp:Label>
 </td>
 </tr>
 <tr>
 <td class="style5">
 &nbsp;</td>
 <td class="style6">
 &nbsp;</td>
 </tr>
 <tr>
 <td class="style5">
 <asp:Label ID="CITY" runat="server" Text="City"></asp:Label>
 </td>
 <td class="style6">
 <asp:Label ID="lblCITY" runat="server"></asp:Label>
 </td>
 </tr>
 <tr>
 <td class="style5">
 &nbsp;</td>
 <td class="style6">
 &nbsp;</td>
 </tr>
 <tr>
 <td class="style5">
 <asp:Label ID="PIN" runat="server" Text="Pincode"></asp:Label>
 </td>
 <td class="style6">
 <asp:Label ID="lblPIN" runat="server"></asp:Label>
 </td>
 </tr>
 <tr>
 <td class="style5">
 &nbsp;</td>
 <td class="style6">
 &nbsp;</td>
 </tr>
 <tr>
 <td class="style5">
 <asp:Label ID="EMAIL" runat="server" Text="Email"></asp:Label>
 </td>
 <td class="style6">
 <asp:Label ID="lblEMAIL" runat="server"></asp:Label>
 </td>
 </tr>
 <tr>
 <td class="style5">
 &nbsp;</td>
 <td class="style6">
 &nbsp;</td>
 </tr>
 <tr>
 <td class="style5">
 <asp:Label ID="CONT" runat="server" Text="Contact"></asp:Label>
 </td>
 <td class="style6">
 <asp:Label ID="lblCONT" runat="server"></asp:Label>
 </td>
 </tr>
 <tr>
 <td class="style5">
 &nbsp;</td>
 <td class="style6">
 &nbsp;</td>
 </tr>
 <tr>
 <td class="style5">
 <asp:Label ID="DOB" runat="server" Text="DOB"></asp:Label>
 </td>
 <td class="style6">
 <asp:Label ID="lblDOB" runat="server"></asp:Label>
 </td>
 </tr>
 <tr>
 <td class="style5">
 &nbsp;</td>
 <td class="style6">
 &nbsp;</td>
 </tr>
 <tr>
 <td class="style5">
 <asp:Label ID="GEND" runat="server" Text="Gender"></asp:Label>
 </td>
 <td class="style6">
 <asp:Label ID="lblGEND" runat="server"></asp:Label>
 </td>
 </tr>
 <tr>
 <td class="style5">
 &nbsp;</td>
 <td class="style6">
 &nbsp;</td>
 </tr>
 <tr>
 <td class="style5">
 <asp:Button ID="btnEDIT" runat="server" class="inputsButton" 
 onclick="Button2_Click" Text="EDIT" Height="33px" Width="72px" />
 </td>
 <td class="style6">
 <asp:Button ID="btnCANCEL" class="inputsButton" runat="server" Text="CANCEL" 
  onclick="Button3_Click" onclientClick="if ( ! Rdirect()) return false;" 
 Width="72px" Height="33px" />
 <asp:Button ID="btnDELETE" class="inputsButton" runat="server" Text="DELETE" 
 onclientClick="if ( ! DeleteConfirm()) return false;" onclick="btnDELETE_Click" 
 style="margin-left: 100px" Height="33px" Width="72px" />
 </td>
 </tr>
 </table>
 </p>
 <p>
 &nbsp;</p>
 </asp:Content>
<asp:Content ID="Content3" runat="server" 
 contentplaceholderid="ContentPlaceHolder2">
    Profile Details
</asp:Content>

