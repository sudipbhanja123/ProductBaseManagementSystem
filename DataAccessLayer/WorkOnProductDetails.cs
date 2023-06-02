using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace DataAccessLayer
{
   public  class WorkOnProductDetails
    {
      string cs= ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
      SqlConnection connect = null;

 
        string _brandName;

        public string BrandName
        {
            get { return _brandName; }
            set { _brandName = value; }
        }
        string _subBrandName;

        public string SubBrandName
        {
            get { return _subBrandName; }
            set { _subBrandName = value; }
        }
        int _lotNumber;

        public int LotNumber
        {
            get { return _lotNumber; }
            set { _lotNumber = value; }
        }
        int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        string _weight;

        public string Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        double _unitPrice;

        public double UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }
        string _expiaryDate;

        public string ExpiaryDate
        {
            get { return _expiaryDate; }
            set { _expiaryDate = value; }
        }
        string _batchNo;

        public string BatchNo
        {
            get { return _batchNo; }
            set { _batchNo = value; }
        }
        string _entryDate;

        public string EntryDate
        {
            get { return _entryDate; }
            set { _entryDate = value; }
        }

        private double _lowestUntiPrice;

        public double LowestUntiPrice
        {
            get { return _lowestUntiPrice; }
            set { _lowestUntiPrice = value; }
        }

        private double _highestUnitPrice;

        public double HighestUnitPrice
        {
            get { return _highestUnitPrice; }
            set { _highestUnitPrice = value; }
        }

        string _dealerName;
        public string DealerName
        {
            get { return _dealerName; }
            set { _dealerName = value; }
        }

        double _paidAmount;

        public double PaidAmount
        {
            get { return _paidAmount; }
            set { _paidAmount = value; }
        }
//----------------------------------------------Stock  Details-------------------------------------------//



        //   GetBrand  Using ArrayList
        public ArrayList GetBrand()
        {
            ArrayList Brand = new ArrayList();
            try
            {
                connect = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("select * from tblBrand", connect);

                connect.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Brand.Add((rdr["BrandName"].ToString()));
                }
                connect.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
            }
            return Brand;
        }

        //   GetSubBrand Sp
        public ArrayList GetSubBrand(string BrandName)
        {
            ArrayList SubBrand = new ArrayList();
            try
            {
                connect = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spGetBrandId", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BrandName", BrandName);

                connect.Open();
                int id = (int)cmd.ExecuteScalar();
                connect.Close();

                if (id == 0)
                {
                    return SubBrand;
                }

                cmd = new SqlCommand("spGetSubBrand", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BrandId", Convert.ToInt32(id));
                connect.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    SubBrand.Add(rdr["SubBrandName"].ToString());
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
            return SubBrand;
        }

        //   GetWeight Sp
        public ArrayList GetWeight()
        {
            ArrayList Weight = new ArrayList();
            try
            {
                connect = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spGetWeight", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                connect.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Weight.Add((rdr["Weight"].ToString()));
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
            return Weight;
        }

       
        //     InsertProductsToDatabase
        public bool InsertProductsToDatabase()
        {
           try
            {
                int LotNo;
                connect = new SqlConnection(cs);
                SqlCommand cmd2 = new SqlCommand("spGetLastLotNoOfSelectedBrand", connect);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@SubBrandName", this.SubBrandName);
                cmd2.Parameters.AddWithValue("@Weight", this.Weight); 
                connect.Open();
                string Check = cmd2.ExecuteScalar().ToString();
                connect.Close();
                if (Check == "")
                {
                    LotNo = 1;
                }
                else
                {
                    LotNo = Convert.ToInt32(Check) + 1;
                }
                SqlCommand cmd = new SqlCommand("spGetSubBrandStock", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                string SubBrandForBatchNo = this.SubBrandName.Replace(" ", "");
                SubBrandForBatchNo += '_';
                BatchNo = SubBrandForBatchNo + LotNo + "_" ;
                double TotalAmount = this._unitPrice * this._quantity;
                double DueAmount = TotalAmount - this._paidAmount;
                string Status;
                if (DueAmount > 0)
                {
                    Status = "Due";
                }
                else if (DueAmount < 0)
                {
                    return false;
                }
                else
                {
                    Status = "Paid";
                }

                string EntryDate = DateTime.Now.ToString();
                cmd.Parameters.AddWithValue("@BrandName", this._brandName);
                cmd.Parameters.AddWithValue("@LotNumber", LotNo);
                cmd.Parameters.AddWithValue("@SubBrandName", this._subBrandName);
                cmd.Parameters.AddWithValue("@BatchNo", BatchNo);
                cmd.Parameters.AddWithValue("@SubBrandWeight", this._weight);
                cmd.Parameters.AddWithValue("@Unitprice", this._unitPrice);
                cmd.Parameters.AddWithValue("@EntryDate", EntryDate);
                cmd.Parameters.AddWithValue("@ExpiryDate", this._expiaryDate);
                cmd.Parameters.AddWithValue("@Quantity", this._quantity);
                cmd.Parameters.AddWithValue("@AmountStatus", Status);
                cmd.Parameters.AddWithValue("@DueAmount", DueAmount);
                cmd.Parameters.AddWithValue("@DealerName", this._dealerName);
          
                connect.Open();
                int i = cmd.ExecuteNonQuery();
                connect.Close();

                if (i <= 0)
                    return false;
                
            }
            
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
            return true;
        }

        //Methode to Get Stock List From DataBase
        public DataTable FillGridView()
        {
            DataTable dt = new DataTable();
            try
            {
                connect = new SqlConnection(cs);

                SqlDataAdapter sda = new SqlDataAdapter("select * from tblSubBrandStock order by BatchNumber;", connect);
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

       // Delete Product Details From Database
        public bool DeleteFromDataBase()
        {
            try
            {
                connect = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spdeleteSubBrandStock", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@BatchNo", this._batchNo);

                connect.Open();
                int i = cmd.ExecuteNonQuery();
                connect.Close();

                if (i > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }

       // Update Product to Database
        public bool UpdateProductsToDatabase()
        {

            try
            {
                connect = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spupdateSubBrandStock", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BrandName", this._brandName);
                cmd.Parameters.AddWithValue("@LotNumber", this._lotNumber);
                cmd.Parameters.AddWithValue("@SubBrandName", this._subBrandName);
                cmd.Parameters.AddWithValue("@BatchNo", this._batchNo);
                cmd.Parameters.AddWithValue("@SubBrandWeight", this._weight);
                cmd.Parameters.AddWithValue("@UnitPrice", this._unitPrice);
                cmd.Parameters.AddWithValue("@EntryDate", this._entryDate);
                //cmd.Parameters.AddWithValue("@EntryTotalPrice", dataGridView1.Rows[item].Cells[9].Value);

                cmd.Parameters.AddWithValue("@ExpiryDate", this._expiaryDate);


                connect.Open();
                int i = cmd.ExecuteNonQuery();
                connect.Close();

                if (i > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }

       // Searching Methode From Database by User Requirment
        public DataTable SearchingItemFromDataBase()
        {
            DataTable dt = new DataTable();
            try
            {
                connect = new SqlConnection(cs);
                SqlCommand cmd = null;

                if (this._brandName != "")
                {
                    if (this._subBrandName != "")
                    {
                        if (this._weight != "")
                        {
                            cmd = new SqlCommand("spSearchBySubBrandAndWeight", connect);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@SubBrandName", this._subBrandName);
                            cmd.Parameters.AddWithValue("@Weight", this._weight);
                        }
                        else if (this._highestUnitPrice != 0)
                        {
                            cmd = new SqlCommand("spSearchBySubBrandAndPrice", connect);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@SubBrandName", this._subBrandName);
                            cmd.Parameters.AddWithValue("@LowestUnitPrice", this._lowestUntiPrice);
                            cmd.Parameters.AddWithValue("@HighestUnitPrice", this._highestUnitPrice);
                        }
                        else
                        {
                            cmd = new SqlCommand("spSearchBySubBrand", connect);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@SubBrandName", this._subBrandName);
                        }
                    }
                    else
                    {

                        if (this._weight != "")
                        {
                            cmd = new SqlCommand("spSearchByBrandAndWeight", connect);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@BrandName", this._brandName);
                            cmd.Parameters.AddWithValue("@Weight", this._weight);
                        }
                        else if (this._highestUnitPrice != 0)
                        {

                            cmd = new SqlCommand("spSearchByBrandAndPrice", connect);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@BrandName", this._brandName);
                            cmd.Parameters.AddWithValue("@LowestUnitPrice", this._lowestUntiPrice);
                            cmd.Parameters.AddWithValue("@HighestUnitPrice", this._highestUnitPrice);
                        }
                        else
                        {
                            cmd = new SqlCommand("spSearchByBrand", connect);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@BrandName", this._brandName);
                        }
                    }
                }
                else
                {
                    if (this._weight != "")
                    {
                        cmd = new SqlCommand("spSearchByWeight", connect);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Weight", this._weight);
                    }
                    else if (this._highestUnitPrice != 0)
                    {
                        double LowestPrice = Convert.ToDouble(this._lowestUntiPrice);
                        double HighestPrice = Convert.ToDouble(this._highestUnitPrice);

                        cmd = new SqlCommand("spSearchByPrice", connect);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@LowestUnitPrice", LowestPrice);
                        cmd.Parameters.AddWithValue("@HighestUnitPrice", HighestPrice);
                    }
                }

                connect.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);

                //BindingSource src = new BindingSource();
                //src.DataSource = rdr;
                //dataGridView1.DataSource = src;


                connect.Close();
            }
            catch (Exception ex)
            {
                return dt;
            }
                
            finally
            {
            }
            return dt;
        }


//------------------------------------------------------New Products----------------------------------------------//

       // Insert New Brand
        public bool InsertNewBrand()
        {
            connect = new SqlConnection(cs);
            try
            {
                SqlCommand cmd2 = new SqlCommand("spGetAvailibityOfBrand", connect);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@BrandName", this._brandName);

                connect.Open();
                  SqlDataReader rdr= cmd2.ExecuteReader();
                rdr.Read();
                int DataFound = Convert.ToInt32(rdr["DataFound"]);
                connect.Close();

                

                if (DataFound==0)
                {
                                    
                    SqlCommand cmd = new SqlCommand("spInsertNewBrand", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BrandName", BrandName);
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
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                connect.Close();
            }
        }

       // Insert New SubBrand 
        public bool InsertNewSubBrand()
        {
            connect = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("spGetBrandId", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BrandName", BrandName);

            connect.Open();
            int id = (int)cmd.ExecuteScalar();
            connect.Close();

            cmd = new SqlCommand("spInsertSubBrand", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@SubBrand", SubBrandName);
            connect.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                return true;
            }
            else
                return false;
        }
        // Insert New SubBrand Weight
        public bool InsertWeight()
        {
            connect = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("spInsertWeight", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Weight", Weight);
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

// ----------------------------Search Products--------------------------

        public ArrayList GetSearchBrand()
        {
            //string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            //  SqlConnection con = new SqlConnection(CS);
            // SqlDataAdapter da = new SqlDataAdapter("spSearchBrand", con);
            // da.SelectCommand.CommandType = CommandType.StoredProcedure;
            // da.SelectCommand.Parameters.AddWithValue("@Brand",BrandName);
            // DataSet ds = new DataSet();
             // da.Fill(ds);
             // return ds;

            ArrayList Brand = new ArrayList();
            try
            {
                connect = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("select * from tblBrand", connect);

                connect.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Brand.Add((rdr["BrandName"].ToString()));
                }
                connect.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
            }
            return Brand;
        }

        public DataSet GetSearchWeight()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlDataAdapter da = new SqlDataAdapter("spSearchByWeight", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Weight",Weight);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

    
    }
}
