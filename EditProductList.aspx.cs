using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GregsGrocery
{
    public partial class EditProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["OperatorName"] == null) { Response.Redirect("Default"); }
            if (!IsPostBack)
            {
                try
                {
                    lblOperator.Text = Session["OperatorName"].ToString();
                    gvProductList.DataSource = Utilities.LoadProducts();
                    gvProductList.DataBind();
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
            Session["Help"] = true;
        }

        private void HideHelp()
        {
            btnHelp.Text = "Show Help";
            lblHelp1.Visible = false;
            lblHelp2.Visible = false;
            lblHelp3.Visible = false;
            lblHelp4.Visible = false;
            Session["Help"] = false;
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu");
        }

        protected void gvProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["CurrentProductID"] = gvProductList.SelectedRow.Cells[1].Text;
            Response.Redirect("EditProduct");
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            Session["CurrentProductID"] = null;
            Response.Redirect("EditProduct");
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