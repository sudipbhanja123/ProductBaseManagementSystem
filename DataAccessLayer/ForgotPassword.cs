using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace DataAccessLayer
{
  public  class ForgotPassword
    {
     
          string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        SqlConnection connect = null;
        string _nickname;

        public string Nickname
        {
            get { return _nickname; }
            set { _nickname = value; }
        }
        string _userPassword;

       public string UserPassword
       {
          get { return _userPassword; }
          set { _userPassword = value; }
       }
        string _managerId;

       public string ManagerId
       {
          get { return _managerId; }
          set { _managerId = value; }
       }


// ---------------------------------------------Manager Forgot Password DAL----------------------------------//

       //    Check Manager NickName Sp
        public bool CheckManagerNickName()
        {

            try
            {
                connect = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spManagerForgotPassword", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NickName",Nickname);

                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

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
            }
        }

        // FillManagerUserName by Using NickName
        public string FillManagerUserName()
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


      //    New password Sp for Manager
        public bool CreateNewManagerPassword()
        {
            connect = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("spSetNewManagerPassword", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@ManagerId",ManagerId);
            cmd.Parameters.AddWithValue("@ManagerPassword",UserPassword);
            cmd.Parameters.AddWithValue("@NickName",Nickname);
           
           
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


        //Get Manager Password
        public string GetManagerUserPassword()
        {
            string UserPassword = "";
            try
            {
                connect = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spGetManagerUserPassword", connect);
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


// ---------------------------------------------Admin Forgot Password DAL----------------------------------//

        // Check Admin NickName sp
        public bool CheckAdminNickName()
        {

            try
            {
                connect = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spAdminForgotPassword", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NickName", Nickname);

                connect.Open();
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
                connect.Close();
            }
        }

        // Fill Admin UserName by Using NickName
      public string FillAdminUserName()
      {
          string UserName = "";
          try
          {
            connect=new SqlConnection (cs);
            SqlCommand cmd = new SqlCommand("spAdminUserName", connect);
              cmd.CommandType=CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@NickName",Nickname);
              connect.Open();
              SqlDataReader rdr=cmd.ExecuteReader();
              while(rdr.Read())
              {
                  UserName = rdr["UserName"].ToString();
              }
              return UserName;
          }
          catch(Exception ex)
          {
            return UserName;
          }
          finally
          {
              connect.Close();
          }
      }

      // New Password sp For Admin
        public bool CreateNewAdminPassword()
        {
            connect = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("spSetAdminrPassword", connect);
            cmd.CommandType = CommandType.StoredProcedure;
           
            cmd.Parameters.AddWithValue("@UserPassWord",UserPassword);
            cmd.Parameters.AddWithValue("@NickName", Nickname);
           
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


        //Get Admin Password
        public string GetAdminUserPassword()
        {
            string UserPassword = "";
            try
            {
                connect = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spGetAdminUserPassword", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NickName", Nickname);
                connect.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    UserPassword = rdr["UserPassWord"].ToString();
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
