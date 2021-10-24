using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI.WebControls;

namespace WebApp.Controls
{
    /// <summary>
    /// Summary description for CountryWebServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class CountryWebServices : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ListItem> GetCountry()
        {
            List<ListItem> customers = new List<ListItem>();

            try
            {
                WebData wd = new WebData();
                DataTable dt = wd.GetCountry();

                foreach (DataRow dr in dt.Rows)
                {
                    customers.Add(new ListItem
                    {
                        Value = dr["ID"].ToString(),
                        Text = dr["Name"].ToString()
                    });
                }
                string x = Session["xyz"].ToString();
            }
            catch (Exception ex)
            {

            }
            return customers;
        }
    }
}
