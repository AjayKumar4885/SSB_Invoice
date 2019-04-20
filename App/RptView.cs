using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Reporting.WinForms;
using ConvertNumberToWord;
using App.ClassLibrary;
using System.Globalization;
using System.Threading;
//using System.Web.UI.WebControls;
//using App.Report;

namespace App
{
    public partial class RptView : Form
    {
        public RptView()
        {
            InitializeComponent();
        }
        private void RptView_Load(object sender, EventArgs e)
        {
            LoadreportoneDs();
        }

        //for single dataset 

        private void LoadreportoneDs()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-IN");
            DataColumn dcol = new DataColumn();
            DataSet dsCustomers = GetDataOne();
            dcol = dsCustomers.Tables[0].Columns[6];
            string numinword;
            numinword = dsCustomers.Tables[0].Compute("Sum(Amount)", "").ToString();
            #region Currency 
            string strCurrency = Convert.ToString(dsCustomers.Tables[0].Rows[0]["InvoiceCurrency"]);
            string currency = string.Empty;
            if (!string.IsNullOrWhiteSpace(strCurrency))
            {
                if (strCurrency.ToUpper() == "US $")
                    currency = "Cent ";
                else if (strCurrency.ToUpper() == "INR ₹")
                    currency = "Paisa ";
                else if (strCurrency.ToUpper() == "Euro €")
                    currency = "Cent ";
            }
            #endregion
            string NuminWords = CurrencyToWord.ConvertNumberToWords(Convert.ToString(numinword), currency);
            dsCustomers.Tables[0].Columns.Add(new DataColumn("TotWordAmount", typeof(string)));
            DataColumn newCol = new DataColumn("TotWordAmount", typeof(string));
            newCol.AllowDBNull = true;
            foreach (DataRow row in dsCustomers.Tables[0].Rows)
            {
                row["TotWordAmount"] = NuminWords;
            }

            this.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource datasource = new ReportDataSource("DataSet1", dsCustomers.Tables[0]);

            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            //  this.bindingSource1.DataSource = rds;
            this.reportViewer1.RefreshReport();
        }

        private DataSet GetDataOne()
        {


            String constr = Convert.ToString(ConfigurationManager.AppSettings["RptConnection"]);

            //string constr = @"Data Source=.\Sql2005;Initial Catalog=Northwind;Integrated Security = true";
            using (SqlConnection con = new SqlConnection(constr))
            {
                //  using (SqlCommand cmd = new SqlCommand("SELECT [InvoiceItemID] ,[InvoiceNo],[ArtNo],[ArtDesc],[WorkOrderDesc],[RefileInk],[Rate],[Quantity],[Amount] from tbl_InvoiceItemDetails where InvoiceNo= 'SSB-" + txthiddenInvoiceNum.Text + "'"))
                // {
                using (SqlCommand cmd = new SqlCommand(@"select invdtl.InvoiceNo,UPPER(invdtl.ArtNo) As ArtNo,UPPER( invdtl.ArtDesc) As ArtDesc, UPPER('REFILL INK : ' +   invdtl.RefileInk) as RefileInk, invdtl.Rate, invdtl.Quantity, invdtl.Amount ,
                                                              Ptm.PartyName, ptm.Address, invc.CreatedOn, invc.InvoiceGrandAmt, invc.DeliveryTerms, invc.InvoiceCurrency, invc.PaymentTerms, invc.TransShipment,
                                                            invc.PartialShip, invc.Port, UPPER(invc.DeliveryType) As DeliveryType, invc.Unit from tblInvoice invc
                                                            join tblPartyMaster ptm on invc.PartyNo = ptm.PartyCode
                                                                join tbl_InvoiceItemDetails invdtl on invdtl.InvoiceNo = invc.InvoiceNo
                                                            where invc.InvoiceNo = '" + txthiddenInvoiceNum.Text + "'"))
                {

                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        DataSet ds = new DataSet();

                        using (CustomInvoiceds dsCustomers = new CustomInvoiceds())
                        {
                            sda.Fill(ds);
                            return ds;
                        }
                    }
                }
            }
        }

        private void LoadreporttwoDs()
        {



            //  DataRow drow = new DataRow();
            DataColumn dcol = new DataColumn();
            DataSet dsCustomers = new DataSet();
            DataTable dtInvoice = new DataTable();
            dtInvoice = GetDataItem().Tables[0].Copy();
            dtInvoice.TableName = "table1";
            dsCustomers.Tables.Add(dtInvoice);

            DataTable dtInvoiceDetails = new DataTable();
            dtInvoiceDetails = GetDataItemDetails().Tables[0].Copy();
            dtInvoiceDetails.TableName = "table2";
            dsCustomers.Tables.Add(dtInvoiceDetails);

            //foreach () ;
            dsCustomers.Tables[0].Columns.Add(new DataColumn("TotWordAmount", typeof(string)));
            DataColumn newCol = new DataColumn("TotWordAmount", typeof(string));
            newCol.AllowDBNull = true;
            foreach (DataRow row in dsCustomers.Tables[0].Rows)
            {
                row["TotWordAmount"] = ConvertNumberToWord.NumberToWord.Num2Word(Convert.ToString(dsCustomers.Tables[0].Rows[0]["InvoiceGrandAmt"]));
            }

            this.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource datasource = new ReportDataSource("DataSet1", dtInvoice);
            ReportDataSource datasource1 = new ReportDataSource("DataSet2", dtInvoiceDetails);
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.LocalReport.DataSources.Add(datasource1);

            this.reportViewer1.RefreshReport();
        }

        private void btnViewRpt_Click(object sender, EventArgs e)
        {
            //  DataSet  dsCustomers = GetData();
            //  this.reportViewer1.LocalReport.DataSources.Clear();
            //  ReportDataSource datasource = new ReportDataSource("DataSet1", dsCustomers.Tables[0]);

            //  this.reportViewer1.LocalReport.DataSources.Add(datasource);
            ////  this.bindingSource1.DataSource = rds;
            //  this.reportViewer1.RefreshReport();

        }

        private DataSet GetDataItem()
        {
            String constr = Convert.ToString(ConfigurationManager.AppSettings["RptConnection"]);

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(@"select Invc.InvoiceNo,Ptm.PartyName,ptm.Address,invc.CreatedOn,invc.InvoiceGrandAmt,invc.DeliveryTerms,invc.InvoiceCurrency,invc.PaymentTerms,invc.TransShipment,
                                                            invc.PartialShip, invc.Port, invc.DeliveryType, invc.Unit from tblInvoice invc
                                                            join tblPartyMaster ptm on invc.PartyNo = ptm.PartyCode
                                                            where invc.InvoiceNo = '" + txthiddenInvoiceNum.Text + "'"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        DataSet ds = new DataSet();

                        using (PerformaInvoice dsCustomers = new PerformaInvoice())
                        {
                            sda.Fill(ds);
                            return ds;
                        }
                    }
                }
            }
        }
        private DataSet GetDataItemDetails()
        {
            String constr = Convert.ToString(ConfigurationManager.AppSettings["RptConnection"]);

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select ArtNo,UPPER(ArtDesc) As ArtDesc, UPPER('REFILL INK : ' +  RefileInk) as RefileInk,Rate,Quantity,Amount from tbl_InvoiceItemDetails where InvoiceNo = '" + txthiddenInvoiceNum.Text + "'"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        DataSet ds = new DataSet();

                        using (PerformaInvoice dsCustomers = new PerformaInvoice())
                        {
                            sda.Fill(ds);
                            return ds;
                        }
                    }
                }
            }
        }


        private void btn_pdfview_Click(object sender, EventArgs e)
        {


        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
