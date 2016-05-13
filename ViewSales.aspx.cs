using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GregsGrocery
{
    public partial class ViewSales : System.Web.UI.Page
    {
        private DataTable myDataTable = new DataTable("Sales");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    if (Session["OperatorName"] == null) { Response.Redirect("Default"); }
                    // Set operator name
                    txtOperator.Text = Session["OperatorName"].ToString();
                    
                    // Add columns to the DataTable
                    myDataTable.Columns.Add("SaleID");
                    myDataTable.Columns.Add("SaleTime");
                    myDataTable.Columns.Add("OperatorID");
                    myDataTable.Columns.Add("Complete");

                    // Set DataSource for Sale ID drop down list
                    ddlSaleID.DataSource = Utilities.LoadSaleIDs();
                    ddlSaleID.DataTextField = "SaleID";
                    ddlSaleID.DataValueField = "SaleID";
                    ddlSaleID.DataBind();

                    // Add and select a blank index for the Sale ID drop down list
                    ddlSaleID.Items.Insert(0, new ListItem(string.Empty, string.Empty));
                    ddlSaleID.SelectedIndex = 0;

                    LoadSales(Utilities.LoadSales());

                    // Check to see if help is enabled if so enable it
                    if (bool.Parse(Session["Help"].ToString()))
                    {
                        ShowHelp();
                    }
                }
                catch
                {

                }
            }
            
            
        }

        private void LoadSales(DataSet dsSalesList)
        {
            // Load and binds sales data
            salesList.DataSource = dsSalesList;
            salesList.DataBind();
        }

        private void ReloadSales()
        {
            DataSet dsNewSalesList = new DataSet();
            dsNewSalesList.Tables.Add("tblSales");
            if (cbCompleted.Checked)
            {
                if (cbIncomplete.Checked)
                {
                    dsNewSalesList = Utilities.LoadSalesByDateAndCompletion(ddlDateFromDay.Text + "/" + ddlDateFromMonth.Text + "/" + ddlDateFromYear.Text, ddlDateToDay.Text + "/" + ddlDateToMonth.Text + "/" + ddlDateToYear.Text, 1);
                }
                else
                {
                    dsNewSalesList = Utilities.LoadSalesByDateAndCompletion(ddlDateFromDay.Text + "/" + ddlDateFromMonth.Text + "/" + ddlDateFromYear.Text, ddlDateToDay.Text + "/" + ddlDateToMonth.Text + "/" + ddlDateToYear.Text, 2);
                }
            }
            else if (cbIncomplete.Checked)
            {
                dsNewSalesList = Utilities.LoadSalesByDateAndCompletion(ddlDateFromDay.Text + "/" + ddlDateFromMonth.Text + "/" + ddlDateFromYear.Text, ddlDateToDay.Text + "/" + ddlDateToMonth.Text + "/" + ddlDateToYear.Text, 3);
            }
            else
            {
                
            }
            LoadSales(dsNewSalesList);
        }
                
        private void ShowHelp()
        {
            btnHelp.Text = "Hide Help";
            lblHelp1.Visible = true;
            lblHelp2.Visible = true;
            lblHelp3.Visible = true;
            lblHelp4.Visible = true;
            lblHelp5.Visible = true;
            lblHelp6.Visible = true;
            lblHelp7.Visible = true;
            lblHelp8.Visible = true;
            Session["Help"] = true;
        }

        private void HideHelp()
        {
            btnHelp.Text = "Show Help";
            lblHelp1.Visible = false;
            lblHelp2.Visible = false;
            lblHelp3.Visible = false;
            lblHelp4.Visible = false;
            lblHelp5.Visible = false;
            lblHelp6.Visible = false;
            lblHelp7.Visible = false;
            lblHelp8.Visible = false;
            Session["Help"] = false;
        }

        protected void salesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["SaleID"] = salesList.SelectedRow.Cells[1].Text;
            Response.Redirect("ViewSale");
        }

        protected void ddlSaleID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["SaleID"] = ddlSaleID.Text;
            Response.Redirect("ViewSale");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ReloadSales();
        }

        protected void btnHelp_Click(object sender, EventArgs e)
        {
            if (btnHelp.Text == "Show Help")
            {
                ShowHelp();
            }
            else
            {
                HideHelp();
            }
        }

        protected void cbCompleted_CheckedChanged(object sender, EventArgs e)
        {
            ReloadSales();
        }

        protected void btnClearFilter_Click(object sender, EventArgs e)
        {
            cbCompleted.Checked = true;
            cbIncomplete.Checked = true;
            ddlDateFromDay.Text = "1";
            ddlDateFromYear.Text = "01";
            ddlDateFromMonth.Text = "2015";
            ddlDateToDay.Text = "1";
            ddlDateToMonth.Text = "01";
            ddlDateToYear.Text = "2022";
            ReloadSales();
        }

        protected void cbIncomplete_CheckedChanged(object sender, EventArgs e)
        {
            ReloadSales();
        }
    }
}