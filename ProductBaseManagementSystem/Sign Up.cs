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
    public partial class Sign_Up : Form
    {
        BLL bll=new BLL ();
        bool validPassword = false;
       
        bool validName = false;
        bool validNickname = false;
        bool validConfirmPassword = false;
        bool validPhoneNumber = false;
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validName && validPhoneNumber && validPhoneNumber && validConfirmPassword)
            {
                AdminCreate();
            }
            else
            {
                MessageBox.Show("Please Check Your Data");
            }
        }
        public void AdminCreate()

           {
               bool result = bll.AdminSignUpBll(txtAdminName.Text,txtAdminPhoneNo.Text, txtAdminNickName.Text, txtAdminPassword.Text);
               if (result)
               {
                   MessageBox.Show("SignUp Succressful");
                   FillAdminGridView();
                  
               }
               else
               {
                   MessageBox.Show("SignUp UnSuccessful");
               }
        }

        public bool UpdateAdminDetails(int row, string id)
        {
            bool update = bll.UpdateAdminDetailsBll(dataGridViewShowDetails.Rows[row].Cells["Name"].Value.ToString(),
                dataGridViewShowDetails.Rows[row].Cells["PhoneNumber"].Value.ToString(),
                dataGridViewShowDetails.Rows[row].Cells["UserName"].Value.ToString(),
                
                dataGridViewShowDetails.Rows[row].Cells["UserPassWord"].Value.ToString(),
                dataGridViewShowDetails.Rows[row].Cells["NickName"].Value.ToString(),
                id);
            return update;
        }
       

        private void dataGridViewShowDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                UpdateAdminDetails(e.RowIndex, dataGridViewShowDetails.Rows[e.RowIndex].Cells["AdminId"].Value.ToString());
                MessageBox.Show("Successfully Update");
            }

            string removedata=dataGridViewShowDetails.Rows[e.RowIndex].Cells["AdminId"].Value.ToString();
            if (e.ColumnIndex == 0)
            {
                bll.DeleteAdminDetailsBll(removedata);
                MessageBox.Show("Delete Successfully");
                FillAdminGridView();
            }
        }

        private void FillAdminGridView()
        {
            DataTable dt = bll.GetSignUpInformationBll();
            dataGridViewShowDetails.DataSource = dt;
            dataGridViewShowDetails.Columns["AdminId"].Visible = false;

            if (dataGridViewShowDetails.Columns.Count == dt.Columns.Count)
            {
                var buttoncol = new DataGridViewButtonColumn();
                buttoncol.Name = "Delete";
                buttoncol.HeaderText = "Delete";
                buttoncol.Text = "Delete";
                buttoncol.UseColumnTextForButtonValue = true;
                dataGridViewShowDetails.Columns.Add(buttoncol);


                var buttoncolum = new DataGridViewButtonColumn();
                buttoncolum.Name = "Update";
                buttoncolum.HeaderText = "Update";
                buttoncolum.Text = "Update";
                buttoncolum.UseColumnTextForButtonValue = true;
                dataGridViewShowDetails.Columns.Add(buttoncolum);
            }



        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {
            FillAdminGridView();
        }

        // Admin Name txtBox
        private void txtAdminName_Leave(object sender, EventArgs e)
        {
            bool result = bll.checkManagerNameBll(txtAdminName.Text);
            if (txtAdminName.Text == "")
            {
                lbltxtAdminName.Text = "Enter Admin Name";
            }
            else if (!result)
            {
                lbltxtAdminName.Text = "Enter Valid Admin Name";
            }
            else
            {
                lbltxtAdminName.Text = "";
                validName = true;
            }
        }

        

        private void txtAdminNickName_Leave(object sender, EventArgs e)
        {
            bool result = bll.checkNickNameBll(txtAdminNickName.Text);
            if (txtAdminNickName.Text == "")
            {
                lbltxtAdminNickName.Text = "Enter Admin Nick Name";
            }
            else if (!result)
            {
                lbltxtAdminNickName.Text = "Enter Valid Admin Nick Name";
            }
            else
            {
                lbltxtAdminNickName.Text = "";
                validNickname = true;
            }
        }

        private void txtAdminPhoneNo_Leave(object sender, EventArgs e)
        {
            bool result = bll.checkManagerPhoneNumberBll(txtAdminPhoneNo.Text);
            if (txtAdminPhoneNo.Text == "")
            {
                lbltxtAdminPhoneNo.Text = "Enter Admin Phone No";
            }
            else if (!result)
            {
                lbltxtAdminPhoneNo.Text = "Enter Valid Phone No";
            }
            else
            {
                lbltxtAdminPhoneNo.Text = "";
                validPhoneNumber = true;
            }
        }

        private void txtAdminPassword_Leave(object sender, EventArgs e)
        {
            string password = bll.PasswordValidationBll(txtAdminPassword.Text);
            if (password != "")
            {
                lbltxtAdminPassword.Text = password;
            }
            else
            {
                lbltxtAdminPassword.Text = "";
                validPassword = true;
            }
        }

        private void txtAdminConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtAdminPassword.Text == "" && txtAdminConfirmPassword.Text == "")
            {
                lbltxtAdminConfirmPassword.Text = "Enter Admin Confirm Password";
            }
            else if (txtAdminPassword.Text != txtAdminConfirmPassword.Text)
            {
                lbltxtAdminConfirmPassword.Text = "Password And Confirm Password Does Not Match";
            }
            else
            {
                lbltxtAdminConfirmPassword.Text = "";
                validConfirmPassword = true;
            }
                
           
        }
    }
}
