using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GregsGrocery
{
    public partial class ViewSale : System.Web.UI.Page
    {
        private DataTable tempData = new DataTable("Products");
        private DataTable saleData = new DataTable("Products");
        private double totalCost;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    if (Session["OperatorName"] == null) { Response.Redirect("Default"); }
                    saleData.Columns.Add("ProductID");
                    saleData.Columns.Add("ProductDescription");
                    saleData.Columns.Add("LinePrice");
                    saleData.Columns.Add("LineQuantity");
                    saleData.Columns.Add("SubTotal");

                    tempData = Utilities.LoadSale(int.Parse(Session["SaleID"].ToString()));
                    for (int i = 0; i < tempData.Rows.Count; i++)
                    {
                        int ProductID = int.Parse(tempData.Rows[i].ItemArray.GetValue(0).ToString());
                        string ProductDescription = Utilities.LoadSpecificProduct(int.Parse(tempData.Rows[i].ItemArray.GetValue(0).ToString())).ItemArray.GetValue(1).ToString();
                        double LinePrice = double.Parse(tempData.Rows[i].ItemArray.GetValue(1).ToString());
                        int LineQuantity = int.Parse(tempData.Rows[i].ItemArray.GetValue(2).ToString());
                        double SubTotal = LinePrice * LineQuantity;
                        saleData.Rows.Add(ProductID, ProductDescription, "$" + LinePrice, LineQuantity, "$" + SubTotal);
                        totalCost += SubTotal;
                    }
                    gvSaleList.DataSource = saleData;
                    gvSaleList.DataBind();
                    txtTotal.Text = "$" + totalCost.ToString();
                    txtOperator.Text = Session["OperatorName"].ToString();
                    txtSaleID.Text = Session["SaleID"].ToString();

                    if (!Utilities.LoadSaleCompleted(int.Parse(txtSaleID.Text)))
                    {
                        Response.Redirect("MakeSale");
                    }

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

        private void ShowHelp()
        {
            btnHelp.Text = "Hide Help";
            lblHelp1.Visible = true;
            lblHelp2.Visible = true;
            lblHelp3.Visible = true;
            lblHelp4.Visible = true;
            lblHelp5.Visible = true;
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
            Session["Help"] = false;
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Session["SaleID"] = null;
            Response.Redirect("ViewSales");
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

        protected void btnComplete_Click(object sender, EventArgs e)
        {
            // remove all sale lines correlating to the current sale
            // change the completed value to true
            // add all sales lines to the sale
            // Update the current sale with the completed value set to true and add any new lines to the sale lines table
        }
    }
}