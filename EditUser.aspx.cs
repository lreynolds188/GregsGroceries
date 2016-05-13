using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GregsGrocery
{
    public partial class EditUser : System.Web.UI.Page
    {
        DataRow userCredentials;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["OperatorName"] == null) { Response.Redirect("Default"); }
            if (!IsPostBack)
            {
                try
                {
                    if (Session["SelectedOperator"] == null)
                    {
                        btnDelete.Visible = false;
                        btnSave.Text = "Create";
                        lblSelectedOperator.Visible = true;
                        lblSelectedOperator.Text = "New User";
                        lblHelp3.Text = "New operator name";
                        lblHelp4.Text = "New operator pin";
                        lblHelp5.Text = "Give new operator sales permissions --->";
                        lblHelp6.Text = "<--- Give new operator admin permissions";
                        lblHelp9.Text = "Create new operator --->";
                    }
                    else
                    {
                        userCredentials = Utilities.LoadUserCredentialsWithoutID(Session["SelectedOperator"].ToString());
                        lblSelectedOperator.Text = userCredentials.ItemArray.GetValue(0).ToString();
                        txtOperator.Text = userCredentials.ItemArray.GetValue(0).ToString();
                        txtOperatorPin.Text = userCredentials.ItemArray.GetValue(1).ToString();
                        cbSalesPermissions.Checked = bool.Parse(userCredentials.ItemArray.GetValue(2).ToString());
                        cbAdminPermissions.Checked = bool.Parse(userCredentials.ItemArray.GetValue(3).ToString());
                    }
                    lblOperator.Text = Session["OperatorName"].ToString();
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
            lblHelp6.Visible = true;
            lblHelp7.Visible = true;
            if (btnDelete.Visible)
            {
                lblHelp8.Visible = true;
            }
            lblHelp9.Visible = true;
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
            Session["Help"] = false;
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditUserList");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                Utilities.UpdateCredentials(lblSelectedOperator.Text, txtOperator.Text, txtOperatorPin.Text, cbSalesPermissions.Checked, cbAdminPermissions.Checked);
            }
            else
            {
                Utilities.AddNewUser(txtOperator.Text, txtOperatorPin.Text, cbSalesPermissions.Checked, cbAdminPermissions.Checked);
            }
            Response.Redirect("EditUserList");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Utilities.DeleteUser(txtOperator.Text);
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