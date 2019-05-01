<%@ Page Title="Create Sale" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MakeSale.aspx.cs" Inherits="GregsGrocery.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" type="text/css" href="Content/myCss.css" />

    <div>
        <div style="float:left">
            <asp:Label ID="lblOperator" runat="server" Text="Operator: "></asp:Label>
            <asp:Label ID="txtOperator" runat="server" Text="Operator"></asp:Label>
            <asp:Label ID="lblHelp1" runat="server" Text="<--- Current operator name" Visible="False" ForeColor="#999999"></asp:Label>
        </div>
        <div style="text-align:right; float:right">
            <asp:Label ID="lblHelp2" runat="server" Text="Current sale's ID --->" Visible="False" ForeColor="#999999"></asp:Label>
            <asp:Label ID="lblSaleID" runat="server" Text="Sales ID: "></asp:Label>
            <asp:Label ID="txtSaleID" runat="server" Text="Sale ID"></asp:Label>
        </div>
        
        <br />
        <hr />
        <table>
            <tr>
                <td style="height: 22px; width: 649px; text-align:center">
                    <asp:Label ID="lblProduct" runat="server" Text="Product"></asp:Label></td>
                <td></td>
                <td style="height: 22px; width: 127px; text-align:center">
                    <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label></td>
                <td></td>
                <td style="height: 22px; width: 170px; text-align:center">
                    <asp:Label ID="lblQty" runat="server" Text="Qty"></asp:Label></td>
                <td>
                <td style="height: 22px; text-align:center">
                    <asp:Label ID="lblSubtotal" runat="server" Text="Sub Total"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 10%">
                    <asp:DropDownList ID="ddlProducts" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProducts_SelectedIndexChanged" Width="100%"></asp:DropDownList></td>
                <td style="width: 10%">
                    <asp:Label ID="lblHelp3" runat="server" Font-Size="Smaller" Text="&lt;--- Product list" Visible="False" ForeColor="#999999"></asp:Label></td>
                <td style="width: 5%">
                    <asp:TextBox ID="txtPrice" runat="server" ReadOnly="true"></asp:TextBox></td>
                <td style="width: 10%">
                    <asp:Label ID="lblHelp4" runat="server" Font-Size="Smaller" Text="&lt;--- Price of current product" Visible="False" ForeColor="#999999"></asp:Label></td>
                <td style="width: 5%">
                    <asp:DropDownList ID="ddlQty" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlQty_SelectedIndexChanged">
                        <asp:ListItem Selected="True">1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="width: 10%">
                    <asp:Label ID="lblHelp5" runat="server" Font-Size="Smaller" Text="<--- Quantity of selected product" Visible="False" ForeColor="#999999"></asp:Label></td>
                <td style="width: 10%">
                    <asp:TextBox ID="txtSubtotal" runat="server" ReadOnly="true"></asp:TextBox></td>
                <td style="width: 10%">
                    <asp:Label ID="lblHelp6" runat="server" Font-Size="Smaller" Text="<--- Subtotal for selected product" Visible="False" ForeColor="#999999"></asp:Label></td>
                <td style="width: 1%"></td>
                <td style="width: 25%; text-align:right">
                    <asp:Label ID="lblHelp7" runat="server" Font-Size="Smaller" Text="Add product to sale --->" Visible="False" ForeColor="#999999"></asp:Label>
                    <asp:Button ID="btnAddProduct" runat="server" CssClass="btn btn-success" Text="Add Product" OnClick="btnAddProduct_Click" /></td>

            </tr>
        </table>
        <hr />
        <asp:Label ID="lblHelp8" runat="server" Text="List of all items currently on the sale" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label>
        <asp:GridView ID="CurrentSaleList" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Width="100%" OnRowDeleting="RowDeleting">
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
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowCancelButton="False" />
            </Columns>
        </asp:GridView>
        <table class="floatRight">
            <tr>
                <td>
                    <asp:Label ID="lblHelp9" runat="server" Text="Total cost for sale --->" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label><asp:Label ID="Label1" runat="server" Text="Total "></asp:Label></td>
                <td>
                    <asp:TextBox ID="Total" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        <br />
        <br />
        <table style="width: 100%">
            <tr>
                <td style="width: 30%">
                    <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="btn btn-danger" OnClick="btnBack_Click" /><asp:Label ID="lblHelp10" runat="server" Text="<--- Return to the main menu" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label></td>
                <td style="width:23%; text-align:right"><asp:Label ID="lblHelp13" runat="server" Text="Save the current sale --->" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label><asp:Button ID="btnDelete" runat="server" CssClass="btn btn-warning" Text="Delete" OnClick="btnDelete_Click" Visible="False" /></td>
                <td style="width:23%; text-align:right"><asp:Label ID="lblHelp12" runat="server" Text="Save the current sale --->" ForeColor="#999999" Font-Size="Smaller" Visible="False"></asp:Label><asp:Button ID="btnSaveSale" runat="server" CssClass="btn btn-info" Text="Save" OnClick="btnSaveSale_Click" /></td>
                <td style="width: 23%; text-align: right">
                    <asp:Label ID="lblHelp11" runat="server" Text="Complete the current sale --->" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label><asp:Button ID="btnCompleteSale" runat="server" CssClass="btn btn-success" Text="Complete" OnClick="btnCompleteSale_Click" /></td>
            </tr>
        </table>
        <div class="floatRight">
            <asp:Button ID="btnHelp" runat="server" CssClass="btn btn-link" Text="Show Help" OnClick="btnHelp_Click" />
        </div>
    </div>
    <br />
</asp:Content>
