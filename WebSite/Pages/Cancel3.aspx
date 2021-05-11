<%@ Page Title="" Language="C#" MasterPageFile="~/Master/master.Master" AutoEventWireup="true" CodeBehind="Cancel3.aspx.cs" Inherits="Cancel.Cancel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<meta http-equiv="refresh" content="3;url=Home.aspx">
 <style type="text/css">
 #farediv
 {
 margin-top:50px;
 margin-left:165px;
 margin-right:100px;
 height:100px;
 width: 392px;
 background-color:#FF9000;
 
 }
 </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <br /><br />
 <div id ="farediv">
  <br />
  <br />
  <center>The amount returned is :<br />
  Rs.
 <asp:Label ID="Label2" runat="server" Text="Label" ForeColor="White"></asp:Label>
 &nbsp;/-</div></center>
 </div>
</asp:Content>
<asp:Content ID="Content4" runat="server" 
 contentplaceholderid="ContentPlaceHolder2">
 Ticket Cancel Successfull !
</asp:Content>

