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
    public partial class CountryHandler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }
        [WebMethod]
        public static List<ListItem> GetCountry()
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

            }
            catch (Exception ex)
            {

            }
            return customers;
        }
        [WebMethod]
        public static List<ListItem> GetState(int ID)
        {
            List<ListItem> customers = new List<ListItem>();

            try
            {
                WebData wd = new WebData();
                DataTable dt = wd.GetState();
                DataView dv = dt.DefaultView;
                if(ID != 0)
                {
                    dv.RowFilter = "CountryID =" + ID;
                    HttpContext.Current.Session["CountryID"] = ID;
                }

                foreach (DataRowView dr in dv)
                {
                    customers.Add(new ListItem
                    {
                        Value = dr["ID"].ToString(),
                        Text = dr["Name"].ToString()
                    });
                }

            }
            catch (Exception ex)
            {

            }
            return customers;
        }
        [WebMethod]
        public static List<ListItem> GetCity(int ID)
        {
            List<ListItem> customers = new List<ListItem>();

            try
            {
                WebData wd = new WebData();
                DataTable dt = wd.GetCity();
                DataView dv = dt.DefaultView;
                if (ID != 0)
                {
                    dv.RowFilter = "StateID =" + ID;
                    HttpContext.Current.Session["StateID"] = ID;
                }
                foreach (DataRowView dr in dv)
                {
                    customers.Add(new ListItem
                    {
                        Value = dr["ID"].ToString(),
                        Text = dr["Name"].ToString()
                    });
                }

            }
            catch (Exception ex)
            {

            }
            return customers;
        }
        [WebMethod]
        public static void SetCity(int ID)
        {
            List<ListItem> customers = new List<ListItem>();

            try
            {
                if (ID != 0)
                {
                    HttpContext.Current.Session["CityID"] = ID;
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}