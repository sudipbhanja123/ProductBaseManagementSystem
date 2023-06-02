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
    public partial class Others : Form
    {
        BLL bll = new BLL();
        int Row,Column;
        bool ValidAmount = false;
        bool ValidPaidAmount = false;
        bool ValidPaymentTo = false;
        bool ValidPaymentPurpose = false;

        public Others()
        {
            InitializeComponent();
        }

        //  Others Payment Purpose
        private void txtOthersPaymentPurpose_Leave(object sender, EventArgs e)
        {
            bool result = bll.ValidPurposeBll(txtOthersPaymentPurpose.Text);
            if (txtOthersPaymentPurpose.Text == "")
            {
                lbltxtOthersPaymentPurpose.Text = "Enter Payment Purpose";
            }
            else  if (!(result))
            {
                lbltxtOthersPaymentPurpose.Text = "Enter Valid Payment Purpose";
            }
            else
            {
                lbltxtOthersPaymentPurpose.Text = "";
                ValidPaymentPurpose = true;
            }
        }

        //  Others Aomunt
        private void txtOthersAmount_Leave(object sender, EventArgs e)
        {
            bool result = bll.CheckShopRentAmountBll(txtOthersAmount.Text);
            if (txtOthersAmount.Text == "")
            {
                lbltxtOthersAmount.Text = "Enter Amount";
            }
            else if (!(result))
            {
                lbltxtOthersAmount.Text = "Enter Valid Amount";
            }
            else
            {
                lbltxtOthersAmount.Text = "";
                ValidAmount = true;
            }
        }

        // Others Paid Amount
        private void txtOthersPaidAmount_Leave(object sender, EventArgs e)
        {
            bool result = bll.CheckShopRentPaidAmountBll(txtOthersPaidAmount.Text);
            if(txtOthersPaidAmount.Text=="")
            {
                lbltxtOthersPaidAmount.Text="Enter Paid Amount";
            }
            else if(!(result))
            {
                lbltxtOthersPaidAmount.Text="Enter Valid Paid Amount";
            
            }
            else
            {
                lbltxtOthersPaidAmount.Text="";
                     ValidPaidAmount=true;
            }
        }

        // Others Payment To
        private void txtOthersPaymentTo_Leave(object sender, EventArgs e)
        {
            bool result = bll.checkManagerNameBll(txtOthersPaymentTo.Text);
                if(txtOthersPaymentTo.Text=="")
                {
                    lbltxtOthersPaymentTo.Text="Enter Whom To Payment";
                }
                else if(!(result))
                {
                    lbltxtOthersPaymentTo.Text="Enter Valid Name";
                }
                else
                {
                    lbltxtOthersPaymentTo.Text="";
                    ValidPaymentTo=true;
                }
        }

        // Button Others Submit
        private void btnOthers_Click(object sender, EventArgs e)
        {
            if (ValidAmount & ValidPaidAmount & ValidPaymentTo & ValidPaymentPurpose)
            {
                InsertDetailsToOtherExpenses();
            }
            GetOtherExpensesData();
        }
        // Insert Others Details Methods

        private void InsertDetailsToOtherExpenses()
        {
            string status;
            string PaymentDate = DateTime.Now.ToString();
            double dueAmount = Convert.ToDouble(txtOthersAmount.Text) - Convert.ToDouble(txtOthersPaidAmount.Text);
            if (txtOthersAmount.Text == txtOthersPaidAmount.Text)
            {
                status = "Paid";
            }
            else
            {
                status = "Due";
            }
            bool result = bll.InsertOtherExpensesBll( dateTimePickerOthersDate.Value.ToString("yyyy-MM-dd"),txtOthersPaymentPurpose.Text, Convert.ToDouble(txtOthersAmount.Text),
                dueAmount, status, PaymentDate);
            if (result)
            {
                MessageBox.Show("Inserted Successfully");
            }
            else
            {
                MessageBox.Show("Not Inserted");
            }
        }
        private void GetOtherExpensesData()
        {
            DataTable dt = bll.GetDataOfOtherExpensesBll();
            dataGridViewOthers.DataSource = dt;
            dataGridViewOthers.Columns["ExpenseId"].Visible = false;
            if (dataGridViewOthers.Columns.Count == dt.Columns.Count)
            {
                var buttoncol = new DataGridViewButtonColumn();
                buttoncol.Name = "Pay";
                buttoncol.HeaderText = "Pay";
                buttoncol.Text = "Pay";
                buttoncol.UseColumnTextForButtonValue = true;
                dataGridViewOthers.Columns.Add(buttoncol);


            }
        }

        private void PayDueAmount()
        {
            var local = DateTime.Now.ToString("yyyy-MM-dd");
            double DueAmount = Convert.ToDouble(dataGridViewOthers.Rows[Row].Cells["Due_Amount"].Value);
            double Payment = 0;
            bool res = Double.TryParse(txtPaymentDueAmount.Text, out Payment);
            double UpdateDueAmount = DueAmount - Payment;


            string id = dataGridViewOthers.Rows[Row].Cells["ExpenseId"].Value.ToString();
            int Column = dataGridViewOthers.Columns.Count;
            if (Column == 8)
            {
                if (bll.PayOtherExpensiveDueAmountBll(UpdateDueAmount, local, id))
                {
                    MessageBox.Show("Paid");
                    MessageBox.Show("Due Amount : " + UpdateDueAmount);
                    GetOtherExpensesData();
                    
                }
                else
                {
                    MessageBox.Show("Not Paid");
                }
            }

        }

        private void Others_Load(object sender, EventArgs e)
        {
            GetOtherExpensesData();
            pnlPayDueAmount.Hide();
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            PayDueAmount();
            pnlPayDueAmount.Hide();
        }

        private void dataGridViewOthers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlPayDueAmount.Show();
            Row = e.RowIndex;
            Column = e.ColumnIndex;
            lblOtherPaymentToShow.Text = dataGridViewOthers.Rows[Row].Cells["Expense_Name"].Value.ToString();
            double DueAmount = Convert.ToDouble(dataGridViewOthers.Rows[Row].Cells["Due_Amount"].Value);
            lblOtherDueAmountShow.Text = DueAmount.ToString();
        }

        private void txtOthersPaymentPurpose_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOthersAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            SearchOtherExpenses();
        }

        private void SearchOtherExpenses()
        {
            DataTable dt = bll.SearchOtherExpenseDetailsBll(dateTimePickerFrom.Value.ToString("yyyy-MM-dd"), dateTimePickerTo.Value.ToString("yyyy-MM-dd"));
            dataGridViewOthers.DataSource = dt;
        }

      


      
    }
}
