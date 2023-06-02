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
    public partial class NewProducts : Form
    {
        BLL bll = new BLL();
        bool ValidBrand = false;
        bool ValidSubBrand = false;
        bool ValidWeight = false;

        public NewProducts()
        {
            InitializeComponent();
        }

        

        // New  Brand
        private void txtNewBrand_Leave(object sender, EventArgs e)
        {
            bool result = bll.ValidUserName(txtNewBrand.Text);
            if (txtNewBrand.Text == "")
            {
                lblTxtNewBrand.Text = "Enter Brand Name";
             
            }
            else if (!(result))
            {
                lblTxtNewBrand.Text = "Enter Valid Brand Name";
            }
            else
            {
                lblTxtNewBrand.Text = "";
                ValidBrand = true;
            }
        }

        // New SubBrand Name
        private void txtNewSubBrand_Leave(object sender, EventArgs e)
        {
            bool Result = bll.ValidUserName(txtNewSubBrand.Text);
            if (txtNewSubBrand.Text == "")
            {
                lbltxtNewSubBrand.Text= "Enter SubBrand Name";
              
            }
            else if (!(Result))
            {
                lbltxtNewSubBrand.Text= "Enter Valid SubBrand";
                
            }
            else
            {
                lbltxtNewSubBrand.Text = "";
                ValidSubBrand = true;
            }
        }

        // New SubBrand Weight
        private void txtNewSubBrandWeight_Leave(object sender, EventArgs e)
            {
            bool result=bll.ValidWeightBll(txtNewSubBrandWeight.Text);
            if (txtNewSubBrandWeight.Text == "")
            {
                lbltxtNewSubBrandWeight.Text="Enter Weight";
              
            }
            else if (!(result))
            {
                lbltxtNewSubBrandWeight.Text="Enter Valid Weight";
               
            }
            else
            {
                lbltxtNewSubBrandWeight.Text = "";
               
                ValidWeight = true;
            }
        }

        // Button New Products Entry
        private void BtnNewProductEntry_Click(object sender, EventArgs e)
        {

            if ( ValidBrand && ValidSubBrand || ValidWeight )
            {
                InsertIntoNewProductbtn();

            }
            else
            {
                MessageBox.Show("Please Enter All Data");
            }
        }


        // methods For  Insert New Products In New Product Entry Button
        public void InsertIntoNewProductbtn()
        {
            if (ValidBrand)
            {
                bool Brandresult = bll.InsertNewBrandBll(txtNewBrand.Text);
                if (Brandresult)
                {
                    MessageBox.Show("Brand Inserted");
                }
                //else
                //    MessageBox.Show("");
            }

            if (ValidSubBrand)
            {
                bool SubBrandResult = bll.InsertNewSubBrandBll(txtNewBrand.Text, txtNewSubBrand.Text);

                if (SubBrandResult)
                {
                    MessageBox.Show("Sub Brand Inserted");
                }
                else
                    MessageBox.Show("Sub Brand Not Inserted");
            }

            if (ValidWeight)
            {
                bool SubBrandWeightResult = bll.InsertNewWeightBll(txtNewSubBrandWeight.Text);
                if (SubBrandWeightResult)
                {
                    MessageBox.Show("Inserted");
                }
                else
                {
                    MessageBox.Show("Not Inserted");
                }
            }
        }

       

        
       

        
    }
}
