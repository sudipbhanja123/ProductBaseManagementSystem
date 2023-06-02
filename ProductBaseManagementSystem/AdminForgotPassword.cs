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
    public partial class AdminForgotPassword : Form
    {
        BLL bll = new BLL();
        bool validPassword = false;
        public AdminForgotPassword()
        {
            InitializeComponent();
        }
   // --------------------------   Admin NickName   Hide  And  Show   ------------------------//

        // Button btnAdminNickName_Hide_Click

        private void btnAdminNickNameHide_Click(object sender, EventArgs e)
        {
            if (txtAdminNickName.PasswordChar == '\0')
            {
                btnAdminNickNameShow.BringToFront();
                txtAdminNickName.PasswordChar = '*';
            }
        }

        // Button btnAdminNickName_Show_Click
        private void btnAdminNickNameShow_Click(object sender, EventArgs e)
        {
            if (txtAdminNickName.PasswordChar == '*')
            {
                btnAdminNickNameHide.BringToFront();
                txtAdminNickName.PasswordChar = '\0';
            }
        }
        // txtAdminNickName Leave
        private void txtAdminNickName_Leave(object sender, EventArgs e)
        {
            bool NickName=bll.ValidNickName(txtAdminNickName.Text);
            if (txtAdminNickName.Text == "")
            {
                lbltxtAdminNickName.Text = "Enter Admin Nick Name";
            }
            else if (!NickName)
            {
                lbltxtAdminNickName.Text = "Enter Valid Nick Name";
            }
            else
            {
                lbltxtAdminNickName.Text = "";
            }
        }
   
//--------------------------btnAdminNickName_Click-----------------------//
        private void btnAdminNickName_Click(object sender, EventArgs e)
        {
            bool result = bll.CheckAdminNickNameBll(txtAdminNickName.Text);
            if (result)
            {
                string UserName = bll.FillAdminUserNameBll(txtAdminNickName.Text);
                pnlAdminCreatePassword.Visible = true;
                pnlAdminNickName.Visible = false;
                txtAdminUserName.Text = UserName;
                txtAdminUserName.Show();


            }
            else
            {
                lbltxtAdminNickName.Text = "You Enter Wrong Nick Name ! ";
            }
        }
//---------------------------------- New Password Hide And Show -----------------------------//

        //   btnAdminNewPassword_Hide_Click
        private void btnAdminNewPasswordHide_Click(object sender, EventArgs e)
        {
            if (txtAdminNewPassword.PasswordChar == '\0')
            {
                btnAdminNewPasswordShow.BringToFront();
                txtAdminNewPassword.PasswordChar = '*';
            }
        }


        //    btnAdminNewPassword_Show_Click
        private void btnAdminNewPasswordShow_Click(object sender, EventArgs e)
        {
            if (txtAdminNewPassword.PasswordChar == '*')
            {
                btnAdminNewPasswordHide.BringToFront();
                txtAdminNewPassword.PasswordChar = '\0';
            }
        }

 //------------------------------- Confirm Password Hide And Show -----------------------------//

        //   btnAdminConfirmPassword_Hide_Click
        private void btnAdminConfirmPasswordHide_Click(object sender, EventArgs e)
        {
            if (txtAdminConfirmPassword.PasswordChar == '\0')
            {
                btnAdminConfirmPasswordShow.BringToFront();
                txtAdminConfirmPassword.PasswordChar = '*';
            }
        }

        //    btnAdminConfirmPassword_Show_Click

        private void btnAdminConfirmPasswordShow_Click(object sender, EventArgs e)
        {
            if (txtAdminConfirmPassword.PasswordChar == '*')
            {
                btnAdminConfirmPasswordHide.BringToFront();
                txtAdminConfirmPassword.PasswordChar = '\0';

            }
        }


        //    btnAdminNewPassword_Click
        private void btnAdminNewPassword_Click(object sender, EventArgs e)
        {
           // CreateNewPassword();
            if (txtAdminNewPassword.Text != "" && txtAdminConfirmPassword.Text != "" && validPassword)
            {
                ChangeAdminPassword();

            }
            else
            {
                MessageBox.Show("Password Not Changed");
            }
        }
        
        // txtAdminNewPassword Leave
        private void txtAdminNewPassword_Leave(object sender, EventArgs e)
        {
            string NewPassword = bll.PasswordValidationBll(txtAdminNewPassword.Text);
            if (NewPassword != "")
            {
                lbltxtAdminNewPassword.Text = NewPassword;
            }

            else
            {
                lbltxtAdminNewPassword.Text = "";
                validPassword = true;
            }
        }
        //   txtAdminConfirmPassword_Leave
        private void txtAdminConfirmPassword_Leave(object sender, EventArgs e)
        {
           
            if (txtAdminConfirmPassword.Text == "")
            {
                lbltxtAdminConfirmPassword.Text = "Create Confirm Password";
            }
            else if (txtAdminConfirmPassword.Text == txtAdminNewPassword.Text)
            {
                lbltxtAdminConfirmPassword.Text = "";
            }
            else
            {
                lbltxtAdminConfirmPassword.Text = "Confirm Password Does Not Match !";
            }
        }

        private void AdminForgotPassword_Load(object sender, EventArgs e)
        {

        }
        // Change Admin Password
        private void ChangeAdminPassword()
        {
            string password = bll.GetAdminUserPasswordBll(txtAdminNickName.Text);
            if (txtAdminNewPassword.Text == password)
            {
                MessageBox.Show("Old Password And New Password Doesm't Same");
            }
            else if (txtAdminNewPassword.Text != txtAdminConfirmPassword.Text)
            {
                lbltxtAdminConfirmPassword.Text = "Confirm Password Does Not Match !";
            }
            else
            {
                lbltxtAdminNewPassword.Text = "";
                lbltxtAdminConfirmPassword.Text = "";
                bll.CreateNewAdminPasswordBll(txtAdminConfirmPassword.Text, txtAdminNickName.Text);
                MessageBox.Show("PassWord Changed !");
            }
        }

       

        

       
 
    }
}
