using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GregsGrocery
{
    public partial class EditProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["OperatorName"] == null) { Response.Redirect("Default"); }
            if (!IsPostBack)
            {
                try
                {
                    lblOperator.Text = Session["OperatorName"].ToString();
                    if (bool.Parse(Session["Help"].ToString()))
                    {
                        ShowHelp();
                    }
                    if (Session["CurrentProductID"] != null)
                    {
                        txtProduct.Text = Utilities.LoadSpecificProduct(int.Parse(Session["CurrentProductID"].ToString())).ItemArray.GetValue(1).ToString();
                        txtProductPrice.Text = Utilities.LoadSpecificProduct(int.Parse(Session["CurrentProductID"].ToString())).ItemArray.GetValue(2).ToString();
                    }
                    else
                    {
                        lblHelp2.Text = "New product name --->";
                        lblHelp3.Text = "<--- New product price";
                        lblHelp6.Text = "Create new product --->";
                        btnDelete.Visible = false;
                        lblHelp5.Visible = false;
                        btnSave.Text = "Create";
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
            if (btnDelete.Visible)
            {
                lblHelp5.Visible = true;
            }
            lblHelp6.Visible = true;
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
            Session["Help"] = false;
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["OperatorName"] = "";
            Response.Redirect("Default");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditProductList");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            double dbPrice;
            if (txtProductPrice.Text.Substring(0, 1) == "$")
            {
                dbPrice = double.Parse(txtProductPrice.Text.Remove(0, 1));
            }
            else
            {
                dbPrice = double.Parse(txtProductPrice.Text);
            }

            if (btnDelete.Visible)
            {
                Utilities.UpdateProduct(int.Parse(Session["CurrentProductID"].ToString()), txtProduct.Text, dbPrice);
            }
            else
            {
                Utilities.AddNewProduct(txtProduct.Text, dbPrice);
            }
            Response.Redirect("EditProductList");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Utilities.DeleteProduct(int.Parse(Session["CurrentProductID"].ToString()));
            Response.Redirect("EditProductList");
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
    }
}