<%@ Page Title="View Sale" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewSale.aspx.cs" Inherits="GregsGrocery.ViewSale" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" type="text/css" href="Content/myCss.css" />

    <div class="align">
        <div class="floatLeft">
            <asp:Label ID="Label1" runat="server" Text="Operator: "></asp:Label>
            <asp:Label ID="txtOperator" runat="server" Text="Operator"></asp:Label>
            <asp:Label ID="lblHelp1" runat="server" Text="<--- To view all previous sales click here" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label>
        </div>
        <div class="floatRight">
            <asp:Label ID="lblHelp2" runat="server" Text="Current sales ID --->" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label>
            <asp:Label ID="lblSaleID" runat="server" Text="Sales ID: "></asp:Label>
            <asp:Label ID="txtSaleID" runat="server" Text="Sale ID"></asp:Label>
        </div>

        <br />
        <br />

        <div>
            <asp:Label ID="lblHelp3" runat="server" Text="List of all items on sale" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label>
            <asp:GridView ID="gvSaleList" runat="server" Width="100%" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        </div>
        
        
        <table class="floatRight">
            <tr>
                <td><asp:Label ID="lblHelp4" runat="server" Text="Total price for sale --->" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label></td>
                <td><asp:Label ID="Label2" runat="server" Text="Total "></asp:Label></td>
                <td><asp:TextBox ID="txtTotal" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        <br />
        <br />
        <div>
            <div style="width:49%; float:left">
            <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="btn btn-danger" OnClick="btnBack_Click" />
            <asp:Label ID="lblHelp5" runat="server" Text="<--- To return to sales list click here" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label>
        </div>
        <div style="width:50%; float:left; text-align:right">
            <asp:Button ID="btnHelp" runat="server" CssClass="btn btn-link" Text="Show Help" OnClick="btnHelp_Click" />
        </div>
            
        </div>
    </div>
    <br />

</asp:Content>
