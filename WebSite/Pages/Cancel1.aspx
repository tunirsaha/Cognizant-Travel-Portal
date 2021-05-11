<%@ Page Language="C#" MasterPageFile="~/Master/master.Master" AutoEventWireup="true" CodeBehind="Cancel1.aspx.cs" Inherits="Cancel.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script src="JavaScript/JScriptCancel.js" type="text/javascript"> </script>

 <script type="text/javascript">
 function RadioCheck(rb) {

 var gv = document.getElementById("<%=GridView1.ClientID%>");

 var rbs = gv.getElementsByTagName("input");

 var row = rb.parentNode.parentNode;

 for (var i = 0; i < rbs.length; i++) {

 if (rbs[i].type == "radio") {

 if (rbs[i].checked && rbs[i] != rb) {

 rbs[i].checked = false;

 break;
 }
 }

 }
 } 

 
 
 </script> 
 <style type="text/css">
 .style1
 {
 width: 53px;
 }
 </style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table style="margin-top:10px; margin-left:50px;">
<tr>
<td>
Enter user Id :
</td>
<td>
<asp:TextBox ID="TextBox1" runat="server" class="inputs" Height="27px" onblur="Cancel_BookingVal() "></asp:TextBox>
<span id="bookingspan"></span>
</td>
<td class="style1">&nbsp;</td>

<td>
<asp:GridView ID="GridView1" runat="server" onselectedindexchanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" style="margin-left: 0px; margin-top: 67px" Width="217px" >
<Columns>
<asp:TemplateField>
<ItemTemplate>
<asp:RadioButton ID="RadioButton1" runat="server" onclick = "RadioCheck(this);"/>
<span id="rb"></span>
<asp:HiddenField ID="HiddenField1" runat="server" Value = '<%#Eval("booking_id")%>' />
</ItemTemplate>
</asp:TemplateField> 
<asp:BoundField DataField="booking_id" HeaderText="Booking Id" />
</Columns>
<HeaderStyle BackColor="#FF9900" ForeColor="White" />
</asp:GridView>
</td>

</tr>

<tr>
<td>
 &nbsp;</td>
<td>&nbsp;</td>
<td class="style1">&nbsp;</td>
<td>&nbsp;</td>
</tr>

<tr>
<td>
<asp:Button ID="Button2" runat="server" Text="RESET" Height="32px" Width="90px" onclick="Button2_Click" UseSubmitBehavior="False" class="inputsButton"/> 
</td>
<td><asp:Button ID="Button1" runat="server" class="inputsButton" Text="SUBMIT" Height="32px" Width="90px" onClientClick="return Cancel_BookingVal() "
 onclick="Button1_Click" UseSubmitBehavior="True" /></td>
<td class="style1"></td>
<td><asp:Button ID="Button3" runat="server" class="inputsButton" onclick="Button3_Click" Text="OK" style="Height=32px; Width=68px;" UseSubmitBehavior="False" /></td>
</tr>
</table>

</asp:Content>
 <asp:Content ID="Content3" runat="server" contentplaceholderid="ContentPlaceHolder2">
Cancel Ticket
</asp:Content>