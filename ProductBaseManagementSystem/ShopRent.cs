using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicalLayer;
namespace ProductBaseManagementSystem
{
    public partial class ShopRent : Form
    {
       
        BLL bll=new BLL ();

        int row, column;
        bool validAmount = false;
        bool validPaidAmount = false;
        bool validPaidto = false;
        bool validMonth = false;
        
       

        public ShopRent()
        {
            InitializeComponent();
        }

        // Button Shop Rent
        private void btnShopRentAmountPaid_Click(object sender, EventArgs e)
        {
            if (validAmount && validPaidAmount && validPaidto && validMonth)
            {
                InsertIntoBtnShopRent();
            }
            else
            {
                MessageBox.Show("Please Select All Data ");
            }
        }

        // Methods For Insert Value In Shop Rent Button
        public void InsertIntoBtnShopRent()
        {
            string status;
            var local = DateTime.Now;
            string paymentDate = local.ToString();
            double DueAmount = Convert.ToDouble(txtShopRentAmount.Text) - Convert.ToDouble(txtShopRentPaidAmount.Text);
            if (txtShopRentAmount.Text == txtShopRentPaidAmount.Text)
            {
                status = "Paid";
                

            }
            else
            {
                status = "Due";
            }
            bool result = bll.InsertIntoShopRentExpensesToShopRentTableBll(dateTimePickerShopRentPaidMonth.Value.ToString("yyyy-MM"), Convert.ToDouble(txtShopRentAmount.Text), Convert.ToDouble(txtShopRentPaidAmount.Text), paymentDate, status, DueAmount, txtShopRentPaymentTo.Text);
            if (result)
            {
                MessageBox.Show("Inserted Successfully");
                FillGridView();
            }
            else
            {
                MessageBox.Show("Not Inserted");
            }
        }

        private void FillGridView()
        {
            DataTable dt = bll.GetDataOfShopRentExpensesFromShopRentTableBLL();
            dataGridViewShopRentDetails.DataSource = dt;
            dataGridViewShopRentDetails.Columns["ShopRentId"].Visible = false;
            if (dataGridViewShopRentDetails.Columns.Count == dt.Columns.Count)
            {
                var buttoncol = new DataGridViewButtonColumn();
                buttoncol.Name = "Pay";
                buttoncol.HeaderText = "Pay";
                buttoncol.Text = "Pay";
                buttoncol.UseColumnTextForButtonValue = true;
                dataGridViewShopRentDetails.Columns.Add(buttoncol);


            }
        }

        // ShopRent Form Load
        private void ShopRent_Load(object sender, EventArgs e)
        {
            pnlShopRentDueAmountPaid.Hide();

            FillGridView();
        }

        // Due Amount Paid Button
        private void btnDueAmountPaid_Click(object sender, EventArgs e)
        {
            if (bll.CheckShopRentAmountBll(txtPaidAmount.Text))
            {
                PayDueAmount();
                pnlShopRentDueAmountPaid.Hide();
            }
            else
            {
                lblDueAmount.Text = "Enter Valid Amount";
            }

        }

        // Due Amount Paid Methods
        private void PayDueAmount()
        {
            var local = DateTime.Now.ToString();
            double DueAmount = Convert.ToDouble(dataGridViewShopRentDetails.Rows[row].Cells["DueAmount"].Value);
            double Payment = 0;
            bool res = Double.TryParse(txtPaidAmount.Text, out Payment);
            double UpdateDueAmount = DueAmount - Payment;



            if (UpdateDueAmount < 0)
            {
                MessageBox.Show("No Dues There !!!");
                return;
            }

            double PaidAmount = Convert.ToDouble(dataGridViewShopRentDetails.Rows[row].Cells["PaidAmount"].Value);
            double UpdatePaidAmount = PaidAmount + Payment;

            string id = dataGridViewShopRentDetails.Rows[row].Cells["ShopRentId"].Value.ToString();
            int Column = dataGridViewShopRentDetails.Columns.Count;
            if (column == 0)
            {
                if (bll.UpdateShopRentDueAmountBll(UpdateDueAmount, UpdatePaidAmount, local, id))
                {
                    MessageBox.Show("Paid");
                   FillGridView();
                   MessageBox.Show("Due Amount=" + UpdateDueAmount + " Paid Amount=" + UpdatePaidAmount);
                 
                }
                else
                {
                    MessageBox.Show("Not Paid");
                 
                }
            }

        }

