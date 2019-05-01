<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GregsGrocery.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" type="text/css" href="Content/myCss.css" />
    <div>
        <div style="text-align: center">
            <h1>Login</h1>
            <p>
                <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label></p>
        </div>
        <table class="table table-striped">
            <tr>
                <td style="width: 40%; text-align:right">
                    <asp:Label ID="lblOperatorName" runat="server" Text="Operator Name"></asp:Label></td>
                <td style="width: 20%">
                    <asp:TextBox ID="txtOperatorName" runat="server" CssClass="form-control input-sm"></asp:TextBox></td>
                <td style="width: 40%; text-align: left">
                    <asp:Label ID="lblHelp1" runat="server" Text="<--- Enter operator name here" Visible="False" ForeColor="#999999" Font-Size="Smaller"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 40%; text-align:right">
                    <asp:Label ID="lblOperatorPin" runat="server" Text="Operator Pin"></asp:Label></td>
                <td style="width: 20%">
                    <asp:TextBox ID="txtOperatorPin" type="password" runat="server" CssClass="form-control input-sm" Font-Names="Segoe MDL2 Assets"></asp:TextBox></td>
                <td style="width: 40%; text-align: left">
                    <asp:Label ID="lblHelp2" runat="server" Text="<--- Enter operator pin here" Visible="False" ForeColor="#999999" Font-Size="Smaller"></asp:Label></td>
            </tr>
        </table>
        <table style="width: 100%">
            <tr>
                <td style="text-align: right">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-success" Height="50px" Style="text-align: center" Width="307px" OnClick="btnLogin_Click" /></td>
                <td style="width: 38%">
                    <asp:Label ID="lblHelp3" runat="server" Text=" <--- Check name against pin and attempt to logon" Visible="False" ForeColor="#999999" Font-Size="Smaller"></asp:Label></td>
            </tr>
        </table>
        <div class="floatRight">
            <asp:Button ID="btnHelp" runat="server" CssClass="btn btn-link" Text="Show Help" OnClick="btnHelp_Click" /></div>
        </div>
    <br />
</asp:Content>
