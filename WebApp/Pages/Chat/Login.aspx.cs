using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Pages.Chat
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_OnClick(object sender, EventArgs e)
        {
            WebData wd = new WebData();
            DataTable dt = wd.getUser(txtEmail.Value, txtPassword.Value);
            
            if (dt.Rows[0]["Email"].ToString() == txtEmail.Value && dt.Rows[0]["Password"].ToString() == txtPassword.Value)
            {
                string UserName = dt.Rows[0]["Name"].ToString();
                Session["UserName"] = UserName;
                Session["Email"] = txtEmail.Value;
                Response.Redirect("Chat.aspx");
            }
            else
                txtEmail.Value = "Invalid Email or Password!!";
        }
    }
}