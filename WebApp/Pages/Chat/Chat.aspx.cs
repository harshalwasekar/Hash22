using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Pages.Chat
{
    public partial class Chat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void SendMessageToAll(string userName, string message, string time)
        {
            string UserImg = GetUserImage(userName);
            // store last 100 messages in cache  
            //AddMessageinCache(userName, message, time, UserImg);

            //// Broad cast message  
            //Clients.All.messageReceived(userName, message, time, UserImg);

        }
        public string GetUserImage(string username)
        {
            //string RetimgName = "images/dummy.png";
            //try
            //{
            //    string query = "select Photo from tbl_Users where UserName='" + username + "'";
            //    string ImageName = ConnC.GetColumnVal(query, "Photo");

            //    if (ImageName != "")
            //        RetimgName = "images/DP/" + ImageName;
            //}
            //catch (Exception ex)
            //{ }
            return "";
        }
    }
}