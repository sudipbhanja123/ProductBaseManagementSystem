using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
   public  class SignUP
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        SqlConnection connect = null;



        string _userId;

        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
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
        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        string _phnumber;

        public string Phnumber
        {
            get { return _phnumber; }
            set { _phnumber = value; }
        }
        string _nickname;

        public string Nickname
        {
            get { return _nickname; }
            set { _nickname = value; }
        }

        string _confirmPassword;

        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set { _confirmPassword = value; }
        }


       // Create Admin Account
        public bool CreateAdminAccount()
        {
            try
            {
                connect = new SqlConnection(cs);
                SqlCommand command = new SqlCommand("spInsertAdminDetails", connect);
                command.CommandType = CommandType.StoredProcedure;
                connect.Open();
                command.Parameters.AddWithValue("Name", Name);
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@PhoneNumber", Phnumber);
                command.Parameters.AddWithValue("@NickName", Nickname);
                command.Parameters.AddWithValue("@UserPassword", Password);
                int rows = command.ExecuteNonQuery();
                connect.Close();
                if (rows > 0)
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
                connect.Close();
            }
        }

       // Get Admin Information
        public DataTable GetSignUpInformation()
        {

            SqlConnection connect = new SqlConnection(cs);
            DataTable dt = new DataTable();
            connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("spGetAdminDetails", connect);

            sda.Fill(dt);

            connect.Close();
            return dt;
        }

       // Updtae SignUp Details
        public bool UpdateAdminDetails(string AdminId)
        {
            connect = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("spUpdateAdminDetails", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@PhoneNumber", Phnumber);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@UserPassword", Password);
            cmd.Parameters.AddWithValue("@NickName",Nickname);


            cmd.Parameters.AddWithValue("@AdminId", AdminId);
            connect.Open();
            int rows = cmd.ExecuteNonQuery();
            connect.Close();
            if (rows > 0)
            {
                return true;
            }
            else
                return false;

        }


       //Delete Admin Details

        public bool DeleteAdminDetails()
        {
            SqlConnection connect = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("spDeleteAdminDetails", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AdminId", UserId);

            connect.Open();
            int rows = cmd.ExecuteNonQuery();
            connect.Close();

            if (rows > 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}


