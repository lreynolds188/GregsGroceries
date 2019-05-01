using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GregsGrocery
{
    public partial class Contact : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    if (Session["OperatorName"] == null) { Response.Redirect("Default"); }
                    txtOperator.Text = Session["OperatorName"].ToString();
                    DataRow row = Utilities.LoadUserCredentials(Session["OperatorName"].ToString());

                    //Sales User
                    if (row.ItemArray.GetValue(3).Equals(false))
                    {
                        btnNewSale.Enabled = false;
                        btnViewSales.Enabled = false;
                    }
                    else
                    {
                        btnNewSale.Enabled = true;
                        btnViewSales.Enabled = true;
                    }

                    //Admin User
                    if (row.ItemArray.GetValue(4).Equals(false))
                    {
                        btnEditProductList.Enabled = false;
                        btnEditUserList.Enabled = false;
                    }
                    else
                    {
                        btnEditProductList.Enabled = true;
                        btnEditUserList.Enabled = true;
                    }
                    if (bool.Parse(Session["Help"].ToString()))
                    {
                        ShowHelp();
                    }
                }
                catch (Exception err) { }
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

        protected void btnNewSale_Click(object sender, EventArgs e)
        {
            Response.Redirect("MakeSale");
        }

        protected void btnViewSales_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewSales");
        }

        protected void btnEditProductList_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditProductList");
        }

        protected void btnEditUserList_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditUserList");
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