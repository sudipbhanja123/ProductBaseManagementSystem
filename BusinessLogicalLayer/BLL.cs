using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using System.Data;
using System.Collections;

namespace BusinessLogicalLayer
{

    public class BLL
    {
        ManagerSection manager = new ManagerSection();
        Login login = new Login();
        ForgotPassword forgot = new ForgotPassword();
        WorkOnProductDetails ProductDetails = new WorkOnProductDetails();
        OtherExpenses otherexpenses = new OtherExpenses();
        Validation valid = new Validation();
        Transaction transaction = new Transaction();
        SignUP signUp = new SignUP();

//-------------------------------------------Sign Up Bll---------------------------------------------
        public bool AdminSignUpBll(string name, string phonenumber, string nickname,string Password)
        {
            string[] firstName = name.Split(' ');
            signUp.Name = name;
            signUp.UserName = firstName[0]+"123";
            signUp.Phnumber = phonenumber;
            signUp.Nickname = nickname;
            signUp.Password = Password;
            return signUp.CreateAdminAccount();

        }

        // GetSignUp Details Bll
        public DataTable GetSignUpInformationBll()
        {
            return signUp.GetSignUpInformation();
        }

        //Update Admin Details
        public bool UpdateAdminDetailsBll(string name, string phonenumber, string username, string Password, string nickname, string id)
        {
            signUp.Name = name;
            signUp.UserName = username;
            signUp.Phnumber = phonenumber;
            signUp.Nickname = nickname;
            signUp.Password = Password;
            return signUp.UpdateAdminDetails(id);
        }


        //Delete Admin Details

        public bool DeleteAdminDetailsBll(string id)
        {
            signUp.UserId = id;
            return signUp.DeleteAdminDetails();
        }



//--------------------------------------------Log In BLL----------------------------------------------
        // Check Admin Login
        public bool CheckAdminLoginBll(string userName, string password)
        {
            login.UserName = userName;
            login.Password = password;

            return login.CheckAdminLogin();
        }

        // Check Manger Login
        public bool ManagerLoginCheckBll(string username, string password)
        {
            login.UserName = username;
            login.Password = password;
            return login.ManagerLoginCheck();
        }

        // Vlid UserName
        public bool ValidUserName(string UserName)
        {
            if (Validation.isValidName(UserName))
            {
                return true;
            }
            else
                return false;
        }

        //Valid Password
        //public bool ValidPassword(string Password)
        //{
        //    if (Validation.isValidPassword(Password))
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //}


        //Valid Password

        public string PasswordValidationBll(string Password)
        {
            valid.Password = Password;
            return valid.isValidPassword();
        }

        // Valid Nick Name
        public bool ValidNickName(string NickName)
        {
            if (Validation.isValidNickName(NickName))
            {
                return true;
            }

            else
                return false;
        }
       

//-------------------------------------------Manager Hire BLL-----------------------------------//


        //checkManagerName
        public bool checkManagerNameBll(string name)
        {
            if (Validation.isValidName(name))
            {
                return true;
            }
            else
                return false;
        }

        //   checkNickName
        public bool checkNickNameBll(string nickname)
        {
            if (Validation.isValidNickName(nickname))
            {
                return true;
            }
            else
                return false;
        }

        //   checkManagerUserName
        public bool checkManagerUserNameBll(string userName)
        {
            if (Validation.isValidUserName(userName))
            {
                return true;
            }
            else
                return false;
        }

     

        //   checkManagerPhoneNumber
        public bool checkManagerPhoneNumberBll(string phno)
        {
            if (Validation.isValidAPhoneNumber(phno))
            {
                return true;
            }
            else
                return false;
        }

        //check Manager Addhar Number
        public bool checkManagerAddharNumberBll(string addhar)
        {
            if (Validation.isValidAddhar(addhar))
            {
                return true;
            }
            else
                return false;
        }

        //   checkManagerSalary
        public bool checkManagerSalaryBll(long salary)
        {
            if (Validation.isValidSalary(salary))
            {
                return true;
            }
            else
            {
                return false;
            }


        }


        // Manager Hire BLL   
        public bool HireManagerBll(string name, string username, string addhar, string phonenumber, string nickname, string hiredate, int salary)
        {
            manager.Name = name;
            manager.UserName = username;
            string password;
            string[] firstname = name.Split(' ');
            password = firstname[0] + "@" + "123";
            manager.Password = password;
            manager.Addhar = addhar;
            manager.Phnumber = phonenumber;
            manager.Nickname = nickname;
            manager.Hiredate = hiredate;
            manager.Salary = salary;

            return manager.HireManager();

        }


