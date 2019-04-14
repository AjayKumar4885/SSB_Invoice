using App.Customers;
using System;
using App.PartyMaster;
using System.Windows.Forms;
using App.Article;

namespace App
{
    public partial class Home : Form
    {
        private CustomersList _instancelstCust = null;
        private AddCustomer _instanceAddCustomer = null;
        private PartyMasterForm _instancePartyMasterForm = null;
        private ItemMaster _instanceItemMaster = null;
        private Invoice.InvoiceMaster _instanceInvoiceMaster = null;
        private Invoice.CreateInvoice _instanceInvoiceCreate = null;

        public Home()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            menuStrip1.ForeColor = System.Drawing.Color.White;
        }

        private void CloseAllForms()
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        private void ShowMessage()
        {
            MessageBox.Show("Page is already opened in backgroud.");
        }

        private void instancelstCustHasBeenClosed(object sender, FormClosedEventArgs e)
        {
            _instancelstCust = null;
        }
        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_instancelstCust == null)
            {
                CloseAllForms();
                _instancelstCust = new CustomersList();
                _instancelstCust.MdiParent = this;
                _instancelstCust.FormClosed += instancelstCustHasBeenClosed;
            }
            else
            {
                ShowMessage();
            }
            _instancelstCust.Show();
        }

        private void instanceAddCustomerHadBeenClosed(object sender, FormClosedEventArgs e)
        {
            _instanceAddCustomer = null;
        }
        private void customerAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_instanceAddCustomer == null)
            {
                CloseAllForms();
                _instanceAddCustomer = new AddCustomer();
                _instanceAddCustomer.MdiParent = this;
                _instanceAddCustomer.FormClosed += instanceAddCustomerHadBeenClosed;
            }
            else
            {
                ShowMessage();
            }
            _instanceAddCustomer.Show();
        }

        private void instancePartyMasterFormHasBeenClosed(object sender, FormClosedEventArgs e)
        {
            _instancePartyMasterForm = null;
        }
        private void partyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (_instancePartyMasterForm == null)
            {
                CloseAllForms();
                _instancePartyMasterForm = new PartyMasterForm();
                _instancePartyMasterForm.MdiParent = this;
                _instancePartyMasterForm.FormClosed += instancePartyMasterFormHasBeenClosed;
            }
            else
            {
                ShowMessage();
            }
            _instancePartyMasterForm.Show();

        }

        private void instanceItemMasterHasBeenClosed(object sender, FormClosedEventArgs e)
        {
            _instanceItemMaster = null;
        }
        private void articleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_instanceItemMaster == null)
            {
                CloseAllForms();
                _instanceItemMaster = new ItemMaster();
                _instanceItemMaster.MdiParent = this;
                _instanceItemMaster.FormClosed += instanceItemMasterHasBeenClosed;
            }
            else
            {
                ShowMessage();
            }
            _instanceItemMaster.Show();
        }

        private void instanceInvoiceMasterHasBeenClosed(object sender, FormClosedEventArgs e)
        {
            _instanceInvoiceMaster = null;
        }
        private void invoiceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_instanceInvoiceMaster == null)
            {
                CloseAllForms();
                _instanceInvoiceMaster = new Invoice.InvoiceMaster();
                _instanceInvoiceMaster.MdiParent = this;
                _instanceInvoiceMaster.FormClosed += instanceInvoiceMasterHasBeenClosed;
            }
            else
            {
                ShowMessage();

            }
            _instanceInvoiceMaster.Show();
        }

        private void instanceInvoiceCreateHasBeenClosed(object sender, FormClosedEventArgs e)
        {
            _instanceInvoiceCreate = null;
        }
        private void invoiceAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_instanceInvoiceCreate == null)
            {
                CloseAllForms();
                _instanceInvoiceCreate = new Invoice.CreateInvoice();
                _instanceInvoiceCreate.MdiParent = this;
                _instanceInvoiceCreate.FormClosed += instanceInvoiceCreateHasBeenClosed;
            }
            else
            {
                ShowMessage();
            }
            _instanceInvoiceCreate.Show();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RptView rpt = new RptView();
            rpt.Show();
        }
    }
}
