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
    public partial class ManagerLogin : Form
    {
        BLL bll = new BLL();

        public ManagerLogin()
        {
            InitializeComponent();
        }

       

        // TextBox UserName MouseLeave Event
        private void txtManagerUserName_MouseLeave(object sender, EventArgs e)
        {
            bool UserName = bll.ValidUserName(txtManagerUserName.Text);
            if (UserName)
            {
                lbltxtManagerUserName.Text = "";
            }
            else
            {
                lbltxtManagerUserName.Text = "Enter Your UserName";
            }
        }
        // TextBox UserName MouseLeave Event
        private void txtManagerPassword_MouseLeave(object sender, EventArgs e)
        {
            bool UserName = bll.ValidUserName(txtManagerPassword.Text);
            if (UserName)
            {
                lbltxtManagerPassword.Text = "";
            }
            else
            {
                lbltxtManagerPassword.Text = "Enter Your Password";
            }
        }

        private void btnManagerLogin_Click(object sender, EventArgs e)
        {
            //if (true)
            //{

            //    Home home = new Home();
            //    home.Show();
            //    home.EnableOtherToolStripMenu("Manager");
            //    this.Hide();
            //}
            //
            bool result = bll.ManagerLoginCheckBll(txtManagerUserName.Text, txtManagerPassword.Text);
            if (result)
            {

                Home home = new Home();
                home.Show();
                home.EnableOtherToolStripMenu("Manager");
                this.Hide();
            }
            else
                MessageBox.Show("You Enter Wrong Password !");
        }
        //    btnManagerUserNameShow_Click
        private void btnManagerUserNameShow_Click(object sender, EventArgs e)
        {
            if (txtManagerUserName.PasswordChar == '*')
            {
                btnManagerUserNameHide.BringToFront();
                txtManagerUserName.PasswordChar = '\0';
            }
        }
        //   btnManagerUserNameHide_Click
        private void btnManagerUserNameHide_Click(object sender, EventArgs e)
        {
            if (txtManagerUserName.PasswordChar == '\0')
            {
                btnManagerUserNameShow.BringToFront();
                txtManagerUserName.PasswordChar = '*';
            }
        }
        //   btnManagerPasswordHide_Click
        private void btnManagerPasswordHide_Click(object sender, EventArgs e)
        {
            if (txtManagerPassword.PasswordChar == '\0')
            {
                btnManagerPasswordShow.BringToFront();
                txtManagerPassword.PasswordChar = '*';
            }
        }
        //   btnManagerPasswordShow_Click
        private void btnManagerPasswordShow_Click(object sender, EventArgs e)
        {
            if (txtManagerPassword.PasswordChar == '*')
            {
                btnManagerPasswordHide.BringToFront();
                txtManagerPassword.PasswordChar = '\0';
            }
        }

       

       

       
    }
}
