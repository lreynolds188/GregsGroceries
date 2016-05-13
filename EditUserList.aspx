<%@ Page Title="Edit User List" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditUserList.aspx.cs" Inherits="GregsGrocery.EditUserList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" type="text/css" href="Content/myCss.css" />

    <div>
        <table style="width:100%">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Operator: "></asp:Label>
                    <asp:Label ID="lblOperator" runat="server" Text="Operator"></asp:Label>
                    <asp:Label ID="lblHelp1" runat="server" Text="<--- Current operator name" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <div>
            <asp:Label ID="lblHelp2" runat="server" Text="List of all operators, each with a select button to allow modification or deletion" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label>
            <asp:GridView ID="gvUserList" runat="server" AutoGenerateSelectButton="true" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Width="100%" OnSelectedIndexChanged="gvUserList_SelectedIndexChanged">
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
        
        <br />
        <table style="width:100%">
            <tr>
                <td><asp:Button ID="btnBack" runat="server" Text="Back" CssClass="btn btn-danger" OnClick="btnBack_Click" /><asp:Label ID="lblHelp3" runat="server" Text="<--- Return to main menu" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label></td>
                <td style="text-align:right"><asp:Label ID="lblHelp4" runat="server" Text="Create a new user --->" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label><asp:Button ID="btnNewUser" runat="server" Text="New User" CssClass="btn btn-success" OnClick="btnNewUser_Click" /></td>
            </tr>
        </table>
        <div style="text-align:right">
            <asp:Button ID="btnHelp" runat="server" CssClass="btn btn-link" Text="Show Help" OnClick="btnHelp_Click" /></div>
        
        
    
    </div>

</asp:Content>
