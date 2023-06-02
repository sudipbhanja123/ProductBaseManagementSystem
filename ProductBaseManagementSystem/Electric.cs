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
    public partial class Electric : Form
    {
        BLL bll = new BLL();

        bool ValidAmount = false;
        bool ValidPaidAmount = false;
        bool ValidPaymentTo = false;
        bool ValidMonth = false;

        public Electric()
        {
            InitializeComponent();
        }

        private void Electric_Load(object sender, EventArgs e)
        {
            pnlDueAmountPaid.Hide();
            ElectricFillGridView();
        }

        private void btnElectricPaid_Click(object sender, EventArgs e)
        {
            if (ValidAmount && ValidPaidAmount && ValidPaymentTo && ValidMonth)
            {
                InsertDataToBtnElectricPaid();
            }
            else
            {
                MessageBox.Show("Please Select Your All Data");
            }

        }
        public void InsertDataToBtnElectricPaid()
        {
            string status;
            var local = DateTime.Now;
            string paymentDate = local.ToString();

            if (txtElectricAmount.Text == txtElectricPaidAmount.Text)
            {
                status = "Paid";

            }
            else
            {
                status = "Due";
            }
            double dueAmount = (Convert.ToDouble(txtElectricAmount.Text) - Convert.ToDouble(txtElectricPaidAmount.Text));
            bool result = bll.InsertIntoElectricExpensesToElectricTablebll(dateTimePickerElectricMonth.Value.ToString("yyyy-MM-"),
                Convert.ToDouble(txtElectricAmount.Text), Convert.ToDouble(txtElectricPaidAmount.Text), paymentDate, status, dueAmount, txtElectricPaymentTo.Text);
            if (result)
            {
                MessageBox.Show("  Inserted Successfully !");
                ElectricFillGridView();
            }
            else
            {
                MessageBox.Show("Not Inserted !");
            }
        }

        private void ElectricFillGridView()
        {
            DataTable dt = bll.GetDataOfElectricExpenseFromElectricTableBll();
            dataGridViewElectric.DataSource = dt;
            dataGridViewElectric.Columns["ElecticId"].Visible = false;
            if (dataGridViewElectric.Columns.Count == dt.Columns.Count)
            {
                var buttoncol = new DataGridViewButtonColumn();
                buttoncol.Name = "Paid";
                buttoncol.HeaderText = "Paid";
                buttoncol.Text = "Paid";
                buttoncol.UseColumnTextForButtonValue = true;
                dataGridViewElectric.Columns.Add(buttoncol);


            }
        }



        //-------------    dataGridViewElectric_CellContentClick --------------  //
        int row, column;
        private void dataGridViewElectric_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlDueAmountPaid.Show();
            row = e.RowIndex;
            column = e.ColumnIndex;
            lblElectricPaymentToShow.Text = dataGridViewElectric.Rows[row].Cells["PaidTo"].Value.ToString();
            double DueAmount = Convert.ToDouble(dataGridViewElectric.Rows[row].Cells["DueAmount"].Value);
            lblElectricDueAmountShow.Text = DueAmount.ToString();

            //    // PayPaidAmount(e.RowIndex);
            //     double PaidAmount = Convert.ToDouble(dataGridViewElectric.Rows[e.RowIndex].Cells["DueAmount"].Value);
            //     double Payment = 0;
            //     bool res = Double.TryParse(txtPaidAmount.Text, out Payment);

            //     double UpdateAmount = PaidAmount - Payment;
            //     string id = dataGridViewElectric.Rows[e.RowIndex].Cells["ElecticId"].Value.ToString();
            //     int Column = dataGridViewElectric.Columns.Count;
            //     if (e.ColumnIndex == 0)
            //     {
            //         if (bll.UpdateDueAmountBll(UpdateAmount, id))
            //         {
            //             MessageBox.Show("Paid");
            //             ElectricFillGridView();
            //         }
            //         else
            //         {
            //             MessageBox.Show("Not Paid");
            //         }
            //}


        }

        private void btnDueAmountPaid_Click(object sender, EventArgs e)
        {
            PayDueAmount();
            pnlDueAmountPaid.Hide();
        }

        private void PayDueAmount()
        {
            double DueAmount = Convert.ToDouble(dataGridViewElectric.Rows[row].Cells["DueAmount"].Value);
            double Payment = 0;
            bool res = Double.TryParse(txtPaidAmount.Text, out Payment);
            double UpdateDueAmount = DueAmount - Payment;

            double PaidAmount = Convert.ToDouble(dataGridViewElectric.Rows[row].Cells["PaidAmount"].Value);
            double UpdatePaidAmount = PaidAmount + Payment;

            string id = dataGridViewElectric.Rows[row].Cells["ElecticId"].Value.ToString();
            int Column = dataGridViewElectric.Columns.Count;
            if (column == 0)
            {
                if (bll.UpdateDueAmountBll(UpdateDueAmount, UpdatePaidAmount, id))
                {
                    MessageBox.Show("Paid");
                    MessageBox.Show("Due Amount :" + UpdateDueAmount + "Paid Amount : " + UpdatePaidAmount);
                    ElectricFillGridView();
                   
                }
                else
                {
                    MessageBox.Show("Not Paid");
                }
            }

        }
        // -------------------------------Electric Amount----------------------/
        private void txtElectricAmount_Leave(object sender, EventArgs e)
        {
            bool result = bll.CheckShopRentAmountBll(txtElectricAmount.Text);
            if (txtElectricAmount.Text == "")
            {
                lbltxtElectricAmount.Text = "Enter Electric Amount";
            }
            else if (!(result))
            {
                lbltxtElectricAmount.Text = "Enter Valid Amount";
            }
            else
            {
                lbltxtElectricAmount.Text = "";
                ValidAmount = true;

            }
        }

        private void txtElectricPaidAmount_Leave(object sender, EventArgs e)
        {
            bool result = bll.CheckShopRentPaidAmountBll(txtElectricPaidAmount.Text);
            if (txtElectricPaidAmount.Text == "")
            {
                lbltxtElectricPaidAmount.Text = "Enter Paid Amount";
            }
            else if (!(result))
            {
                lbltxtElectricPaidAmount.Text = "Enter Valid Paid Amount";
            }
            else
            {
                lbltxtElectricPaidAmount.Text = "";
                ValidPaidAmount = true;
            }
        }

        private void txtElectricPaymentTo_Leave(object sender, EventArgs e)
        {
            bool result = bll.checkManagerNameBll(txtElectricPaymentTo.Text);
            if (txtElectricPaymentTo.Text == "")
            {

                lbltxtElectricPaymentTo.Text = "Enter Whom You To Pay";
            }
            else if (!(result))
            {
                lbltxtElectricPaymentTo.Text = "Enter Valid Name";
            }
            else
            {
                lbltxtElectricPaymentTo.Text = "";
                ValidPaymentTo = true;
            }
        }


        private void dateTimePickerElectricPaymentDate_Leave(object sender, EventArgs e)
        {
            if (dateTimePickerElectricMonth.Value == null)
            {
                lbltxtElectricPaymentMonth.Text = "Select Payment Month";
            }
            else
            {
                lbltxtElectricPaymentMonth.Text = "";
                ValidMonth = true;
            }
        }

        private void txtElectricPaymentTo_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.isValidName(txtElectricPaymentTo.Text))
            {
                lbltxtElectricPaymentTo.Text = "Please Enter Valid Name";
            }
            else
            {
                lbltxtElectricPaymentTo.Text = "";
            }
        }

        // Method SearchElectric 
        private void SearchElectric()
        {
            DataTable dt = bll.SearchElectricDetailsBll(dateTimePickerSearchFromDate.Value.ToString("yyyy-MM"), dateTimePickerSearchToDate.Value.ToString("yyyy-MM"));
            dataGridViewElectric.DataSource = dt;
        }
           // Button Search By Date
        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            SearchElectric();
        }

      

        
    }
}
    

