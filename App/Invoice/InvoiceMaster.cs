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

namespace App.Invoice
{
    public partial class InvoiceMaster : Form
    {
        DAL_PartyMaster _objDalPartyMaster;
        DAL_Invoices _objInvoice;
        public InvoiceMaster()
        {
            InitializeComponent();
            this.dgInvoiceList.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            this.dgInvoiceList.AlternatingRowsDefaultCellStyle.BackColor = Color.AntiqueWhite;
            this.Dock = DockStyle.Fill;
        }

        private void InvoiceMaster_Load(object sender, EventArgs e)
        {
            BindPageData();
            this.WindowState = FormWindowState.Maximized;
        }

        private void BindPageData()
        {
            FillPartyNameDetails();
            FillPartyMaster(new Models.PartyMasterRQ() { });
            FillInvoiceForParty(null);
        }
        private void grdvwPartyNameForInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string PartyNo = Convert.ToString(this.grdvwPartyNameForInvoice.CurrentRow.Cells[1].Value);
            if (!string.IsNullOrWhiteSpace(PartyNo))
                FillInvoiceForParty(PartyNo);
        }

        private void FillInvoiceForParty(string partyNo)
        {
            _objInvoice = new DAL_Invoices();
            var result = _objInvoice.GetInvoiceByPartyNo(new Models.Invoice_RQ() { PartyNo = partyNo });
            dgInvoiceList.DataSource = result;
            this.dgInvoiceList.Columns["InvoiceId"].Visible = false;
            if (dgInvoiceList.Columns.Count == 6)
            {
                AddCoulumn(dgInvoiceList);
            }
        }

        private void AddCoulumn(DataGridView dgInvoiceList)
        {

            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.HeaderText = " ";
            bcol.Text = "View";
            bcol.Name = "View";
            bcol.UseColumnTextForButtonValue = true;
            dgInvoiceList.Columns.Add(bcol);

            DataGridViewButtonColumn bcolToPrint = new DataGridViewButtonColumn();
            bcolToPrint.HeaderText = " ";
            bcolToPrint.Text = "Print";
            bcolToPrint.Name = "Print";
            bcolToPrint.UseColumnTextForButtonValue = true;
            dgInvoiceList.Columns.Add(bcolToPrint);

            DataGridViewButtonColumn bcolToEdit = new DataGridViewButtonColumn();
            bcolToEdit.HeaderText = " ";
            bcolToEdit.Text = "Edit";
            bcolToEdit.Name = "Edit";
            bcolToEdit.UseColumnTextForButtonValue = true;
            dgInvoiceList.Columns.Add(bcolToEdit);
        }

        private void FillPartyNameDetails()
        {
            try
            {
                _objDalPartyMaster = new DAL_PartyMaster();
                var result = _objDalPartyMaster.GetPartyMaster(new Models.PartyMasterRQ() { });

                result.Insert(0, new Models.PartyMasterRS() { PartyId = 0, PartyName = "All Party" });
                if (result != null && result.Count > 0)
                {
                    cmbPartyName.DataSource = result;
                    cmbPartyName.DisplayMember = "PartyName";
                    cmbPartyName.ValueMember = "PartyCode";
                }
                cmbPartyName.SelectedIndex = 0;

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void FillPartyMaster(Models.PartyMasterRQ _obj)
        {
            try
            {
                _objDalPartyMaster = new DAL_PartyMaster();
                var result = _objDalPartyMaster.GetPartyMaster(_obj);
                grdvwPartyNameForInvoice.DataSource = result;
                grdvwPartyNameForInvoice.Columns[0].Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgInvoiceList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dgInvoiceList.Columns["View"].Index || e.ColumnIndex == -1)
            {
                string invoiceNo = Convert.ToString(this.dgInvoiceList.CurrentRow.Cells["InvoiceNo"].Value);
                FillOrderItem(invoiceNo);
            }
            else if (e.ColumnIndex == this.dgInvoiceList.Columns["Print"].Index)
            {
                string invoiceNo = Convert.ToString(this.dgInvoiceList.CurrentRow.Cells["InvoiceNo"].Value);
                FillOrderItem(invoiceNo);
                PrintInvoice(invoiceNo);
            }
            else if (e.ColumnIndex == this.dgInvoiceList.Columns["Edit"].Index)
            {
                string invoiceNo = Convert.ToString(this.dgInvoiceList.CurrentRow.Cells["InvoiceNo"].Value);
                CreateInvoice createInvoice = new CreateInvoice();
                createInvoice.MdiParent = this.ParentForm;
                createInvoice.strInvoiceNo = invoiceNo;
                this.ParentForm.ActiveMdiChild.Close();
                createInvoice.Show();
                //FillOrderItem(invoiceNo);
                //PrintInvoice(invoiceNo);
            }
        }

        private void PrintInvoice(string invoiceNo)
        {
           // MessageBox.Show(invoiceNo + " Print Function will call here");

            RptView frmrpt = new RptView();
            frmrpt.txthiddenInvoiceNum.Text = invoiceNo;
            frmrpt.Show();
        }

        private void FillOrderItem(string invoiceNo)
        {
            try
            {
                DAL_InvoiceItem dAL_InvoiceItem = new DAL_InvoiceItem();
                var result = dAL_InvoiceItem.GetInvoiceItemByInvoiceNo(new Models.InvoiceItem_RQ() { InvoiceNo = invoiceNo });
                dgvOrderItem.DataSource = result;
                this.dgvOrderItem.Columns[0].Visible = false;
                this.dgvOrderItem.Columns[1].Visible = false;
                this.dgvOrderItem.Columns["WorkOrderDesc"].Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cmbPartyName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbPartyName.SelectedValue != null)
            {
                // Models.PartyMasterRS selected = (Models.PartyMasterRS)cmbPartyName.SelectedValue;
                FillInvoiceForParty(cmbPartyName.SelectedValue.ToString());
                FillPartyMaster(new Models.PartyMasterRQ() { PartyCode = cmbPartyName.SelectedValue.ToString() });
            }
            else
            {
                FillInvoiceForParty(null);
                FillPartyMaster(new Models.PartyMasterRQ() { });
            }
        }


        //private void dgInvoiceList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    string PartyNo = Convert.ToString(this.dgvOrderItem.CurrentRow.Cells[1].Value);
        //    if (!string.IsNullOrWhiteSpace(PartyNo))
        //        FillInvoiceForParty(PartyNo);
        //}
    }
}
