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
    public partial class CustomersList : Form
    {
        public CustomersList()
        {
            InitializeComponent();
            BindingData(new Models.RQ_Customer() { PageNo = 0, PageSize = 5 });
        }

        private void BindingData(Models.RQ_Customer _rqObj)
        {
            try
            {
                DAL_Customers _objDAL = new DAL_Customers();

                var lstData = _objDAL.GetCustomers(_rqObj);

                DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                bcol.HeaderText = " ";
                bcol.Text = "Edit";
                bcol.Name = "btnClickMe";
                bcol.UseColumnTextForButtonValue = true;
                gdvwCustomers.Columns.Add(bcol);

                DataGridViewButtonColumn dcol = new DataGridViewButtonColumn();
                dcol.HeaderText = " ";
                dcol.Text = "Delete";
                dcol.Name = "btnClickMe";
                dcol.UseColumnTextForButtonValue = true;
                gdvwCustomers.Columns.Add(dcol);

                rSCustomersBindingSource.DataSource = lstData;

                //gdvwCustomers.DataSource = lstData;
                //gdvwCustomers.DataBindings();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void gdvwCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            this.Hide();
            int CustId = Convert.ToInt32(this.gdvwCustomers.CurrentRow.Cells[0].Value);
            EditCustomer editCustomer = new EditCustomer(CustId);
            editCustomer.Closed += (s, args) => this.Close();
            editCustomer.Show();
            
        }
    }
}