        //    ManagerFillGridviewBLL
        public DataTable ManagerFillGridviewBLL()
        {
            return manager.GetManagerInfomationFromDatabase();
        
        }


        //FireManagerBll
        public bool FireManagerBll(string id)
        {
            manager.UserId = id;
            return manager.DeleteManagerInfomationFromDatabase();
        }

        //UpdateManagerInfomationToDatabaseBll
        public bool UpdateManagerInfomationToDatabaseBll(string name, string phoneno, string addharno, string hiredate, string firedate, int salary, string ManagerId)
        {
            manager.Name = name;
            manager.Phnumber = phoneno;
            manager.Addhar = addharno;
            manager.Hiredate = hiredate;
            manager.Firedate = firedate;
            manager.Salary = salary;

            return manager.UpdateManagerInfomationToDatabase(ManagerId);
        }

        //Get Manager UserName
        public string GetManagerUserNameBll(string nickname)
        {
            manager.Nickname = nickname;

            return manager.GetManagerUserName();
        }
        //Get Manager UserName
        public string GetManagerUserPasswordBll(string nickname)
        {
            manager.Nickname = nickname;

            return manager.GetManagerUserPassword();
        }



//-------------------------------------------------Forgot BLL--------------------------------------------//

        // Forgot Password for Check Manager Nick Name 
        public bool CheckManagerNickNameBll(string nickname)
        {
            forgot.Nickname = nickname;
            return forgot.CheckManagerNickName();
        }

        //FillManagerUserName
        public string FillManagerUserNameBll(string nickname)
        {
            forgot.Nickname = nickname;

            return forgot.FillManagerUserName();
        }

        //   Forgot Password for Create New Manager Pasworod 
        public bool CreateNewManagerPasswordBll(string password, string nickname)
        {
            forgot.UserPassword = password;
            forgot.Nickname = nickname;

            return forgot.CreateNewManagerPassword();
        }

        //Check Admin NickName
        public bool CheckAdminNickNameBll(string nickname)
        {
            forgot.Nickname = nickname;
            return forgot.CheckAdminNickName();
        }

        //Create New Admin PassWord
        public bool CreateNewAdminPasswordBll(string password, string nickname)
        {
            forgot.Nickname = nickname;
            forgot.UserPassword = password;

            return forgot.CreateNewAdminPassword();
        }

        //   FillAdminUserNameBll
        public string FillAdminUserNameBll(string nickname)
        {
            forgot.Nickname = nickname;

            return forgot.FillAdminUserName();
        }
         //  Search Brand Name Bll
        public ArrayList SearchBrandBll()
        {
            // ProductDetails.BrandName = brand;

            return ProductDetails.GetSearchBrand();
        }
        //  Search Weight Bll
        public DataSet SearchWeightBll(string weight)
        {
            ProductDetails.Weight = weight;
            return ProductDetails.GetSearchWeight();
        }

        //Get Manager User Password

        public string GetManagerUserConfirmPasswordBll(string nickname)
        {
            forgot.Nickname = nickname;

            return forgot.GetManagerUserPassword();
        }


        //Get Admin User Password
        public string GetAdminUserPasswordBll(string nickname)
        {
            forgot.Nickname = nickname;

            return forgot.GetAdminUserPassword();
        }


//--------------------------------------------------Entry Stock Details BLL----------------------------------------//
        // For geting BrandName using ArrayList
        public ArrayList GetBrandNameBll()
        {
            return ProductDetails.GetBrand();
        }


        // GetSubBrandBySelectedBrandName using ArrayList
        public ArrayList GetSubBrandBySelectedBrandNameBll(string BrandName)
        {
            return ProductDetails.GetSubBrand(BrandName);
        }

        //   GetWeight
        public ArrayList GetWeight()
        {
            return ProductDetails.GetWeight();
        }

