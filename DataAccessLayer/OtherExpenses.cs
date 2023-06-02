using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class OtherExpenses
    {
        
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        SqlConnection connect = null;
        double _transportExpense;

        public double TransportExpense
        {
            get { return _transportExpense; }
            set { _transportExpense = value; }
        }
        string _transportPaymentstatus;

        public string TransportPaymentstatus
        {
            get { return _transportPaymentstatus; }
            set { _transportPaymentstatus = value; }
        }
        string _transportDate;

        public string TransportDate
        {
            get { return _transportDate; }
            set { _transportDate = value; }
        }
        double _paidAmount;

        public double PaidAmount
        {
            get { return _paidAmount; }
            set { _paidAmount = value; }
        }
        string _paymentDate;

        public string PaymentDate
        {
            get { return _paymentDate; }
            set { _paymentDate = value; }
        }
        double _electricExpense;

        public double ElectricExpense
        {
            get { return _electricExpense; }
            set { _electricExpense = value; }
        }
        string _electricPaymentStatus;

        public string ElectricPaymentStatus
        {
            get { return _electricPaymentStatus; }
            set { _electricPaymentStatus = value; }
        }
        string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        double _shopRentExpense;

        public double ShopRentExpense
        {
            get { return _shopRentExpense; }
            set { _shopRentExpense = value; }
        }
        string _shopRentPaymentStatus;

        public string ShopRentPaymentStatus
        {
            get { return _shopRentPaymentStatus; }
            set { _shopRentPaymentStatus = value; }
        }
        string _ShopRentPaymetMonth;

        public string ShopRentPaymetMonth
        {
            get { return _ShopRentPaymetMonth; }
            set { _ShopRentPaymetMonth = value; }
        }
        string _electricBillPaidMonth;

        public string ElectricBillPaidMonth
        {
            get { return _electricBillPaidMonth; }
            set { _electricBillPaidMonth = value; }
        }

        double _dueAmount;

        public double DueAmount
        {
            get { return _dueAmount; }
            set { _dueAmount = value; }
        }
        string _paymentTo;

        public string PaymentTo
        {
            get { return _paymentTo; }
            set { _paymentTo = value; }
        }

        string _expenseName;

        public string ExpenseName
        {
            get { return _expenseName; }
            set { _expenseName = value; }
        }

        double _expenseAmount;

        public double ExpenseAmount
        {
            get { return _expenseAmount; }
            set { _expenseAmount = value; }
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
        string _expenseDate;

        public string ExpenseDate
        {
            get { return _expenseDate; }
            set { _expenseDate = value; }
        }
//------------------------------------------------------ Transport DAL-----------------------------------------//

        //    InsertIntoTransportTransactionToTransportTable

        public bool InsertIntoTransportTransactionToTransportTable()
        {
            connect = new SqlConnection(cs);
            try
            {
                SqlCommand cmd = new SqlCommand("spInsertDetailsOfTransport", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TransportDate", TransportDate);
                cmd.Parameters.AddWithValue("@Amount", TransportExpense);

                cmd.Parameters.AddWithValue("@PaymentAmount", PaidAmount);
                cmd.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                cmd.Parameters.AddWithValue("@PaymentStatus", TransportPaymentstatus);
                cmd.Parameters.AddWithValue("@DueAmount", DueAmount);
                cmd.Parameters.AddWithValue("@PaymentTo", PaymentTo);

                connect.Open();
                int i = cmd.ExecuteNonQuery();
                connect.Close();

                if (i > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connect.Close();
            }
        }

        //    GetDataOfTransportTransactionFromTransportTable
        public DataTable GetDataOfTransportTransactionFromTransportTable()
        {
            DataTable dt = new DataTable();
            try
            {
                connect = new SqlConnection(cs);
                SqlDataAdapter sda = new SqlDataAdapter("spGetDetailsOfTransport", connect);
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

        //Update Transport Table
        public bool UpdateTransportDueAmount()
        {
            connect = new SqlConnection(cs);
            try
            {
                SqlCommand cmd = new SqlCommand("spUpdateDetailsOfTransport", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PaymentAmount", PaidAmount);
                cmd.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                cmd.Parameters.AddWithValue("@PaymentStatus", TransportPaymentstatus);
                cmd.Parameters.AddWithValue("@DueAmount", DueAmount);
                cmd.Parameters.AddWithValue("@Id", Id);

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
        // Search ShopRent Date Details
        public DataTable SearchTransportDatebyDate()
        {
            DataTable dt = new DataTable();

            try
            {
                connect = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spSearchTransportExpenses", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@From", FromDate);
                cmd.Parameters.AddWithValue("@To", ToDate);
                connect.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);


                connect.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
            return dt;

        }

//------------------------------------------------------ ShopRent DAL-----------------------------------------//

        //   InsertIntoShopRentExpensesToShopRentTable
        public bool InsertIntoShopRentExpensesToShopRentTable()
        {
            connect = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("spInsertTotblShopRent", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RentPaidMonth", ShopRentPaymetMonth);
            cmd.Parameters.AddWithValue("@Amount", ShopRentExpense);
            cmd.Parameters.AddWithValue("@PaidAmount", PaidAmount);
            cmd.Parameters.AddWithValue("@PaymentDate", PaymentDate);
            cmd.Parameters.AddWithValue("@PaymentStatus", ShopRentPaymentStatus);
            cmd.Parameters.AddWithValue("@DueAmount",DueAmount);
            cmd.Parameters.AddWithValue("@PaymentTo", PaymentTo);

            connect.Open();
            int i = cmd.ExecuteNonQuery();
            connect.Close();

            if (i > 0)
                return true;
            else
                return false;

        }

        //     GetDataOfShopRentExpensesFromShopRentTable
        public DataTable GetDataOfShopRentExpensesFromShopRentTable()
        {
            DataTable dt = new DataTable();
            try
            {
                connect = new SqlConnection(cs);

                SqlDataAdapter sda = new SqlDataAdapter("spGetDetailsOfShopRentExpenses", connect);
                sda.Fill(dt);

                return dt;



            }
            catch (Exception ex)
            {
            }
            finally
            {
            }
            return dt;
        }

        //Update ShopRent Due Amount
        public bool UpdateShopRentDueAmount()
        {
            connect = new SqlConnection(cs);
            try
            {
                SqlCommand cmd = new SqlCommand("spUpdateDetailsOfShopRentExpenses", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PaidAmount", PaidAmount);
                cmd.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                cmd.Parameters.AddWithValue("@PaymentStatus", ShopRentPaymentStatus);
                cmd.Parameters.AddWithValue("@DueAmount", DueAmount);
                cmd.Parameters.AddWithValue("@Id", Id);

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
        // Search ShopRent Date Details
        public DataTable SearchShoprentDetails()
        {
            DataTable dt = new DataTable();

            try
            {
                connect = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spSearchShopRentByMonth", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@From", FromDate);
                cmd.Parameters.AddWithValue("@To", ToDate);
                connect.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);


                connect.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
            return dt;

        }
//------------------------------------------------------Electric  DAL--------------------------------------------///

        //InsertIntoElectricExpensesToElectricTable
        public bool InsertIntoElectricExpensesToElectricTable()
        {
            connect = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("spInsertTotblElectric", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ExpensePaidMonth", ElectricBillPaidMonth);
            cmd.Parameters.AddWithValue("@Amount", ElectricExpense);

            cmd.Parameters.AddWithValue("@PaidAmount", PaidAmount);
            cmd.Parameters.AddWithValue("@PaymentDate", PaymentDate);
            cmd.Parameters.AddWithValue("@PaymentStatus", ElectricPaymentStatus);
            cmd.Parameters.AddWithValue("@DueAmount", DueAmount);
            cmd.Parameters.AddWithValue("@PaidTo", PaymentTo);

            connect.Open();
            int i = cmd.ExecuteNonQuery();
            connect.Close();

            if (i > 0)
                return true;
            else
                return false;
        }

        //Electric  Grid View 
        public DataTable GetDataOfElectricExpenseFromElectricTable()
        {
            DataTable dt = new DataTable();
            try
            {
                connect = new SqlConnection(cs);
                SqlDataAdapter sda = new SqlDataAdapter("spGetDetailsOfElectricExpenses", connect);
                sda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
            }
            return dt;
        }

        //Electric Update Due Amount
        public bool UpdateElectricDueAmount()
        {
            connect = new SqlConnection(cs);
            try
            {
                SqlCommand cmd = new SqlCommand("spUpdateDueAmount", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DueAmount", DueAmount);
                cmd.Parameters.AddWithValue("@PaidAmount", PaidAmount);
                cmd.Parameters.AddWithValue("@PaymentStatus", ElectricPaymentStatus);
                cmd.Parameters.AddWithValue("@ElectricId", Id);

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

        // Search Electric Details using Date to Date
        public DataTable SearchElectricDetails()
        {
            DataTable dt = new DataTable();

            try
            {
                connect = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spSearchElectric", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@From", FromDate);
                cmd.Parameters.AddWithValue("@To", ToDate);
                connect.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);


                connect.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
            return dt;

        }
//------------------------------------------------------Other  DAL--------------------------------------------///


        public bool InsertOtherExpenses()
        {
            try
            {
                connect = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spInsertOtherExpenses", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ExpenseDate", ExpenseDate);
                cmd.Parameters.AddWithValue("@ExpenseName", ExpenseName);
                cmd.Parameters.AddWithValue("@ExpenseAmount", ExpenseAmount);
                cmd.Parameters.AddWithValue("@DueAmount", DueAmount);
                cmd.Parameters.AddWithValue("@PaymentStatus", ShopRentPaymentStatus);
                cmd.Parameters.AddWithValue("@PaymentDate", PaymentDate);

                connect.Open();

                int rows = cmd.ExecuteNonQuery();
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
            }

        }

        //Show Other Expenses

        public DataTable GetDataOfOtherExpenses()
        {
            DataTable dt = new DataTable();
            try
            {
                connect = new SqlConnection(cs);
                SqlDataAdapter sda = new SqlDataAdapter("spGetDataFromOtherExpenses", connect);
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

        //----------Pay Other Expensive Due Amount-------------
        public bool PayOtherExpensiveDueAmount()
        {
            connect = new SqlConnection(cs);
            try
            {
                SqlCommand cmd = new SqlCommand("spUpdateOtherExpenseDetails", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DueAmount", DueAmount);
                cmd.Parameters.AddWithValue("@Status", ShopRentPaymentStatus);
                cmd.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                cmd.Parameters.AddWithValue("@ExpenseId", Id);

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

        //---------------------Search Other Expense Details By Date To Date----------------------------
        public DataTable SearchOtherExpenseDetails()
        {
            DataTable dt = new DataTable();

            try
            {
                connect = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spSearchOtherExpenses", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@From", FromDate);
                cmd.Parameters.AddWithValue("@To", ToDate);
                connect.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);


                connect.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
            return dt;

        }

    }
}