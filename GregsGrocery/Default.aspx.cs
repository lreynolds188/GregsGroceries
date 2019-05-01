using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GregsGrocery
{
    public partial class Default : System.Web.UI.Page
    {

        bool blnLoginSuccess = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["Help"] = false;
                Response.Write("<script>alert('Logins:\\nadmin | admin\\nuser | pass');</script>");
            }
        }

        private void Login()
        {
            blnLoginSuccess = Utilities.CheckCredentials(txtOperatorName.Text, txtOperatorPin.Text);
            if (blnLoginSuccess)
            {
                Session["OperatorName"] = txtOperatorName.Text;
                Response.Redirect("Menu");
            }
            else
            {
                lblInfo.Text = "Invalid username or password";
                lblInfo.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        protected void btnHelp_Click(object sender, EventArgs e)
        {
            if (btnHelp.Text == "Show Help")
            {
                Session["Help"] = true;
                btnHelp.Text = "Hide Help";
                lblHelp1.Visible = true;
                lblHelp2.Visible = true;
                lblHelp3.Visible = true;
            }
            else
            {
                Session["Help"] = false;
                btnHelp.Text = "Show Help";
                lblHelp1.Visible = false;
                lblHelp2.Visible = false;
                lblHelp3.Visible = false;
            }
        }
    }
}