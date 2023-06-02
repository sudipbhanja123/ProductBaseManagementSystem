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
    public partial class ManagerForgotPassword : Form
    {
        BLL bll = new BLL();

        bool validPassword = false;
        public ManagerForgotPassword()
        {
            InitializeComponent();
        }
        //Manager ForgotPassword Load
        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            pnlNickNameCheck.Visible = true;
           //pnlSetUserNameAndPassword.Visible = false;
           pnlSetUserNameAndPassword.Enabled = true;
        }


        // ------------- Manager Nick Name Check button------------//

        private void btnNickNameCheck_Click(object sender, EventArgs e)
        {
            
            bool result = bll.CheckManagerNickNameBll(txtMangerNickName.Text);
         
          if (result)
          {
              string UserName = bll.FillManagerUserNameBll(txtMangerNickName.Text);
              pnlSetUserNameAndPassword.Visible = true;
              pnlNickNameCheck.Visible = false;
                  txtManagerUserName.Text = UserName;
                  txtManagerUserName.Show();

          }
          else
          {
              lbltxtManagerNickName.Text = "You Enter Wrong Nick Name !";
          }
            
        }


        //---------------------Fill user Name-----------------//

        private string fillUserName()
        {
            string result= bll.FillManagerUserNameBll(txtMangerNickName.Text);
            return result;
        }
    


        // ------------------Manager Nick Name Label Check---------------------///


        private void txtMangerNickName_Leave(object sender, EventArgs e)
        {
            bool NickName = bll.ValidNickName(txtMangerNickName.Text);
            if (txtMangerNickName.Text == "")
            {
                lbltxtManagerNickName.Text = "Please Select Manager NickName";
            }
            else if (! NickName)
            {
                lbltxtManagerNickName.Text = "Enter Your Correct Nick Name";
                
            }
            else
            {
                lbltxtManagerNickName.Text = ""; 
            }
        }



        // ---------------Manager New Password Label check-------------------///

       
        private void txtManagerNewPassword_Leave(object sender, EventArgs e)
        {

            string NewPassword = bll.PasswordValidationBll(txtManagerNewPassword.Text);
            if (NewPassword != "")
            {
                lbltxtManagerNewPassword.Text = NewPassword;
            }
            else
            {
                lbltxtManagerNewPassword.Text = "";
                validPassword = true;
            }
        }

        //-----------------------txtManagerConfirmPassword_MouseLeave-----------------//


        private void txtManagerConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtManagerConfirmPassword.Text == "")
            {
                lbltxtManagerConfirmPassword.Text = " Select Confirm Password ";
            }
           else  if (txtManagerNewPassword.Text == txtManagerConfirmPassword.Text)
            {
                lbltxtManagerConfirmPassword.Text = "";
            }
           
            else
            {
                lbltxtManagerConfirmPassword.Text = "Confirm Password Does Not Match !";
            }
        }

         //  btnManagerForgotPasswordNewPasswordHide
        private void btnManagerForgotPasswordNewPasswordHide_Click(object sender, EventArgs e)
        {
            if (txtManagerNewPassword.PasswordChar == '\0')
            {
                btnManagerForgotPasswordNewPasswordShow.BringToFront();
                txtManagerNewPassword.PasswordChar = '*';

            }
        }
        //   btnManagerForgotPasswordNewPasswordShow
        private void btnManagerForgotPasswordNewPasswordShow_Click(object sender, EventArgs e)
        {
            if (txtManagerNewPassword.PasswordChar == '*')
            {
                btnManagerForgotPasswordNewPasswordHide.BringToFront();
                txtManagerNewPassword.PasswordChar = '\0';
            }
        }
        //    btnManagerConfirmPasswordHide_Click
        private void btnManagerConfirmPasswordHide_Click(object sender, EventArgs e)
        {
            if (txtManagerConfirmPassword.PasswordChar == '\0')
            {
                btnManagerConfirmPasswordShow.BringToFront();
                txtManagerConfirmPassword.PasswordChar = '*';
            }
        }

        //   btnManagerConfirmPasswordShow_Click
        private void btnManagerConfirmPasswordShow_Click(object sender, EventArgs e)
        {
            if (txtManagerConfirmPassword.PasswordChar == '*')
            {
                btnManagerConfirmPasswordHide.BringToFront();
                txtManagerConfirmPassword.PasswordChar = '\0';
            }
        }
        //   btnManagerForgotPasswordNickNameShow_Click
        private void btnManagerForgotPasswordNickNameShow_Click(object sender, EventArgs e)
        {
            if (txtMangerNickName.PasswordChar == '*')
            {
                btnManagerForgotPasswordNickNameHide.BringToFront();
                txtMangerNickName.PasswordChar = '\0';
            }
        }
        //  btnManagerForgotPasswordNickNameHide_Click
        private void btnManagerForgotPasswordNickNameHide_Click(object sender, EventArgs e)
        {
            if (txtMangerNickName.PasswordChar == '\0')
            {
                btnManagerForgotPasswordNickNameShow.BringToFront();
                txtMangerNickName.PasswordChar = '*';
            }
        }
        //    btnManagerSetNewUserNameAndPassword_Click
        private void btnManagerSetNewUserNameAndPassword_Click(object sender, EventArgs e)
        {
            if (txtManagerNewPassword.Text != "" && txtManagerConfirmPassword.Text != "" && (validPassword))
            {
                ChangeManagerPassword();

            }
            else
            {
                MessageBox.Show("Password Not Changed");
            }
        }

        //Manager Password Change
        private void ChangeManagerPassword()
        {
            string password = bll.GetManagerUserConfirmPasswordBll(txtMangerNickName.Text);
            if (txtManagerNewPassword.Text == password)
            {
                MessageBox.Show("Old Password And New Password Doesm't Same");
            }
            else if (txtManagerNewPassword.Text != txtManagerConfirmPassword.Text)
            {
                lbltxtManagerConfirmPassword.Text = "Confirm Password Does Not Match !";

            }

            else
            {
                lbltxtManagerConfirmPassword.Text = "";
                lbltxtManagerNewPassword.Text = "";
                bll.CreateNewManagerPasswordBll(txtManagerNewPassword.Text, txtMangerNickName.Text);
                MessageBox.Show("PassWord Changed !");
            }
        }   

   

        
    }
}
