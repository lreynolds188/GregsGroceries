<%@ Page Title="Menu" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="GregsGrocery.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" type="text/css" href="Content/myCss.css" />
    <div>
        <table style="width:100%">
            <tr>
                <td style="width: 50%">
                    <asp:Label ID="lblOperator" runat="server" Text="Operator: "></asp:Label>
                    <asp:Label ID="txtOperator" runat="server" Text="Operator"></asp:Label>
                    <asp:Label ID="lblHelp6" runat="server" Text="<--- Current operator name" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label>
                </td>
                    
                <td style="text-align: right; width: 50%;">
                    <asp:Label ID="lblHelp5" runat="server" Text="To logout click here --->" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label>
                    <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="btn btn-warning" OnClick="btnLogout_Click" /></td>
            </tr>
        </table>

        <br />
        <table style="width: 100%">
            <tr>
                <td style="text-align:right; width:25%"><asp:Label ID="lblHelp1" runat="server" Text="To create a new sale click here --->" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label></td>
                <td style="text-align: center; width:25%"><asp:Button ID="btnNewSale" runat="server" Text="New Sale" CssClass="btn btn-success" OnClick="btnNewSale_Click" Width="80%" /></td>
                <td style="text-align: center; width:25%"><asp:Button ID="btnViewSales" runat="server" Text="View Sales" CssClass="btn btn-primary" OnClick="btnViewSales_Click" Width="80%" /></td>
                <td style="text-align:left; width:25%"><asp:Label ID="lblHelp2" runat="server" Text="<--- To view all previous sales click here" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label></td>
            </tr>
            <tr>
                <td></td>
            </tr>
            <tr>
                <td style="text-align:right; width:25%"><asp:Label ID="lblHelp3" runat="server" Text="To edit the list of products click here --->" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label></td>
                <td style="text-align: center;"><asp:Button ID="btnEditProductList" runat="server" Text="Edit Product List" CssClass="btn btn-info" Width="80%" OnClick="btnEditProductList_Click" /></td>
                <td style="text-align: center;"><asp:Button ID="btnEditUserList" runat="server" Text="Edit User List" CssClass="btn btn-danger" Width="80%" OnClick="btnEditUserList_Click" /></td>
                <td style="text-align:left; width:25%"><asp:Label ID="lblHelp4" runat="server" Text="<--- To edit the list of users click here" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label></td>
            </tr>
        </table>
        <div class="floatRight"><asp:Button ID="btnHelp" runat="server" CssClass="btn btn-link" Text="Show Help" OnClick="btnHelp_Click" /></div>
    </div>
    <br />
</asp:Content>
