<%@ Page Title="" Language="C#" MasterPageFile="~/Master/master.Master" AutoEventWireup="true" CodeBehind="ViewSchedule.aspx.cs" Inherits="WebSite.viewSchedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div style="overflow:scroll; height: 535px; width: 695px;">
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:GridView ID="gvViewData" class="inputs"
 runat="server" AutoGenerateColumns="False" 
 CellPadding="4" ForeColor="#000000" GridLines="None" Width="624px" Height="422px" 
 onpageindexchanging="GridView1_PageIndexChanging" PageSize="5">
 <AlternatingRowStyle BackColor="White" />
 <Columns>
 <asp:BoundField HeaderText="Bus ID" DataField="bus_id" />
 <asp:BoundField HeaderText="Name" DataField="name" />
 <asp:BoundField HeaderText="Type" DataField="bus_type" />
 <asp:BoundField HeaderText="Seats" DataField="maxseat" />
 <asp:BoundField HeaderText="Start" DataField="start" />
 <asp:BoundField HeaderText="Destination" DataField="destination" />
 <asp:BoundField HeaderText="Cost" DataField="cost" />
 <asp:BoundField HeaderText="Time" DataField="bus_time" />
 </Columns>
 <EditRowStyle BackColor="#7C6F57" />
 <FooterStyle BackColor="#1C5E55" Font-Bold="False" ForeColor="White" />
 <HeaderStyle BackColor="#FF9000" Font-Bold="False" ForeColor="White" />
 <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
 <RowStyle BackColor="#E3EAEB" />
 <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
 <SortedAscendingCellStyle BackColor="#F8FAFA" />
 <SortedAscendingHeaderStyle BackColor="#246B61" />
 <SortedDescendingCellStyle BackColor="#D4DFE1" />
 <SortedDescendingHeaderStyle BackColor="#15524A" />
 </asp:GridView></div>
 <p>
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 </p>
 <p>
 &nbsp;</p>
 <p>
 &nbsp;</p>
</asp:Content>
<asp:Content ID="Content3" runat="server" 
 contentplaceholderid="ContentPlaceHolder2">
 View Available Schedules
</asp:Content>

