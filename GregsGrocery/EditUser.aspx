<%@ Page Title="Edit User" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" Inherits="GregsGrocery.EditUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" type="text/css" href="Content/myCss.css" />

    <div>
        <div style="width: 100%">
                <asp:Label ID="Label1" runat="server" Text="Operator: "></asp:Label>
                <asp:Label ID="lblOperator" runat="server" Text="Operator"></asp:Label>
                <asp:Label ID="lblHelp1" runat="server" Text="<--- Current operator name" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label>
            </div>
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="Selected user: "></asp:Label>
            <asp:Label ID="lblSelectedOperator" runat="server" Text="User"></asp:Label>
            <asp:Label ID="lblHelp2" runat="server" Text="<--- Currently selected operator" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label>
        </div>
        <div>
            <table style="width:100%">
                <tr>
                    <td style="width:25%"></td>
                    <td style="width:25%"><asp:Label ID="Label3" runat="server" Text="Operator Name"></asp:Label></td>
                    <td style="width:13%"><asp:Label ID="Label4" runat="server" Text="Operator Pin: "></asp:Label></td>
                </tr>
                <tr>
                    <td style="width:25%; text-align:right"><asp:Label ID="lblHelp3" runat="server" Text="Change operator name --->" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label></td>
                    <td><asp:TextBox ID="txtOperator" runat="server" Width="180px"></asp:TextBox></td>
                    <td style="width:13%"><asp:TextBox ID="txtOperatorPin" runat="server" Width="180px"></asp:TextBox></td>
                    <td style="width:30%"><asp:Label ID="lblHelp4" runat="server" Text="<--- Change operator pin" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label></td>
                </tr>
                <tr>
                    <td></td>
                </tr>
                <tr>
                    <td style="width:25%"></td>
                    <td><asp:Label ID="Label5" runat="server" Text="Operator Permissions"></asp:Label></td>
                </tr>
                <tr>
                    <td style="text-align:right"><asp:Label ID="lblHelp5" runat="server" Text="Change operator sales permissions --->" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label></td>
                    <td><asp:CheckBox ID="cbSalesPermissions" runat="server" Text="Sales Permissions"/></td>
                    <td><asp:CheckBox ID="cbAdminPermissions" runat="server" Text="Admin Permissions" /></td>
                    <td><asp:Label ID="lblHelp6" runat="server" Text="<--- Change operator admin permissions" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label></td>
                </tr>
                </table>
           
        <div style="float:left">
            <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="btn btn-danger" OnClick="btnBack_Click"/>
            <asp:Label ID="lblHelp7" runat="server" Text="<--- Return to operators list" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label>
        </div>
        <div style="float:right">
            <asp:Label ID="lblHelp9" runat="server" Text="Update operators credentials --->" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label>
            <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-success" OnClick="btnSave_Click"/>
        </div>
        <div style="float:right; margin-right:20px;">
            <asp:Label ID="lblHelp8" runat="server" Text="Delete selected operator --->" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label>
            <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btn btn-warning" OnClick="btnDelete_Click"/>
        </div>
    </div>
    <br />
    <br />
    <div style="float:right"><asp:Button ID="btnHelp" runat="server" CssClass="btn btn-link" Text="Show Help" OnClick="btnHelp_Click" /></div>
    </div>
        <br />

</asp:Content>
