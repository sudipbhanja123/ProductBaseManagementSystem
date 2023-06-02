using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicalLayer;
using System.Data.SqlClient;
using System.Configuration;

namespace ProductBaseManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        // Home Menu Button Click Event
        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            pnlHome.Show();
        }
        //Manager Menu Button Click Event
        private void btnMenuManager_Click_1(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            ManagerHire managerSection = new ManagerHire();
            managerSection.TopLevel = false;
            pnlHome.Controls.Add(managerSection);
            managerSection.Show();
        }

        // HomeClose Button Click Event
        private void btnHomeClose_Click(object sender, EventArgs e)
        {

            string Message = "Do You Want To Exit";
            string Title = "Exit";
            MessageBoxButtons Buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(Message, Title, Buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        // Button For Log Out  Admin And Manager
        private void btnLogOut_Click(object sender, EventArgs e)
        {


            string Message = "Do You Want To Log Out";
            string Title = "Log Out";
            MessageBoxButtons Buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(Message, Title, Buttons);
            if (result == DialogResult.Yes)
            {
                LogOutAdminManager();
                btnLogOut.Hide();
            }
            else
            {
                this.Show();
            }
           

        }
        //Methods For AdminManager LogOut
        public void LogOutAdminManager()
        {
            ToolStripMenuItemManager.Visible = false;
            ToolStripMenuItemBill.Enabled = false;
            ToolStripMenuItemProductDetails.Enabled = false;
            ToolStripMenuItemOtherExpenses.Enabled = false;
            ToolStripMenuItemTransport.Enabled = false;
            ToolStripMenuItemTransaction.Enabled = false;
            pnlHome.Controls.Clear();
        }

        //   fireToolStripMenuItem_Click
        private void fireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            ManagerHire managerSection = new ManagerHire();
            managerSection.TopLevel = false;
            pnlHome.Controls.Add(managerSection);
            managerSection.Show();
        }

       // Home Page Load
        private void Home_Load(object sender, EventArgs e)
        {
            RealTime.Start();
            ToolStripMenuItemManager.Visible= false;
            ToolStripMenuItemBill.Enabled = false;
            ToolStripMenuItemProductDetails.Enabled = false;
            ToolStripMenuItemOtherExpenses.Enabled = false;
            ToolStripMenuItemTransport.Enabled = false;
            ToolStripMenuItemTransaction.Enabled = false;
            btnLogOut.Hide();
        }
        // Home Page Real Time
        //private void RealTime_Tick(object sender, EventArgs e)
        //{
        //    lblTime.Text = DateTime.Now.ToLongTimeString();
        //    lblDate.Text = DateTime.Now.ToLongDateString();
        //}

        //Images Slider Timer
        //int count = 0;
        //private void ImageSlider_Tick(object sender, EventArgs e)
        //{

        //    if (count < 6)
        //    {
        //        PictureBoxHome.Image = HomeSlideImages.Images[count];

        //        count++;
        //    }
        //    else
        //    {
        //        count = 0;
        //    }
        //}

        //  menuStripHome_MouseHover
        private void menuStripHome_MouseHover(object sender, EventArgs e)
        {
            menuStripHome.BackColor = System.Drawing.Color.SeaGreen;
        }


     
        // Methods For Admin EnableOtherToolStripMenu
        public void EnableOtherToolStripMenu(string Person)
        {
            if (Person == "Admin")
            {
                ToolStripMenuItemManager.Visible = true;
            }
            else
            {
                ToolStripMenuItemManager.Visible = false;

            }
            ToolStripMenuItemBill.Enabled = true;
            ToolStripMenuItemProductDetails.Enabled = true;
            ToolStripMenuItemOtherExpenses.Enabled = true;
            ToolStripMenuItemTransport.Enabled = true;
            ToolStripMenuItemTransaction.Enabled = true;
        }

        // Methods For Manger EnableOtherToolStripMenu
        public void EnableOtherToolStripMenuForManager(string Person)
        {
            if (Person == "Manager")
            {
                ToolStripMenuItemManager.Visible = false;
            }
            else
            {
                ToolStripMenuItemManager.Visible = true;

            }
            ToolStripMenuItemBill.Enabled = true;
            ToolStripMenuItemProductDetails.Enabled = true;
            ToolStripMenuItemOtherExpenses.Enabled = true;
            ToolStripMenuItemTransport.Enabled = true;
            ToolStripMenuItemTransaction.Enabled = true;
        }

    
        //   homeToolStripMenuItem_MouseHover
        private void homeToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            ToolStripMenuItemHome.BackColor = Color.SeaGreen;

        }

        //ToolStripMenuManagerHire
        private void ToolStripMenuItemManagerHire_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            ManagerHire managerSection = new ManagerHire();
            managerSection.TopLevel = false;
            pnlHome.Controls.Add(managerSection);
            managerSection.Show();

        }