        // DataGrid View For Cell Content Click
        private void dataGridViewShopRentDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                pnlShopRentDueAmountPaid.Show();
                row = e.RowIndex;
                column = e.ColumnIndex;
                lblPaymentToShow.Text = dataGridViewShopRentDetails.Rows[row].Cells["PaidTo"].Value.ToString();
                double DueAmount = Convert.ToDouble(dataGridViewShopRentDetails.Rows[row].Cells["DueAmount"].Value);
                lblDueAmountShow.Text = DueAmount.ToString();
  
        }

       
        //-----------------------Shop Rent UI------------------------------//

        //---------------Shop Rent Amount----------------/
        private void txtShopRentAmount_Leave(object sender, EventArgs e)
        {
            bool result = bll.CheckShopRentAmountBll(txtShopRentAmount.Text);
            if (txtShopRentAmount.Text == "")
            {
                lbltxtShopRentAmount.Text = "Please Enter Amount";
            }
            else if (!result)
            {
                lbltxtShopRentAmount.Text = "Please Enter Valid Amount";
            }
            else
                lbltxtShopRentAmount.Text = "";
            validAmount = true;

        }

        //-------------------Shop Rent Paid Amount--------------------//
        private void txtShopRentPaidAmount_Leave(object sender, EventArgs e)
        {


            bool result = bll.CheckShopRentPaidAmountBll(txtShopRentPaidAmount.Text);
            if (txtShopRentPaidAmount.Text == "")
            {
                lbltxtShopRentPaidAmount.Text = "Please Enter PaidAmount";
            }
            else if (!(result))
            {
                lbltxtShopRentPaidAmount.Text = "Please Enter Valid PaidAmount";
            }
            else
                lbltxtShopRentPaidAmount.Text = "";
            validPaidAmount = true;
        }

        //-------------------Shop Rent Payment To--------------------//

        private void txtShopRentPaymentTo_Leave(object sender, EventArgs e)
        {
            bool result = bll.checkManagerNameBll(txtShopRentPaymentTo.Text);
            if (txtShopRentPaymentTo.Text == "")
            {
                lbltxtShopRentPaymentTo.Text = "Enter Name You Want To Pay";
            }
            else if (!result)
            {
                lbltxtShopRentPaymentTo.Text = "Please Enter Valid Name";
            }
            else
            {
                lbltxtShopRentPaymentTo.Text = "";
                validPaidto = true;
            }
        }

        //----------------------------ShopRent Paid Month-------------------------//
       
        private void dateTimePickerShopRentPaidMonth_Leave(object sender, EventArgs e)
        {
            if (dateTimePickerShopRentPaidMonth.Value.ToString() == null)
            {
                lbltxtShopRentPaidMonth.Text = "Please Select Month";
            }

            else
            {
                lbltxtShopRentPaidMonth.Text = "";
                validMonth = true;
            }
        }

        private void txtShopRentPaymentTo_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.isValidName(txtShopRentPaymentTo.Text))
            {
                lbltxtShopRentPaymentTo.Text = "Please Enter Valid Name";
            }
            else
            {
                lbltxtShopRentPaymentTo.Text = "";
            }
            // lbltxtShopRentPaymentTo.Show();
        }


       // method for search data
        private void SearchTransport()
        {
            DataTable dt = bll.SearchShoprentDetailsBll(dateTimePickerFrom.Value.ToString("yyyy-MM"), dateTimePickerTo.Value.ToString("yyyy-MM"));
            dataGridViewShopRentDetails.DataSource = dt;
        }

        // Button Search Date
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchTransport();
        }

       

    }
}
