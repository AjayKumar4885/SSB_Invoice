using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Invoice
{
    public partial class CreateInvoice : Form
    {
        DAL_PartyMaster _objDalPartyMaster;
        DAL_Article _objDalArticle;
        DAL_Invoices _objInvoice;
        DataTable dtorder = new DataTable("dtOrderDetails");
        public string strInvoiceNo { get; set; }
        public CreateInvoice()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        private void InvoiceCreate_Load(object sender, EventArgs e)
        {
            FillDefaultData();
            FillPageData();
            if (!string.IsNullOrWhiteSpace(strInvoiceNo))
            {
                FindInvoice(strInvoiceNo);
                txtBoxInvoiceNo.Text = strInvoiceNo;
            }
            this.WindowState = FormWindowState.Maximized;
        }

        #region PageData & DefaultData Fill
        private void FillDefaultData()
        {
            List<DeliveryByClass> deliveryByClasses = new List<DeliveryByClass>();
            deliveryByClasses.Add(new DeliveryByClass() { DeliveryID = "BySea", DeliveryBy = "By Sea" });
            deliveryByClasses.Add(new DeliveryByClass() { DeliveryID = "ByAir", DeliveryBy = "By Air" });
            cmbDeliveryBy.DataSource = deliveryByClasses;
            cmbDeliveryBy.DisplayMember = "DeliveryBy";
            cmbDeliveryBy.ValueMember = "DeliveryID";
            cmbDeliveryBy.SelectedIndex = 0;


            List<PartialShipClass> partialShipClasses = new List<PartialShipClass>();
            partialShipClasses.Add(new PartialShipClass() { PartialShipID = "NotAllowed", PartialShip = "Not Allowed" });
            partialShipClasses.Add(new PartialShipClass() { PartialShipID = "Allowed", PartialShip = "Allowed" });
            cmbPartialShip.DataSource = partialShipClasses;
            cmbPartialShip.DisplayMember = "PartialShip";
            cmbPartialShip.ValueMember = "PartialShipID";
            cmbPartialShip.SelectedIndex = 0;

            List<TransShipmentClass> transShipmentClasses = new List<TransShipmentClass>();
            transShipmentClasses.Add(new TransShipmentClass() { TransShipmentID = "NotAllowed", TransShipment = "Not Allowed" });
            transShipmentClasses.Add(new TransShipmentClass() { TransShipmentID = "Allowed", TransShipment = "Allowed" });
            cmbTransShipment.DataSource = transShipmentClasses;
            cmbTransShipment.DisplayMember = "TransShipment";
            cmbTransShipment.ValueMember = "TransShipmentID";
            cmbTransShipment.SelectedIndex = 0;

        }

        private void FillPageData()
        {
            FillPartyNameDetails();
            FillBankDetails();
            FillCurrencyDetails();
            FillUnitDetails();
            FillArticle();
            FillRefileInk();
            dtColumns();
        }

        private void dtColumns()
        {
            dtorder.Clear();
            dtorder.Columns.Add("invoiceOrderItemId");
            dtorder.Columns.Add("ArtId");
            dtorder.Columns.Add("ArtNo");
            dtorder.Columns.Add("Desc");
            //dtorder.Columns.Add("WorkOrderDesc");
            dtorder.Columns.Add("RefillsLink");
            dtorder.Columns.Add("Rate");
            dtorder.Columns.Add("Qty");
            dtorder.Columns.Add("Amount");
            dtorder.Columns.Add("Sequence");
            dtorder.Columns.Add("RefillsLinkId");

        }

        private void FillRefileInk()
        {
            _objDalArticle = new DAL_Article();
            var result = GetRefileInkData();
            result.Insert(0, new RefillInk() { id = 0, RefillInkColor = "-- Select --" });
            if (result != null && result.Count > 0)
            {
                cmbboxToAddRefileInk.DataSource = result;
                cmbboxToAddRefileInk.DisplayMember = "RefillInkColor";
                cmbboxToAddRefileInk.ValueMember = "id";
            }
            cmbBoxArtNo.SelectedIndex = 0;
        }

        private List<RefillInk> GetRefileInkData()
        {
            List<RefillInk> _lstRefileInk = new List<RefillInk>();


            RefillInk _objBlack = new RefillInk() { id = 1, RefillInkColor = "Black" }; _lstRefileInk.Add(_objBlack);
            RefillInk _objRed = new RefillInk() { id = 2, RefillInkColor = "Red" }; _lstRefileInk.Add(_objRed);
            RefillInk _objGreen = new RefillInk() { id = 3, RefillInkColor = "Green" }; _lstRefileInk.Add(_objGreen);

            return _lstRefileInk;



        }

        private void FillArticle()
        {
            _objDalArticle = new DAL_Article();
            var result = _objDalArticle.GetArticleForInvoice(new Models.ArticleRQ() { });
            result.Insert(0, new Models.ArticleWithDescRS() { ArtId = 0, ArtNoWithDesc = " " });
            if (result != null && result.Count > 0)
            {
                cmbBoxArtNo.DataSource = result;
                cmbBoxArtNo.DisplayMember = "ArtNo";
                cmbBoxArtNo.ValueMember = "ArtNo";
            }
            cmbBoxArtNo.SelectedIndex = 0;
            cmbBoxArtNo.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbBoxArtNo.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void FillUnitDetails()
        {
            cmbBoxUnit.DataSource = GetUnitMaster();
            cmbBoxUnit.DisplayMember = "Unit";
            cmbBoxUnit.ValueMember = "UnitID";
        }

        private List<UnitMaster> GetUnitMaster()
        {
            List<UnitMaster> _lstunitMasters = new List<UnitMaster>();
            _lstunitMasters.Add(new UnitMaster() { UnitID = 1, Unit = "Per/PC" });
            _lstunitMasters.Add(new UnitMaster() { UnitID = 2, Unit = "Pack/PC" });
            return _lstunitMasters;
        }

        private void FillCurrencyDetails()
        {
            cmbBoxCurrency.DataSource = GetCurrencyMaster();
            cmbBoxCurrency.DisplayMember = "Currency";
            cmbBoxCurrency.ValueMember = "CurrencyId";
        }

        private List<CurrencyMaster> GetCurrencyMaster()
        {
            List<CurrencyMaster> _lstCurrency = new List<CurrencyMaster>();
            _lstCurrency.Add(new CurrencyMaster() { CurrencyId = 1, Currency = "US $" });
            _lstCurrency.Add(new CurrencyMaster() { CurrencyId = 2, Currency = "INR ₹" });
            _lstCurrency.Add(new CurrencyMaster() { CurrencyId = 3, Currency = "Euro €" });

            return _lstCurrency;

        }

        private void FillBankDetails()
        {
            List<BankMaster> bankMasters = new List<BankMaster>();
            bankMasters.Add(new BankMaster() { BankId = 1, BankName = "Union Bank Of India" });

            if (bankMasters != null && bankMasters.Count > 0)
            {
                cmbboxBanks.DataSource = bankMasters;
                cmbboxBanks.DisplayMember = "BankName";
                cmbboxBanks.ValueMember = "BankId";
            }
        }

        private void FillPartyNameDetails()
        {
            try
            {
                _objDalPartyMaster = new DAL_PartyMaster();
                var result = _objDalPartyMaster.GetPartyMaster(new Models.PartyMasterRQ() { });

                result.Insert(0, new Models.PartyMasterRS() { PartyId = 0, PartyName = " " });
                if (result != null && result.Count > 0)
                {
                    cmbPartyName.DataSource = result;
                    cmbPartyName.DisplayMember = "PartyName";
                    cmbPartyName.ValueMember = "PartyCode";
                }
                cmbPartyName.SelectedIndex = 0;

                //Set AutoCompleteMode.
                cmbPartyName.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbPartyName.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region Controls Event
        private void cmbPartyName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            var partycode = ((Models.PartyMasterRS)comboBox.SelectedItem).PartyCode;
            SetPartyMasterAddress(partycode);

        }
        private void SetPartyMasterAddress(string partycode)
        {
            var result = _objDalPartyMaster.GetPartyMasterByID(new Models.PartyMasterRQ() { PartyCode = partycode });
            if (result != null && !string.IsNullOrWhiteSpace(result.PartyCode))
            {
                txtboxAddress.Text = result.Address;
            }
        }

        private void cmbBoxArtNo_SelectionChangeCommitted(object sender, System.EventArgs e)
        {

            ComboBox comboBox = (ComboBox)sender;
            var _ArtNo = ((Models.ArticleWithDescRS)comboBox.SelectedItem).ArtNo;
            var result = _objDalArticle.GetArticleByID(new Models.ArticleRQ() { ArtNo = _ArtNo });
            if (result != null && !string.IsNullOrWhiteSpace(result.ArtNo))
            {
                lblArtId.Text = Convert.ToString(result.ArtId);
                lblArtNoData.Text = result.ArtNo;
                txtArtDesc.Text = result.Desc;
                // txtBoxWorkOrderDesc.Text = result.WorkOrderDesc;
                txtboxRate.Text = Convert.ToString(result.Rate);

            }

        }

        private void txtboxRate_TextChanged(object sender, EventArgs e)
        {
            lblAmout.Text = Convert.ToString(CalcuateAmout());
        }

        private void txtboxQty_TextChanged(object sender, EventArgs e)
        {
            lblAmout.Text = Convert.ToString(CalcuateAmout());
        }

        private void rdbtnCIF_CheckedChanged(object sender, EventArgs e)
        {
            //   rdbtnCIF.Checked = !rdbtnCIF.Checked;
            if (rdbtnCIF.Checked)
            {
                rdbtnCIF.Checked = true;
                lblDeliveryTermsValue.Text = rdbtnCIF.Text;
                rdbtnCNF.Checked = false;
                rdbtnFOB.Checked = false;
            }


        }

        private void rdbtnCNF_CheckedChanged(object sender, EventArgs e)
        {
            // rdbtnCNF.Checked = !rdbtnCNF.Checked;
            if (rdbtnCNF.Checked)
            {
                rdbtnCNF.Checked = true;
                lblDeliveryTermsValue.Text = rdbtnCNF.Text;
                rdbtnCIF.Checked = false;
                rdbtnFOB.Checked = false;
            }

        }

        private void rdbtnFOB_CheckedChanged(object sender, EventArgs e)
        {
            // rdbtnFOB.Checked = !rdbtnFOB.Checked;
            if (rdbtnFOB.Checked)
            {
                rdbtnFOB.Checked = true;
                lblDeliveryTermsValue.Text = rdbtnFOB.Text;
                rdbtnCNF.Checked = false;
                rdbtnCIF.Checked = false;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxInvoiceNo.Text))
            {
                RptView frmrpt = new RptView();
                frmrpt.txthiddenInvoiceNum.Text = txtBoxInvoiceNo.Text.Split('-')[1];
                frmrpt.Show();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAllControls();
        }

        private void ClearAllControls()
        {
            dtorder.Rows.Clear();
            cmbPartyName.SelectedIndex = 0;
            txtboxAddress.Text = string.Empty;
            cmbboxBanks.SelectedIndex = 0;
            cmbBoxUnit.SelectedIndex = 0;
            cmbBoxCurrency.SelectedIndex = 0;
            lblGrandAmout.Text = string.Empty;
            lblGrandQty.Text = string.Empty;
            rdbtnCIF.Checked = false;
            rdbtnCNF.Checked = false;
            rdbtnFOB.Checked = false;
            cmbDeliveryBy.SelectedIndex = 0;
            cmbPartialShip.SelectedIndex = 0;
            cmbTransShipment.SelectedIndex = 0;
            txtPaymentTerms.Text = string.Empty;
            txtDeliveryPeriod.Text = string.Empty;
            txtRemark.Text = string.Empty;
            btnPrint.Enabled = false;
            lblArtNoData.Text = string.Empty;
            txtArtDesc.Text = string.Empty;
            grdvOrderItem.DataSource = null;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {

        }
        #endregion


        private double CalcuateAmout()
        {
            if (!string.IsNullOrWhiteSpace(txtboxQty.Text) && !string.IsNullOrWhiteSpace(txtboxRate.Text))
                return (Convert.ToDouble(txtboxQty.Text) * Convert.ToDouble(txtboxRate.Text));
            else
                return 0;
        }
        private void CalculateGrandTotal()
        {
            double grdAmt = 0;
            double grdQty = 0;
            foreach (DataRow item in dtorder.Rows)
            {
                grdAmt = grdAmt + Convert.ToDouble(item["Amount"]);
                grdQty = grdQty + Convert.ToDouble(item["Qty"]);
            }
            lblGrandQty.Text = Convert.ToString(grdQty);
            lblGrandAmout.Text = Convert.ToString(grdAmt);

        }
        private void ClearAddItemControls()
        {

            lblArtId.Text = string.Empty;
            lblArtNoData.Text = string.Empty;
            txtArtDesc.Text = string.Empty;
            //txtBoxWorkOrderDesc.Text = string.Empty;
            cmbboxToAddRefileInk.SelectedIndex = 0;
            txtboxRate.Text = string.Empty;
            txtboxQty.Text = string.Empty;
            lblAmout.Text = string.Empty;
            cmbBoxArtNo.SelectedIndex = 0;
        }
        private void AddCoulmnInGrid()
        {
            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.HeaderText = " ";
            bcol.Text = "Delete";
            bcol.Name = "Delete";
            bcol.UseColumnTextForButtonValue = true;
            grdvOrderItem.Columns.Add(bcol);

        }
        private bool FillOrderItemGrid()
        {
            try
            {
                DataView dv = dtorder.DefaultView;
                dv.Sort = "Sequence desc";
                DataTable data = dv.ToTable();
                grdvOrderItem.DataSource = data;

                if (!grdvOrderItem.Columns.Contains("Delete"))
                    AddCoulmnInGrid();
                this.grdvOrderItem.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.grdvOrderItem.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.grdvOrderItem.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.grdvOrderItem.Columns["invoiceOrderItemId"].Visible = false;
                this.grdvOrderItem.Columns["ArtId"].Visible = false;
                this.grdvOrderItem.Columns["Sequence"].Visible = false;
                this.grdvOrderItem.Columns["RefillsLinkId"].Visible = false;
            }
            catch (Exception)
            {
                throw;
            }
            return true;

        }

        private void btnCreate_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateInvoiceDetails();
            }
        }

        private void CreateInvoiceDetails()
        {
            //Validate invoice
            if (string.IsNullOrWhiteSpace(txtBoxInvoiceNo.Text))
            {
                var item = ValidateInvoice();
                if (item != null && item.IsValid)
                {
                    CreateInvoiceObject(null);
                }
                else
                {
                    MessageBox.Show(item.Info);
                }
            }
            else //Update
            {
                var item = ValidateInvoice();
                if (item != null && item.IsValid)
                {
                    CreateInvoiceObject(txtBoxInvoiceNo.Text.Trim());
                }

                // MessageBox.Show("Invoice already created !");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateInvoiceDetails();
        }

        private void CreateInvoiceObject(string invoiceNo)
        {
            try
            {
                Models.Invoice _invoice = new Models.Invoice();

                _invoice.BankId = Convert.ToString(cmbboxBanks.SelectedValue);
                _invoice.InvoiceCurrency = cmbBoxCurrency.Text;
                _invoice.IsActive = true;
                _invoice.CreatedBy = "System";
                _invoice.CreatedOn = DateTime.Today;
                _invoice.InvoiceDate = DateTime.ParseExact(InvoiceDate.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                _invoice.InvoiceGrandAmt = Convert.ToDecimal(lblGrandAmout.Text);
                _invoice.InvoiceGrandQty = Convert.ToDecimal(lblGrandQty.Text);
                _invoice.PartyNo = (string)cmbPartyName.SelectedValue;
                _invoice.Unit = cmbBoxUnit.Text;
                _invoice.DeliveryTerms = lblDeliveryTermsValue.Text;
                _invoice.DeliveryPeriod = txtDeliveryPeriod.Text;
                _invoice.DeliveryType = Convert.ToString(cmbDeliveryBy.SelectedValue);
                _invoice.PaymentTerms = txtPaymentTerms.Text;
                _invoice.Port = txtPort.Text;
                _invoice.PartialShip = Convert.ToString(cmbPartialShip.SelectedValue);
                _invoice.PaymentTerms = Convert.ToString(cmbTransShipment.SelectedValue);
                _invoice.Remark = txtRemark.Text;

                if (dtorder.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtorder.Rows)
                    {
                        if (Convert.ToInt32(dr["Sequence"]) == 0)
                        {
                            continue;
                        }

                        _invoice._objOrderItem.Add(new InvoiceItemDetails()
                        {
                            Amount = Convert.ToDecimal(dr["Amount"]),
                            ArtDesc = Convert.ToString(dr["Desc"]),
                            WorkOrderDesc = Convert.ToString(dr["WorkOrderDesc"]),
                            Quantity = Convert.ToInt32(dr["Qty"]),
                            ArtNo = Convert.ToString(dr["ArtNo"]),
                            Rate = Convert.ToDecimal(dr["Rate"]),
                            RefileInk = Convert.ToString(dr["RefillsLink"]),

                        });

                    }
                    _objInvoice = new DAL_Invoices();
                    if (string.IsNullOrWhiteSpace(invoiceNo))
                    {
                        _invoice.InvoiceNo = invoiceNo;
                        var resultCreate = _objInvoice.CreateInvoice(_invoice);
                        if (resultCreate != null && !string.IsNullOrWhiteSpace(resultCreate.MessageText))
                        {
                            MessageBox.Show(resultCreate.MessageText);
                            txtBoxInvoiceNo.Text = resultCreate.InvoiceNo;
                            btnPrint.Enabled = true;
                            //  ClearControl();
                        }
                        else
                        {
                            // lblStatus.Visible = false;
                        }
                    }
                    else
                    {
                        _invoice.InvoiceNo = invoiceNo;
                        var resultUpdate = _objInvoice.UpdateInvoice(_invoice);
                        if (resultUpdate != null && !string.IsNullOrWhiteSpace(resultUpdate.MessageText))
                        {
                            MessageBox.Show(resultUpdate.MessageText);
                            txtBoxInvoiceNo.Text = resultUpdate.InvoiceNo;
                            btnPrint.Enabled = true;
                            //  ClearControl();
                        }
                        else
                        {
                            // lblStatus.Visible = false;
                        }
                    }


                }
                else
                {
                    //MessageBox.Show(item.Info);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private ValidInvoice ValidateInvoice()
        {
            ValidInvoice _obj = new ValidInvoice();
            try
            {
                //Check Party Name
                if (cmbPartyName.SelectedIndex == 0)
                {
                    _obj.IsValid = false;
                    _obj.Info = "Please select Party to create invoice";
                    return _obj;
                }
                //Check Bank 
                if (Convert.ToInt32(cmbboxBanks.SelectedValue) == 0)
                {
                    _obj.IsValid = false;
                    _obj.Info = "Please select bank to create invoice";
                    return _obj;
                }
                //Check currency Name
                if (Convert.ToInt32(cmbBoxCurrency.SelectedValue) == 0)
                {
                    _obj.IsValid = false;
                    _obj.Info = "Please select currency to create invoice";
                    return _obj;
                }
                //Check currency Name
                if (Convert.ToInt32(cmbBoxUnit.SelectedValue) == 0)
                {
                    _obj.IsValid = false;
                    _obj.Info = "Please select unit to create invoice";
                    return _obj;
                }
                //Check item count
                if (dtorder.Rows.Count < 1)
                {
                    _obj.IsValid = false;
                    _obj.Info = "Please add item before create invoice";
                    return _obj;
                }

                if (!rdbtnCIF.Checked && !rdbtnCNF.Checked && !rdbtnFOB.Checked)
                {
                    _obj.IsValid = false;
                    _obj.Info = "Please at least one delivery term before create invoice";
                    return _obj;

                }
            }
            catch (Exception)
            {

                throw;
            }
            return new ValidInvoice() { IsValid = true, Info = string.Empty };
        }

        private void BindOrderDetails(string invoiceno)
        {
            try
            {
                DAL_Invoices _objInvoice = new DAL_Invoices();
                var invoice = _objInvoice.GetInvoiceByNo(new Invoice_RQ() { InvoiceNo = invoiceno });
                if (invoice != null)
                {
                    btnPrint.Enabled = true;
                    int seq = 1;
                    dtorder.Rows.Clear();
                    foreach (var item in invoice._objOrderItem)
                    {
                        DataRow dr = dtorder.NewRow();
                        dr["invoiceOrderItemId"] = item.InvoiceItemID;
                        dr["ArtId"] = item.ArtNo;
                        dr["ArtNo"] = item.ArtNo;
                        dr["Desc"] = item.ArtDesc;
                        // dr["WorkOrderDesc"] = item.WorkOrderDesc;
                        dr["RefillsLink"] = item.RefileInk;
                        dr["Rate"] = item.Rate;
                        dr["Qty"] = item.Quantity;
                        dr["Amount"] = item.Amount;
                        dr["Sequence"] = seq++;
                        dtorder.Rows.Add(dr);
                    }
                    FillOrderItemGrid();
                    cmbPartyName.SelectedValue = invoice.PartyNo;
                    SetPartyMasterAddress(invoice.PartyNo);
                    //Fill Order Details
                    FillBankDetails();
                    cmbboxBanks.SelectedValue = Convert.ToInt32(invoice.BankId);
                    InvoiceDate.Text = Convert.ToString(invoice.InvoiceDate);
                    cmbBoxCurrency.SelectedIndex = cmbBoxCurrency.FindString(invoice.InvoiceCurrency);
                    cmbBoxUnit.SelectedIndex = cmbBoxUnit.FindString(invoice.Unit);
                    lblGrandAmout.Text = Convert.ToString(invoice.InvoiceGrandAmt);
                    lblGrandQty.Text = Convert.ToString(invoice.InvoiceGrandQty);
                    //Delivery Term
                    if (invoice.DeliveryTerms != null)
                    {
                        if (invoice.DeliveryTerms == "CIF")
                            rdbtnCIF.Checked = true;
                        if (invoice.DeliveryTerms == "CNF")
                            rdbtnCNF.Checked = true;
                        if (invoice.DeliveryTerms == "FOB")
                            rdbtnFOB.Checked = true;
                    }
                    if (!string.IsNullOrWhiteSpace(invoice.DeliveryType))
                        cmbDeliveryBy.SelectedValue = Convert.ToString(invoice.DeliveryType);
                    txtPort.Text = invoice.Port;
                    if (!string.IsNullOrWhiteSpace(invoice.PartialShip))
                        cmbPartialShip.SelectedValue = Convert.ToString(invoice.PartialShip);
                    if (!string.IsNullOrWhiteSpace(invoice.TransShipment))
                        cmbTransShipment.SelectedValue = Convert.ToString(invoice.TransShipment);

                    txtRemark.Text = invoice.Remark;
                    txtPaymentTerms.Text = invoice.PaymentTerms;
                    txtDeliveryPeriod.Text = invoice.DeliveryTerms;
                    btnCreate.Text = "Update";

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //private void SetCheckBox(string strcheckboxname)
        //{
        //    rdbtnCIF.Checked = !rdbtnCIF.Checked;
        //    if (rdbtnCIF.Checked)
        //    {
        //        rdbtnCNF.Checked = false;
        //        rdbtnFOB.Checked = false;
        //    }
        //}

        private void grdvOrderItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.grdvOrderItem.Columns["Delete"].Index)
            {
                DialogResult result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    RemoveItemOrderDetails(Convert.ToString(grdvOrderItem["ArtNo", e.RowIndex].Value), Convert.ToString(grdvOrderItem["RefillsLink", e.RowIndex].Value));
                }
                else
                {
                }

            }
        }
        private void grdvOrderItem_CellEditEnd(object sender, DataGridViewCellEventArgs e)
        {
            // My combobox column is the second one so I hard coded a 1, flavor to taste
            if (e.ColumnIndex == this.grdvOrderItem.Columns["Qty"].Index || e.ColumnIndex == this.grdvOrderItem.Columns["Rate"].Index)
            {
                var qty = Convert.ToDouble(this.grdvOrderItem.Rows[e.RowIndex].Cells["Qty"].Value);
                var rate = Convert.ToDouble(this.grdvOrderItem.Rows[e.RowIndex].Cells["Rate"].Value);
                var Sequence = Convert.ToString(this.grdvOrderItem.Rows[e.RowIndex].Cells["Sequence"].Value);

                var TotalAmount = Convert.ToDouble(qty * rate);
                //this.grdvOrderItem.Rows[e.RowIndex].Cells["Amount"].Value = TotalAmount;

                // Get all DataRows where the name is the name you want.
                IEnumerable<DataRow> rows = dtorder.Rows.Cast<DataRow>().Where(r => r["Sequence"].ToString() == Sequence);
                // Loop through the rows and change the name.
                rows.ToList().ForEach(r => r.SetField("Qty", qty));
                rows.ToList().ForEach(r => r.SetField("Rate", rate));
                rows.ToList().ForEach(r => r.SetField("Amount", TotalAmount));

                FillOrderItemGrid();

                //foreach (var item in dtorder.Rows)
                //{
                //    if(Convert.ToString(((System.Data.DataRow)item).ItemArray[9]) == Sequence)
                //    {
                //        ((System.Data.DataRow)item).ItemArray[6] = qty;
                //        ((System.Data.DataRow)item).ItemArray[7] = rate;
                //        ((System.Data.DataRow)item).ItemArray[8] = TotalAmount;

                //    }
                //}
                //dtorder.AcceptChanges();
                CalculateGrandTotal();

            }

        }
        private void RemoveItemOrderDetails(string artNo, string RefillsLink)
        {
            string searchExpression = "ArtNo = '" + artNo + "' AND RefillsLink= '" + RefillsLink + "'";
            DataRow[] foundRows = dtorder.Select(searchExpression);
            foreach (DataRow dr in foundRows)
            {
                dtorder.Rows.Remove(dr);
            }
            FillOrderItemGrid();
            CalculateGrandTotal();
        }
        private void cmbPartyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPartyName_SelectionChangeCommitted(sender, e);
        }

        private void cmbBoxArtNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBoxArtNo_SelectionChangeCommitted(sender, e);
        }
        public void FindInvoice(string invoiceno)
        {
            if (!string.IsNullOrWhiteSpace(invoiceno))
                BindOrderDetails(invoiceno);
            else
                MessageBox.Show("Please enter invoice no to find !!");
        }
        private void jbtnFind_Click(object sender, EventArgs e)
        {
            FindInvoice(txtBoxInvoiceNo.Text);
        }

        private void jbtnAdd_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddItemDetails();
            }
        }

        private void jbtnAdd_Click(object sender, EventArgs e)
        {
            AddItemDetails();

        }

        private void AddItemDetails()
        {
            //Check Duplicate Item in Order
            if (!string.IsNullOrWhiteSpace(lblArtId.Text) && !string.IsNullOrWhiteSpace(txtboxQty.Text))
            {
                //string expression = " ArtId = '" + Convert.ToInt32(lblArtId.Text) + "'";
                //if (dtorder.Select(expression).Count() > 0)
                //{
                //    MessageBox.Show("Selected Item is already added in order !!");
                //    return;
                //}
                if (cmbboxToAddRefileInk.SelectedIndex == 0)
                {
                    MessageBox.Show("Please select refile Ink before adding item !!");
                    return;
                }
                int seq = Convert.ToInt32(dtorder.AsEnumerable().Max(row => row["Sequence"]));
                if (dtorder != null)
                {

                    DataRow dr = dtorder.NewRow();
                    dr["invoiceOrderItemId"] = Guid.NewGuid();
                    dr["ArtId"] = lblArtId.Text;
                    dr["ArtNo"] = lblArtNoData.Text;
                    dr["Desc"] = txtArtDesc.Text;
                    // dr["WorkOrderDesc"] = txtBoxWorkOrderDesc.Text;
                    dr["RefillsLink"] = ((Models.RefillInk)cmbboxToAddRefileInk.SelectedItem).RefillInkColor;
                    dr["Rate"] = txtboxRate.Text;
                    dr["Qty"] = txtboxQty.Text;
                    dr["Amount"] = lblAmout.Text;
                    dr["Sequence"] = seq + 1;
                    dtorder.Rows.Add(dr);
                    CalculateGrandTotal();
                    //AddCalculatedDataInDataTable();
                    if (FillOrderItemGrid())
                    {
                        ClearAddItemControls();
                        this.ActiveControl = cmbBoxArtNo;
                    }
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtboxQty.Text))
                {
                    MessageBox.Show("Please enter item quantity !!");
                    return;
                }
                MessageBox.Show("Please select item to add !!");
                return;
            }
        }
    }
    public class ValidInvoice
    {
        public bool IsValid { get; set; }

        public string Info { get; set; }
    }
    public class DeliveryByClass
    {
        public string DeliveryID { get; set; }
        public string DeliveryBy { get; set; }

    }
    public class PartialShipClass
    {
        public string PartialShipID { get; set; }
        public string PartialShip { get; set; }

    }
    public class TransShipmentClass
    {
        public string TransShipmentID { get; set; }
        public string TransShipment { get; set; }

    }
}
