using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

using BusinessLogicalLayer;

namespace ProductBaseManagementSystem
{
    public partial class ProductDetails : Form
    {

        bool validBrand = false;
        bool validSubBrand = false;
        bool validWeight = false;
        bool validQuantity = false;
        bool validUnitPrice = false;
        bool validPaidAmount = false;
        bool validDealer = false;

        BLL bll = new BLL();
        public ProductDetails()
        {
            InitializeComponent();
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            StockDetails();
        }

        private void StockDetails()
        {

            ArrayList BrandName = bll.GetBrandNameBll();
            cmbProductBrandName.Items.Clear();
            cmbSearchBrand.Items.Clear();
            foreach (string s in BrandName)
            {

                cmbProductBrandName.Items.Add(s);
                cmbSearchBrand.Items.Add(s);
            }

            ArrayList Weight = bll.GetWeight();
            cmbProductWeight.Items.Clear();
            cmbSearchWeight.Items.Clear();
            foreach (string s in Weight)
            {
                cmbProductWeight.Items.Add(s);
                cmbSearchWeight.Items.Add(s);
            }
            DataTable dt = bll.FillGridViewFromDatabase();
            dataGridViewStocks.DataSource = dt;

            if (dataGridViewStocks.Columns.Count == dt.Columns.Count)
            {
                var buttoncol1 = new DataGridViewButtonColumn();
                buttoncol1.Name = "Update";
                buttoncol1.HeaderText = "Update";
                buttoncol1.Text = "Update";
                buttoncol1.UseColumnTextForButtonValue = true;
                dataGridViewStocks.Columns.Add(buttoncol1);

                var buttoncol2 = new DataGridViewButtonColumn();
                buttoncol2.Name = "Delete";
                buttoncol2.HeaderText = "Delete";
                buttoncol2.Text = "Delete";
                buttoncol2.UseColumnTextForButtonValue = true;
                dataGridViewStocks.Columns.Add(buttoncol2);
            }
        }
        //  cmbProductBrandName_SelectedIndexChanged
        
        private void cmbProductBrandName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string SelectedBrand = cmbProductBrandName.SelectedItem.ToString();
            ArrayList SubBrand = bll.GetSubBrandBySelectedBrandNameBll(SelectedBrand);
            cmbProductSubBrandName.Items.Clear();
            foreach (string s in SubBrand)
            {
                cmbProductSubBrandName.Items.Add(s);
                
            }
        }

        //   btnProductSave_Click
        private void btnProductSave_Click(object sender, EventArgs e)
        {
            string Message = "Do You Want To Procide";
            string Title = "Title";
            MessageBoxButtons Buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(Message, Title, Buttons);

            if (result == DialogResult.Yes)
            {



                string ExpiryDate = dateTimePickerProducts.Value.ToString();

                if (validBrand && validSubBrand && validWeight && validQuantity && validUnitPrice && validPaidAmount && validDealer)
                {
                    string[] Details = new string[] { cmbProductBrandName.SelectedItem.ToString(), //BrandName
                                                      cmbProductSubBrandName.SelectedItem.ToString(),  // SubBrand
                                                      cmbProductWeight.SelectedItem.ToString(), // Weight
                                                      txtProductQuantity.Text, // Quantity
                                                      txtProductUnitPrice.Text, //Unit Price
                                                      ExpiryDate.ToString(),   // Expiry Date
                                                      txtProductPaidAmount.Text,  //Paid Amount
                                                      txtProductDealerName.Text //Dealer Name
                                                    };
                    bool insert = false;
                    try
                    {
                        insert = bll.InsertProductsToDatabaseBll(Details);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (insert == true)
                    {
                        MessageBox.Show("Inserted Successful !");
                    }
                    else
                    {
                        MessageBox.Show("Inserted UnSuccessful !");
                    }

                }
                else
                    MessageBox.Show("Please Check Your Details");
            }
        }

        private void dataGridViewStocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string BatchNo = dataGridViewStocks.Rows[e.RowIndex].Cells["BatchNumber"].Value.ToString();
            int Coloum = dataGridViewStocks.Columns.Count;

            if (e.ColumnIndex == 0)
            {
                if (UpdateStockDetais(e.RowIndex, BatchNo))
                {
                    MessageBox.Show("Update Successfull");
                    bll.FillGridViewFromDatabase();
                }
                else
                {
                    MessageBox.Show("Update Unsuccessfull");
                }

            }

            if (e.ColumnIndex == 1)
            {
                if (bll.DeleteRowFromDataGridView(BatchNo))
                {
                    dataGridViewStocks.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Deleted Successfull");
                }
                else
                {
                    MessageBox.Show("Deleted Unsuccessfull");
                }
            }
        }

