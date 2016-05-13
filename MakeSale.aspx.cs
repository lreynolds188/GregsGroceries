using GregsGrocery.myServiceReference;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GregsGrocery
{
    public partial class About : Page
    {
        myServiceReference.myWebServiceSoapClient service = new myServiceReference.myWebServiceSoapClient();
        private static DataTable myDataTable = new DataTable("Products");
        private static List<string> lstSubTotal = new List<string>();
        static bool pageload = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["OperatorName"] == null) { Response.Redirect("Default"); }
            // If is first run
            if (!IsPostBack)
            {
                try
                {
                    txtOperator.Text = Session["OperatorName"].ToString();
                    ddlProducts.DataSource = Utilities.LoadProducts();
                    ddlProducts.DataTextField = "ProductDescription";
                    ddlProducts.DataValueField = "ProductDescription";
                    ddlProducts.DataBind();
                    myDataTable.Columns.Add("ProductDescription");
                    myDataTable.Columns.Add("ProductPrice");
                    myDataTable.Columns.Add("Qty");
                    myDataTable.Columns.Add("SubTotal");
                }
                catch
                {
                }
            }

            if (!pageload)
            {
                pageload = true;
                // If there is a sale ID to be looked at
                if (Session["SaleID"] != null)
                {
                    btnDelete.Visible = true;
                    txtSaleID.Text = Session["SaleID"].ToString();

                    // load the sale and display it on the page
                    DataTable dtSale = Utilities.LoadSale(int.Parse(Session["SaleID"].ToString()));
                    foreach (DataRow row in dtSale.Rows)
                    {
                        myDataTable.Rows.Add(Utilities.LoadSpecificProduct(int.Parse(row.ItemArray.GetValue(0).ToString())).ItemArray.GetValue(1).ToString(), "$" + row.ItemArray.GetValue(1).ToString(), row.ItemArray.GetValue(2).ToString(), "$" + double.Parse(row.ItemArray.GetValue(1).ToString()) * int.Parse(row.ItemArray.GetValue(2).ToString()));
                    }
                    BindDataTable();
                }
                else
                {
                    int lastSaleId = Utilities.LoadLastSaleID();
                    txtSaleID.Text = (lastSaleId + 1).ToString();
                }
            }
            

            if (bool.Parse(Session["Help"].ToString()))
            {
                ShowHelp();
            }
            DataRow productRow = Utilities.LoadSpecificProduct(ddlProducts.Text);
            txtPrice.Text = "$" + productRow.ItemArray.GetValue(2).ToString();
            txtSubtotal.Text = "$" + (double.Parse(txtPrice.Text.Remove(0, 1)) * int.Parse(ddlQty.Text)).ToString();
        }

        private void BindDataTable()
        {
            CurrentSaleList.DataSource = myDataTable;
            CurrentSaleList.DataBind();
        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            myDataTable.Rows.Add(ddlProducts.Text, "$" + txtPrice.Text.Remove(0, 1), ddlQty.Text, "$" + (double.Parse(txtPrice.Text.Remove(0, 1)) * double.Parse(ddlQty.Text)).ToString());
            BindDataTable();

            lstSubTotal.Add((double.Parse(txtPrice.Text.Remove(0, 1)) * double.Parse(ddlQty.Text)).ToString());
            ArrayOfString myArray = new ArrayOfString();
            myArray.AddRange(lstSubTotal);
            Total.Text = "$" + service.total(myArray);
        }

        protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow productRow = Utilities.LoadSpecificProduct(ddlProducts.Text);
            txtPrice.Text = "$" + productRow.ItemArray.GetValue(2).ToString();
            txtSubtotal.Text = "$" + (double.Parse(txtPrice.Text.Remove(0, 1)) * double.Parse(ddlQty.Text)).ToString();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            ClearForm();
            pageload = false;            
            if (Session["SaleID"] != null)
            {
                Session["SaleID"] = null;
                Response.Redirect("ViewSales");
            }
            else
            {
                Response.Redirect("Menu");
            }
        }

        protected void ddlQty_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSubtotal.Text = "$" + (double.Parse(txtPrice.Text.Remove(0, 1)) * double.Parse(ddlQty.Text)).ToString();
        }

        public void RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Total.Text = "$" + (double.Parse(Total.Text.Remove(0, 1)) - double.Parse(myDataTable.Rows[e.RowIndex].ItemArray.GetValue(3).ToString().Remove(0, 1))).ToString();


            myDataTable.Rows[e.RowIndex].Delete();
            BindDataTable();
        }

        public void ClearForm()
        {
            myDataTable.Clear();
            lstSubTotal.Clear();
            BindDataTable();
            Total.Text = "";
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
            lblHelp9.Visible = true;
            lblHelp10.Visible = true;
            lblHelp11.Visible = true;
            lblHelp12.Visible = true;
            if (btnDelete.Visible)
            {
                lblHelp13.Visible = true;
            }
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
            lblHelp9.Visible = false;
            lblHelp10.Visible = false;
            lblHelp11.Visible = false;
            lblHelp12.Visible = false;
            lblHelp13.Visible = false;
            Session["Help"] = false;
        }

        private void DeleteSale() {
            Utilities.DeleteSaleLines(int.Parse(txtSaleID.Text));
            Utilities.DeleteSale(int.Parse(txtSaleID.Text));
        }

        protected void btnCompleteSale_Click(object sender, EventArgs e)
        {
            if (Session["SaleID"] != null)
            {
                DeleteSale();
                Utilities.InsertSale(Session["OperatorName"].ToString(), true);
                Utilities.InsertSaleLines(myDataTable, int.Parse((Utilities.LoadLastSaleID()).ToString()));
                ClearForm();
                pageload = false;
                Response.Redirect("ViewSales");
            }
            else
            {
                Utilities.InsertSale(Session["OperatorName"].ToString(), true);
                Utilities.InsertSaleLines(myDataTable, int.Parse(txtSaleID.Text));
            }
            ClearForm();
            pageload = false;
            txtSaleID.Text = (int.Parse(txtSaleID.Text) + 1).ToString();
        }

        protected void btnSaveSale_Click(object sender, EventArgs e)
        {
            if (Session["SaleID"] != null)
            {
                DeleteSale();
                Utilities.InsertSale(Session["OperatorName"].ToString(), false);
                Utilities.InsertSaleLines(myDataTable, int.Parse((Utilities.LoadLastSaleID()).ToString()));
                ClearForm();
                pageload = false;
                Response.Redirect("ViewSales");
            }
            else
            {
                Utilities.InsertSale(Session["OperatorName"].ToString(), false);
                Utilities.InsertSaleLines(myDataTable, int.Parse(txtSaleID.Text));
            }
            ClearForm();
            pageload = false;
            txtSaleID.Text = (int.Parse(txtSaleID.Text) + 1).ToString();
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

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            pageload = false;
            DeleteSale();
            Response.Redirect("ViewSales");
        }
    }
}