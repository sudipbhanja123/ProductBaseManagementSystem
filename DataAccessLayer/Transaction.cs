using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class Transaction
    {
        string _paymentStatus;

        public string PaymentStatus
        {
            get { return _paymentStatus; }
            set { _paymentStatus = value; }
        }
        double _dueAmount;

        public double DueAmount
        {
            get { return _dueAmount; }
            set { _dueAmount = value; }
        }
        string _transactionId;

        public string TransactionId
        {
            get { return _transactionId; }
            set { _transactionId = value; }
        }
        string _paymentDate;

        public string PaymentDate
        {
            get { return _paymentDate; }
            set { _paymentDate = value; }
        }
        string _fromDate;

        public string FromDate
        {
            get { return _fromDate; }
            set { _fromDate = value; }
        }
        string _toDate;

        public string ToDate
        {
            get { return _toDate; }
            set { _toDate = value; }
        }
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        SqlConnection connect = null;
        public DataTable GetAllTransaction()
        {

            DataTable dt = new DataTable();
            try
            {
                connect = new SqlConnection(cs);
                SqlDataAdapter sda = new SqlDataAdapter("spGetAllTransition", connect);

                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
            return dt;

        }
        public bool UpdateTransactionStatus()
        {
            connect = new SqlConnection(cs);
            try
            {
                SqlCommand cmd = new SqlCommand("spUpdateAllTransition", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
                cmd.Parameters.AddWithValue("@DueAmount", DueAmount);
                cmd.Parameters.AddWithValue("@TransactionId", TransactionId);
                cmd.Parameters.AddWithValue("@PaymentDate", PaymentDate);

                connect.Open();
                int i = cmd.ExecuteNonQuery();
                connect.Close();
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {

            }
        }

        //-----------------------Search Transaction Status--------------------

        public DataTable SearchTransaction()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection connect = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spSearchTransaction", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@From", FromDate);
                cmd.Parameters.AddWithValue("@To", ToDate);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
            }
            finally
            {
            }
            return dt;
        }
    }
}
