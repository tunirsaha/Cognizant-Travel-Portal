<%@ Page Title="" Language="C#" MasterPageFile="~/Master/master.Master" AutoEventWireup="true" CodeBehind="Success.aspx.cs" Inherits="WebSite.Pages.Success" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
 User Added Successfully !!
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <table style="margin-top:50px; margin-left:50px;">
 
 <tr>
 <td>
     <asp:Label ID="UserID" runat="server"></asp:Label>
&nbsp;has been Added Successfully !!</td>
 </tr>

 <tr>
 <td>
 &nbsp;</td>
 </tr>
 
 <tr>
 <td>
 Do you wish to add another User ?
 </td>
 <td>
     &nbsp;</td>
 </tr>
 <tr>
 <td>
     &nbsp;</td>
 <td>
     &nbsp;</td>
 </tr>
 <tr>
 <td>
 <asp:Button ID="Button2" runat="server" class="inputsButton" onclick="Button2_Click" Text="Yes" />
 &nbsp;&nbsp;
 <asp:Button ID="Button1" runat="server" class="inputsButton" onclick="Button1_Click" Text="No" />
 </td>
 <td>
     &nbsp;</td>
 </tr>
 </table>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
 @ Offers Today
 </asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
<asp:Image ID="Image1" runat="server" ImageUrl="~/Images/ad.gif" />
 </asp:Content>