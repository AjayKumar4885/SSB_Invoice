using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace App.Customers
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void lblClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        private void ClearControl()
        {
            txtAddress.Text = string.Empty;
            txtBSTNo.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtContactPerson.Text = string.Empty;
            txtCSTNo.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtFYF.Text = string.Empty;
            txtFYT.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtPhone.Text = string.Empty;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            try
            {
                DAL_Customers _objDAL = new DAL_Customers();
                
                Models.Customers customers = _objDAL.CreateCust(new Models.Customers()
                {
                    Address = txtAddress.Text,
                    //txtBSTNo.Text ,
                    CustomerName = txtCompanyName.Text,
                    ContactPerson = txtContactPerson.Text,
                    //txtCSTNo.Text ,
                    //txtEmail.Text ,
                    //txtFYF.Text ,
                    //txtFYT.Text ,
                    MobileNo = txtMobile.Text,
                    //txtPhone.Text ,
                    CreatedBy = "System",
                    CreatedOn = DateTime.Today
                });
                if (customers != null && !string.IsNullOrWhiteSpace(customers.MessageText))
                {
                    lblStatus.Visible = true;
                    lblStatus.Text = customers.MessageText;
                    if(customers.Code == Models.MessageCode.Success)
                    {
                        ClearControl();
                    }
                }
                else
                {
                    lblStatus.Visible = false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void lblFYT_Click(object sender, EventArgs e)
        {

        }
    }
}
