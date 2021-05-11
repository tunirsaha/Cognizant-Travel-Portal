<%@ Page Title="" Language="C#" MasterPageFile="~/Master/master.Master" AutoEventWireup="true" CodeBehind="UserSearch.aspx.cs" Inherits="MasterData.UserSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" language="JavaScript">
<!--
 var nHist = window.history.length;
 if (window.history[nHist] != window.location)
 window.history.forward();
//-->
</script> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    Search User 
 to Edit Profile 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table style="margin-left:50px; margin-top:50px;">
<tr>
<td><asp:TextBox ID="txtUSERID" MaxLength="10" class="inputs" runat="server" Width="210px" Height="30px"></asp:TextBox></td>
<td><asp:Label ID="lblERROR" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label></td>
</tr>

<tr>
<td><asp:Button ID="btnSEARCH" class="inputsButton" runat="server" onclick="Button1_Click" Text="Search" /></td>
<td></td>
</tr>

</table>
</asp:Content>
