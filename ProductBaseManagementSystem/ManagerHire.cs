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
    public partial class ManagerHire : Form
    {
        BLL bll = new BLL();


        bool validName = false;
        bool validPhoneNumber = false;
        bool validUserName = false;
        bool validAddharNumber = false;
        bool validSalary = false;
        bool validNickname = false;

        //
        public ManagerHire()
        {
            InitializeComponent();
        }

        //Manager Hire button
        private void btnManagerHire_Click(object sender, EventArgs e)
        {
            if (validName && validPhoneNumber && validNickname && validSalary && validUserName && validAddharNumber)
            {
                HireManager();
            }
            else
            {
                MessageBox.Show("Please Select Your All Data ");
            }
          
        }
        public void HireManager()
        {
            
            string date = DateTime.Now.ToString();

            bool result = bll.HireManagerBll(txtManagerName.Text, txtManagerUserName.Text, txtManagerAadharNo.Text, txtManagerPhoneNo.Text.ToString(), txtManagerNickName.Text, date, Convert.ToInt32(txtManagerSalary.Text));

            if (result)
            {
               
                MessageBox.Show("Hired");
                FillGridView();
                string UserName = bll.GetManagerUserNameBll(txtManagerNickName.Text);
                string UserPassword = bll.GetManagerUserConfirmPasswordBll(txtManagerNickName.Text);
                MessageBox.Show("UserName="+UserName+ " Password="+UserPassword);
            }
            else
                MessageBox.Show("Not Hired");
        }
      

        private void dataGridViewManagerHire_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string RemoveData = dataGridViewManagerHire.Rows[e.RowIndex].Cells["ManagerId"].Value.ToString();
           // int column = dataGridViewManagerHire.Columns.Count;
            if (e.ColumnIndex == 0)
            {

                bll.FireManagerBll(RemoveData);
                dataGridViewManagerHire.Rows.RemoveAt(e.RowIndex);

               

            }
            if (e.ColumnIndex == 1)
            {
                updateManager(e.RowIndex, dataGridViewManagerHire.Rows[e.RowIndex].Cells["ManagerId"].Value.ToString());
                MessageBox.Show("Successfully Update");
            }

        }

        //  FillGridView Manager Details

        private void FillGridView()
        {
            DataTable dt = bll.ManagerFillGridviewBLL();
            dataGridViewManagerHire.DataSource = dt;
            dataGridViewManagerHire.Columns["ManagerId"].Visible = false;
            if (dataGridViewManagerHire.Columns.Count == dt.Columns.Count)
            {
                var buttoncol = new DataGridViewButtonColumn();
                buttoncol.Name = "fire";
                buttoncol.HeaderText = "Fire";
                buttoncol.Text = "Fire";
                buttoncol.UseColumnTextForButtonValue = true;
                dataGridViewManagerHire.Columns.Add(buttoncol);


                var buttoncolum = new DataGridViewButtonColumn();
                buttoncolum.Name = "update";
                buttoncolum.HeaderText = "Update";
                buttoncolum.Text = "Update";
                buttoncolum.UseColumnTextForButtonValue = true;
                dataGridViewManagerHire.Columns.Add(buttoncolum);
            }



        }

        //  ManagerHire_Load   form load
        private void ManagerHire_Load(object sender, EventArgs e)
        {
            FillGridView();
        }

        //   updateManager   
        public bool updateManager(int row,string managerId)
        {
            bool update = bll.UpdateManagerInfomationToDatabaseBll(
                dataGridViewManagerHire.Rows[row].Cells["ManagerName"].Value.ToString(),
                dataGridViewManagerHire.Rows[row].Cells["PhoneNumber"].Value.ToString(),
                dataGridViewManagerHire.Rows[row].Cells["AddharNo"].Value.ToString(),
                dataGridViewManagerHire.Rows[row].Cells["HireDate"].Value.ToString(),
                dataGridViewManagerHire.Rows[row].Cells["FireDate"].Value.ToString(),
                Convert.ToInt32(dataGridViewManagerHire.Rows[row].Cells["Salary"].Value),
                managerId);
            return update;


        }
        // TextBox ManagerName
        private void txtManagerName_Leave(object sender, EventArgs e)
        {
            bool result = bll.checkManagerNameBll(txtManagerName.Text);
            if (txtManagerName.Text == "")
            {
                lbltxtManagerName.Text = "Enter ManagerName";
            }
            else if (!result)
            {
                lbltxtManagerName.Text = "Enter Correct ManagerName";

            }
            else
            {
                lbltxtManagerName.Text = "";
                validName = true;
            }
        }
        // TextBox ManagerNickName
        private void txtManagerNickName_Leave(object sender, EventArgs e)
        {
            bool result = bll.checkNickNameBll(txtManagerNickName.Text);
            if (txtManagerNickName.Text == "")
            {
                lbltxtManagerNickName.Text = "Enter Manager NickName";
            }
           else if (!result)
            {

                lbltxtManagerNickName.Text = "Enter Correct Manager NickName";
            }
            else
            {
                lbltxtManagerNickName.Text = "";
                validNickname = true;
            }
        }
        // TextBox ManagerPhone Number
        private void txtManagerPhoneNo_Leave(object sender, EventArgs e)
        {
            bool result = bll.checkManagerPhoneNumberBll(txtManagerPhoneNo.Text);

            if (txtManagerPhoneNo.Text == "")
            {
                lbltxtManagerPhoneNo.Text = "Enter Manager Phone No";

            }

            else if (!result)
            {
                lbltxtManagerPhoneNo.Text = "Enter Valid Phone No";

            }
            else
            {
                lbltxtManagerPhoneNo.Text = "";
                validPhoneNumber = true;
            }
        }
        //  TextBox Manager Aadhar Number
        private void txtManagerAadharNo_Leave(object sender, EventArgs e)
        {

            bool result = bll.checkManagerAddharNumberBll(txtManagerAadharNo.Text);
            if (txtManagerAadharNo.Text == "")
            {
                lbltxtManagerAadharNo.Text = "Enter Manager Aadhar No";
            }
            else if (!result)
            {
                lbltxtManagerAadharNo.Text = "Enter Valid Manager Aadhar No";
            }
            else
            {
                lbltxtManagerAadharNo.Text = "";
                validAddharNumber = true;

            }
        }
        //  TextBox Manager UserName
        private void txtManagerUserName_Leave(object sender, EventArgs e)
        {
            bool result = bll.checkManagerUserNameBll(txtManagerUserName.Text);
            if (txtManagerUserName.Text == "")
            {
                lbltxtManagerUserName.Text = " Enter Manager UserName ";

            }
            else if (!result)
            {
                lbltxtManagerUserName.Text = " Enter Valid Manager UserName ";
            }
            else
            {
                lbltxtManagerUserName.Text = "";
                validUserName = true;
            }
        }
        //  TextBox Manager Salary
        private void txtManagerSalary_Leave(object sender, EventArgs e)
        {
            long Salary = 0;
            bool r = long.TryParse(txtManagerSalary.Text, out Salary);
            bool result = bll.checkManagerSalaryBll(Salary);


            if (txtManagerSalary.Text == "")
            {
                lbltxtManagerSalary.Text = "Plese Enter The Salary";
            }
            else if (result)
            {
                lbltxtManagerSalary.Text = "";
                validSalary = true;
            }
            else
            {
                lbltxtManagerSalary.Text = "Salary coud not Negative";
            }

        }

       //

      
    }
}
