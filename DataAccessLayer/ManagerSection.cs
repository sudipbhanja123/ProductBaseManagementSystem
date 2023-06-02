using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class ManagerSection
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
        string _addhar;

        public string Addhar
        {
            get { return _addhar; }
            set { _addhar = value; }
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
        string _hiredate;

        public string Hiredate
        {
            get { return _hiredate; }
            set { _hiredate = value; }
        }
        string _firedate;

        public string Firedate
        {
            get { return _firedate; }
            set { _firedate = value; }
        }
        int _salary;

        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

//----------------------------------------Manager Hire DAL----------------------------------------------------//

        // Hire Manager
        public bool HireManager()
        {
            try
            {
                connect = new SqlConnection(cs);
                SqlCommand command = new SqlCommand("spRegisterManager", connect);
                command.CommandType = CommandType.StoredProcedure;
                connect.Open();
                command.Parameters.AddWithValue("Name", Name);
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@UserPassword", Password);
                command.Parameters.AddWithValue("@AddharNo", Addhar);
                command.Parameters.AddWithValue("@PhoneNumber", Phnumber);
                command.Parameters.AddWithValue("@NickName", Nickname);
                command.Parameters.AddWithValue("@HireDate", Hiredate);
                command.Parameters.AddWithValue("@Salary", Salary);
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
       
        // Fire Manager Information From Database
        public bool DeleteManagerInfomationFromDatabase()
        {
            SqlConnection connect = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("spDeleteManager", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ManagerId", UserId);

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

        // Update Manager Details
        public bool UpdateManagerInfomationToDatabase(string ManagerId)
        {
            connect = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("spUpdateManager", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ManagerName", Name);
            cmd.Parameters.AddWithValue("@PhoneNumber", Phnumber);
            cmd.Parameters.AddWithValue("@AddharNo", Addhar);
            cmd.Parameters.AddWithValue("@HireDate", Hiredate);
            cmd.Parameters.AddWithValue("@FireDate", Firedate);
            cmd.Parameters.AddWithValue("@Salary", Salary);
            cmd.Parameters.AddWithValue("@ManagerId", ManagerId);
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

        //    GetManagerInfomationFromDatabase
        public DataTable GetManagerInfomationFromDatabase()
        {

            SqlConnection connect = new SqlConnection(cs);
            DataTable dt = new DataTable();
            connect.Open();
            SqlDataAdapter sda = new SqlDataAdapter("spGetManagerDetails", connect);

            sda.Fill(dt);

            connect.Close();
            return dt;
        }


        //Get Manager UserName

        public string GetManagerUserName()
        {
            string UserName = "";
            try
            {
                connect = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spGetUserName", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NickName", Nickname);
                connect.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    UserName = rdr["UserName"].ToString();
                }
                return UserName;
            }
            catch (Exception ex)
            {
                return UserName;
            }
            finally
            {
                connect.Close();
            }
        }

        //Get User Password
        public string GetManagerUserPassword()
        {
            string UserPassword = "";
            try
            {
                connect = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spGetUserPassword", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NickName", Nickname);
                connect.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    UserPassword = rdr["UserPassword"].ToString();
                }
                return UserPassword;
            }
            catch (Exception ex)
            {
                return UserPassword;
            }
            finally
            {
                connect.Close();
            }
        }
    }


}
