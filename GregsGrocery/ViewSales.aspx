<%@ Page Title="View Sales" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewSales.aspx.cs" Inherits="GregsGrocery.ViewSales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" type="text/css" href="Content/myCss.css" />
    
    <div>
        <div class="floatLeft">
                <asp:Label ID="lblOperator" runat="server" Text="Operator: "></asp:Label>
                <asp:Label ID="txtOperator" runat="server" Text="Operator"></asp:Label>
                <asp:Label ID="lblHelp1" runat="server" Text="<--- Current operator name" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label>
            </div>

        <br />
        <br />

    <table style="width:100%">
        <tr>
            <td><asp:Label ID="Label1" runat="server" Text="SaleID"></asp:Label></td>
            <td></td>
            <td></td>
            <td style="text-align:center; width: 9%;"><asp:Label ID="Label4" runat="server" Text="Filter Completed"></asp:Label></td>
            
            <td style="width: 9%"></td>
            
        </tr>
        <tr>
            
            <td style="width:8%"><asp:DropDownList ID="ddlSaleID" runat="server" AutoPostBack="true" Width="100%" OnSelectedIndexChanged="ddlSaleID_SelectedIndexChanged"></asp:DropDownList></td>
            <td style="width:10%"><asp:Label ID="lblHelp2" runat="server" Text="<--- Search via Sale ID" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label></td>
            <td style="text-align:right; width:10%">
                <asp:Label ID="lblHelp7" runat="server" Font-Size="Smaller" ForeColor="#999999" Text="Filter completed/incomplete sales from the list --->" Visible="False"></asp:Label>
            </td>
            <td style="width:9%; text-align:center"><asp:CheckBox ID="cbCompleted" runat="server" Text="Completed" OnCheckedChanged="cbCompleted_CheckedChanged" Checked="True" AutoPostBack="True" /><asp:CheckBox ID="cbIncomplete" runat="server" Text="Incomplete" OnCheckedChanged="cbIncomplete_CheckedChanged" Checked="True" AutoPostBack="True" /></td>
           <td style="text-align:right; width:9%"><asp:Label ID="lblHelp8" runat="server" Font-Size="Smaller" ForeColor="#999999" Text="Clear the filter and show all sales on the list --->" Visible="False"></asp:Label></td>
            <td style="width:8%"><asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" Width="100%" CssClass="btn btn-info" OnClick="btnClearFilter_Click"/></td>
        </tr>
        </table>

        <br />

        <table>
        <tr>
            <td style="text-align:center"><asp:Label ID="Label2" runat="server" Text="Date from"></asp:Label></td>
            <td></td>
            <td style="text-align:center"><asp:Label ID="Label3" runat="server" Text="Date to"></asp:Label></td>
        </tr>
        <tr>
            <td style="width:12%; text-align:center"><asp:DropDownList ID="ddlDateFromDay" runat="server" Width="28%">
                <asp:ListItem Selected="True" Value="1">1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                <asp:ListItem>13</asp:ListItem>
                <asp:ListItem>14</asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
                <asp:ListItem>16</asp:ListItem>
                <asp:ListItem>17</asp:ListItem>
                <asp:ListItem>18</asp:ListItem>
                <asp:ListItem>19</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>21</asp:ListItem>
                <asp:ListItem>22</asp:ListItem>
                <asp:ListItem>23</asp:ListItem>
                <asp:ListItem>24</asp:ListItem>
                <asp:ListItem>25</asp:ListItem>
                <asp:ListItem>26</asp:ListItem>
                <asp:ListItem>27</asp:ListItem>
                <asp:ListItem>28</asp:ListItem>
                <asp:ListItem>29</asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem>31</asp:ListItem>
                </asp:DropDownList><asp:DropDownList ID="ddlDateFromMonth" runat="server" Width="28%">
                    <asp:ListItem Selected="True">01</asp:ListItem>
                    <asp:ListItem>02</asp:ListItem>
                    <asp:ListItem>03</asp:ListItem>
                    <asp:ListItem>04</asp:ListItem>
                    <asp:ListItem>05</asp:ListItem>
                    <asp:ListItem>06</asp:ListItem>
                    <asp:ListItem>07</asp:ListItem>
                    <asp:ListItem>08</asp:ListItem>
                    <asp:ListItem>09</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                </asp:DropDownList><asp:DropDownList ID="ddlDateFromYear" runat="server" Width="35%">
                    <asp:ListItem>2015</asp:ListItem>
                    <asp:ListItem>2016</asp:ListItem>
                    <asp:ListItem>2017</asp:ListItem>
                    <asp:ListItem>2018</asp:ListItem>
                    <asp:ListItem>2019</asp:ListItem>
                    <asp:ListItem>2020</asp:ListItem>
                    <asp:ListItem>2021</asp:ListItem>
                    <asp:ListItem>2022</asp:ListItem>
                </asp:DropDownList></td>

            <td style="width:10%; text-align:center"><asp:Label ID="lblHelp3" runat="server" Text="<--- Filter between dates --->" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label></td>

            <td style="width:14%; text-align:center"><asp:DropDownList ID="ddlDateToDay" runat="server" Width="28%">
                <asp:ListItem Selected="True" Value="1">1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                <asp:ListItem>13</asp:ListItem>
                <asp:ListItem>14</asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
                <asp:ListItem>16</asp:ListItem>
                <asp:ListItem>17</asp:ListItem>
                <asp:ListItem>18</asp:ListItem>
                <asp:ListItem>19</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>21</asp:ListItem>
                <asp:ListItem>22</asp:ListItem>
                <asp:ListItem>23</asp:ListItem>
                <asp:ListItem>24</asp:ListItem>
                <asp:ListItem>25</asp:ListItem>
                <asp:ListItem>26</asp:ListItem>
                <asp:ListItem>27</asp:ListItem>
                <asp:ListItem>28</asp:ListItem>
                <asp:ListItem>29</asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem>31</asp:ListItem>
                </asp:DropDownList><asp:DropDownList ID="ddlDateToMonth" runat="server" Width="28%">
                    <asp:ListItem Selected="True">01</asp:ListItem>
                    <asp:ListItem>02</asp:ListItem>
                    <asp:ListItem>03</asp:ListItem>
                    <asp:ListItem>04</asp:ListItem>
                    <asp:ListItem>05</asp:ListItem>
                    <asp:ListItem>06</asp:ListItem>
                    <asp:ListItem>07</asp:ListItem>
                    <asp:ListItem>08</asp:ListItem>
                    <asp:ListItem>09</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                </asp:DropDownList><asp:DropDownList ID="ddlDateToYear" runat="server" Width="35%">
                    <asp:ListItem>2015</asp:ListItem>
                    <asp:ListItem>2016</asp:ListItem>
                    <asp:ListItem>2017</asp:ListItem>
                    <asp:ListItem>2018</asp:ListItem>
                    <asp:ListItem>2019</asp:ListItem>
                    <asp:ListItem>2020</asp:ListItem>
                    <asp:ListItem>2021</asp:ListItem>
                    <asp:ListItem Selected="True">2022</asp:ListItem>
                </asp:DropDownList></td>

             <td style="width:10%; text-align:right"><asp:Label ID="lblHelp4" runat="server" Text="Search for sale with matching dates --->" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label></td>

            <td style="width:8%; text-align:right"><asp:Button ID="btnSearch" runat="server" Text="Search Dates" Width="100%" CssClass="btn btn-success" OnClick="btnSearch_Click"/></td>

        </tr>
    </table>

        <br />

        <div>
            <asp:Label ID="lblHelp5" runat="server" Text="List containing all sales or a filtered list of sales" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label>
            <asp:GridView ID="salesList" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Width ="100%" OnSelectedIndexChanged="salesList_SelectedIndexChanged">
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
            <Columns><asp:CommandField ShowSelectButton="True" /></Columns>
        </asp:GridView>
        </div>

        <br />

        <div class="floatLeft">
            <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="btn btn-danger" OnClick="btnBack_Click" />
            <asp:Label ID="lblHelp6" runat="server" Text="<--- To return to the main menu click here" ForeColor="#999999" Visible="False" Font-Size="Smaller"></asp:Label>
        </div>
        <div class="floatRight">
            <asp:Button ID="btnHelp" runat="server" Text="Show Help" CssClass="btn btn-link" OnClick="btnHelp_Click" />
        </div>
        
    </div>
    <br />
</asp:Content>
