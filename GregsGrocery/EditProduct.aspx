<%@ Page Title="Edit Product" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditProduct.aspx.cs" Inherits="GregsGrocery.EditProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" type="text/css" href="Content/myCss.css" />

    <div>
        <table style="width: 100%">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Operator: "></asp:Label><asp:Label ID="lblOperator" runat="server" Text="Operator"></asp:Label>
                    <asp:Label ID="lblHelp1" runat="server" Text="<--- Current operator name" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <table style="width:100%">
            <tr>
                <td style="width:25%"></td>
                <td style="width:25%"><asp:Label ID="Label3" runat="server" Text="Product Name"></asp:Label></td>
                <td style="width:18%"><asp:Label ID="Label4" runat="server" Text="Product Price"></asp:Label></td>
            </tr>
            <tr>
                <td style="text-align:right"><asp:Label ID="lblHelp2" runat="server" Text="Current product name --->" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label></td>
                <td><asp:TextBox ID="txtProduct" runat="server" Width="60%"></asp:TextBox></td>
                <td>$<asp:TextBox ID="txtProductPrice" runat="server" Width="90%"></asp:TextBox></td>
                <td><asp:Label ID="lblHelp3" runat="server" Text="<--- Current product price" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label></td>
            </tr>
        </table>

        <br />

         <div style="float:left">
            <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="btn btn-danger" OnClick="btnBack_Click"/>
             <asp:Label ID="lblHelp4" runat="server" Text="<--- Return to operator list" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label>
        </div>
        <div style="float:right">
            <asp:Label ID="lblHelp6" runat="server" Text="Save selected product --->" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label>
            <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-success" OnClick="btnSave_Click"/>
        </div>
        <div style="float:right; margin-right:20px;">
            <asp:Label ID="lblHelp5" runat="server" Text="Delete selected product --->" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label>
            <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btn btn-warning" OnClick="btnDelete_Click"/>
        </div>
        <br />
        <br />
        <div style="text-align:right">
        <asp:Button ID="btnHelp" runat="server" CssClass="btn btn-link" Text="Show Help" OnClick="btnHelp_Click" />
        </div>
    </div>

    


</asp:Content>