//---------------------------------------------------Stock Home UI--------------------------------------------------//

        private void ToolStripMenuItemStocks_Click_1(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            ProductDetails productDetails = new ProductDetails();
            productDetails.TopLevel = false;
            pnlHome.Controls.Add(productDetails);
            productDetails.Show();
        }



//---------------------------------------------------New Products Home UI--------------------------------------------------//

        private void newProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            NewProducts newProduct = new NewProducts();
            newProduct.TopLevel = false;
            pnlHome.Controls.Add(newProduct);
            newProduct.Show();
        }



//---------------------------------------------------Admin Login Home UI--------------------------------------------------//

        private void ToolStripMenuItemAdminLogin_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            AdminLogin login = new AdminLogin();
            login.TopLevel = false;
            pnlHome.Controls.Add(login);
            login.Show();
            btnLogOut.Show();
        }



//---------------------------------------------------Manager Login Home UI--------------------------------------------------//

        private void ToolStripMenuItem1ManagerLogin_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            ManagerLogin login = new ManagerLogin();
            login.TopLevel = false;
            pnlHome.Controls.Add(login);
            login.Show();
        }



//---------------------------------------------------Manager Forgot Password Home UI--------------------------------------------------//
       
        private void ToolStripMenuItemManagerForgotPassword_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            ManagerForgotPassword forgotpassword = new ManagerForgotPassword();
            forgotpassword.TopLevel = false;
            pnlHome.Controls.Add(forgotpassword);
            forgotpassword.Show();
        }



//---------------------------------------------------Admin Forgot Password Home UI--------------------------------------------------//
        
        private void ToolStripMenuItemAdminForgotPassword_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            AdminForgotPassword forgotpassword = new AdminForgotPassword();
            forgotpassword.TopLevel = false;
            pnlHome.Controls.Add(forgotpassword);
            forgotpassword.Show();
        }



//---------------------------------------------------Electric Home UI--------------------------------------------------//
      
        private void ToolStripMenuItemTransport_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            Transport transport = new Transport();
            transport.TopLevel = false;
            pnlHome.Controls.Add(transport);
            transport.Show();
        }


        
//---------------------------------------------------ShopRent Home UI--------------------------------------------------//

        private void ToolStripMenuItemShopRent_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            ShopRent shopRent = new ShopRent();
            shopRent.TopLevel = false;
            pnlHome.Controls.Add(shopRent);
            shopRent.Show();
        }


//---------------------------------------------------Electric Home UI--------------------------------------------------//
  
        private void ToolStripMenuItemElectricBill_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            Electric electric = new Electric();
            electric.TopLevel = false;
            pnlHome.Controls.Add(electric);
            electric.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }



//---------------------------------------------------Others Home UI--------------------------------------------------//

        private void ToolStripMenuItemOthers_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            Others others = new Others();
            others.TopLevel = false;
            pnlHome.Controls.Add(others);
            others.Show();
        }

        private void ToolStripMenuItemHome_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItemTransaction_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            Transaction_Status transaction = new Transaction_Status();
            transaction.TopLevel = false;
            pnlHome.Controls.Add(transaction);
            transaction.Show();

        }

        private void pnlHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItemSignUpAdmin_Click(object sender, EventArgs e)
        {
            pnlHome.Controls.Clear();
            Sign_Up signUp = new Sign_Up();
            signUp.TopLevel = false;

            pnlHome.Controls.Add(signUp);
            signUp.Show();
        }

        private void ToolStripMenuItemLogin_Click(object sender, EventArgs e)
        {

        }

        //private void ToolStripMenuItemLogin_Click(object sender, EventArgs e)
        //{
        //    ToolStripMenuItemAdminLogin.HideDropDown();

        //}

      

       

        

        

      

       

        
       
        

       
       
       

        

       

      
       

       
        

      
       

        

       
       

       




 





















    }
}
