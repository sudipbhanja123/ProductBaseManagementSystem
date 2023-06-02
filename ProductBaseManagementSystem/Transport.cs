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
    public partial class Transport : Form
    {
        BLL bll = new BLL();

        int row, column;

        bool ValidAmount = false;
        bool ValidPaidAmount = false;
        bool ValidPaymentTo = false;
       // bool ValidDate = false;
       

        public Transport()
        {
            InitializeComponent();
        }

        //------------------------Button Transport Paid------------------------//
        private void btnTransportImportPaid_Click(object sender, EventArgs e)
        {
            if (ValidAmount && ValidPaymentTo && ValidPaidAmount )
            {
                InsertTransportDetails();
            }
            else
            {
                MessageBox.Show("Please Select Your All Data");
            }
        }

        //-------------------- Method For Transport Paid Button----------------------//
        private bool InsertTransportDetails()
        {
            var local = DateTime.Now;
            string datetime = local.ToString();
            string months = local.Month.ToString();
            string status;
            double dueAmount = Convert.ToDouble(txtTransportImportAmount.Text) - Convert.ToDouble(txtTransportImportPaidAmount.Text);

            if (txtTransportImportAmount.Text == txtTransportImportPaidAmount.Text)
            {
                status = "Paid";
            }
            else
            {
                status = "Due";
            }
            bool result= bll.InsertIntoTransportTransactionToTransportTableBll(dateTimePickerTransportDate.Value.ToString("yyyy-MM-dd"), Convert.ToDouble( txtTransportImportAmount.Text), Convert.ToDouble( txtTransportImportPaidAmount.Text), datetime, status,dueAmount,txtPaymentTo.Text);
            if (result)
            {
                MessageBox.Show("Inserted");
                FillGridView();

            }
            else
            {
                MessageBox.Show("Not Inserted");
            }
            return result;
        }
        private void FillGridView()
        {
            DataTable dt = bll.GetDataOfTransportTransactionFromTransportTableBll();
            dataGridViewTransportImportPaidAmount.DataSource = dt;
            dataGridViewTransportImportPaidAmount.Columns["TransportId"].Visible = false;
            if (dataGridViewTransportImportPaidAmount.Columns.Count == dt.Columns.Count)
            {
                var buttoncol = new DataGridViewButtonColumn();
                buttoncol.Name = "Pay";
                buttoncol.HeaderText = "Pay";
                buttoncol.Text = "Pay";
                buttoncol.UseColumnTextForButtonValue = true;
                dataGridViewTransportImportPaidAmount.Columns.Add(buttoncol);


            }
        }

        private void Transport_Load(object sender, EventArgs e)
        {
            FillGridView();
            pnlTransportDueAmountPaid.Hide();
        }


        private void PayTransportDueAmount()
        {
            var local=DateTime.Now.ToString();
            
            double DueAmount = Convert.ToDouble(dataGridViewTransportImportPaidAmount.Rows[row].Cells["DueAmount"].Value);
            double Payment = 0;
            bool res = Double.TryParse(txtPaidAmount.Text, out Payment);
            double UpdateDueAmount = DueAmount - Payment;

            double PaidAmount = Convert.ToDouble(dataGridViewTransportImportPaidAmount.Rows[row].Cells["PaidAmount"].Value);
            double UpdatePaidAmount = PaidAmount + Payment;

            string id = dataGridViewTransportImportPaidAmount.Rows[row].Cells["TransportId"].Value.ToString();
            int Column = dataGridViewTransportImportPaidAmount.Columns.Count;
            if (column == 0)
            {
                if (bll.UpdateTransportDueAmountBll(UpdateDueAmount,UpdatePaidAmount,local,id))
                {
                    MessageBox.Show("Paid");
                    MessageBox.Show("Due Amount : " + UpdateDueAmount + "Paid Amount : " + UpdatePaidAmount);
                    FillGridView();
                    
                }
                else
                {
                    MessageBox.Show("Not Paid");
                }
            }

        }

        private void dataGridViewTransportImportPaidAmount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlTransportDueAmountPaid.Show();
            row = e.RowIndex;
            column = e.ColumnIndex;
            lblTransportPaymentToShow.Text = dataGridViewTransportImportPaidAmount.Rows[row].Cells["PaidTo"].Value.ToString();
            double DueAmount = Convert.ToDouble(dataGridViewTransportImportPaidAmount.Rows[row].Cells["DueAmount"].Value);
            lblTransportDueAmountShow.Text = DueAmount.ToString();
        }

        private void btnDueAmountPaid_Click(object sender, EventArgs e)
        {
            PayTransportDueAmount();
            pnlTransportDueAmountPaid.Hide();
        }

      // ---------------------------------------- Tranport Amount------------------------------//
        private void txtTransportImportAmount_Leave(object sender, EventArgs e)
        {

            bool result = bll.CheckShopRentAmountBll(txtTransportImportAmount.Text);
            if (txtTransportImportAmount.Text == "")
            {
                lbltxtImportAmount.Text = "Enter Transport Amount";
            }
            else if (!(result))
            {
                lbltxtImportAmount.Text = "Enter Valid Amount";
            }
            else
            {
                lbltxtImportAmount.Text = "";
                ValidAmount = true;
            }

        }

        // --------------------------------- Transport Paid Amount---------------------------//
        private void txtTransportImportPaidAmount_Leave(object sender, EventArgs e)
        {
            bool result = bll.CheckShopRentPaidAmountBll(txtTransportImportPaidAmount.Text);
            if (txtTransportImportPaidAmount.Text == "")
            {
                lbltxtImportPaidAmount.Text = "Enter Transport Paid Amount";
            }
            else if (!(result))
            {
                lbltxtImportPaidAmount.Text = "Enter Valid Paid Amount";
            }
            else
            {
                lbltxtImportPaidAmount.Text = "";
                ValidPaidAmount = true;
            }
        }

        // ----------------------------Tranport PaymentTo------------------------------//
        private void txtPaymentTo_Leave(object sender, EventArgs e)
        {
            bool result = bll.checkManagerNameBll(txtPaymentTo.Text);
            if (txtPaymentTo.Text == "")
            {
                lbltxtImportPaymentTo.Text = "Enter Whom You To Pay";
            }
            else if (!(result))
            {
                lbltxtImportPaymentTo.Text = "Enter Valid Name";
            }
            else
            {
                lbltxtImportPaymentTo.Text = "";
                ValidPaymentTo = true;
            }
        }

        private void dateTimePickerTransportDate_Leave(object sender, EventArgs e)
        {
          
        }

        private void txtPaymentTo_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.isValidName(txtPaymentTo.Text))
            {
                lbltxtImportPaymentTo.Text = "Please Enter Valid Name";
            }
            else
            {
                lbltxtImportPaymentTo.Text = "";
            }
        }

        private void dateTimePickerTransportDate_ValueChanged(object sender, EventArgs e)
        {

        }

        // Search Date by Date 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchTransport();
        }

        private void SearchTransport()
        {
            DataTable dt=bll.SearchTransportDatebyDateDetailsBll(dateTimePickerFrom.Value.ToString("yyyy-MM-dd"),dateTimePickerTo.Value.ToString("yyyy-MM-dd") );
             dataGridViewTransportImportPaidAmount.DataSource=dt;

        }
       
       

       

       

        

       

        
    }
}