        private bool UpdateStockDetais(int rows, string batchNo)
        {
            string[] Details = {dataGridViewStocks.Rows[rows].Cells[3].Value.ToString(),     // BrandName
                                   dataGridViewStocks.Rows[rows].Cells[4].Value.ToString(),  // LotNo    
                                   dataGridViewStocks.Rows[rows].Cells[5].Value.ToString(),  // SubBrandName
                                   dataGridViewStocks.Rows[rows].Cells[7].Value.ToString(),  // SubBrandWeight
                                   dataGridViewStocks.Rows[rows].Cells[8].Value.ToString(),  // UnitPrice
                                   dataGridViewStocks.Rows[rows].Cells[9].Value.ToString(),  // Entry Date
                                   dataGridViewStocks.Rows[rows].Cells[10].Value.ToString() }; // Expiry Date

            bool Update = bll.UpdateProductsToDatabaseBLL(Details, batchNo);

            return Update;
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string BrandName;
            string SubBrandName;
            string Weight;
            string LowestUnitPrice;
            string HighestUnitPrice;

            if (cmbSearchBrand.SelectedItem != null)
            {
                BrandName = cmbSearchBrand.SelectedItem.ToString();
            }
            else
            {
                BrandName = "";
            }

            if (cmbSearchSubBrand.SelectedItem != null)
            {
                SubBrandName = cmbSearchSubBrand.SelectedItem.ToString();
            }
            else
            {
                SubBrandName = "";
            }

            if (cmbSearchWeight.SelectedItem != null)
            {
                Weight = cmbSearchWeight.SelectedItem.ToString();
            }
            else
            {
                Weight = "";
            }

            if (txtSearchByLowestUnitPrice.Text != "")
            {
                LowestUnitPrice = txtSearchByLowestUnitPrice.Text;
            }
            else
            {
                LowestUnitPrice = "";
            }

            if (txtSearchByHighestUnitPrice.Text != "")
            {
                HighestUnitPrice = txtSearchByHighestUnitPrice.Text;
            }
            else
            {
                HighestUnitPrice = "";
            }
            string[] Details = {BrandName,
                                SubBrandName,
                                Weight,
                                LowestUnitPrice,
                                HighestUnitPrice};

            DataTable dt = bll.SearchingItem(Details);
            if (dt.Rows.Count > 0)
            {
                dataGridViewStocks.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Not Available");
                StockDetails();
            }
        }

       

        private void btnProductsRefresh_Click(object sender, EventArgs e)
        {
            StockDetails();
        }

       

        private void cmbProductBrandName_Leave_1(object sender, EventArgs e)
        {
            if (cmbProductBrandName.SelectedIndex.ToString() == null)
            {
                lbltxtBrandName.Text = "Please Select Brand ";
            }
            else
            {
                lbltxtBrandName.Text = "";
                validBrand = true;
            }
        }
        
        private void cmbProductSubBrandName_Leave_1(object sender, EventArgs e)
        {
            if (cmbProductSubBrandName.Items.ToString() == null)
            {
                lbltxtSubBrandName.Text = "Please Select SubBrand ";
            }
            else
            {
                lbltxtSubBrandName.Text = "";
                validSubBrand = true;
            }
        }

        private void cmbProductWeight_Leave(object sender, EventArgs e)
        {
            if (cmbProductWeight.Items.ToString() == null)
            {
                lbltxtSubBrandWeight.Text = "Please Select Weight ";
            }
            else
            {
                lbltxtSubBrandWeight.Text = "";
                validWeight = true;

            }
        }

        private void txtProductQuantity_Leave(object sender, EventArgs e)
        {
            bool result = bll.CheckQuantityIsValid(txtProductQuantity.Text);
            if (txtProductQuantity.Text == "")
            {
                lbltxtSubBrandQuantity.Text = "Enter The Quantity";
            }
            else if (!result)
            {
                lbltxtSubBrandQuantity.Text = "Enter Valid Quantity";
            }
            else
            {
                lbltxtSubBrandQuantity.Text = "";
                validQuantity = true;
            }
        }

        private void txtProductUnitPrice_Leave(object sender, EventArgs e)
        {
            bool result = bll.CheckUnitPriceIsValid(txtProductUnitPrice.Text);
            if (txtProductUnitPrice.Text == "")
            {
                lbltxtSubBrandUnitPrice.Text = "Enter The Price";
            }
            else if (!result)
            {
                lbltxtSubBrandUnitPrice.Text = "Enter Valid Price";
            }
            else
            {
                lbltxtSubBrandUnitPrice.Text = "";
                validUnitPrice = true;
            }
        }

        private void txtProductDealerName_Leave(object sender, EventArgs e)
        {
            bool result = bll.checkManagerNameBll(txtProductDealerName.Text);
            if (txtProductDealerName.Text == "")
            {

                lbltxtProductDealerName.Text = "Enter Dealer Name";
            }
            else if (!result)
            {
                lbltxtProductDealerName.Text = "Enter Valid Dealer Name";
            }
            else
            {
                lbltxtProductDealerName.Text = "";
                validDealer = true;
            }
        }

        private void txtProductPaidAmount_Leave(object sender, EventArgs e)
        {
            bool result = bll.CheckQuantityIsValid(txtProductPaidAmount.Text);
            double amount = Convert.ToDouble(txtProductQuantity.Text) * Convert.ToDouble(txtProductUnitPrice.Text);
            double paidAmount = Convert.ToDouble(txtProductPaidAmount.Text);

            if (txtProductPaidAmount.Text == "")
            {

                lbltxtProductPaidAmount.Text = "Enter Paid Amount";
            }
            else if (amount < paidAmount)
            {
                lbltxtProductPaidAmount.Text = "Enter Valid Paid Amount";
            }
            else
            {
                lbltxtProductPaidAmount.Text = "";
                validPaidAmount = true;
            }
        }

        private void cmbSearchBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedBrand = cmbSearchBrand.SelectedItem.ToString();
            ArrayList SubBrand = bll.GetSubBrandBySelectedBrandNameBll(SelectedBrand);
            cmbSearchSubBrand.Items.Clear();
            foreach (string s in SubBrand)
            {
                cmbSearchSubBrand.Items.Add(s);
            }
        }

       

       

       

       
       

      

       

       

       

    }
}