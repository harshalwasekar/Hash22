using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class WebData
    {
        public DataTable getUser(string Email, string Password)
        {
            string connectionStr = ConfigurationManager.ConnectionStrings["ConnStringSignal"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionStr))
            {
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "spGetUser";
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();

                if (Email != null)
                {
                    SqlParameter param = new SqlParameter
                        ("@Email", Email);
                    cmd.Parameters.Add(param);
                }
                if (Password != null)
                {
                    SqlParameter param = new SqlParameter
                        ("@Password", Password);
                    cmd.Parameters.Add(param);
                }
                try
                {
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                }
                catch(Exception e)
                {

                }
                
                return dt;
            }
        }
        public void putUser(string Name,string Email,string Password, string photo)
        {
            string connectionStr = ConfigurationManager.ConnectionStrings["ConnStringSignal"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionStr))
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "spPutUser";
                cmd.CommandType = CommandType.StoredProcedure;

                if (Name != null)
                {
                    SqlParameter param = new SqlParameter("@Name", Name);
                    cmd.Parameters.Add(param);
                }
                if (Email != null)
                {
                    SqlParameter param = new SqlParameter("@Email", Email);
                    cmd.Parameters.Add(param);
                }
                if (Name != null)
                {
                    SqlParameter param = new SqlParameter("@Password", Password);
                    cmd.Parameters.Add(param);
                }
                SqlParameter param1 = new SqlParameter("@Password", Password);
                cmd.Parameters.Add(param1);

                try
                {
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                }
                catch (Exception e)
                {

                }

       
            }
        }
        public DataTable GetCountry()
        {
            string connectionStr = ConfigurationManager.ConnectionStrings["ConnStringStudent"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionStr))
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "spGetCountry";
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();

                try
                {
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                }
                catch (Exception e)
                {

                }

                return dt;
            }
        }
        public DataTable GetState()
        {
            string connectionStr = ConfigurationManager.ConnectionStrings["ConnStringStudent"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionStr))
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "spGetState";
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();

                try
                {
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                }
                catch (Exception e)
                {

                }

                return dt;
            }
        }
        public DataTable GetCity()
        {
            string connectionStr = ConfigurationManager.ConnectionStrings["ConnStringStudent"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionStr))
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "spGetCity";
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();

                try
                {
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                }
                catch (Exception e)
                {

                }

                return dt;
            }
        }
    }
}