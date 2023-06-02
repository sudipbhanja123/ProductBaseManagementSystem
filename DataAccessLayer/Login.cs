using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataAccessLayer
{
     public class Login
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        SqlConnection con = null;
        string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

//------------------------------------------For Check Admin Login-------------------------------//

        public bool CheckAdminLogin()
        {

            try
            {
                con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spAdminLogin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", this._userName);
                cmd.Parameters.AddWithValue("@Password", this._password);
                con.Open();
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter();

                sda.SelectCommand = cmd;
                sda.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

//----------------------------------------Manager Login Check--------------------------------//

       public bool ManagerLoginCheck()
        {
            try
            {
                con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spManagerLogin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@UserPassword", Password);
                con.Open();
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter();

                sda.SelectCommand = cmd;
                sda.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                con.Close();
            }

        }
      

    }
}
