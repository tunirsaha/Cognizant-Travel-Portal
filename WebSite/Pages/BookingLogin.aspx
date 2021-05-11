<%@ Page Title="" Language="C#" MasterPageFile="~/Master/master.Master" AutoEventWireup="true" CodeBehind="BookingLogin.aspx.cs" Inherits="WebSite.BookingLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div style="margin-top: 43px; height: 288px;">
<ul style="list-style-type:none;">
<li>
 Enter User ID :<asp:TextBox ID="userid" MaxLength="10" class="inputs" onfocus="document.getElementById('userid_span').innerHTML=''" runat="server" 
 style="margin-left: 20px; margin-top: 48px" onblur="userid_validate()"></asp:TextBox>
 <span id="userid_span" ></span></li>
 <li style="margin-top: 36px"> 
 <asp:Button ID="btnSubmit" class="inputsButton" runat="server" Text="Search" 
  onclientclick="return userid_validate()" onclick="btnSubmit_Click" 
 style="margin-left: 143px"/></li>
</ul>
 </div>
</asp:Content>
<asp:Content ID="Content3" runat="server" 
 contentplaceholderid="ContentPlaceHolder2">
 Search User to Book Ticket
</asp:Content>

