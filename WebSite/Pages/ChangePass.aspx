<%@ Page Title="" Language="C#" MasterPageFile="~/Master/master.Master" AutoEventWireup="true" CodeBehind="ChangePass.aspx.cs" Inherits="WebSite.Pages.ChangePass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
 Change Password
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table style="margin-left: 50px; margin-top: 50px;">
<tr>
<td>
Enter Old Password :
</td>
<td>
<asp:TextBox ID="OldPassChange" Textmode="Password" class="inputs" runat="server" onblur="CheckEmptyOldPass()" onchange="CheckEmptyOldPass()" onfocus="document.getElementById('CheckEmptyOldPass').innerHTML = ' ';" style="margin-left: 25px" Width="120px"></asp:TextBox>
</td>
<td><span id="CheckEmptyOldPass"></span></td>
</tr>

<tr>
<td>
Enter New Password :
</td>
<td>
<asp:TextBox ID="NewPassChange" runat="server" class="inputs" onblur="CheckEmptyNewPass()" onchange="CheckEmptyNewPass()" onfocus="document.getElementById('CheckEmptyNewPass').innerHTML = ' ';" style="margin-left: 25px" Width="120px" TextMode="Password"></asp:TextBox>
</td>
<td>
<span id="CheckEmptyNewPass"></span>
</td>
</tr>

<tr>
<td>
Confirm New Password :
</td>
<td>
<asp:TextBox ID="ConfirmPassChange" runat="server" class="inputs" onblur="CheckThreePass()" onchange="CheckThreePass()" onfocus="document.getElementById('CheckThreePass').innerHTML = ' ';" style="margin-left: 25px" Width="120px" TextMode="Password"></asp:TextBox>
</td>
<td>
<span id="CheckThreePass"></span>
</td>
</tr>

<tr>
<td>
 &nbsp;</td>
<td>
 &nbsp;</td>
<td>
 &nbsp;</td>
</tr>

<tr>
<td>
<asp:Button ID="BtnPasschangeReset" class="inputsButton" runat="server" Text="RESET" Font-Names="Trebuchet MS" UseSubmitBehavior="False" onclick="BtnPasschangeReset_Click" />
</td>
<td>
<asp:Button ID="BtnPasschangeSubmit" runat="server" class="inputsButton" Text="SUBMIT" Font-Names="Trebuchet MS" onclick="BtnPasschangeSubmit_Click" onClientClick="return ok()" />
</td>
<td>
</td>
</tr>
</table>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
 @ Offers Today
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
<asp:Image ID="Image1" runat="server" ImageUrl="~/Images/ad.gif" />
 </asp:Content>
