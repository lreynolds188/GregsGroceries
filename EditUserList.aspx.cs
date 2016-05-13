using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GregsGrocery
{
    public partial class EditUserList : System.Web.UI.Page
    {
        private static DataTable myData = new DataTable("UserList");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["OperatorName"] == null) { Response.Redirect("Default"); }
            if (!IsPostBack)
            {
                lblOperator.Text = Session["OperatorName"].ToString();
                if (bool.Parse(Session["Help"].ToString()))
                {
                    ShowHelp();
                }
            }
            gvUserList.DataSource = Utilities.LoadCredentialsWithoutID();
            gvUserList.DataBind();
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

        protected void gvUserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["SelectedOperator"] = gvUserList.SelectedRow.Cells[1].Text;
            Response.Redirect("EditUser");
        }

        protected void btnNewUser_Click(object sender, EventArgs e)
        {
            Session["SelectedOperator"] = null;
            Response.Redirect("EditUser");
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