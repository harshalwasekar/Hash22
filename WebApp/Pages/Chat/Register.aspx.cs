using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Pages.Chat
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRegister_OnClick(object sender, EventArgs e)
        {
            WebData d = new WebData();
            d.putUser(txtName.Value , txtEmail.Value ,txtPassword.Value,null); 
            ScriptManager.RegisterStartupScript(this, GetType(), "Message", "alert('Congratulations!! You have successfully registered..');", true);
            Session["UserName"] = txtName.Value;
            Session["Email"] = txtEmail.Value;
            Response.Redirect("Chat.aspx");
        }
    }
}