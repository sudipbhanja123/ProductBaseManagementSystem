using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using BusinessLogicalLayer;

namespace ProductBaseManagementSystem
{
    public partial class AdminLogin : Form
    {
      
       BLL bll = new BLL();
        public AdminLogin()
        {
            InitializeComponent();
        }

        //private void btnLogin_Click(object sender, EventArgs e)
        //{
           
        //}

        // TextBox UserName MouseLeave Event
        private void txtAdminUserName_MouseLeave(object sender, EventArgs e)
        {
            bool UserName = bll.ValidUserName(txtAdminUserName.Text);
            if (UserName)
            {
                lbltxtAdminUserName.Text = "";
            }
            else
            {
                lbltxtAdminUserName.Text = "Enter Your UserName";
            }
        }
        //TextBox Password MouseLeave Event
        private void txtAdminPassword_MouseLeave(object sender, EventArgs e)
        {
           
            //bool Password = bll.ValidPassword(txtAdminPassword.Text);
            //if (Password)
            //{
            //    lbltxtAdminPassword.Text = "";
            //}
            //else
            //{
            //    lbltxtAdminPassword.Text = "Enter Your Password";
            //}
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Hello" + txtAdminPassword.Text);
            bool result = bll.CheckAdminLoginBll(txtAdminUserName.Text, txtAdminPassword.Text);
            if (result)
            {

                Home home = new Home();
                home.Show();
                home.EnableOtherToolStripMenu("Admin");
                this.Hide();
            }
            else
                MessageBox.Show("You Enter Wrong UserName Or Password !");
           
        }
        // Button Show Click
        private void btnShow_Click(object sender, EventArgs e)
        {
            
            if (txtAdminUserName.PasswordChar == '*')
            {
                btnHide.BringToFront();
                txtAdminUserName.PasswordChar = '\0';
            }
        }
        // Button Hide Click
        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtAdminUserName.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtAdminUserName.PasswordChar = '*';
            }
        }
        //Button Password Hide
        private void btnPassWordHide_Click(object sender, EventArgs e)
        {
            if (txtAdminPassword.PasswordChar == '\0')
            {
                btnPassWordShow.BringToFront();
                txtAdminPassword.PasswordChar = '*';
            }
        }
        //Button Password Show
        private void btnPassWordShow_Click(object sender, EventArgs e)
        {
            if (txtAdminPassword.PasswordChar == '*')
            {
                btnPassWordHide.BringToFront();
                txtAdminPassword.PasswordChar = '\0';
            }
        }

        private void txtAdminUserName_Click(object sender, EventArgs e)
        {
            

        }

       

        
       
       

      

        

        

       

       
    }
}
