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

namespace App.Customers
{
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();
        }
        public EditCustomer(int custid)
        {
            InitializeComponent();
            FillDetails(custid);
        }

        private void FillDetails(int custid)
        {
            DAL_Customers dAL_Customers = new DAL_Customers();
            var result = dAL_Customers.GetCustomersById(new Models.RQ_Customer() { CustId = custid });
            if (result != null && result.CustomerName != string.Empty)
            {
                txtAddress.Text = result.Address;
                lblCustomerCode.Text = "(" + result.CustomerCode + ")";
                // txtBSTNo.Text =
                txtCompanyName.Text = result.CustomerName;
                txtContactPerson.Text = result.ContactPerson;
                //txtCSTNo.Text
                //txtEmail.Text = result.em
                txtMobile.Text = result.MobileNo;
                //txtPhone.Text =result.p
                lblID.Text = Convert.ToString(result.Id);

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomersList customersList = new CustomersList();
            customersList.Closed += (s, args) => this.Close(); 
            customersList.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DAL_Customers _objDAL = new DAL_Customers();

            Models.Customers customers = _objDAL.UpdateCustomer(new Models.Customers()
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
                Id = Convert.ToInt32(lblID.Text)
                //txtPhone.Text ,

            });
            if (customers != null && !string.IsNullOrWhiteSpace(customers.MessageText))
            {
                lblStatus.Visible = true;
                lblStatus.Text = customers.MessageText;
                if (customers.Code == Models.MessageCode.Success)
                {
                    // ClearControl();
                }
            }
            else
            {
                lblStatus.Visible = false;
            }
        }
    }
}
