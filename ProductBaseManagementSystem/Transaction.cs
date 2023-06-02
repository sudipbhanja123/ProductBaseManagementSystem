using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicalLayer;

namespace ProductBaseManagementSystem
{
    public partial class Transaction_Status : Form
    {
        bool validPaymentAmount = false;
        int row, column;
        BLL bll = new BLL();
        public Transaction_Status()
        {
            InitializeComponent();
        }

        private void Transaction_Status_Load(object sender, EventArgs e)
        {
            FillGridView();
            pnlPaymentAmount.Hide();

        }
        private void FillGridView()
        {
            DataTable dt = bll.TransactionBll();
            dataGridViewGetAllTransaction.DataSource = dt;
            dataGridViewGetAllTransaction.Columns["TransectionId"].Visible = false;
            if (dataGridViewGetAllTransaction.Columns.Count == dt.Columns.Count)
            {
                var buttoncol = new DataGridViewButtonColumn();
                buttoncol.Name = "Paid";
                buttoncol.HeaderText = "Paid";
                buttoncol.Text = "Paid";
                buttoncol.UseColumnTextForButtonValue = true;
                dataGridViewGetAllTransaction.Columns.Add(buttoncol);


            }
        }
        private void PayDueAmount()
        {
            var local = DateTime.Now.ToString();
            double DueAmount = Convert.ToDouble(dataGridViewGetAllTransaction.Rows[row].Cells["DueAmount"].Value);
            double Payment = 0;
            bool res = Double.TryParse(txtPaymentAmount.Text, out Payment);
            double UpdateDueAmount = DueAmount - Payment;

            string id = dataGridViewGetAllTransaction.Rows[row].Cells["TransectionId"].Value.ToString();
            int Column = dataGridViewGetAllTransaction.Columns.Count;
            if (column == 0)
            {
                if (bll.UpdateTransactionStatusBll(id, UpdateDueAmount, local))
                {
                    MessageBox.Show("Paid");
                    FillGridView();
                }
                else
                {
                    MessageBox.Show("Not Paid");
                }
            }

        }


     

        private void txtPaymentAmount_Leave(object sender, EventArgs e)
        {
            bool result = bll.CheckShopRentAmountBll(txtPaymentAmount.Text);
            if (txtPaymentAmount.Text == "")
            {
                lbltxtpaymentAmount.Text = "Please Enter Your Amount";
            }
            else if (!result)
            {
                lbltxtpaymentAmount.Text = "Please Enter Valid Amount";
            }
            else
            {
                lbltxtpaymentAmount.Text = "";
                validPaymentAmount = true;

            }
        }

        // Search day y day All transaction
        private void btnSearchTransactionDate_Click(object sender, EventArgs e)
        {
            SearchTranssaction();
        }

        private void SearchTranssaction()
        {
            DataTable dt = bll.SearchTransactionBll(dateTimePickerFrom.Value.ToString("yyyy-MM-dd"), dateTimePickerTo.Value.ToString("yyyy-MM-dd"));
            dataGridViewGetAllTransaction.DataSource = dt;
        }

       
        // Refresh all Transaction
        private void btnTransactionRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnPaymentAmount_Click(object sender, EventArgs e)
        {
            if (validPaymentAmount)
            {
                PayDueAmount();
                pnlPaymentAmount.Hide();
            }
            else
                MessageBox.Show("Please Check Your Details");
        }

        private void dataGridViewGetAllTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlPaymentAmount.Show();
            row = e.RowIndex;
            column = e.ColumnIndex;
        }

        private void Transaction_Status_Load_1(object sender, EventArgs e)
        {
            FillGridView();
        }

     }
}
