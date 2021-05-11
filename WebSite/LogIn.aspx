<%@ Page Title="" Language="C#" MasterPageFile="~/Master/log.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="WebSite.Pages.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
 Admin Login
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table style="margin-top:50px; margin-left:50px;">

<tr>
<td></td>
</tr>

<tr>
<td></td>
<td>Username : </td>
<td><asp:TextBox ID="TxtLoginName" class="inputs" runat="server" onblur="NameCheck()" onchange="NameCheck()" onfocus="document.getElementById('NameErrorLogin').innerHTML = ''"></asp:TextBox></td>
<td><span id="NameErrorLogin"></span></td>
</tr>

<tr>
<td>&nbsp;</td>
<td>Password : </td>
<td><asp:TextBox ID="TxtLoginPass" class="inputs" runat="server" onblur="PassCheck()" onchange="PassCheck()" onfocus="document.getElementById('PassError').innerHTML = ''" TextMode="Password"></asp:TextBox></td>
<td><span id="PassError"></span></td>
</tr>

<tr>
<td>
</td>
</tr>

<tr>
<td>&nbsp;&nbsp;&nbsp;</td>
<td><asp:Button ID="btnReset" class="inputsButton" runat="server" onclick="Button1_Click" Text="RESET" UseSubmitBehavior="False"/></td>
<td><asp:Button ID="btnSubmit" onClientClick="return LoginButton()" class="inputsButton" runat="server" onclick="Button2_Click" Text="SUBMIT" /></td>
<td></td>
</tr>
</table>
</asp:Content>