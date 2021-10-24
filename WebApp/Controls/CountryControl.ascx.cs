using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Controls 
{
    public partial class CountryControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }
        [WebMethod]
        private static List<ListItem> GetCountry()
        {
            List<ListItem> customers = new List<ListItem>();

            try
            {
                WebData wd = new WebData();
                DataTable dt = wd.GetCountry();
                
                foreach(DataRow dr in dt.Rows)
                {
                    customers.Add(new ListItem
                    {
                        Value = dr["Name"].ToString(),
                        Text = dr["ID"].ToString()
                    });
                }
                
            }
            catch(Exception ex)
            {
                
            }
            return customers;
        }
    }
}