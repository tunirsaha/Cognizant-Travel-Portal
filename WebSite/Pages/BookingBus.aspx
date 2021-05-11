<%@ Page Title="" Language="C#" MasterPageFile="~/Master/master.Master" AutoEventWireup="true" CodeBehind="BookingBus.aspx.cs" Inherits="WebSite.BookingBus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <style type="text/css">
 #div1
 {
 height: 458px;
 margin-top: 35px;
 }
 #div2
 {
 height: 181px;
 }
 #div3
 {
 height: 264px;
 margin-top: 2px;
 }
 .style1
 {
 height: 41px;
 background-color:#FF9000;
 }
 .style2
 {
 height: 61px;
 background-color:#FFFBD6;
 
 }
 .style3
 {
 height: 41px;
 background-color: #FF9000;
 width: 253px;
 }
 .style4
 {
 height: 61px;
 background-color: #FFFBD6;
 width: 253px;
 }
 </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
 Select Bus
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div id="div1">
 <div id="div2">
 
 <table style="width:100%; margin-top: 31px; text-align:center; height: 82px;">
 <tr>
 <td class="style3">
 <input id="Text1" type="text" value="SOURCE" class="transparent_textbox" style=" color:White; font-weight:900;" readonly/></td>
 <td class="style3">
 <input id="Text3" type="text" value="DESTINATION" class="transparent_textbox" style=" color:White; font-weight:900;" readonly/></td>
 <td class="style1">
 <input id="Text5" type="text" value="DATE OF JOURNEY" class="transparent_textbox" style=" color:White; font-weight:900;" readonly/></td>
 </tr>
 <tr>
 <td class="style4">
 <input id="txtSrc" type="text" runat="server" class="transparent_textbox" readonly/></td>
 <td class="style4">
 <input id="txtDst" type="text" runat="server" class="transparent_textbox" readonly/></td>
 <td class="style2">
 <input id="txtDoj" type="text" runat="server" class="transparent_textbox" readonly/></td>
 </tr>
 </table>
 
 </div>
 <div id="div3">
 <asp:GridView ID="GridView1" runat="server" CellPadding="4" 
 ForeColor="#333333" GridLines="None" DataKeyNames="bus_id" >
 <AlternatingRowStyle BackColor="White" />
 <Columns>
 <asp:TemplateField ShowHeader="False">
 <ItemTemplate>
  <asp:RadioButton ID="rbBus" OnCheckedChanged="rbSelector_CheckedChanged" AutoPostBack="true" GroupName="bus" runat="server" />
 </ItemTemplate>
 </asp:TemplateField>
 </Columns>
 <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
 <HeaderStyle BackColor="#FF9000" Font-Bold="True" ForeColor="White" />
 <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="left" />
 <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
 <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
 <SortedAscendingCellStyle BackColor="#FDF5AC" />
 <SortedAscendingHeaderStyle BackColor="#4D0000" />
 <SortedDescendingCellStyle BackColor="#FCF6C0" />
 <SortedDescendingHeaderStyle BackColor="#820000" />
 </asp:GridView>
 <ul style="list-style-type:none; margin-left:0px;">
 <li><span id="GridView1_span"></span></li>
 <li><asp:Button ID="btnSubmit" runat="server" class="inputsButton" 
 onclientclick="return Grid_Validate()" onclick="btnSubmit_Click" 
 style="margin-left: 59px; margin-top: 46px" Text="SUBMIT" /></li>
 </ul>
 </div>
 </div>
</asp:Content>