        // Send DetailsToDAL
        public bool InsertProductsToDatabaseBll(string[] Details)
        {


            ProductDetails.BrandName = Details[0];
            ProductDetails.SubBrandName = Details[1];
            ProductDetails.Quantity = Convert.ToInt32(Details[3]);
            ProductDetails.Weight = Details[2];
            ProductDetails.UnitPrice = Convert.ToDouble(Details[4]);
            ProductDetails.ExpiaryDate = Details[5];
            ProductDetails.PaidAmount = Convert.ToDouble(Details[6]);
            ProductDetails.DealerName = Details[7];
            try
            {
                return ProductDetails.InsertProductsToDatabase();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        //Get Stock Details From Database
        public DataTable FillGridViewFromDatabase()
        {
            return ProductDetails.FillGridView();
        }

        //    CheckQuantityIsValid
        public bool CheckQuantityIsValid(string Weight)
        {
            int WeightConvert = 0;
            bool SuccesfullToConvertInt = int.TryParse(Weight, out WeightConvert);
            if (!SuccesfullToConvertInt)
            {
                return false;
            }
            else if (WeightConvert <= 0)
            {
                return false;
            }
            return true;
        }

        //     CheckUnitPriceIsValid
        public bool CheckUnitPriceIsValid(string UnitPrice)
        {
            double UnitPriceConvert = 0;
            bool SuccesfullToConvertInt = double.TryParse(UnitPrice, out UnitPriceConvert);
            if (!SuccesfullToConvertInt)
            {
                return false;
            }
            else if (UnitPriceConvert <= 0)
            {
                return false;
            }
            return true;
        }

        // BLL Methode for Delete Productrs From Database
        public bool DeleteRowFromDataGridView(string BatchNo)
        {
            ProductDetails.BatchNo = BatchNo;
            return ProductDetails.DeleteFromDataBase();
        }

        // BLL Methode for Update Products From Database
        public bool UpdateProductsToDatabaseBLL(string[] Details, string BatchNo)
        {
            ProductDetails.BrandName = Details[0];
            int LotNo = 0;
            if (int.TryParse(Details[1], out LotNo))
            {
                ProductDetails.LotNumber = LotNo;
            }
            ProductDetails.SubBrandName = Details[2];
            ProductDetails.Weight = Details[3];
            double UnitPrice = 0;
            if (double.TryParse(Details[4], out UnitPrice))
            {
                ProductDetails.UnitPrice = UnitPrice;
            }
            ProductDetails.EntryDate = Details[5];
            ProductDetails.ExpiaryDate = Details[6];
            ProductDetails.BatchNo = BatchNo;

            return ProductDetails.UpdateProductsToDatabase();
        }

        // BLL Methode for Searching Items By User Requirment
        public DataTable SearchingItem(string[] Details)
        {
            ProductDetails.BrandName = Details[0];
            ProductDetails.SubBrandName = Details[1];
            ProductDetails.Weight = Details[2];
            if (Details[3] == "")
            {
                ProductDetails.LowestUntiPrice = 0;
            }
            else
            {
                ProductDetails.LowestUntiPrice = Convert.ToDouble(Details[3]);
            }

            if (Details[4] == "")
            {
                ProductDetails.HighestUnitPrice = 0;
            }
            else
            {
                ProductDetails.HighestUnitPrice = Convert.ToDouble(Details[4]);
            }

            DataTable dt = ProductDetails.SearchingItemFromDataBase();

            return dt;
        }


// ------------------------------------------------   ShopRent -------------------------------------------------//
        

        // ShopRent Insert BLL
       public bool InsertIntoShopRentExpensesToShopRentTableBll(string month,double amount,double paidAmount,string paymentDate,string paymentStatus,double dueAmount,string PaymentTo)
        {
            otherexpenses.ShopRentPaymetMonth = month;
            otherexpenses.ShopRentExpense = amount;
            otherexpenses.PaidAmount = paidAmount;
            otherexpenses.PaymentDate = paymentDate;
            otherexpenses.ShopRentPaymentStatus = paymentStatus;
            otherexpenses.DueAmount = dueAmount;
            otherexpenses.PaymentTo = PaymentTo;

            return otherexpenses.InsertIntoShopRentExpensesToShopRentTable();
        }

       //    GetDataOfShopRentExpensesFromShopRentTableBLL
        public DataTable  GetDataOfShopRentExpensesFromShopRentTableBLL()
        {
            return otherexpenses.GetDataOfShopRentExpensesFromShopRentTable();
        }

        //Update Shoprent Due Amount
        public bool UpdateShopRentDueAmountBll(double due, double paid, string paymentDate, string id)
        {
            if (due < 0)
            {
                return false;
            }
            else if (due > 0)
                otherexpenses.ShopRentPaymentStatus = "Due";
            else
                otherexpenses.ShopRentPaymentStatus = "Paid";

            otherexpenses.DueAmount = due;
            otherexpenses.PaidAmount = paid;
            otherexpenses.PaymentDate = paymentDate;
            otherexpenses.Id = id;

            return otherexpenses.UpdateShopRentDueAmount();
        }


        //Check ShopRent Amount
        public bool CheckShopRentAmountBll(string amount)
        {
            valid.Amount = amount;
            if (valid.isValidAmount())
            {
                return true;
            }
            else
                return false;

        }


        //Check ShopRent Paid Amount
        public bool CheckShopRentPaidAmountBll(string paidAmount)
        {
            if (valid.isValidPaymentAmount(paidAmount))
            {
                return true;
            }
            else
                return false;
        }

        //-----------------------SearchShopRentDetails--------------------------------

        public DataTable SearchShoprentDetailsBll(string from, string to)
        {
            otherexpenses.FromDate = from;
            otherexpenses.ToDate = to;
            return otherexpenses.SearchShoprentDetails();
        }
// ---------------------------------------------------------------   Transport ------------------------------------------////


        // Transport Insert BLL
     public bool InsertIntoTransportTransactionToTransportTableBll(string transportDate,double transportExpense,double paidAmmount,string paymentDate,string paymentStatus,double dueAmount,string paymentTo)
        {
            otherexpenses.TransportDate = transportDate;
            otherexpenses.TransportExpense = transportExpense;
            otherexpenses.PaidAmount = paidAmmount;
            otherexpenses.PaymentDate = paymentDate;
            otherexpenses.TransportPaymentstatus = paymentStatus;
            otherexpenses.DueAmount = dueAmount;
            otherexpenses.PaymentTo = paymentTo;

            return otherexpenses.InsertIntoTransportTransactionToTransportTable();
        }

     //    GetDataOfTransportFromTransportTableBLL
        public DataTable GetDataOfTransportTransactionFromTransportTableBll()
        {
            return otherexpenses.GetDataOfTransportTransactionFromTransportTable();
        }

        //Update Transport Due Amount
        public bool UpdateTransportDueAmountBll(double due, double paid, string paymentDate, string id)
        {
            if (due < 0)
            {
                return false;
            }
            else if (due > 0)
                otherexpenses.TransportPaymentstatus = "Due";
            else
                otherexpenses.TransportPaymentstatus = "Paid";

            otherexpenses.DueAmount = due;
            otherexpenses.PaidAmount = paid;
            otherexpenses.PaymentDate = paymentDate;
            otherexpenses.Id = id;

            return otherexpenses.UpdateTransportDueAmount();

        }
        // Search TransportDetailsBll
        public DataTable SearchTransportDatebyDateDetailsBll(string from, string to)
        {
            otherexpenses.FromDate = from;
            otherexpenses.ToDate = to;


            return otherexpenses.SearchTransportDatebyDate();
        }

//  ----------------------------------------------------------- Electric  ------------------------------------------//


        //   InsertIntoElectricExpensesToElectricTablebll
        public bool InsertIntoElectricExpensesToElectricTablebll(string PaymentMonth,double Amount, double PaidAmount, string PaymentDate,string PaymentStatus, double Due,string PaymentTo)
        {
            otherexpenses.ElectricBillPaidMonth = PaymentMonth;
            otherexpenses.ElectricExpense = Amount;
            otherexpenses.PaidAmount = PaidAmount;
            otherexpenses.PaymentDate = PaymentDate;
            otherexpenses.ElectricPaymentStatus = PaymentStatus;
            otherexpenses.DueAmount = Due;
            otherexpenses.PaymentTo = PaymentTo;

            return otherexpenses.InsertIntoElectricExpensesToElectricTable();
        }

        //    GetDataOfElectricExpenseFromExpenseTableBll
        public DataTable GetDataOfElectricExpenseFromElectricTableBll()
        {
            return otherexpenses.GetDataOfElectricExpenseFromElectricTable();
        }

        //    UpdateElectricDueAmountBll
        public bool UpdateDueAmountBll(double due, double paid, string id)
        {

            if (due < 0)
                return false;
            else if (due > 0)
                otherexpenses.ElectricPaymentStatus = "Due";
            else
                otherexpenses.ElectricPaymentStatus = "Paid";

            otherexpenses.DueAmount = due;
            otherexpenses.PaidAmount = paid;
            otherexpenses.Id = id;

            return otherexpenses.UpdateElectricDueAmount();
        }

        //--------------------------Search Transport Electric Bll----------------------------

        // Search ElectricDetailsBLL
        public DataTable SearchElectricDetailsBll(string from, string to)
        {
            otherexpenses.FromDate = from;
            otherexpenses.ToDate = to;


            return otherexpenses.SearchElectricDetails();
        }
       
  
//----------------------------------------------------------New Products BLL----------------------------------------------//


        // Insert New Brand 
        public bool InsertNewBrandBll(string Brand)
        {
            ProductDetails.BrandName = Brand;
            return ProductDetails.InsertNewBrand();
        }

        // Insert New SubBrand
        public bool InsertNewSubBrandBll(string Brand, string subBrand)
        {
            ProductDetails.BrandName = Brand;
            ProductDetails.SubBrandName = subBrand;
            return ProductDetails.InsertNewSubBrand();
        }
        public bool InsertNewWeightBll(string weight)
        {
            ProductDetails.Weight = weight;

            return ProductDetails.InsertWeight();
        }


        //------------------NewWeight Validation-----------------------

        public bool ValidWeightBll(string weight)
        {
            if (Validation.isValidWeight(weight))
            {
                return true;
            }
            else
                return false;
        }

   
//------------------------------------------------------- Others Purpose------------------------------------------------//
        
        // Check Other Valid Purpose Bll
        public bool ValidPurposeBll(string Purpose)
        {
            if(Validation.isValidPurpose(Purpose))
            {
                return true;
            }
            else
            return false;

        }




        //--------------------------Insert Other Expenses Details----------------------------

        public bool InsertOtherExpensesBll(string expenseDate,string expensename, double expenseAmount, double dueAmount, string paymentStatus, string paymentDate)
        {
            otherexpenses.ExpenseDate = expenseDate;
            otherexpenses.ExpenseName = expensename;
            otherexpenses.ExpenseAmount = expenseAmount;
            otherexpenses.DueAmount = dueAmount;
            otherexpenses.ShopRentPaymentStatus = paymentStatus;
            otherexpenses.PaymentDate = paymentDate;

            return otherexpenses.InsertOtherExpenses();

        }

        //---------------------------Get OtherExpenses Data-------------------------
        public DataTable GetDataOfOtherExpensesBll()
        {
            return otherexpenses.GetDataOfOtherExpenses();
        }

        //---------------------Update Other Expense Data-------------------

        public bool PayOtherExpensiveDueAmountBll(double dueAmount, string paymentDate, string id)
        {

            if (dueAmount < 0)
            {
                return false;
            }
            else if (dueAmount > 0)
                otherexpenses.ShopRentPaymentStatus = "Due";
            else
                otherexpenses.ShopRentPaymentStatus = "Paid";

            otherexpenses.Id = id;
            otherexpenses.DueAmount = dueAmount;
            otherexpenses.PaymentDate = paymentDate;

            return otherexpenses.PayOtherExpensiveDueAmount();
        }






        //----------------Get All Transaction----------------------
        public DataTable TransactionBll()
        {
            return transaction.GetAllTransaction();
        }
        //-------------Update Transaction Status----------------

        public bool UpdateTransactionStatusBll(string id, double dueAmount, string date)
        {
            if (dueAmount < 0)
            {
                return false;
            }
            else if (dueAmount > 0)
                transaction.PaymentStatus = "Due";
            else
                transaction.PaymentStatus = "Paid";

            transaction.TransactionId = id;
            transaction.DueAmount = dueAmount;
            transaction.PaymentDate = date;

            return transaction.UpdateTransactionStatus();

        }



        //--------------------------Search Date by Date OtherExpenses Bll----------------------------


        public DataTable SearchOtherExpenseDetailsBll(string from, string to)
        {
            otherexpenses.FromDate = from;
            otherexpenses.ToDate = to;


            return otherexpenses.SearchOtherExpenseDetails();
        }

//-----------------------------------------------------------Transaction------------------------------------------------//

        //--------------------------Search Transaction Bll----------------------------


        public DataTable SearchTransactionBll(string from, string to)
        {
            transaction.FromDate = from;
            transaction.ToDate = to;


            return transaction.SearchTransaction();
        }




    }



}
